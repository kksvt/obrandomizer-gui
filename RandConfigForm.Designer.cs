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
            this.components = new System.ComponentModel.Container();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabMiscSettings = new System.Windows.Forms.TabPage();
            this.groupMisc = new System.Windows.Forms.GroupBox();
            this.groupMiscSeed = new System.Windows.Forms.GroupBox();
            this.buttonRandSeed = new System.Windows.Forms.Button();
            this.textBoxMiscSeed = new System.Windows.Forms.TextBox();
            this.groupMiscPatches = new System.Windows.Forms.GroupBox();
            this.checkInvalidCreatureDataPatch = new System.Windows.Forms.CheckBox();
            this.checkInvalidTexturePatch = new System.Windows.Forms.CheckBox();
            this.groupMiscHitEffect = new System.Windows.Forms.GroupBox();
            this.numericHitEffect = new System.Windows.Forms.NumericUpDown();
            this.groupMiscDelayStart = new System.Windows.Forms.GroupBox();
            this.radioDelayStartNo = new System.Windows.Forms.RadioButton();
            this.radioDelayStartYes = new System.Windows.Forms.RadioButton();
            this.groupMiscQuestObjects = new System.Windows.Forms.GroupBox();
            this.radioExcludeQuestYes = new System.Windows.Forms.RadioButton();
            this.radioExcludeQuestNo = new System.Windows.Forms.RadioButton();
            this.groupMiscSpells = new System.Windows.Forms.GroupBox();
            this.radioSpells2 = new System.Windows.Forms.RadioButton();
            this.radioSpellsDisabled = new System.Windows.Forms.RadioButton();
            this.radioSpells1 = new System.Windows.Forms.RadioButton();
            this.tabLootSettings = new System.Windows.Forms.TabPage();
            this.groupLoot = new System.Windows.Forms.GroupBox();
            this.groupLootExcludeUnplayableItems = new System.Windows.Forms.GroupBox();
            this.radioLootExcludeUnplayableYes = new System.Windows.Forms.RadioButton();
            this.radioLootExcludeUnplayableNo = new System.Windows.Forms.RadioButton();
            this.groupLootGold = new System.Windows.Forms.GroupBox();
            this.radioLootRandGoldNo = new System.Windows.Forms.RadioButton();
            this.radioLootRandGoldYes = new System.Windows.Forms.RadioButton();
            this.groupLootDeathItem = new System.Windows.Forms.GroupBox();
            this.radioDeathItemAggressive = new System.Windows.Forms.RadioButton();
            this.radioDeathItemEnabled = new System.Windows.Forms.RadioButton();
            this.radioDeathItemDisabled = new System.Windows.Forms.RadioButton();
            this.groupLootAddItem = new System.Windows.Forms.GroupBox();
            this.radioAddItemAggressive = new System.Windows.Forms.RadioButton();
            this.radioAddItemEnabled = new System.Windows.Forms.RadioButton();
            this.radioAddItemDisabled = new System.Windows.Forms.RadioButton();
            this.groupLootWorldItem = new System.Windows.Forms.GroupBox();
            this.radioWorldItemAggressive = new System.Windows.Forms.RadioButton();
            this.radioWorldItemEnabled = new System.Windows.Forms.RadioButton();
            this.radioWorldItemDisabled = new System.Windows.Forms.RadioButton();
            this.groupLootRandChestInventory = new System.Windows.Forms.GroupBox();
            this.radioRandChestInventoryAggressive = new System.Windows.Forms.RadioButton();
            this.radioRandChestInventoryEnabled = new System.Windows.Forms.RadioButton();
            this.radioRandChestInventoryDisabled = new System.Windows.Forms.RadioButton();
            this.groupLootRandActorInventory = new System.Windows.Forms.GroupBox();
            this.radioRandActorInventoryAggressive = new System.Windows.Forms.RadioButton();
            this.radioRandActorInventoryEnabled = new System.Windows.Forms.RadioButton();
            this.radioRandActorInventoryDisabled = new System.Windows.Forms.RadioButton();
            this.tabActorSettings = new System.Windows.Forms.TabPage();
            this.groupActors = new System.Windows.Forms.GroupBox();
            this.groupNPCActorScaling = new System.Windows.Forms.GroupBox();
            this.checkActorScaling = new System.Windows.Forms.CheckBox();
            this.panelActorScaling = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textActorScalingMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textActorScalingMax = new System.Windows.Forms.TextBox();
            this.groupNPCRestoreAttributes = new System.Windows.Forms.GroupBox();
            this.radioRestoreActorAttribNo = new System.Windows.Forms.RadioButton();
            this.radioRestoreActorAttribYes = new System.Windows.Forms.RadioButton();
            this.groupNPCRandomizeAttributes = new System.Windows.Forms.GroupBox();
            this.radioAttribAll = new System.Windows.Forms.RadioButton();
            this.radioAttribNonEssential = new System.Windows.Forms.RadioButton();
            this.radioAttribDisabled = new System.Windows.Forms.RadioButton();
            this.groupNPCVampire = new System.Windows.Forms.GroupBox();
            this.numericVampire = new System.Windows.Forms.NumericUpDown();
            this.tabCreatureSettings = new System.Windows.Forms.TabPage();
            this.groupCreatures = new System.Windows.Forms.GroupBox();
            this.groupUseEssentialCreatures = new System.Windows.Forms.GroupBox();
            this.radioUseEssentialCreaturesYes = new System.Windows.Forms.RadioButton();
            this.radioUseEssentialCreaturesNo = new System.Windows.Forms.RadioButton();
            this.groupExcludeHorses = new System.Windows.Forms.GroupBox();
            this.radioExcludeHorsesYes = new System.Windows.Forms.RadioButton();
            this.radioExcludeHorsesNo = new System.Windows.Forms.RadioButton();
            this.groupMiscRandCreatures = new System.Windows.Forms.GroupBox();
            this.radioRandCreaturesUnstable = new System.Windows.Forms.RadioButton();
            this.radioRandCreaturesEnabled = new System.Windows.Forms.RadioButton();
            this.radioRandCreaturesDisabled = new System.Windows.Forms.RadioButton();
            this.tabExcludes = new System.Windows.Forms.TabPage();
            this.buttonReloadExcludes = new System.Windows.Forms.Button();
            this.buttonSaveExcludes = new System.Windows.Forms.Button();
            this.groupDontAddToRandomizerLists = new System.Windows.Forms.GroupBox();
            this.buttonDontAddToLists = new System.Windows.Forms.Button();
            this.textBoxDontAddToLists = new System.Windows.Forms.TextBox();
            this.groupDontRandomize = new System.Windows.Forms.GroupBox();
            this.buttonDontRandomizePaste = new System.Windows.Forms.Button();
            this.textBoxDontRandomize = new System.Windows.Forms.TextBox();
            this.groupCurrentMods = new System.Windows.Forms.GroupBox();
            this.listMods = new System.Windows.Forms.ListBox();
            this.textBoxHelp = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboTemplates = new System.Windows.Forms.ComboBox();
            this.labelTemplates = new System.Windows.Forms.Label();
            this.buttonSaveTemplate = new System.Windows.Forms.Button();
            this.buttonLoadTemplate = new System.Windows.Forms.Button();
            this.buttonDeleteTemplate = new System.Windows.Forms.Button();
            this.labelLastLoaded = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.tabMiscSettings.SuspendLayout();
            this.groupMisc.SuspendLayout();
            this.groupMiscSeed.SuspendLayout();
            this.groupMiscPatches.SuspendLayout();
            this.groupMiscHitEffect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHitEffect)).BeginInit();
            this.groupMiscDelayStart.SuspendLayout();
            this.groupMiscQuestObjects.SuspendLayout();
            this.groupMiscSpells.SuspendLayout();
            this.tabLootSettings.SuspendLayout();
            this.groupLoot.SuspendLayout();
            this.groupLootExcludeUnplayableItems.SuspendLayout();
            this.groupLootGold.SuspendLayout();
            this.groupLootDeathItem.SuspendLayout();
            this.groupLootAddItem.SuspendLayout();
            this.groupLootWorldItem.SuspendLayout();
            this.groupLootRandChestInventory.SuspendLayout();
            this.groupLootRandActorInventory.SuspendLayout();
            this.tabActorSettings.SuspendLayout();
            this.groupActors.SuspendLayout();
            this.groupNPCActorScaling.SuspendLayout();
            this.panelActorScaling.SuspendLayout();
            this.groupNPCRestoreAttributes.SuspendLayout();
            this.groupNPCRandomizeAttributes.SuspendLayout();
            this.groupNPCVampire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVampire)).BeginInit();
            this.tabCreatureSettings.SuspendLayout();
            this.groupCreatures.SuspendLayout();
            this.groupUseEssentialCreatures.SuspendLayout();
            this.groupExcludeHorses.SuspendLayout();
            this.groupMiscRandCreatures.SuspendLayout();
            this.tabExcludes.SuspendLayout();
            this.groupDontAddToRandomizerLists.SuspendLayout();
            this.groupDontRandomize.SuspendLayout();
            this.groupCurrentMods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabMiscSettings);
            this.tabs.Controls.Add(this.tabLootSettings);
            this.tabs.Controls.Add(this.tabActorSettings);
            this.tabs.Controls.Add(this.tabCreatureSettings);
            this.tabs.Controls.Add(this.tabExcludes);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(676, 362);
            this.tabs.TabIndex = 0;
            // 
            // tabMiscSettings
            // 
            this.tabMiscSettings.Controls.Add(this.groupMisc);
            this.tabMiscSettings.Location = new System.Drawing.Point(4, 22);
            this.tabMiscSettings.Name = "tabMiscSettings";
            this.tabMiscSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabMiscSettings.Size = new System.Drawing.Size(668, 336);
            this.tabMiscSettings.TabIndex = 0;
            this.tabMiscSettings.Text = "Misc settings";
            this.tabMiscSettings.UseVisualStyleBackColor = true;
            // 
            // groupMisc
            // 
            this.groupMisc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupMisc.Controls.Add(this.groupMiscSeed);
            this.groupMisc.Controls.Add(this.groupMiscPatches);
            this.groupMisc.Controls.Add(this.groupMiscHitEffect);
            this.groupMisc.Controls.Add(this.groupMiscDelayStart);
            this.groupMisc.Controls.Add(this.groupMiscQuestObjects);
            this.groupMisc.Controls.Add(this.groupMiscSpells);
            this.groupMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupMisc.Location = new System.Drawing.Point(6, 6);
            this.groupMisc.Name = "groupMisc";
            this.groupMisc.Size = new System.Drawing.Size(656, 186);
            this.groupMisc.TabIndex = 0;
            this.groupMisc.TabStop = false;
            this.groupMisc.Text = "Misc";
            // 
            // groupMiscSeed
            // 
            this.groupMiscSeed.Controls.Add(this.buttonRandSeed);
            this.groupMiscSeed.Controls.Add(this.textBoxMiscSeed);
            this.groupMiscSeed.Location = new System.Drawing.Point(6, 20);
            this.groupMiscSeed.Name = "groupMiscSeed";
            this.groupMiscSeed.Size = new System.Drawing.Size(188, 62);
            this.groupMiscSeed.TabIndex = 7;
            this.groupMiscSeed.TabStop = false;
            this.groupMiscSeed.Tag = "";
            this.groupMiscSeed.Text = "Seed";
            this.groupMiscSeed.MouseHover += new System.EventHandler(this.groupMiscSeed_MouseHover);
            // 
            // buttonRandSeed
            // 
            this.buttonRandSeed.Location = new System.Drawing.Point(6, 19);
            this.buttonRandSeed.Name = "buttonRandSeed";
            this.buttonRandSeed.Size = new System.Drawing.Size(52, 23);
            this.buttonRandSeed.TabIndex = 1;
            this.buttonRandSeed.Text = "New";
            this.buttonRandSeed.UseVisualStyleBackColor = true;
            this.buttonRandSeed.Click += new System.EventHandler(this.buttonRandSeed_Click);
            // 
            // textBoxMiscSeed
            // 
            this.textBoxMiscSeed.Location = new System.Drawing.Point(69, 21);
            this.textBoxMiscSeed.Name = "textBoxMiscSeed";
            this.textBoxMiscSeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiscSeed.TabIndex = 0;
            // 
            // groupMiscPatches
            // 
            this.groupMiscPatches.Controls.Add(this.checkInvalidCreatureDataPatch);
            this.groupMiscPatches.Controls.Add(this.checkInvalidTexturePatch);
            this.groupMiscPatches.Location = new System.Drawing.Point(235, 88);
            this.groupMiscPatches.Name = "groupMiscPatches";
            this.groupMiscPatches.Size = new System.Drawing.Size(187, 69);
            this.groupMiscPatches.TabIndex = 6;
            this.groupMiscPatches.TabStop = false;
            this.groupMiscPatches.Text = "Enable anti-crash patches";
            this.groupMiscPatches.MouseHover += new System.EventHandler(this.groupMiscPatches_MouseHover);
            // 
            // checkInvalidCreatureDataPatch
            // 
            this.checkInvalidCreatureDataPatch.AutoSize = true;
            this.checkInvalidCreatureDataPatch.Location = new System.Drawing.Point(7, 40);
            this.checkInvalidCreatureDataPatch.Margin = new System.Windows.Forms.Padding(1, 3, 3, 1);
            this.checkInvalidCreatureDataPatch.Name = "checkInvalidCreatureDataPatch";
            this.checkInvalidCreatureDataPatch.Size = new System.Drawing.Size(120, 17);
            this.checkInvalidCreatureDataPatch.TabIndex = 1;
            this.checkInvalidCreatureDataPatch.Text = "Creature data patch";
            this.checkInvalidCreatureDataPatch.UseVisualStyleBackColor = true;
            // 
            // checkInvalidTexturePatch
            // 
            this.checkInvalidTexturePatch.AutoSize = true;
            this.checkInvalidTexturePatch.Location = new System.Drawing.Point(7, 19);
            this.checkInvalidTexturePatch.Margin = new System.Windows.Forms.Padding(1, 3, 3, 1);
            this.checkInvalidTexturePatch.Name = "checkInvalidTexturePatch";
            this.checkInvalidTexturePatch.Size = new System.Drawing.Size(122, 17);
            this.checkInvalidTexturePatch.TabIndex = 0;
            this.checkInvalidTexturePatch.Text = "Invalid texture patch";
            this.checkInvalidTexturePatch.UseVisualStyleBackColor = true;
            // 
            // groupMiscHitEffect
            // 
            this.groupMiscHitEffect.Controls.Add(this.numericHitEffect);
            this.groupMiscHitEffect.Location = new System.Drawing.Point(461, 19);
            this.groupMiscHitEffect.Name = "groupMiscHitEffect";
            this.groupMiscHitEffect.Size = new System.Drawing.Size(187, 53);
            this.groupMiscHitEffect.TabIndex = 5;
            this.groupMiscHitEffect.TabStop = false;
            this.groupMiscHitEffect.Text = "Hit effect chance (%)";
            this.groupMiscHitEffect.MouseHover += new System.EventHandler(this.groupMiscHitEffect_MouseHover);
            // 
            // numericHitEffect
            // 
            this.numericHitEffect.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericHitEffect.Location = new System.Drawing.Point(7, 19);
            this.numericHitEffect.Name = "numericHitEffect";
            this.numericHitEffect.Size = new System.Drawing.Size(120, 20);
            this.numericHitEffect.TabIndex = 0;
            this.numericHitEffect.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // groupMiscDelayStart
            // 
            this.groupMiscDelayStart.Controls.Add(this.radioDelayStartNo);
            this.groupMiscDelayStart.Controls.Add(this.radioDelayStartYes);
            this.groupMiscDelayStart.Location = new System.Drawing.Point(235, 19);
            this.groupMiscDelayStart.Name = "groupMiscDelayStart";
            this.groupMiscDelayStart.Size = new System.Drawing.Size(187, 63);
            this.groupMiscDelayStart.TabIndex = 4;
            this.groupMiscDelayStart.TabStop = false;
            this.groupMiscDelayStart.Text = "Delay start";
            this.groupMiscDelayStart.MouseHover += new System.EventHandler(this.groupMiscDelayStart_MouseHover);
            // 
            // radioDelayStartNo
            // 
            this.radioDelayStartNo.AutoSize = true;
            this.radioDelayStartNo.Checked = true;
            this.radioDelayStartNo.Location = new System.Drawing.Point(7, 39);
            this.radioDelayStartNo.Name = "radioDelayStartNo";
            this.radioDelayStartNo.Size = new System.Drawing.Size(39, 17);
            this.radioDelayStartNo.TabIndex = 1;
            this.radioDelayStartNo.TabStop = true;
            this.radioDelayStartNo.Text = "No";
            this.radioDelayStartNo.UseVisualStyleBackColor = true;
            // 
            // radioDelayStartYes
            // 
            this.radioDelayStartYes.AutoSize = true;
            this.radioDelayStartYes.Location = new System.Drawing.Point(7, 20);
            this.radioDelayStartYes.Name = "radioDelayStartYes";
            this.radioDelayStartYes.Size = new System.Drawing.Size(43, 17);
            this.radioDelayStartYes.TabIndex = 0;
            this.radioDelayStartYes.Text = "Yes";
            this.radioDelayStartYes.UseVisualStyleBackColor = true;
            // 
            // groupMiscQuestObjects
            // 
            this.groupMiscQuestObjects.Controls.Add(this.radioExcludeQuestYes);
            this.groupMiscQuestObjects.Controls.Add(this.radioExcludeQuestNo);
            this.groupMiscQuestObjects.Location = new System.Drawing.Point(6, 88);
            this.groupMiscQuestObjects.Name = "groupMiscQuestObjects";
            this.groupMiscQuestObjects.Size = new System.Drawing.Size(188, 69);
            this.groupMiscQuestObjects.TabIndex = 3;
            this.groupMiscQuestObjects.TabStop = false;
            this.groupMiscQuestObjects.Text = "Exclude quest objects";
            this.groupMiscQuestObjects.MouseHover += new System.EventHandler(this.groupMiscQuestObjects_MouseHover);
            // 
            // radioExcludeQuestYes
            // 
            this.radioExcludeQuestYes.AutoSize = true;
            this.radioExcludeQuestYes.Checked = true;
            this.radioExcludeQuestYes.Location = new System.Drawing.Point(6, 19);
            this.radioExcludeQuestYes.Name = "radioExcludeQuestYes";
            this.radioExcludeQuestYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioExcludeQuestYes.Size = new System.Drawing.Size(43, 17);
            this.radioExcludeQuestYes.TabIndex = 0;
            this.radioExcludeQuestYes.TabStop = true;
            this.radioExcludeQuestYes.Text = "Yes";
            this.radioExcludeQuestYes.UseVisualStyleBackColor = true;
            // 
            // radioExcludeQuestNo
            // 
            this.radioExcludeQuestNo.AutoSize = true;
            this.radioExcludeQuestNo.Location = new System.Drawing.Point(6, 38);
            this.radioExcludeQuestNo.Name = "radioExcludeQuestNo";
            this.radioExcludeQuestNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioExcludeQuestNo.Size = new System.Drawing.Size(39, 17);
            this.radioExcludeQuestNo.TabIndex = 1;
            this.radioExcludeQuestNo.Text = "No";
            this.radioExcludeQuestNo.UseVisualStyleBackColor = true;
            // 
            // groupMiscSpells
            // 
            this.groupMiscSpells.Controls.Add(this.radioSpells2);
            this.groupMiscSpells.Controls.Add(this.radioSpellsDisabled);
            this.groupMiscSpells.Controls.Add(this.radioSpells1);
            this.groupMiscSpells.Location = new System.Drawing.Point(461, 88);
            this.groupMiscSpells.Name = "groupMiscSpells";
            this.groupMiscSpells.Size = new System.Drawing.Size(187, 83);
            this.groupMiscSpells.TabIndex = 0;
            this.groupMiscSpells.TabStop = false;
            this.groupMiscSpells.Text = "Spell randomization";
            this.groupMiscSpells.MouseHover += new System.EventHandler(this.groupMiscSpells_MouseHover);
            // 
            // radioSpells2
            // 
            this.radioSpells2.AutoSize = true;
            this.radioSpells2.Location = new System.Drawing.Point(6, 57);
            this.radioSpells2.Name = "radioSpells2";
            this.radioSpells2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioSpells2.Size = new System.Drawing.Size(117, 17);
            this.radioSpells2.TabIndex = 4;
            this.radioSpells2.Text = "Total randomization";
            this.radioSpells2.UseVisualStyleBackColor = true;
            // 
            // radioSpellsDisabled
            // 
            this.radioSpellsDisabled.AutoSize = true;
            this.radioSpellsDisabled.Location = new System.Drawing.Point(6, 18);
            this.radioSpellsDisabled.Name = "radioSpellsDisabled";
            this.radioSpellsDisabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioSpellsDisabled.Size = new System.Drawing.Size(66, 17);
            this.radioSpellsDisabled.TabIndex = 2;
            this.radioSpellsDisabled.Text = "Disabled";
            this.radioSpellsDisabled.UseVisualStyleBackColor = true;
            // 
            // radioSpells1
            // 
            this.radioSpells1.AutoSize = true;
            this.radioSpells1.Checked = true;
            this.radioSpells1.Location = new System.Drawing.Point(6, 37);
            this.radioSpells1.Name = "radioSpells1";
            this.radioSpells1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioSpells1.Size = new System.Drawing.Size(175, 17);
            this.radioSpells1.TabIndex = 3;
            this.radioSpells1.TabStop = true;
            this.radioSpells1.Text = "Randomize spell, but not school";
            this.radioSpells1.UseVisualStyleBackColor = true;
            // 
            // tabLootSettings
            // 
            this.tabLootSettings.Controls.Add(this.groupLoot);
            this.tabLootSettings.Location = new System.Drawing.Point(4, 22);
            this.tabLootSettings.Name = "tabLootSettings";
            this.tabLootSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabLootSettings.Size = new System.Drawing.Size(668, 336);
            this.tabLootSettings.TabIndex = 1;
            this.tabLootSettings.Text = "Loot settings";
            this.tabLootSettings.UseVisualStyleBackColor = true;
            // 
            // groupLoot
            // 
            this.groupLoot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupLoot.Controls.Add(this.groupLootExcludeUnplayableItems);
            this.groupLoot.Controls.Add(this.groupLootGold);
            this.groupLoot.Controls.Add(this.groupLootDeathItem);
            this.groupLoot.Controls.Add(this.groupLootAddItem);
            this.groupLoot.Controls.Add(this.groupLootWorldItem);
            this.groupLoot.Controls.Add(this.groupLootRandChestInventory);
            this.groupLoot.Controls.Add(this.groupLootRandActorInventory);
            this.groupLoot.Location = new System.Drawing.Point(6, 6);
            this.groupLoot.Name = "groupLoot";
            this.groupLoot.Size = new System.Drawing.Size(656, 324);
            this.groupLoot.TabIndex = 2;
            this.groupLoot.TabStop = false;
            this.groupLoot.Text = "Loot";
            // 
            // groupLootExcludeUnplayableItems
            // 
            this.groupLootExcludeUnplayableItems.Controls.Add(this.radioLootExcludeUnplayableYes);
            this.groupLootExcludeUnplayableItems.Controls.Add(this.radioLootExcludeUnplayableNo);
            this.groupLootExcludeUnplayableItems.Location = new System.Drawing.Point(6, 211);
            this.groupLootExcludeUnplayableItems.Name = "groupLootExcludeUnplayableItems";
            this.groupLootExcludeUnplayableItems.Size = new System.Drawing.Size(188, 69);
            this.groupLootExcludeUnplayableItems.TabIndex = 17;
            this.groupLootExcludeUnplayableItems.TabStop = false;
            this.groupLootExcludeUnplayableItems.Text = "Exclude unplayable items";
            this.groupLootExcludeUnplayableItems.MouseHover += new System.EventHandler(this.groupLootExcludeUnplayableItems_MouseHover);
            // 
            // radioLootExcludeUnplayableYes
            // 
            this.radioLootExcludeUnplayableYes.AutoSize = true;
            this.radioLootExcludeUnplayableYes.Checked = true;
            this.radioLootExcludeUnplayableYes.Location = new System.Drawing.Point(6, 19);
            this.radioLootExcludeUnplayableYes.Name = "radioLootExcludeUnplayableYes";
            this.radioLootExcludeUnplayableYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioLootExcludeUnplayableYes.Size = new System.Drawing.Size(43, 17);
            this.radioLootExcludeUnplayableYes.TabIndex = 0;
            this.radioLootExcludeUnplayableYes.TabStop = true;
            this.radioLootExcludeUnplayableYes.Text = "Yes";
            this.radioLootExcludeUnplayableYes.UseVisualStyleBackColor = true;
            // 
            // radioLootExcludeUnplayableNo
            // 
            this.radioLootExcludeUnplayableNo.AutoSize = true;
            this.radioLootExcludeUnplayableNo.Location = new System.Drawing.Point(6, 38);
            this.radioLootExcludeUnplayableNo.Name = "radioLootExcludeUnplayableNo";
            this.radioLootExcludeUnplayableNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioLootExcludeUnplayableNo.Size = new System.Drawing.Size(39, 17);
            this.radioLootExcludeUnplayableNo.TabIndex = 1;
            this.radioLootExcludeUnplayableNo.Text = "No";
            this.radioLootExcludeUnplayableNo.UseVisualStyleBackColor = true;
            // 
            // groupLootGold
            // 
            this.groupLootGold.Controls.Add(this.radioLootRandGoldNo);
            this.groupLootGold.Controls.Add(this.radioLootRandGoldYes);
            this.groupLootGold.Location = new System.Drawing.Point(462, 115);
            this.groupLootGold.Name = "groupLootGold";
            this.groupLootGold.Size = new System.Drawing.Size(187, 90);
            this.groupLootGold.TabIndex = 16;
            this.groupLootGold.TabStop = false;
            this.groupLootGold.Text = "Gold";
            this.groupLootGold.MouseHover += new System.EventHandler(this.groupLootGold_MouseHover);
            // 
            // radioLootRandGoldNo
            // 
            this.radioLootRandGoldNo.AutoSize = true;
            this.radioLootRandGoldNo.Checked = true;
            this.radioLootRandGoldNo.Location = new System.Drawing.Point(6, 19);
            this.radioLootRandGoldNo.Name = "radioLootRandGoldNo";
            this.radioLootRandGoldNo.Size = new System.Drawing.Size(137, 17);
            this.radioLootRandGoldNo.TabIndex = 1;
            this.radioLootRandGoldNo.TabStop = true;
            this.radioLootRandGoldNo.Text = "Only randomize quantity";
            this.radioLootRandGoldNo.UseVisualStyleBackColor = true;
            // 
            // radioLootRandGoldYes
            // 
            this.radioLootRandGoldYes.AutoSize = true;
            this.radioLootRandGoldYes.Location = new System.Drawing.Point(6, 39);
            this.radioLootRandGoldYes.Name = "radioLootRandGoldYes";
            this.radioLootRandGoldYes.Size = new System.Drawing.Size(159, 17);
            this.radioLootRandGoldYes.TabIndex = 0;
            this.radioLootRandGoldYes.Text = "Randomize into another item";
            this.radioLootRandGoldYes.UseVisualStyleBackColor = true;
            // 
            // groupLootDeathItem
            // 
            this.groupLootDeathItem.Controls.Add(this.radioDeathItemAggressive);
            this.groupLootDeathItem.Controls.Add(this.radioDeathItemEnabled);
            this.groupLootDeathItem.Controls.Add(this.radioDeathItemDisabled);
            this.groupLootDeathItem.Location = new System.Drawing.Point(235, 115);
            this.groupLootDeathItem.Name = "groupLootDeathItem";
            this.groupLootDeathItem.Size = new System.Drawing.Size(187, 90);
            this.groupLootDeathItem.TabIndex = 15;
            this.groupLootDeathItem.TabStop = false;
            this.groupLootDeathItem.Text = "Death item randomization";
            this.groupLootDeathItem.MouseHover += new System.EventHandler(this.groupLootDeathItem_MouseHover);
            // 
            // radioDeathItemAggressive
            // 
            this.radioDeathItemAggressive.AutoSize = true;
            this.radioDeathItemAggressive.Location = new System.Drawing.Point(7, 59);
            this.radioDeathItemAggressive.Name = "radioDeathItemAggressive";
            this.radioDeathItemAggressive.Size = new System.Drawing.Size(121, 17);
            this.radioDeathItemAggressive.TabIndex = 2;
            this.radioDeathItemAggressive.Text = "Enabled, aggressive";
            this.radioDeathItemAggressive.UseVisualStyleBackColor = true;
            // 
            // radioDeathItemEnabled
            // 
            this.radioDeathItemEnabled.AutoSize = true;
            this.radioDeathItemEnabled.Checked = true;
            this.radioDeathItemEnabled.Location = new System.Drawing.Point(7, 39);
            this.radioDeathItemEnabled.Name = "radioDeathItemEnabled";
            this.radioDeathItemEnabled.Size = new System.Drawing.Size(101, 17);
            this.radioDeathItemEnabled.TabIndex = 1;
            this.radioDeathItemEnabled.TabStop = true;
            this.radioDeathItemEnabled.Text = "Enabled, normal";
            this.radioDeathItemEnabled.UseVisualStyleBackColor = true;
            // 
            // radioDeathItemDisabled
            // 
            this.radioDeathItemDisabled.AutoSize = true;
            this.radioDeathItemDisabled.Location = new System.Drawing.Point(7, 20);
            this.radioDeathItemDisabled.Name = "radioDeathItemDisabled";
            this.radioDeathItemDisabled.Size = new System.Drawing.Size(66, 17);
            this.radioDeathItemDisabled.TabIndex = 0;
            this.radioDeathItemDisabled.Text = "Disabled";
            this.radioDeathItemDisabled.UseVisualStyleBackColor = true;
            // 
            // groupLootAddItem
            // 
            this.groupLootAddItem.Controls.Add(this.radioAddItemAggressive);
            this.groupLootAddItem.Controls.Add(this.radioAddItemEnabled);
            this.groupLootAddItem.Controls.Add(this.radioAddItemDisabled);
            this.groupLootAddItem.Location = new System.Drawing.Point(6, 115);
            this.groupLootAddItem.Name = "groupLootAddItem";
            this.groupLootAddItem.Size = new System.Drawing.Size(186, 90);
            this.groupLootAddItem.TabIndex = 14;
            this.groupLootAddItem.TabStop = false;
            this.groupLootAddItem.Text = "AddItem randomization";
            this.groupLootAddItem.MouseHover += new System.EventHandler(this.groupLootAddItem_MouseHover);
            // 
            // radioAddItemAggressive
            // 
            this.radioAddItemAggressive.AutoSize = true;
            this.radioAddItemAggressive.Location = new System.Drawing.Point(7, 59);
            this.radioAddItemAggressive.Name = "radioAddItemAggressive";
            this.radioAddItemAggressive.Size = new System.Drawing.Size(121, 17);
            this.radioAddItemAggressive.TabIndex = 2;
            this.radioAddItemAggressive.Text = "Enabled, aggressive";
            this.radioAddItemAggressive.UseVisualStyleBackColor = true;
            // 
            // radioAddItemEnabled
            // 
            this.radioAddItemEnabled.AutoSize = true;
            this.radioAddItemEnabled.Checked = true;
            this.radioAddItemEnabled.Location = new System.Drawing.Point(7, 39);
            this.radioAddItemEnabled.Name = "radioAddItemEnabled";
            this.radioAddItemEnabled.Size = new System.Drawing.Size(101, 17);
            this.radioAddItemEnabled.TabIndex = 1;
            this.radioAddItemEnabled.TabStop = true;
            this.radioAddItemEnabled.Text = "Enabled, normal";
            this.radioAddItemEnabled.UseVisualStyleBackColor = true;
            // 
            // radioAddItemDisabled
            // 
            this.radioAddItemDisabled.AutoSize = true;
            this.radioAddItemDisabled.Location = new System.Drawing.Point(7, 20);
            this.radioAddItemDisabled.Name = "radioAddItemDisabled";
            this.radioAddItemDisabled.Size = new System.Drawing.Size(66, 17);
            this.radioAddItemDisabled.TabIndex = 0;
            this.radioAddItemDisabled.Text = "Disabled";
            this.radioAddItemDisabled.UseVisualStyleBackColor = true;
            // 
            // groupLootWorldItem
            // 
            this.groupLootWorldItem.Controls.Add(this.radioWorldItemAggressive);
            this.groupLootWorldItem.Controls.Add(this.radioWorldItemEnabled);
            this.groupLootWorldItem.Controls.Add(this.radioWorldItemDisabled);
            this.groupLootWorldItem.Location = new System.Drawing.Point(461, 19);
            this.groupLootWorldItem.Name = "groupLootWorldItem";
            this.groupLootWorldItem.Size = new System.Drawing.Size(188, 90);
            this.groupLootWorldItem.TabIndex = 13;
            this.groupLootWorldItem.TabStop = false;
            this.groupLootWorldItem.Text = "World item randomization";
            this.groupLootWorldItem.MouseHover += new System.EventHandler(this.groupLootWorldItem_MouseHover);
            // 
            // radioWorldItemAggressive
            // 
            this.radioWorldItemAggressive.AutoSize = true;
            this.radioWorldItemAggressive.Location = new System.Drawing.Point(7, 59);
            this.radioWorldItemAggressive.Name = "radioWorldItemAggressive";
            this.radioWorldItemAggressive.Size = new System.Drawing.Size(121, 17);
            this.radioWorldItemAggressive.TabIndex = 2;
            this.radioWorldItemAggressive.Text = "Enabled, aggressive";
            this.radioWorldItemAggressive.UseVisualStyleBackColor = true;
            // 
            // radioWorldItemEnabled
            // 
            this.radioWorldItemEnabled.AutoSize = true;
            this.radioWorldItemEnabled.Checked = true;
            this.radioWorldItemEnabled.Location = new System.Drawing.Point(7, 39);
            this.radioWorldItemEnabled.Name = "radioWorldItemEnabled";
            this.radioWorldItemEnabled.Size = new System.Drawing.Size(101, 17);
            this.radioWorldItemEnabled.TabIndex = 1;
            this.radioWorldItemEnabled.TabStop = true;
            this.radioWorldItemEnabled.Text = "Enabled, normal";
            this.radioWorldItemEnabled.UseVisualStyleBackColor = true;
            // 
            // radioWorldItemDisabled
            // 
            this.radioWorldItemDisabled.AutoSize = true;
            this.radioWorldItemDisabled.Location = new System.Drawing.Point(7, 20);
            this.radioWorldItemDisabled.Name = "radioWorldItemDisabled";
            this.radioWorldItemDisabled.Size = new System.Drawing.Size(66, 17);
            this.radioWorldItemDisabled.TabIndex = 0;
            this.radioWorldItemDisabled.Text = "Disabled";
            this.radioWorldItemDisabled.UseVisualStyleBackColor = true;
            // 
            // groupLootRandChestInventory
            // 
            this.groupLootRandChestInventory.Controls.Add(this.radioRandChestInventoryAggressive);
            this.groupLootRandChestInventory.Controls.Add(this.radioRandChestInventoryEnabled);
            this.groupLootRandChestInventory.Controls.Add(this.radioRandChestInventoryDisabled);
            this.groupLootRandChestInventory.Location = new System.Drawing.Point(235, 19);
            this.groupLootRandChestInventory.Name = "groupLootRandChestInventory";
            this.groupLootRandChestInventory.Size = new System.Drawing.Size(187, 90);
            this.groupLootRandChestInventory.TabIndex = 12;
            this.groupLootRandChestInventory.TabStop = false;
            this.groupLootRandChestInventory.Text = "Container inventory randomization";
            this.groupLootRandChestInventory.MouseHover += new System.EventHandler(this.groupLootRandChestInventory_MouseHover);
            // 
            // radioRandChestInventoryAggressive
            // 
            this.radioRandChestInventoryAggressive.AutoSize = true;
            this.radioRandChestInventoryAggressive.Location = new System.Drawing.Point(7, 59);
            this.radioRandChestInventoryAggressive.Name = "radioRandChestInventoryAggressive";
            this.radioRandChestInventoryAggressive.Size = new System.Drawing.Size(121, 17);
            this.radioRandChestInventoryAggressive.TabIndex = 2;
            this.radioRandChestInventoryAggressive.Text = "Enabled, aggressive";
            this.radioRandChestInventoryAggressive.UseVisualStyleBackColor = true;
            // 
            // radioRandChestInventoryEnabled
            // 
            this.radioRandChestInventoryEnabled.AutoSize = true;
            this.radioRandChestInventoryEnabled.Checked = true;
            this.radioRandChestInventoryEnabled.Location = new System.Drawing.Point(7, 39);
            this.radioRandChestInventoryEnabled.Name = "radioRandChestInventoryEnabled";
            this.radioRandChestInventoryEnabled.Size = new System.Drawing.Size(101, 17);
            this.radioRandChestInventoryEnabled.TabIndex = 1;
            this.radioRandChestInventoryEnabled.TabStop = true;
            this.radioRandChestInventoryEnabled.Text = "Enabled, normal";
            this.radioRandChestInventoryEnabled.UseVisualStyleBackColor = true;
            // 
            // radioRandChestInventoryDisabled
            // 
            this.radioRandChestInventoryDisabled.AutoSize = true;
            this.radioRandChestInventoryDisabled.Location = new System.Drawing.Point(7, 20);
            this.radioRandChestInventoryDisabled.Name = "radioRandChestInventoryDisabled";
            this.radioRandChestInventoryDisabled.Size = new System.Drawing.Size(66, 17);
            this.radioRandChestInventoryDisabled.TabIndex = 0;
            this.radioRandChestInventoryDisabled.Text = "Disabled";
            this.radioRandChestInventoryDisabled.UseVisualStyleBackColor = true;
            // 
            // groupLootRandActorInventory
            // 
            this.groupLootRandActorInventory.Controls.Add(this.radioRandActorInventoryAggressive);
            this.groupLootRandActorInventory.Controls.Add(this.radioRandActorInventoryEnabled);
            this.groupLootRandActorInventory.Controls.Add(this.radioRandActorInventoryDisabled);
            this.groupLootRandActorInventory.Location = new System.Drawing.Point(6, 19);
            this.groupLootRandActorInventory.Name = "groupLootRandActorInventory";
            this.groupLootRandActorInventory.Size = new System.Drawing.Size(186, 90);
            this.groupLootRandActorInventory.TabIndex = 11;
            this.groupLootRandActorInventory.TabStop = false;
            this.groupLootRandActorInventory.Text = "Actor inventory randomization";
            this.groupLootRandActorInventory.MouseHover += new System.EventHandler(this.groupLootRandActorInventory_MouseHover);
            // 
            // radioRandActorInventoryAggressive
            // 
            this.radioRandActorInventoryAggressive.AutoSize = true;
            this.radioRandActorInventoryAggressive.Location = new System.Drawing.Point(7, 59);
            this.radioRandActorInventoryAggressive.Name = "radioRandActorInventoryAggressive";
            this.radioRandActorInventoryAggressive.Size = new System.Drawing.Size(121, 17);
            this.radioRandActorInventoryAggressive.TabIndex = 2;
            this.radioRandActorInventoryAggressive.Text = "Enabled, aggressive";
            this.radioRandActorInventoryAggressive.UseVisualStyleBackColor = true;
            // 
            // radioRandActorInventoryEnabled
            // 
            this.radioRandActorInventoryEnabled.AutoSize = true;
            this.radioRandActorInventoryEnabled.Checked = true;
            this.radioRandActorInventoryEnabled.Location = new System.Drawing.Point(7, 39);
            this.radioRandActorInventoryEnabled.Name = "radioRandActorInventoryEnabled";
            this.radioRandActorInventoryEnabled.Size = new System.Drawing.Size(101, 17);
            this.radioRandActorInventoryEnabled.TabIndex = 1;
            this.radioRandActorInventoryEnabled.TabStop = true;
            this.radioRandActorInventoryEnabled.Text = "Enabled, normal";
            this.radioRandActorInventoryEnabled.UseVisualStyleBackColor = true;
            // 
            // radioRandActorInventoryDisabled
            // 
            this.radioRandActorInventoryDisabled.AutoSize = true;
            this.radioRandActorInventoryDisabled.Location = new System.Drawing.Point(7, 20);
            this.radioRandActorInventoryDisabled.Name = "radioRandActorInventoryDisabled";
            this.radioRandActorInventoryDisabled.Size = new System.Drawing.Size(66, 17);
            this.radioRandActorInventoryDisabled.TabIndex = 0;
            this.radioRandActorInventoryDisabled.Text = "Disabled";
            this.radioRandActorInventoryDisabled.UseVisualStyleBackColor = true;
            // 
            // tabActorSettings
            // 
            this.tabActorSettings.Controls.Add(this.groupActors);
            this.tabActorSettings.Location = new System.Drawing.Point(4, 22);
            this.tabActorSettings.Name = "tabActorSettings";
            this.tabActorSettings.Size = new System.Drawing.Size(668, 336);
            this.tabActorSettings.TabIndex = 2;
            this.tabActorSettings.Text = "Actor settings";
            this.tabActorSettings.UseVisualStyleBackColor = true;
            // 
            // groupActors
            // 
            this.groupActors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupActors.Controls.Add(this.groupNPCActorScaling);
            this.groupActors.Controls.Add(this.groupNPCRestoreAttributes);
            this.groupActors.Controls.Add(this.groupNPCRandomizeAttributes);
            this.groupActors.Controls.Add(this.groupNPCVampire);
            this.groupActors.Location = new System.Drawing.Point(6, 6);
            this.groupActors.Name = "groupActors";
            this.groupActors.Size = new System.Drawing.Size(656, 163);
            this.groupActors.TabIndex = 1;
            this.groupActors.TabStop = false;
            this.groupActors.Text = "Actor parameters";
            // 
            // groupNPCActorScaling
            // 
            this.groupNPCActorScaling.Controls.Add(this.checkActorScaling);
            this.groupNPCActorScaling.Controls.Add(this.panelActorScaling);
            this.groupNPCActorScaling.Location = new System.Drawing.Point(461, 19);
            this.groupNPCActorScaling.Name = "groupNPCActorScaling";
            this.groupNPCActorScaling.Size = new System.Drawing.Size(187, 114);
            this.groupNPCActorScaling.TabIndex = 9;
            this.groupNPCActorScaling.TabStop = false;
            this.groupNPCActorScaling.Text = "Actor size scaling";
            this.groupNPCActorScaling.MouseHover += new System.EventHandler(this.groupNPCActorScaling_MouseHover);
            // 
            // checkActorScaling
            // 
            this.checkActorScaling.AutoSize = true;
            this.checkActorScaling.Location = new System.Drawing.Point(7, 20);
            this.checkActorScaling.Name = "checkActorScaling";
            this.checkActorScaling.Size = new System.Drawing.Size(65, 17);
            this.checkActorScaling.TabIndex = 4;
            this.checkActorScaling.Text = "Enabled";
            this.checkActorScaling.UseVisualStyleBackColor = true;
            this.checkActorScaling.CheckedChanged += new System.EventHandler(this.checkActorScaling_CheckedChanged);
            // 
            // panelActorScaling
            // 
            this.panelActorScaling.Controls.Add(this.label2);
            this.panelActorScaling.Controls.Add(this.textActorScalingMin);
            this.panelActorScaling.Controls.Add(this.label1);
            this.panelActorScaling.Controls.Add(this.textActorScalingMax);
            this.panelActorScaling.Enabled = false;
            this.panelActorScaling.Location = new System.Drawing.Point(6, 42);
            this.panelActorScaling.Name = "panelActorScaling";
            this.panelActorScaling.Size = new System.Drawing.Size(160, 63);
            this.panelActorScaling.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Max";
            // 
            // textActorScalingMin
            // 
            this.textActorScalingMin.Location = new System.Drawing.Point(34, 8);
            this.textActorScalingMin.Name = "textActorScalingMin";
            this.textActorScalingMin.Size = new System.Drawing.Size(100, 20);
            this.textActorScalingMin.TabIndex = 3;
            this.textActorScalingMin.Validating += new System.ComponentModel.CancelEventHandler(this.textActorScalingMin_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Min";
            // 
            // textActorScalingMax
            // 
            this.textActorScalingMax.Location = new System.Drawing.Point(34, 31);
            this.textActorScalingMax.Name = "textActorScalingMax";
            this.textActorScalingMax.Size = new System.Drawing.Size(100, 20);
            this.textActorScalingMax.TabIndex = 4;
            this.textActorScalingMax.Validating += new System.ComponentModel.CancelEventHandler(this.textActorScalingMax_Validating);
            // 
            // groupNPCRestoreAttributes
            // 
            this.groupNPCRestoreAttributes.Controls.Add(this.radioRestoreActorAttribNo);
            this.groupNPCRestoreAttributes.Controls.Add(this.radioRestoreActorAttribYes);
            this.groupNPCRestoreAttributes.Location = new System.Drawing.Point(235, 19);
            this.groupNPCRestoreAttributes.Name = "groupNPCRestoreAttributes";
            this.groupNPCRestoreAttributes.Size = new System.Drawing.Size(187, 63);
            this.groupNPCRestoreAttributes.TabIndex = 8;
            this.groupNPCRestoreAttributes.TabStop = false;
            this.groupNPCRestoreAttributes.Text = "Actor attribute restoration";
            this.groupNPCRestoreAttributes.MouseHover += new System.EventHandler(this.groupNPCRestoreAttributes_MouseHover);
            // 
            // radioRestoreActorAttribNo
            // 
            this.radioRestoreActorAttribNo.AutoSize = true;
            this.radioRestoreActorAttribNo.Checked = true;
            this.radioRestoreActorAttribNo.Location = new System.Drawing.Point(7, 39);
            this.radioRestoreActorAttribNo.Name = "radioRestoreActorAttribNo";
            this.radioRestoreActorAttribNo.Size = new System.Drawing.Size(39, 17);
            this.radioRestoreActorAttribNo.TabIndex = 1;
            this.radioRestoreActorAttribNo.TabStop = true;
            this.radioRestoreActorAttribNo.Text = "No";
            this.radioRestoreActorAttribNo.UseVisualStyleBackColor = true;
            // 
            // radioRestoreActorAttribYes
            // 
            this.radioRestoreActorAttribYes.AutoSize = true;
            this.radioRestoreActorAttribYes.Location = new System.Drawing.Point(7, 20);
            this.radioRestoreActorAttribYes.Name = "radioRestoreActorAttribYes";
            this.radioRestoreActorAttribYes.Size = new System.Drawing.Size(43, 17);
            this.radioRestoreActorAttribYes.TabIndex = 0;
            this.radioRestoreActorAttribYes.Text = "Yes";
            this.radioRestoreActorAttribYes.UseVisualStyleBackColor = true;
            this.radioRestoreActorAttribYes.CheckedChanged += new System.EventHandler(this.radioRestoreActorAttribYes_CheckedChanged);
            // 
            // groupNPCRandomizeAttributes
            // 
            this.groupNPCRandomizeAttributes.Controls.Add(this.radioAttribAll);
            this.groupNPCRandomizeAttributes.Controls.Add(this.radioAttribNonEssential);
            this.groupNPCRandomizeAttributes.Controls.Add(this.radioAttribDisabled);
            this.groupNPCRandomizeAttributes.Location = new System.Drawing.Point(7, 19);
            this.groupNPCRandomizeAttributes.Name = "groupNPCRandomizeAttributes";
            this.groupNPCRandomizeAttributes.Size = new System.Drawing.Size(187, 90);
            this.groupNPCRandomizeAttributes.TabIndex = 7;
            this.groupNPCRandomizeAttributes.TabStop = false;
            this.groupNPCRandomizeAttributes.Text = "Actor attribute randomization";
            this.groupNPCRandomizeAttributes.MouseHover += new System.EventHandler(this.groupNPCRandomizeAttributes_MouseHover);
            // 
            // radioAttribAll
            // 
            this.radioAttribAll.AutoSize = true;
            this.radioAttribAll.Location = new System.Drawing.Point(7, 59);
            this.radioAttribAll.Name = "radioAttribAll";
            this.radioAttribAll.Size = new System.Drawing.Size(92, 17);
            this.radioAttribAll.TabIndex = 2;
            this.radioAttribAll.Text = "Enabled for all";
            this.radioAttribAll.UseVisualStyleBackColor = true;
            // 
            // radioAttribNonEssential
            // 
            this.radioAttribNonEssential.AutoSize = true;
            this.radioAttribNonEssential.Checked = true;
            this.radioAttribNonEssential.Location = new System.Drawing.Point(7, 39);
            this.radioAttribNonEssential.Name = "radioAttribNonEssential";
            this.radioAttribNonEssential.Size = new System.Drawing.Size(158, 17);
            this.radioAttribNonEssential.TabIndex = 1;
            this.radioAttribNonEssential.TabStop = true;
            this.radioAttribNonEssential.Text = "Only for non-essential actors";
            this.radioAttribNonEssential.UseVisualStyleBackColor = true;
            // 
            // radioAttribDisabled
            // 
            this.radioAttribDisabled.AutoSize = true;
            this.radioAttribDisabled.Location = new System.Drawing.Point(7, 20);
            this.radioAttribDisabled.Name = "radioAttribDisabled";
            this.radioAttribDisabled.Size = new System.Drawing.Size(66, 17);
            this.radioAttribDisabled.TabIndex = 0;
            this.radioAttribDisabled.Text = "Disabled";
            this.radioAttribDisabled.UseVisualStyleBackColor = true;
            // 
            // groupNPCVampire
            // 
            this.groupNPCVampire.Controls.Add(this.numericVampire);
            this.groupNPCVampire.Location = new System.Drawing.Point(235, 95);
            this.groupNPCVampire.Name = "groupNPCVampire";
            this.groupNPCVampire.Size = new System.Drawing.Size(187, 53);
            this.groupNPCVampire.TabIndex = 6;
            this.groupNPCVampire.TabStop = false;
            this.groupNPCVampire.Text = "Vampirism chance (%)";
            this.groupNPCVampire.MouseHover += new System.EventHandler(this.groupNPCVampire_MouseHover);
            // 
            // numericVampire
            // 
            this.numericVampire.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericVampire.Location = new System.Drawing.Point(7, 19);
            this.numericVampire.Name = "numericVampire";
            this.numericVampire.Size = new System.Drawing.Size(120, 20);
            this.numericVampire.TabIndex = 0;
            this.numericVampire.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tabCreatureSettings
            // 
            this.tabCreatureSettings.Controls.Add(this.groupCreatures);
            this.tabCreatureSettings.Location = new System.Drawing.Point(4, 22);
            this.tabCreatureSettings.Name = "tabCreatureSettings";
            this.tabCreatureSettings.Size = new System.Drawing.Size(668, 336);
            this.tabCreatureSettings.TabIndex = 3;
            this.tabCreatureSettings.Text = "Creature settings";
            this.tabCreatureSettings.UseVisualStyleBackColor = true;
            // 
            // groupCreatures
            // 
            this.groupCreatures.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupCreatures.Controls.Add(this.groupUseEssentialCreatures);
            this.groupCreatures.Controls.Add(this.groupExcludeHorses);
            this.groupCreatures.Controls.Add(this.groupMiscRandCreatures);
            this.groupCreatures.Location = new System.Drawing.Point(6, 6);
            this.groupCreatures.Name = "groupCreatures";
            this.groupCreatures.Size = new System.Drawing.Size(656, 124);
            this.groupCreatures.TabIndex = 3;
            this.groupCreatures.TabStop = false;
            this.groupCreatures.Text = "Creatures";
            // 
            // groupUseEssentialCreatures
            // 
            this.groupUseEssentialCreatures.Controls.Add(this.radioUseEssentialCreaturesYes);
            this.groupUseEssentialCreatures.Controls.Add(this.radioUseEssentialCreaturesNo);
            this.groupUseEssentialCreatures.Location = new System.Drawing.Point(234, 19);
            this.groupUseEssentialCreatures.Name = "groupUseEssentialCreatures";
            this.groupUseEssentialCreatures.Size = new System.Drawing.Size(188, 61);
            this.groupUseEssentialCreatures.TabIndex = 12;
            this.groupUseEssentialCreatures.TabStop = false;
            this.groupUseEssentialCreatures.Text = "Use essential creatures";
            this.groupUseEssentialCreatures.MouseHover += new System.EventHandler(this.groupUseEssentialCreatures_MouseHover);
            // 
            // radioUseEssentialCreaturesYes
            // 
            this.radioUseEssentialCreaturesYes.AutoSize = true;
            this.radioUseEssentialCreaturesYes.Location = new System.Drawing.Point(6, 19);
            this.radioUseEssentialCreaturesYes.Name = "radioUseEssentialCreaturesYes";
            this.radioUseEssentialCreaturesYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioUseEssentialCreaturesYes.Size = new System.Drawing.Size(43, 17);
            this.radioUseEssentialCreaturesYes.TabIndex = 0;
            this.radioUseEssentialCreaturesYes.Text = "Yes";
            this.radioUseEssentialCreaturesYes.UseVisualStyleBackColor = true;
            // 
            // radioUseEssentialCreaturesNo
            // 
            this.radioUseEssentialCreaturesNo.AutoSize = true;
            this.radioUseEssentialCreaturesNo.Checked = true;
            this.radioUseEssentialCreaturesNo.Location = new System.Drawing.Point(6, 38);
            this.radioUseEssentialCreaturesNo.Name = "radioUseEssentialCreaturesNo";
            this.radioUseEssentialCreaturesNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioUseEssentialCreaturesNo.Size = new System.Drawing.Size(39, 17);
            this.radioUseEssentialCreaturesNo.TabIndex = 1;
            this.radioUseEssentialCreaturesNo.TabStop = true;
            this.radioUseEssentialCreaturesNo.Text = "No";
            this.radioUseEssentialCreaturesNo.UseVisualStyleBackColor = true;
            // 
            // groupExcludeHorses
            // 
            this.groupExcludeHorses.Controls.Add(this.radioExcludeHorsesYes);
            this.groupExcludeHorses.Controls.Add(this.radioExcludeHorsesNo);
            this.groupExcludeHorses.Location = new System.Drawing.Point(462, 19);
            this.groupExcludeHorses.Name = "groupExcludeHorses";
            this.groupExcludeHorses.Size = new System.Drawing.Size(188, 61);
            this.groupExcludeHorses.TabIndex = 11;
            this.groupExcludeHorses.TabStop = false;
            this.groupExcludeHorses.Text = "Exclude horses";
            this.groupExcludeHorses.MouseHover += new System.EventHandler(this.groupExcludeHorses_MouseHover);
            // 
            // radioExcludeHorsesYes
            // 
            this.radioExcludeHorsesYes.AutoSize = true;
            this.radioExcludeHorsesYes.Checked = true;
            this.radioExcludeHorsesYes.Location = new System.Drawing.Point(6, 19);
            this.radioExcludeHorsesYes.Name = "radioExcludeHorsesYes";
            this.radioExcludeHorsesYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioExcludeHorsesYes.Size = new System.Drawing.Size(119, 17);
            this.radioExcludeHorsesYes.TabIndex = 0;
            this.radioExcludeHorsesYes.TabStop = true;
            this.radioExcludeHorsesYes.Text = "Yes (recommended)";
            this.radioExcludeHorsesYes.UseVisualStyleBackColor = true;
            // 
            // radioExcludeHorsesNo
            // 
            this.radioExcludeHorsesNo.AutoSize = true;
            this.radioExcludeHorsesNo.Location = new System.Drawing.Point(6, 38);
            this.radioExcludeHorsesNo.Name = "radioExcludeHorsesNo";
            this.radioExcludeHorsesNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioExcludeHorsesNo.Size = new System.Drawing.Size(39, 17);
            this.radioExcludeHorsesNo.TabIndex = 1;
            this.radioExcludeHorsesNo.Text = "No";
            this.radioExcludeHorsesNo.UseVisualStyleBackColor = true;
            // 
            // groupMiscRandCreatures
            // 
            this.groupMiscRandCreatures.Controls.Add(this.radioRandCreaturesUnstable);
            this.groupMiscRandCreatures.Controls.Add(this.radioRandCreaturesEnabled);
            this.groupMiscRandCreatures.Controls.Add(this.radioRandCreaturesDisabled);
            this.groupMiscRandCreatures.Location = new System.Drawing.Point(6, 19);
            this.groupMiscRandCreatures.Name = "groupMiscRandCreatures";
            this.groupMiscRandCreatures.Size = new System.Drawing.Size(187, 90);
            this.groupMiscRandCreatures.TabIndex = 10;
            this.groupMiscRandCreatures.TabStop = false;
            this.groupMiscRandCreatures.Text = "Creature randomziation";
            this.groupMiscRandCreatures.MouseHover += new System.EventHandler(this.groupMiscRandCreatures_MouseHover);
            // 
            // radioRandCreaturesUnstable
            // 
            this.radioRandCreaturesUnstable.AutoSize = true;
            this.radioRandCreaturesUnstable.Location = new System.Drawing.Point(7, 59);
            this.radioRandCreaturesUnstable.Name = "radioRandCreaturesUnstable";
            this.radioRandCreaturesUnstable.Size = new System.Drawing.Size(110, 17);
            this.radioRandCreaturesUnstable.TabIndex = 2;
            this.radioRandCreaturesUnstable.Text = "Enabled, unstable";
            this.radioRandCreaturesUnstable.UseVisualStyleBackColor = true;
            // 
            // radioRandCreaturesEnabled
            // 
            this.radioRandCreaturesEnabled.AutoSize = true;
            this.radioRandCreaturesEnabled.Checked = true;
            this.radioRandCreaturesEnabled.Location = new System.Drawing.Point(7, 39);
            this.radioRandCreaturesEnabled.Name = "radioRandCreaturesEnabled";
            this.radioRandCreaturesEnabled.Size = new System.Drawing.Size(101, 17);
            this.radioRandCreaturesEnabled.TabIndex = 1;
            this.radioRandCreaturesEnabled.TabStop = true;
            this.radioRandCreaturesEnabled.Text = "Enabled, normal";
            this.radioRandCreaturesEnabled.UseVisualStyleBackColor = true;
            // 
            // radioRandCreaturesDisabled
            // 
            this.radioRandCreaturesDisabled.AutoSize = true;
            this.radioRandCreaturesDisabled.Location = new System.Drawing.Point(7, 20);
            this.radioRandCreaturesDisabled.Name = "radioRandCreaturesDisabled";
            this.radioRandCreaturesDisabled.Size = new System.Drawing.Size(66, 17);
            this.radioRandCreaturesDisabled.TabIndex = 0;
            this.radioRandCreaturesDisabled.Text = "Disabled";
            this.radioRandCreaturesDisabled.UseVisualStyleBackColor = true;
            // 
            // tabExcludes
            // 
            this.tabExcludes.Controls.Add(this.buttonReloadExcludes);
            this.tabExcludes.Controls.Add(this.buttonSaveExcludes);
            this.tabExcludes.Controls.Add(this.groupDontAddToRandomizerLists);
            this.tabExcludes.Controls.Add(this.groupDontRandomize);
            this.tabExcludes.Controls.Add(this.groupCurrentMods);
            this.tabExcludes.Location = new System.Drawing.Point(4, 22);
            this.tabExcludes.Name = "tabExcludes";
            this.tabExcludes.Size = new System.Drawing.Size(668, 336);
            this.tabExcludes.TabIndex = 4;
            this.tabExcludes.Text = "Mod excludes";
            this.tabExcludes.UseVisualStyleBackColor = true;
            // 
            // buttonReloadExcludes
            // 
            this.buttonReloadExcludes.Location = new System.Drawing.Point(357, 287);
            this.buttonReloadExcludes.Name = "buttonReloadExcludes";
            this.buttonReloadExcludes.Size = new System.Drawing.Size(291, 23);
            this.buttonReloadExcludes.TabIndex = 5;
            this.buttonReloadExcludes.Text = "Reload RandomizerSkip.cfg";
            this.buttonReloadExcludes.UseVisualStyleBackColor = true;
            this.buttonReloadExcludes.Click += new System.EventHandler(this.buttonReloadExcludes_Click);
            // 
            // buttonSaveExcludes
            // 
            this.buttonSaveExcludes.Location = new System.Drawing.Point(12, 287);
            this.buttonSaveExcludes.Name = "buttonSaveExcludes";
            this.buttonSaveExcludes.Size = new System.Drawing.Size(291, 23);
            this.buttonSaveExcludes.TabIndex = 4;
            this.buttonSaveExcludes.Text = "Save to RandomizerSkip.cfg";
            this.buttonSaveExcludes.UseVisualStyleBackColor = true;
            this.buttonSaveExcludes.Click += new System.EventHandler(this.buttonSaveExcludes_Click);
            // 
            // groupDontAddToRandomizerLists
            // 
            this.groupDontAddToRandomizerLists.Controls.Add(this.buttonDontAddToLists);
            this.groupDontAddToRandomizerLists.Controls.Add(this.textBoxDontAddToLists);
            this.groupDontAddToRandomizerLists.Location = new System.Drawing.Point(448, 6);
            this.groupDontAddToRandomizerLists.Name = "groupDontAddToRandomizerLists";
            this.groupDontAddToRandomizerLists.Size = new System.Drawing.Size(200, 258);
            this.groupDontAddToRandomizerLists.TabIndex = 3;
            this.groupDontAddToRandomizerLists.TabStop = false;
            this.groupDontAddToRandomizerLists.Text = "Don\'t add to lists";
            // 
            // buttonDontAddToLists
            // 
            this.buttonDontAddToLists.Location = new System.Drawing.Point(6, 229);
            this.buttonDontAddToLists.Name = "buttonDontAddToLists";
            this.buttonDontAddToLists.Size = new System.Drawing.Size(188, 23);
            this.buttonDontAddToLists.TabIndex = 3;
            this.buttonDontAddToLists.Text = "Paste selection from \"Your mods\"";
            this.buttonDontAddToLists.UseVisualStyleBackColor = true;
            this.buttonDontAddToLists.Click += new System.EventHandler(this.buttonDontAddToLists_Click);
            this.buttonDontAddToLists.MouseHover += new System.EventHandler(this.buttonDontAddToLists_MouseHover);
            // 
            // textBoxDontAddToLists
            // 
            this.textBoxDontAddToLists.AllowDrop = true;
            this.textBoxDontAddToLists.Location = new System.Drawing.Point(7, 19);
            this.textBoxDontAddToLists.Multiline = true;
            this.textBoxDontAddToLists.Name = "textBoxDontAddToLists";
            this.textBoxDontAddToLists.Size = new System.Drawing.Size(187, 204);
            this.textBoxDontAddToLists.TabIndex = 2;
            this.textBoxDontAddToLists.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxDontAddToLists_DragDrop);
            this.textBoxDontAddToLists.DragEnter += new System.Windows.Forms.DragEventHandler(this.listDontRandomize_DragEnter);
            this.textBoxDontAddToLists.MouseHover += new System.EventHandler(this.textBoxDontAddToLists_MouseHover);
            // 
            // groupDontRandomize
            // 
            this.groupDontRandomize.Controls.Add(this.buttonDontRandomizePaste);
            this.groupDontRandomize.Controls.Add(this.textBoxDontRandomize);
            this.groupDontRandomize.Location = new System.Drawing.Point(228, 6);
            this.groupDontRandomize.Name = "groupDontRandomize";
            this.groupDontRandomize.Size = new System.Drawing.Size(200, 258);
            this.groupDontRandomize.TabIndex = 2;
            this.groupDontRandomize.TabStop = false;
            this.groupDontRandomize.Text = "Don\'t randomize";
            // 
            // buttonDontRandomizePaste
            // 
            this.buttonDontRandomizePaste.Location = new System.Drawing.Point(6, 229);
            this.buttonDontRandomizePaste.Name = "buttonDontRandomizePaste";
            this.buttonDontRandomizePaste.Size = new System.Drawing.Size(188, 23);
            this.buttonDontRandomizePaste.TabIndex = 1;
            this.buttonDontRandomizePaste.Text = "Paste selection from \"Your mods\"";
            this.buttonDontRandomizePaste.UseVisualStyleBackColor = true;
            this.buttonDontRandomizePaste.Click += new System.EventHandler(this.buttonDontRandomizePaste_Click);
            this.buttonDontRandomizePaste.MouseHover += new System.EventHandler(this.buttonDontRandomizePaste_MouseHover);
            // 
            // textBoxDontRandomize
            // 
            this.textBoxDontRandomize.AllowDrop = true;
            this.textBoxDontRandomize.Location = new System.Drawing.Point(7, 19);
            this.textBoxDontRandomize.Multiline = true;
            this.textBoxDontRandomize.Name = "textBoxDontRandomize";
            this.textBoxDontRandomize.Size = new System.Drawing.Size(187, 204);
            this.textBoxDontRandomize.TabIndex = 0;
            this.textBoxDontRandomize.DragDrop += new System.Windows.Forms.DragEventHandler(this.listDontRandomize_DragDrop);
            this.textBoxDontRandomize.DragEnter += new System.Windows.Forms.DragEventHandler(this.listDontRandomize_DragEnter);
            this.textBoxDontRandomize.MouseHover += new System.EventHandler(this.textBoxDontRandomize_MouseHover);
            // 
            // groupCurrentMods
            // 
            this.groupCurrentMods.Controls.Add(this.listMods);
            this.groupCurrentMods.Location = new System.Drawing.Point(6, 6);
            this.groupCurrentMods.Name = "groupCurrentMods";
            this.groupCurrentMods.Size = new System.Drawing.Size(200, 258);
            this.groupCurrentMods.TabIndex = 1;
            this.groupCurrentMods.TabStop = false;
            this.groupCurrentMods.Text = "Your mods";
            // 
            // listMods
            // 
            this.listMods.AllowDrop = true;
            this.listMods.FormattingEnabled = true;
            this.listMods.Location = new System.Drawing.Point(6, 19);
            this.listMods.Name = "listMods";
            this.listMods.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listMods.Size = new System.Drawing.Size(188, 225);
            this.listMods.Sorted = true;
            this.listMods.TabIndex = 2;
            this.listMods.MouseHover += new System.EventHandler(this.listMods_MouseHover);
            // 
            // textBoxHelp
            // 
            this.textBoxHelp.Location = new System.Drawing.Point(695, 34);
            this.textBoxHelp.Multiline = true;
            this.textBoxHelp.Name = "textBoxHelp";
            this.textBoxHelp.Size = new System.Drawing.Size(258, 254);
            this.textBoxHelp.TabIndex = 1;
            this.textBoxHelp.Text = "Hover over an element to display help";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(426, 379);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save to main config";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseHover += new System.EventHandler(this.buttonSave_MouseHover);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(558, 379);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(126, 23);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load from main config";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            this.buttonLoad.MouseHover += new System.EventHandler(this.buttonLoad_MouseHover);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // comboTemplates
            // 
            this.comboTemplates.FormattingEnabled = true;
            this.comboTemplates.Location = new System.Drawing.Point(754, 294);
            this.comboTemplates.Name = "comboTemplates";
            this.comboTemplates.Size = new System.Drawing.Size(199, 21);
            this.comboTemplates.TabIndex = 4;
            this.comboTemplates.MouseHover += new System.EventHandler(this.labelTemplates_MouseHover);
            // 
            // labelTemplates
            // 
            this.labelTemplates.AutoSize = true;
            this.labelTemplates.Location = new System.Drawing.Point(694, 297);
            this.labelTemplates.Name = "labelTemplates";
            this.labelTemplates.Size = new System.Drawing.Size(54, 13);
            this.labelTemplates.TabIndex = 5;
            this.labelTemplates.Text = "Template:";
            this.labelTemplates.MouseHover += new System.EventHandler(this.labelTemplates_MouseHover);
            // 
            // buttonSaveTemplate
            // 
            this.buttonSaveTemplate.Location = new System.Drawing.Point(697, 350);
            this.buttonSaveTemplate.Name = "buttonSaveTemplate";
            this.buttonSaveTemplate.Size = new System.Drawing.Size(259, 23);
            this.buttonSaveTemplate.TabIndex = 6;
            this.buttonSaveTemplate.Text = "Save current settings to template";
            this.buttonSaveTemplate.UseVisualStyleBackColor = true;
            this.buttonSaveTemplate.Click += new System.EventHandler(this.buttonSaveTemplate_Click);
            this.buttonSaveTemplate.MouseHover += new System.EventHandler(this.labelTemplates_MouseHover);
            // 
            // buttonLoadTemplate
            // 
            this.buttonLoadTemplate.Location = new System.Drawing.Point(697, 321);
            this.buttonLoadTemplate.Name = "buttonLoadTemplate";
            this.buttonLoadTemplate.Size = new System.Drawing.Size(259, 23);
            this.buttonLoadTemplate.TabIndex = 7;
            this.buttonLoadTemplate.Text = "Load template";
            this.buttonLoadTemplate.UseVisualStyleBackColor = true;
            this.buttonLoadTemplate.Click += new System.EventHandler(this.buttonLoadTemplate_Click);
            this.buttonLoadTemplate.MouseHover += new System.EventHandler(this.labelTemplates_MouseHover);
            // 
            // buttonDeleteTemplate
            // 
            this.buttonDeleteTemplate.Location = new System.Drawing.Point(698, 379);
            this.buttonDeleteTemplate.Name = "buttonDeleteTemplate";
            this.buttonDeleteTemplate.Size = new System.Drawing.Size(258, 23);
            this.buttonDeleteTemplate.TabIndex = 8;
            this.buttonDeleteTemplate.Text = "Delete template";
            this.buttonDeleteTemplate.UseVisualStyleBackColor = true;
            this.buttonDeleteTemplate.Click += new System.EventHandler(this.buttonDeleteTemplate_Click);
            this.buttonDeleteTemplate.MouseHover += new System.EventHandler(this.labelTemplates_MouseHover);
            // 
            // labelLastLoaded
            // 
            this.labelLastLoaded.AutoSize = true;
            this.labelLastLoaded.Location = new System.Drawing.Point(13, 384);
            this.labelLastLoaded.Name = "labelLastLoaded";
            this.labelLastLoaded.Size = new System.Drawing.Size(102, 13);
            this.labelLastLoaded.TabIndex = 9;
            this.labelLastLoaded.Text = "Currently loaded file:";
            // 
            // RandConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 425);
            this.Controls.Add(this.labelLastLoaded);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonDeleteTemplate);
            this.Controls.Add(this.buttonLoadTemplate);
            this.Controls.Add(this.buttonSaveTemplate);
            this.Controls.Add(this.labelTemplates);
            this.Controls.Add(this.comboTemplates);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxHelp);
            this.Controls.Add(this.tabs);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(981, 464);
            this.MinimumSize = new System.Drawing.Size(981, 464);
            this.Name = "RandConfigForm";
            this.Text = "Oblivion Randomizer Config";
            this.Load += new System.EventHandler(this.RandConfigForm_Load);
            this.tabs.ResumeLayout(false);
            this.tabMiscSettings.ResumeLayout(false);
            this.groupMisc.ResumeLayout(false);
            this.groupMiscSeed.ResumeLayout(false);
            this.groupMiscSeed.PerformLayout();
            this.groupMiscPatches.ResumeLayout(false);
            this.groupMiscPatches.PerformLayout();
            this.groupMiscHitEffect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericHitEffect)).EndInit();
            this.groupMiscDelayStart.ResumeLayout(false);
            this.groupMiscDelayStart.PerformLayout();
            this.groupMiscQuestObjects.ResumeLayout(false);
            this.groupMiscQuestObjects.PerformLayout();
            this.groupMiscSpells.ResumeLayout(false);
            this.groupMiscSpells.PerformLayout();
            this.tabLootSettings.ResumeLayout(false);
            this.groupLoot.ResumeLayout(false);
            this.groupLootExcludeUnplayableItems.ResumeLayout(false);
            this.groupLootExcludeUnplayableItems.PerformLayout();
            this.groupLootGold.ResumeLayout(false);
            this.groupLootGold.PerformLayout();
            this.groupLootDeathItem.ResumeLayout(false);
            this.groupLootDeathItem.PerformLayout();
            this.groupLootAddItem.ResumeLayout(false);
            this.groupLootAddItem.PerformLayout();
            this.groupLootWorldItem.ResumeLayout(false);
            this.groupLootWorldItem.PerformLayout();
            this.groupLootRandChestInventory.ResumeLayout(false);
            this.groupLootRandChestInventory.PerformLayout();
            this.groupLootRandActorInventory.ResumeLayout(false);
            this.groupLootRandActorInventory.PerformLayout();
            this.tabActorSettings.ResumeLayout(false);
            this.groupActors.ResumeLayout(false);
            this.groupNPCActorScaling.ResumeLayout(false);
            this.groupNPCActorScaling.PerformLayout();
            this.panelActorScaling.ResumeLayout(false);
            this.panelActorScaling.PerformLayout();
            this.groupNPCRestoreAttributes.ResumeLayout(false);
            this.groupNPCRestoreAttributes.PerformLayout();
            this.groupNPCRandomizeAttributes.ResumeLayout(false);
            this.groupNPCRandomizeAttributes.PerformLayout();
            this.groupNPCVampire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericVampire)).EndInit();
            this.tabCreatureSettings.ResumeLayout(false);
            this.groupCreatures.ResumeLayout(false);
            this.groupUseEssentialCreatures.ResumeLayout(false);
            this.groupUseEssentialCreatures.PerformLayout();
            this.groupExcludeHorses.ResumeLayout(false);
            this.groupExcludeHorses.PerformLayout();
            this.groupMiscRandCreatures.ResumeLayout(false);
            this.groupMiscRandCreatures.PerformLayout();
            this.tabExcludes.ResumeLayout(false);
            this.groupDontAddToRandomizerLists.ResumeLayout(false);
            this.groupDontAddToRandomizerLists.PerformLayout();
            this.groupDontRandomize.ResumeLayout(false);
            this.groupDontRandomize.PerformLayout();
            this.groupCurrentMods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

