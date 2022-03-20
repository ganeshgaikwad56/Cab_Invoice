using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        private int numberOfRides;
        private double totalFare;
        private double avareageFare;

        public InvoiceSummary(int numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.avareageFare = this.totalFare/this.numberOfRides;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is InvoiceSummary)) return false;

            InvoiceSummary InputObjrct = (InvoiceSummary)obj;

            return this.numberOfRides == InputObjrct.numberOfRides && this.totalFare == InputObjrct.totalFare && this.avareageFare == InputObjrct.avareageFare;
        }
        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode();
        }
    }
}
