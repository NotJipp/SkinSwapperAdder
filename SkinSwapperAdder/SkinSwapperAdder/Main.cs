using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SkinSwapperAdder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void checkBoxTopMost_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTopMost.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void checkBoxSkinHasFaceAccessories_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSkinHasFaceAccessories.Checked == true)
            {
                labelSkinFace.Enabled = true;
                textBoxSkinFace.Enabled = true;
            }
            else
            {
                labelSkinFace.Enabled = false;
                textBoxSkinFace.Enabled = false;
                textBoxSkinFace.Text = "";
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.ForeColor = Color.Black;

            if (checkBoxSkinHasFaceAccessories.Checked == false)
            {
                if (textBoxSkinBody.Text.Length <= 103 || textBoxSkinHead.Text.Length <= 103)
                {
                    richTextBoxOutput.Text = "  " + textBoxSkinName.Text + "enabled: \"true\",\n  " + textBoxSkinName.Text + "bodyb: \"" + textBoxSkinBody.Text + "\",\n  " + textBoxSkinName.Text + "headb: \"" + textBoxSkinHead.Text + "\",";
                    File.WriteAllText(textBoxSkinName.Text + ".txt", richTextBoxOutput.Text = "  " + textBoxSkinName.Text + "enabled: \"true\",\n  " + textBoxSkinName.Text + "bodyb: \"" + textBoxSkinBody.Text + "\",\n  " + textBoxSkinName.Text + "headb: \"" + textBoxSkinHead.Text + "\",");
                }
                else
                {
                    MessageBox.Show("Too many characters in one of the fields.");
                }
            }
            else
            {
                if (textBoxSkinBody.Text.Length <= 103 || textBoxSkinHead.Text.Length <= 103 || textBoxSkinFace.Text.Length <= 103)
                {
                    richTextBoxOutput.Text = "  " + textBoxSkinName.Text + "enabled: \"true\",\n  " + textBoxSkinName.Text + "bodyb: \"" + textBoxSkinBody.Text + "\",\n  " + textBoxSkinName.Text + "headb: \"" + textBoxSkinHead.Text + "\",\n  " + textBoxSkinName.Text + "faceb: \"" + textBoxSkinFace.Text + "\",";
                    File.WriteAllText(textBoxSkinName.Text + ".txt", richTextBoxOutput.Text = "  " + textBoxSkinName.Text + "enabled: \"true\",\n  " + textBoxSkinName.Text + "bodyb: \"" + textBoxSkinBody.Text + "\",\n  " + textBoxSkinName.Text + "headb: \"" + textBoxSkinHead.Text + "\",\n  " + textBoxSkinName.Text + "faceb: \"" + textBoxSkinFace.Text + "\",");
                }
                else
                {
                    MessageBox.Show("Too many characters in one of the fields.");
                }
            }
        }
    }
}
