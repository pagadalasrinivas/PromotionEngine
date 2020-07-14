using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class PromotionResult

    {

        private IPromotion promotion;

        public List<Item> Items { get; set; } = new List<Item>();

        public PromotionResult(IPromotion promotion)

        {

            this.promotion = promotion;

        }

        public double Calculate()

        {

            double totalCost = 0;

            double adjustedValue = 0;

            foreach (Item item in Items)

            {

                totalCost += item.Accept(promotion);

            }

            if (promotion.GetType().Equals(typeof(Promotion1)))

            {

                int noOfCItems = 0;

                double costOfCItem = 0.0;

                int noOfDItems = 0;

                double costOfDItem = 0.0;

                if (Items.OfType<ItemC>().FirstOrDefault() != null)

                {

                    noOfCItems = Items.OfType<ItemC>().FirstOrDefault().NoOfItems;

                    costOfCItem = Items.OfType<ItemC>().FirstOrDefault().Cost;

                }

                if (Items.OfType<ItemD>().FirstOrDefault() != null)

                {

                    noOfDItems = Items.OfType<ItemD>().FirstOrDefault().NoOfItems;

                    costOfDItem = Items.OfType<ItemD>().FirstOrDefault().Cost;

                }

                if (noOfCItems > 0 && noOfDItems > 0)

                {

                    if (noOfCItems == noOfDItems)

                        adjustedValue = noOfCItems * 5;

                    if (noOfCItems != noOfDItems)

                        adjustedValue = (noOfCItems > noOfDItems) ? ((noOfCItems - noOfDItems) * costOfCItem) : ((noOfDItems - noOfCItems) * costOfDItem);

                }

            }

            return totalCost - adjustedValue;

        }

    }



    class Program

    {

        static void Main(string[] args)

        {

            IPromotion promotion = null;

            promotion = new Promotion1();

            PromotionResult promotionResult = new PromotionResult(promotion);

            promotionResult.Items.Add(new ItemA()

            {

                NoOfItems = 3,

                Cost = 50

            });

            promotionResult.Items.Add(new ItemB()

            {

                NoOfItems = 2,

                Cost = 30

            });

            promotionResult.Items.Add(new ItemC()

            {

                NoOfItems = 2,

                Cost = 20

            });

            promotionResult.Items.Add(new ItemD()

            {

                NoOfItems = 2,

                Cost = 15

            });

            Console.WriteLine(promotionResult.Calculate());

            Console.ReadLine();



        }

    }



}
