using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace CacheDataset
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Cache["Data"] == null)
            {
                using (SqlConnection con = new SqlConnection("Data Source=PRADEEP\\SQLEXPRESS;Initial Catalog=product;Integrated Security=true"))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from tblProductInventory", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    Cache["Data"] = ds;
                    GridView1.DataSource = ds;
                    GridView1.DataBind();


                }
                Label1.Text = "Data loaded from the database";

            }
            else
            {
                GridView1.DataSource = (DataSet)Cache["Data"];
                GridView1.DataBind();
                Label1.Text = "Data loaded from the Cache";

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Cache["Data"] != null)
            {

                Cache.Remove("Data");
                Label1.Text = "Cache cleared";

            }
            else
            {
                Label1.Text = "nothing in the cache";
            }
        }
    }
}