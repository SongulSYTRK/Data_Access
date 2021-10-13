using CodeFirst_PhoneDirectory_Example.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_PhoneDirectory_Example.Models.Entities.Concrete
{
   public  class PhoneDirectory:BaseEntityPhone
    {
        [Required(ErrorMessage = "Must to type into name ")] // null asla geçemez doldurmak zorunda 
        [MaxLength(15, ErrorMessage = "Must length is 15")] //max bu uzunlukta 
        [MinLength(3, ErrorMessage = "Must length is 3")] //min bu uzunlukta olmak zorunda 
        public string  Name  { get; set; }

        [Required]
        public int PhoneNumber { get; set; }
        
    }
}
