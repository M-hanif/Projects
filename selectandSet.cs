   using (SqlConnection con=new SqlConnection(cs)) {

            SqlDataAdapter sda = new SqlDataAdapter("select image1,image2,image3,image4 from aside_images", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            eimg1.ImageUrl = dt.Rows[0]["image1"].ToString();
            eimg2.ImageUrl = dt.Rows[0]["image2"].ToString();
            eimg3.ImageUrl = dt.Rows[0]["image3"].ToString();
            eimg4.ImageUrl = dt.Rows[0]["image4"].ToString();
        }
