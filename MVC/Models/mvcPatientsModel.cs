using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVC.Models
{
    public class mvcPatientsModel
    {
        [Required(ErrorMessage ="This Field is Required.")]
        public string PatientID { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        public System.DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        public int NacionalityID { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        public string Diseases { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        public int BloodTypeID { get; set; }

        public virtual mvcBloodTypesModel BloodType { get; set; }
        public virtual mvcNationalitiesModel Nationality { get; set; }

        [Required]
        [Display(Name = "Blood Type")]
        public string SelectedBloodTypeIso3 { get; set; }
        public IEnumerable<SelectListItem> BloodTypes { get; set; }

        [Required]
        [Display(Name = "Nationality")]
        public string SelectedNationalityIso3 { get; set; }
        public IEnumerable<SelectListItem> Nationalities { get; set; }
    }
}