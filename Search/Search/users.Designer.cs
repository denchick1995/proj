/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 02.04.2022
 * Время: 13:52
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Search
{
	partial class users
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		
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
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(8, 160);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(616, 203);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(324, 395);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(296, 20);
			this.textBox2.TabIndex = 7;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 395);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(282, 20);
			this.textBox1.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(12, 421);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(213, 73);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Работа с закрытой темой";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(7, 43);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(115, 24);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Нет";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(7, 17);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(102, 24);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Да";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(232, 426);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(392, 32);
			this.button2.TabIndex = 10;
			this.button2.Text = "Изменить пользователя";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(231, 464);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(393, 30);
			this.button3.TabIndex = 10;
			this.button3.Text = "Удалить пользователя";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(616, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "При необходимости выберите пользователя из таблицы для его редактирования";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(192, 57);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(428, 73);
			this.button4.TabIndex = 17;
			this.button4.Text = "Добавить нового пользователя";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Location = new System.Drawing.Point(8, 57);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(178, 73);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Работа с закрытой темой";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(7, 43);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(115, 24);
			this.radioButton3.TabIndex = 1;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Нет";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(7, 17);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(102, 24);
			this.radioButton4.TabIndex = 0;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Да";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(320, 31);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(300, 20);
			this.textBox3.TabIndex = 15;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(8, 31);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(282, 20);
			this.textBox4.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(320, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(282, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "Должность";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(8, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(282, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "ФИО";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(325, 368);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(282, 23);
			this.label1.TabIndex = 19;
			this.label1.Text = "Должность";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(13, 369);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(282, 23);
			this.label2.TabIndex = 18;
			this.label2.Text = "ФИО";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// users
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 501);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "users";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Работа с сотрудниками базы данных";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
