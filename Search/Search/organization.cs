//код для формы "Организации"
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;


namespace Search
{
	public partial class organization : Form
	{
		public organization()
		{
			InitializeComponent();
			sel_zak();//при открытии программы осуществляется вывод всех заказчиков в таблицу
		}
		
		
		/*
		 * По нажатию на эту кнопку осуществляется добавление заказчиков, при этом осуществляется проверка, 
         * что все ли данные заполнены, в конце соединение закрывается
		 */
		void Button4Click(object sender, EventArgs e)
		{
			if (textBox3.Text=="" || textBox4.Text=="" || textBox5.Text=="" || textBox6.Text=="" || textBox7.Text=="" || textBox8.Text=="" || textBox9.Text=="")
			{
				MessageBox.Show("Заполните все поля!");
			}
			else
			{
			SqlConnection connection1 = MainForm.connect;
            connection1.Open();//открытие соединения
            string sql = "insert into Заказчик values('"+textBox4.Text+"','"+textBox3.Text+"','"+textBox5.Text+"','"+textBox8.Text+"','"+textBox9.Text+"','"+textBox7.Text+"','"+textBox6.Text+"')";
             SqlCommand command1 = new SqlCommand(sql, connection1);//передача параментров для выполнения
             command1.ExecuteNonQuery();
             MessageBox.Show("Заказчик добавлен добавлен!");
             connection1.Close();
             this.Close();
			}
		}
		
		void sel_zak()// функция вывода всех заказчиков в таблицу
		{
		dataGridView1.Rows.Clear();
		DataTable dTable = new DataTable();
	    SqlConnection connection = MainForm.connect;
        connection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Заказчик", connection);
        adapter.Fill(dTable);
        dataGridView1.DataSource=dTable;
        dataGridView1.Columns[0].Visible=false;//скрытие столбца ID
        connection.Close();
		}
		
		string id_zak;
		/*
		 * При нажатии на любую строку осущетвляется получение id заказчика
		 * заполнение всех элементов для их редактирования
		 * 
		 * 
		 */ 
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex<0)
			{
				return;
			}
			else
			{
			id_zak = Convert.ToString(dataGridView1[0, e.RowIndex].Value);//id
			textBox14.Text=Convert.ToString(dataGridView1[1, e.RowIndex].Value);
			textBox13.Text=Convert.ToString(dataGridView1[2, e.RowIndex].Value);
			textBox12.Text=Convert.ToString(dataGridView1[3, e.RowIndex].Value);
			textBox2.Text=Convert.ToString(dataGridView1[4, e.RowIndex].Value);
			textBox1.Text=Convert.ToString(dataGridView1[5, e.RowIndex].Value);
			textBox10.Text=Convert.ToString(dataGridView1[6, e.RowIndex].Value);
			textBox11.Text=Convert.ToString(dataGridView1[7, e.RowIndex].Value);
		}
		}
		/*
		 * По нажатию кнопки происходит обновление записи заказчика 
		 * но при условии что он обязательно выбран из таблицы (получен его id)
		 * 
		 */ 
		void Button2Click(object sender, EventArgs e)
		{
			if(id_zak!="")
			{
			SqlConnection connection1 = MainForm.connect;
            connection1.Open();//открытие соединения
            string sql = "update Заказчик set ИНН='"+textBox14.Text+"',КПП='"+textBox13.Text+"',р_c='"+textBox12.Text+"',юр_адрес='"+textBox2.Text+"',почт_адрес='"+textBox1.Text+"',банк='"+textBox10.Text+"',к_с='"+textBox11.Text+"' where id='"+id_zak+"'";
             SqlCommand command1 = new SqlCommand(sql, connection1);//передача параментров для выполнения
             command1.ExecuteNonQuery();
             MessageBox.Show("Заказчик обновлен!");
             connection1.Close();
             this.Close();
			}
			else
			{
				MessageBox.Show("Выберите сотрудника из таблицы!");
			}
		}
		/*
		 * По нажатию кнопки происходит удаление записи заказчика 
		 * но при условии что он обязательно выбран из таблицы (получен его id)
		 * 
		 */ 
		void Button3Click(object sender, EventArgs e)
		{
			if(id_zak!="")
			{
			SqlConnection connection1 = MainForm.connect;
            connection1.Open();//открытие соединения
            string sql = "delete Заказчик where id='"+id_zak+"'";
             SqlCommand command1 = new SqlCommand(sql, connection1);//передача параментров для выполнения
             command1.ExecuteNonQuery();
             MessageBox.Show("Заказчик и все его документы удалены!");
             connection1.Close();
             this.Close();
			}
			else
			{
				MessageBox.Show("Выберите заказчика из таблицы!");
			}	
		}
	}
}
