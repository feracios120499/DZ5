namespace Task1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNewDoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonColorText = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBackColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFont = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextPastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDocДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСТекстомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найстрокаТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxText = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripSeparator1,
            this.toolStripButtonNewDoc,
            this.toolStripButtonCopy,
            this.toolStripButtonCut,
            this.toolStripButtonPaste,
            this.toolStripButtonCancel,
            this.toolStripSeparator2,
            this.toolStripButtonColorText,
            this.toolStripButtonBackColor,
            this.toolStripButtonFont});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1160, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(44, 44);
            this.toolStripButtonOpen.Text = "toolStripButton1";
            this.toolStripButtonOpen.ToolTipText = "Открыть";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(44, 44);
            this.toolStripButtonSave.Text = "toolStripButton1";
            this.toolStripButtonSave.ToolTipText = "Сохранить";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButtonNewDoc
            // 
            this.toolStripButtonNewDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewDoc.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewDoc.Image")));
            this.toolStripButtonNewDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewDoc.Name = "toolStripButtonNewDoc";
            this.toolStripButtonNewDoc.Size = new System.Drawing.Size(44, 44);
            this.toolStripButtonNewDoc.Text = "toolStripButton1";
            this.toolStripButtonNewDoc.ToolTipText = "Новый документ";
            this.toolStripButtonNewDoc.Click += new System.EventHandler(this.toolStripButtonNewDoc_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopy.Image")));
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(44, 44);
            this.toolStripButtonCopy.Text = "toolStripButton1";
            this.toolStripButtonCopy.ToolTipText = "Копировать";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.toolStripButtonCopy_Click);
            // 
            // toolStripButtonCut
            // 
            this.toolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCut.Image")));
            this.toolStripButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCut.Name = "toolStripButtonCut";
            this.toolStripButtonCut.Size = new System.Drawing.Size(44, 44);
            this.toolStripButtonCut.Text = "toolStripButton1";
            this.toolStripButtonCut.ToolTipText = "Вырезать";
            this.toolStripButtonCut.Click += new System.EventHandler(this.toolStripButtonCut_Click);
            // 
            // toolStripButtonPaste
            // 
            this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPaste.Image")));
            this.toolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPaste.Name = "toolStripButtonPaste";
            this.toolStripButtonPaste.Size = new System.Drawing.Size(44, 44);
            this.toolStripButtonPaste.Text = "toolStripButton1";
            this.toolStripButtonPaste.ToolTipText = "Вставить";
            this.toolStripButtonPaste.Click += new System.EventHandler(this.toolStripButtonPaste_Click);
            // 
            // toolStripButtonCancel
            // 
            this.toolStripButtonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancel.Image")));
            this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancel.Name = "toolStripButtonCancel";
            this.toolStripButtonCancel.Size = new System.Drawing.Size(44, 44);
            this.toolStripButtonCancel.Text = "toolStripButton1";
            this.toolStripButtonCancel.ToolTipText = "Отменить";
            this.toolStripButtonCancel.Click += new System.EventHandler(this.toolStripButtonCancel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButtonColorText
            // 
            this.toolStripButtonColorText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColorText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColorText.Image")));
            this.toolStripButtonColorText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColorText.Name = "toolStripButtonColorText";
            this.toolStripButtonColorText.Size = new System.Drawing.Size(44, 44);
            this.toolStripButtonColorText.Text = "toolStripButton1";
            this.toolStripButtonColorText.ToolTipText = "Цвет текста";
            this.toolStripButtonColorText.Click += new System.EventHandler(this.toolStripButtonColorText_Click);
            // 
            // toolStripButtonBackColor
            // 
            this.toolStripButtonBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBackColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBackColor.Image")));
            this.toolStripButtonBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBackColor.Name = "toolStripButtonBackColor";
            this.toolStripButtonBackColor.Size = new System.Drawing.Size(44, 44);
            this.toolStripButtonBackColor.Text = "toolStripButton1";
            this.toolStripButtonBackColor.ToolTipText = "Цвет фона";
            this.toolStripButtonBackColor.Click += new System.EventHandler(this.toolStripButtonBackColor_Click);
            // 
            // toolStripButtonFont
            // 
            this.toolStripButtonFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFont.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFont.Image")));
            this.toolStripButtonFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFont.Name = "toolStripButtonFont";
            this.toolStripButtonFont.Size = new System.Drawing.Size(44, 44);
            this.toolStripButtonFont.Text = "toolStripButton1";
            this.toolStripButtonFont.ToolTipText = "Шрифт";
            this.toolStripButtonFont.Click += new System.EventHandler(this.toolStripButtonFont_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextCopyToolStripMenuItem,
            this.ContextCutToolStripMenuItem,
            this.ContextPastToolStripMenuItem,
            this.ContextCancelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 136);
            // 
            // ContextCopyToolStripMenuItem
            // 
            this.ContextCopyToolStripMenuItem.Image = global::Task1.Properties.Resources.Copy_40px;
            this.ContextCopyToolStripMenuItem.Name = "ContextCopyToolStripMenuItem";
            this.ContextCopyToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.ContextCopyToolStripMenuItem.Text = "Копировать";
            this.ContextCopyToolStripMenuItem.Click += new System.EventHandler(this.ContextCopyToolStripMenuItem_Click);
            // 
            // ContextCutToolStripMenuItem
            // 
            this.ContextCutToolStripMenuItem.Image = global::Task1.Properties.Resources.Cut_40px;
            this.ContextCutToolStripMenuItem.Name = "ContextCutToolStripMenuItem";
            this.ContextCutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.ContextCutToolStripMenuItem.Text = "Вырезать";
            this.ContextCutToolStripMenuItem.Click += new System.EventHandler(this.ContextCutToolStripMenuItem_Click);
            // 
            // ContextPastToolStripMenuItem
            // 
            this.ContextPastToolStripMenuItem.Image = global::Task1.Properties.Resources.Paste_40px;
            this.ContextPastToolStripMenuItem.Name = "ContextPastToolStripMenuItem";
            this.ContextPastToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.ContextPastToolStripMenuItem.Text = "Вставить";
            this.ContextPastToolStripMenuItem.Click += new System.EventHandler(this.ContextPastToolStripMenuItem_Click);
            // 
            // ContextCancelToolStripMenuItem
            // 
            this.ContextCancelToolStripMenuItem.Image = global::Task1.Properties.Resources.Undo_40px;
            this.ContextCancelToolStripMenuItem.Name = "ContextCancelToolStripMenuItem";
            this.ContextCancelToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.ContextCancelToolStripMenuItem.Text = "Отменить";
            this.ContextCancelToolStripMenuItem.Click += new System.EventHandler(this.ContextCancelToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.работаСТекстомToolStripMenuItem,
            this.найстрокаТекстаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.NewDocДокументToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsКакToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = global::Task1.Properties.Resources.Open_40px;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // NewDocДокументToolStripMenuItem
            // 
            this.NewDocДокументToolStripMenuItem.Image = global::Task1.Properties.Resources.Document_40px;
            this.NewDocДокументToolStripMenuItem.Name = "NewDocДокументToolStripMenuItem";
            this.NewDocДокументToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.NewDocДокументToolStripMenuItem.Text = "Новый документ";
            this.NewDocДокументToolStripMenuItem.Click += new System.EventHandler(this.NewDocДокументToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = global::Task1.Properties.Resources.Save_40px;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsКакToolStripMenuItem
            // 
            this.SaveAsКакToolStripMenuItem.Image = global::Task1.Properties.Resources.Save_as_40px;
            this.SaveAsКакToolStripMenuItem.Name = "SaveAsКакToolStripMenuItem";
            this.SaveAsКакToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.SaveAsКакToolStripMenuItem.Text = "Сохранить как";
            this.SaveAsКакToolStripMenuItem.Click += new System.EventHandler(this.SaveAsКакToolStripMenuItem_Click);
            // 
            // работаСТекстомToolStripMenuItem
            // 
            this.работаСТекстомToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.CancelToolStripMenuItem,
            this.SelectAllВсёToolStripMenuItem});
            this.работаСТекстомToolStripMenuItem.Name = "работаСТекстомToolStripMenuItem";
            this.работаСТекстомToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.работаСТекстомToolStripMenuItem.Text = "Работа с текстом";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Image = global::Task1.Properties.Resources.Copy_40px;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Image = global::Task1.Properties.Resources.Cut_40px;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Image = global::Task1.Properties.Resources.Paste_40px;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.PasteToolStripMenuItem.Text = "Вставить";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.Image = global::Task1.Properties.Resources.Undo_40px;
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.CancelToolStripMenuItem.Text = "Отменить";
            this.CancelToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // SelectAllВсёToolStripMenuItem
            // 
            this.SelectAllВсёToolStripMenuItem.Image = global::Task1.Properties.Resources.Select_All_40px;
            this.SelectAllВсёToolStripMenuItem.Name = "SelectAllВсёToolStripMenuItem";
            this.SelectAllВсёToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.SelectAllВсёToolStripMenuItem.Text = "Выделить всё";
            this.SelectAllВсёToolStripMenuItem.Click += new System.EventHandler(this.SelectAllВсёToolStripMenuItem_Click);
            // 
            // найстрокаТекстаToolStripMenuItem
            // 
            this.найстрокаТекстаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorTextToolStripMenuItem,
            this.BackColorToolStripMenuItem,
            this.FontToolStripMenuItem});
            this.найстрокаТекстаToolStripMenuItem.Name = "найстрокаТекстаToolStripMenuItem";
            this.найстрокаТекстаToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.найстрокаТекстаToolStripMenuItem.Text = "Найстрока текста";
            // 
            // ColorTextToolStripMenuItem
            // 
            this.ColorTextToolStripMenuItem.Image = global::Task1.Properties.Resources.Color_Wheel_48px;
            this.ColorTextToolStripMenuItem.Name = "ColorTextToolStripMenuItem";
            this.ColorTextToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ColorTextToolStripMenuItem.Text = "Цвет текста";
            this.ColorTextToolStripMenuItem.Click += new System.EventHandler(this.ColorTextToolStripMenuItem_Click);
            // 
            // BackColorToolStripMenuItem
            // 
            this.BackColorToolStripMenuItem.Image = global::Task1.Properties.Resources.Fill_Color_48px;
            this.BackColorToolStripMenuItem.Name = "BackColorToolStripMenuItem";
            this.BackColorToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.BackColorToolStripMenuItem.Text = "Цвет фона";
            this.BackColorToolStripMenuItem.Click += new System.EventHandler(this.BackColorToolStripMenuItem_Click);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Image = global::Task1.Properties.Resources.Choose_Font_48px;
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.FontToolStripMenuItem.Text = "Настройка шрифта";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxText.Location = new System.Drawing.Point(0, 75);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(1160, 645);
            this.textBoxText.TabIndex = 3;
            this.textBoxText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 720);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewDoc;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonCut;
        private System.Windows.Forms.ToolStripButton toolStripButtonPaste;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private System.Windows.Forms.ToolStripButton toolStripButtonColorText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonBackColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonFont;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDocДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСТекстомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllВсёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найстрокаТекстаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContextCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextPastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextCancelToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBoxText;
    }
}

