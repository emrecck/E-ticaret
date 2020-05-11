using E_ticaret_İleri_Seviye_.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_ticaret_İleri_Seviye_.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ApplicationUser User { get; set; }
        public List<OrderLine> OrderLines { get; set; }


    }
    public class OrderLine 
    {
        public string CourseName { get; set; }
        public string Price { get; set; }
        public int OrderId { get; set; }

    }
}