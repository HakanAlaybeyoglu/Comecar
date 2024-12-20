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
        protected CheckBoxList brandCheckBoxList;
        protected CheckBoxList colorCheckBoxList;
        protected CheckBoxList fuelCheckBoxList;
        protected CheckBoxList gearCheckBoxList;
        protected CheckBoxList vehicleCheckBoxList;
        protected CheckBoxList salersCheckBoxList;

        protected void Page_Load(object sender, EventArgs e)
        {
           //
        }

        protected void Filtrele_Click(object sender, EventArgs e)
        {
            string url = "";
            // Seçilen markalar
            StringBuilder brandFilter = new StringBuilder();
            foreach (ListItem item in brandCheckBoxList.Items)

            {
                if (item.Selected)
                {
                    brandFilter.Append(item.Value);
                }
            }

            if (brandFilter.Length > 0)
            {
                // Yönlendirme URL'sini oluşturuyoruz
                url += $"get_filter.aspx?brand={brandFilter.ToString()}";
            }

            StringBuilder colorFilter = new StringBuilder();
            foreach (ListItem item in colorCheckBoxList.Items)

            {
                if (item.Selected)
                {
                    colorFilter.Append(item.Value);
                }
            }

            if (colorFilter.Length > 0)
            {
                // Yönlendirme URL'sini oluşturuyoruz
                url += $"&color={colorFilter.ToString()}";
            }

            StringBuilder fuelFilter = new StringBuilder();
            foreach (ListItem item in fuelCheckBoxList.Items)

            {
                if (item.Selected)
                {
                    fuelFilter.Append(item.Value);
                }
            }

            if (fuelFilter.Length > 0)
            {
                // Yönlendirme URL'sini oluşturuyoruz
                url += $"&fuel={fuelFilter.ToString()}";
            }

            StringBuilder gearFilter = new StringBuilder();
            foreach (ListItem item in gearCheckBoxList.Items)

            {
                if (item.Selected)
                {
                    gearFilter.Append(item.Value);
                }
            }

            if (gearFilter.Length > 0)
            {
                // Yönlendirme URL'sini oluşturuyoruz
                url += $"&gear={gearFilter.ToString()}";
            }

            StringBuilder typeFilter = new StringBuilder();
            foreach (ListItem item in vehicleCheckBoxList.Items)

            {
                if (item.Selected)
                {
                    typeFilter.Append(item.Value);
                }
            }

            if (typeFilter.Length > 0)
            {
                // Yönlendirme URL'sini oluşturuyoruz
                url += $"&type={typeFilter.ToString()}";
            }


            StringBuilder salerFilter = new StringBuilder();
            foreach (ListItem item in salersCheckBoxList.Items)

            {
                if (item.Selected)
                {
                    salerFilter.Append(item.Value);
                }
            }

            if (salerFilter.Length > 0)
            {
                // Yönlendirme URL'sini oluşturuyoruz
                url += $"&saler={salerFilter.ToString()}";
            }



            Response.Redirect(url);












            //// Diğer filtreler için benzer şekilde işlemi yapabilirsiniz
            //// Örnek olarak renk filtresi eklenmiş
            //StringBuilder colorFilter = new StringBuilder();
            //foreach (ListItem item in colorCheckBoxList.Items)
            //{
            //    if (item.Selected)
            //    {
            //        if (colorFilter.Length > 0)
            //            colorFilter.Append(" OR ");
            //        colorFilter.Append($"Color = '{item.Value}'");
            //    }
            //}
            //StringBuilder fuelFilter = new StringBuilder();
            //foreach (ListItem item in fuelCheckBoxList.Items)
            //{
            //    if (item.Selected)
            //    {
            //        if (fuelFilter.Length > 0)
            //            fuelFilter.Append(" OR ");
            //        fuelFilter.Append($"Color = '{item.Value}'");
            //    }
            //}
            //StringBuilder gearFilter = new StringBuilder();
            //foreach (ListItem item in gearCheckBoxList.Items)
            //{
            //    if (item.Selected)
            //    {
            //        if (gearFilter.Length > 0)
            //            gearFilter.Append(" OR ");
            //        gearFilter.Append($"Color = '{item.Value}'");
            //    }
            //}
            //StringBuilder vehicleFilter = new StringBuilder();
            //foreach (ListItem item in vehicleCheckBoxList.Items)
            //{
            //    if (item.Selected)
            //    {
            //        if (vehicleFilter.Length > 0)
            //            vehicleFilter.Append(" OR ");
            //        vehicleFilter.Append($"Color = '{item.Value}'");
            //    }
            //}
            //StringBuilder salersFilter = new StringBuilder();
            //foreach (ListItem item in salersCheckBoxList.Items)
            //{
            //    if (item.Selected)
            //    {
            //        if (salersFilter.Length > 0)
            //            salersFilter.Append(" OR ");
            //        salersFilter.Append($"Color = '{item.Value}'");
            //    }
            //}
            // SQL sorgusunu dinamik oluşturuyoruz
            //string sqlQuery = @"
            //        SELECT
            //            DAILY_PRICE,
            //            KILOMETRES,
            //            YEAR,
            //            V_ID,
            //            BRAND_NAME,
            //            IMAGE1
            //        FROM
            //            VEHICLES V
            //        JOIN
            //            BRANDS B ON V.BRAND_ID = B.B_ID
            //        JOIN
            //            IMAGE I ON V.IMAGE = I.I_ID";

            //if (brandFilter.Length > 0)
            //{
            //    sqlQuery += " WHERE " + brandFilter.ToString() + " ";
            //}

            //if (colorFilter.Length > 0)
            //{
            //    sqlQuery += " AND (" + colorFilter.ToString() + ")";
            //}
            //if (fuelFilter.Length > 0)
            //{
            //    sqlQuery += " AND (" + fuelFilter.ToString() + ")";
            //}
            //if (gearFilter.Length > 0)
            //{
            //    sqlQuery += " AND (" + gearFilter.ToString() + ")";
            //}
            //if (vehicleFilter.Length > 0)
            //{
            //    sqlQuery += " AND (" + vehicleFilter.ToString() + ")";
            //}
            //if (salersFilter.Length > 0)
            //{
            //    sqlQuery += " AND (" + salersFilter.ToString() + ")";
            //}


            // Diğer filtreler için de aynı şekilde koşullar ekleyebilirsiniz

            //// Veritabanına bağlanıp sorguyu çalıştırıyoruz
            //SqlConnection connection = new SqlConnection(connectionString);

            //connection.Open();
            //SqlCommand command = new SqlCommand(sqlQuery, connection);
            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    // İlk sorgudan gelen veriler
            //    string dailyPrice = reader["DAILY_PRICE"].ToString();



            //}

        }
    }
}