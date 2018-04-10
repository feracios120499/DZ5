using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxText.DragEnter += TextBoxText_DragEnter;
            textBoxText.DragDrop += TextBoxText_DragDrop;
            textBoxText.AllowDrop = true;
        }

        private void TextBoxText_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void TextBoxText_DragDrop(object sender, DragEventArgs e)
        {
            string[] items = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach(var item in items)
            {
                if (Path.GetExtension(item) == ".txt")
                {
                    textBoxText.Text = File.ReadAllText(item);
                }
                else
                {
                    textBoxText.LoadFile(item, RichTextBoxStreamType.RichText);
                }
                this.Text = item;
            }
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files(*.txt) | *.txt|RTF Files| *.rtf";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(dialog.FileName) == ".txt")
                {
                    textBoxText.Text = File.ReadAllText(dialog.FileName);
                }
                else
                {
                    textBoxText.LoadFile(dialog.FileName, RichTextBoxStreamType.RichText);
                }

                this.Text = dialog.FileName;
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (Path.GetExtension(this.Text) == "txt")
            {
                Save(true);
            }
            else
            {
                Save(false);
            }

        }
        private void Save(bool flag)
        {
            if (flag)
                File.WriteAllText(this.Text, textBoxText.Text);
            else
                textBoxText.SaveFile(this.Text,RichTextBoxStreamType.RichText);
        }
        private void toolStripButtonNewDoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files(*.txt) | *.txt|RTF Files| *.rtf";
            dialog.FilterIndex = 0;
            dialog.DefaultExt = "txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Text = dialog.FileName;
                textBoxText.Clear();
            }
        }

        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            textBoxText.Copy();
        }

        private void toolStripButtonCut_Click(object sender, EventArgs e)
        {
            textBoxText.Cut();
        }

        private void toolStripButtonPaste_Click(object sender, EventArgs e)
        {
            textBoxText.Paste();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            textBoxText.Undo();
        }

        private void toolStripButtonColorText_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxText.SelectionColor = dialog.Color;
            }
        }

        private void toolStripButtonBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxText.SelectionBackColor = dialog.Color;
            }
        }

        private void toolStripButtonFont_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxText.SelectionFont = dialog.Font;
            }
        }


        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonOpen.PerformClick();
        }

        private void NewDocДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonNewDoc.PerformClick();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonSave.PerformClick();
        }

        private void SaveAsКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files(*.txt) | *.txt|RTF Files| *.rtf";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                this.Text = dialog.FileName;

                toolStripButtonSave.PerformClick();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxText.Copy();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxText.Cut();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxText.Paste();
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxText.Undo();
        }

        private void SelectAllВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxText.SelectAll();
        }

        private void ColorTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonColorText.PerformClick();
        }

        private void BackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonBackColor.PerformClick();
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonFont.PerformClick();
        }

        private void ContextCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonCopy.PerformClick();
        }

        private void ContextCutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonCut.PerformClick();
        }

        private void ContextPastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonPaste.PerformClick();
        }

        private void ContextCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxText.Undo();
        }
    }
}
