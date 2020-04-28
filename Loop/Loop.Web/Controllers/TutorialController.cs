using Loop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Loop.Web.Controllers
{
    public class TutorialController : Controller
    {
        // GET: Tutorial
        public ActionResult Index()
        {
            return View();
        }
    
        [HttpGet]
        public ActionResult UploadVideo()
        {
            List<Tutorial> videolist = new List<Tutorial>();
            string CS = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spGetAllVideoFile", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Tutorial video = new Tutorial();
                    video.ProductId = Convert.ToInt32(rdr["ProductId"]);
                    video.Title = rdr["Name"].ToString();
                    video.Duration = Convert.ToInt32(rdr["Duration"]);
                    video.FilePath = rdr["FilePath"].ToString();

                    videolist.Add(video);
                }
            }
            return View(videolist);
        }
        [HttpPost]
        public ActionResult UploadVideo(HttpPostedFileBase fileupload)
        {
            if (fileupload != null)
            {
                string fileName = Path.GetFileName(fileupload.FileName);
                int fileSize = fileupload.ContentLength;
                int Size = fileSize / 1000;
                fileupload.SaveAs(Server.MapPath("~/VideoFileUpload/" + fileName));

                string CS = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spAddNewVideoFile", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Name", fileName);
                    cmd.Parameters.AddWithValue("@FileSize", Size);
                    cmd.Parameters.AddWithValue("FilePath", "~/VideoFileUpload/" + fileName);
                    cmd.ExecuteNonQuery();
                }
            }
            return RedirectToAction("UploadVideo");
        }
    }
}