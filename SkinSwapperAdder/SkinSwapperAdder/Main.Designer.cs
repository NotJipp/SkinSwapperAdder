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
            this.buttonCreate = new System.Windows.Forms.Button();
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
            this.richTextBoxOutput.Location = new System.Drawing.Point(3, 121);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(629, 149);
            this.richTextBoxOutput.TabIndex = 10;
            this.richTextBoxOutput.Text = "Output goes here";
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.buttonCreate);
            this.groupBoxMain.Controls.Add(this.checkBoxSkinHasFaceAccessories);
            this.groupBoxMain.Controls.Add(this.checkBoxTopMost);
            this.groupBoxMain.Location = new System.Drawing.Point(3, 0);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(629, 115);
            this.groupBoxMain.TabIndex = 11;
            this.groupBoxMain.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonCreate.Location = new System.Drawing.Point(473, 64);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(150, 47);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 277);
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
        private System.Windows.Forms.Button buttonCreate;
    }
}

