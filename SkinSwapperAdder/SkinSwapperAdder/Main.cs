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

        private void checkBoxAppend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAppend.Checked == true)
            {
                labelFileName.Enabled = true;
                textBoxFileName.Enabled = true;
            }
            else
            {
                labelFileName.Enabled = false;
                textBoxFileName.Enabled = false;
                textBoxFileName.Text = "";
            }
        }

        private void buttonCreateAppend_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.ForeColor = Color.Black;

            if (checkBoxAppend.Checked == true)
            {
                if (checkBoxSkinHasFaceAccessories.Checked == false)
                {
                    if (textBoxSkinBody.Text.Length <= 103 && textBoxSkinHead.Text.Length <= 103)
                    {
                        richTextBoxOutput.Text = "  " + textBoxSkinName.Text + "enabled: \"true\",\n  " + textBoxSkinName.Text + "bodyb: \"" + textBoxSkinBody.Text + "\",\n  " + textBoxSkinName.Text + "headb: \"" + textBoxSkinHead.Text + "\",";
                        File.AppendAllText(textBoxFileName.Text + ".txt", richTextBoxOutput.Text = "  " + textBoxSkinName.Text + "enabled: \"true\",\n  " + textBoxSkinName.Text + "bodyb: \"" + textBoxSkinBody.Text + "\",\n  " + textBoxSkinName.Text + "headb: \"" + textBoxSkinHead.Text + "\",\n");
                    }
                    else
                    {
                        MessageBox.Show("Too many characters in one of the fields.");
                    }
                }
                else if (checkBoxSkinHasFaceAccessories.Checked == true)
                {
                    if (textBoxSkinBody.Text.Length <= 103 && textBoxSkinHead.Text.Length <= 103 && textBoxSkinFace.Text.Length <= 103)
                    {
                        richTextBoxOutput.Text = "  " + textBoxSkinName.Text + "enabled: \"true\",\n  " + textBoxSkinName.Text + "bodyb: \"" + textBoxSkinBody.Text + "\",\n  " + textBoxSkinName.Text + "headb: \"" + textBoxSkinHead.Text + "\",\n  " + textBoxSkinName.Text + "faceb: \"" + textBoxSkinFace.Text + "\",";
                        File.AppendAllText(textBoxFileName.Text + ".txt", richTextBoxOutput.Text = "  " + textBoxSkinName.Text + "enabled: \"true\",\n  " + textBoxSkinName.Text + "bodyb: \"" + textBoxSkinBody.Text + "\",\n  " + textBoxSkinName.Text + "headb: \"" + textBoxSkinHead.Text + "\",\n  " + textBoxSkinName.Text + "faceb: \"" + textBoxSkinFace.Text + "\",\n");
                    }
                    else
                    {
                        MessageBox.Show("Too many characters in one of the fields.");
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong.");
                }
            }

            else
            {
                if (checkBoxSkinHasFaceAccessories.Checked == false)
                {
                    if (textBoxSkinBody.Text.Length <= 103 && textBoxSkinHead.Text.Length <= 103)
                    {
                        richTextBoxOutput.Text = "  " + textBoxSkinName.Text + "enabled: \"true\",\n  " + textBoxSkinName.Text + "bodyb: \"" + textBoxSkinBody.Text + "\",\n  " + textBoxSkinName.Text + "headb: \"" + textBoxSkinHead.Text + "\",";
                        File.WriteAllText(textBoxSkinName.Text + ".txt", richTextBoxOutput.Text = "  " + textBoxSkinName.Text + "enabled: \"true\",\n  " + textBoxSkinName.Text + "bodyb: \"" + textBoxSkinBody.Text + "\",\n  " + textBoxSkinName.Text + "headb: \"" + textBoxSkinHead.Text + "\",\n");
                    }
                    else
                    {
                        MessageBox.Show("Too many characters in one of the fields.");
                    }
                }
                else if (checkBoxSkinHasFaceAccessories.Checked == true)
                {
                    if (textBoxSkinBody.Text.Length <= 103 && textBoxSkinHead.Text.Length <= 103 && textBoxSkinFace.Text.Length <= 103)
                    {
                        richTextBoxOutput.Text = "  " + textBoxSkinName.Text + "enabled: \"true\",\n  " + textBoxSkinName.Text + "bodyb: \"" + textBoxSkinBody.Text + "\",\n  " + textBoxSkinName.Text + "headb: \"" + textBoxSkinHead.Text + "\",\n  " + textBoxSkinName.Text + "faceb: \"" + textBoxSkinFace.Text + "\",";
                        File.WriteAllText(textBoxSkinName.Text + ".txt", richTextBoxOutput.Text = "  " + textBoxSkinName.Text + "enabled: \"true\",\n  " + textBoxSkinName.Text + "bodyb: \"" + textBoxSkinBody.Text + "\",\n  " + textBoxSkinName.Text + "headb: \"" + textBoxSkinHead.Text + "\",\n  " + textBoxSkinName.Text + "faceb: \"" + textBoxSkinFace.Text + "\",\n");
                    }
                    else
                    {
                        MessageBox.Show("Too many characters in one of the fields.");
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong.");
                }
            }
        }
    }
}