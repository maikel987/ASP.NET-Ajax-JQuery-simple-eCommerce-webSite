﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ClassLibrary;
using DAL;

namespace Market.Web.Models
{
    public class ProductVM
    {
        public Int64 ID
        {
            get; set;
        }
        //public User OwnerID { get; set; }

        //public User UserID { get; set; }

        [Required(ErrorMessage = "Please enter a Title")]
        [StringLength(50, ErrorMessage = "Please enter a Title with less than 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a Short Description")]
        [StringLength(500, ErrorMessage = "Please enter a Title with less than 500 characters")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "Please enter a Long Description")]
        [StringLength(4000, ErrorMessage = "Please enter a Title with less than 4000 characters")]
        public string LongDescription { get; set; }


        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please enter a Price")]
        public double Price { get; set; }

        public Byte[] Picture1 { get; set; }

        public Byte[] Picture2 { get; set; }

        public Byte[] Picture3 { get; set; }

        //[Required]
        //public State state { get; set; }


    }
}