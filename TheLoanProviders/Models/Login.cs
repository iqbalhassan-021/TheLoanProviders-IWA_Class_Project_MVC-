using System.ComponentModel.DataAnnotations;

namespace TheLoanProviders.Models
{
  
    public class signuppageData
    {
        [Key]
        public string newusername { get; set; }
        public string newuserpass { get; set; }
        public string newuserfname { get; set; }

    }
}
