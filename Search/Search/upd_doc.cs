//формы удаления или обновления документов
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.Xml;


namespace Search
{
	public partial class upd_doc : Form
	{
		public upd_doc()
		{

			InitializeComponent();
			sel_zak();//при запуске формы осуществляется вывод всех заказчиков
			sel_user();//при запуске формы осуществляется вывод всех пользователей
			sel_doc();//при запуске формы осуществляется вывод всех документов
		}
		void sel_zak()//вывод всех заказчиков в таблицу
		{
		dataGridView2.Rows.Clear();
		DataTable dTable = new DataTable();
	    SqlConnection connection = MainForm.connect;
        connection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter("select * from Заказчик", connection);
        adapter.Fill(dTable);
        dataGridView2.DataSource=dTable;
        dataGridView2.Columns[0].Visible=false;
        //dataGridView1.Columns[4].Visible=false;
        connection.Close();
		}
		void sel_doc()//вывод всех документов в таблицу
		{
		dataGridView1.Rows.Clear();
		DataTable dTable = new DataTable();
	    SqlConnection connection = MainForm.connect;
        connection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter(@"select a.*,c.комментарий,b.*,d.*,e.роль,f.ФИО from Документ a
join Заказчик b on a.id_заказчика=b.id
join Приложение c on c.id=a.id_приложения
join Привлеченный_сотрудник d on d.id_документа=a.id
join Роль e on e.id=d.id_роли
join Сотрудник f on f.id=d.id_сотрудника", connection);
        adapter.Fill(dTable);
        dataGridView1.DataSource=dTable;
        dataGridView1.Columns[0].Visible=false;
        //dataGridView1.Columns[4].Visible=false;
        connection.Close();
		}
		
		void sel_user()//вывод всех сотрудников в таблицу
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
		
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)//выбор неоходимого документа из выпвдвющего меню
		{
		DataTable dTable = new DataTable();
	    SqlConnection connection = MainForm.connect;
        connection.Open();
        SqlDataAdapter adapter = new SqlDataAdapter("select * from "+comboBox1.Text+"", connection);
        adapter.Fill(dTable);
        dataGridView1.DataSource=dTable;
        dataGridView1.Columns[0].Visible=false;
        connection.Close();
		}
		string id_doc;string id_pril;string id_rol;string id_prs;
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)//заполнение элементов формы при выборе строки
		{
			if(e.RowIndex<0)
			{
				return;
			}
			else
			{
			id_doc = Convert.ToString(dataGridView1[0, e.RowIndex].Value);
			id_pril = Convert.ToString(dataGridView1[1, e.RowIndex].Value);
			id_rol=Convert.ToString(dataGridView1[23, e.RowIndex].Value);
			id_prs=Convert.ToString(dataGridView1[20, e.RowIndex].Value);
			id_zak=Convert.ToString(dataGridView1[2, e.RowIndex].Value);
			textBox1.Text=Convert.ToString(dataGridView1[6, e.RowIndex].Value);
			textBox5.Text=Convert.ToString(dataGridView1[5, e.RowIndex].Value);
			comboBox1.Text=Convert.ToString(dataGridView1[3, e.RowIndex].Value);
			textBox2.Text=Convert.ToString(dataGridView1[4, e.RowIndex].Value);
			textBox3.Text=Convert.ToString(dataGridView1[8, e.RowIndex].Value);
			textBox4.Text=Convert.ToString(dataGridView1[9, e.RowIndex].Value);
			checkBox1.Checked=Convert.ToBoolean(dataGridView1[10, e.RowIndex].Value);
			comboBox2.SelectedValue=Convert.ToInt32(dataGridView1[21, e.RowIndex].Value);
			textBox6.Text=Convert.ToString(dataGridView1[25, e.RowIndex].Value);
			richTextBox1.Text=Convert.ToString(dataGridView1[11, e.RowIndex].Value);
		}
		}
		
		/*
 		 * По нажатии на кнопку происходит изменение документа, при этом идет проверка что документ выбран из таблицы
		 * обновление идет в несколько этапов, сначала документ, затем приложение, затем роль и сорудник
		 * ответственный за работу. Все данные берется из элементов с формы
		 * 
		 * 
		 */	
		void Button1Click(object sender, EventArgs e)//именение документов
		{
			if(id_doc!="" && id_zak!="")
			{
			    SqlConnection connection = MainForm.connect;
		        connection.Open();
			     SqlCommand command1 = new SqlCommand(@"
update Документ set id_заказчика='"+id_zak+"', тип='"+comboBox1.Text+"',подтип='"+textBox2.Text+"',рег_номер='"+textBox1.Text+"',номер='"+textBox1.Text+"',начало_работ='"+textBox3.Text+"', конец_работ='"+textBox4.Text+"', закр_тема='"+checkBox1.Checked+"'  where id='"+id_doc+@"'
update Приложение set Комментарий='"+richTextBox1.Text+"' where id='"+id_pril+@"'
update Роль set роль='"+textBox6.Text+"' where id='"+id_rol+@"'
update Привлеченный_сотрудник set id_сотрудника="+Convert.ToInt32(comboBox2.SelectedValue)+" where id='"+id_prs+"'", connection);//передача параментров для выполнения
	             command1.ExecuteNonQuery();
	             MessageBox.Show("Документ изменен!");
	             connection.Close();
	             this.Close();
			}
			else
			{
				MessageBox.Show("Выберите документ из таблицы, и обязательно выберите заказчика!");
			}
		}
		void Button2Click(object sender, EventArgs e)//удаление документов, при этом проверка если выбран из таблицы
		{
			if(id_doc!="")
			{
			    SqlConnection connection = MainForm.connect;
		        connection.Open();
			     SqlCommand command1 = new SqlCommand("delete Документ where id='"+id_doc+"'", connection);//передача параментров для выполнения
	             command1.ExecuteNonQuery();
	             MessageBox.Show("Документ удален!");
	             connection.Close();
	             this.Close();
			}
			else
			{
				MessageBox.Show("Выберите документ из таблицы!");
			}
		}
		void Button3Click(object sender, EventArgs e)//получение пути к файлу
		{
			OpenFileDialog openFileDialog1=new OpenFileDialog();
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
	        string filename = openFileDialog1.FileName; // получаем выбранный файл
	        richTextBox1.Text = filename;
		}
		string id_zak;
		void DataGridView2CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex<0)
			{
				return;
			}
			else
			{
			id_zak = Convert.ToString(dataGridView2[0, e.RowIndex].Value);//id
			}
		}
	}
}
