namespace PromotionEngine
{
    public class ItemA : Item

    {

        public int NoOfItems { get; set; }

        public double Cost { get; set; }

        public double Accept(IPromotion promotion)

        {

            return promotion.Calculate(this);

        }

    }
}
