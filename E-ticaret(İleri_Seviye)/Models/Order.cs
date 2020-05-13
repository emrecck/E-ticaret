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

        public virtual List<OrderLine> OrderLines { get; set; }


    }
    public class OrderLine 
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Price { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

    }
}