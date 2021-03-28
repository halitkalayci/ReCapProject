using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int CarModelYear { get; set; }
        public string CarDescription { get; set; }
        public decimal CarDailyPrice { get; set; }
        public string CarColorName { get; set; }
        public string CarBrandName { get; set; }
    }
}
