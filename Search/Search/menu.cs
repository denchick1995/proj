using System;
using System.Drawing;
using System.Windows.Forms;

namespace Search
{

	public partial class menu : Form
	{
		public menu()
		{

			InitializeComponent();
			

		}
		void Button1Click(object sender, EventArgs e)
		{
			users us=new users();//открытие формы пользователей
			us.ShowDialog();
		}
		void Button2Click(object sender, EventArgs e)
		{
			doc docum=new doc();//открытие формы работы с документами
			docum.ShowDialog();
		}
		void Button4Click(object sender, EventArgs e)
		{
			search_doc f=new search_doc();//открытие формы поиска
			f.ShowDialog();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();//закрытие программы
		}
		void Button5Click(object sender, EventArgs e)
		{
			organization org=new organization();//открытие формы заказчика
			org.ShowDialog();
		}
	}
}
