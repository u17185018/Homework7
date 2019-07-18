using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework7.ViewModels
{
    public class ShopItemViewModel
    {
        private string mName;
        private string mDescription;
        private double mPrice;
        private int mQuantitiyAvailable;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
    }
        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }
        public double Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }
        public int QuantityAvailable
        {
            get { return mQuantitiyAvailable; }
            set { mQuantitiyAvailable = value; }
        }
        public ShopItemViewModel()
          {


           }


        public ShopItemViewModel(string fName, string fDesc,double fPrice,int fQuantity)
        {
            Name = fName;
            Description = fDesc;
            Price = fPrice;
            QuantityAvailable = fQuantity;
        }
    }
}