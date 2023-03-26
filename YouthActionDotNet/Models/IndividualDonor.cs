
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace YouthActionDotNet.Models
{
    public class individualDonor : Donor
    {
        // Properties specific to corporate donors
       
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        
    }
}