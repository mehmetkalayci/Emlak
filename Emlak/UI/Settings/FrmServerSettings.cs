using Emlak.Model;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.UI.Settings
{
    public partial class FrmServerSettings : BaseForm
    {
        public FrmServerSettings()
        {
            InitializeComponent();
        }

        public static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<string> GetDatabaseList(string connectionString)
        {
            List<string> list = new List<string>();

            // Open connection to the database
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                // Set up a command with the given query and associate
                // this with the current connection.
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", sqlConnection))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }
            }
            return list;

        }


        string connectionString = "";
        private void btnConnectionCheck_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                Authentication = SqlAuthenticationMethod.SqlPassword,
                UserID = txtUser.Text,
                Password = txtPass.Text,
                DataSource = txtServer.Text,
                //InitialCatalog = comboBoxDbs.Text,
                TrustServerCertificate = true,
                ConnectTimeout = 60
            };

            try
            {
                bool status = IsServerConnected(sqlConnectionStringBuilder.ConnectionString);
                if (status)
                {
                    connectionString = sqlConnectionStringBuilder.ConnectionString;
                    MessageBox.Show("Bağlantı başarılı!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    List<string> dbs = GetDatabaseList(sqlConnectionStringBuilder.ConnectionString);
                    comboBoxDbs.Items.Clear();
                    comboBoxDbs.Items.AddRange(dbs.ToArray());
                    comboBoxDbs.DroppedDown = true;
                }
                else
                {
                    MessageBox.Show("Sunucuya bağlanıldı. Ancak bilgiler sorunlu görünüyor!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                Authentication = SqlAuthenticationMethod.SqlPassword,
                UserID = txtUser.Text,
                Password = txtPass.Text,
                DataSource = txtServer.Text,
                InitialCatalog = comboBoxDbs.Text,
                TrustServerCertificate = true,
                ConnectTimeout = 60
            };

            try
            {
                bool status = IsServerConnected(sqlConnectionStringBuilder.ConnectionString);
                if (status)
                {
                    connectionString = sqlConnectionStringBuilder.ConnectionString;
                    MessageBox.Show("Bağlantı başarılı!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

                    // ef connection string ayarla
                    var entityConnectionStringBuilder = new EntityConnectionStringBuilder();
                    entityConnectionStringBuilder.Provider = "System.Data.SqlClient";
                    entityConnectionStringBuilder.ProviderConnectionString = sqlConnectionStringBuilder.ConnectionString;
                    entityConnectionStringBuilder.Metadata = "res://*/Model.ModelEmlak.csdl|res://*/Model.ModelEmlak.ssdl|res://*/Model.ModelEmlak.msl";


                    connectionStringsSection.ConnectionStrings["EmlakEntities"].ConnectionString = entityConnectionStringBuilder.ToString();
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");

                    MessageBox.Show("Ayarlar kaydedildi.\nAyarların yansıtılması için uygulama yeniden başlatılacak!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
                {
                    Authentication = SqlAuthenticationMethod.SqlPassword,
                    UserID = txtUser.Text,
                    Password = txtPass.Text,
                    DataSource = txtServer.Text,
                    TrustServerCertificate = true,
                    ConnectTimeout = 60
                };

                SqlConnection con = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("select name from sys.databases", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string[] array = dt
                    .AsEnumerable()
                    .Select(row => row.Field<string>("Name"))
                    .ToArray();

                if (!array.Contains("Emlak", StringComparer.OrdinalIgnoreCase))
                {
                    DialogResult dialogResult = openFileDialog1.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        SqlCommand cmd = new SqlCommand("sp_attach_db");
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@dbname", "Emlak");
                        cmd.Parameters.AddWithValue("@filename1", openFileDialog1.FileName);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Veritabanı tanımı tamamlandı!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Veritabanı dosyanızı seçmediğiniz için işlem iptal edildi!", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Emlak adında zaten bir veritabanı tanımı var!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetachDb_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
                {
                    Authentication = SqlAuthenticationMethod.SqlPassword,
                    UserID = txtUser.Text,
                    Password = txtPass.Text,
                    DataSource = txtServer.Text,
                    TrustServerCertificate = true,
                    ConnectTimeout = 60
                };

                SqlConnection con = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("select name from sys.databases", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string[] array = dt
                    .AsEnumerable()
                    .Select(row => row.Field<string>("Name"))
                    .ToArray();

                if (array.Contains("Emlak", StringComparer.OrdinalIgnoreCase))
                {
                        SqlCommand cmd = new SqlCommand("sp_detach_db");
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@dbname", "Emlak");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Veritabanı bağlantısı kesildi!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Emlak bir veritabanı zaten yok!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmServerSettings_Load(object sender, EventArgs e)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

                txtConnectionString.Text = connectionStringsSection.ConnectionStrings["EmlakEntities"].ConnectionString;
            }
            catch
            {
            }
        }
    }
}
