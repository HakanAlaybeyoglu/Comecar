using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
namespace Comecar
{
    public partial class filter : System.Web.UI.Page
    {
        // Veritabanı bağlantı dizesi
        string connectionString = "Server=DESKTOP-LI7EMTS;Database=COMECAR;Integrated Security=True;";
        private CheckBoxList brandCheckBoxList;
        private CheckBoxList colorCheckBoxList;
        private CheckBoxList fuelCheckBoxList;
        private CheckBoxList gearCheckBoxList;
        private CheckBoxList vehicleCheckBoxList;
        private CheckBoxList salersCheckBoxList;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa yüklendiğinde yapılacak işlemler
        }

        protected void Filtrele_Click(object sender, EventArgs e)
        {
            // Seçilen markalar
            StringBuilder brandFilter = new StringBuilder();
            foreach (ListItem item in brandCheckBoxList.Items)

            {
                if (item.Selected)
                {
                    if (brandFilter.Length > 0)
                        brandFilter.Append(" OR ");
                    brandFilter.Append($"Brand = '{item.Value}'");
                }
            }

            // Diğer filtreler için benzer şekilde işlemi yapabilirsiniz
            // Örnek olarak renk filtresi eklenmiş
            StringBuilder colorFilter = new StringBuilder();
            foreach (ListItem item in colorCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    if (colorFilter.Length > 0)
                        colorFilter.Append(" OR ");
                    colorFilter.Append($"Color = '{item.Value}'");
                }
            }
            StringBuilder fuelFilter = new StringBuilder();
            foreach (ListItem item in fuelCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    if (fuelFilter.Length > 0)
                        fuelFilter.Append(" OR ");
                    fuelFilter.Append($"Color = '{item.Value}'");
                }
            }
            StringBuilder gearFilter = new StringBuilder();
            foreach (ListItem item in gearCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    if (gearFilter.Length > 0)
                        gearFilter.Append(" OR ");
                    gearFilter.Append($"Color = '{item.Value}'");
                }
            }
            StringBuilder vehicleFilter = new StringBuilder();
            foreach (ListItem item in vehicleCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    if (vehicleFilter.Length > 0)
                        vehicleFilter.Append(" OR ");
                    vehicleFilter.Append($"Color = '{item.Value}'");
                }
            }
            StringBuilder salersFilter = new StringBuilder();
            foreach (ListItem item in salersCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    if (salersFilter.Length > 0)
                        salersFilter.Append(" OR ");
                    salersFilter.Append($"Color = '{item.Value}'");
                }
            }
            // SQL sorgusunu dinamik oluşturuyoruz
            string sqlQuery = "SELECT * FROM Cars WHERE 1=1";

            if (brandFilter.Length > 0)
            {
                sqlQuery += " AND (" + brandFilter.ToString() + ")";
            }

            if (colorFilter.Length > 0)
            {
                sqlQuery += " AND (" + colorFilter.ToString() + ")";
            }
            if (fuelFilter.Length > 0)
            {
                sqlQuery += " AND (" + fuelFilter.ToString() + ")";
            }
            if (gearFilter.Length > 0)
            {
                sqlQuery += " AND (" + gearFilter.ToString() + ")";
            }
            if (vehicleFilter.Length > 0)
            {
                sqlQuery += " AND (" + vehicleFilter.ToString() + ")";
            }
            if (salersFilter.Length > 0)
            {
                sqlQuery += " AND (" + salersFilter.ToString() + ")";
            }


            // Diğer filtreler için de aynı şekilde koşullar ekleyebilirsiniz

            // Veritabanına bağlanıp sorguyu çalıştırıyoruz
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Sonuçları ekrana yazdırmak için
                // Bu kısmı GridView veya başka bir kontrol ile yapabilirsiniz
                while (reader.Read())
                {
                    string carName = reader["CarName"].ToString();
                    // Veriyi ekrana veya bir listeye yazdırabilirsiniz
                    Response.Write(carName + "<br>");
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi
                Response.Write("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}