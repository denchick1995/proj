using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace Search
{
	public partial class users : Form
	{
		public users()
		{
			InitializeComponent();
			sel_user();
		}
		
		
		void sel_user()//вывод всех пользователей в таблицу, за исключением админа
		{
		dataGridView1.Rows.Clear();
		DataTable dTable = new DataTable();
	    SqlConnection connection = MainForm.connect;
        connection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Сотрудник where ФИО <>'admin'", connection);
        adapter.Fill(dTable);
        dataGridView1.DataSource=dTable;
        dataGridView1.Columns[0].Visible=false;
        //dataGridView1.Columns[4].Visible=false;
        for(int i=0;i<dataGridView1.Rows.Count;i++)
			{	
        	if(Convert.ToString(dataGridView1[3,i].Value)=="0") dataGridView1[3,i].Value="да";
        	if (Convert.ToString(dataGridView1[3,i].Value)=="1") dataGridView1[3,i].Value="нет";
			}
        connection.Close();
		}
		/*
		 * По нажатию кнопки происходит добавление пользователя
		 * при этот идет проверка, что все данные заполнены
		 * 
		 */
		void Button4Click(object sender, EventArgs e)//добавление пользователя
		{
			
			if (textBox3.Text=="" || textBox4.Text=="" || (radioButton3.Checked==false && radioButton4.Checked==false))
			{
				MessageBox.Show("Заполните все поля!");
			}
			else
			{
			string flag="";
			if (radioButton3.Checked==true)  flag="0";//работа с закрытой темой (да)
			if (radioButton4.Checked==true)  flag="1";//работа с закрытой темой (нет)
			SqlConnection connection1 = MainForm.connect;
            connection1.Open();//открытие соединения
            string sql = "insert into Сотрудник values('"+textBox4.Text+"','"+textBox3.Text+"','"+flag+"')";
             SqlCommand command1 = new SqlCommand(sql, connection1);//передача параментров для выполнения
             command1.ExecuteNonQuery();
             MessageBox.Show("Сотрудник добавлен!");
             connection1.Close();
             textBox3.Text="" ; textBox4.Text="" ; radioButton3.Checked=false; radioButton4.Checked=false;
             this.Close();
			}
			
		}
		
		string id_user;
		/*
		 * ПО нажатии из таблицы выводятся и заполняются определенные элементы
		 * 
		 */ 
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)//при выборе пользователя данные переносятся в нужные элементы формы
		{
				if(e.RowIndex<0)
			{
				return;
			}
			else
			{
			id_user = Convert.ToString(dataGridView1[0, e.RowIndex].Value);//id артикула
			textBox1.Text=Convert.ToString(dataGridView1[1, e.RowIndex].Value);
			textBox2.Text=Convert.ToString(dataGridView1[2, e.RowIndex].Value);
			if(Convert.ToString(dataGridView1[3, e.RowIndex].Value)=="True")radioButton1.Checked=true;
			if(Convert.ToString(dataGridView1[3, e.RowIndex].Value)=="False") radioButton2.Checked=true;
		}
	}
		/*
		 * По нажатию кнопки происходит изменение пользователя
		 * при этом идет проверка, что все пользователь выбран заполнены
		 * 
		 */
		void Button2Click(object sender, EventArgs e)//изменение пользователя
		{
			if(id_user!="")
			{
			string flag="";
			if (radioButton2.Checked==true)  flag="0";//закр_тема (да)
			if (radioButton1.Checked==true)  flag="1";//закр_тема (нет)
			SqlConnection connection1 = MainForm.connect;
            connection1.Open();//открытие соединения
            string sql = "update Сотрудник set ФИО='"+textBox1.Text+"', должность='"+textBox2.Text+"', закрыт_тема='"+flag+"' where id='"+id_user+"'";
             SqlCommand command1 = new SqlCommand(sql, connection1);//передача параментров для выполнения
             command1.ExecuteNonQuery();
             MessageBox.Show("Сотрудник обновлен!");
             connection1.Close();
             textBox3.Text="" ; textBox4.Text="" ; radioButton3.Checked=false; radioButton4.Checked=false;
             this.Close();
			}
			else
			{
				MessageBox.Show("Выберите сотрудника из таблицы!");
			}
		}
		void Button3Click(object sender, EventArgs e)//удаление пользователя
		{
			if(id_user!="")
			{
			SqlConnection connection1 = MainForm.connect;
            connection1.Open();//открытие соединения
            string sql = "delete Сотрудник where id='"+id_user+"'";
             SqlCommand command1 = new SqlCommand(sql, connection1);//передача параментров для выполнения
             command1.ExecuteNonQuery();
             MessageBox.Show("Сотрудник удален и все назначенные для его работы документы!");
             connection1.Close();
             textBox3.Text="" ; textBox4.Text="" ; radioButton3.Checked=false; radioButton4.Checked=false;
             this.Close();
			}
			else
			{
				MessageBox.Show("Выберите сотрудника из таблицы!");
			}
		}
}
}
