using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.Management.Data.Dtos
{
    public class BookingDto
    {
        
        public int NannyId { get; set; }
        public string Duration { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Notes { get; set; }
        //child Info
        public string ChildName { get; set; }
        public string? ChildGender { get; set; }
        public string? MedicalHistoryAboutChild { get; set; }
        //Home details
        public int? HomeSpace { get; set; }
        public int? NumOfLivingRoom { get; set; }
        public int? NumOfDinningRoom { get; set; }
        public int? NumOfBedRoom { get; set; }
        public int? NumOfLaundryRoom { get; set; }
        public int? NumOfKitchenRoom { get; set; }
        public int? NumOfBathRoom { get; set; }
        //Info about Location
        public string? BuildingName { get; set; }
        public int? AptNo { get; set; }
        public int? Floor { get; set; }
        public string? AdditionalDirection { get; set; }
        public string? PaymentMethod { get; set; }
    }
}
