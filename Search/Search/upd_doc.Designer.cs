/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 02.04.2022
 * Время: 20:54
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Search
{
	partial class upd_doc
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox5;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(15, 35);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(735, 170);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(735, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Выберите документ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 583);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(733, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Изменить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(16, 611);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(733, 23);
			this.button2.TabIndex = 12;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(11, 549);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(139, 24);
			this.checkBox1.TabIndex = 34;
			this.checkBox1.Text = "Закрытая тема";
			this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(393, 505);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 23);
			this.label7.TabIndex = 33;
			this.label7.Text = "Введите конец работ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 504);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(124, 23);
			this.label6.TabIndex = 32;
			this.label6.Text = "Введите начало работ";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(593, 549);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(149, 20);
			this.textBox6.TabIndex = 31;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(535, 507);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(208, 20);
			this.textBox4.TabIndex = 30;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(159, 507);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(208, 20);
			this.textBox3.TabIndex = 29;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(12, 413);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(731, 84);
			this.dataGridView2.TabIndex = 28;
			this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellClick);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(176, 357);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(567, 20);
			this.textBox2.TabIndex = 27;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(433, 266);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(312, 53);
			this.button3.TabIndex = 26;
			this.button3.Text = "Выбрать путь";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(11, 386);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(732, 23);
			this.label5.TabIndex = 25;
			this.label5.Text = "Выберите заказчика";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 355);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 23);
			this.label4.TabIndex = 24;
			this.label4.Text = "Введите подтип документа";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(440, 538);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(148, 40);
			this.label10.TabIndex = 23;
			this.label10.Text = "Введите роль сотрудника";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(166, 539);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(120, 40);
			this.label9.TabIndex = 22;
			this.label9.Text = "Выберите сотрудника";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 322);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 23);
			this.label1.TabIndex = 21;
			this.label1.Text = "Выберите тип документа";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(292, 549);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(141, 21);
			this.comboBox2.TabIndex = 20;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
			"Договорная_документация",
			"Документы_НИОКР",
			"Нормативная_документация",
			"Результаты_диагностического_оборудования_АЭС",
			"Ремонтная_документация",
			"Техническая_документация"});
			this.comboBox1.Location = new System.Drawing.Point(176, 325);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(567, 21);
			this.comboBox1.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(11, 242);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(734, 23);
			this.label2.TabIndex = 18;
			this.label2.Text = "Выберите путь к необходимому документу";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(440, 220);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(144, 23);
			this.label8.TabIndex = 17;
			this.label8.Text = "Введите дату документа";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(12, 220);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(201, 23);
			this.label11.TabIndex = 16;
			this.label11.Text = "Введите регистрационный номер";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(590, 222);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(153, 20);
			this.textBox5.TabIndex = 14;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(219, 222);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(215, 20);
			this.textBox1.TabIndex = 15;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Enabled = false;
			this.richTextBox1.Location = new System.Drawing.Point(11, 266);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(416, 53);
			this.richTextBox1.TabIndex = 13;
			this.richTextBox1.Text = "";
			// 
			// upd_doc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 646);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "upd_doc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редактирование документов";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
