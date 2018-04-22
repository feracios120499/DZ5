using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        RichTextBox textBoxText;
        Color textColor = Color.Black;
        public class MyPage
        {
            public Page Page { get; set; }
            public RichTextBox TextBox { get; set; }
            public MyPage(Page page, RichTextBox textBox)
            {
                this.Page = page;
                this.TextBox = textBox;
                
            }
        }
        public void ClickPage(object sender, EventArgs e)
        {
            foreach (var item in listPages)
            {
                if (item.Page == sender)
                {
                    item.TextBox.BringToFront();
                    textBoxText = item.TextBox;
                    this.Text = item.Page.GetName();
                }
            }
        }
        public void DeletePage(object sender, EventArgs e)
        {
            MyPage page = null;
            foreach (var item in listPages)
            {
                if (item.Page == sender)
                {
                    item.Page.Parent.Controls.Remove(item.Page);
                    item.TextBox.Parent.Controls.Remove(item.TextBox);
                    page = item;
                }
            }
            listPages.Remove(page);
            if (listPages.Count != 0)
                listPages.Last().Page.SetActiv();

        }
        public void CreatePage(Page page)
        {
            panelPages.Controls.Add(page);
            page.Dock = DockStyle.Left;
            page.BringToFront();
            page.eventActiv += ClickPage;
            RichTextBox textBox = new RichTextBox();
            panelTextBoxs.Controls.Add(textBox);
            textBox.Dock = DockStyle.Fill;
            textBox.TextChanged += textBoxText_TextChanged;
            textBox.MouseClick += textBoxText_MouseClick;
            textBox.PreviewKeyDown += textBoxText_PreviewKeyDown;
            listPages.Add(new MyPage(page, textBox));
            page.eventDelete += DeletePage;
            page.SetActiv();
            if (BlackToolStripMenuItem.Checked)
                BlackTextBox(listPages.Last());
        }
        List<MyPage> listPages = new List<MyPage>();
        public Form1()
        {
            InitializeComponent();
            //textBoxText.DragEnter += TextBoxText_DragEnter;
            //textBoxText.DragDrop += TextBoxText_DragDrop;
            //textBoxText.AllowDrop = true;
        }

        private void TextBoxText_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void TextBoxText_DragDrop(object sender, DragEventArgs e)
        {
            string[] items = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (var item in items)
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
            dialog.Filter = "Text files(*.txt) | *.txt|RTF Files| *.rtf|C#(*.cs)| *.cs";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Page page = new Page(Path.GetFileName(dialog.FileName));
                CreatePage(page);
                if (Path.GetExtension(dialog.FileName) == ".txt" || Path.GetExtension(dialog.FileName) == ".cs")
                {
                    textBoxText.Text = File.ReadAllText(dialog.FileName);
                    if (Path.GetExtension(dialog.FileName) == ".cs" && !SyntToolStripMenuItem.Checked)
                    {

                        SyntToolStripMenuItem.PerformClick();
                    }
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
            if (listPages.Count == 0)
                return;

            if (Path.GetExtension(this.Text) == ".txt" || Path.GetExtension(this.Text) == ".cs")
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
                textBoxText.SaveFile(this.Text, RichTextBoxStreamType.RichText);
        }
        private void toolStripButtonNewDoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files(*.txt) | *.txt|RTF Files| *.rtf|C#(*.cs) | *.cs";
            dialog.FilterIndex = 0;
            dialog.DefaultExt = "txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Page page = new Page(Path.GetFileName(dialog.FileName));
                CreatePage(page);
                this.Text = dialog.FileName;
                if (Path.GetExtension(Text) == ".cs" && !SyntToolStripMenuItem.Checked)
                    SyntToolStripMenuItem.PerformClick();

                textBoxText.Clear();
            }
        }

        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            if(listPages.Count!=0)
                textBoxText.Copy();
        }

        private void toolStripButtonCut_Click(object sender, EventArgs e)
        {
            if(listPages.Count!=0)
                textBoxText.Cut();
        }

        private void toolStripButtonPaste_Click(object sender, EventArgs e)
        {
            if (listPages.Count != 0)
                textBoxText.Paste();
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            if (listPages.Count != 0)
            {
                textBoxText.TextChanged -= textBoxText_TextChanged;
                if(SyntToolStripMenuItem.Checked)
                    textBoxText.Undo();
                textBoxText.Undo();
                textBoxText.TextChanged += textBoxText_TextChanged;
                //textBoxText.Text += "";
            }
            
        }

        private void toolStripButtonColorText_Click(object sender, EventArgs e)
        {
            if (listPages.Count == 0)
                return;
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxText.SelectionColor = dialog.Color;
            }
        }

        private void toolStripButtonBackColor_Click(object sender, EventArgs e)
        {
            if (listPages.Count == 0)
                return;
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxText.SelectionBackColor = dialog.Color;
            }
        }

        private void toolStripButtonFont_Click(object sender, EventArgs e)
        {
            if (listPages.Count == 0)
                return;
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
            if (listPages.Count == 0)
                return;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files(*.txt) | *.txt|RTF Files| *.rtf|C#(*.cs) | *.cs";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                this.Text = dialog.FileName;

                toolStripButtonSave.PerformClick();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listPages.Count == 0)
                return;
            textBoxText.Copy();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listPages.Count == 0)
                return;
            textBoxText.Cut();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listPages.Count == 0)
                return;
            textBoxText.Paste();
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listPages.Count == 0)
                return;
            textBoxText.Undo();
        }

        private void SelectAllВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listPages.Count == 0)
                return;
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
            if (listPages.Count == 0)
                return;
            textBoxText.Undo();
        }


        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            var textBox = (sender as RichTextBox);
            SyntaxHighlighting.RePaint(ref textBox, textColor);
            
        }

        private void найстрокаТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxText_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            RefreshPosition();
            if (e.Control && e.KeyCode == Keys.F)
            {
                new FindAndReplace(this).Show();
            }

        }
        private void RefreshPosition()
        {
            int i = textBoxText.SelectionStart;
            int line = textBoxText.GetLineFromCharIndex(i);
            int fc = textBoxText.GetFirstCharIndexFromLine(line);
            int column = i - fc;
            RowIndexToolStripStatusLabel1.Text = line.ToString();
            ColumnIndexToolStripStatusLabel1.Text = column.ToString();
        }

        private void textBoxText_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshPosition();
        }

        private void StateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (StateToolStripMenuItem2.Checked)
            {
                statusStrip1.Visible = false;
                StateToolStripMenuItem2.Checked = false;
            }
            else
            {
                statusStrip1.Visible = true;
                StateToolStripMenuItem2.Checked = true;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutProgramm().Show();
        }
        public void SearchText(string searchWord, ref int count)
        {
            MatchCollection allWords = Regex.Matches(textBoxText.Text, $@"\b{searchWord}\b", RegexOptions.Multiline | RegexOptions.Compiled);
            int currentSelection = textBoxText.SelectionStart;
            Color currentColor = Color.Black;
            if (count == allWords.Count)
            {
                count = 0;
            }
            int numberWord = 0;
            foreach (Match ip in allWords)
            {
                if (numberWord < count)
                {
                    numberWord++;
                    continue;

                }
                count++;
                textBoxText.SelectionStart = ip.Index;
                textBoxText.SelectionLength = ip.Length;

                textBoxText.ScrollToCaret();
                break;
            }
            this.Focus();
        }
        public void ReplaceText(string oldStr, string newStr)
        {
            textBoxText.Text = textBoxText.Text.Replace(oldStr, newStr);
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RusToolStripMenuItem.Checked = false;
            englishToolStripMenuItem.Checked = true;
            Translate();
        }
        private void RusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RusToolStripMenuItem.Checked = true;
            englishToolStripMenuItem.Checked = false;
            Translate();

        }
        #region Translate
        private void Translate()
        {
            TranslateMenu();
            TranslateTooStrip();
            TranslateStringState();
        }
        private void TranslateMenu()
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                try
                {
                    if (!string.IsNullOrEmpty(item.Tag.ToString()))
                    {
                        string temp = item.Tag.ToString();
                        item.Tag = item.Text;
                        item.Text = temp;
                    }
                }
                catch { }
                TranslateMenuStrip(item);
            }
        }
        private void TranslateMenuStrip(ToolStripMenuItem items)
        {
            foreach (ToolStripDropDownItem item in items.DropDownItems)
            {
                try
                {
                    if (!string.IsNullOrEmpty(item.Tag.ToString()))
                    {

                        string temp = item.Tag.ToString();
                        item.Tag = item.Text;
                        item.Text = temp;
                    }
                }
                catch { }
                TranslateDropDownItem(item.DropDownItems);
            }
        }
        private void TranslateDropDownItem(ToolStripItemCollection items)
        {
            foreach (ToolStripDropDownItem item in items)
            {
                TranslateDropDownItem(item.DropDownItems);
                try
                {
                    if (!string.IsNullOrEmpty(item.Tag.ToString()))
                    {

                        string temp = item.Tag.ToString();
                        item.Tag = item.Text;
                        item.Text = temp;
                    }
                }
                catch { }
            }
        }
        private void TranslateTooStrip()
        {
            foreach (ToolStripButton item in toolStrip1.Items.OfType<ToolStripButton>())
            {
                try
                {
                    if (!string.IsNullOrEmpty(item.Tag.ToString()))
                    {
                        string temp = item.Tag.ToString();
                        item.Tag = item.ToolTipText;
                        item.ToolTipText = temp;
                    }
                }
                catch { }
            }
        }
        private void TranslateStringState()
        {
            foreach (ToolStripStatusLabel item in statusStrip1.Items)
            {
                try
                {
                    string temp = item.Tag.ToString();
                    item.Tag = item.Text;
                    item.Text = temp;
                }
                catch { }
            }
        }
        #endregion
        private void BlackInterface()
        {

            foreach (var item in listPages)
            {
                BlackTextBox(item);
            }

            menuStrip1.BackColor = Color.FromArgb(45, 45, 48);
            toolStrip1.BackColor = Color.FromArgb(45, 45, 48);
            menuStrip1.ForeColor = Color.White;
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.FromArgb(45, 45, 48);
                item.ForeColor = Color.White;
                BlackInterfaceForDropDownItem(item.DropDownItems);
            }
            statusStrip1.BackColor = Color.FromArgb(0, 122, 204);
            foreach (ToolStripStatusLabel item in statusStrip1.Items)
            {
                item.ForeColor = Color.White;
            }
        }
        private void BlackTextBox(MyPage item)
        {
            int currentPosition = textBoxText.SelectionStart;
            textColor = Color.White;
            item.TextBox.BackColor = Color.FromArgb(30, 30, 30);
            item.TextBox.SelectionColor = Color.White;
            item.TextBox.Text += ' ';
            item.TextBox.Text.Remove(item.TextBox.TextLength - 1, 1);
            item.TextBox.SelectionStart = currentPosition;
        }
        private void BlackInterfaceForDropDownItem(ToolStripItemCollection items)
        {
            foreach (ToolStripDropDownItem item in items)
            {
                BlackInterfaceForDropDownItem(item.DropDownItems);
                item.BackColor = Color.FromArgb(45, 45, 48);
                item.ForeColor = Color.White;
            }
        }
        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WhiteToolStripMenuItem.Checked = false;
            BlackToolStripMenuItem.Checked = true;
            BlackInterface();
        }
        private void WhiteTextBox(MyPage item)
        {
            int currentPosition = textBoxText.SelectionStart;
            item.TextBox.BackColor = Color.White;
            item.TextBox.SelectionColor = Color.Black;
            item.TextBox.Text += ' ';
            item.TextBox.Text.Remove(item.TextBox.TextLength - 1, 1);
            item.TextBox.SelectionStart = currentPosition;
        }
        private void WhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textColor = Color.Black;
            foreach (var item in listPages)
            {
                WhiteTextBox(item);
            }


            menuStrip1.BackColor = Color.White;
            toolStrip1.BackColor = Color.White;
            menuStrip1.ForeColor = Color.Black;
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.White;
                item.ForeColor = Color.Black;
                WhiteInterfaceForDropDownItem(item.DropDownItems);
            }
            statusStrip1.BackColor = SystemColors.Control;
            foreach (ToolStripStatusLabel item in statusStrip1.Items)
            {
                item.ForeColor = Color.Black;
            }
        }
        private void WhiteInterfaceForDropDownItem(ToolStripItemCollection items)
        {
            foreach (ToolStripDropDownItem item in items)
            {
                BlackInterfaceForDropDownItem(item.DropDownItems);
                item.BackColor = Color.White;
                item.ForeColor = Color.Black;
            }
        }

        private void SyntToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SyntToolStripMenuItem.Checked = !SyntToolStripMenuItem.Checked;
            if (SyntToolStripMenuItem.Checked)
            {
                SyntaxHighlighting.IsOn = true;
                foreach (var item in listPages)
                {
                    var textBox = item.TextBox;
                    SyntaxHighlighting.RePaint(ref textBox, textColor);
                }
                toolStripButtonBackColor.Visible = false;
                toolStripButtonColorText.Visible = false;
                toolStripButtonFont.Visible = false;
                toolStripSeparator2.Visible = false;
            }
            else
            {
                SyntaxHighlighting.IsOn = false;
                toolStripButtonBackColor.Visible = true;
                toolStripButtonColorText.Visible = true;
                toolStripButtonFont.Visible = true;
                toolStripSeparator2.Visible = true;
            }
        }
    }
}
