using MVC_Insert_Data_Into_Database.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Insert_Data_Into_Database.Controllers
{
    public class EMPController : Controller
    {
        public ActionResult AddNewEmployee(EMPModel emp)
        {
            if (ModelState.IsValid)
            {
                string constring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("Employee_spInsertEmployee", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FName", emp.FName);
                        cmd.Parameters.AddWithValue("@MName", emp.MName);
                        cmd.Parameters.AddWithValue("@LName", emp.LName);
                        cmd.Parameters.AddWithValue("@EmailId", emp.EmailId);
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        con.Close();
                        if (i >= 1)
                        {
                            ViewBag.Message = "New Employee Added SuccessFully";
                        }
                        else 
                        {
                            ViewBag.Message = "Insertion Failed SuccessFully";
                        }
                    }
                }
                ModelState.Clear();                
            }
            return View();
        }
    }
}