//форма поиска документов
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace Search
{
	public partial class search_doc : Form
	{
		public search_doc()
		{

			InitializeComponent();
			
		}
		void TextBox1TextChanged(object sender, EventArgs e)//поиск и вывод документов с использованием нечеткго поиска
		{
		DataTable dTable = new DataTable();
	    SqlConnection connection = MainForm.connect;
        connection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Документ a join Приложение b on a.id_приложения=b.id where a.тип='"+comboBox1.Text+"' and a.рег_номер like'%"+textBox1.Text+"%' and  b.комментарий like'%"+textBox2.Text+"%'", connection);
        adapter.Fill(dTable);
        dataGridView1.DataSource=dTable;
        dataGridView1.Columns[0].Visible=false;
        dataGridView1.Columns[1].Visible=false;
        dataGridView1.Columns[2].Visible=false;
        dataGridView1.Columns[11].Visible=false;
        if(MainForm.zak=="False")
        {
        	for(int i=0;i<dataGridView1.Rows.Count;i++)
        	{
        		if(Convert.ToBoolean(dataGridView1[10,i].Value)!=Convert.ToBoolean(MainForm.zak))//проверка флагов закрытия области пользователя и документа
        		{
        		dataGridView1[5,i].Value="Данные скрыты";
        		dataGridView1[6,i].Value="Данные скрыты";
        		dataGridView1[7,i].Value="Данные скрыты";
        		dataGridView1[8,i].Value="Данные скрыты";
        		dataGridView1[9,i].Value="Данные скрыты";
        		}
        	}
        }
        connection.Close();
		}
		/*
		При выборе определенного типа из выпадающего меню осущетсвляется выгрузка всех документов в таблицу,
		при этом если значение закрытой области пользователя, который авторизировался имеет значения false, 
		а документ имеет закрытую область (true), то часть значений по документу будут скрыты сообщением "Данные скрыты"
		*/
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)//вывод всех документов по типу 
		{
		DataTable dTable = new DataTable();
	    SqlConnection connection = MainForm.connect;
        connection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Документ a join Приложение b on a.id_приложения=b.id where a.тип='"+comboBox1.Text+"' and a.рег_номер like'%"+textBox1.Text+"%' and  b.комментарий like'%"+textBox2.Text+"%'",connection);
        adapter.Fill(dTable);
        dataGridView1.DataSource=dTable;
        dataGridView1.Columns[0].Visible=false;
        dataGridView1.Columns[1].Visible=false;
        dataGridView1.Columns[2].Visible=false;
        dataGridView1.Columns[11].Visible=false;
        if(MainForm.zak=="False")
        {
        	for(int i=0;i<dataGridView1.Rows.Count;i++)
        	{
        		if(Convert.ToBoolean(dataGridView1[10,i].Value)!=Convert.ToBoolean(MainForm.zak))//проверка флагов закрытия области пользователя и документа
        		{
        		dataGridView1[5,i].Value="Данные скрыты";
        		dataGridView1[6,i].Value="Данные скрыты";
        		dataGridView1[7,i].Value="Данные скрыты";
        		dataGridView1[8,i].Value="Данные скрыты";
        		dataGridView1[9,i].Value="Данные скрыты";
        		}
        	}
        }
        connection.Close();
		}
		/*
		 *При нажатии на любую строку в таблице 
		 *заполняюся элемент рег номер документа
		 * и путь к файлу	  
		 */
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex<0)
			{
				return;
			}
			else
			{
			textBox3.Text=Convert.ToString(dataGridView1[6, e.RowIndex].Value);
			richTextBox1.Text=Convert.ToString(dataGridView1[12, e.RowIndex].Value);
			}
		}
		void Button1Click(object sender, EventArgs e)//сохранение выбраного документа (сохраняется в папку с программой(.\bin\))
		{	
			if(richTextBox1.Text!="")
			{
				Process.Start(@""+richTextBox1.Text+"");
			}
			else
			{
				MessageBox.Show("Не выбран документ!");
			}
		}
		void Button2Click(object sender, EventArgs e)//запуск документа
		{
			if(richTextBox1.Text!="")
			{
			Process.Start(@"explorer.exe", "/select, \""+richTextBox1.Text+"");
			}
			else
			{
				MessageBox.Show("Не выбран документ!");
			}	
		}
	}
}
