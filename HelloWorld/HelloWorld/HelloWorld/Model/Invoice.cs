using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    public class Invoice
    {
        public string Customer { get; set; }

        public string InvoiceItem { get; set; }

        public double Price { get; set; }
    }
}
