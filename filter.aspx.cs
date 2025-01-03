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
        string connectionString = "Server=DESKTOP-8D8OQ9R;Database=COMECAR;Integrated Security=True;";
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
            string url = "get_filter.aspx?";
            List<string> filters = new List<string>();

            // Marka Filtresi
            StringBuilder brandFilter = new StringBuilder();
            foreach (ListItem item in brandCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    brandFilter.Append(item.Value + ",");
                }
            }
            if (brandFilter.Length > 0)
            {
                filters.Add("brand=" + HttpUtility.UrlEncode(brandFilter.ToString().TrimEnd(',')));
            }

            // Renk Filtresi
            StringBuilder colorFilter = new StringBuilder();
            foreach (ListItem item in colorCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    colorFilter.Append(item.Value + ",");
                }
            }
            if (colorFilter.Length > 0)
            {
                filters.Add("color=" + HttpUtility.UrlEncode(colorFilter.ToString().TrimEnd(',')));
            }

            // Yakıt Filtresi
            StringBuilder fuelFilter = new StringBuilder();
            foreach (ListItem item in fuelCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    fuelFilter.Append(item.Value + ",");
                }
            }
            if (fuelFilter.Length > 0)
            {
                filters.Add("fuel=" + HttpUtility.UrlEncode(fuelFilter.ToString().TrimEnd(',')));
            }

            // Vites Filtresi
            StringBuilder gearFilter = new StringBuilder();
            foreach (ListItem item in gearCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    gearFilter.Append(item.Value + ",");
                }
            }
            if (gearFilter.Length > 0)
            {
                filters.Add("gear=" + HttpUtility.UrlEncode(gearFilter.ToString().TrimEnd(',')));
            }

            // Araç Tipi Filtresi
            StringBuilder typeFilter = new StringBuilder();
            foreach (ListItem item in vehicleCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    typeFilter.Append(item.Value + ",");
                }
            }
            if (typeFilter.Length > 0)
            {
                filters.Add("type=" + HttpUtility.UrlEncode(typeFilter.ToString().TrimEnd(',')));
            }

            // Satıcı Filtresi
            StringBuilder salerFilter = new StringBuilder();
            foreach (ListItem item in salersCheckBoxList.Items)
            {
                if (item.Selected)
                {
                    salerFilter.Append(item.Value + ",");
                }
            }
            if (salerFilter.Length > 0)
            {
                filters.Add("saler=" + HttpUtility.UrlEncode(salerFilter.ToString().TrimEnd(',')));
            }

            // Filtreleri birleştir ve yönlendir
            if (filters.Count > 0)
            {
                url += string.Join("&", filters);
            }

            Response.Redirect(url);
        }

    }
}