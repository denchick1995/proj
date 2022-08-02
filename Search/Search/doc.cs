//форма добавления документов
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace Search
{
	public partial class doc : Form
	{
		public doc()
		{

			InitializeComponent();
			sel_zak();
			sel_user();
		}
		
		void sel_zak()//вывод всех заказчиков в таблицу
		{
		dataGridView1.Rows.Clear();
		DataTable dTable = new DataTable();
	    SqlConnection connection = MainForm.connect;
        connection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Заказчик", connection);
        adapter.Fill(dTable);
        dataGridView1.DataSource=dTable;
        dataGridView1.Columns[0].Visible=false;
        //dataGridView1.Columns[4].Visible=false;
        connection.Close();
		}
		
		void sel_user()//вывод всех заказчиков в таблицу
		{
		DataTable dTable = new DataTable();
	    SqlConnection connection = MainForm.connect;
        connection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Сотрудник", connection);
        adapter.Fill(dTable);
        comboBox2.DataSource=dTable;
        comboBox2.DisplayMember="ФИО";
        comboBox2.ValueMember="id";
        connection.Close();
		}
		/*По нажатии на кнопку происходит добавление документа, при этом идет проверка что все данные заполнены
		 * добавление идет в несколько этапов, сначала для добавление приложение, затем документ, затем роль и сорудник
		 * ответственный за работу
		 * 
		 * 
		 */		
		void Button1Click(object sender, EventArgs e)//добавление документов
		{
			if (textBox1.Text=="" || richTextBox1.Text=="" || comboBox1.Text=="" || textBox5.Text=="" || textBox2.Text=="" || textBox3.Text=="" || textBox4.Text=="" || textBox6.Text=="")
			{
				MessageBox.Show("Заполните все поля, а также проверьте, что путь к файлу выбран!");
			}
			else
			{
			SqlConnection connection1 = MainForm.connect;
            connection1.Open();//открытие соединения
            string sql = @"insert into Приложение values('"+richTextBox1.Text+@"')
insert into Документ values((select max(id) from Приложение),'"+id_zak+"','"+comboBox1.Text+"','"+textBox2.Text+"','"+textBox5.Text+"','"+textBox1.Text+"','"+textBox1.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+checkBox1.Checked+@"')
insert into Роль values('"+textBox6.Text+@"')
insert into Привлеченный_сотрудник values("+Convert.ToInt32(comboBox2.SelectedValue)+",(select max(id) from Документ),(select max(id) from Роль),'назначен')";
             SqlCommand command1 = new SqlCommand(sql, connection1);//передача параментров для выполнения
             command1.ExecuteNonQuery();
             MessageBox.Show("Документ добавлен!");
             connection1.Close();
             this.Close();
			}
		}
		void Button2Click(object sender, EventArgs e)//открытие формы обновления документов
		{
			upd_doc f=new upd_doc();
			f.ShowDialog();
		}
		/*
		 * ПО нажатию на кнопку происходит получение пути к файлу
		 */ 
		void Button3Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1=new OpenFileDialog();
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
	        string filename = openFileDialog1.FileName; // получаем выбранный файл
	        richTextBox1.Text = filename;
		}
		
		string id_zak;
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex<0)
			{
				return;
			}
			else
			{
			id_zak = Convert.ToString(dataGridView1[0, e.RowIndex].Value);//id
			}
		}
	}
}
