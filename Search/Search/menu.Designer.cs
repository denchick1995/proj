/*
 * Создано в SharpDevelop.
 * Пользователь: User
 * Дата: 02.04.2022
 * Время: 13:41
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace Search
{
	partial class menu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		public System.Windows.Forms.Button button4;
		public System.Windows.Forms.Button button5;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(11, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(234, 48);
			this.button1.TabIndex = 0;
			this.button1.Text = "Работа с сотрудниками \r\nбазы данных";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(11, 123);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(234, 44);
			this.button2.TabIndex = 2;
			this.button2.Text = "Работа с документами базы данных";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(11, 223);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(232, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "ВЫХОД";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(11, 173);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(234, 44);
			this.button4.TabIndex = 3;
			this.button4.Text = "Поиск документации";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(11, 66);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(234, 48);
			this.button5.TabIndex = 1;
			this.button5.Text = "Работа с заказчиками";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(264, 262);
			this.ControlBox = false;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Главное меню";
			this.ResumeLayout(false);

		}
	}
}
