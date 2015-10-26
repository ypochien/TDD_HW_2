using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    [TestClass]
    public class PotterShoppingCartTEST
    {

    //Feature: PotterShoppingCart
    //In order to 提供最便宜的價格給來買書的爸爸媽媽
    //As a 佛心的出版社老闆
    //I want to 設計一個哈利波特的購物車

        [TestMethod]
        //Scenario: 第一集買了一本，其他都沒買，價格應為100*1=100元
        public void TEST_Buy_episode_1_Should_Be_100()
        {
            //Arrange
            ShoppingCart target = new ShoppingCart();
            target.PickUp(new BOOK { Name = "Holly Potter 1", Cost = 100 });

            //Act
            var actual = target.CalculateTotalAmount();

            //Assert
            var expected = 100;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        //Scenario: 第一集買了一本，第二集也買了一本，價格應為100*2*0.95=190
        public void TEST_Buy_episode_1_And_Buy_episode_2_Should_Be_190()
        {
            //Arrange
            ShoppingCart target = new ShoppingCart();
            target.PickUp(new BOOK { Name = "Holly Potter 1", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 2", Cost = 100 });

            //Act
            var actual = target.CalculateTotalAmount();

            //Assert
            var expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Scenario: 一二三集各買了一本，價格應為100*3*0.9=270
        public void TEST_Buy_episode_1_And_2_And_3_Should_Be_270()
        {
            //Arrange
            ShoppingCart target = new ShoppingCart();
            target.PickUp(new BOOK { Name = "Holly Potter 1", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 2", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 3", Cost = 100 });

            //Act
            var actual = target.CalculateTotalAmount();

            //Assert
            var expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Scenario: 一二三四集各買了一本，價格應為100*4*0.8=320
        public void TEST_Buy_episode_1_And_2_And_3_And_4_Should_Be_320()
        {
            //Arrange
            ShoppingCart target = new ShoppingCart();
            target.PickUp(new BOOK { Name = "Holly Potter 1", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 2", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 3", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 4", Cost = 100 });

            //Act
            var actual = target.CalculateTotalAmount();

            //Assert
            var expected = 320;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Scenario: 一次買了整套，一二三四五集各買了一本，價格應為100*5*0.75=375
        public void TEST_Buy_episode_1_And_2_And_3_And_4_And_5_Should_Be_375()
        {
            //Arrange
            ShoppingCart target = new ShoppingCart();
            target.PickUp(new BOOK { Name = "Holly Potter 1", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 2", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 3", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 4", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 5", Cost = 100 });

            //Act
            var actual = target.CalculateTotalAmount();

            //Assert
            var expected = 375;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        //Scenario: 一二集各買了一本，第三集買了兩本，價格應為100*3*0.9 + 100 = 370
        public void TEST_Buy_One_ep1_And_One_ep2_And_Two_ep3_Should_Be_370()
        {
            //Arrange
            ShoppingCart target = new ShoppingCart();
            target.PickUp(new BOOK { Name = "Holly Potter 1", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 2", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 3", Cost = 100 });
            target.PickUp(new BOOK { Name = "Holly Potter 3", Cost = 100 });

            //Act
            var actual = target.CalculateTotalAmount();

            //Assert
            var expected = 370;
            Assert.AreEqual(expected, actual);
        }
    }
}
