using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;

namespace Comecar
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Sayfa ilk kez yüklendiğinde çalışacak
            {
                // Veritabanına bağlanarak vehicle verilerini çekme


                string connectionString = "Server=DESKTOP-8D8OQ9R;Database=COMECAR;Integrated Security=True;";


                string query = @"
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
                        IMAGE I ON V.IMAGE = I.I_ID";

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
                        // İlk sorgudan gelen veriler
                        string dailyPrice = reader["DAILY_PRICE"].ToString();
                        string kilometres = reader["KILOMETRES"].ToString();
                        string year = reader["YEAR"].ToString();

                        // İkinci sorgudan gelen veriler
                        string vehicleId = reader["V_ID"].ToString();
                        string brandName = reader["BRAND_NAME"].ToString();
                        string colourName = reader["COLOUR_NAME"].ToString();
                        string image = reader["IMAGE1"].ToString();

                        // Tek bir HTML kartı oluşturma
                        string cardHtml = $@"
                        <div class='card'>
                            <div class='card-body'>
                                <h3 class='card-title'>{brandName} {colourName} ({year})</h3>
                                <p class='card-text'>
                                   <h5> Price: {dailyPrice} </h5> 
                                    Kilometres: {kilometres} <br />
                                    Year: {year} <br />
                                </p>
                              <div class='image-body'> 
                                    <img src='{image}' alt='{brandName} {colourName}' class='card-img-top' /> 
                              </div>
                                
                                <a href='car_profile.aspx?id={vehicleId}' class='btn btn-secondary' tabindex='-1' role='button' aria-disabled='true'>Details</a>
                                
                            </div>
                        </div>";

                        // HTML kartını placeholder'a eklemek için
                        vehiclesPlaceholder.Controls.Add(new LiteralControl(cardHtml));
                    }

                    reader.Close(); // Veritabanı bağlantısını kapat
                }

            }
        }

    }
}
