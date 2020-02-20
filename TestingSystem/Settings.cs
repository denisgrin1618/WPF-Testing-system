using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Configuration;

namespace TestingSystem
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection();
            SqlCommand command = new SqlCommand();
            try
            {
                DatabaseList.Items.Clear();
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                // Обеспечивает удобный способ создания и управления содержимым строк подключения с помощью класса SqlConnection
                builder.IntegratedSecurity = true;
                builder.DataSource = ServerName.Text;
                connect.ConnectionString = builder.ConnectionString;
                connect.Open();
                command.Connection = connect;
                // Получим все БД, которые есть на выбранном сервере
                command.CommandText = "execute sp_helpdb";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string res = reader[0].ToString();
                    DatabaseList.Items.Add(res);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                command.Dispose();
                connect.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection();
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
                string connection = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", ServerName.Text, DatabaseList.SelectedItem.ToString());
                
                ConnectionStringSettings csSettings = new ConnectionStringSettings(DatabaseList.Text, connection, "System.Data.SqlClient");
                ConnectionStringsSection csSection = config.GetSection("connectionStrings") as ConnectionStringsSection;
                csSection.ConnectionStrings.Add(csSettings);
                config.Save();

                ConfigurationManager.RefreshSection("connectionStrings");
                connect.ConnectionString = connection;
                connect.Open();
                MessageBox.Show("Соединение с БД успешно установлено!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }          
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs.ConnectionString);
                    ServerName.Items.Add(builder.DataSource);
                    DatabaseList.Items.Add(builder.InitialCatalog);
                }
            }

        }
      
    }
}
