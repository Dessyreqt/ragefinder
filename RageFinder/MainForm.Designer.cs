namespace RageFinder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.formNum7 = new System.Windows.Forms.CheckBox();
            this.formNum6 = new System.Windows.Forms.CheckBox();
            this.formNum5 = new System.Windows.Forms.CheckBox();
            this.formNum4 = new System.Windows.Forms.CheckBox();
            this.formNum3 = new System.Windows.Forms.CheckBox();
            this.formNum2 = new System.Windows.Forms.CheckBox();
            this.formNum1 = new System.Windows.Forms.CheckBox();
            this.formNum0 = new System.Windows.Forms.CheckBox();
            this.groupNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.historyList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.historyGroup = new System.Windows.Forms.NumericUpDown();
            this.historyFormation = new System.Windows.Forms.ComboBox();
            this.historyAdd = new System.Windows.Forms.Button();
            this.historyClear = new System.Windows.Forms.LinkLabel();
            this.nextFormationsList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lblStartSeed1 = new System.Windows.Forms.Label();
            this.lblStartSeed2 = new System.Windows.Forms.Label();
            this.lblMatches = new System.Windows.Forms.Label();
            this.addTopGroup = new System.Windows.Forms.Button();
            this.enemiesList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFindMethod = new System.Windows.Forms.Label();
            this.lblPossibleGroups = new System.Windows.Forms.Label();
            this.lastClear = new System.Windows.Forms.LinkLabel();
            this.resetting = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.formNum7);
            this.groupBox1.Controls.Add(this.formNum6);
            this.groupBox1.Controls.Add(this.formNum5);
            this.groupBox1.Controls.Add(this.formNum4);
            this.groupBox1.Controls.Add(this.formNum3);
            this.groupBox1.Controls.Add(this.formNum2);
            this.groupBox1.Controls.Add(this.formNum1);
            this.groupBox1.Controls.Add(this.formNum0);
            this.groupBox1.Controls.Add(this.groupNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formations On Veldt";
            // 
            // formNum7
            // 
            this.formNum7.AutoSize = true;
            this.formNum7.Location = new System.Drawing.Point(6, 244);
            this.formNum7.Name = "formNum7";
            this.formNum7.Size = new System.Drawing.Size(55, 17);
            this.formNum7.TabIndex = 9;
            this.formNum7.Text = "Empty";
            this.formNum7.UseVisualStyleBackColor = true;
            this.formNum7.CheckedChanged += new System.EventHandler(this.formNum7_CheckedChanged);
            // 
            // formNum6
            // 
            this.formNum6.AutoSize = true;
            this.formNum6.Location = new System.Drawing.Point(6, 221);
            this.formNum6.Name = "formNum6";
            this.formNum6.Size = new System.Drawing.Size(55, 17);
            this.formNum6.TabIndex = 8;
            this.formNum6.Text = "Empty";
            this.formNum6.UseVisualStyleBackColor = true;
            this.formNum6.CheckedChanged += new System.EventHandler(this.formNum6_CheckedChanged);
            // 
            // formNum5
            // 
            this.formNum5.AutoSize = true;
            this.formNum5.Location = new System.Drawing.Point(6, 198);
            this.formNum5.Name = "formNum5";
            this.formNum5.Size = new System.Drawing.Size(55, 17);
            this.formNum5.TabIndex = 7;
            this.formNum5.Text = "Empty";
            this.formNum5.UseVisualStyleBackColor = true;
            this.formNum5.CheckedChanged += new System.EventHandler(this.formNum5_CheckedChanged);
            // 
            // formNum4
            // 
            this.formNum4.AutoSize = true;
            this.formNum4.Location = new System.Drawing.Point(6, 175);
            this.formNum4.Name = "formNum4";
            this.formNum4.Size = new System.Drawing.Size(55, 17);
            this.formNum4.TabIndex = 6;
            this.formNum4.Text = "Empty";
            this.formNum4.UseVisualStyleBackColor = true;
            this.formNum4.CheckedChanged += new System.EventHandler(this.formNum4_CheckedChanged);
            // 
            // formNum3
            // 
            this.formNum3.AutoSize = true;
            this.formNum3.Location = new System.Drawing.Point(6, 152);
            this.formNum3.Name = "formNum3";
            this.formNum3.Size = new System.Drawing.Size(55, 17);
            this.formNum3.TabIndex = 5;
            this.formNum3.Text = "Empty";
            this.formNum3.UseVisualStyleBackColor = true;
            this.formNum3.CheckedChanged += new System.EventHandler(this.formNum3_CheckedChanged);
            // 
            // formNum2
            // 
            this.formNum2.AutoSize = true;
            this.formNum2.Location = new System.Drawing.Point(6, 129);
            this.formNum2.Name = "formNum2";
            this.formNum2.Size = new System.Drawing.Size(55, 17);
            this.formNum2.TabIndex = 4;
            this.formNum2.Text = "Empty";
            this.formNum2.UseVisualStyleBackColor = true;
            this.formNum2.CheckedChanged += new System.EventHandler(this.formNum2_CheckedChanged);
            // 
            // formNum1
            // 
            this.formNum1.AutoSize = true;
            this.formNum1.Location = new System.Drawing.Point(6, 106);
            this.formNum1.Name = "formNum1";
            this.formNum1.Size = new System.Drawing.Size(55, 17);
            this.formNum1.TabIndex = 3;
            this.formNum1.Text = "Empty";
            this.formNum1.UseVisualStyleBackColor = true;
            this.formNum1.CheckedChanged += new System.EventHandler(this.formNum1_CheckedChanged);
            // 
            // formNum0
            // 
            this.formNum0.AutoSize = true;
            this.formNum0.Location = new System.Drawing.Point(6, 83);
            this.formNum0.Name = "formNum0";
            this.formNum0.Size = new System.Drawing.Size(55, 17);
            this.formNum0.TabIndex = 2;
            this.formNum0.Text = "Empty";
            this.formNum0.UseVisualStyleBackColor = true;
            this.formNum0.CheckedChanged += new System.EventHandler(this.formNum0_CheckedChanged);
            // 
            // groupNum
            // 
            this.groupNum.Location = new System.Drawing.Point(6, 32);
            this.groupNum.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.groupNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.groupNum.Name = "groupNum";
            this.groupNum.Size = new System.Drawing.Size(55, 20);
            this.groupNum.TabIndex = 1;
            this.groupNum.ValueChanged += new System.EventHandler(this.groupNum_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group";
            // 
            // historyList
            // 
            this.historyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.historyList.Location = new System.Drawing.Point(315, 38);
            this.historyList.Name = "historyList";
            this.historyList.Size = new System.Drawing.Size(362, 221);
            this.historyList.TabIndex = 1;
            this.historyList.UseCompatibleStateImageBehavior = false;
            this.historyList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Group";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Formation";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 238;
            // 
            // historyGroup
            // 
            this.historyGroup.Location = new System.Drawing.Point(315, 12);
            this.historyGroup.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.historyGroup.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.historyGroup.Name = "historyGroup";
            this.historyGroup.Size = new System.Drawing.Size(53, 20);
            this.historyGroup.TabIndex = 2;
            this.historyGroup.ValueChanged += new System.EventHandler(this.historyGroup_ValueChanged);
            // 
            // historyFormation
            // 
            this.historyFormation.FormattingEnabled = true;
            this.historyFormation.Location = new System.Drawing.Point(375, 12);
            this.historyFormation.Name = "historyFormation";
            this.historyFormation.Size = new System.Drawing.Size(244, 21);
            this.historyFormation.TabIndex = 3;
            // 
            // historyAdd
            // 
            this.historyAdd.Location = new System.Drawing.Point(625, 12);
            this.historyAdd.Name = "historyAdd";
            this.historyAdd.Size = new System.Drawing.Size(52, 23);
            this.historyAdd.TabIndex = 4;
            this.historyAdd.Text = "Add";
            this.historyAdd.UseVisualStyleBackColor = true;
            this.historyAdd.Click += new System.EventHandler(this.historyAdd_Click);
            // 
            // historyClear
            // 
            this.historyClear.AutoSize = true;
            this.historyClear.BackColor = System.Drawing.Color.Transparent;
            this.historyClear.Location = new System.Drawing.Point(611, 262);
            this.historyClear.Name = "historyClear";
            this.historyClear.Size = new System.Drawing.Size(66, 13);
            this.historyClear.TabIndex = 5;
            this.historyClear.TabStop = true;
            this.historyClear.Text = "Clear History";
            this.historyClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.historyClear_LinkClicked);
            // 
            // nextFormationsList
            // 
            this.nextFormationsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.nextFormationsList.Location = new System.Drawing.Point(683, 38);
            this.nextFormationsList.Name = "nextFormationsList";
            this.nextFormationsList.Size = new System.Drawing.Size(307, 221);
            this.nextFormationsList.TabIndex = 6;
            this.nextFormationsList.UseCompatibleStateImageBehavior = false;
            this.nextFormationsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Group";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Formation";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Description";
            this.columnHeader6.Width = 183;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(683, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Next Groups";
            // 
            // lblStartSeed1
            // 
            this.lblStartSeed1.AutoSize = true;
            this.lblStartSeed1.BackColor = System.Drawing.Color.Transparent;
            this.lblStartSeed1.Location = new System.Drawing.Point(683, 262);
            this.lblStartSeed1.Name = "lblStartSeed1";
            this.lblStartSeed1.Size = new System.Drawing.Size(66, 13);
            this.lblStartSeed1.TabIndex = 8;
            this.lblStartSeed1.Text = "Start Seed1:";
            // 
            // lblStartSeed2
            // 
            this.lblStartSeed2.AutoSize = true;
            this.lblStartSeed2.BackColor = System.Drawing.Color.Transparent;
            this.lblStartSeed2.Location = new System.Drawing.Point(794, 262);
            this.lblStartSeed2.Name = "lblStartSeed2";
            this.lblStartSeed2.Size = new System.Drawing.Size(66, 13);
            this.lblStartSeed2.TabIndex = 9;
            this.lblStartSeed2.Text = "Start Seed2:";
            // 
            // lblMatches
            // 
            this.lblMatches.AutoSize = true;
            this.lblMatches.BackColor = System.Drawing.Color.Transparent;
            this.lblMatches.Location = new System.Drawing.Point(911, 262);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(51, 13);
            this.lblMatches.TabIndex = 10;
            this.lblMatches.Text = "Matches:";
            // 
            // addTopGroup
            // 
            this.addTopGroup.Location = new System.Drawing.Point(887, 10);
            this.addTopGroup.Name = "addTopGroup";
            this.addTopGroup.Size = new System.Drawing.Size(102, 23);
            this.addTopGroup.TabIndex = 11;
            this.addTopGroup.Text = "Add Top Group";
            this.addTopGroup.UseVisualStyleBackColor = true;
            this.addTopGroup.Click += new System.EventHandler(this.addTopGroup_Click);
            // 
            // enemiesList
            // 
            this.enemiesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemiesList.FormattingEnabled = true;
            this.enemiesList.Location = new System.Drawing.Point(315, 278);
            this.enemiesList.Name = "enemiesList";
            this.enemiesList.Size = new System.Drawing.Size(244, 21);
            this.enemiesList.TabIndex = 12;
            this.enemiesList.SelectedIndexChanged += new System.EventHandler(this.enemiesList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(312, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search for Rage";
            // 
            // lblFindMethod
            // 
            this.lblFindMethod.AutoSize = true;
            this.lblFindMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblFindMethod.Location = new System.Drawing.Point(315, 306);
            this.lblFindMethod.Name = "lblFindMethod";
            this.lblFindMethod.Size = new System.Drawing.Size(0, 13);
            this.lblFindMethod.TabIndex = 14;
            // 
            // lblPossibleGroups
            // 
            this.lblPossibleGroups.AutoSize = true;
            this.lblPossibleGroups.BackColor = System.Drawing.Color.Transparent;
            this.lblPossibleGroups.Location = new System.Drawing.Point(566, 285);
            this.lblPossibleGroups.Name = "lblPossibleGroups";
            this.lblPossibleGroups.Size = new System.Drawing.Size(84, 13);
            this.lblPossibleGroups.TabIndex = 15;
            this.lblPossibleGroups.Text = "Possible groups:";
            // 
            // lastClear
            // 
            this.lastClear.AutoSize = true;
            this.lastClear.BackColor = System.Drawing.Color.Transparent;
            this.lastClear.Location = new System.Drawing.Point(499, 262);
            this.lastClear.Name = "lastClear";
            this.lastClear.Size = new System.Drawing.Size(106, 13);
            this.lastClear.TabIndex = 16;
            this.lastClear.TabStop = true;
            this.lastClear.Text = "Clear Last Encounter";
            this.lastClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lastClear_LinkClicked);
            // 
            // resetting
            // 
            this.resetting.AutoSize = true;
            this.resetting.BackColor = System.Drawing.Color.Transparent;
            this.resetting.Location = new System.Drawing.Point(12, 285);
            this.resetting.Name = "resetting";
            this.resetting.Size = new System.Drawing.Size(148, 17);
            this.resetting.TabIndex = 17;
            this.resetting.Text = "Resetting after each entry";
            this.resetting.UseVisualStyleBackColor = false;
            this.resetting.CheckedChanged += new System.EventHandler(this.resetting_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(13, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 56);
            this.button1.TabIndex = 19;
            this.button1.Text = "Instructions";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resetting);
            this.Controls.Add(this.lastClear);
            this.Controls.Add(this.lblPossibleGroups);
            this.Controls.Add(this.lblFindMethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enemiesList);
            this.Controls.Add(this.addTopGroup);
            this.Controls.Add(this.lblMatches);
            this.Controls.Add(this.lblStartSeed2);
            this.Controls.Add(this.lblStartSeed1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nextFormationsList);
            this.Controls.Add(this.historyClear);
            this.Controls.Add(this.historyAdd);
            this.Controls.Add(this.historyFormation);
            this.Controls.Add(this.historyGroup);
            this.Controls.Add(this.historyList);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "RageFinder v0.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox formNum7;
        private System.Windows.Forms.CheckBox formNum6;
        private System.Windows.Forms.CheckBox formNum5;
        private System.Windows.Forms.CheckBox formNum4;
        private System.Windows.Forms.CheckBox formNum3;
        private System.Windows.Forms.CheckBox formNum2;
        private System.Windows.Forms.CheckBox formNum1;
        private System.Windows.Forms.CheckBox formNum0;
        private System.Windows.Forms.NumericUpDown groupNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView historyList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NumericUpDown historyGroup;
        private System.Windows.Forms.ComboBox historyFormation;
        private System.Windows.Forms.Button historyAdd;
        private System.Windows.Forms.LinkLabel historyClear;
        private System.Windows.Forms.ListView nextFormationsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblStartSeed1;
        private System.Windows.Forms.Label lblStartSeed2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblMatches;
        private System.Windows.Forms.Button addTopGroup;
        private System.Windows.Forms.ComboBox enemiesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFindMethod;
        private System.Windows.Forms.Label lblPossibleGroups;
        private System.Windows.Forms.LinkLabel lastClear;
        private System.Windows.Forms.CheckBox resetting;
        private System.Windows.Forms.Button button1;
    }
}

