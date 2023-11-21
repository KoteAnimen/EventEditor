namespace EventEditor
{
	partial class EditMarkForm
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
			tableLayoutPanel1 = new TableLayoutPanel();
			lbl_Header = new Label();
			tableLayoutPanel2 = new TableLayoutPanel();
			label1 = new Label();
			tbx_Name = new TextBox();
			tableLayoutPanel3 = new TableLayoutPanel();
			label2 = new Label();
			tbx_ShortDescription = new TextBox();
			tableLayoutPanel4 = new TableLayoutPanel();
			label3 = new Label();
			tbx_Description = new TextBox();
			tableLayoutPanel5 = new TableLayoutPanel();
			btn_Accept = new Button();
			btn_Cancel = new Button();
			tableLayoutPanel6 = new TableLayoutPanel();
			tableLayoutPanel7 = new TableLayoutPanel();
			label4 = new Label();
			label5 = new Label();
			btn_SelectColor = new Button();
			cmb_MarkType = new ComboBox();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			tableLayoutPanel5.SuspendLayout();
			tableLayoutPanel6.SuspendLayout();
			tableLayoutPanel7.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 3);
			tableLayoutPanel1.Controls.Add(lbl_Header, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 2);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 4);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 5);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 6);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 7;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			tableLayoutPanel1.Size = new Size(507, 577);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// lbl_Header
			// 
			lbl_Header.AutoSize = true;
			lbl_Header.Dock = DockStyle.Fill;
			lbl_Header.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			lbl_Header.Location = new Point(3, 0);
			lbl_Header.Name = "lbl_Header";
			lbl_Header.Size = new Size(501, 40);
			lbl_Header.TabIndex = 0;
			lbl_Header.Text = "Добавить заметку";
			lbl_Header.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(label1, 0, 0);
			tableLayoutPanel2.Controls.Add(tbx_Name, 0, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 43);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(501, 64);
			tableLayoutPanel2.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(495, 30);
			label1.TabIndex = 0;
			label1.Text = "Имя:";
			// 
			// tbx_Name
			// 
			tbx_Name.Dock = DockStyle.Fill;
			tbx_Name.Location = new Point(3, 33);
			tbx_Name.Name = "tbx_Name";
			tbx_Name.Size = new Size(495, 29);
			tbx_Name.TabIndex = 1;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel3.Controls.Add(tbx_ShortDescription, 0, 1);
			tableLayoutPanel3.Controls.Add(label2, 0, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 263);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.Size = new Size(501, 127);
			tableLayoutPanel3.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Fill;
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(495, 30);
			label2.TabIndex = 0;
			label2.Text = "Краткое описание:";
			// 
			// tbx_ShortDescription
			// 
			tbx_ShortDescription.Dock = DockStyle.Fill;
			tbx_ShortDescription.Location = new Point(3, 33);
			tbx_ShortDescription.Multiline = true;
			tbx_ShortDescription.Name = "tbx_ShortDescription";
			tbx_ShortDescription.ScrollBars = ScrollBars.Both;
			tbx_ShortDescription.Size = new Size(495, 91);
			tbx_ShortDescription.TabIndex = 1;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 1;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel4.Controls.Add(label3, 0, 0);
			tableLayoutPanel4.Controls.Add(tbx_Description, 0, 1);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(3, 396);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 2;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel4.Size = new Size(501, 127);
			tableLayoutPanel4.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Fill;
			label3.Location = new Point(3, 0);
			label3.Name = "label3";
			label3.Size = new Size(495, 30);
			label3.TabIndex = 0;
			label3.Text = "Описание:";
			// 
			// tbx_Description
			// 
			tbx_Description.Dock = DockStyle.Fill;
			tbx_Description.Location = new Point(3, 33);
			tbx_Description.Multiline = true;
			tbx_Description.Name = "tbx_Description";
			tbx_Description.ScrollBars = ScrollBars.Both;
			tbx_Description.Size = new Size(495, 91);
			tbx_Description.TabIndex = 1;
			// 
			// tableLayoutPanel5
			// 
			tableLayoutPanel5.ColumnCount = 2;
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel5.Controls.Add(btn_Accept, 0, 0);
			tableLayoutPanel5.Controls.Add(btn_Cancel, 1, 0);
			tableLayoutPanel5.Dock = DockStyle.Fill;
			tableLayoutPanel5.Location = new Point(3, 529);
			tableLayoutPanel5.Name = "tableLayoutPanel5";
			tableLayoutPanel5.RowCount = 1;
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel5.Size = new Size(501, 45);
			tableLayoutPanel5.TabIndex = 4;
			// 
			// btn_Accept
			// 
			btn_Accept.BackColor = Color.LimeGreen;
			btn_Accept.Dock = DockStyle.Fill;
			btn_Accept.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btn_Accept.ForeColor = Color.White;
			btn_Accept.Location = new Point(3, 3);
			btn_Accept.Name = "btn_Accept";
			btn_Accept.Size = new Size(244, 39);
			btn_Accept.TabIndex = 0;
			btn_Accept.Text = "Добавить";
			btn_Accept.UseVisualStyleBackColor = false;
			btn_Accept.Click += btn_Accept_Click;
			// 
			// btn_Cancel
			// 
			btn_Cancel.BackColor = Color.Tomato;
			btn_Cancel.Dock = DockStyle.Fill;
			btn_Cancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btn_Cancel.ForeColor = Color.White;
			btn_Cancel.Location = new Point(253, 3);
			btn_Cancel.Name = "btn_Cancel";
			btn_Cancel.Size = new Size(245, 39);
			btn_Cancel.TabIndex = 1;
			btn_Cancel.Text = "Отмена";
			btn_Cancel.UseVisualStyleBackColor = false;
			btn_Cancel.Click += btn_Cancel_Click;
			// 
			// tableLayoutPanel6
			// 
			tableLayoutPanel6.ColumnCount = 1;
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel6.Controls.Add(label4, 0, 0);
			tableLayoutPanel6.Controls.Add(btn_SelectColor, 0, 1);
			tableLayoutPanel6.Dock = DockStyle.Fill;
			tableLayoutPanel6.Location = new Point(3, 113);
			tableLayoutPanel6.Name = "tableLayoutPanel6";
			tableLayoutPanel6.RowCount = 2;
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel6.Size = new Size(501, 74);
			tableLayoutPanel6.TabIndex = 5;
			// 
			// tableLayoutPanel7
			// 
			tableLayoutPanel7.ColumnCount = 1;
			tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel7.Controls.Add(label5, 0, 0);
			tableLayoutPanel7.Controls.Add(cmb_MarkType, 0, 1);
			tableLayoutPanel7.Dock = DockStyle.Fill;
			tableLayoutPanel7.Location = new Point(3, 193);
			tableLayoutPanel7.Name = "tableLayoutPanel7";
			tableLayoutPanel7.RowCount = 2;
			tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel7.Size = new Size(501, 64);
			tableLayoutPanel7.TabIndex = 6;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Dock = DockStyle.Fill;
			label4.Location = new Point(3, 0);
			label4.Name = "label4";
			label4.Size = new Size(495, 30);
			label4.TabIndex = 0;
			label4.Text = "Цвет заметки:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Dock = DockStyle.Fill;
			label5.Location = new Point(3, 0);
			label5.Name = "label5";
			label5.Size = new Size(495, 30);
			label5.TabIndex = 0;
			label5.Text = "Тип заметки:";
			// 
			// btn_SelectColor
			// 
			btn_SelectColor.BackColor = Color.White;
			btn_SelectColor.Dock = DockStyle.Fill;
			btn_SelectColor.Location = new Point(3, 33);
			btn_SelectColor.Name = "btn_SelectColor";
			btn_SelectColor.Size = new Size(495, 38);
			btn_SelectColor.TabIndex = 1;
			btn_SelectColor.Text = "Выбрать цвет";
			btn_SelectColor.UseVisualStyleBackColor = false;
			btn_SelectColor.Click += btn_SelectColor_Click;
			// 
			// cmb_MarkType
			// 
			cmb_MarkType.Dock = DockStyle.Fill;
			cmb_MarkType.DropDownStyle = ComboBoxStyle.DropDownList;
			cmb_MarkType.FormattingEnabled = true;
			cmb_MarkType.Location = new Point(3, 33);
			cmb_MarkType.Name = "cmb_MarkType";
			cmb_MarkType.Size = new Size(495, 29);
			cmb_MarkType.TabIndex = 1;
			// 
			// EditMarkForm
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(507, 577);
			Controls.Add(tableLayoutPanel1);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(4, 4, 4, 4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "EditMarkForm";
			ShowIcon = false;
			Text = "Добавить заметку";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel4.PerformLayout();
			tableLayoutPanel5.ResumeLayout(false);
			tableLayoutPanel6.ResumeLayout(false);
			tableLayoutPanel6.PerformLayout();
			tableLayoutPanel7.ResumeLayout(false);
			tableLayoutPanel7.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label lbl_Header;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label1;
		private TextBox tbx_Name;
		private TableLayoutPanel tableLayoutPanel3;
		private Label label2;
		private TextBox tbx_ShortDescription;
		private TableLayoutPanel tableLayoutPanel4;
		private Label label3;
		private TextBox tbx_Description;
		private TableLayoutPanel tableLayoutPanel5;
		private Button btn_Accept;
		private Button btn_Cancel;
		private TableLayoutPanel tableLayoutPanel7;
		private TableLayoutPanel tableLayoutPanel6;
		private Label label5;
		private Label label4;
		private Button btn_SelectColor;
		private ComboBox cmb_MarkType;
	}
}