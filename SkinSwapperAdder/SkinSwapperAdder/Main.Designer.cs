namespace SkinSwapperAdder
{
    partial class Main
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
            this.labelSkinName = new System.Windows.Forms.Label();
            this.textBoxSkinName = new System.Windows.Forms.TextBox();
            this.textBoxSkinBody = new System.Windows.Forms.TextBox();
            this.labelSkinBody = new System.Windows.Forms.Label();
            this.textBoxSkinHead = new System.Windows.Forms.TextBox();
            this.labelSkinHead = new System.Windows.Forms.Label();
            this.textBoxSkinFace = new System.Windows.Forms.TextBox();
            this.labelSkinFace = new System.Windows.Forms.Label();
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.checkBoxSkinHasFaceAccessories = new System.Windows.Forms.CheckBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.labelCharacterCount = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxCharacters = new System.Windows.Forms.TextBox();
            this.labelCharacters = new System.Windows.Forms.Label();
            this.checkBoxAppend = new System.Windows.Forms.CheckBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonCreateAppend = new System.Windows.Forms.Button();
            this.groupBoxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSkinName
            // 
            this.labelSkinName.AutoSize = true;
            this.labelSkinName.Location = new System.Drawing.Point(6, 15);
            this.labelSkinName.Name = "labelSkinName";
            this.labelSkinName.Size = new System.Drawing.Size(62, 13);
            this.labelSkinName.TabIndex = 0;
            this.labelSkinName.Text = "Skin Name:";
            // 
            // textBoxSkinName
            // 
            this.textBoxSkinName.Location = new System.Drawing.Point(69, 12);
            this.textBoxSkinName.Name = "textBoxSkinName";
            this.textBoxSkinName.Size = new System.Drawing.Size(401, 20);
            this.textBoxSkinName.TabIndex = 1;
            // 
            // textBoxSkinBody
            // 
            this.textBoxSkinBody.Location = new System.Drawing.Point(69, 38);
            this.textBoxSkinBody.Name = "textBoxSkinBody";
            this.textBoxSkinBody.Size = new System.Drawing.Size(401, 20);
            this.textBoxSkinBody.TabIndex = 3;
            // 
            // labelSkinBody
            // 
            this.labelSkinBody.AutoSize = true;
            this.labelSkinBody.Location = new System.Drawing.Point(6, 41);
            this.labelSkinBody.Name = "labelSkinBody";
            this.labelSkinBody.Size = new System.Drawing.Size(58, 13);
            this.labelSkinBody.TabIndex = 2;
            this.labelSkinBody.Text = "Skin Body:";
            // 
            // textBoxSkinHead
            // 
            this.textBoxSkinHead.Location = new System.Drawing.Point(69, 64);
            this.textBoxSkinHead.Name = "textBoxSkinHead";
            this.textBoxSkinHead.Size = new System.Drawing.Size(401, 20);
            this.textBoxSkinHead.TabIndex = 5;
            // 
            // labelSkinHead
            // 
            this.labelSkinHead.AutoSize = true;
            this.labelSkinHead.Location = new System.Drawing.Point(6, 67);
            this.labelSkinHead.Name = "labelSkinHead";
            this.labelSkinHead.Size = new System.Drawing.Size(60, 13);
            this.labelSkinHead.TabIndex = 4;
            this.labelSkinHead.Text = "Skin Head:";
            // 
            // textBoxSkinFace
            // 
            this.textBoxSkinFace.Enabled = false;
            this.textBoxSkinFace.Location = new System.Drawing.Point(69, 90);
            this.textBoxSkinFace.Name = "textBoxSkinFace";
            this.textBoxSkinFace.Size = new System.Drawing.Size(401, 20);
            this.textBoxSkinFace.TabIndex = 7;
            // 
            // labelSkinFace
            // 
            this.labelSkinFace.AutoSize = true;
            this.labelSkinFace.Enabled = false;
            this.labelSkinFace.Location = new System.Drawing.Point(6, 93);
            this.labelSkinFace.Name = "labelSkinFace";
            this.labelSkinFace.Size = new System.Drawing.Size(58, 13);
            this.labelSkinFace.TabIndex = 6;
            this.labelSkinFace.Text = "Skin Face:";
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.Location = new System.Drawing.Point(473, 14);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(96, 17);
            this.checkBoxTopMost.TabIndex = 8;
            this.checkBoxTopMost.Text = "Always on Top";
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMost_CheckedChanged);
            // 
            // checkBoxSkinHasFaceAccessories
            // 
            this.checkBoxSkinHasFaceAccessories.AutoSize = true;
            this.checkBoxSkinHasFaceAccessories.Location = new System.Drawing.Point(473, 36);
            this.checkBoxSkinHasFaceAccessories.Name = "checkBoxSkinHasFaceAccessories";
            this.checkBoxSkinHasFaceAccessories.Size = new System.Drawing.Size(154, 17);
            this.checkBoxSkinHasFaceAccessories.TabIndex = 9;
            this.checkBoxSkinHasFaceAccessories.Text = "Skin has Face Accessories";
            this.checkBoxSkinHasFaceAccessories.UseVisualStyleBackColor = true;
            this.checkBoxSkinHasFaceAccessories.CheckedChanged += new System.EventHandler(this.checkBoxSkinHasFaceAccessories_CheckedChanged);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxOutput.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBoxOutput.Location = new System.Drawing.Point(1, 177);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(658, 149);
            this.richTextBoxOutput.TabIndex = 10;
            this.richTextBoxOutput.Text = "Output goes here";
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.labelCharacterCount);
            this.groupBoxMain.Controls.Add(this.labelCount);
            this.groupBoxMain.Controls.Add(this.textBoxCharacters);
            this.groupBoxMain.Controls.Add(this.labelCharacters);
            this.groupBoxMain.Controls.Add(this.checkBoxAppend);
            this.groupBoxMain.Controls.Add(this.textBoxFileName);
            this.groupBoxMain.Controls.Add(this.labelFileName);
            this.groupBoxMain.Controls.Add(this.buttonCreateAppend);
            this.groupBoxMain.Controls.Add(this.checkBoxSkinHasFaceAccessories);
            this.groupBoxMain.Controls.Add(this.checkBoxTopMost);
            this.groupBoxMain.Location = new System.Drawing.Point(3, 0);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(656, 171);
            this.groupBoxMain.TabIndex = 11;
            this.groupBoxMain.TabStop = false;
            // 
            // labelCharacterCount
            // 
            this.labelCharacterCount.AutoSize = true;
            this.labelCharacterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCharacterCount.Location = new System.Drawing.Point(473, 145);
            this.labelCharacterCount.Name = "labelCharacterCount";
            this.labelCharacterCount.Size = new System.Drawing.Size(113, 17);
            this.labelCharacterCount.TabIndex = 17;
            this.labelCharacterCount.Text = "Character count:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelCount.ForeColor = System.Drawing.Color.Green;
            this.labelCount.Location = new System.Drawing.Point(583, 146);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(17, 17);
            this.labelCount.TabIndex = 12;
            this.labelCount.Text = "0";
            // 
            // textBoxCharacters
            // 
            this.textBoxCharacters.Location = new System.Drawing.Point(66, 142);
            this.textBoxCharacters.Name = "textBoxCharacters";
            this.textBoxCharacters.Size = new System.Drawing.Size(401, 20);
            this.textBoxCharacters.TabIndex = 16;
            this.textBoxCharacters.TextChanged += new System.EventHandler(this.textBoxCharacters_TextChanged);
            // 
            // labelCharacters
            // 
            this.labelCharacters.AutoSize = true;
            this.labelCharacters.Location = new System.Drawing.Point(3, 145);
            this.labelCharacters.Name = "labelCharacters";
            this.labelCharacters.Size = new System.Drawing.Size(61, 13);
            this.labelCharacters.TabIndex = 15;
            this.labelCharacters.Text = "Characters:";
            // 
            // checkBoxAppend
            // 
            this.checkBoxAppend.AutoSize = true;
            this.checkBoxAppend.Location = new System.Drawing.Point(473, 59);
            this.checkBoxAppend.Name = "checkBoxAppend";
            this.checkBoxAppend.Size = new System.Drawing.Size(181, 17);
            this.checkBoxAppend.TabIndex = 14;
            this.checkBoxAppend.Text = "Append to an already existing file";
            this.checkBoxAppend.UseVisualStyleBackColor = true;
            this.checkBoxAppend.CheckedChanged += new System.EventHandler(this.checkBoxAppend_CheckedChanged);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Enabled = false;
            this.textBoxFileName.Location = new System.Drawing.Point(66, 116);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(401, 20);
            this.textBoxFileName.TabIndex = 13;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Enabled = false;
            this.labelFileName.Location = new System.Drawing.Point(3, 119);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(57, 13);
            this.labelFileName.TabIndex = 12;
            this.labelFileName.Text = "File Name:";
            // 
            // buttonCreateAppend
            // 
            this.buttonCreateAppend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonCreateAppend.Location = new System.Drawing.Point(473, 90);
            this.buttonCreateAppend.Name = "buttonCreateAppend";
            this.buttonCreateAppend.Size = new System.Drawing.Size(175, 46);
            this.buttonCreateAppend.TabIndex = 0;
            this.buttonCreateAppend.Text = "Create / Append";
            this.buttonCreateAppend.UseVisualStyleBackColor = true;
            this.buttonCreateAppend.Click += new System.EventHandler(this.buttonCreateAppend_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 331);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.textBoxSkinFace);
            this.Controls.Add(this.labelSkinFace);
            this.Controls.Add(this.textBoxSkinHead);
            this.Controls.Add(this.labelSkinHead);
            this.Controls.Add(this.textBoxSkinBody);
            this.Controls.Add(this.labelSkinBody);
            this.Controls.Add(this.textBoxSkinName);
            this.Controls.Add(this.labelSkinName);
            this.Controls.Add(this.groupBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skin Swapper Adder - Made by Jipp#2516";
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSkinName;
        private System.Windows.Forms.TextBox textBoxSkinName;
        private System.Windows.Forms.TextBox textBoxSkinBody;
        private System.Windows.Forms.Label labelSkinBody;
        private System.Windows.Forms.TextBox textBoxSkinHead;
        private System.Windows.Forms.Label labelSkinHead;
        private System.Windows.Forms.TextBox textBoxSkinFace;
        private System.Windows.Forms.Label labelSkinFace;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
        private System.Windows.Forms.CheckBox checkBoxSkinHasFaceAccessories;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.Button buttonCreateAppend;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.CheckBox checkBoxAppend;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox textBoxCharacters;
        private System.Windows.Forms.Label labelCharacters;
        private System.Windows.Forms.Label labelCharacterCount;
    }
}

