using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


public partial class test_map : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Request.QueryString.Keys.Count > 0)
            {
                string con = ConfigurationManager.ConnectionStrings["mcon"].ConnectionString;
                using (SqlConnection co = new SqlConnection(con))
                {

                    SqlCommand cmd = new SqlCommand("select * from tblcountry  join tblresource on tblcountry.id=tblresource.c_id where hint=@CountryName", co);
                    cmd.Parameters.AddWithValue("@CountryName", Request.QueryString["c"].ToString());
                    co.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {

                        //Response.Write( rdr["industrial production growth rate"].ToString());
                        lbl_main_title.Text = rdr["Country"].ToString() + " Economical Rate " + rdr["date"].ToString();
                        lbl_disriptitle.Text = rdr["Country"].ToString();
                        lbl_discription.InnerText = rdr["Discription"].ToString();

                        lbl_i1_title.Text = "industrial production growth rate";
                        lbl_i2_title.Text = "Population below poverty line";
                        lbl_i3_title.Text = "Household income by percetage";
                        lbl_i4_title.Text = "public debt of GDP";
                        lbl_i5_title.Text = "stock of narrow money (Billion USD)";
                        lbl_i6_title.Text = "stock of broad money (Billion USD)";

                        i_i1_back.Style["width"] = rdr["industrial production growth rate"].ToString();
                        i_i2_back.Style["width"] = rdr["Population below poverty line"].ToString();
                        i_i3_back.Style["width"] = rdr["Household income by percetage"].ToString();
                        i_i4_back.Style["width"] = rdr["public debt of GDP"].ToString();
                        i_i5_back.Style["width"] = rdr["stock of narrow money (Billion USD)"].ToString();
                        i_i6_back.Style["width"] = rdr["stock of broad money (Billion USD)"].ToString();

                        i_i1_per.InnerHtml = rdr["industrial production growth rate"].ToString();
                        i_i1_per.Attributes["title"] = rdr["industrial production growth rate"].ToString();
                        i_i2_per.InnerHtml = rdr["Population below poverty line"].ToString();
                        i_i2_per.Attributes["title"] = rdr["Population below poverty line"].ToString();
                        i_i3_per.InnerHtml = rdr["Household income by percetage"].ToString();
                        i_i3_per.Attributes["title"] = rdr["Household income by percetage"].ToString();
                        i_i4_per.InnerHtml = rdr["public debt of GDP"].ToString();
                        i_i4_per.Attributes["title"] = rdr["public debt of GDP"].ToString();
                        i_i5_per.InnerHtml = rdr["stock of narrow money (Billion USD)"].ToString();
                        i_i5_per.Attributes["title"] = rdr["stock of narrow money (Billion USD)"].ToString();
                        i_i6_per.InnerHtml = rdr["stock of broad money (Billion USD)"].ToString();
                        i_i6_per.Attributes["title"] = rdr["stock of broad money (Billion USD)"].ToString();
                    }
                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "MM_swapImage('a2_r2_c24','','images/a2_r2_c24_s4.png','a2_r4_c24','','images/a2_r4_c24_s4.png','a2_r4_c36','','images/a2_r4_c36_s6.png','a2_r4_c39','','images/a2_r4_c39_s4.png','a2_r5_c24','','images/a2_r5_c24_s4.png','a2_r5_c28','','images/a2_r5_c28_s4.png','a2_r5_c35','','images/a2_r5_c35_s4.png',1)", true);

                }

            }

        }
    }

}
