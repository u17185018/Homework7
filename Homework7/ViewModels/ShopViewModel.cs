using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework7.ViewModels
{
    public class ShopViewModel
    {
        private List<ShopItemViewModel> itemlist = new List<ShopItemViewModel>();

        public List<ShopItemViewModel> Itemlist
        {
           get { return itemlist; }
            set { itemlist = value; }
       }
        public ShopViewModel()
        {

        }
        public ShopViewModel(List<ShopItemViewModel> nItemList)
        {
            itemlist = nItemList;
        }
         public void AddItem(ShopItemViewModel u)
        {
            itemlist.Add(u);
        }
    }
}