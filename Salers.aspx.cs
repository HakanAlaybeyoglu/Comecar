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
    public partial class Salers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack) // Sayfa ilk kez yüklendiğinde çalışacak
            {
                // Veritabanına bağlanarak salers verilerini çekme

                string connectionString = "Server=DESKTOP-LI7EMTS;Database=COMECAR;Integrated Security=True;";

                string query = @"
                    SELECT * FROM SALERS";


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
                        //  sorgudan gelen veriler
                        string salerName = reader["FULL_NAME"].ToString();
                        string salerNum = reader["PHONE_NUM"].ToString();
                        string salerEmail = reader["EMAIL"].ToString();
                        string salerId = reader["S_ID"].ToString();

                        // Tek bir HTML kartı oluşturma
                        string cardHtml = $@"
                        <div class='col'>
                            <div class='card'>

                                <div class='card-body'>
                                    <h5 class='card-title'>{salerName}</h5>
                                    <p class='card-text'>{salerNum} <br/>  {salerEmail}</p>
                                    
                                </div>
                                <a href='saler_profile.aspx?id={salerId}' class='btn btn-secondary' tabindex='-1' role='button' aria-disabled='true'>Cars For Sale</a>

                            </div>
                            
                        </div>";

                        // HTML kartını placeholder'a eklemek için
                        salersPlaceholder.Controls.Add(new LiteralControl(cardHtml));


                    }

                    reader.Close(); // Veritabanı bağlantısını kapat
                }

            }
        }
    }
}