namespace PromotionEngine
{
    public class Promotion1 : IPromotion
    {
        public double Calculate(ItemA itemA)
        {

            return itemA.NoOfItems / 3 * 130 + itemA.NoOfItems % 3 * itemA.Cost;

        }

        public double Calculate(ItemB itemB)

        {

            return itemB.NoOfItems / 2 * 45 + itemB.NoOfItems % 2 * itemB.Cost;

        }

        public double Calculate(ItemC itemC)

        {

            return itemC.NoOfItems * itemC.Cost;

        }

        public double Calculate(ItemD itemD)

        {

            return itemD.NoOfItems * itemD.Cost;

        }
    }
}
