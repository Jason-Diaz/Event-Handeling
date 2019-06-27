using System;

namespace Lab_Events
{
    class Company
    {
        string Name { get; set; }



        public event Action ShipmentArrived;
        public event EventHandler<SaleEventArgs> Sale;

        public void FireShipmentArrived()
        {
            if (ShipmentArrived == null)
                return;

            ShipmentArrived();
        }

        public void FireSale(string saleDescription)
        {
            if (Sale == null)
                return;

            Company.SaleEventArgs evtArgs = new Company.SaleEventArgs(saleDescription);
            Sale(this, evtArgs);
        }

        public class SaleEventArgs : EventArgs
        {

            public string SaleDescription { get; set; }

            public SaleEventArgs(string saleDescription)
            {
                SaleDescription = saleDescription;
            }

            public void SaveEventArgs(string sd)
            {
                SaleDescription = sd;
            }
        }
    }
}
