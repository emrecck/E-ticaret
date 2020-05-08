using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Web;

namespace E_ticaret_İleri_Seviye_.Models
{
    public class Cart
    {
        private List<CartLine> cartLines = new List<CartLine>();

        public List<CartLine> CartLines { get { return cartLines; } }

        public void AddCartLine(Course course)
        {
            var line = cartLines.FirstOrDefault(i => i.Course.Id == course.Id);
            if( line == null )
            {
                cartLines.Add(new CartLine() { Course = course });
            }
        }
        public void DeleteFromCartLine(Course course)
        {
            var line = cartLines.FirstOrDefault(i => i.Course.Id == course.Id);
            if( line != null )
            {
                cartLines.RemoveAll(i => i.Course.Id == course.Id);
            }
        }
        public double TotalCost()
        {
            double total = 0;
            foreach( var item in cartLines )
            {
                total += Convert.ToDouble(item.Course.Price);
            }
            return total;
        }
        public void Clear() 
        {
            cartLines.Clear();
        }
    }
    public class CartLine
    {
        public Course Course { get; set; }
    }
}