using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace NguyenMinhTrong853.Models
{
    public class PersonNMT853
    {
        [Key]
        public string PersonId { get; set; }
         [Display(Name = "Tên")]
        public string PersonName { get; set; }
    }
}