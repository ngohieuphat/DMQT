using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Web.Mvc;
using Web.Models;
using Web.Controllers;
using System.Collections.Generic;
namespace Web.Tests.Controllers
{
    class BangSanPhamTest
    {
        [TestMethod]
        public void IndexTest()
        {
            var controller = new BangSanPhamController();
            var result = controller.Index() as ViewResult;
            var db = new CS4PEEntities();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Model, typeof(List<BangSanPham>));
            Assert.AreEqual(db.BangSanPhams.Count(), ((List<BangSanPham>)result.Model).Count);
        }
    }
}
