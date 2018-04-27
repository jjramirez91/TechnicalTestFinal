using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Text;

namespace MVC.Controllers
{
    public class PatientsController : Controller
    {
        // GET: Patients
        /// <summary>
        /// Get the all patients.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Patients").Result;
            string data = response.Content.ReadAsStringAsync().Result;

            JavaScriptSerializer JSSeralizer = new JavaScriptSerializer();
            IEnumerable<mvcPatientsModel> patList;

            patList = JSSeralizer.Deserialize<IEnumerable<mvcPatientsModel>>(data);
            return View(patList);
        }

        public ActionResult AddOrEdit(string ID = "")
        {
            if (ID == "")
            {
                return View(new mvcPatientsModel());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Patients/" + ID.ToString()).Result;
                string data = response.Content.ReadAsStringAsync().Result;

                JavaScriptSerializer JSSeralizer = new JavaScriptSerializer();
                IEnumerable<mvcPatientsModel> patList;

                patList = JSSeralizer.Deserialize<IEnumerable<mvcPatientsModel>>(data);
                return View(patList);
            }
            
        }

        /// <summary>
        /// Add or Edit patients.
        /// </summary>
        /// <param name="pat"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddOrEdit(mvcPatientsModel pat)
        {
            if (pat.PatientID == "")
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsync("Patients", new StringContent(new JavaScriptSerializer().Serialize(pat), Encoding.UTF8, "application/json")).Result;
                TempData["SuccessMessage"] = "Saved Succesfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsync("Patients/" + pat.PatientID, new StringContent(new JavaScriptSerializer().Serialize(pat), Encoding.UTF8, "application/json")).Result;
                TempData["SuccessMessage"] = "Update Succesfully";
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Patients/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Delete Succesfully";
            return RedirectToAction("Index");
        }
    }
}