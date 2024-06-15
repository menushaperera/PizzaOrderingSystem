using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_System
{
    internal class customers
    {
        public string Fname { get; set; }

        public string Lname { get; set; }
        public string address { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string Pcode { get; set; }
        public string CNo { get; set; }
        public string Email { get; set; }

        public customers(string fname, string lname, string address, string province, string city, string pcode, string cNo, string email)
        {
            Fname = fname;
            Lname = lname;
            this.address = address;
            this.province = province;
            this.city = city;
            Pcode = pcode;
            CNo = cNo;
            Email = email;
        }
    }

    internal class payment
    {
        public string PaymentMethod { get; set; }
        public string CardNo { get; set; }
        public string AmountDue { get; set; } 
        public string AmountPaid { get; set; } 

        public payment(string paymentMethod, string cardNo, string amountDue, string amountPaid)
        {
            this.PaymentMethod = paymentMethod;
            this.CardNo = cardNo;
            this.AmountDue = amountDue;
            this.AmountPaid = amountPaid;
        }
    }
}
