using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test__Task
{
	public	class Product
	{
		public string Name_product { get; set; }
		public string Price_product { get; set; }
		public string Name_Categories { get; set; }
		public string UID_Categories { get; set; }


		public static List<Product> Get_data(int flags)
		{
			List<Product> Result = new List<Product>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=testBD;Integrated Security=True";
			try
			{
				conn.Open();
				SqlCommand cmd;

				cmd = new SqlCommand();
				cmd.Connection = conn;
				cmd.CommandType = CommandType.StoredProcedure;
				switch (flags)
				{

					case 0:
						cmd.CommandText = "LEFT_OUTER_JOIN";
						break;
					case 1:
						cmd.CommandText = "RIGHT_OUTER_JOIN";
						break;
					case 2:
						cmd.CommandText = "FULL_OUTER_JOIN";
						break;
					case 3:
						cmd.CommandText = "LEFT_OUTER_JOIN_is_NULL";
						break;
					case 4:
						cmd.CommandText = "RIGHT_OUTER_JOIN_is_NULL";
						break;
					case 5:
						cmd.CommandText = "UNION_ALL";
						break;

				}

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					Product Et_element = new Product();
					Et_element.Name_product = Convert.ToString(reader["Name_product"]);
					Et_element.Price_product = Convert.ToString(reader["Price_product"]);
					Et_element.Name_Categories = Convert.ToString(reader["Name_Categories"]);
					Et_element.UID_Categories = Convert.ToString(reader["Categories"]);
					Result.Add(Et_element);
				}
				conn.Close();
			}
			catch(Exception e)
			{
				conn.Close();
				MessageBox.Show(e.Message.ToString());
			}
			return Result;

		}
	}
}
