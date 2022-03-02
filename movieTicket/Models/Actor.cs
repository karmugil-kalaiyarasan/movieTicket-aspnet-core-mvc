﻿using movieTicket.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace movieTicket.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is Required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="Full Name is Required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Full Name must be between 3 and 50 characters")]
        public string FullName { get; set; }
        [Display(Name ="Bio")]
        [Required(ErrorMessage ="Bio is Required")]
        public string Bio { get; set; }
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}