/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 02.04.2022
 * Время: 20:34
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Search
{
	partial class doc
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.CheckBox checkBox1;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(220, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(215, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Введите регистрационный номер";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(734, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Выберите путь к необходимому документу";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(9, 371);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(735, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
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
			this.comboBox1.Location = new System.Drawing.Point(177, 111);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(567, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Выберите тип документа";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(9, 400);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(735, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Открыть форму для редактирования или удаления";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Enabled = false;
			this.richTextBox1.Location = new System.Drawing.Point(12, 52);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(416, 53);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(434, 52);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(312, 53);
			this.button3.TabIndex = 7;
			this.button3.Text = "Выбрать путь";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(11, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Введите подтип документа";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(177, 143);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(567, 20);
			this.textBox2.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(732, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Выберите заказчика";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 199);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(731, 84);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(160, 293);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(208, 20);
			this.textBox3.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 290);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(124, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Введите начало работ";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(536, 293);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(208, 20);
			this.textBox4.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(394, 291);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Введите конец работ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(591, 8);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(153, 20);
			this.textBox5.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(441, 6);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(144, 23);
			this.label8.TabIndex = 2;
			this.label8.Text = "Введите дату документа";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(293, 335);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(141, 21);
			this.comboBox2.TabIndex = 4;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(167, 325);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(120, 40);
			this.label9.TabIndex = 5;
			this.label9.Text = "Выберите сотрудника";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(441, 324);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(148, 40);
			this.label10.TabIndex = 5;
			this.label10.Text = "Введите роль сотрудника";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(594, 335);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(149, 20);
			this.textBox6.TabIndex = 10;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(12, 335);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(139, 24);
			this.checkBox1.TabIndex = 12;
			this.checkBox1.Text = "Закрытая тема";
			this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// doc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 431);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.richTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "doc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Работа с документами";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
