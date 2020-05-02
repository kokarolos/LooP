using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Loop.Entities;

namespace Loop.Web.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            List<VideoFile> videolist = new List<VideoFile>();
            string mainconn = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[VideoFiles]";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataReader sdr = sqlcomm.ExecuteReader();
            while (sdr.Read()) 
            {
                VideoFile vf = new VideoFile();
                vf.Vname = sdr["Vname"].ToString();
                vf.Vpath = sdr["Vpath"].ToString();
                videolist.Add(vf);
            }
            return View(videolist);
        }  
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase videofile)
        {
            if (videofile!=null)
            {
                string filename = Path.GetFileName(videofile.FileName);
                // checking for uploads under 100MB
                if (videofile.ContentLength<104857600) // MB converted to bytes
                {
                    videofile.SaveAs(Server.MapPath("/VideoFiles/"+filename));
                    string mainconn = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                    SqlConnection sqlconn = new SqlConnection(mainconn);
                    string sqlquery = "insert into [dbo].[VideoFiles] values (@Vname,@Vpath)";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                    sqlconn.Open();
                    sqlcomm.Parameters.AddWithValue("@Vname", filename);
                    sqlcomm.Parameters.AddWithValue("@Vpath", "/VideoFiles/"+filename);
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                    ViewData["Message"] = "Record Saved Successfully!";
                }

            }
            return RedirectToAction("Index");
        }
    }
}