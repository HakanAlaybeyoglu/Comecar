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
            string brand = Request.QueryString["brand"];
            string color = Request.QueryString["color"];
            string fuel = Request.QueryString["fuel"];
            string gear = Request.QueryString["gear"];
            string type = Request.QueryString["type"];
            string saler = Request.QueryString["saler"];

            if (!IsPostBack) // Sayfa ilk kez yüklendiğinde çalışacak
            {
                // Veritabanına bağlanarak verileri çekme
                string connectionString = "DESKTOP-LI7EMTS;Database=COMECAR;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Satıcı bilgilerini çekme
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
                        SALERS S ON V.SALER_ID = S.S_ID
                    WHERE 
                       B.B_ID = @brand AND C.C_ID = @color AND F.FT_ID = @fuel AND G.GT_ID = @gear AND T.VT_ID = @type AND S.S_ID = @saler";
                    SqlCommand filterCommand = new SqlCommand(sqlQuery, conn);
                    filterCommand.Parameters.AddWithValue("@brand", brand);
                    filterCommand.Parameters.AddWithValue("@color", color);
                    filterCommand.Parameters.AddWithValue("@fuel", fuel);
                    filterCommand.Parameters.AddWithValue("@gear", gear);
                    filterCommand.Parameters.AddWithValue("@type", type);
                    filterCommand.Parameters.AddWithValue("@saler", saler);


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
                       

                        string cardHtml = $@"
                        <div class='card'>
                            <div class='card-body'>
                                <h3 class='card-title'>{brandName} {colorName} ({year})</h3>
                                <p class='card-text'>
                                   <h5> Price: {dailyPrice} </h5> 
                                    Kilometres: {kilometres} <br />
                                    Year: {year} <br />
                                </p>
                              <div class='image-body'> 
                                    <img src='{image}' alt='{brandName} {colorName} ' class='card-img-top' /> 
                              </div>
                                
                                <a href='car_profile.aspx?id={vehicleId}' class='btn btn-secondary' tabindex='-1' role='button' aria-disabled='true'>Details</a>
                                
                            </div>
                        </div>";

                        // HTML kartını placeholder'a eklemek için
                        filterPlaceholder.Controls.Add(new LiteralControl(cardHtml));
                    }
                    filterReader.Close();

                }

                }
            }
        }
    }