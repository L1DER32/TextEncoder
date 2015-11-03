using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace TextEncoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".txt File|*.txt";
            dialog.Title = "Select text file";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                InputBox.Text = String.Empty; //reset
                try
                {
                    InputBox.Text = File.ReadAllText(dialog.FileName, Encoding.Default);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error occured");
                }
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox tBase = FindFocusedTextBox();
            if (tBase != null)
            {
                // Ensure that text is currently selected in the text box.   
                if (tBase.SelectedText != "")
                    // Cut the selected text in the control and paste it into the Clipboard.
                    tBase.Cut();
            }

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox tBase = FindFocusedTextBox();
            if (tBase != null)
            {
                //// Ensure that text is selected in the text box.   
                if (tBase.SelectionLength > 0)
                    // Copy the selected text to the Clipboard.
                    tBase.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox tBase = FindFocusedTextBox();
            if (tBase != null)
            {
                // Determine if there is any text in the Clipboard to paste into the text box.
                if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
                {
                    // Paste current text in Clipboard into text box.
                    tBase.Paste();
                }
            }
        }

        public RichTextBox FindFocusedTextBox()
        {
            //adding all rtxtBoxes on the form to the list
            List<RichTextBox> txtBoxList = new List<RichTextBox>();
            txtBoxList.Add(InputBox);

            //page1 -- TitleStmt and PubStmt
            txtBoxList.Add(textBoxAuthor);
            txtBoxList.Add(textBoxDate);
            txtBoxList.Add(textBoxPublisher);
            txtBoxList.Add(textBoxPublisherPlace);
            txtBoxList.Add(textBoxTitle);
            txtBoxList.Add(textBoxDistr);
            txtBoxList.Add(textBoxAddress);

            //page2 -- sourceDesc and options
            txtBoxList.Add(textBoxBiblCitation);
            txtBoxList.Add(textBoxTitleSrc);
            txtBoxList.Add(textBoxAuthorSrc);
            txtBoxList.Add(textBoxEditionSrc);
            txtBoxList.Add(textBoxAnalytic);
            txtBoxList.Add(textBoxDateSrc);

            foreach (var box in txtBoxList)
            {
                if (box.Focused) return box;
            }
            return null;
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            bool resultOK = true;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = ".xml File|*.xml";
            dialog.Title = "Save XML file";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //packing all text description info into one class
                HeaderInformation info = new HeaderInformation
                {
                    //page1 -- TitleStmt and PubStmt
                    Author = textBoxAuthor.Text,
                    Title = textBoxTitle.Text,
                    Publisher = textBoxPublisher.Text,
                    PublishDate = textBoxDate.Text,
                    PublishAddress = textBoxAddress.Text,
                    Distributor = textBoxDistr.Text,
                    PublisherPlace = textBoxPublisherPlace.Text,

                    //page2 -- sourceDesc
                    BiblCitation = textBoxBiblCitation.Text,
                    TitleSrc = textBoxTitleSrc.Text,
                    AuthorSrc = textBoxAuthorSrc.Text,
                    EditionSrc = textBoxEditionSrc.Text,
                    Analytic = textBoxAnalytic.Text,
                    DateSrc = textBoxDateSrc.Text
                };

                try
                {
                    List<string[]> paragraphs = SimpleTextSplitter.SplitToParagraphsWithSentences(InputBox.Text);

                    XmlEncoder.EncodeTextFile(dialog.FileName, info, paragraphs, checkBoxPunc.Checked);
                }
                catch (Exception ex)
                {
                    resultOK = false;
                    MessageBox.Show(ex.ToString(), "Error");

                }
                finally
                {
                    if (resultOK && checkBoxOpen.Checked) System.Diagnostics.Process.Start(dialog.FileName);
                }

            }//end if
        }

        private void TxtBox_MouseUp(object sender, MouseEventArgs e)
        {
            RichTextBox temp = sender as RichTextBox;
            temp.Focus();
        }

        private void btn_CopyDate_Click(object sender, EventArgs e)
        {
            textBoxDateSrc.Text = textBoxDate.Text;
        }

    }
}
