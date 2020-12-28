﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task3;

namespace Task3Tests
{
    [TestClass]
    public class QuerySyntaxMethodsTests
    {
        [TestMethod]
        public void GetProductByNameTest()
        {
            Assert.AreEqual(5, QuerySyntaxMethods.GetProductsByName("Chain").Count);
        }

        [TestMethod]
        public void GetProductsByVendorNameTest()
        {
            Assert.AreEqual(1,QuerySyntaxMethods.GetProductsByVendorName("International").Count);
        }

        [TestMethod]
        public void GetProductNameByVendorNameTest()
        {
           Assert.AreEqual(1, QuerySyntaxMethods.GetProtuctNamesByVendorName("International").Count);
        }

        [TestMethod]
        public void GetProduvtVendorByProductNameTest()
        {
            Assert.AreEqual("Varsity Sport Co.", QuerySyntaxMethods.GetProductVendorByProductName("Chain"));
        }

        [TestMethod]
        public void GetProductsWithRecentReviewsTest()
        {
            Assert.AreEqual(3, QuerySyntaxMethods.GetProductsWithRecentReviews(3).Count);
        }

        [TestMethod]
        public void GetNRecentlyReviewdProductdTest()
        {
            Assert.AreEqual(3, QuerySyntaxMethods.GetNRecentlyReviewedProductd(3).Count);
        }

        [TestMethod]
        public void GetNProductsFromCategoryTest()
        {
            Assert.AreEqual(5, QuerySyntaxMethods.GetNProductsFromCategory("Bikes", 5).Count);
        }

        [TestMethod]
        public void GetTotalStandardCostByCategoryTest()
        {
            ProductCategory pc = new ProductCategory
            {
                Name = "Bikes"
            };

            Assert.AreEqual(92092.8230m, QuerySyntaxMethods.GetTotalStandardCostByCategory(pc));
        }
    }
}