/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 02.04.2022
 * Время: 21:16
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Search
{
	partial class search_doc
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(752, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Выберите тип документа";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.comboBox1.Location = new System.Drawing.Point(12, 37);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(752, 21);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 125);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(752, 109);
			this.dataGridView1.TabIndex = 10;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 91);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(378, 20);
			this.textBox1.TabIndex = 11;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(397, 91);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(367, 20);
			this.textBox2.TabIndex = 12;
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(363, 23);
			this.label1.TabIndex = 13;
			this.label1.Text = "Начните вводить реквизиты";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(419, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(329, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Начните вводить путь к файлу";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 240);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(751, 19);
			this.label4.TabIndex = 14;
			this.label4.Text = "Для прочтения документа выберите в таблице";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(13, 283);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(751, 20);
			this.textBox3.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 258);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 16;
			this.label5.Text = "Реквизиты";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Enabled = false;
			this.richTextBox1.Location = new System.Drawing.Point(13, 330);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(751, 63);
			this.richTextBox1.TabIndex = 17;
			this.richTextBox1.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(13, 306);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Путь к файлу документа";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 409);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(751, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "Открыть документ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(13, 437);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(751, 23);
			this.button2.TabIndex = 19;
			this.button2.Text = "Открыть расположение документа";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// search_doc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 469);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "search_doc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Поиск документов";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
