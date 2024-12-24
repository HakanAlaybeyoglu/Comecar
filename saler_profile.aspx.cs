using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Comecar
{
    public partial class saler_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //istekten gelen querydeki (indexteki) stringi alıyor 
            string id = Request.QueryString["id"];
            if (!IsPostBack) // Sayfa ilk kez yüklendiğinde çalışacak
            {
                // Veritabanına bağlanarak verileri çekme
                string connectionString = "Server=DESKTOP-8D8OQ9R;Database=COMECAR;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Satıcı bilgilerini çekme
                    string salerQuery = @"
                        SELECT FULL_NAME, EMAIL, PHONE_NUM
                        FROM SALERS
                        WHERE S_ID = @id";
                    SqlCommand salerCommand = new SqlCommand(salerQuery, conn);
                    salerCommand.Parameters.AddWithValue("@id", id);

                    SqlDataReader salerReader = salerCommand.ExecuteReader();
                    if (salerReader.Read())
                    {
                        string salerName = salerReader["FULL_NAME"].ToString();
                        string salerEmail = salerReader["EMAIL"].ToString();
                        string salerPhone = salerReader["PHONE_NUM"].ToString();

                        // Satıcı bilgileri için HTML oluştur
                        string salerInfoHtml = $@"
                            <div class='saler-info'>
                                <h4>Seller Information</h4>
                                <p><strong>Name:</strong> {salerName}</p>
                                <p><strong>Phone Number:</strong> {salerPhone}</p>
                                <p><strong>E-mail:</strong> {salerEmail}</p>
                                
                            </div>";

                        // Left Menu'ye ekle
                        leftMenu.Controls.Add(new LiteralControl(salerInfoHtml));
                    }
                    salerReader.Close();

                    // 2. Araç bilgilerini çekme
                    string vehicleQuery = @"
                        SELECT
                            DAILY_PRICE,
                            KILOMETRES,
                            YEAR,
                            V_ID,
                            BRAND_NAME,
                            COLOUR_NAME,
                            IMAGE1,
                            SALER_ID
                        FROM
                            VEHICLES V
                        JOIN
                            BRANDS B ON V.BRAND_ID = B.B_ID
                        JOIN
                            COLOURS C ON V.COLOURS_ID = C.C_ID
                        JOIN
                            IMAGE I ON V.IMAGE = I.I_ID
                        WHERE
                            SALER_ID = @id";
                    SqlCommand vehicleCommand = new SqlCommand(vehicleQuery, conn);
                    vehicleCommand.Parameters.AddWithValue("@id", id);

                    SqlDataReader vehicleReader = vehicleCommand.ExecuteReader();
                    while (vehicleReader.Read())
                    {
                        string brandName = vehicleReader["BRAND_NAME"].ToString();
                        string colourName = vehicleReader["COLOUR_NAME"].ToString();
                        string dailyPrice = vehicleReader["DAILY_PRICE"].ToString();
                        string kilometres = vehicleReader["KILOMETRES"].ToString();
                        string year = vehicleReader["YEAR"].ToString();
                        string image = vehicleReader["IMAGE1"].ToString();
                        string vehicleId = vehicleReader["V_ID"].ToString();

                        // Araç kartı için HTML oluştur
                        string cardHtml = $@"
                            <div class='card d-flex flex-row align-items-center mb-3' style='border: 1px solid #ddd; padding: 10px;'>
                        <div class='card-image' style='width: 200px; margin-right: 20px;'>
                            <img src='{image}' alt='{brandName} {colourName}' class='img-fluid' style='width: 100%; height: auto;' />
                        </div>
                        <div class='card-body' style='flex: 1;'>
                            <h3 class='card-title'>{brandName} {colourName} ({year})</h3>
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

                        // Kartı placeholder'a ekle
                        salersProfile.Controls.Add(new LiteralControl(cardHtml));
                    }
                    vehicleReader.Close();
                }
            }
        }
    }
}