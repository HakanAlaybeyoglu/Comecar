using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comecar
{
    public partial class get_filter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // QueryString'den filtre parametrelerini alıyoruz
            string brand = Request.QueryString["brand"];
            string color = Request.QueryString["color"];
            string fuel = Request.QueryString["fuel"];
            string gear = Request.QueryString["gear"];
            string type = Request.QueryString["type"];
            string saler = Request.QueryString["saler"];

            if (!IsPostBack) // Sayfa sadece ilk kez yüklendiğinde çalışacak
            {
                string connectionString = "Server=DESKTOP-8D8OQ9R;Database=COMECAR;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Ana SQL sorgusu
                    string sqlQuery = @"
                SELECT
                    DAILY_PRICE,
                    KILOMETRES,
                    YEAR,
                    V_ID,
                    BRAND_NAME,
                    COLOUR_NAME,
                    IMAGE1
                FROM
                    VEHICLES V
                JOIN
                    BRANDS B ON V.BRAND_ID = B.B_ID
                JOIN
                    COLOURS C ON V.COLOURS_ID = C.C_ID
                JOIN
                    IMAGE I ON V.IMAGE = I.I_ID
                JOIN
                    FUEL_TYPE F ON V.FUEL_TYPE = F.FT_ID
                JOIN
                    GEAR_TYPE G ON V.GEAR_TYPE = G.GT_ID
                JOIN
                    VEHICLE_TYPE T ON V.VEHICLE_TYPE = T.VT_ID
                JOIN
                    SALERS S ON V.SALER_ID = S.S_ID";

                    // WHERE koşullarını dinamik olarak oluştur
                    List<string> conditions = new List<string>();
                    SqlCommand filterCommand = new SqlCommand();
                    filterCommand.Connection = conn;

                    // Brand kontrolü
                    if (!string.IsNullOrEmpty(brand))
                    {
                        conditions.Add("B.B_ID = @brand");
                        filterCommand.Parameters.AddWithValue("@brand", brand);
                    }

                    // Color kontrolü
                    if (!string.IsNullOrEmpty(color))
                    {
                        conditions.Add("C.C_ID = @color");
                        filterCommand.Parameters.AddWithValue("@color", color);
                    }

                    // Fuel kontrolü
                    if (!string.IsNullOrEmpty(fuel))
                    {
                        conditions.Add("F.FT_ID = @fuel");
                        filterCommand.Parameters.AddWithValue("@fuel", fuel);
                    }

                    // Gear kontrolü
                    if (!string.IsNullOrEmpty(gear))
                    {
                        conditions.Add("G.GT_ID = @gear");
                        filterCommand.Parameters.AddWithValue("@gear", gear);
                    }

                    // Type kontrolü
                    if (!string.IsNullOrEmpty(type))
                    {
                        conditions.Add("T.VT_ID = @type");
                        filterCommand.Parameters.AddWithValue("@type", type);
                    }

                    // Saler kontrolü
                    if (!string.IsNullOrEmpty(saler))
                    {
                        conditions.Add("S.S_ID = @saler");
                        filterCommand.Parameters.AddWithValue("@saler", saler);
                    }

                    // WHERE koşullarını sorguya ekle
                    if (conditions.Count > 0)
                    {
                        sqlQuery += " WHERE " + string.Join(" AND ", conditions);
                    }

                    filterCommand.CommandText = sqlQuery;

                    // Sorguyu çalıştır ve sonuçları al
                    SqlDataReader filterReader = filterCommand.ExecuteReader();
                    while (filterReader.Read())
                    {
                        string dailyPrice = filterReader["DAILY_PRICE"].ToString();
                        string kilometres = filterReader["KILOMETRES"].ToString();
                        string year = filterReader["YEAR"].ToString();
                        string vehicleId = filterReader["V_ID"].ToString();
                        string brandName = filterReader["BRAND_NAME"].ToString();
                        string colorName = filterReader["COLOUR_NAME"].ToString();
                        string image = filterReader["IMAGE1"].ToString();

                        // HTML kartını oluştur
                        string cardHtml = $@"
                                                    
                         <div class='card d-flex flex-row align-items-center mb-3' style='border: 1px solid #ddd; padding: 10px;'>
                        <div class='card-image' style='width: 200px; margin-right: 20px;'>
                            <img src='{image}' alt='{brandName} {colorName}' class='img-fluid' style='width: 100%; height: auto;' />
                        </div>
                        <div class='card-body' style='flex: 1;'>
                            <h3 class='card-title'>{brandName} {colorName} ({year})</h3>
                            <p class='card-text'>
                                <strong>Price:</strong> {dailyPrice} <br />
                                <strong>Kilometres:</strong> {kilometres} <br />
                                <strong>Year:</strong> {year}
                            </p>
                        </div>
                        <div class='card-button' style='margin-left: auto;'>
                            <a href='car_profile.aspx?id={vehicleId}' class='btn btn-secondary' tabindex='-1' role='button' aria-disabled='true'>Details</a>
                        </div>
                    </div>";

                        // Placeholder'a HTML ekle
                        filterPlaceholder.Controls.Add(new LiteralControl(cardHtml));
                    }
                    filterReader.Close();
                }
            }
        }
    }


}