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

    }
}
