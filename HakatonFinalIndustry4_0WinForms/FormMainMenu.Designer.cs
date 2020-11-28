namespace HakatonFinalIndustry4_0WinForms
{
	partial class FormMainMenu
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonPredict = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.SelectedSize = new System.Windows.Forms.ComboBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.SelectedPeriod = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.SelectedCircle = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.buttonPredict);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(696, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(201, 481);
			this.panel1.TabIndex = 1;
			// 
			// buttonPredict
			// 
			this.buttonPredict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.buttonPredict.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonPredict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPredict.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPredict.Location = new System.Drawing.Point(0, 431);
			this.buttonPredict.Name = "buttonPredict";
			this.buttonPredict.Size = new System.Drawing.Size(201, 50);
			this.buttonPredict.TabIndex = 0;
			this.buttonPredict.Text = "ПРОГНОЗ";
			this.buttonPredict.UseVisualStyleBackColor = false;
			this.buttonPredict.Click += new System.EventHandler(this.ButtonPredict_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.SelectedSize);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(201, 77);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Масштаб";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// SelectedSize
			// 
			this.SelectedSize.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SelectedSize.FormattingEnabled = true;
			this.SelectedSize.Items.AddRange(new object[] {
            "Страна",
            "Округ",
            "Регион",
            "Город"});
			this.SelectedSize.Location = new System.Drawing.Point(0, 36);
			this.SelectedSize.Name = "SelectedSize";
			this.SelectedSize.Size = new System.Drawing.Size(201, 41);
			this.SelectedSize.TabIndex = 1;
			this.SelectedSize.Text = "Страна";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel3.Controls.Add(this.comboBox2);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(0, 263);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(201, 78);
			this.panel3.TabIndex = 2;
			// 
			// comboBox2
			// 
			this.comboBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "лёгкая и тяжёлая",
            "отраслевая",
            "химическая промышленность",
            "машиностроение",
            "электроэнергетика",
            "топливная",
            "чёрная металлургия",
            "цветная металлургия",
            "металлообработка",
            "легкая промышленность",
            "лесная промышленность",
            "строительная промышленность",
            "пищевая промышленность"});
			this.comboBox2.Location = new System.Drawing.Point(0, 37);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(201, 41);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.Text = "Все";
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(201, 33);
			this.label2.TabIndex = 0;
			this.label2.Text = "Отрасль";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel4.Controls.Add(this.SelectedPeriod);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Location = new System.Drawing.Point(0, 347);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(201, 78);
			this.panel4.TabIndex = 3;
			// 
			// SelectedPeriod
			// 
			this.SelectedPeriod.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SelectedPeriod.FormattingEnabled = true;
			this.SelectedPeriod.Items.AddRange(new object[] {
            "День",
            "Неделя",
            "Месяц",
            "Год"});
			this.SelectedPeriod.Location = new System.Drawing.Point(0, 37);
			this.SelectedPeriod.Name = "SelectedPeriod";
			this.SelectedPeriod.Size = new System.Drawing.Size(201, 41);
			this.SelectedPeriod.TabIndex = 1;
			this.SelectedPeriod.Text = "День";
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(201, 33);
			this.label3.TabIndex = 0;
			this.label3.Text = "Прогноз";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel5.Controls.Add(this.SelectedCircle);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Location = new System.Drawing.Point(0, 83);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(201, 78);
			this.panel5.TabIndex = 4;
			// 
			// SelectedCircle
			// 
			this.SelectedCircle.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SelectedCircle.FormattingEnabled = true;
			this.SelectedCircle.Items.AddRange(new object[] {
            "Центр",
            "Юг",
            "Средняя Волга",
            "Сибирь",
            "Урал",
            "Северо-Запад"});
			this.SelectedCircle.Location = new System.Drawing.Point(0, 37);
			this.SelectedCircle.Name = "SelectedCircle";
			this.SelectedCircle.Size = new System.Drawing.Size(201, 41);
			this.SelectedCircle.TabIndex = 1;
			this.SelectedCircle.Text = "Центр";
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(201, 33);
			this.label4.TabIndex = 0;
			this.label4.Text = "Округ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Checked = false;
			this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dateTimePicker.Location = new System.Drawing.Point(0, 37);
			this.dateTimePicker.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
			this.dateTimePicker.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(201, 41);
			this.dateTimePicker.TabIndex = 5;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel6.Controls.Add(this.label5);
			this.panel6.Controls.Add(this.dateTimePicker);
			this.panel6.Location = new System.Drawing.Point(0, 167);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(201, 78);
			this.panel6.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(201, 33);
			this.label5.TabIndex = 0;
			this.label5.Text = "Отсчёт";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FormMainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 481);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
			this.Name = "FormMainMenu";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonPredict;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox SelectedSize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ComboBox SelectedPeriod;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.ComboBox SelectedCircle;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label5;
	}
}

