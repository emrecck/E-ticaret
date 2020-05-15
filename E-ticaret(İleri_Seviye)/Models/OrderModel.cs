using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_ticaret_İleri_Seviye_.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        
    }
}