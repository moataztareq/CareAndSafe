using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Management.Data.Models
{
    public class Form
    {
        public int Id { get; set; }
        public string SSIDImagePath { get; set; }
        public string ProofOfAddressPath { get; set; }
        public string SelfieWithYourIDPath { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int age { get; set; }
        public string Address { get; set; }
        
        public int HourlyRateInPound { get; set; }
        public string Bio{ get; set; }
        
    }
}
