using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PromotionEngine.UnitTests
{
    [TestClass]
    public class PromotionEngineUnitTest
    {
        [TestMethod]

        public void TestMethod_Only_ItemA()

        {

            //Arrange

            IPromotion promotion = null;

            promotion = new Promotion1();

            PromotionResult promotionResult = new PromotionResult(promotion);

            promotionResult.Items.Add(new ItemA()

            {

                NoOfItems = 3,

                Cost = 50

            });

            //Act

            var result = promotionResult.Calculate();

            //Assert

            Assert.AreEqual<double>(result, 130);

        }

        [TestMethod]

        public void TestMethod_Only_ItemB()

        {

            //Arrange

            IPromotion promotion = null;

            promotion = new Promotion1();

            PromotionResult promotionResult = new PromotionResult(promotion);

            promotionResult.Items.Add(new ItemB()

            {

                NoOfItems = 2,

                Cost = 30

            });

            //Act

            var result = promotionResult.Calculate();

            //Assert

            Assert.AreEqual<double>(result, 45);

        }

        [TestMethod]

        public void TestMethod_Only_ItemC()

        {

            //Arrange

            IPromotion promotion = null;

            promotion = new Promotion1();

            PromotionResult promotionResult = new PromotionResult(promotion);

            promotionResult.Items.Add(new ItemC()

            {

                NoOfItems = 1,

                Cost = 20

            });

            //Act

            var result = promotionResult.Calculate();

            //Assert

            Assert.AreEqual<double>(result, 20);

        }

        [TestMethod]

        public void TestMethod_Only_ItemD()

        {

            //Arrange

            IPromotion promotion = null;

            promotion = new Promotion1();

            PromotionResult promotionResult = new PromotionResult(promotion);

            promotionResult.Items.Add(new ItemD()

            {

                NoOfItems = 1,

                Cost = 15

            });

            //Act

            var result = promotionResult.Calculate();

            //Assert

            Assert.AreEqual<double>(result, 15);

        }

        [TestMethod]

        public void TestMethod_ScenarioA()

        {

            //Arrange

            IPromotion promotion = null;

            promotion = new Promotion1();

            PromotionResult promotionResult = new PromotionResult(promotion);

            promotionResult.Items.Add(new ItemA()

            {

                NoOfItems = 1,

                Cost = 50

            });

            promotionResult.Items.Add(new ItemB()

            {

                NoOfItems = 1,

                Cost = 30

            });

            promotionResult.Items.Add(new ItemC()

            {

                NoOfItems = 1,

                Cost = 20

            });

            //Act

            var result = promotionResult.Calculate();

            //Assert

            Assert.AreEqual<double>(result, 100);

        }

        [TestMethod]

        public void TestMethod_ScenarioB()

        {

            //Arrange

            IPromotion promotion = null;

            promotion = new Promotion1();

            PromotionResult promotionResult = new PromotionResult(promotion);

            promotionResult.Items.Add(new ItemA()

            {

                NoOfItems = 1,

                Cost = 50

            });

            promotionResult.Items.Add(new ItemB()

            {

                NoOfItems = 1,

                Cost = 30

            });

            promotionResult.Items.Add(new ItemC()

            {

                NoOfItems = 1,

                Cost = 20

            });

            //Act

            var result = promotionResult.Calculate();

            //Assert

            Assert.AreEqual<double>(result, 100);

        }

        [TestMethod]

        public void TestMethod_ScenarioC()

        {

            //Arrange

            IPromotion promotion = null;

            promotion = new Promotion1();

            PromotionResult promotionResult = new PromotionResult(promotion);

            promotionResult.Items.Add(new ItemA()

            {

                NoOfItems = 5,

                Cost = 50

            });

            promotionResult.Items.Add(new ItemB()

            {

                NoOfItems = 5,

                Cost = 30

            });

            promotionResult.Items.Add(new ItemC()

            {

                NoOfItems = 1,

                Cost = 20

            });

            //Act

            var result = promotionResult.Calculate();

            //Assert

            Assert.AreEqual<double>(result, 370);

        }

        [TestMethod]

        public void TestMethod_ScenarioD()

        {

            //Arrange

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

                NoOfItems = 5,

                Cost = 30

            });

            promotionResult.Items.Add(new ItemC()

            {

                NoOfItems = 1,

                Cost = 20

            });

            promotionResult.Items.Add(new ItemD()

            {

                NoOfItems = 1,

                Cost = 15

            });

            //Act

            var result = promotionResult.Calculate();

            //Assert

            Assert.AreEqual<double>(result, 280);

        }





    }
}
