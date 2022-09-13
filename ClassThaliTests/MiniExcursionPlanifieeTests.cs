using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassThali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassThali.Tests
{
    [TestClass()]
    public class MiniExcursionPlanifieeTests
    {
        [TestMethod()]
        public void MiniExcursionPlanifieeTest()
        {
            /*MiniExcursion ME = new MiniExcursion(1, "balade", 20);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("2", ME, new DateTime(20, 09, 2022),1);
            Assert.AreEqual();
            */
        }

        [TestMethod()]
        public void GetCodeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetNombreInscritsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EstCompleteTest()
        {
            MiniExcursion ME = new MiniExcursion(1, "balade", 20);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("2", ME, new DateTime(15),1);
            Assert.AreEqual(false, MEP.EstComplete(), "La MEP n'est pas complet");
            MEP.SetNombreInscrits(15);
            Assert.AreEqual(false, MEP.EstComplete(), "La MEP n'est pas complete 15 inscrit pour 20");
            MEP.SetNombreInscrits(5);
            Assert.AreEqual(true, MEP.EstComplete(), "La MEP est complete 20 inscrit pour 20");

        }

        [TestMethod()]
        public void HeureRetourPrevueTest()
        {
            Assert.Fail();
        }
    }
}

namespace ClassThaliTests
{
    class MiniExcursionPlanifieeTests
    {
    }
}
