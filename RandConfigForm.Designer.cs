namespace obrandomizer_gui
{
    partial class RandConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabs = new System.Windows.Forms.TabControl();
            tabMiscSettings = new System.Windows.Forms.TabPage();
            groupMisc = new System.Windows.Forms.GroupBox();
            groupMiscSeed = new System.Windows.Forms.GroupBox();
            checkSaveSeedData = new System.Windows.Forms.CheckBox();
            buttonRandSeed = new System.Windows.Forms.Button();
            textBoxMiscSeed = new System.Windows.Forms.TextBox();
            groupMiscPatches = new System.Windows.Forms.GroupBox();
            checkInvalidCreatureDataPatch = new System.Windows.Forms.CheckBox();
            checkInvalidTexturePatch = new System.Windows.Forms.CheckBox();
            groupMiscHitEffect = new System.Windows.Forms.GroupBox();
            numericHitEffect = new System.Windows.Forms.NumericUpDown();
            groupMiscDelayStart = new System.Windows.Forms.GroupBox();
            radioDelayStartNo = new System.Windows.Forms.RadioButton();
            radioDelayStartYes = new System.Windows.Forms.RadioButton();
            groupMiscQuestObjects = new System.Windows.Forms.GroupBox();
            radioExcludeQuestYes = new System.Windows.Forms.RadioButton();
            radioExcludeQuestNo = new System.Windows.Forms.RadioButton();
            groupMiscSpells = new System.Windows.Forms.GroupBox();
            radioSpells2 = new System.Windows.Forms.RadioButton();
            radioSpellsDisabled = new System.Windows.Forms.RadioButton();
            radioSpells1 = new System.Windows.Forms.RadioButton();
            tabLootSettings = new System.Windows.Forms.TabPage();
            groupLoot = new System.Windows.Forms.GroupBox();
            groupLootExcludeUnplayableItems = new System.Windows.Forms.GroupBox();
            radioLootExcludeUnplayableYes = new System.Windows.Forms.RadioButton();
            radioLootExcludeUnplayableNo = new System.Windows.Forms.RadioButton();
            groupLootGold = new System.Windows.Forms.GroupBox();
            radioLootRandGoldNo = new System.Windows.Forms.RadioButton();
            radioLootRandGoldYes = new System.Windows.Forms.RadioButton();
            groupLootDeathItem = new System.Windows.Forms.GroupBox();
            radioDeathItemAggressive = new System.Windows.Forms.RadioButton();
            radioDeathItemEnabled = new System.Windows.Forms.RadioButton();
            radioDeathItemDisabled = new System.Windows.Forms.RadioButton();
            groupLootAddItem = new System.Windows.Forms.GroupBox();
            radioAddItemAggressive = new System.Windows.Forms.RadioButton();
            radioAddItemEnabled = new System.Windows.Forms.RadioButton();
            radioAddItemDisabled = new System.Windows.Forms.RadioButton();
            groupLootWorldItem = new System.Windows.Forms.GroupBox();
            radioWorldItemAggressive = new System.Windows.Forms.RadioButton();
            radioWorldItemEnabled = new System.Windows.Forms.RadioButton();
            radioWorldItemDisabled = new System.Windows.Forms.RadioButton();
            groupLootRandChestInventory = new System.Windows.Forms.GroupBox();
            radioRandChestInventoryAggressive = new System.Windows.Forms.RadioButton();
            radioRandChestInventoryEnabled = new System.Windows.Forms.RadioButton();
            radioRandChestInventoryDisabled = new System.Windows.Forms.RadioButton();
            groupLootRandActorInventory = new System.Windows.Forms.GroupBox();
            radioRandActorInventoryAggressive = new System.Windows.Forms.RadioButton();
            radioRandActorInventoryEnabled = new System.Windows.Forms.RadioButton();
            radioRandActorInventoryDisabled = new System.Windows.Forms.RadioButton();
            tabActorSettings = new System.Windows.Forms.TabPage();
            groupActors = new System.Windows.Forms.GroupBox();
            groupNPCRandomizeStats = new System.Windows.Forms.GroupBox();
            radioStatAll = new System.Windows.Forms.RadioButton();
            radioStatNonEssential = new System.Windows.Forms.RadioButton();
            radioStatDisabled = new System.Windows.Forms.RadioButton();
            groupNPCActorScaling = new System.Windows.Forms.GroupBox();
            checkActorScaling = new System.Windows.Forms.CheckBox();
            panelActorScaling = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            textActorScalingMin = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            textActorScalingMax = new System.Windows.Forms.TextBox();
            groupNPCRestoreAttributes = new System.Windows.Forms.GroupBox();
            radioRestoreActorAttribNo = new System.Windows.Forms.RadioButton();
            radioRestoreActorAttribYes = new System.Windows.Forms.RadioButton();
            groupNPCRandomizeAttributes = new System.Windows.Forms.GroupBox();
            radioAttribAll = new System.Windows.Forms.RadioButton();
            radioAttribNonEssential = new System.Windows.Forms.RadioButton();
            radioAttribDisabled = new System.Windows.Forms.RadioButton();
            groupNPCVampire = new System.Windows.Forms.GroupBox();
            numericVampire = new System.Windows.Forms.NumericUpDown();
            tabCreatureSettings = new System.Windows.Forms.TabPage();
            groupCreatures = new System.Windows.Forms.GroupBox();
            groupUseEssentialCreatures = new System.Windows.Forms.GroupBox();
            radioUseEssentialCreaturesYes = new System.Windows.Forms.RadioButton();
            radioUseEssentialCreaturesNo = new System.Windows.Forms.RadioButton();
            groupExcludeHorses = new System.Windows.Forms.GroupBox();
            radioExcludeHorsesYes = new System.Windows.Forms.RadioButton();
            radioExcludeHorsesNo = new System.Windows.Forms.RadioButton();
            groupMiscRandCreatures = new System.Windows.Forms.GroupBox();
            radioRandCreaturesUnstable = new System.Windows.Forms.RadioButton();
            radioRandCreaturesEnabled = new System.Windows.Forms.RadioButton();
            radioRandCreaturesDisabled = new System.Windows.Forms.RadioButton();
            tabExcludes = new System.Windows.Forms.TabPage();
            buttonReloadExcludes = new System.Windows.Forms.Button();
            buttonSaveExcludes = new System.Windows.Forms.Button();
            groupDontAddToRandomizerLists = new System.Windows.Forms.GroupBox();
            buttonDontAddToLists = new System.Windows.Forms.Button();
            textBoxDontAddToLists = new System.Windows.Forms.TextBox();
            groupDontRandomize = new System.Windows.Forms.GroupBox();
            buttonDontRandomizePaste = new System.Windows.Forms.Button();
            textBoxDontRandomize = new System.Windows.Forms.TextBox();
            groupCurrentMods = new System.Windows.Forms.GroupBox();
            listMods = new System.Windows.Forms.ListBox();
            textBoxHelp = new System.Windows.Forms.TextBox();
            buttonSave = new System.Windows.Forms.Button();
            buttonLoad = new System.Windows.Forms.Button();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            comboTemplates = new System.Windows.Forms.ComboBox();
            labelTemplates = new System.Windows.Forms.Label();
            buttonSaveTemplate = new System.Windows.Forms.Button();
            buttonLoadTemplate = new System.Windows.Forms.Button();
            buttonDeleteTemplate = new System.Windows.Forms.Button();
            labelLastLoaded = new System.Windows.Forms.Label();
            tabs.SuspendLayout();
            tabMiscSettings.SuspendLayout();
            groupMisc.SuspendLayout();
            groupMiscSeed.SuspendLayout();
            groupMiscPatches.SuspendLayout();
            groupMiscHitEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericHitEffect).BeginInit();
            groupMiscDelayStart.SuspendLayout();
            groupMiscQuestObjects.SuspendLayout();
            groupMiscSpells.SuspendLayout();
            tabLootSettings.SuspendLayout();
            groupLoot.SuspendLayout();
            groupLootExcludeUnplayableItems.SuspendLayout();
            groupLootGold.SuspendLayout();
            groupLootDeathItem.SuspendLayout();
            groupLootAddItem.SuspendLayout();
            groupLootWorldItem.SuspendLayout();
            groupLootRandChestInventory.SuspendLayout();
            groupLootRandActorInventory.SuspendLayout();
            tabActorSettings.SuspendLayout();
            groupActors.SuspendLayout();
            groupNPCRandomizeStats.SuspendLayout();
            groupNPCActorScaling.SuspendLayout();
            panelActorScaling.SuspendLayout();
            groupNPCRestoreAttributes.SuspendLayout();
            groupNPCRandomizeAttributes.SuspendLayout();
            groupNPCVampire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericVampire).BeginInit();
            tabCreatureSettings.SuspendLayout();
            groupCreatures.SuspendLayout();
            groupUseEssentialCreatures.SuspendLayout();
            groupExcludeHorses.SuspendLayout();
            groupMiscRandCreatures.SuspendLayout();
            tabExcludes.SuspendLayout();
            groupDontAddToRandomizerLists.SuspendLayout();
            groupDontRandomize.SuspendLayout();
            groupCurrentMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Controls.Add(tabMiscSettings);
            tabs.Controls.Add(tabLootSettings);
            tabs.Controls.Add(tabActorSettings);
            tabs.Controls.Add(tabCreatureSettings);
            tabs.Controls.Add(tabExcludes);
            tabs.Location = new System.Drawing.Point(14, 14);
            tabs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new System.Drawing.Size(789, 418);
            tabs.TabIndex = 0;
            // 
            // tabMiscSettings
            // 
            tabMiscSettings.Controls.Add(groupMisc);
            tabMiscSettings.Location = new System.Drawing.Point(4, 24);
            tabMiscSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabMiscSettings.Name = "tabMiscSettings";
            tabMiscSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabMiscSettings.Size = new System.Drawing.Size(781, 390);
            tabMiscSettings.TabIndex = 0;
            tabMiscSettings.Text = "Misc settings";
            tabMiscSettings.UseVisualStyleBackColor = true;
            // 
            // groupMisc
            // 
            groupMisc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            groupMisc.Controls.Add(groupMiscSeed);
            groupMisc.Controls.Add(groupMiscPatches);
            groupMisc.Controls.Add(groupMiscHitEffect);
            groupMisc.Controls.Add(groupMiscDelayStart);
            groupMisc.Controls.Add(groupMiscQuestObjects);
            groupMisc.Controls.Add(groupMiscSpells);
            groupMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
            groupMisc.Location = new System.Drawing.Point(7, 7);
            groupMisc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMisc.Name = "groupMisc";
            groupMisc.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMisc.Size = new System.Drawing.Size(765, 232);
            groupMisc.TabIndex = 0;
            groupMisc.TabStop = false;
            groupMisc.Text = "Misc";
            // 
            // groupMiscSeed
            // 
            groupMiscSeed.Controls.Add(checkSaveSeedData);
            groupMiscSeed.Controls.Add(buttonRandSeed);
            groupMiscSeed.Controls.Add(textBoxMiscSeed);
            groupMiscSeed.Location = new System.Drawing.Point(7, 23);
            groupMiscSeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscSeed.Name = "groupMiscSeed";
            groupMiscSeed.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscSeed.Size = new System.Drawing.Size(219, 88);
            groupMiscSeed.TabIndex = 7;
            groupMiscSeed.TabStop = false;
            groupMiscSeed.Tag = "";
            groupMiscSeed.Text = "Seed";
            groupMiscSeed.MouseEnter += groupMiscSeed_MouseEnter;
            // 
            // checkSaveSeedData
            // 
            checkSaveSeedData.AutoSize = true;
            checkSaveSeedData.Enabled = false;
            checkSaveSeedData.Location = new System.Drawing.Point(7, 55);
            checkSaveSeedData.Name = "checkSaveSeedData";
            checkSaveSeedData.Size = new System.Drawing.Size(101, 17);
            checkSaveSeedData.TabIndex = 2;
            checkSaveSeedData.Text = "Save seed data";
            checkSaveSeedData.UseVisualStyleBackColor = true;
            // 
            // buttonRandSeed
            // 
            buttonRandSeed.Location = new System.Drawing.Point(7, 22);
            buttonRandSeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonRandSeed.Name = "buttonRandSeed";
            buttonRandSeed.Size = new System.Drawing.Size(61, 27);
            buttonRandSeed.TabIndex = 1;
            buttonRandSeed.Text = "New";
            buttonRandSeed.UseVisualStyleBackColor = true;
            buttonRandSeed.Click += buttonRandSeed_Click;
            // 
            // textBoxMiscSeed
            // 
            textBoxMiscSeed.Location = new System.Drawing.Point(80, 24);
            textBoxMiscSeed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMiscSeed.Name = "textBoxMiscSeed";
            textBoxMiscSeed.Size = new System.Drawing.Size(116, 20);
            textBoxMiscSeed.TabIndex = 0;
            textBoxMiscSeed.TextChanged += textBoxMiscSeed_TextChanged;
            // 
            // groupMiscPatches
            // 
            groupMiscPatches.Controls.Add(checkInvalidCreatureDataPatch);
            groupMiscPatches.Controls.Add(checkInvalidTexturePatch);
            groupMiscPatches.Location = new System.Drawing.Point(274, 117);
            groupMiscPatches.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscPatches.Name = "groupMiscPatches";
            groupMiscPatches.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscPatches.Size = new System.Drawing.Size(218, 80);
            groupMiscPatches.TabIndex = 6;
            groupMiscPatches.TabStop = false;
            groupMiscPatches.Text = "Enable anti-crash patches";
            groupMiscPatches.MouseEnter += groupMiscPatches_MouseEnter;
            // 
            // checkInvalidCreatureDataPatch
            // 
            checkInvalidCreatureDataPatch.AutoSize = true;
            checkInvalidCreatureDataPatch.Location = new System.Drawing.Point(8, 46);
            checkInvalidCreatureDataPatch.Margin = new System.Windows.Forms.Padding(1, 3, 4, 1);
            checkInvalidCreatureDataPatch.Name = "checkInvalidCreatureDataPatch";
            checkInvalidCreatureDataPatch.Size = new System.Drawing.Size(120, 17);
            checkInvalidCreatureDataPatch.TabIndex = 1;
            checkInvalidCreatureDataPatch.Text = "Creature data patch";
            checkInvalidCreatureDataPatch.UseVisualStyleBackColor = true;
            // 
            // checkInvalidTexturePatch
            // 
            checkInvalidTexturePatch.AutoSize = true;
            checkInvalidTexturePatch.Location = new System.Drawing.Point(8, 22);
            checkInvalidTexturePatch.Margin = new System.Windows.Forms.Padding(1, 3, 4, 1);
            checkInvalidTexturePatch.Name = "checkInvalidTexturePatch";
            checkInvalidTexturePatch.Size = new System.Drawing.Size(122, 17);
            checkInvalidTexturePatch.TabIndex = 0;
            checkInvalidTexturePatch.Text = "Invalid texture patch";
            checkInvalidTexturePatch.UseVisualStyleBackColor = true;
            // 
            // groupMiscHitEffect
            // 
            groupMiscHitEffect.Controls.Add(numericHitEffect);
            groupMiscHitEffect.Location = new System.Drawing.Point(538, 22);
            groupMiscHitEffect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscHitEffect.Name = "groupMiscHitEffect";
            groupMiscHitEffect.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscHitEffect.Size = new System.Drawing.Size(218, 61);
            groupMiscHitEffect.TabIndex = 5;
            groupMiscHitEffect.TabStop = false;
            groupMiscHitEffect.Text = "Hit effect chance (%)";
            groupMiscHitEffect.MouseEnter += groupMiscHitEffect_MouseEnter;
            // 
            // numericHitEffect
            // 
            numericHitEffect.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericHitEffect.Location = new System.Drawing.Point(8, 22);
            numericHitEffect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericHitEffect.Name = "numericHitEffect";
            numericHitEffect.Size = new System.Drawing.Size(140, 20);
            numericHitEffect.TabIndex = 0;
            numericHitEffect.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // groupMiscDelayStart
            // 
            groupMiscDelayStart.Controls.Add(radioDelayStartNo);
            groupMiscDelayStart.Controls.Add(radioDelayStartYes);
            groupMiscDelayStart.Location = new System.Drawing.Point(274, 22);
            groupMiscDelayStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscDelayStart.Name = "groupMiscDelayStart";
            groupMiscDelayStart.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscDelayStart.Size = new System.Drawing.Size(218, 73);
            groupMiscDelayStart.TabIndex = 4;
            groupMiscDelayStart.TabStop = false;
            groupMiscDelayStart.Text = "Delay start";
            groupMiscDelayStart.MouseEnter += groupMiscDelayStart_MouseEnter;
            // 
            // radioDelayStartNo
            // 
            radioDelayStartNo.AutoSize = true;
            radioDelayStartNo.Checked = true;
            radioDelayStartNo.Location = new System.Drawing.Point(8, 45);
            radioDelayStartNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioDelayStartNo.Name = "radioDelayStartNo";
            radioDelayStartNo.Size = new System.Drawing.Size(39, 17);
            radioDelayStartNo.TabIndex = 1;
            radioDelayStartNo.TabStop = true;
            radioDelayStartNo.Text = "No";
            radioDelayStartNo.UseVisualStyleBackColor = true;
            // 
            // radioDelayStartYes
            // 
            radioDelayStartYes.AutoSize = true;
            radioDelayStartYes.Location = new System.Drawing.Point(8, 23);
            radioDelayStartYes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioDelayStartYes.Name = "radioDelayStartYes";
            radioDelayStartYes.Size = new System.Drawing.Size(43, 17);
            radioDelayStartYes.TabIndex = 0;
            radioDelayStartYes.Text = "Yes";
            radioDelayStartYes.UseVisualStyleBackColor = true;
            // 
            // groupMiscQuestObjects
            // 
            groupMiscQuestObjects.Controls.Add(radioExcludeQuestYes);
            groupMiscQuestObjects.Controls.Add(radioExcludeQuestNo);
            groupMiscQuestObjects.Location = new System.Drawing.Point(7, 117);
            groupMiscQuestObjects.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscQuestObjects.Name = "groupMiscQuestObjects";
            groupMiscQuestObjects.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscQuestObjects.Size = new System.Drawing.Size(219, 80);
            groupMiscQuestObjects.TabIndex = 3;
            groupMiscQuestObjects.TabStop = false;
            groupMiscQuestObjects.Text = "Exclude quest objects";
            groupMiscQuestObjects.MouseEnter += groupMiscQuestObjects_MouseEnter;
            // 
            // radioExcludeQuestYes
            // 
            radioExcludeQuestYes.AutoSize = true;
            radioExcludeQuestYes.Checked = true;
            radioExcludeQuestYes.Location = new System.Drawing.Point(7, 22);
            radioExcludeQuestYes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioExcludeQuestYes.Name = "radioExcludeQuestYes";
            radioExcludeQuestYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            radioExcludeQuestYes.Size = new System.Drawing.Size(43, 17);
            radioExcludeQuestYes.TabIndex = 0;
            radioExcludeQuestYes.TabStop = true;
            radioExcludeQuestYes.Text = "Yes";
            radioExcludeQuestYes.UseVisualStyleBackColor = true;
            // 
            // radioExcludeQuestNo
            // 
            radioExcludeQuestNo.AutoSize = true;
            radioExcludeQuestNo.Location = new System.Drawing.Point(7, 44);
            radioExcludeQuestNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioExcludeQuestNo.Name = "radioExcludeQuestNo";
            radioExcludeQuestNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            radioExcludeQuestNo.Size = new System.Drawing.Size(39, 17);
            radioExcludeQuestNo.TabIndex = 1;
            radioExcludeQuestNo.Text = "No";
            radioExcludeQuestNo.UseVisualStyleBackColor = true;
            // 
            // groupMiscSpells
            // 
            groupMiscSpells.Controls.Add(radioSpells2);
            groupMiscSpells.Controls.Add(radioSpellsDisabled);
            groupMiscSpells.Controls.Add(radioSpells1);
            groupMiscSpells.Location = new System.Drawing.Point(538, 117);
            groupMiscSpells.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscSpells.Name = "groupMiscSpells";
            groupMiscSpells.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscSpells.Size = new System.Drawing.Size(218, 96);
            groupMiscSpells.TabIndex = 0;
            groupMiscSpells.TabStop = false;
            groupMiscSpells.Text = "Spell randomization";
            groupMiscSpells.MouseEnter += groupMiscSpells_MouseEnter;
            // 
            // radioSpells2
            // 
            radioSpells2.AutoSize = true;
            radioSpells2.Location = new System.Drawing.Point(7, 66);
            radioSpells2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioSpells2.Name = "radioSpells2";
            radioSpells2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            radioSpells2.Size = new System.Drawing.Size(117, 17);
            radioSpells2.TabIndex = 4;
            radioSpells2.Text = "Total randomization";
            radioSpells2.UseVisualStyleBackColor = true;
            // 
            // radioSpellsDisabled
            // 
            radioSpellsDisabled.AutoSize = true;
            radioSpellsDisabled.Location = new System.Drawing.Point(7, 21);
            radioSpellsDisabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioSpellsDisabled.Name = "radioSpellsDisabled";
            radioSpellsDisabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            radioSpellsDisabled.Size = new System.Drawing.Size(66, 17);
            radioSpellsDisabled.TabIndex = 2;
            radioSpellsDisabled.Text = "Disabled";
            radioSpellsDisabled.UseVisualStyleBackColor = true;
            // 
            // radioSpells1
            // 
            radioSpells1.AutoSize = true;
            radioSpells1.Checked = true;
            radioSpells1.Location = new System.Drawing.Point(7, 43);
            radioSpells1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioSpells1.Name = "radioSpells1";
            radioSpells1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            radioSpells1.Size = new System.Drawing.Size(175, 17);
            radioSpells1.TabIndex = 3;
            radioSpells1.TabStop = true;
            radioSpells1.Text = "Randomize spell, but not school";
            radioSpells1.UseVisualStyleBackColor = true;
            // 
            // tabLootSettings
            // 
            tabLootSettings.Controls.Add(groupLoot);
            tabLootSettings.Location = new System.Drawing.Point(4, 24);
            tabLootSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabLootSettings.Name = "tabLootSettings";
            tabLootSettings.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabLootSettings.Size = new System.Drawing.Size(781, 390);
            tabLootSettings.TabIndex = 1;
            tabLootSettings.Text = "Loot settings";
            tabLootSettings.UseVisualStyleBackColor = true;
            // 
            // groupLoot
            // 
            groupLoot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            groupLoot.Controls.Add(groupLootExcludeUnplayableItems);
            groupLoot.Controls.Add(groupLootGold);
            groupLoot.Controls.Add(groupLootDeathItem);
            groupLoot.Controls.Add(groupLootAddItem);
            groupLoot.Controls.Add(groupLootWorldItem);
            groupLoot.Controls.Add(groupLootRandChestInventory);
            groupLoot.Controls.Add(groupLootRandActorInventory);
            groupLoot.Location = new System.Drawing.Point(7, 7);
            groupLoot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLoot.Name = "groupLoot";
            groupLoot.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLoot.Size = new System.Drawing.Size(765, 374);
            groupLoot.TabIndex = 2;
            groupLoot.TabStop = false;
            groupLoot.Text = "Loot";
            // 
            // groupLootExcludeUnplayableItems
            // 
            groupLootExcludeUnplayableItems.Controls.Add(radioLootExcludeUnplayableYes);
            groupLootExcludeUnplayableItems.Controls.Add(radioLootExcludeUnplayableNo);
            groupLootExcludeUnplayableItems.Location = new System.Drawing.Point(7, 243);
            groupLootExcludeUnplayableItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootExcludeUnplayableItems.Name = "groupLootExcludeUnplayableItems";
            groupLootExcludeUnplayableItems.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootExcludeUnplayableItems.Size = new System.Drawing.Size(219, 80);
            groupLootExcludeUnplayableItems.TabIndex = 17;
            groupLootExcludeUnplayableItems.TabStop = false;
            groupLootExcludeUnplayableItems.Text = "Exclude unplayable items";
            groupLootExcludeUnplayableItems.MouseEnter += groupLootExcludeUnplayableItems_MouseEnter;
            // 
            // radioLootExcludeUnplayableYes
            // 
            radioLootExcludeUnplayableYes.AutoSize = true;
            radioLootExcludeUnplayableYes.Checked = true;
            radioLootExcludeUnplayableYes.Location = new System.Drawing.Point(7, 22);
            radioLootExcludeUnplayableYes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioLootExcludeUnplayableYes.Name = "radioLootExcludeUnplayableYes";
            radioLootExcludeUnplayableYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            radioLootExcludeUnplayableYes.Size = new System.Drawing.Size(42, 19);
            radioLootExcludeUnplayableYes.TabIndex = 0;
            radioLootExcludeUnplayableYes.TabStop = true;
            radioLootExcludeUnplayableYes.Text = "Yes";
            radioLootExcludeUnplayableYes.UseVisualStyleBackColor = true;
            // 
            // radioLootExcludeUnplayableNo
            // 
            radioLootExcludeUnplayableNo.AutoSize = true;
            radioLootExcludeUnplayableNo.Location = new System.Drawing.Point(7, 44);
            radioLootExcludeUnplayableNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioLootExcludeUnplayableNo.Name = "radioLootExcludeUnplayableNo";
            radioLootExcludeUnplayableNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            radioLootExcludeUnplayableNo.Size = new System.Drawing.Size(41, 19);
            radioLootExcludeUnplayableNo.TabIndex = 1;
            radioLootExcludeUnplayableNo.Text = "No";
            radioLootExcludeUnplayableNo.UseVisualStyleBackColor = true;
            // 
            // groupLootGold
            // 
            groupLootGold.Controls.Add(radioLootRandGoldNo);
            groupLootGold.Controls.Add(radioLootRandGoldYes);
            groupLootGold.Location = new System.Drawing.Point(539, 133);
            groupLootGold.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootGold.Name = "groupLootGold";
            groupLootGold.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootGold.Size = new System.Drawing.Size(218, 104);
            groupLootGold.TabIndex = 16;
            groupLootGold.TabStop = false;
            groupLootGold.Text = "Gold";
            groupLootGold.MouseEnter += groupLootGold_MouseEnter;
            // 
            // radioLootRandGoldNo
            // 
            radioLootRandGoldNo.AutoSize = true;
            radioLootRandGoldNo.Checked = true;
            radioLootRandGoldNo.Location = new System.Drawing.Point(7, 22);
            radioLootRandGoldNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioLootRandGoldNo.Name = "radioLootRandGoldNo";
            radioLootRandGoldNo.Size = new System.Drawing.Size(156, 19);
            radioLootRandGoldNo.TabIndex = 1;
            radioLootRandGoldNo.TabStop = true;
            radioLootRandGoldNo.Text = "Only randomize quantity";
            radioLootRandGoldNo.UseVisualStyleBackColor = true;
            // 
            // radioLootRandGoldYes
            // 
            radioLootRandGoldYes.AutoSize = true;
            radioLootRandGoldYes.Location = new System.Drawing.Point(7, 45);
            radioLootRandGoldYes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioLootRandGoldYes.Name = "radioLootRandGoldYes";
            radioLootRandGoldYes.Size = new System.Drawing.Size(179, 19);
            radioLootRandGoldYes.TabIndex = 0;
            radioLootRandGoldYes.Text = "Randomize into another item";
            radioLootRandGoldYes.UseVisualStyleBackColor = true;
            // 
            // groupLootDeathItem
            // 
            groupLootDeathItem.Controls.Add(radioDeathItemAggressive);
            groupLootDeathItem.Controls.Add(radioDeathItemEnabled);
            groupLootDeathItem.Controls.Add(radioDeathItemDisabled);
            groupLootDeathItem.Location = new System.Drawing.Point(274, 133);
            groupLootDeathItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootDeathItem.Name = "groupLootDeathItem";
            groupLootDeathItem.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootDeathItem.Size = new System.Drawing.Size(218, 104);
            groupLootDeathItem.TabIndex = 15;
            groupLootDeathItem.TabStop = false;
            groupLootDeathItem.Text = "Death item randomization";
            groupLootDeathItem.MouseEnter += groupLootDeathItem_MouseEnter;
            // 
            // radioDeathItemAggressive
            // 
            radioDeathItemAggressive.AutoSize = true;
            radioDeathItemAggressive.Location = new System.Drawing.Point(8, 68);
            radioDeathItemAggressive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioDeathItemAggressive.Name = "radioDeathItemAggressive";
            radioDeathItemAggressive.Size = new System.Drawing.Size(128, 19);
            radioDeathItemAggressive.TabIndex = 2;
            radioDeathItemAggressive.Text = "Enabled, aggressive";
            radioDeathItemAggressive.UseVisualStyleBackColor = true;
            // 
            // radioDeathItemEnabled
            // 
            radioDeathItemEnabled.AutoSize = true;
            radioDeathItemEnabled.Checked = true;
            radioDeathItemEnabled.Location = new System.Drawing.Point(8, 45);
            radioDeathItemEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioDeathItemEnabled.Name = "radioDeathItemEnabled";
            radioDeathItemEnabled.Size = new System.Drawing.Size(111, 19);
            radioDeathItemEnabled.TabIndex = 1;
            radioDeathItemEnabled.TabStop = true;
            radioDeathItemEnabled.Text = "Enabled, normal";
            radioDeathItemEnabled.UseVisualStyleBackColor = true;
            // 
            // radioDeathItemDisabled
            // 
            radioDeathItemDisabled.AutoSize = true;
            radioDeathItemDisabled.Location = new System.Drawing.Point(8, 23);
            radioDeathItemDisabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioDeathItemDisabled.Name = "radioDeathItemDisabled";
            radioDeathItemDisabled.Size = new System.Drawing.Size(70, 19);
            radioDeathItemDisabled.TabIndex = 0;
            radioDeathItemDisabled.Text = "Disabled";
            radioDeathItemDisabled.UseVisualStyleBackColor = true;
            // 
            // groupLootAddItem
            // 
            groupLootAddItem.Controls.Add(radioAddItemAggressive);
            groupLootAddItem.Controls.Add(radioAddItemEnabled);
            groupLootAddItem.Controls.Add(radioAddItemDisabled);
            groupLootAddItem.Location = new System.Drawing.Point(7, 133);
            groupLootAddItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootAddItem.Name = "groupLootAddItem";
            groupLootAddItem.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootAddItem.Size = new System.Drawing.Size(217, 104);
            groupLootAddItem.TabIndex = 14;
            groupLootAddItem.TabStop = false;
            groupLootAddItem.Text = "AddItem randomization";
            groupLootAddItem.MouseEnter += groupLootAddItem_MouseEnter;
            // 
            // radioAddItemAggressive
            // 
            radioAddItemAggressive.AutoSize = true;
            radioAddItemAggressive.Location = new System.Drawing.Point(8, 68);
            radioAddItemAggressive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioAddItemAggressive.Name = "radioAddItemAggressive";
            radioAddItemAggressive.Size = new System.Drawing.Size(128, 19);
            radioAddItemAggressive.TabIndex = 2;
            radioAddItemAggressive.Text = "Enabled, aggressive";
            radioAddItemAggressive.UseVisualStyleBackColor = true;
            // 
            // radioAddItemEnabled
            // 
            radioAddItemEnabled.AutoSize = true;
            radioAddItemEnabled.Checked = true;
            radioAddItemEnabled.Location = new System.Drawing.Point(8, 45);
            radioAddItemEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioAddItemEnabled.Name = "radioAddItemEnabled";
            radioAddItemEnabled.Size = new System.Drawing.Size(111, 19);
            radioAddItemEnabled.TabIndex = 1;
            radioAddItemEnabled.TabStop = true;
            radioAddItemEnabled.Text = "Enabled, normal";
            radioAddItemEnabled.UseVisualStyleBackColor = true;
            // 
            // radioAddItemDisabled
            // 
            radioAddItemDisabled.AutoSize = true;
            radioAddItemDisabled.Location = new System.Drawing.Point(8, 23);
            radioAddItemDisabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioAddItemDisabled.Name = "radioAddItemDisabled";
            radioAddItemDisabled.Size = new System.Drawing.Size(70, 19);
            radioAddItemDisabled.TabIndex = 0;
            radioAddItemDisabled.Text = "Disabled";
            radioAddItemDisabled.UseVisualStyleBackColor = true;
            // 
            // groupLootWorldItem
            // 
            groupLootWorldItem.Controls.Add(radioWorldItemAggressive);
            groupLootWorldItem.Controls.Add(radioWorldItemEnabled);
            groupLootWorldItem.Controls.Add(radioWorldItemDisabled);
            groupLootWorldItem.Location = new System.Drawing.Point(538, 22);
            groupLootWorldItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootWorldItem.Name = "groupLootWorldItem";
            groupLootWorldItem.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootWorldItem.Size = new System.Drawing.Size(219, 104);
            groupLootWorldItem.TabIndex = 13;
            groupLootWorldItem.TabStop = false;
            groupLootWorldItem.Text = "World item randomization";
            groupLootWorldItem.MouseEnter += groupLootWorldItem_MouseEnter;
            // 
            // radioWorldItemAggressive
            // 
            radioWorldItemAggressive.AutoSize = true;
            radioWorldItemAggressive.Location = new System.Drawing.Point(8, 68);
            radioWorldItemAggressive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioWorldItemAggressive.Name = "radioWorldItemAggressive";
            radioWorldItemAggressive.Size = new System.Drawing.Size(128, 19);
            radioWorldItemAggressive.TabIndex = 2;
            radioWorldItemAggressive.Text = "Enabled, aggressive";
            radioWorldItemAggressive.UseVisualStyleBackColor = true;
            // 
            // radioWorldItemEnabled
            // 
            radioWorldItemEnabled.AutoSize = true;
            radioWorldItemEnabled.Checked = true;
            radioWorldItemEnabled.Location = new System.Drawing.Point(8, 45);
            radioWorldItemEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioWorldItemEnabled.Name = "radioWorldItemEnabled";
            radioWorldItemEnabled.Size = new System.Drawing.Size(111, 19);
            radioWorldItemEnabled.TabIndex = 1;
            radioWorldItemEnabled.TabStop = true;
            radioWorldItemEnabled.Text = "Enabled, normal";
            radioWorldItemEnabled.UseVisualStyleBackColor = true;
            // 
            // radioWorldItemDisabled
            // 
            radioWorldItemDisabled.AutoSize = true;
            radioWorldItemDisabled.Location = new System.Drawing.Point(8, 23);
            radioWorldItemDisabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioWorldItemDisabled.Name = "radioWorldItemDisabled";
            radioWorldItemDisabled.Size = new System.Drawing.Size(70, 19);
            radioWorldItemDisabled.TabIndex = 0;
            radioWorldItemDisabled.Text = "Disabled";
            radioWorldItemDisabled.UseVisualStyleBackColor = true;
            // 
            // groupLootRandChestInventory
            // 
            groupLootRandChestInventory.Controls.Add(radioRandChestInventoryAggressive);
            groupLootRandChestInventory.Controls.Add(radioRandChestInventoryEnabled);
            groupLootRandChestInventory.Controls.Add(radioRandChestInventoryDisabled);
            groupLootRandChestInventory.Location = new System.Drawing.Point(274, 22);
            groupLootRandChestInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootRandChestInventory.Name = "groupLootRandChestInventory";
            groupLootRandChestInventory.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootRandChestInventory.Size = new System.Drawing.Size(218, 104);
            groupLootRandChestInventory.TabIndex = 12;
            groupLootRandChestInventory.TabStop = false;
            groupLootRandChestInventory.Text = "Container inventory randomization";
            groupLootRandChestInventory.MouseEnter += groupLootRandChestInventory_MouseEnter;
            // 
            // radioRandChestInventoryAggressive
            // 
            radioRandChestInventoryAggressive.AutoSize = true;
            radioRandChestInventoryAggressive.Location = new System.Drawing.Point(8, 68);
            radioRandChestInventoryAggressive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioRandChestInventoryAggressive.Name = "radioRandChestInventoryAggressive";
            radioRandChestInventoryAggressive.Size = new System.Drawing.Size(128, 19);
            radioRandChestInventoryAggressive.TabIndex = 2;
            radioRandChestInventoryAggressive.Text = "Enabled, aggressive";
            radioRandChestInventoryAggressive.UseVisualStyleBackColor = true;
            // 
            // radioRandChestInventoryEnabled
            // 
            radioRandChestInventoryEnabled.AutoSize = true;
            radioRandChestInventoryEnabled.Checked = true;
            radioRandChestInventoryEnabled.Location = new System.Drawing.Point(8, 45);
            radioRandChestInventoryEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioRandChestInventoryEnabled.Name = "radioRandChestInventoryEnabled";
            radioRandChestInventoryEnabled.Size = new System.Drawing.Size(111, 19);
            radioRandChestInventoryEnabled.TabIndex = 1;
            radioRandChestInventoryEnabled.TabStop = true;
            radioRandChestInventoryEnabled.Text = "Enabled, normal";
            radioRandChestInventoryEnabled.UseVisualStyleBackColor = true;
            // 
            // radioRandChestInventoryDisabled
            // 
            radioRandChestInventoryDisabled.AutoSize = true;
            radioRandChestInventoryDisabled.Location = new System.Drawing.Point(8, 23);
            radioRandChestInventoryDisabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioRandChestInventoryDisabled.Name = "radioRandChestInventoryDisabled";
            radioRandChestInventoryDisabled.Size = new System.Drawing.Size(70, 19);
            radioRandChestInventoryDisabled.TabIndex = 0;
            radioRandChestInventoryDisabled.Text = "Disabled";
            radioRandChestInventoryDisabled.UseVisualStyleBackColor = true;
            // 
            // groupLootRandActorInventory
            // 
            groupLootRandActorInventory.Controls.Add(radioRandActorInventoryAggressive);
            groupLootRandActorInventory.Controls.Add(radioRandActorInventoryEnabled);
            groupLootRandActorInventory.Controls.Add(radioRandActorInventoryDisabled);
            groupLootRandActorInventory.Location = new System.Drawing.Point(7, 22);
            groupLootRandActorInventory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootRandActorInventory.Name = "groupLootRandActorInventory";
            groupLootRandActorInventory.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupLootRandActorInventory.Size = new System.Drawing.Size(217, 104);
            groupLootRandActorInventory.TabIndex = 11;
            groupLootRandActorInventory.TabStop = false;
            groupLootRandActorInventory.Text = "Actor inventory randomization";
            groupLootRandActorInventory.MouseEnter += groupLootRandActorInventory_MouseEnter;
            // 
            // radioRandActorInventoryAggressive
            // 
            radioRandActorInventoryAggressive.AutoSize = true;
            radioRandActorInventoryAggressive.Location = new System.Drawing.Point(8, 68);
            radioRandActorInventoryAggressive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioRandActorInventoryAggressive.Name = "radioRandActorInventoryAggressive";
            radioRandActorInventoryAggressive.Size = new System.Drawing.Size(128, 19);
            radioRandActorInventoryAggressive.TabIndex = 2;
            radioRandActorInventoryAggressive.Text = "Enabled, aggressive";
            radioRandActorInventoryAggressive.UseVisualStyleBackColor = true;
            // 
            // radioRandActorInventoryEnabled
            // 
            radioRandActorInventoryEnabled.AutoSize = true;
            radioRandActorInventoryEnabled.Checked = true;
            radioRandActorInventoryEnabled.Location = new System.Drawing.Point(8, 45);
            radioRandActorInventoryEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioRandActorInventoryEnabled.Name = "radioRandActorInventoryEnabled";
            radioRandActorInventoryEnabled.Size = new System.Drawing.Size(111, 19);
            radioRandActorInventoryEnabled.TabIndex = 1;
            radioRandActorInventoryEnabled.TabStop = true;
            radioRandActorInventoryEnabled.Text = "Enabled, normal";
            radioRandActorInventoryEnabled.UseVisualStyleBackColor = true;
            // 
            // radioRandActorInventoryDisabled
            // 
            radioRandActorInventoryDisabled.AutoSize = true;
            radioRandActorInventoryDisabled.Location = new System.Drawing.Point(8, 23);
            radioRandActorInventoryDisabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioRandActorInventoryDisabled.Name = "radioRandActorInventoryDisabled";
            radioRandActorInventoryDisabled.Size = new System.Drawing.Size(70, 19);
            radioRandActorInventoryDisabled.TabIndex = 0;
            radioRandActorInventoryDisabled.Text = "Disabled";
            radioRandActorInventoryDisabled.UseVisualStyleBackColor = true;
            // 
            // tabActorSettings
            // 
            tabActorSettings.Controls.Add(groupActors);
            tabActorSettings.Location = new System.Drawing.Point(4, 24);
            tabActorSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabActorSettings.Name = "tabActorSettings";
            tabActorSettings.Size = new System.Drawing.Size(781, 390);
            tabActorSettings.TabIndex = 2;
            tabActorSettings.Text = "Actor settings";
            tabActorSettings.UseVisualStyleBackColor = true;
            // 
            // groupActors
            // 
            groupActors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            groupActors.Controls.Add(groupNPCRandomizeStats);
            groupActors.Controls.Add(groupNPCActorScaling);
            groupActors.Controls.Add(groupNPCRestoreAttributes);
            groupActors.Controls.Add(groupNPCRandomizeAttributes);
            groupActors.Controls.Add(groupNPCVampire);
            groupActors.Location = new System.Drawing.Point(7, 7);
            groupActors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupActors.Name = "groupActors";
            groupActors.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupActors.Size = new System.Drawing.Size(765, 352);
            groupActors.TabIndex = 1;
            groupActors.TabStop = false;
            groupActors.Text = "Actor parameters";
            // 
            // groupNPCRandomizeStats
            // 
            groupNPCRandomizeStats.Controls.Add(radioStatAll);
            groupNPCRandomizeStats.Controls.Add(radioStatNonEssential);
            groupNPCRandomizeStats.Controls.Add(radioStatDisabled);
            groupNPCRandomizeStats.Location = new System.Drawing.Point(8, 132);
            groupNPCRandomizeStats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupNPCRandomizeStats.Name = "groupNPCRandomizeStats";
            groupNPCRandomizeStats.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupNPCRandomizeStats.Size = new System.Drawing.Size(218, 104);
            groupNPCRandomizeStats.TabIndex = 10;
            groupNPCRandomizeStats.TabStop = false;
            groupNPCRandomizeStats.Text = "Actor stat randomization";
            groupNPCRandomizeStats.MouseEnter += groupNPCRandomizeStats_MouseEnter;
            // 
            // radioStatAll
            // 
            radioStatAll.AutoSize = true;
            radioStatAll.Location = new System.Drawing.Point(9, 68);
            radioStatAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioStatAll.Name = "radioStatAll";
            radioStatAll.Size = new System.Drawing.Size(100, 19);
            radioStatAll.TabIndex = 2;
            radioStatAll.Text = "Enabled for all";
            radioStatAll.UseVisualStyleBackColor = true;
            // 
            // radioStatNonEssential
            // 
            radioStatNonEssential.AutoSize = true;
            radioStatNonEssential.Checked = true;
            radioStatNonEssential.Location = new System.Drawing.Point(9, 45);
            radioStatNonEssential.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioStatNonEssential.Name = "radioStatNonEssential";
            radioStatNonEssential.Size = new System.Drawing.Size(177, 19);
            radioStatNonEssential.TabIndex = 1;
            radioStatNonEssential.TabStop = true;
            radioStatNonEssential.Text = "Only for non-essential actors";
            radioStatNonEssential.UseVisualStyleBackColor = true;
            // 
            // radioStatDisabled
            // 
            radioStatDisabled.AutoSize = true;
            radioStatDisabled.Location = new System.Drawing.Point(9, 23);
            radioStatDisabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioStatDisabled.Name = "radioStatDisabled";
            radioStatDisabled.Size = new System.Drawing.Size(70, 19);
            radioStatDisabled.TabIndex = 0;
            radioStatDisabled.Text = "Disabled";
            radioStatDisabled.UseVisualStyleBackColor = true;
            // 
            // groupNPCActorScaling
            // 
            groupNPCActorScaling.Controls.Add(checkActorScaling);
            groupNPCActorScaling.Controls.Add(panelActorScaling);
            groupNPCActorScaling.Location = new System.Drawing.Point(538, 22);
            groupNPCActorScaling.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupNPCActorScaling.Name = "groupNPCActorScaling";
            groupNPCActorScaling.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupNPCActorScaling.Size = new System.Drawing.Size(218, 132);
            groupNPCActorScaling.TabIndex = 9;
            groupNPCActorScaling.TabStop = false;
            groupNPCActorScaling.Text = "Actor size scaling";
            groupNPCActorScaling.MouseEnter += groupNPCActorScaling_MouseEnter;
            // 
            // checkActorScaling
            // 
            checkActorScaling.AutoSize = true;
            checkActorScaling.Location = new System.Drawing.Point(8, 23);
            checkActorScaling.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkActorScaling.Name = "checkActorScaling";
            checkActorScaling.Size = new System.Drawing.Size(68, 19);
            checkActorScaling.TabIndex = 4;
            checkActorScaling.Text = "Enabled";
            checkActorScaling.UseVisualStyleBackColor = true;
            checkActorScaling.CheckedChanged += checkActorScaling_CheckedChanged;
            // 
            // panelActorScaling
            // 
            panelActorScaling.Controls.Add(label2);
            panelActorScaling.Controls.Add(textActorScalingMin);
            panelActorScaling.Controls.Add(label1);
            panelActorScaling.Controls.Add(textActorScalingMax);
            panelActorScaling.Enabled = false;
            panelActorScaling.Location = new System.Drawing.Point(7, 48);
            panelActorScaling.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelActorScaling.Name = "panelActorScaling";
            panelActorScaling.Size = new System.Drawing.Size(187, 73);
            panelActorScaling.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 39);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 15);
            label2.TabIndex = 6;
            label2.Text = "Max";
            // 
            // textActorScalingMin
            // 
            textActorScalingMin.Location = new System.Drawing.Point(40, 9);
            textActorScalingMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textActorScalingMin.Name = "textActorScalingMin";
            textActorScalingMin.Size = new System.Drawing.Size(116, 23);
            textActorScalingMin.TabIndex = 3;
            textActorScalingMin.Validating += textActorScalingMin_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 13);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(28, 15);
            label1.TabIndex = 5;
            label1.Text = "Min";
            // 
            // textActorScalingMax
            // 
            textActorScalingMax.Location = new System.Drawing.Point(40, 36);
            textActorScalingMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textActorScalingMax.Name = "textActorScalingMax";
            textActorScalingMax.Size = new System.Drawing.Size(116, 23);
            textActorScalingMax.TabIndex = 4;
            textActorScalingMax.Validating += textActorScalingMax_Validating;
            // 
            // groupNPCRestoreAttributes
            // 
            groupNPCRestoreAttributes.Controls.Add(radioRestoreActorAttribNo);
            groupNPCRestoreAttributes.Controls.Add(radioRestoreActorAttribYes);
            groupNPCRestoreAttributes.Location = new System.Drawing.Point(274, 22);
            groupNPCRestoreAttributes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupNPCRestoreAttributes.Name = "groupNPCRestoreAttributes";
            groupNPCRestoreAttributes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupNPCRestoreAttributes.Size = new System.Drawing.Size(218, 73);
            groupNPCRestoreAttributes.TabIndex = 8;
            groupNPCRestoreAttributes.TabStop = false;
            groupNPCRestoreAttributes.Text = "Actor attribute restoration";
            groupNPCRestoreAttributes.MouseEnter += groupNPCRestoreAttributes_MouseEnter;
            // 
            // radioRestoreActorAttribNo
            // 
            radioRestoreActorAttribNo.AutoSize = true;
            radioRestoreActorAttribNo.Checked = true;
            radioRestoreActorAttribNo.Location = new System.Drawing.Point(8, 45);
            radioRestoreActorAttribNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioRestoreActorAttribNo.Name = "radioRestoreActorAttribNo";
            radioRestoreActorAttribNo.Size = new System.Drawing.Size(41, 19);
            radioRestoreActorAttribNo.TabIndex = 1;
            radioRestoreActorAttribNo.TabStop = true;
            radioRestoreActorAttribNo.Text = "No";
            radioRestoreActorAttribNo.UseVisualStyleBackColor = true;
            // 
            // radioRestoreActorAttribYes
            // 
            radioRestoreActorAttribYes.AutoSize = true;
            radioRestoreActorAttribYes.Location = new System.Drawing.Point(8, 23);
            radioRestoreActorAttribYes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioRestoreActorAttribYes.Name = "radioRestoreActorAttribYes";
            radioRestoreActorAttribYes.Size = new System.Drawing.Size(42, 19);
            radioRestoreActorAttribYes.TabIndex = 0;
            radioRestoreActorAttribYes.Text = "Yes";
            radioRestoreActorAttribYes.UseVisualStyleBackColor = true;
            radioRestoreActorAttribYes.CheckedChanged += radioRestoreActorAttribYes_CheckedChanged;
            // 
            // groupNPCRandomizeAttributes
            // 
            groupNPCRandomizeAttributes.Controls.Add(radioAttribAll);
            groupNPCRandomizeAttributes.Controls.Add(radioAttribNonEssential);
            groupNPCRandomizeAttributes.Controls.Add(radioAttribDisabled);
            groupNPCRandomizeAttributes.Location = new System.Drawing.Point(8, 22);
            groupNPCRandomizeAttributes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupNPCRandomizeAttributes.Name = "groupNPCRandomizeAttributes";
            groupNPCRandomizeAttributes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupNPCRandomizeAttributes.Size = new System.Drawing.Size(218, 102);
            groupNPCRandomizeAttributes.TabIndex = 7;
            groupNPCRandomizeAttributes.TabStop = false;
            groupNPCRandomizeAttributes.Text = "Actor attribute randomization";
            groupNPCRandomizeAttributes.MouseEnter += groupNPCRandomizeAttributes_MouseEnter;
            // 
            // radioAttribAll
            // 
            radioAttribAll.AutoSize = true;
            radioAttribAll.Location = new System.Drawing.Point(8, 68);
            radioAttribAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioAttribAll.Name = "radioAttribAll";
            radioAttribAll.Size = new System.Drawing.Size(100, 19);
            radioAttribAll.TabIndex = 2;
            radioAttribAll.Text = "Enabled for all";
            radioAttribAll.UseVisualStyleBackColor = true;
            // 
            // radioAttribNonEssential
            // 
            radioAttribNonEssential.AutoSize = true;
            radioAttribNonEssential.Checked = true;
            radioAttribNonEssential.Location = new System.Drawing.Point(8, 45);
            radioAttribNonEssential.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioAttribNonEssential.Name = "radioAttribNonEssential";
            radioAttribNonEssential.Size = new System.Drawing.Size(177, 19);
            radioAttribNonEssential.TabIndex = 1;
            radioAttribNonEssential.TabStop = true;
            radioAttribNonEssential.Text = "Only for non-essential actors";
            radioAttribNonEssential.UseVisualStyleBackColor = true;
            // 
            // radioAttribDisabled
            // 
            radioAttribDisabled.AutoSize = true;
            radioAttribDisabled.Location = new System.Drawing.Point(8, 23);
            radioAttribDisabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioAttribDisabled.Name = "radioAttribDisabled";
            radioAttribDisabled.Size = new System.Drawing.Size(70, 19);
            radioAttribDisabled.TabIndex = 0;
            radioAttribDisabled.Text = "Disabled";
            radioAttribDisabled.UseVisualStyleBackColor = true;
            // 
            // groupNPCVampire
            // 
            groupNPCVampire.Controls.Add(numericVampire);
            groupNPCVampire.Location = new System.Drawing.Point(274, 110);
            groupNPCVampire.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupNPCVampire.Name = "groupNPCVampire";
            groupNPCVampire.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupNPCVampire.Size = new System.Drawing.Size(218, 61);
            groupNPCVampire.TabIndex = 6;
            groupNPCVampire.TabStop = false;
            groupNPCVampire.Text = "Vampirism chance (%)";
            groupNPCVampire.MouseEnter += groupNPCVampire_MouseEnter;
            // 
            // numericVampire
            // 
            numericVampire.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericVampire.Location = new System.Drawing.Point(8, 22);
            numericVampire.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericVampire.Name = "numericVampire";
            numericVampire.Size = new System.Drawing.Size(140, 23);
            numericVampire.TabIndex = 0;
            numericVampire.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // tabCreatureSettings
            // 
            tabCreatureSettings.Controls.Add(groupCreatures);
            tabCreatureSettings.Location = new System.Drawing.Point(4, 24);
            tabCreatureSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabCreatureSettings.Name = "tabCreatureSettings";
            tabCreatureSettings.Size = new System.Drawing.Size(781, 390);
            tabCreatureSettings.TabIndex = 3;
            tabCreatureSettings.Text = "Creature settings";
            tabCreatureSettings.UseVisualStyleBackColor = true;
            // 
            // groupCreatures
            // 
            groupCreatures.Anchor = System.Windows.Forms.AnchorStyles.Top;
            groupCreatures.Controls.Add(groupUseEssentialCreatures);
            groupCreatures.Controls.Add(groupExcludeHorses);
            groupCreatures.Controls.Add(groupMiscRandCreatures);
            groupCreatures.Location = new System.Drawing.Point(7, 7);
            groupCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupCreatures.Name = "groupCreatures";
            groupCreatures.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupCreatures.Size = new System.Drawing.Size(765, 143);
            groupCreatures.TabIndex = 3;
            groupCreatures.TabStop = false;
            groupCreatures.Text = "Creatures";
            // 
            // groupUseEssentialCreatures
            // 
            groupUseEssentialCreatures.Controls.Add(radioUseEssentialCreaturesYes);
            groupUseEssentialCreatures.Controls.Add(radioUseEssentialCreaturesNo);
            groupUseEssentialCreatures.Location = new System.Drawing.Point(273, 22);
            groupUseEssentialCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupUseEssentialCreatures.Name = "groupUseEssentialCreatures";
            groupUseEssentialCreatures.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupUseEssentialCreatures.Size = new System.Drawing.Size(219, 70);
            groupUseEssentialCreatures.TabIndex = 12;
            groupUseEssentialCreatures.TabStop = false;
            groupUseEssentialCreatures.Text = "Use essential creatures";
            groupUseEssentialCreatures.MouseEnter += groupUseEssentialCreatures_MouseEnter;
            // 
            // radioUseEssentialCreaturesYes
            // 
            radioUseEssentialCreaturesYes.AutoSize = true;
            radioUseEssentialCreaturesYes.Location = new System.Drawing.Point(7, 22);
            radioUseEssentialCreaturesYes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioUseEssentialCreaturesYes.Name = "radioUseEssentialCreaturesYes";
            radioUseEssentialCreaturesYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            radioUseEssentialCreaturesYes.Size = new System.Drawing.Size(42, 19);
            radioUseEssentialCreaturesYes.TabIndex = 0;
            radioUseEssentialCreaturesYes.Text = "Yes";
            radioUseEssentialCreaturesYes.UseVisualStyleBackColor = true;
            // 
            // radioUseEssentialCreaturesNo
            // 
            radioUseEssentialCreaturesNo.AutoSize = true;
            radioUseEssentialCreaturesNo.Checked = true;
            radioUseEssentialCreaturesNo.Location = new System.Drawing.Point(7, 44);
            radioUseEssentialCreaturesNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioUseEssentialCreaturesNo.Name = "radioUseEssentialCreaturesNo";
            radioUseEssentialCreaturesNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            radioUseEssentialCreaturesNo.Size = new System.Drawing.Size(41, 19);
            radioUseEssentialCreaturesNo.TabIndex = 1;
            radioUseEssentialCreaturesNo.TabStop = true;
            radioUseEssentialCreaturesNo.Text = "No";
            radioUseEssentialCreaturesNo.UseVisualStyleBackColor = true;
            // 
            // groupExcludeHorses
            // 
            groupExcludeHorses.Controls.Add(radioExcludeHorsesYes);
            groupExcludeHorses.Controls.Add(radioExcludeHorsesNo);
            groupExcludeHorses.Location = new System.Drawing.Point(539, 22);
            groupExcludeHorses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupExcludeHorses.Name = "groupExcludeHorses";
            groupExcludeHorses.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupExcludeHorses.Size = new System.Drawing.Size(219, 70);
            groupExcludeHorses.TabIndex = 11;
            groupExcludeHorses.TabStop = false;
            groupExcludeHorses.Text = "Exclude horses";
            groupExcludeHorses.MouseEnter += groupExcludeHorses_MouseEnter;
            // 
            // radioExcludeHorsesYes
            // 
            radioExcludeHorsesYes.AutoSize = true;
            radioExcludeHorsesYes.Checked = true;
            radioExcludeHorsesYes.Location = new System.Drawing.Point(7, 22);
            radioExcludeHorsesYes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioExcludeHorsesYes.Name = "radioExcludeHorsesYes";
            radioExcludeHorsesYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            radioExcludeHorsesYes.Size = new System.Drawing.Size(131, 19);
            radioExcludeHorsesYes.TabIndex = 0;
            radioExcludeHorsesYes.TabStop = true;
            radioExcludeHorsesYes.Text = "Yes (recommended)";
            radioExcludeHorsesYes.UseVisualStyleBackColor = true;
            // 
            // radioExcludeHorsesNo
            // 
            radioExcludeHorsesNo.AutoSize = true;
            radioExcludeHorsesNo.Location = new System.Drawing.Point(7, 44);
            radioExcludeHorsesNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioExcludeHorsesNo.Name = "radioExcludeHorsesNo";
            radioExcludeHorsesNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            radioExcludeHorsesNo.Size = new System.Drawing.Size(41, 19);
            radioExcludeHorsesNo.TabIndex = 1;
            radioExcludeHorsesNo.Text = "No";
            radioExcludeHorsesNo.UseVisualStyleBackColor = true;
            // 
            // groupMiscRandCreatures
            // 
            groupMiscRandCreatures.Controls.Add(radioRandCreaturesUnstable);
            groupMiscRandCreatures.Controls.Add(radioRandCreaturesEnabled);
            groupMiscRandCreatures.Controls.Add(radioRandCreaturesDisabled);
            groupMiscRandCreatures.Location = new System.Drawing.Point(7, 22);
            groupMiscRandCreatures.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscRandCreatures.Name = "groupMiscRandCreatures";
            groupMiscRandCreatures.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupMiscRandCreatures.Size = new System.Drawing.Size(218, 104);
            groupMiscRandCreatures.TabIndex = 10;
            groupMiscRandCreatures.TabStop = false;
            groupMiscRandCreatures.Text = "Creature randomziation";
            groupMiscRandCreatures.MouseEnter += groupMiscRandCreatures_MouseEnter;
            // 
            // radioRandCreaturesUnstable
            // 
            radioRandCreaturesUnstable.AutoSize = true;
            radioRandCreaturesUnstable.Location = new System.Drawing.Point(8, 68);
            radioRandCreaturesUnstable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioRandCreaturesUnstable.Name = "radioRandCreaturesUnstable";
            radioRandCreaturesUnstable.Size = new System.Drawing.Size(118, 19);
            radioRandCreaturesUnstable.TabIndex = 2;
            radioRandCreaturesUnstable.Text = "Enabled, unstable";
            radioRandCreaturesUnstable.UseVisualStyleBackColor = true;
            // 
            // radioRandCreaturesEnabled
            // 
            radioRandCreaturesEnabled.AutoSize = true;
            radioRandCreaturesEnabled.Checked = true;
            radioRandCreaturesEnabled.Location = new System.Drawing.Point(8, 45);
            radioRandCreaturesEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioRandCreaturesEnabled.Name = "radioRandCreaturesEnabled";
            radioRandCreaturesEnabled.Size = new System.Drawing.Size(111, 19);
            radioRandCreaturesEnabled.TabIndex = 1;
            radioRandCreaturesEnabled.TabStop = true;
            radioRandCreaturesEnabled.Text = "Enabled, normal";
            radioRandCreaturesEnabled.UseVisualStyleBackColor = true;
            // 
            // radioRandCreaturesDisabled
            // 
            radioRandCreaturesDisabled.AutoSize = true;
            radioRandCreaturesDisabled.Location = new System.Drawing.Point(8, 23);
            radioRandCreaturesDisabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioRandCreaturesDisabled.Name = "radioRandCreaturesDisabled";
            radioRandCreaturesDisabled.Size = new System.Drawing.Size(70, 19);
            radioRandCreaturesDisabled.TabIndex = 0;
            radioRandCreaturesDisabled.Text = "Disabled";
            radioRandCreaturesDisabled.UseVisualStyleBackColor = true;
            // 
            // tabExcludes
            // 
            tabExcludes.Controls.Add(buttonReloadExcludes);
            tabExcludes.Controls.Add(buttonSaveExcludes);
            tabExcludes.Controls.Add(groupDontAddToRandomizerLists);
            tabExcludes.Controls.Add(groupDontRandomize);
            tabExcludes.Controls.Add(groupCurrentMods);
            tabExcludes.Location = new System.Drawing.Point(4, 24);
            tabExcludes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabExcludes.Name = "tabExcludes";
            tabExcludes.Size = new System.Drawing.Size(781, 390);
            tabExcludes.TabIndex = 4;
            tabExcludes.Text = "Mod excludes";
            tabExcludes.UseVisualStyleBackColor = true;
            // 
            // buttonReloadExcludes
            // 
            buttonReloadExcludes.Location = new System.Drawing.Point(416, 331);
            buttonReloadExcludes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonReloadExcludes.Name = "buttonReloadExcludes";
            buttonReloadExcludes.Size = new System.Drawing.Size(340, 27);
            buttonReloadExcludes.TabIndex = 5;
            buttonReloadExcludes.Text = "Reload RandomizerSkip.cfg";
            buttonReloadExcludes.UseVisualStyleBackColor = true;
            buttonReloadExcludes.Click += buttonReloadExcludes_Click;
            // 
            // buttonSaveExcludes
            // 
            buttonSaveExcludes.Location = new System.Drawing.Point(14, 331);
            buttonSaveExcludes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSaveExcludes.Name = "buttonSaveExcludes";
            buttonSaveExcludes.Size = new System.Drawing.Size(340, 27);
            buttonSaveExcludes.TabIndex = 4;
            buttonSaveExcludes.Text = "Save to RandomizerSkip.cfg";
            buttonSaveExcludes.UseVisualStyleBackColor = true;
            buttonSaveExcludes.Click += buttonSaveExcludes_Click;
            // 
            // groupDontAddToRandomizerLists
            // 
            groupDontAddToRandomizerLists.Controls.Add(buttonDontAddToLists);
            groupDontAddToRandomizerLists.Controls.Add(textBoxDontAddToLists);
            groupDontAddToRandomizerLists.Location = new System.Drawing.Point(265, 7);
            groupDontAddToRandomizerLists.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupDontAddToRandomizerLists.Name = "groupDontAddToRandomizerLists";
            groupDontAddToRandomizerLists.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupDontAddToRandomizerLists.Size = new System.Drawing.Size(233, 298);
            groupDontAddToRandomizerLists.TabIndex = 3;
            groupDontAddToRandomizerLists.TabStop = false;
            groupDontAddToRandomizerLists.Text = "Don't add to lists";
            groupDontAddToRandomizerLists.MouseEnter += textBoxDontAddToLists_MouseEnter;
            // 
            // buttonDontAddToLists
            // 
            buttonDontAddToLists.Location = new System.Drawing.Point(7, 264);
            buttonDontAddToLists.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonDontAddToLists.Name = "buttonDontAddToLists";
            buttonDontAddToLists.Size = new System.Drawing.Size(219, 27);
            buttonDontAddToLists.TabIndex = 3;
            buttonDontAddToLists.Text = "Paste selection from \"Your mods\"";
            buttonDontAddToLists.UseVisualStyleBackColor = true;
            buttonDontAddToLists.Click += buttonDontAddToLists_Click;
            buttonDontAddToLists.MouseEnter += buttonDontAddToLists_MouseEnter;
            // 
            // textBoxDontAddToLists
            // 
            textBoxDontAddToLists.AllowDrop = true;
            textBoxDontAddToLists.Location = new System.Drawing.Point(8, 22);
            textBoxDontAddToLists.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxDontAddToLists.Multiline = true;
            textBoxDontAddToLists.Name = "textBoxDontAddToLists";
            textBoxDontAddToLists.Size = new System.Drawing.Size(218, 235);
            textBoxDontAddToLists.TabIndex = 2;
            textBoxDontAddToLists.DragDrop += textBoxDontAddToLists_DragDrop;
            textBoxDontAddToLists.DragEnter += listDontRandomize_DragEnter;
            textBoxDontAddToLists.MouseEnter += textBoxDontAddToLists_MouseEnter;
            // 
            // groupDontRandomize
            // 
            groupDontRandomize.Controls.Add(buttonDontRandomizePaste);
            groupDontRandomize.Controls.Add(textBoxDontRandomize);
            groupDontRandomize.Location = new System.Drawing.Point(523, 7);
            groupDontRandomize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupDontRandomize.Name = "groupDontRandomize";
            groupDontRandomize.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupDontRandomize.Size = new System.Drawing.Size(233, 298);
            groupDontRandomize.TabIndex = 2;
            groupDontRandomize.TabStop = false;
            groupDontRandomize.Text = "Don't randomize";
            groupDontRandomize.MouseEnter += textBoxDontRandomize_MouseEnter;
            // 
            // buttonDontRandomizePaste
            // 
            buttonDontRandomizePaste.Location = new System.Drawing.Point(7, 264);
            buttonDontRandomizePaste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonDontRandomizePaste.Name = "buttonDontRandomizePaste";
            buttonDontRandomizePaste.Size = new System.Drawing.Size(219, 27);
            buttonDontRandomizePaste.TabIndex = 1;
            buttonDontRandomizePaste.Text = "Paste selection from \"Your mods\"";
            buttonDontRandomizePaste.UseVisualStyleBackColor = true;
            buttonDontRandomizePaste.Click += buttonDontRandomizePaste_Click;
            buttonDontRandomizePaste.MouseEnter += buttonDontRandomizePaste_MouseEnter;
            // 
            // textBoxDontRandomize
            // 
            textBoxDontRandomize.AllowDrop = true;
            textBoxDontRandomize.Location = new System.Drawing.Point(8, 22);
            textBoxDontRandomize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxDontRandomize.Multiline = true;
            textBoxDontRandomize.Name = "textBoxDontRandomize";
            textBoxDontRandomize.Size = new System.Drawing.Size(218, 235);
            textBoxDontRandomize.TabIndex = 0;
            textBoxDontRandomize.DragDrop += listDontRandomize_DragDrop;
            textBoxDontRandomize.DragEnter += listDontRandomize_DragEnter;
            textBoxDontRandomize.MouseEnter += textBoxDontRandomize_MouseEnter;
            // 
            // groupCurrentMods
            // 
            groupCurrentMods.Controls.Add(listMods);
            groupCurrentMods.Location = new System.Drawing.Point(7, 7);
            groupCurrentMods.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupCurrentMods.Name = "groupCurrentMods";
            groupCurrentMods.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupCurrentMods.Size = new System.Drawing.Size(233, 298);
            groupCurrentMods.TabIndex = 1;
            groupCurrentMods.TabStop = false;
            groupCurrentMods.Text = "Your mods";
            // 
            // listMods
            // 
            listMods.AllowDrop = true;
            listMods.FormattingEnabled = true;
            listMods.ItemHeight = 15;
            listMods.Location = new System.Drawing.Point(7, 22);
            listMods.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listMods.Name = "listMods";
            listMods.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            listMods.Size = new System.Drawing.Size(219, 259);
            listMods.Sorted = true;
            listMods.TabIndex = 2;
            listMods.MouseEnter += listMods_MouseEnter;
            // 
            // textBoxHelp
            // 
            textBoxHelp.Location = new System.Drawing.Point(811, 39);
            textBoxHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxHelp.Multiline = true;
            textBoxHelp.Name = "textBoxHelp";
            textBoxHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxHelp.Size = new System.Drawing.Size(300, 292);
            textBoxHelp.TabIndex = 1;
            textBoxHelp.Text = "Hover over an element to display help";
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(497, 437);
            buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(147, 27);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save to main config";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            buttonSave.MouseEnter += buttonSave_MouseEnter;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new System.Drawing.Point(651, 437);
            buttonLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new System.Drawing.Size(147, 27);
            buttonLoad.TabIndex = 3;
            buttonLoad.Text = "Load from main config";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            buttonLoad.MouseEnter += buttonLoad_MouseEnter;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // comboTemplates
            // 
            comboTemplates.FormattingEnabled = true;
            comboTemplates.Location = new System.Drawing.Point(880, 339);
            comboTemplates.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboTemplates.Name = "comboTemplates";
            comboTemplates.Size = new System.Drawing.Size(231, 23);
            comboTemplates.TabIndex = 4;
            comboTemplates.MouseEnter += labelTemplates_MouseEnter;
            // 
            // labelTemplates
            // 
            labelTemplates.AutoSize = true;
            labelTemplates.Location = new System.Drawing.Point(810, 343);
            labelTemplates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelTemplates.Name = "labelTemplates";
            labelTemplates.Size = new System.Drawing.Size(59, 15);
            labelTemplates.TabIndex = 5;
            labelTemplates.Text = "Template:";
            labelTemplates.MouseEnter += labelTemplates_MouseEnter;
            // 
            // buttonSaveTemplate
            // 
            buttonSaveTemplate.Location = new System.Drawing.Point(813, 404);
            buttonSaveTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSaveTemplate.Name = "buttonSaveTemplate";
            buttonSaveTemplate.Size = new System.Drawing.Size(302, 27);
            buttonSaveTemplate.TabIndex = 6;
            buttonSaveTemplate.Text = "Save current settings to template";
            buttonSaveTemplate.UseVisualStyleBackColor = true;
            buttonSaveTemplate.Click += buttonSaveTemplate_Click;
            buttonSaveTemplate.MouseEnter += labelTemplates_MouseEnter;
            // 
            // buttonLoadTemplate
            // 
            buttonLoadTemplate.Location = new System.Drawing.Point(813, 370);
            buttonLoadTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonLoadTemplate.Name = "buttonLoadTemplate";
            buttonLoadTemplate.Size = new System.Drawing.Size(302, 27);
            buttonLoadTemplate.TabIndex = 7;
            buttonLoadTemplate.Text = "Load template";
            buttonLoadTemplate.UseVisualStyleBackColor = true;
            buttonLoadTemplate.Click += buttonLoadTemplate_Click;
            buttonLoadTemplate.MouseEnter += labelTemplates_MouseEnter;
            // 
            // buttonDeleteTemplate
            // 
            buttonDeleteTemplate.Location = new System.Drawing.Point(814, 437);
            buttonDeleteTemplate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonDeleteTemplate.Name = "buttonDeleteTemplate";
            buttonDeleteTemplate.Size = new System.Drawing.Size(301, 27);
            buttonDeleteTemplate.TabIndex = 8;
            buttonDeleteTemplate.Text = "Delete template";
            buttonDeleteTemplate.UseVisualStyleBackColor = true;
            buttonDeleteTemplate.Click += buttonDeleteTemplate_Click;
            buttonDeleteTemplate.MouseEnter += labelTemplates_MouseEnter;
            // 
            // labelLastLoaded
            // 
            labelLastLoaded.AutoSize = true;
            labelLastLoaded.Location = new System.Drawing.Point(15, 443);
            labelLastLoaded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLastLoaded.Name = "labelLastLoaded";
            labelLastLoaded.Size = new System.Drawing.Size(117, 15);
            labelLastLoaded.TabIndex = 9;
            labelLastLoaded.Text = "Currently loaded file:";
            // 
            // RandConfigForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1126, 490);
            Controls.Add(labelLastLoaded);
            Controls.Add(buttonLoad);
            Controls.Add(buttonDeleteTemplate);
            Controls.Add(buttonLoadTemplate);
            Controls.Add(buttonSaveTemplate);
            Controls.Add(labelTemplates);
            Controls.Add(comboTemplates);
            Controls.Add(buttonSave);
            Controls.Add(textBoxHelp);
            Controls.Add(tabs);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1142, 529);
            MinimumSize = new System.Drawing.Size(1142, 529);
            Name = "RandConfigForm";
            Text = "Oblivion Randomizer Config";
            Load += RandConfigForm_Load;
            tabs.ResumeLayout(false);
            tabMiscSettings.ResumeLayout(false);
            groupMisc.ResumeLayout(false);
            groupMiscSeed.ResumeLayout(false);
            groupMiscSeed.PerformLayout();
            groupMiscPatches.ResumeLayout(false);
            groupMiscPatches.PerformLayout();
            groupMiscHitEffect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericHitEffect).EndInit();
            groupMiscDelayStart.ResumeLayout(false);
            groupMiscDelayStart.PerformLayout();
            groupMiscQuestObjects.ResumeLayout(false);
            groupMiscQuestObjects.PerformLayout();
            groupMiscSpells.ResumeLayout(false);
            groupMiscSpells.PerformLayout();
            tabLootSettings.ResumeLayout(false);
            groupLoot.ResumeLayout(false);
            groupLootExcludeUnplayableItems.ResumeLayout(false);
            groupLootExcludeUnplayableItems.PerformLayout();
            groupLootGold.ResumeLayout(false);
            groupLootGold.PerformLayout();
            groupLootDeathItem.ResumeLayout(false);
            groupLootDeathItem.PerformLayout();
            groupLootAddItem.ResumeLayout(false);
            groupLootAddItem.PerformLayout();
            groupLootWorldItem.ResumeLayout(false);
            groupLootWorldItem.PerformLayout();
            groupLootRandChestInventory.ResumeLayout(false);
            groupLootRandChestInventory.PerformLayout();
            groupLootRandActorInventory.ResumeLayout(false);
            groupLootRandActorInventory.PerformLayout();
            tabActorSettings.ResumeLayout(false);
            groupActors.ResumeLayout(false);
            groupNPCRandomizeStats.ResumeLayout(false);
            groupNPCRandomizeStats.PerformLayout();
            groupNPCActorScaling.ResumeLayout(false);
            groupNPCActorScaling.PerformLayout();
            panelActorScaling.ResumeLayout(false);
            panelActorScaling.PerformLayout();
            groupNPCRestoreAttributes.ResumeLayout(false);
            groupNPCRestoreAttributes.PerformLayout();
            groupNPCRandomizeAttributes.ResumeLayout(false);
            groupNPCRandomizeAttributes.PerformLayout();
            groupNPCVampire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericVampire).EndInit();
            tabCreatureSettings.ResumeLayout(false);
            groupCreatures.ResumeLayout(false);
            groupUseEssentialCreatures.ResumeLayout(false);
            groupUseEssentialCreatures.PerformLayout();
            groupExcludeHorses.ResumeLayout(false);
            groupExcludeHorses.PerformLayout();
            groupMiscRandCreatures.ResumeLayout(false);
            groupMiscRandCreatures.PerformLayout();
            tabExcludes.ResumeLayout(false);
            groupDontAddToRandomizerLists.ResumeLayout(false);
            groupDontAddToRandomizerLists.PerformLayout();
            groupDontRandomize.ResumeLayout(false);
            groupDontRandomize.PerformLayout();
            groupCurrentMods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabMiscSettings;
        private System.Windows.Forms.TabPage tabLootSettings;
        private System.Windows.Forms.GroupBox groupLoot;
        private System.Windows.Forms.GroupBox groupActors;
        private System.Windows.Forms.GroupBox groupMisc;
        private System.Windows.Forms.RadioButton radioExcludeQuestYes;
        private System.Windows.Forms.RadioButton radioExcludeQuestNo;
        private System.Windows.Forms.GroupBox groupMiscDelayStart;
        private System.Windows.Forms.RadioButton radioDelayStartNo;
        private System.Windows.Forms.RadioButton radioDelayStartYes;
        private System.Windows.Forms.GroupBox groupMiscQuestObjects;
        private System.Windows.Forms.GroupBox groupMiscHitEffect;
        private System.Windows.Forms.NumericUpDown numericHitEffect;
        private System.Windows.Forms.GroupBox groupMiscPatches;
        private System.Windows.Forms.CheckBox checkInvalidCreatureDataPatch;
        private System.Windows.Forms.CheckBox checkInvalidTexturePatch;
        private System.Windows.Forms.GroupBox groupMiscSpells;
        private System.Windows.Forms.RadioButton radioSpellsDisabled;
        private System.Windows.Forms.RadioButton radioSpells1;
        private System.Windows.Forms.GroupBox groupNPCVampire;
        private System.Windows.Forms.NumericUpDown numericVampire;
        private System.Windows.Forms.GroupBox groupNPCRandomizeAttributes;
        private System.Windows.Forms.RadioButton radioAttribNonEssential;
        private System.Windows.Forms.RadioButton radioAttribDisabled;
        private System.Windows.Forms.RadioButton radioAttribAll;
        private System.Windows.Forms.GroupBox groupNPCRestoreAttributes;
        private System.Windows.Forms.RadioButton radioRestoreActorAttribNo;
        private System.Windows.Forms.RadioButton radioRestoreActorAttribYes;
        private System.Windows.Forms.GroupBox groupNPCActorScaling;
        private System.Windows.Forms.TextBox textActorScalingMax;
        private System.Windows.Forms.TextBox textActorScalingMin;
        private System.Windows.Forms.Panel panelActorScaling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkActorScaling;
        private System.Windows.Forms.GroupBox groupMiscRandCreatures;
        private System.Windows.Forms.RadioButton radioRandCreaturesUnstable;
        private System.Windows.Forms.RadioButton radioRandCreaturesEnabled;
        private System.Windows.Forms.RadioButton radioRandCreaturesDisabled;
        private System.Windows.Forms.GroupBox groupCreatures;
        private System.Windows.Forms.GroupBox groupExcludeHorses;
        private System.Windows.Forms.RadioButton radioExcludeHorsesYes;
        private System.Windows.Forms.RadioButton radioExcludeHorsesNo;
        private System.Windows.Forms.GroupBox groupUseEssentialCreatures;
        private System.Windows.Forms.RadioButton radioUseEssentialCreaturesYes;
        private System.Windows.Forms.RadioButton radioUseEssentialCreaturesNo;
        private System.Windows.Forms.GroupBox groupLootRandActorInventory;
        private System.Windows.Forms.RadioButton radioRandActorInventoryAggressive;
        private System.Windows.Forms.RadioButton radioRandActorInventoryEnabled;
        private System.Windows.Forms.RadioButton radioRandActorInventoryDisabled;
        private System.Windows.Forms.GroupBox groupLootRandChestInventory;
        private System.Windows.Forms.RadioButton radioRandChestInventoryAggressive;
        private System.Windows.Forms.RadioButton radioRandChestInventoryEnabled;
        private System.Windows.Forms.RadioButton radioRandChestInventoryDisabled;
        private System.Windows.Forms.RadioButton radioSpells2;
        private System.Windows.Forms.GroupBox groupLootWorldItem;
        private System.Windows.Forms.RadioButton radioWorldItemAggressive;
        private System.Windows.Forms.RadioButton radioWorldItemEnabled;
        private System.Windows.Forms.RadioButton radioWorldItemDisabled;
        private System.Windows.Forms.GroupBox groupLootAddItem;
        private System.Windows.Forms.RadioButton radioAddItemAggressive;
        private System.Windows.Forms.RadioButton radioAddItemEnabled;
        private System.Windows.Forms.RadioButton radioAddItemDisabled;
        private System.Windows.Forms.GroupBox groupLootDeathItem;
        private System.Windows.Forms.RadioButton radioDeathItemAggressive;
        private System.Windows.Forms.RadioButton radioDeathItemEnabled;
        private System.Windows.Forms.RadioButton radioDeathItemDisabled;
        private System.Windows.Forms.GroupBox groupLootGold;
        private System.Windows.Forms.RadioButton radioLootRandGoldNo;
        private System.Windows.Forms.RadioButton radioLootRandGoldYes;
        private System.Windows.Forms.GroupBox groupMiscSeed;
        private System.Windows.Forms.Button buttonRandSeed;
        private System.Windows.Forms.TextBox textBoxMiscSeed;
        private System.Windows.Forms.TextBox textBoxHelp;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabPage tabActorSettings;
        private System.Windows.Forms.TabPage tabCreatureSettings;
        private System.Windows.Forms.GroupBox groupLootExcludeUnplayableItems;
        private System.Windows.Forms.RadioButton radioLootExcludeUnplayableYes;
        private System.Windows.Forms.RadioButton radioLootExcludeUnplayableNo;
        private System.Windows.Forms.Label labelTemplates;
        private System.Windows.Forms.ComboBox comboTemplates;
        private System.Windows.Forms.Button buttonSaveTemplate;
        private System.Windows.Forms.Button buttonLoadTemplate;
        private System.Windows.Forms.Button buttonDeleteTemplate;
        private System.Windows.Forms.Label labelLastLoaded;
        private System.Windows.Forms.TabPage tabExcludes;
        private System.Windows.Forms.GroupBox groupCurrentMods;
        private System.Windows.Forms.ListBox listMods;
        private System.Windows.Forms.GroupBox groupDontAddToRandomizerLists;
        private System.Windows.Forms.GroupBox groupDontRandomize;
        private System.Windows.Forms.TextBox textBoxDontRandomize;
        private System.Windows.Forms.Button buttonDontRandomizePaste;
        private System.Windows.Forms.Button buttonDontAddToLists;
        private System.Windows.Forms.TextBox textBoxDontAddToLists;
        private System.Windows.Forms.Button buttonReloadExcludes;
        private System.Windows.Forms.Button buttonSaveExcludes;
        private System.Windows.Forms.CheckBox checkRandomizeStats;
        private System.Windows.Forms.GroupBox groupNPCRandomizeStats;
        private System.Windows.Forms.RadioButton radioStatAll;
        private System.Windows.Forms.RadioButton radioStatNonEssential;
        private System.Windows.Forms.RadioButton radioStatDisabled;
        private System.Windows.Forms.CheckBox checkSaveSeedData;
    }
}

