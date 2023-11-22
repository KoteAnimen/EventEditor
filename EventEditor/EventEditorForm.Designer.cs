namespace EventEditor
{
	partial class EventEditorForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			statusStrip = new StatusStrip();
			toolStripEventName = new ToolStripStatusLabel();
			toolStrip = new ToolStrip();
			StartRIO_Button = new ToolStripButton();
			splitContainer1 = new SplitContainer();
			tableLayoutPanel2 = new TableLayoutPanel();
			splitContainer2 = new SplitContainer();
			panelImage = new Panel();
			pictureBox = new PictureBox();
			splitContainer3 = new SplitContainer();
			tableLayoutPanel3 = new TableLayoutPanel();
			label2 = new Label();
			listCamera = new ListBox();
			tableLayoutPanel4 = new TableLayoutPanel();
			label3 = new Label();
			listMarks = new ListView();
			columnName = new ColumnHeader();
			columnShortDescription = new ColumnHeader();
			columnDescription = new ColumnHeader();
			cms_EditMarks = new ContextMenuStrip(components);
			cms_AddMark = new ToolStripMenuItem();
			cms_EditMark = new ToolStripMenuItem();
			cms_DeleteMark = new ToolStripMenuItem();
			tableLayoutPanel1 = new TableLayoutPanel();
			label1 = new Label();
			tbx_EventInfo = new TextBox();
			menuStrip = new MenuStrip();
			файлToolStripMenuItem = new ToolStripMenuItem();
			mi_AddMark = new ToolStripMenuItem();
			mi_EditMark = new ToolStripMenuItem();
			mi_DeleteMark = new ToolStripMenuItem();
			сохранитьToolStripMenuItem = new ToolStripMenuItem();
			выходToolStripMenuItem = new ToolStripMenuItem();
			справкаToolStripMenuItem = new ToolStripMenuItem();
			оПрограммеToolStripMenuItem = new ToolStripMenuItem();
			statusStrip.SuspendLayout();
			toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			panelImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
			splitContainer3.Panel1.SuspendLayout();
			splitContainer3.Panel2.SuspendLayout();
			splitContainer3.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			cms_EditMarks.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			menuStrip.SuspendLayout();
			SuspendLayout();
			// 
			// statusStrip
			// 
			statusStrip.Items.AddRange(new ToolStripItem[] { toolStripEventName });
			statusStrip.Location = new Point(0, 558);
			statusStrip.Name = "statusStrip";
			statusStrip.Padding = new Padding(1, 0, 18, 0);
			statusStrip.Size = new Size(866, 22);
			statusStrip.TabIndex = 0;
			statusStrip.Text = "statusStrip1";
			// 
			// toolStripEventName
			// 
			toolStripEventName.Name = "toolStripEventName";
			toolStripEventName.Size = new Size(0, 17);
			// 
			// toolStrip
			// 
			toolStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			toolStrip.ImageScalingSize = new Size(30, 30);
			toolStrip.Items.AddRange(new ToolStripItem[] { StartRIO_Button });
			toolStrip.Location = new Point(0, 24);
			toolStrip.Name = "toolStrip";
			toolStrip.Size = new Size(866, 37);
			toolStrip.TabIndex = 1;
			toolStrip.Text = "toolStrip1";
			// 
			// StartRIO_Button
			// 
			StartRIO_Button.DisplayStyle = ToolStripItemDisplayStyle.Image;
			StartRIO_Button.Enabled = false;
			StartRIO_Button.Image = Properties.Resources.selectTool;
			StartRIO_Button.ImageTransparentColor = Color.Magenta;
			StartRIO_Button.Name = "StartRIO_Button";
			StartRIO_Button.Size = new Size(34, 34);
			StartRIO_Button.Text = "Выделить область";
			StartRIO_Button.Click += StartRIO_Button_Click;
			// 
			// splitContainer1
			// 
			splitContainer1.BorderStyle = BorderStyle.FixedSingle;
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 61);
			splitContainer1.Margin = new Padding(4);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
			splitContainer1.Panel1.RightToLeft = RightToLeft.No;
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
			splitContainer1.Panel2.RightToLeft = RightToLeft.No;
			splitContainer1.Size = new Size(866, 497);
			splitContainer1.SplitterDistance = 371;
			splitContainer1.SplitterWidth = 5;
			splitContainer1.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(splitContainer2, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(0, 0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutPanel2.Size = new Size(864, 369);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// splitContainer2
			// 
			splitContainer2.BorderStyle = BorderStyle.FixedSingle;
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.Location = new Point(3, 3);
			splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.Controls.Add(panelImage);
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(splitContainer3);
			splitContainer2.Size = new Size(858, 323);
			splitContainer2.SplitterDistance = 587;
			splitContainer2.TabIndex = 0;
			// 
			// panelImage
			// 
			panelImage.AutoScroll = true;
			panelImage.Controls.Add(pictureBox);
			panelImage.Dock = DockStyle.Fill;
			panelImage.Location = new Point(0, 0);
			panelImage.Name = "panelImage";
			panelImage.Size = new Size(585, 321);
			panelImage.TabIndex = 0;
			panelImage.Scroll += panelImage_Scroll;
			// 
			// pictureBox
			// 
			pictureBox.Location = new Point(0, 0);
			pictureBox.Name = "pictureBox";
			pictureBox.Size = new Size(337, 267);
			pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox.TabIndex = 0;
			pictureBox.TabStop = false;
			pictureBox.MouseDown += pictureBox_MouseDown;
			pictureBox.MouseMove += pictureBox_MouseMove;
			pictureBox.MouseUp += pictureBox_MouseUp;
			// 
			// splitContainer3
			// 
			splitContainer3.BorderStyle = BorderStyle.FixedSingle;
			splitContainer3.Dock = DockStyle.Fill;
			splitContainer3.Location = new Point(0, 0);
			splitContainer3.Name = "splitContainer3";
			splitContainer3.Orientation = Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			splitContainer3.Panel1.Controls.Add(tableLayoutPanel3);
			// 
			// splitContainer3.Panel2
			// 
			splitContainer3.Panel2.Controls.Add(tableLayoutPanel4);
			splitContainer3.Size = new Size(267, 323);
			splitContainer3.SplitterDistance = 155;
			splitContainer3.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel3.Controls.Add(label2, 0, 0);
			tableLayoutPanel3.Controls.Add(listCamera, 0, 1);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(0, 0);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.Size = new Size(265, 153);
			tableLayoutPanel3.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Fill;
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(259, 30);
			label2.TabIndex = 0;
			label2.Text = "Камеры:";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// listCamera
			// 
			listCamera.Dock = DockStyle.Fill;
			listCamera.FormattingEnabled = true;
			listCamera.ItemHeight = 21;
			listCamera.Location = new Point(3, 33);
			listCamera.Name = "listCamera";
			listCamera.Size = new Size(259, 117);
			listCamera.TabIndex = 1;
			listCamera.SelectedIndexChanged += listCamera_SelectedIndexChanged;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 1;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel4.Controls.Add(label3, 0, 0);
			tableLayoutPanel4.Controls.Add(listMarks, 0, 1);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(0, 0);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 2;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel4.Size = new Size(265, 162);
			tableLayoutPanel4.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Fill;
			label3.Location = new Point(3, 0);
			label3.Name = "label3";
			label3.Size = new Size(259, 30);
			label3.TabIndex = 0;
			label3.Text = "Заметки:";
			label3.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// listMarks
			// 
			listMarks.Columns.AddRange(new ColumnHeader[] { columnName, columnShortDescription, columnDescription });
			listMarks.ContextMenuStrip = cms_EditMarks;
			listMarks.Dock = DockStyle.Fill;
			listMarks.FullRowSelect = true;
			listMarks.Location = new Point(3, 33);
			listMarks.MultiSelect = false;
			listMarks.Name = "listMarks";
			listMarks.Size = new Size(259, 126);
			listMarks.TabIndex = 1;
			listMarks.UseCompatibleStateImageBehavior = false;
			listMarks.View = View.Details;
			listMarks.SelectedIndexChanged += listMarks_SelectedIndexChanged;
			// 
			// columnName
			// 
			columnName.Text = "Имя";
			columnName.Width = 120;
			// 
			// columnShortDescription
			// 
			columnShortDescription.Text = "Кратк. описание";
			// 
			// columnDescription
			// 
			columnDescription.Text = "Описание";
			columnDescription.Width = 100;
			// 
			// cms_EditMarks
			// 
			cms_EditMarks.Items.AddRange(new ToolStripItem[] { cms_AddMark, cms_EditMark, cms_DeleteMark });
			cms_EditMarks.Name = "cms_EditMarks";
			cms_EditMarks.Size = new Size(201, 70);
			// 
			// cms_AddMark
			// 
			cms_AddMark.Name = "cms_AddMark";
			cms_AddMark.Size = new Size(200, 22);
			cms_AddMark.Text = "Добавить заметку";
			cms_AddMark.Click += cms_AddMark_Click;
			// 
			// cms_EditMark
			// 
			cms_EditMark.Name = "cms_EditMark";
			cms_EditMark.Size = new Size(200, 22);
			cms_EditMark.Text = "Редактировать заметку";
			cms_EditMark.Click += cms_EditMark_Click;
			// 
			// cms_DeleteMark
			// 
			cms_DeleteMark.Name = "cms_DeleteMark";
			cms_DeleteMark.Size = new Size(200, 22);
			cms_DeleteMark.Text = "Удалить заметку";
			cms_DeleteMark.Click += cms_DeleteMark_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(tbx_EventInfo, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(864, 119);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(858, 30);
			label1.TabIndex = 0;
			label1.Text = "Информация:";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// tbx_EventInfo
			// 
			tbx_EventInfo.Dock = DockStyle.Fill;
			tbx_EventInfo.Location = new Point(3, 33);
			tbx_EventInfo.Multiline = true;
			tbx_EventInfo.Name = "tbx_EventInfo";
			tbx_EventInfo.ReadOnly = true;
			tbx_EventInfo.ScrollBars = ScrollBars.Both;
			tbx_EventInfo.Size = new Size(858, 83);
			tbx_EventInfo.TabIndex = 1;
			// 
			// menuStrip
			// 
			menuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(866, 24);
			menuStrip.TabIndex = 3;
			menuStrip.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mi_AddMark, mi_EditMark, mi_DeleteMark, сохранитьToolStripMenuItem, выходToolStripMenuItem });
			файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			файлToolStripMenuItem.Size = new Size(48, 20);
			файлToolStripMenuItem.Text = "Файл";
			// 
			// mi_AddMark
			// 
			mi_AddMark.Name = "mi_AddMark";
			mi_AddMark.Size = new Size(200, 22);
			mi_AddMark.Text = "Добавить заметку";
			mi_AddMark.Click += mi_AddMark_Click;
			// 
			// mi_EditMark
			// 
			mi_EditMark.Name = "mi_EditMark";
			mi_EditMark.Size = new Size(200, 22);
			mi_EditMark.Text = "Редактировать заметку";
			mi_EditMark.Click += mi_EditMark_Click;
			// 
			// mi_DeleteMark
			// 
			mi_DeleteMark.Name = "mi_DeleteMark";
			mi_DeleteMark.Size = new Size(200, 22);
			mi_DeleteMark.Text = "Удалить заметку";
			mi_DeleteMark.Click += mi_DeleteMark_Click;
			// 
			// сохранитьToolStripMenuItem
			// 
			сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			сохранитьToolStripMenuItem.Size = new Size(200, 22);
			сохранитьToolStripMenuItem.Text = "Сохранить";
			// 
			// выходToolStripMenuItem
			// 
			выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			выходToolStripMenuItem.Size = new Size(200, 22);
			выходToolStripMenuItem.Text = "Выход";
			// 
			// справкаToolStripMenuItem
			// 
			справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
			справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			справкаToolStripMenuItem.Size = new Size(65, 20);
			справкаToolStripMenuItem.Text = "Справка";
			// 
			// оПрограммеToolStripMenuItem
			// 
			оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			оПрограммеToolStripMenuItem.Size = new Size(149, 22);
			оПрограммеToolStripMenuItem.Text = "О программе";
			// 
			// EventEditorForm
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(866, 580);
			Controls.Add(splitContainer1);
			Controls.Add(toolStrip);
			Controls.Add(statusStrip);
			Controls.Add(menuStrip);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			MainMenuStrip = menuStrip;
			Margin = new Padding(4);
			Name = "EventEditorForm";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Kvantron: EventEditor";
			WindowState = FormWindowState.Maximized;
			SizeChanged += EventEditorForm_SizeChanged;
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStrip.ResumeLayout(false);
			toolStrip.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			panelImage.ResumeLayout(false);
			panelImage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
			splitContainer3.Panel1.ResumeLayout(false);
			splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
			splitContainer3.ResumeLayout(false);
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			cms_EditMarks.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private StatusStrip statusStrip;
		private ToolStrip toolStrip;
		private SplitContainer splitContainer1;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private TextBox tbx_EventInfo;
		private MenuStrip menuStrip;
		private ToolStripMenuItem файлToolStripMenuItem;
		private ToolStripMenuItem справкаToolStripMenuItem;
		private ToolStripMenuItem оПрограммеToolStripMenuItem;
		private ToolStripStatusLabel toolStripEventName;
		private TableLayoutPanel tableLayoutPanel2;
		private SplitContainer splitContainer2;
		private SplitContainer splitContainer3;
		private TableLayoutPanel tableLayoutPanel3;
		private TableLayoutPanel tableLayoutPanel4;
		private Label label2;
		private Label label3;
		private ListBox listCamera;
		private ListView listMarks;
		private ColumnHeader columnName;
		private ColumnHeader columnShortDescription;
		private ColumnHeader columnDescription;
		private ToolStripMenuItem mi_AddMark;
		private ToolStripMenuItem mi_EditMark;
		private ToolStripMenuItem mi_DeleteMark;
		private ToolStripMenuItem сохранитьToolStripMenuItem;
		private ToolStripMenuItem выходToolStripMenuItem;
		private ToolStripButton StartRIO_Button;
		private Panel panelImage;
		private PictureBox pictureBox;
		private ContextMenuStrip cms_EditMarks;
		private ToolStripMenuItem cms_AddMark;
		private ToolStripMenuItem cms_EditMark;
		private ToolStripMenuItem cms_DeleteMark;
	}
}