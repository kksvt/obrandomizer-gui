using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms.VisualStyles;
using System.Globalization;

namespace obrandomizer_gui
{
    public partial class RandConfigForm: Form
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
            if (s == null)
            {
                return false;
            }

            if (Boolean.TryParse(s, out result))
            {
                return result;
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
            } else
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
            groupNPCRandomizeAttributes.Enabled = !radioRestoreActorAttribYes.Checked;
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

        private void LoadSettings(string fileName)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddIniFile(fileName)
                .Build();
            int n;
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
            radioExcludeQuestNo.Checked = !(radioExcludeQuestYes.Checked = StringToBool(section["oExcludeQuestItems"]));
            radioDelayStartNo.Checked = !(radioDelayStartYes.Checked = StringToBool(section["oDelayStart"]));
            if (Int32.TryParse(section["oInstallCrashFix"], out n))
            {
                checkInvalidTexturePatch.Checked = ((n & 1) == 1);
                checkInvalidCreatureDataPatch.Checked = ((n & 2) == 2);
            } else
            {
                //MessageBox.Show($"Could not parse \"oInstallCrashFix\" from \"{fileName}\".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                invalidParses.Add("oInstallCrashFix");
                checkInvalidTexturePatch.Checked = checkInvalidCreatureDataPatch.Checked = false;
            }
            
            if (Int32.TryParse(section["oHitEffect"], out n))
            {
                numericHitEffect.Value = n;
            } else
            {
                //MessageBox.Show($"Could not parse \"oHitEffect\" from \"{fileName}\".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            oRandGold=0*/
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

            if (!StringIntToThreeRadioBoxes(section["oAddItems"],
                radioAddItemDisabled,
                radioAddItemEnabled,
                radioAddItemAggressive))
            {
                invalidParses.Add("oAddItems");
            }

            radioLootRandGoldNo.Checked = !(radioLootRandGoldYes.Checked = StringToBool(section["oRandGold"]));

            /*[Actor]
            oRandomizeAttrib=1
            oRandomizeAttribEssential=0
            oRestoreBaseAttributes=0
            oVampire=10
            oScaleActors=0
            oScaleMin=0.7
            oScaleMax=1.5*/



            /*[Creatures]
            oRandCreatures=1
            oUseEssentialCreatures=0
            oSkipHorses=1  */

        }

        private void SaveSettings(string fileName) {
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
                output.WriteLine("oExcludeQuestItems=" + (radioExcludeQuestYes.Checked ? "yes" : "no"));
                output.WriteLine("oDelayStart=" + (radioDelayStartYes.Checked ? "yes" : "no"));
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
                } else if (radioSpells1.Checked)
                {
                    output.WriteLine("oRandSpells=1");
                } else if (radioSpells2.Checked)
                {
                    output.WriteLine("oRandSpells=2");
                }
                //Loot
                output.WriteLine("\n[Loot]");
                //actors
                if (radioRandActorInventoryDisabled.Checked)
                {
                    output.WriteLine("oRandInventory=0");
                } else if (radioRandActorInventoryEnabled.Checked)
                {
                    output.WriteLine("oRandInventory=1");
                } else if (radioRandActorInventoryAggressive.Checked)
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
                else if (radioRandChestInventoryAggressive.Checked)
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
                else if (radioWorldItemAggressive.Checked)
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
                else if (radioAddItemAggressive.Checked)
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
                else if (radioDeathItemAggressive.Checked)
                {
                    output.WriteLine("oDeathItems=2");
                }
                //gold
                output.WriteLine("oRandGold=" + (radioLootRandGoldYes.Checked ? "1" : "0"));
                //Actor params
                output.WriteLine("\n[Actor]");
                //attributes
                output.WriteLine("oRandomizeAttrib=" + (radioAttribDisabled.Checked || radioRestoreActorAttribYes.Checked ? "0" : "1"));
                output.WriteLine("oRandomizeAttribEssential=" + (radioAttribAll.Checked && radioRestoreActorAttribNo.Checked ? "1" : "0"));
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
                else if (radioRandCreaturesUnstable.Checked)
                {
                    output.WriteLine("oRandCreatures=2");
                }
                //use essential
                output.WriteLine("oUseEssentialCreatures=" + (radioUseEssentialCreaturesYes.Checked ? "1" : "0"));
                //exclude horses
                output.WriteLine("oSkipHorses=" + (radioExcludeHorsesYes.Checked ? "1" : "0"));
            }
        }

        private void groupMiscSeed_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "Since the information about the randomization of world items, non-leveled list creatures " +
                "and spells is not stored in the save file, they will get re-randomized every time you launch the game.\r\n\r\n" +
                "Selecting a fixed seed will cause them to get randomized into the same objects " +
                "every time, allowing a consistent experience across one playthrough.\r\n\r\n" +
                "Leave the field empty if you want the game to generate a new random seed every launch.";
        }

        private void groupMiscQuestObjects_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the inclusion of quest and scripted items in the randomizer's lists.\r\n\r\n" +
                "Picking up quest items often prompts the game to update the status of the associated quest, " +
                "resulting in strange effects and possibly being locked out of proper progression within that questline.\r\n\r\n" +
                "Excluding quest items means that no item can be randomized into a quest item, allowing you to progress quests " +
                "without having to worry about them breaking.";
        }

        private void groupMiscDelayStart_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "If this setting is enabled, then inventory and attribute randomization will not kick in " +
                "until the first ambush in the tutorial (Charactergen reaches stage 20).";
        }

        private void groupMiscPatches_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls whether various anti-crash patches are enabled. Should you find " +
                "that your save crashes every time you load it, enable either of these settings (or both) and see " +
                "if that helps.";
        }

        private void groupMiscHitEffect_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "The chance for each hit to apply one of the following random effects:\r\n" +
                "- fire,\r\n- frost,\r\n- shock,\r\n- demoralize,\r\n- burden,\r\n- frenzy,\r\n- paralysis,\r\n- push,\r\n- heal," +
                "\r\n- disintegrate,\r\n- drain fatigue";
        }

        private void groupMiscSpells_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "Spell randomization setting.\r\n\r\n- Disabled - don't enable spell randomization,\r\n\r\n" +
                "- Randomize spell, but not school - every spell will get randomized into a spell of the same school (for example " +
                "Flare may get randomized into Fire Storm, but never into Paralyze),\r\n\r\n- Total randomization - every spell may " +
                " get randomized into any spell, regardless of the school.";
        }

        private void groupLootRandActorInventory_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of actors' inventories.\r\n\r\n- Disabled - don't randomize,\r\n\r\n" +
                "- Enabled, normal - every item in an NPC's inventory will get randomized into an item of the same type (for example a helmet " +
                "may only get randomized into another helmet),\r\n\r\n- Enabled, aggressive - will grant NPCs a lot of random items, regardless " +
                "of their pre-randomized inventory.";
        }

        private void groupLootRandChestInventory_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of containers' inventories.\r\n\r\n- Disabled - don't randomize,\r\n\r\n" +
                "- Enabled, normal - every item in a container's inventory will get randomized into an item of the same type (for example a helmet " +
                "may only get randomized into another helmet),\r\n\r\n- Enabled, aggressive - will grant containers a lot of random items, regardless " +
                "of their pre-randomized inventory.";
        }

        private void groupLootWorldItem_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of items freely spawned in the world (such as a bowl lying on a table). Note that " +
                "world item randomization is not stored in your save file, so use a fixed seed if you wish them to be randomized into the same items every time." +
                "\r\n\r\n- Disabled - don't randomize,\r\n\r\n- Enabled, normal - every item will get randomized into an item of the same type (for example a helmet " +
                "may only get randomized into another helmet),\r\n\r\n- Enabled, aggressive - every item will get randomized into an item of any type.";
        }

        private void groupLootAddItem_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of items given to the player through scripts, such as \"The Warp in the West\" book, which " + 
                "one receives from Brother Piner.\r\n\r\n- Disabled - don't randomize,\r\n\r\n- Enabled, normal - every item will get randomized into an item of the " + 
                "same type (for example a helmet may only get randomized into another helmet),\r\n\r\n- Enabled, aggressive - every item will get randomized into an " + 
                "item of any type.";
        }

        private void groupLootDeathItem_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of items placed in NPCs' inventories upon death, such as \"Daedra Hearts\" placed in Dremoras " +
                "\r\n\r\n- Disabled - don't randomize,\r\n\r\n- Enabled, normal - every item will get randomized into an item of the same type (for example a helmet " +
                "may only get randomized into another helmet),\r\n\r\n- Enabled, aggressive - every item will get randomized into an item of any type.";
        }

        private void groupLootGold_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting determines how the randomizer approaches randomizing gold\r\n\r\n- Only randomize quantity - only the quantity of gold " +
                "will be randomized.\r\n\r\n- Randomize into another item - gold will be treated just like every other regular item.";
        }

        private void groupNPCRandomizeAttributes_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the randomization of actor parameters. The parameters includeaggression, confidence, responsibility," +
                "\r\n\r\n- Disabled - don't randomize,\r\n\r\n- Only for non-essential actors - randomize only actors without the essential " + 
                "flag turned on,\r\n\r\n- Enabled for all - randomize all actors.";
        }

        private void groupNPCRestoreAttributes_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting restores the previously randomized actor parameters.";
        }

        private void groupNPCVampire_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the chance for an actor to be turned into a vampire.";
        }

        private void groupNPCActorScaling_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls the actor scaling. If enabled, every actor's size will be multiplied by a random number between Min and Max.\r\n\r\n" +
                "For example, if you wish each actor to be randomized into a size at least twice as small and at most twice as big as usual, set Min to 0.5 and Max to 2.0.";
        }

        private void groupMiscRandCreatures_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls creature randomization. Note that creatures spawned from leveled lists are randomized only on spawn AND stored " +
                "in the save file, whereas other creatures are randomized every time you launch the game, so use a fixed seed if you wish them to be randomized into " +
                "the same creatures every time.\r\n\r\n- Disabled - don't randomize creatures,\r\n\r\n- Enabled, normal - randomize leveled-list creatures on spawn " + 
                "and other creatures on every launch,\r\n\r\n- Enabled, unstable - re-randomize leveled-list creatures on load. This is a highly unstable option " +
                "and it is recommended that you don't enable it.";
        }

        private void groupUseEssentialCreatures_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "This setting controls whether essential creatures will be added to the randomizer's lists. Essential creatures cannot be killed, " +
                "therefore enabling this option may prevent you from completing quests that require you to kill some creatures (or force you to use cheats).";
        }

        private void groupExcludeHorses_MouseHover(object sender, EventArgs e)
        {
            textBoxHelp.Text = "If disabled, this setting will randomize horses into other creatures and vice versa. I firmly believe it strongly contributes " +
                "to memory issues, and it is recommended that you keep it disabled. If you don't, you may want to check the \"Creature data patch\" in the " +
                "\"Enable anti-crash patches\" group.";
        }

        private void RandConfigForm_Load(object sender, EventArgs e)
        {
            textActorScalingMin.Text = $"0{DecimalSeparator}7"; //lol
            textActorScalingMax.Text = $"1{DecimalSeparator}5";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveSettings("test.cfg");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadSettings("test.cfg");
        }

        private void textActorScalingMin_Validating(object sender, CancelEventArgs e)
        {
            double min, max;
            if (!Double.TryParse(textActorScalingMin.Text, out min))
            {
                errorProvider.SetError(textActorScalingMin, "Couldn't convert the input to a floating-point number.");
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
                errorProvider.SetError(textActorScalingMax, "Couldn't convert the input to a floating-point number.");
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
    }
}
