using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace javito
{
    internal record Airplane(string Manufacturer, string Model, string Airline )
    {
        private int Price { get; set; }
        public double Rating { get; set; }
        private int Range { get; set; }
        private int Capacity { get; set; }

        public int GetPrice()
        {
            return Price;
        }
        public int GetRange()
        {
            return Range;
        }
        public int GetCapacity()
        {
            return Capacity;
        }
        public void SetPrice(int price)
        {
            Price = price;
        }
        public void SetCapacity(int capacity)
        {
            Capacity = capacity;
        }
        public void SetRange(int range)
        {
            Range = range;
        }

        public bool IsCapableForLongDistanceFlight()
        {
            return Range > 10000;
        }
        public bool CanCarryGivenPassengers(int minPassengers)
        {
            return Capacity >= minPassengers;
        }
        public void DiscountPrice(int discount) 
        {
            if (discount >=1 && discount <= 30) 
            {
                Price -= Price * discount / 100;
            }
        }
        public override string ToString()
        {
            return $"a {Manufacturer} {Model} repulogepet a {Airline} uzemelteti, {Range} km hatotavolsággan és {Capacity} fős kapacitssal rendelkazik.";
        }
    }
    
}
