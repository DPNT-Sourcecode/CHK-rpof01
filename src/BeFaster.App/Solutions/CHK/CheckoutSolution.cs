using BeFaster.Runner.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace BeFaster.App.Solutions.CHK
{

    public class Offer
    {
        public Offer(int qty, int price)
        {
            Qty = qty;
            Price = price;
        }

        public int Qty { get;  }
        public int Price { get;  }
    }


    public static class CheckoutSolution
    {


        public static int ComputePrice(string skus)
        {
            if (string.IsNullOrEmpty(skus))
                return -1;

            var validCodes = new List<char>() { 'A', 'B', 'C', 'D' };
            var isValid = skus.All(x => validCodes.Contains(x));
            if (!isValid)
                return -1;

            var offers = new Dictionary<char, Offer>();
            offers.Add('A', new Offer(3, 130));
            offers.Add('B', new Offer(2, 45));

            var normalPrice = new Dictionary<char, int>();
            normalPrice.Add('A', 50);
            normalPrice.Add('B', 30);
            normalPrice.Add('C', 20);
            normalPrice.Add('D', 15);

            var groupedItems = skus.GroupBy(x => x);

            var total = 0;

            foreach (var group in groupedItems)
            {
                var item = group.Key;
                var countOfItem = group.ToList().Count;

                if(offers.ContainsKey(item))
                {
                    var qtyForOffer = offers[item];
                    if (countOfItem >= qtyForOffer.Qty)
                    {
                        var withinOffer = countOfItem / qtyForOffer.Qty;
                        var outsideOffer = countOfItem - (withinOffer * qtyForOffer.Qty);
                        total += withinOffer * qtyForOffer.Price + outsideOffer * normalPrice[item];
                    }
                    else
                    {
                        total += countOfItem * normalPrice[item];
                    }
                }
                else
                {
                    total += countOfItem * normalPrice[item];
                }
            }
            return total;
        }
    }
}






