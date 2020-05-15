using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using Loop.Entities;

namespace Loop.Web.Controllers
{
    public class ImageUploadController : Controller
    {
       // private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Upload
        public ActionResult Index()
        {
            List<Image> imageList = new List<Image>();
            string mainconn = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[ImageFiles]";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            while (sdr.Read())
            {
                Image im = new Image();
                im.ImgName = sdr["ImgName"].ToString();
                im.ImgPath = sdr["ImgPath"].ToString();
                imageList.Add(im);
            }
            return View(imageList);
        }



        [HttpPost]
        public ActionResult Index(HttpPostedFileBase imageFile)
        {
            if (imageFile != null)
            {
                string filename = Path.GetFileName(imageFile.FileName);
                // checking for uploads under 100MB
               
                    imageFile.SaveAs(Server.MapPath("/ImageFiles/"+filename));
                    string mainconn = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery = "insert into [dbo].[ImageFiles] values (@ImgName,@ImgPath)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                    sqlconn.Open();
                    sqlcomm.Parameters.AddWithValue("@ImgName", filename);
                    sqlcomm.Parameters.AddWithValue("@ImgPath","/ImageFiles/"+ filename);
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                    ViewData["Message"] = "Record Saved Successfully!";

            }
            return RedirectToAction("Index");
        }
    }
}