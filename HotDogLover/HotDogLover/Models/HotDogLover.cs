using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace HotDogLover.Models
{
    public class Contact
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [StringLength(500)]
        public string Bio { get; set; }
        [Display(Name = "Past Parks")]
        [Required]
        [StringLength(30)]
        public string pastPark { get; set; }
        [Display(Name = "Image")]
        //Ref: http://cpratt.co/file-uploads-in-asp-net-mvc-with-view-models/
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
        [StringLength(40)]
        public string CurrentDog { get; set; }
        public string LastPark { get; set; } 
       
        [Display(Name = "Last Walk Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]        
        public DateTime LastParkDate { get; set; }

        //Ref: http://dotnetawesome.blogspot.com/2013/12/how-to-implement-5-star-rating-system-inside-gridview.html
        public int Score { get; set; }

    }
}