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
    public partial class car_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            //istekten gelen querydeki (indexteki) stringi alıyor 
            string id = Request.QueryString["id"];
            if (!IsPostBack) // Sayfa ilk kez yüklendiğinde çalışacak
            {
                // Veritabanına bağlanarak vehicle verilerini çekme
                string connectionString = "Server=DESKTOP-8D8OQ9R;Database=COMECAR;Integrated Security=True;";
                string query = @"
                    SELECT
                        DAMAGE,
                        DAILY_PRICE,
                        KILOMETRES,
                        YEAR,
                        V_ID,
                        BRAND_NAME,
                        COLOUR_NAME,
                        IMAGE1, IMAGE2, IMAGE3,
                        TYPE_NAME,
                        FUEL_NAME,
                        GEAR_NAME,
                        FULL_NAME, PHONE_NUM, EMAIL
                    FROM
                        VEHICLES V
                    JOIN
                        BRANDS B ON V.BRAND_ID = B.B_ID
                    JOIN
                        COLOURS C ON V.COLOURS_ID = C.C_ID
                    JOIN
                        IMAGE I ON V.IMAGE = I.I_ID
                    JOIN
                        VEHICLE_TYPE T ON V.VEHICLE_TYPE = T.VT_ID
                    JOIN
                        FUEL_TYPE F ON V.FUEL_TYPE = F.FT_ID
                    JOIN
                        GEAR_TYPE G ON V.GEAR_TYPE = G.GT_ID
                    JOIN
                        SALERS S ON V.SALER_ID = S.S_ID
                    WHERE
                        V_ID = '" + id + "'";


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(query, conn);

                    // SqlDataReader ile sorguları çalıştırıyoruz
                    SqlDataReader reader = command.ExecuteReader();
                    //sqlDataReader data  okumak için kullanılır

                    // Verileri işleyip tek bir kart oluşturmak için
                    while (reader.Read())
                    {
                        // sorgudan gelen veriler
                        string brandName = reader["BRAND_NAME"].ToString();
                        string colourName = reader["COLOUR_NAME"].ToString();
                        string image1 = reader["IMAGE1"].ToString();
                        string image2 = reader["IMAGE2"].ToString();
                        string image3 = reader["IMAGE3"].ToString();
                        string dailyPrice = reader["DAILY_PRICE"].ToString();
                        string kilometres = reader["KILOMETRES"].ToString();
                        string year = reader["YEAR"].ToString();
                        string damage = reader["DAMAGE"].ToString();
                        string typeName = reader["TYPE_NAME"].ToString();
                        string fuelName = reader["FUEL_NAME"].ToString();
                        string gearName = reader["GEAR_NAME"].ToString();
                        string salerName = reader["FULL_NAME"].ToString();
                        string salerNum = reader["PHONE_NUM"].ToString();
                        string salerEmail = reader["EMAIL"].ToString();
                        string vehicle_id = reader["V_ID"].ToString();

                        // Tek bir HTML kartı oluşturma
                        string cardHtml = $@"
                        <div class='row'>
                            <div class='col-md-6'>
                                <div id='carouselExampleControls' class='carousel slide' data-bs-ride='carousel'>
                                    <div class='carousel-inner'>
                                        {(string.IsNullOrEmpty(image1) ? "": $"<div class='carousel-item active'><img src='{image1}' class='d-block w-100'></div>")}
                                        {(string.IsNullOrEmpty(image2) ? "" : $"<div class='carousel-item'><img src='{image2}' class='d-block w-100'></div>")}
                                        {(string.IsNullOrEmpty(image3) ? "" : $"<div class='carousel-item'><img src='{image3}' class='d-block w-100'></div>")}
                                    </div>
                                    <button class='carousel-control-prev' type='button' data-bs-target='#carouselExampleControls' data-bs-slide='prev'>
                                        <span class='carousel-control-prev-icon' aria-hidden='true'></span>
                                        <span class='visually-hidden'>Previous</span>
                                    </button>
                                    <button class='carousel-control-next' type='button' data-bs-target='#carouselExampleControls' data-bs-slide='next'>
                                        <span class='carousel-control-next-icon' aria-hidden='true'></span>
                                        <span class='visually-hidden'>Next</span>
                                    </button>
                                </div>
                            </div>
                            <div class='col-md-6'>
                                <div class='card'>
                                    <div class='card-body'>
                                        <h5 class='card-title'>VEHICLE DETAILS</h5>
                                        <p class='card-text'>Brand: {brandName}</p>
                                        <p class='card-text'>Colour: {colourName}</p>
                                        <p class='card-text'>Year: {year}</p>
                                        <p class='card-text'>KM: {kilometres}</p>
                                        <p class='card-text'>Fuel Type: {fuelName}</p>
                                        <p class='card-text'>Gear Type: {gearName}</p>
                                        <p class='card-text'>Damage Record: {damage}</p>
                                        <p class='card-text'>Price: {dailyPrice}</p>
                                    </div>
                                </div>
                                <div class='card mt-3'>
                                    <div class='card-body'>
                                        <h5 class='card-title'>Seller Information</h5>
                                        <p class='card-text'>Name: {salerName}</p>
                                        <p class='card-text'>Phone Number: {salerNum}</p>
                                        <p class='card-text'>E-mail: {salerEmail}</p>
                                    </div>
                                </div>
                            </div>
                        </div>";

                        // HTML kartını placeholder'a eklemek için
                        vehiclesDetail.Controls.Add(new LiteralControl(cardHtml));
                    }

                    reader.Close(); // Veritabanı bağlantısını kapat
                }

            }
        }
    }
}
