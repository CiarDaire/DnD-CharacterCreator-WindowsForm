namespace Assessment2
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.lvlLabel = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioOther = new System.Windows.Forms.RadioButton();
            this.genderLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.raceTab = new System.Windows.Forms.TabPage();
            this.modifierLabel = new System.Windows.Forms.Label();
            this.raceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.raceTraitsLabel = new System.Windows.Forms.Label();
            this.raceListbox = new System.Windows.Forms.ListBox();
            this.raceCombobox = new System.Windows.Forms.ComboBox();
            this.classTab = new System.Windows.Forms.TabPage();
            this.classListbox = new System.Windows.Forms.ListBox();
            this.backgroundTab = new System.Windows.Forms.TabPage();
            this.backgroundTextbox = new System.Windows.Forms.TextBox();
            this.backgroundListbox = new System.Windows.Forms.ListBox();
            this.cantripTab = new System.Windows.Forms.TabPage();
            this.cantripLabel = new System.Windows.Forms.Label();
            this.cantripCheckedlistbox = new System.Windows.Forms.CheckedListBox();
            this.skillsTab = new System.Windows.Forms.TabPage();
            this.baseSkillsRollBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.strLabel = new System.Windows.Forms.Label();
            this.wdmLabel = new System.Windows.Forms.Label();
            this.ctsnLabel = new System.Windows.Forms.Label();
            this.intLabel = new System.Windows.Forms.Label();
            this.chrLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.strRange = new System.Windows.Forms.NumericUpDown();
            this.wisRange = new System.Windows.Forms.NumericUpDown();
            this.constRange = new System.Windows.Forms.NumericUpDown();
            this.intRange = new System.Windows.Forms.NumericUpDown();
            this.chrRange = new System.Windows.Forms.NumericUpDown();
            this.dexRange = new System.Windows.Forms.NumericUpDown();
            this.strCounterLabel = new System.Windows.Forms.Label();
            this.wisCounterLabel = new System.Windows.Forms.Label();
            this.constCounterLabel = new System.Windows.Forms.Label();
            this.intCounterLabel = new System.Windows.Forms.Label();
            this.chaCounterLabel = new System.Windows.Forms.Label();
            this.dexCounterLabel = new System.Windows.Forms.Label();
            this.viewTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.viewTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lvlNumeric = new System.Windows.Forms.NumericUpDown();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.classTextbox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.raceTab.SuspendLayout();
            this.classTab.SuspendLayout();
            this.backgroundTab.SuspendLayout();
            this.cantripTab.SuspendLayout();
            this.skillsTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexRange)).BeginInit();
            this.viewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvlNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(81, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(129, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Character Name:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(216, 30);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(347, 26);
            this.nameInput.TabIndex = 1;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // lvlLabel
            // 
            this.lvlLabel.AutoSize = true;
            this.lvlLabel.Location = new System.Drawing.Point(588, 36);
            this.lvlLabel.Name = "lvlLabel";
            this.lvlLabel.Size = new System.Drawing.Size(50, 20);
            this.lvlLabel.TabIndex = 2;
            this.lvlLabel.Text = "Level:";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Checked = true;
            this.radioMale.Location = new System.Drawing.Point(197, 84);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(68, 24);
            this.radioMale.TabIndex = 4;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(363, 84);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(87, 24);
            this.radioFemale.TabIndex = 5;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // radioOther
            // 
            this.radioOther.AutoSize = true;
            this.radioOther.Location = new System.Drawing.Point(533, 84);
            this.radioOther.Name = "radioOther";
            this.radioOther.Size = new System.Drawing.Size(74, 24);
            this.radioOther.TabIndex = 6;
            this.radioOther.Text = "Other";
            this.radioOther.UseVisualStyleBackColor = true;
            this.radioOther.CheckedChanged += new System.EventHandler(this.radioOther_CheckedChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(81, 86);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(67, 20);
            this.genderLabel.TabIndex = 7;
            this.genderLabel.Text = "Gender:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.raceTab);
            this.tabControl1.Controls.Add(this.classTab);
            this.tabControl1.Controls.Add(this.backgroundTab);
            this.tabControl1.Controls.Add(this.cantripTab);
            this.tabControl1.Controls.Add(this.skillsTab);
            this.tabControl1.Controls.Add(this.viewTab);
            this.tabControl1.Location = new System.Drawing.Point(-4, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 328);
            this.tabControl1.TabIndex = 8;
            // 
            // raceTab
            // 
            this.raceTab.Controls.Add(this.modifierLabel);
            this.raceTab.Controls.Add(this.raceLinkLabel);
            this.raceTab.Controls.Add(this.raceTraitsLabel);
            this.raceTab.Controls.Add(this.raceListbox);
            this.raceTab.Controls.Add(this.raceCombobox);
            this.raceTab.Location = new System.Drawing.Point(4, 29);
            this.raceTab.Name = "raceTab";
            this.raceTab.Padding = new System.Windows.Forms.Padding(3);
            this.raceTab.Size = new System.Drawing.Size(654, 295);
            this.raceTab.TabIndex = 0;
            this.raceTab.Text = "Race";
            this.raceTab.UseVisualStyleBackColor = true;
            // 
            // modifierLabel
            // 
            this.modifierLabel.AutoSize = true;
            this.modifierLabel.BackColor = System.Drawing.Color.Transparent;
            this.modifierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierLabel.Location = new System.Drawing.Point(323, 38);
            this.modifierLabel.Name = "modifierLabel";
            this.modifierLabel.Size = new System.Drawing.Size(114, 20);
            this.modifierLabel.TabIndex = 4;
            this.modifierLabel.Text = "Racial Traits:";
            // 
            // raceLinkLabel
            // 
            this.raceLinkLabel.AutoSize = true;
            this.raceLinkLabel.Location = new System.Drawing.Point(323, 247);
            this.raceLinkLabel.Name = "raceLinkLabel";
            this.raceLinkLabel.Size = new System.Drawing.Size(88, 20);
            this.raceLinkLabel.TabIndex = 3;
            this.raceLinkLabel.TabStop = true;
            this.raceLinkLabel.Text = "Read More";
            this.raceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.raceLinkLabel_LinkClicked);
            // 
            // raceTraitsLabel
            // 
            this.raceTraitsLabel.AutoSize = true;
            this.raceTraitsLabel.Location = new System.Drawing.Point(323, 79);
            this.raceTraitsLabel.Name = "raceTraitsLabel";
            this.raceTraitsLabel.Size = new System.Drawing.Size(0, 20);
            this.raceTraitsLabel.TabIndex = 2;
            this.raceTraitsLabel.Click += new System.EventHandler(this.raceTraitsLabel_Click);
            // 
            // raceListbox
            // 
            this.raceListbox.FormattingEnabled = true;
            this.raceListbox.ItemHeight = 20;
            this.raceListbox.Location = new System.Drawing.Point(24, 87);
            this.raceListbox.Name = "raceListbox";
            this.raceListbox.Size = new System.Drawing.Size(253, 184);
            this.raceListbox.TabIndex = 1;
            this.raceListbox.SelectedIndexChanged += new System.EventHandler(this.raceListbox_SelectedIndexChanged);
            // 
            // raceCombobox
            // 
            this.raceCombobox.FormattingEnabled = true;
            this.raceCombobox.Items.AddRange(new object[] {
            "Elf",
            "Dwarf",
            "Dragonborn",
            "Half-Elf",
            "Half-Orc",
            "Halfling",
            "Human",
            "Gnome",
            "Tiefling",
            "Genasi",
            "Drow",
            "Githyanki"});
            this.raceCombobox.Location = new System.Drawing.Point(24, 35);
            this.raceCombobox.Name = "raceCombobox";
            this.raceCombobox.Size = new System.Drawing.Size(253, 28);
            this.raceCombobox.TabIndex = 0;
            this.raceCombobox.SelectedIndexChanged += new System.EventHandler(this.raceCombobox_SelectedIndexChanged);
            // 
            // classTab
            // 
            this.classTab.Controls.Add(this.classTextbox);
            this.classTab.Controls.Add(this.classListbox);
            this.classTab.Location = new System.Drawing.Point(4, 29);
            this.classTab.Name = "classTab";
            this.classTab.Padding = new System.Windows.Forms.Padding(3);
            this.classTab.Size = new System.Drawing.Size(654, 295);
            this.classTab.TabIndex = 1;
            this.classTab.Text = "Class";
            this.classTab.UseVisualStyleBackColor = true;
            // 
            // classListbox
            // 
            this.classListbox.FormattingEnabled = true;
            this.classListbox.ItemHeight = 20;
            this.classListbox.Items.AddRange(new object[] {
            "Cleric",
            "Bard",
            "Wizard",
            "Warlock",
            "Ranger",
            "Barbarian",
            "Druid",
            "Monk",
            "Fighter",
            "Paladin",
            "Rogue",
            "Sorcerer"});
            this.classListbox.Location = new System.Drawing.Point(29, 26);
            this.classListbox.Name = "classListbox";
            this.classListbox.Size = new System.Drawing.Size(199, 244);
            this.classListbox.TabIndex = 0;
            this.classListbox.SelectedIndexChanged += new System.EventHandler(this.classListbox_SelectedIndexChanged);
            // 
            // backgroundTab
            // 
            this.backgroundTab.Controls.Add(this.backgroundTextbox);
            this.backgroundTab.Controls.Add(this.backgroundListbox);
            this.backgroundTab.Location = new System.Drawing.Point(4, 29);
            this.backgroundTab.Name = "backgroundTab";
            this.backgroundTab.Padding = new System.Windows.Forms.Padding(3);
            this.backgroundTab.Size = new System.Drawing.Size(654, 295);
            this.backgroundTab.TabIndex = 2;
            this.backgroundTab.Text = "Background";
            this.backgroundTab.UseVisualStyleBackColor = true;
            // 
            // backgroundTextbox
            // 
            this.backgroundTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.backgroundTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backgroundTextbox.Location = new System.Drawing.Point(256, 26);
            this.backgroundTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.backgroundTextbox.Multiline = true;
            this.backgroundTextbox.Name = "backgroundTextbox";
            this.backgroundTextbox.ReadOnly = true;
            this.backgroundTextbox.Size = new System.Drawing.Size(368, 244);
            this.backgroundTextbox.TabIndex = 2;
            this.backgroundTextbox.TextChanged += new System.EventHandler(this.backgroundTextbox_TextChanged);
            // 
            // backgroundListbox
            // 
            this.backgroundListbox.FormattingEnabled = true;
            this.backgroundListbox.ItemHeight = 20;
            this.backgroundListbox.Items.AddRange(new object[] {
            "Urchin",
            "Entertainer",
            "Acolyte",
            "Charlatan",
            "Criminal",
            "Folk Hero",
            "Guild Artisan",
            "Noble",
            "Sage",
            "Outlander",
            "Soldier"});
            this.backgroundListbox.Location = new System.Drawing.Point(29, 26);
            this.backgroundListbox.Name = "backgroundListbox";
            this.backgroundListbox.Size = new System.Drawing.Size(199, 244);
            this.backgroundListbox.TabIndex = 1;
            this.backgroundListbox.SelectedIndexChanged += new System.EventHandler(this.backgroundListbox_SelectedIndexChanged);
            // 
            // cantripTab
            // 
            this.cantripTab.Controls.Add(this.cantripLabel);
            this.cantripTab.Controls.Add(this.cantripCheckedlistbox);
            this.cantripTab.Location = new System.Drawing.Point(4, 29);
            this.cantripTab.Name = "cantripTab";
            this.cantripTab.Padding = new System.Windows.Forms.Padding(3);
            this.cantripTab.Size = new System.Drawing.Size(654, 295);
            this.cantripTab.TabIndex = 3;
            this.cantripTab.Text = "Cantrips";
            this.cantripTab.UseVisualStyleBackColor = true;
            // 
            // cantripLabel
            // 
            this.cantripLabel.AutoSize = true;
            this.cantripLabel.Location = new System.Drawing.Point(12, 24);
            this.cantripLabel.Name = "cantripLabel";
            this.cantripLabel.Size = new System.Drawing.Size(160, 20);
            this.cantripLabel.TabIndex = 2;
            this.cantripLabel.Text = "Please select a class.";
            this.cantripLabel.Click += new System.EventHandler(this.cantripLabel_Click_1);
            // 
            // cantripCheckedlistbox
            // 
            this.cantripCheckedlistbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cantripCheckedlistbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cantripCheckedlistbox.CheckOnClick = true;
            this.cantripCheckedlistbox.FormattingEnabled = true;
            this.cantripCheckedlistbox.Location = new System.Drawing.Point(12, 75);
            this.cantripCheckedlistbox.MultiColumn = true;
            this.cantripCheckedlistbox.Name = "cantripCheckedlistbox";
            this.cantripCheckedlistbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cantripCheckedlistbox.Size = new System.Drawing.Size(626, 184);
            this.cantripCheckedlistbox.TabIndex = 1;
            this.cantripCheckedlistbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cantripCheckedlistbox_ItemCheck);
            this.cantripCheckedlistbox.SelectedIndexChanged += new System.EventHandler(this.cantripCheckedlistbox_SelectedIndexChanged);
            // 
            // skillsTab
            // 
            this.skillsTab.Controls.Add(this.baseSkillsRollBtn);
            this.skillsTab.Controls.Add(this.tableLayoutPanel1);
            this.skillsTab.Location = new System.Drawing.Point(4, 29);
            this.skillsTab.Name = "skillsTab";
            this.skillsTab.Padding = new System.Windows.Forms.Padding(3);
            this.skillsTab.Size = new System.Drawing.Size(654, 295);
            this.skillsTab.TabIndex = 5;
            this.skillsTab.Text = "Skills";
            this.skillsTab.UseVisualStyleBackColor = true;
            // 
            // baseSkillsRollBtn
            // 
            this.baseSkillsRollBtn.Location = new System.Drawing.Point(37, 115);
            this.baseSkillsRollBtn.Name = "baseSkillsRollBtn";
            this.baseSkillsRollBtn.Size = new System.Drawing.Size(238, 38);
            this.baseSkillsRollBtn.TabIndex = 3;
            this.baseSkillsRollBtn.Text = "Roll for Skills";
            this.baseSkillsRollBtn.UseVisualStyleBackColor = true;
            this.baseSkillsRollBtn.Click += new System.EventHandler(this.baseSkillsRollBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.24176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.75824F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Controls.Add(this.strLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.wdmLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ctsnLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.intLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chrLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dexLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.strRange, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.wisRange, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.constRange, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.intRange, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.chrRange, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dexRange, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.strCounterLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.wisCounterLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.constCounterLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.intCounterLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.chaCounterLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dexCounterLabel, 2, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(327, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 209);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Location = new System.Drawing.Point(4, 1);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(75, 20);
            this.strLabel.TabIndex = 0;
            this.strLabel.Text = "Strength:";
            // 
            // wdmLabel
            // 
            this.wdmLabel.AutoSize = true;
            this.wdmLabel.Location = new System.Drawing.Point(4, 33);
            this.wdmLabel.Name = "wdmLabel";
            this.wdmLabel.Size = new System.Drawing.Size(70, 20);
            this.wdmLabel.TabIndex = 1;
            this.wdmLabel.Text = "Wisdom:";
            // 
            // ctsnLabel
            // 
            this.ctsnLabel.AutoSize = true;
            this.ctsnLabel.Location = new System.Drawing.Point(4, 65);
            this.ctsnLabel.Name = "ctsnLabel";
            this.ctsnLabel.Size = new System.Drawing.Size(98, 20);
            this.ctsnLabel.TabIndex = 2;
            this.ctsnLabel.Text = "Constitution:";
            // 
            // intLabel
            // 
            this.intLabel.AutoSize = true;
            this.intLabel.Location = new System.Drawing.Point(4, 99);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(94, 20);
            this.intLabel.TabIndex = 3;
            this.intLabel.Text = "Intelligence:";
            // 
            // chrLabel
            // 
            this.chrLabel.AutoSize = true;
            this.chrLabel.Location = new System.Drawing.Point(4, 135);
            this.chrLabel.Name = "chrLabel";
            this.chrLabel.Size = new System.Drawing.Size(80, 20);
            this.chrLabel.TabIndex = 4;
            this.chrLabel.Text = "Charisma:";
            // 
            // dexLabel
            // 
            this.dexLabel.AutoSize = true;
            this.dexLabel.Location = new System.Drawing.Point(4, 170);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(75, 20);
            this.dexLabel.TabIndex = 5;
            this.dexLabel.Text = "Dexterity:";
            // 
            // strRange
            // 
            this.strRange.Location = new System.Drawing.Point(113, 4);
            this.strRange.Name = "strRange";
            this.strRange.Size = new System.Drawing.Size(72, 26);
            this.strRange.TabIndex = 6;
            this.strRange.ValueChanged += new System.EventHandler(this.strRange_ValueChanged);
            // 
            // wisRange
            // 
            this.wisRange.Location = new System.Drawing.Point(113, 36);
            this.wisRange.Name = "wisRange";
            this.wisRange.Size = new System.Drawing.Size(72, 26);
            this.wisRange.TabIndex = 7;
            this.wisRange.ValueChanged += new System.EventHandler(this.wisRange_ValueChanged);
            // 
            // constRange
            // 
            this.constRange.Location = new System.Drawing.Point(113, 68);
            this.constRange.Name = "constRange";
            this.constRange.Size = new System.Drawing.Size(72, 26);
            this.constRange.TabIndex = 8;
            this.constRange.ValueChanged += new System.EventHandler(this.constRange_ValueChanged);
            // 
            // intRange
            // 
            this.intRange.Location = new System.Drawing.Point(113, 102);
            this.intRange.Name = "intRange";
            this.intRange.Size = new System.Drawing.Size(72, 26);
            this.intRange.TabIndex = 9;
            this.intRange.ValueChanged += new System.EventHandler(this.intRange_ValueChanged);
            // 
            // chrRange
            // 
            this.chrRange.Location = new System.Drawing.Point(113, 138);
            this.chrRange.Name = "chrRange";
            this.chrRange.Size = new System.Drawing.Size(72, 26);
            this.chrRange.TabIndex = 10;
            this.chrRange.ValueChanged += new System.EventHandler(this.chrRange_ValueChanged);
            // 
            // dexRange
            // 
            this.dexRange.Location = new System.Drawing.Point(113, 173);
            this.dexRange.Name = "dexRange";
            this.dexRange.Size = new System.Drawing.Size(72, 26);
            this.dexRange.TabIndex = 11;
            this.dexRange.ValueChanged += new System.EventHandler(this.dexRange_ValueChanged);
            // 
            // strCounterLabel
            // 
            this.strCounterLabel.AutoSize = true;
            this.strCounterLabel.Location = new System.Drawing.Point(192, 1);
            this.strCounterLabel.Name = "strCounterLabel";
            this.strCounterLabel.Size = new System.Drawing.Size(0, 20);
            this.strCounterLabel.TabIndex = 12;
            this.strCounterLabel.Click += new System.EventHandler(this.strCounterLabel_Click);
            // 
            // wisCounterLabel
            // 
            this.wisCounterLabel.AutoSize = true;
            this.wisCounterLabel.Location = new System.Drawing.Point(192, 33);
            this.wisCounterLabel.Name = "wisCounterLabel";
            this.wisCounterLabel.Size = new System.Drawing.Size(0, 20);
            this.wisCounterLabel.TabIndex = 13;
            this.wisCounterLabel.Click += new System.EventHandler(this.wisCounterLabel_Click);
            // 
            // constCounterLabel
            // 
            this.constCounterLabel.AutoSize = true;
            this.constCounterLabel.Location = new System.Drawing.Point(192, 65);
            this.constCounterLabel.Name = "constCounterLabel";
            this.constCounterLabel.Size = new System.Drawing.Size(0, 20);
            this.constCounterLabel.TabIndex = 14;
            this.constCounterLabel.Click += new System.EventHandler(this.constCounterLabel_Click);
            // 
            // intCounterLabel
            // 
            this.intCounterLabel.AutoSize = true;
            this.intCounterLabel.Location = new System.Drawing.Point(192, 99);
            this.intCounterLabel.Name = "intCounterLabel";
            this.intCounterLabel.Size = new System.Drawing.Size(0, 20);
            this.intCounterLabel.TabIndex = 15;
            this.intCounterLabel.Click += new System.EventHandler(this.intCounterLabel_Click);
            // 
            // chaCounterLabel
            // 
            this.chaCounterLabel.AutoSize = true;
            this.chaCounterLabel.Location = new System.Drawing.Point(192, 135);
            this.chaCounterLabel.Name = "chaCounterLabel";
            this.chaCounterLabel.Size = new System.Drawing.Size(0, 20);
            this.chaCounterLabel.TabIndex = 16;
            this.chaCounterLabel.Click += new System.EventHandler(this.chaCounterLabel_Click);
            // 
            // dexCounterLabel
            // 
            this.dexCounterLabel.AutoSize = true;
            this.dexCounterLabel.Location = new System.Drawing.Point(192, 170);
            this.dexCounterLabel.Name = "dexCounterLabel";
            this.dexCounterLabel.Size = new System.Drawing.Size(0, 20);
            this.dexCounterLabel.TabIndex = 17;
            this.dexCounterLabel.Click += new System.EventHandler(this.dexCounterLabel_Click);
            // 
            // viewTab
            // 
            this.viewTab.Controls.Add(this.label1);
            this.viewTab.Controls.Add(this.viewTextbox);
            this.viewTab.Controls.Add(this.button1);
            this.viewTab.Location = new System.Drawing.Point(4, 29);
            this.viewTab.Name = "viewTab";
            this.viewTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewTab.Size = new System.Drawing.Size(654, 295);
            this.viewTab.TabIndex = 4;
            this.viewTab.Text = "View";
            this.viewTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "View any previously made characters here by opening a saved .txt file:";
            // 
            // viewTextbox
            // 
            this.viewTextbox.Location = new System.Drawing.Point(142, 61);
            this.viewTextbox.Multiline = true;
            this.viewTextbox.Name = "viewTextbox";
            this.viewTextbox.ReadOnly = true;
            this.viewTextbox.Size = new System.Drawing.Size(481, 212);
            this.viewTextbox.TabIndex = 12;
            this.viewTextbox.TextChanged += new System.EventHandler(this.viewTextbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvlNumeric
            // 
            this.lvlNumeric.Location = new System.Drawing.Point(644, 30);
            this.lvlNumeric.Name = "lvlNumeric";
            this.lvlNumeric.Size = new System.Drawing.Size(62, 26);
            this.lvlNumeric.TabIndex = 9;
            this.lvlNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lvlNumeric.ValueChanged += new System.EventHandler(this.lvlNumeric_ValueChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(688, 393);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 32);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // classTextbox
            // 
            this.classTextbox.BackColor = System.Drawing.SystemColors.Info;
            this.classTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classTextbox.Location = new System.Drawing.Point(258, 26);
            this.classTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.classTextbox.Multiline = true;
            this.classTextbox.Name = "classTextbox";
            this.classTextbox.ReadOnly = true;
            this.classTextbox.Size = new System.Drawing.Size(368, 244);
            this.classTextbox.TabIndex = 3;
            this.classTextbox.TextChanged += new System.EventHandler(this.classTextbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.lvlNumeric);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.radioOther);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.lvlLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Dungeons & Dragons Character Creator";
            this.tabControl1.ResumeLayout(false);
            this.raceTab.ResumeLayout(false);
            this.raceTab.PerformLayout();
            this.classTab.ResumeLayout(false);
            this.classTab.PerformLayout();
            this.backgroundTab.ResumeLayout(false);
            this.backgroundTab.PerformLayout();
            this.cantripTab.ResumeLayout(false);
            this.cantripTab.PerformLayout();
            this.skillsTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexRange)).EndInit();
            this.viewTab.ResumeLayout(false);
            this.viewTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvlNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label lvlLabel;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioOther;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage raceTab;
        private System.Windows.Forms.TabPage classTab;
        private System.Windows.Forms.ComboBox raceCombobox;
        private System.Windows.Forms.ListBox raceListbox;
        private System.Windows.Forms.NumericUpDown lvlNumeric;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ListBox classListbox;
        private System.Windows.Forms.TabPage backgroundTab;
        private System.Windows.Forms.ListBox backgroundListbox;
        private System.Windows.Forms.CheckedListBox cantripCheckedlistbox;
        private System.Windows.Forms.TabPage cantripTab;
        private System.Windows.Forms.Label cantripLabel;
        private System.Windows.Forms.LinkLabel raceLinkLabel;
        private System.Windows.Forms.TextBox backgroundTextbox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage skillsTab;
        private System.Windows.Forms.TabPage viewTab;
        private System.Windows.Forms.TextBox viewTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label wdmLabel;
        private System.Windows.Forms.Label ctsnLabel;
        private System.Windows.Forms.Label intLabel;
        private System.Windows.Forms.Label chrLabel;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.Button baseSkillsRollBtn;
        private System.Windows.Forms.NumericUpDown strRange;
        private System.Windows.Forms.NumericUpDown wisRange;
        private System.Windows.Forms.NumericUpDown constRange;
        private System.Windows.Forms.NumericUpDown intRange;
        private System.Windows.Forms.NumericUpDown chrRange;
        private System.Windows.Forms.NumericUpDown dexRange;
        private System.Windows.Forms.Label strCounterLabel;
        private System.Windows.Forms.Label wisCounterLabel;
        private System.Windows.Forms.Label constCounterLabel;
        private System.Windows.Forms.Label intCounterLabel;
        private System.Windows.Forms.Label chaCounterLabel;
        private System.Windows.Forms.Label dexCounterLabel;
        private System.Windows.Forms.Label modifierLabel;
        private System.Windows.Forms.Label raceTraitsLabel;
        private System.Windows.Forms.TextBox classTextbox;
    }
}

