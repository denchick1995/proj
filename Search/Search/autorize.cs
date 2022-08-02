//код для формы "Авторизация"
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
	public partial class MainForm : Form
	{
		public static SqlConnection connect;
		public MainForm()
		{

			InitializeComponent();
			connect = connection();//Передача переменной значения подключения к БД
			connect.Open();
            if (connect.State==ConnectionState.Open)//Проверка соединения с БД
            {
            	label3.ForeColor=Color.Green;
            	label3.Text="Соединение с БД установлено!";
            }
            else
            {
            	label3.ForeColor=Color.Red;
            	label3.Text="Соединение с БД не установлено!";
            }
            connect.Close();
		}
		
		 SqlConnection connection()//строка подключения к базе данных (здесь можно заменить хост и инстанс подключения)
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = @"server ='localhost\SQLEXPRESS';Integrated Security=true;Initial Catalog='Документация'";
            return connect;
        }
		 public static string zak;
		 /*
		 При нажатии на кнопку нижепроисходит вход в систему (под админом с паролем, либо просто по ФИО без пароля, так как хранение пароля в таблице не предусмотрено), при этом дополнительно в переменную zak
		 осуществляется запись значения (true, false) имеет ли сотрудник доступ к закрытой области в документе
		 (в дальнейшем эта переменная используеся на форме поиска "search_doc.cs".)
		 */
		 void Button1Click(object sender, EventArgs e)//вход в базу данных (авторизация)
		{
		 	SqlConnection connection1 = connect;
            connection1.Open();//открытие соединения
            string sql = "select ФИО,закрыт_тема from Сотрудник where upper(ФИО)='"+textBox1.Text.ToUpper()+"'";//проверка что админ имеется в БД
             SqlCommand command1 = new SqlCommand(sql, connection1);//передача параментров для выполнения
             SqlDataReader dataReader1 = command1.ExecuteReader();//выполнение запроса
             while (dataReader1.Read())//получение результата запроса
                {
             	if (dataReader1[0].ToString()=="admin" && textBox2.Text=="admin")//проверка авторизации администратором
             	{
             		MessageBox.Show("Вы вошли как администратор!");//вывод диалога
             		this.Hide();
             		menu m=new menu();
             		m.button1.Enabled=true;//показ кнопок на форме меню
             		m.button2.Enabled=true;//показ кнопок на форме меню
             		m.button5.Enabled=true;//показ кнопок на форме меню
             		m.button4.Enabled=true;//показ кнопок на форме меню
             		m.Show();//открытие формы для админа (для админа доступны все кнопки)
             	}
             	else if(dataReader1[0].ToString()!="admin" || textBox1.Text!="admin" || textBox2.Text=="")//вход обычным сотрудником
             	{
             		zak=dataReader1[1].ToString();
             		MessageBox.Show("Вы вошли как обычный сотрудник! Редактирование записей недоступно!");//вывод диалога
             		this.Hide();
             		menu m=new menu();
             		m.button4.Enabled=true;//показ кнопок на форме меню
             		m.Show();//открытие формы для пользователя (доступна кнопка поиска)
             	}
                }
             connection1.Close();
		}
		 
		
		void Button2Click(object sender, EventArgs e)//кнопка выхода из приложения
		{
			Application.Exit();//закрыть приложение
		}
		
	}
}
