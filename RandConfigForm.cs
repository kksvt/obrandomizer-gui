using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.Globalization;

namespace obrandomizer_gui
{
    public partial class RandConfigForm : Form
    {

        public RandConfigForm()
        {
            InitializeComponent();
        }

        private static string DecimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        private static bool StringToBool(string s)
        {
            //todo: consider throwing an exception for invalid return paths
            bool result;
            int number;
            if (s == null)
            {
                return false;
            }

            if (Boolean.TryParse(s, out result))
            {
                return result;
            }

            if (int.TryParse(s, out number))
            {
                return (number != 0);
            }

            if (s.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (s.Equals("no", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            return false;
        }

        private static bool StringIntToThreeRadioBoxes(string value,
            RadioButton zero, RadioButton one, RadioButton two)
        {
            bool success = false;

            if (Int32.TryParse(value, out int n))
            {
                success = true;
            }
            else
            {
                n = 0;
            }

            switch (n)
            {
                case 0:
                    one.Checked = two.Checked = !(zero.Checked = true);
                    break;
                case 1:
                    two.Checked = zero.Checked = !(one.Checked = true);
                    break;
                default:
                    zero.Checked = one.Checked = !(two.Checked = true);
                    break;

            }

            return success;
        }

        private void checkActorScaling_CheckedChanged(object sender, EventArgs e)
        {
            panelActorScaling.Enabled = checkActorScaling.Checked;
        }

        private void radioRestoreActorAttribYes_CheckedChanged(object sender, EventArgs e)
        {
            groupNPCRandomizeStats.Enabled = groupNPCRandomizeAttributes.Enabled = !radioRestoreActorAttribYes.Checked;
        }

        private void buttonRandSeed_Click(object sender, EventArgs e)
        {
            byte[] randomSeed = new byte[4];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomSeed);
            }
            textBoxMiscSeed.Text = BitConverter.ToUInt32(randomSeed, 0).ToString();
        }

        private void LoadSettings(string fileName) //i hate pretty much everything about this method
        {
            try
            {
                IConfiguration config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddIniFile(fileName, optional: false)
                        .Build();
                int n;
                double d;
                var invalidParses = new List<string>();
                /*
                [Misc]
                oSeed=
                oExcludeQuestItems=yes
                oDelayStart=no
                oInstallCrashFix=0
                oHitEffect=20
                oRandSpells=1*/
                IConfigurationSection section = config.GetSection("Misc");
                textBoxMiscSeed.Text = section["oSeed"];
                checkSaveSeedData.Checked = StringToBool(section["oSaveSeedData"]);
                radioExcludeQuestNo.Checked = !(radioExcludeQuestYes.Checked = StringToBool(section["oExcludeQuestItems"]));
                radioDelayStartNo.Checked = !(radioDelayStartYes.Checked = StringToBool(section["oDelayStart"]));
                if (Int32.TryParse(section["oInstallCrashFix"], out n))
                {
                    checkInvalidTexturePatch.Checked = ((n & 1) == 1);
                    checkInvalidCreatureDataPatch.Checked = ((n & 2) == 2);
                }
                else
                {
                    invalidParses.Add("oInstallCrashFix");
                    checkInvalidTexturePatch.Checked = checkInvalidCreatureDataPatch.Checked = false;
                }

                if (Int32.TryParse(section["oHitEffect"], out n))
                {
                    numericHitEffect.Value = n;
                }
                else
                {
                    invalidParses.Add("oHitEffect");
                    numericHitEffect.Value = 20;
                }

                if (!StringIntToThreeRadioBoxes(section["oRandSpells"],
                    radioSpellsDisabled, radioSpells1, radioSpells2))
                {
                    invalidParses.Add("oRandSpells");
                }


                /*[Loot]
                oRandInventory=1
                oRandContainers=1
                oWorldItems=1
                oAddItems=1
                oDeathItems=1
                oRandGold=0
                oExcludeUnplayableItems=1*/
                section = config.GetSection("Loot");

                if (!StringIntToThreeRadioBoxes(section["oRandInventory"],
                    radioRandActorInventoryDisabled,
                    radioRandActorInventoryEnabled,
                    radioRandActorInventoryAggressive))
                {
                    invalidParses.Add("oRandInventory");
                }

                if (!StringIntToThreeRadioBoxes(section["oRandContainers"],
                    radioRandChestInventoryDisabled,
                    radioRandChestInventoryEnabled,
                    radioRandChestInventoryAggressive))
                {
                    invalidParses.Add("oRandContainers");
                }

                if (!StringIntToThreeRadioBoxes(section["oWorldItems"],
                    radioWorldItemDisabled,
                    radioWorldItemEnabled,
                    radioWorldItemAggressive))
                {
                    invalidParses.Add("oWorldItems");
                }

                if (!StringIntToThreeRadioBoxes(section["oAddItems"],
                    radioAddItemDisabled,
                    radioAddItemEnabled,
                    radioAddItemAggressive))
                {
                    invalidParses.Add("oAddItems");
                }

                if (!StringIntToThreeRadioBoxes(section["oDeathItems"],
                    radioDeathItemDisabled,
                    radioDeathItemEnabled,
                    radioDeathItemAggressive))
                {
                    invalidParses.Add("oDeathItems");
                }

                radioLootRandGoldNo.Checked = !(radioLootRandGoldYes.Checked = StringToBool(section["oRandGold"]));
                radioLootExcludeUnplayableNo.Checked = !(radioLootExcludeUnplayableYes.Checked = StringToBool(section["oExcludeUnplayableItems"]));
                /*[Actor]
                oRandomizeAttrib=1
                oRestoreBaseAttributes=0
                oVampire=10
                oScaleActors=0
                oScaleMin=0.7
                oScaleMax=1.5*/
                section = config.GetSection("Actor");

                if (!StringIntToThreeRadioBoxes(section["oRandomizeAttrib"],
                    radioAttribDisabled,
                    radioAttribNonEssential,
                    radioAttribAll))
                {
                    invalidParses.Add("oRandomizeAttrib");
                }

                if (!StringIntToThreeRadioBoxes(section["oRandomizeStats"],
                    radioStatDisabled,
                    radioStatNonEssential,
                    radioStatAll))
                {
                    invalidParses.Add("oRandomizeStats");
                }

                radioRestoreActorAttribNo.Checked = !(radioRestoreActorAttribYes.Checked = StringToBool(section["oRestoreBaseAttributes"]));

                if (Int32.TryParse(section["oVampire"], out n))
                {
                    numericVampire.Value = n;
                }
                else
                {
                    invalidParses.Add("oVampire");
                    numericVampire.Value = 10;
                }

                checkActorScaling.Checked = StringToBool(section["oScaleActors"]);
                if (!Double.TryParse(section["oScaleMin"], out d))
                {
                    if (!Double.TryParse(section["oScaleMin"].Replace(".", DecimalSeparator), out d))
                    {
                        invalidParses.Add("oScaleMin");
                        textActorScalingMin.Text = $"{0.7}";
                    }
                    else
                    {
                        textActorScalingMin.Text = $"{d}";
                    }
                }
                else
                {
                    textActorScalingMin.Text = $"{d}";
                }
                if (!Double.TryParse(section["oScaleMax"], out d))
                {
                    if (!Double.TryParse(section["oScaleMax"].Replace(".", DecimalSeparator), out d))
                    {
                        invalidParses.Add("oScaleMax");
                        textActorScalingMax.Text = $"{1.5}";
                    }
                    else
                    {
                        textActorScalingMax.Text = $"{d}";
                    }
                }
                else
                {
                    textActorScalingMax.Text = $"{d}";
                }

                /*[Creatures]
                oRandCreatures=1
                oUseEssentialCreatures=0
                oSkipHorses=1  */
                section = config.GetSection("Creatures");
                if (!StringIntToThreeRadioBoxes(section["oRandCreatures"],
                    radioRandCreaturesDisabled,
                    radioRandCreaturesEnabled,
                    radioRandCreaturesUnstable))
                {
                    invalidParses.Add("oRandCreatures");
                }

                radioUseEssentialCreaturesNo.Checked = !(radioUseEssentialCreaturesYes.Checked = StringToBool(section["oUseEssentialCreatures"]));
                radioExcludeHorsesNo.Checked = !(radioExcludeHorsesYes.Checked = StringToBool(section["oSkipHorses"]));

                if (invalidParses.Count > 0)
                {
                    string errorMsg = "Could not parse the following settings:";
                    foreach (var msg in invalidParses)
                    {
                        errorMsg += $"\r\n{msg}";
                    }
                    MessageBox.Show(errorMsg, "Config parsing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                labelLastLoaded.Text = $"Currently loaded file: {fileName}";
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"Config file {fileName} not found. Make sure the GUI application " +
                    "is in your Oblivion directory and the config is in your Oblivion/Data directory.",
                    "Config not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not parse config file {fileName}. Exception message: {ex}",
                    "Invalid config",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void SaveSettings(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (var output = new StreamWriter(fileName))
            {
                byte flags = 0;
                //Misc
                output.WriteLine("[Misc]");
                output.WriteLine("oSeed=" + textBoxMiscSeed.Text);
                if (checkSaveSeedData.Checked)
                {
                    output.WriteLine("oSaveSeedData=1");
                }
                else
                {
                    output.WriteLine("oSaveSeedData=0");
                }
                output.WriteLine("oExcludeQuestItems=" + (radioExcludeQuestYes.Checked ? "1" : "0"));
                output.WriteLine("oDelayStart=" + (radioDelayStartYes.Checked ? "1" : "0"));
                if (checkInvalidTexturePatch.Checked)
                {
                    flags |= 1;
                }
                if (checkInvalidCreatureDataPatch.Checked)
                {
                    flags |= 2;
                }
                output.WriteLine("oInstallCrashFix=" + flags);
                output.WriteLine("oHitEffect=" + numericHitEffect.Value);
                if (radioSpellsDisabled.Checked)
                {
                    output.WriteLine("oRandSpells=0");
                }
                else if (radioSpells1.Checked)
                {
                    output.WriteLine("oRandSpells=1");
                }
                else //if (radioSpells2.Checked)
                {
                    output.WriteLine("oRandSpells=2");
                }
                //Loot
                output.WriteLine("\n[Loot]");
                //actors
                if (radioRandActorInventoryDisabled.Checked)
                {
                    output.WriteLine("oRandInventory=0");
                }
                else if (radioRandActorInventoryEnabled.Checked)
                {
                    output.WriteLine("oRandInventory=1");
                }
                else //if (radioRandActorInventoryAggressive.Checked)
                {
                    output.WriteLine("oRandInventory=2");
                }
                //containers
                if (radioRandChestInventoryDisabled.Checked)
                {
                    output.WriteLine("oRandContainers=0");
                }
                else if (radioRandChestInventoryEnabled.Checked)
                {
                    output.WriteLine("oRandContainers=1");
                }
                else //if (radioRandChestInventoryAggressive.Checked)
                {
                    output.WriteLine("oRandContainers=2");
                }
                //world items
                if (radioWorldItemDisabled.Checked)
                {
                    output.WriteLine("oWorldItems=0");
                }
                else if (radioWorldItemEnabled.Checked)
                {
                    output.WriteLine("oWorldItems=1");
                }
                else //if (radioWorldItemAggressive.Checked)
                {
                    output.WriteLine("oWorldItems=2");
                }
                //add items
                if (radioAddItemDisabled.Checked)
                {
                    output.WriteLine("oAddItems=0");
                }
                else if (radioAddItemEnabled.Checked)
                {
                    output.WriteLine("oAddItems=1");
                }
                else //if (radioAddItemAggressive.Checked)
                {
                    output.WriteLine("oAddItems=2");
                }
                //death items
                if (radioDeathItemDisabled.Checked)
                {
                    output.WriteLine("oDeathItems=0");
                }
                else if (radioDeathItemEnabled.Checked)
                {
                    output.WriteLine("oDeathItems=1");
                }
                else //if (radioDeathItemAggressive.Checked)
                {
                    output.WriteLine("oDeathItems=2");
                }
                //gold
                output.WriteLine("oRandGold=" + (radioLootRandGoldYes.Checked ? "1" : "0"));
                //unplayable items
                output.WriteLine("oExcludeUnplayableItems=" + (radioLootExcludeUnplayableYes.Checked ? "1" : "0"));
                //Actor params
                output.WriteLine("\n[Actor]");
                //attributes
                //this is ugly
                //output.WriteLine("oRandomizeAttrib=" + (radioAttribDisabled.Checked || radioRestoreActorAttribYes.Checked ? "0" : "1"));
                //output.WriteLine("oRandomizeAttribEssential=" + (radioAttribAll.Checked && radioRestoreActorAttribNo.Checked ? "1" : "0"));
                if (radioAttribAll.Checked)
                {
                    output.WriteLine("oRandomizeAttrib=2");
                }
                else if (radioAttribNonEssential.Checked)
                {
                    output.WriteLine("oRandomizeAttrib=1");
                }
                else
                {
                    output.WriteLine("oRandomizeAttrib=0");
                }

                if (radioStatAll.Checked)
                {
                    output.WriteLine("oRandomizeStats=2");
                }
                else if (radioStatNonEssential.Checked)
                {
                    output.WriteLine("oRandomizeStats=1");
                }
                else
                {
                    output.WriteLine("oRandomizeStats=0");
                }
                //restore attributes
                output.WriteLine("oRestoreBaseAttributes=" + (radioRestoreActorAttribYes.Checked ? "1" : "0"));
                //vampirism
                output.WriteLine("oVampire=" + numericVampire.Value);
                //scaling
                output.WriteLine("oScaleActors=" + (checkActorScaling.Checked ? "1" : "0"));
                output.WriteLine("oScaleMin=" + textActorScalingMin.Text.Replace(DecimalSeparator, "."));
                output.WriteLine("oScaleMax=" + textActorScalingMax.Text.Replace(DecimalSeparator, "."));
                //Creatures
                output.WriteLine("\n[Creatures]");
                //randomization
                if (radioRandCreaturesDisabled.Checked)
                {
                    output.WriteLine("oRandCreatures=0");
                }
                else if (radioRandCreaturesEnabled.Checked)
                {
                    output.WriteLine("oRandCreatures=1");
                }
                else// if (radioRandCreaturesUnstable.Checked)
                {
                    output.WriteLine("oRandCreatures=2");
                }
                //use essential
                output.WriteLine("oUseEssentialCreatures=" + (radioUseEssentialCreaturesYes.Checked ? "1" : "0"));
                //exclude horses
                output.WriteLine("oSkipHorses=" + (radioExcludeHorsesYes.Checked ? "1" : "0"));
            }
        }

        private void LoadTemplates()
        {
            comboTemplates.Items.Clear();
            try
            {
                if (!Directory.Exists("obrn-configs"))
                {
                    Directory.CreateDirectory("obrn-configs");
                }
                else
                {
                    DirectoryInfo d = new DirectoryInfo($"{Directory.GetCurrentDirectory()}/obrn-configs");
                    foreach (var template in d.GetFiles("*.cfg"))
                    {
                        comboTemplates.Items.Add($"{template.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                buttonDeleteTemplate.Enabled = buttonSaveTemplate.Enabled = buttonLoadTemplate.Enabled =
                    comboTemplates.Enabled = false;
                MessageBox.Show($"Could not read template files. Exception: {ex}", "Error reading templates",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMods()
        {
            try
            {
                if (Directory.Exists("Data"))
                {
                    DirectoryInfo d = new DirectoryInfo($"{Directory.GetCurrentDirectory()}/Data");
                    foreach (var mod in d.GetFiles("*.esm").Union(d.GetFiles("*.esp")))
                    {
                        listMods.Items.Add(mod.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                buttonDeleteTemplate.Enabled = buttonSaveTemplate.Enabled = buttonLoadTemplate.Enabled =
                    comboTemplates.Enabled = false;
                MessageBox.Show($"Could not read template files. Exception: {ex}", "Error reading templates",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExcludes(string fileName)
        {
            TextBox current = null;
            textBoxDontAddToLists.Clear();
            textBoxDontRandomize.Clear();
            try
            {
                foreach (var line in File.ReadLines(fileName))
                {
                    if (line.Length == 0)
                    {
                        continue;
                    }

                    if (line.Equals("[DON'T ADD TO LISTS]"))
                    {
                        current = textBoxDontAddToLists;
                        continue;
                    }

                    if (line.Equals("[DON'T RANDOMIZE]"))
                    {
                        current = textBoxDontRandomize;
                        continue;
                    }

                    if (current == null)
                    {
                        throw new FormatException("Mod name outside of a section");
                    }

                    addItemToTextBox(current, line);
                }
            }
            catch (Exception ex) when (ex is FileNotFoundException || ex is DirectoryNotFoundException)
            {
                MessageBox.Show($"Config file {fileName} not found. Make sure the GUI application " +
                    "is in your Oblivion directory and the config is in your Oblivion/Data directory.",
                    "Config not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not parse config file {fileName}. Exception message: {ex}",
                    "Invalid config",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SaveExcludes(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (var output = new StreamWriter(fileName))
            {
                output.WriteLine("[DON'T ADD TO LISTS]");
                output.WriteLine(textBoxDontAddToLists.Text);
                output.WriteLine();
                output.WriteLine("[DON'T RANDOMIZE]");
                output.WriteLine(textBoxDontRandomize.Text);
            }
        }

        private void groupMiscSeed_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "Since the information about the randomization of world items, non-leveled list creatures " +
                "and spells is not stored in the save file, they will get re-randomized every time you launch the game.\r\n\r\n" +
                "Due to how Oblivion handles constructing references, a fixed seed may not always yield the same randomizations, " +
                "but it should provide a more consistent experience nonetheless.\r\n\r\n" +
                "Leave the field empty if you want the game to generate a new random seed every launch.\r\n\r\n" +
                "Save seed data - if the seed is not empty and this option is enabled, then creature & world item randomization data " +
                "will be saved to Oblivion/obrn-seed-data/<seed value>.bin. While it guarantees creatures and world items to be " +
                "randomized into the same objects every time you restart the game, you should keep in mind that this is an " +
                "experimental feature.";
        }

        private void groupMiscQuestObjects_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the inclusion of quest and scripted items in the randomizer's lists.\r\n\r\n" +
                "Picking up quest items often prompts the game to update the status of the associated quest, " +
                "resulting in strange effects and possibly being locked out of proper progression within that questline.\r\n\r\n" +
                "Excluding quest items means that no item can be randomized into a quest item, allowing you to progress quests " +
                "without having to worry about them breaking.";
        }

        private void groupMiscDelayStart_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "If this setting is enabled, then inventory and attribute randomization will not kick in " +
                "until the first ambush in the tutorial (Charactergen reaches stage 20).";
        }

        private void groupMiscPatches_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls whether various anti-crash patches are enabled. Should you find " +
                "that your save crashes every time you load it, enable either of these settings (or both) and see " +
                "if that helps.";
        }

        private void groupMiscHitEffect_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "The chance for each hit to apply one of the following random effects:\r\n" +
                "- fire,\r\n- frost,\r\n- shock,\r\n- demoralize,\r\n- burden,\r\n- frenzy,\r\n- paralysis,\r\n- push,\r\n- heal," +
                "\r\n- disintegrate,\r\n- drain fatigue";
        }

        private void groupMiscSpells_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "Spell randomization setting.\r\n\r\n- Disabled - don't enable spell randomization,\r\n\r\n" +
                "- Randomize spell, but not school - every spell will get randomized into a spell of the same school (for example " +
                "Flare may get randomized into Fire Storm, but never into Paralyze),\r\n\r\n- Total randomization - every spell may " +
                " get randomized into any spell, regardless of the school.";
        }

        private void groupLootRandActorInventory_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of actors' inventories.\r\n\r\n- Disabled - don't randomize,\r\n\r\n" +
                "- Enabled, normal - every item in an NPC's inventory will get randomized into an item of the same type (for example a helmet " +
                "may only get randomized into another helmet),\r\n\r\n- Enabled, aggressive - will grant NPCs a lot of random items, regardless " +
                "of their pre-randomized inventory.";
        }

        private void groupLootRandChestInventory_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of containers' inventories.\r\n\r\n- Disabled - don't randomize,\r\n\r\n" +
                "- Enabled, normal - every item in a container's inventory will get randomized into an item of the same type (for example a helmet " +
                "may only get randomized into another helmet),\r\n\r\n- Enabled, aggressive - will grant containers a lot of random items, regardless " +
                "of their pre-randomized inventory.";
        }

        private void groupLootWorldItem_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of items freely spawned in the world (such as a bowl lying on a table). Note that " +
                "world item randomization is not stored in your save file, so use a fixed seed if you wish for them to be randomized into the same items every time." +
                "\r\n\r\n- Disabled - don't randomize,\r\n\r\n- Enabled, normal - every item will get randomized into an item of the same type (for example a helmet " +
                "may only get randomized into another helmet),\r\n\r\n- Enabled, aggressive - every item will get randomized into an item of any type.";
        }

        private void groupLootAddItem_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of items given to the player through scripts, such as \"The Warp in the West\" book, which " +
                "one receives from Brother Piner.\r\n\r\n- Disabled - don't randomize,\r\n\r\n- Enabled, normal - every item will get randomized into an item of the " +
                "same type (for example a helmet may only get randomized into another helmet),\r\n\r\n- Enabled, aggressive - every item will get randomized into an " +
                "item of any type.";
        }

        private void groupLootDeathItem_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of items placed in NPCs' inventories upon death, such as \"Daedra Hearts\" for Dremoras." +
                "\r\n\r\n- Disabled - don't randomize,\r\n\r\n- Enabled, normal - every item will get randomized into an item of the same type (for example a helmet " +
                "may only get randomized into another helmet),\r\n\r\n- Enabled, aggressive - every item will get randomized into an item of any type.";
        }

        private void groupLootGold_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting determines how the randomizer approaches randomizing gold.\r\n\r\n- Only randomize quantity - only the quantity of gold " +
                "will be randomized.\r\n\r\n- Randomize into another item - gold will be treated just like every other regular item.";
        }

        private void groupNPCRandomizeAttributes_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of actor parameters. The parameters include aggression, confidence and responsibility." +
                "\r\n\r\n- Disabled - don't randomize,\r\n\r\n- Only for non-essential actors - randomize only actors without the essential " +
                "flag turned on,\r\n\r\n- Enabled for all - randomize all actors.";
        }
        private void groupNPCRandomizeStats_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of actor stats. The parameters include basic attributes (such as strength, dexterity, " +
                "endurance) and skills (blade, blunt, block...).\r\n\r\n- Disabled - don't randomize,\r\n\r\n- Only for non-essential actors - randomize only actors without the essential " +
                "flag turned on,\r\n\r\n- Enabled for all - randomize all actors.";
        }

        private void groupNPCRestoreAttributes_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting restores the previously randomized actor parameters.";
        }

        private void groupNPCVampire_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the chance for an actor to be turned into a vampire.";
        }

        private void groupNPCActorScaling_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the actor scaling. If enabled, every actor's size will be multiplied by a random number between Min and Max.\r\n\r\n" +
                "For example, if you wish each actor to be randomized into a size at least twice as small and at most twice as big as usual, set Min to 0.5 and Max to 2.0.";
        }

        private void groupMiscRandCreatures_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls creature randomization. Note that creatures spawned from leveled lists are randomized only on spawn AND stored " +
                "in the save file, whereas other creatures are randomized every time you launch the game, so use a fixed seed if you wish them to be randomized into " +
                "the same creatures every time.\r\n\r\n- Disabled - don't randomize creatures,\r\n\r\n- Enabled, normal - randomize leveled-list creatures on spawn " +
                "and other creatures on every launch,\r\n\r\n- Enabled, unstable - re-randomize leveled-list creatures on load. This is a highly unstable option " +
                "and it is recommended that you don't enable it.";
        }

        private void groupUseEssentialCreatures_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls whether essential creatures will be added to the randomizer's lists. Essential creatures cannot be killed, " +
                "therefore enabling this option may prevent you from completing quests that require you to kill some creatures (or force you to use cheats).";
        }

        private void groupExcludeHorses_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "If disabled, this setting will randomize horses into other creatures and vice versa. I firmly believe it strongly contributes " +
                "to memory issues, and it is recommended that you keep it disabled. If you don't, you may want to check the \"Creature data patch\" in the " +
                "\"Enable anti-crash patches\" group.";
        }

        private void groupLootExcludeUnplayableItems_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "If enabled, this setting will cause items marked as unplayable to be excluded from the randomization process.\r\n\r\n" +
                "In vanilla, these are typically items that the game does not want the player to wear for plot reasons (such as Emperor Uriel Septim's robe), " +
                "but custom mods may use this feature to handle some internal logic and potentially break if these are randomized from or into something else.";
        }

        private void RandConfigForm_Load(object sender, EventArgs e)
        {
            textActorScalingMin.Text = $"0{DecimalSeparator}7"; //lol
            textActorScalingMax.Text = $"1{DecimalSeparator}5";
            LoadSettings("Data/Randomizer.cfg");
            LoadExcludes("Data/RandomizerSkip.cfg");
            LoadTemplates();
            LoadMods();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveSettings("Data/Randomizer.cfg");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadSettings("Data/Randomizer.cfg");
        }

        private void textActorScalingMin_Validating(object sender, CancelEventArgs e)
        {
            double min, max;
            if (!Double.TryParse(textActorScalingMin.Text, out min))
            {
                errorProvider.SetError(textActorScalingMin, "Could not convert the input to a floating-point number.");
                textActorScalingMin.Focus();
                buttonSave.Enabled = false;
                return;
            }

            if (Double.TryParse(textActorScalingMax.Text, out max) && max < min)
            {
                errorProvider.SetError(textActorScalingMin, $"Minimum scaling value cannot be greater than the maximum scaling value ({max}).");
                textActorScalingMin.Focus();
                buttonSave.Enabled = false;
                return;
            }
            buttonSave.Enabled = true;
            errorProvider.SetError(textActorScalingMin, null);
        }

        private void textActorScalingMax_Validating(object sender, CancelEventArgs e)
        {
            double min, max;
            if (!Double.TryParse(textActorScalingMax.Text, out max))
            {
                errorProvider.SetError(textActorScalingMax, "Could not convert the input to a floating-point number.");
                textActorScalingMax.Focus();
                buttonSave.Enabled = false;
                return;
            }

            if (Double.TryParse(textActorScalingMin.Text, out min) && max < min)
            {
                errorProvider.SetError(textActorScalingMax, $"Maximum scaling value cannot be lower than the minimum scaling value ({min}).");
                textActorScalingMax.Focus();
                buttonSave.Enabled = false;
                return;
            }
            buttonSave.Enabled = true;
            errorProvider.SetError(textActorScalingMax, null);
        }

        private void buttonSaveTemplate_Click(object sender, EventArgs e)
        {
            if (comboTemplates.Text.Length == 0)
            {
                MessageBox.Show("Invalid template name.", "Save template", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = DialogResult.Yes;
            string path = $"obrn-configs/{comboTemplates.Text}";
            if (File.Exists(path))
            {
                result = MessageBox.Show("The following template already exists. Are you sure you want to overwrite it?",
                    "Save template",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            }
            if (result == DialogResult.Yes)
            {
                SaveSettings(path);
                if (comboTemplates.Items.IndexOf(comboTemplates.Text) == -1)
                {
                    comboTemplates.Items.Add(comboTemplates.Text);
                }
            }
        }

        private void buttonLoadTemplate_Click(object sender, EventArgs e)
        {
            if (comboTemplates.Text.Length == 0)
            {
                MessageBox.Show("Invalid template name.", "Save template", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Console.WriteLine($"Changing current config to {comboTemplates.Text}");
            LoadSettings($"obrn-configs/{comboTemplates.Text}");
        }

        private void buttonDeleteTemplate_Click(object sender, EventArgs e)
        {
            if (comboTemplates.Text.Length == 0)
            {
                MessageBox.Show("Invalid template name.", "Delete template", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string path = $"obrn-configs/{comboTemplates.Text}";

            if (!File.Exists(path) ||
                comboTemplates.Items.IndexOf(comboTemplates.Text) == -1)
            {
                MessageBox.Show("Given template does not exist.", "Delete template", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                File.Delete(path);
                comboTemplates.Items.Remove(comboTemplates.Text);
                comboTemplates.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not delete the template file. Exception: {ex}", "Delete template",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelTemplates_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "Controls responsible for template management.\r\n\r\nThe game loads randomizer's settings from the Data/Randomizer.cfg file, " +
                "and the template system allows you to keep multiple config files on standby.\r\n\r\n" +
                "For example, selecting \"Chaos.cfg\" from the dropdown box and pressing \"Load template\" will load the chaos settings into the GUI. " +
                "Then, pressing \"Save to main config\" will copy all settings from the \"Chaos.cfg\" template to the main config file, " +
                "which will be used by the game.";
        }

        private void buttonLoad_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "Loads settings from the main config file (Data/Randomizer.cfg).";
        }

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "Saves current settings to the main config file (Data/Randomizer.cfg).";
        }

        private void addItemToTextBox(TextBox tb, string item)
        {
            if (tb.Lines.Count(s => s.Equals(item, StringComparison.OrdinalIgnoreCase)) > 0)
            {
                return;
            }

            tb.AppendText($"{item}\r\n");
        }

        private void handleDragDropForTextbox(TextBox tb, DragEventArgs e)
        {
            List<string> mods = new List<string>();
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                mods.Add(e.Data.GetData(DataFormats.Text).ToString());
            }
            else
            {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var file in s)
                {
                    mods.Add(Path.GetFileName(file));
                }
            }

            foreach (var file in mods)
            {//i cannot believe that a textbox is unironically a preferable solution to a listbox
                addItemToTextBox(tb, file);
            }
        }

        private void listDontRandomize_DragDrop(object sender, DragEventArgs e)
        {
            handleDragDropForTextbox(textBoxDontRandomize, e);
        }
        private void textBoxDontAddToLists_DragDrop(object sender, DragEventArgs e)
        {
            handleDragDropForTextbox(textBoxDontAddToLists, e);
        }

        private void listDontRandomize_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) ||
                e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void buttonDontRandomizePaste_Click(object sender, EventArgs e)
        {
            foreach (var select in listMods.SelectedItems)
            {
                addItemToTextBox(textBoxDontRandomize, select.ToString());
            }

            listMods.SelectedItems.Clear();
        }

        private void buttonDontAddToLists_Click(object sender, EventArgs e)
        {
            foreach (var select in listMods.SelectedItems)
            {
                addItemToTextBox(textBoxDontAddToLists, select.ToString());
            }

            listMods.SelectedItems.Clear();
        }

        private void buttonSaveExcludes_Click(object sender, EventArgs e)
        {
            SaveExcludes("Data/RandomizerSkip.cfg");
        }

        private void buttonReloadExcludes_Click(object sender, EventArgs e)
        {
            LoadExcludes("Data/RandomizerSkip.cfg");
        }

        private void textBoxDontRandomize_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "Objects from plugin files in this list will not be randomized.";
        }

        private void listMods_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "All .esp and .esm files from your Oblivion/Data directory should be listed here.\r\n\r\n" +
                "If this list is empty, then it indicates that you have not installed the randomizer properly.";
        }

        private void buttonDontRandomizePaste_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "Pressing this button will copy all selected items from \"Your mods\" and paste them here.";
        }

        private void textBoxDontAddToLists_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "Objects from plugin files in this list will not be added to the randomizer's pool.\r\n\r\n" +
                "For example, if you are playing a total conversion mod, you may want the randomizer not to randomize objects " +
                "into vanilla Oblivion ones, thus you ought to put Oblivion.esm on this list.";
        }

        private void buttonDontAddToLists_MouseEnter(object sender, EventArgs e)
        {
            textBoxHelp.Text = "Pressing this button will copy all selected items from \"Your mods\" and paste them here.";
        }

        private void textBoxMiscSeed_TextChanged(object sender, EventArgs e)
        {
            checkSaveSeedData.Enabled = (textBoxMiscSeed.Text.Length > 0);
        }
    }
}
