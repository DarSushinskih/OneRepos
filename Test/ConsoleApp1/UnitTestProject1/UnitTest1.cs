using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test_search_win_default()
        {
            Dictionary<int, int> Castle = new Dictionary<int, int> { { 1, 5 }, { 2, 3 }, { 3, 4}, { 4, 1 },
                { 5, 3 }, { 6, 4 }, { 7, 2 }, { 8, 1 }, { 9, 4 }, { 10, 5 }};

            Assert.AreEqual(true, Program.SeachWin(Castle));
        }
        [TestMethod]
        public void test_search_win_failure()
        {
            Dictionary<int, int> Castle = new Dictionary<int, int> { { 1, 5 }, { 2, 3 }, { 3, 4}, { 4, 1 },
                                { 5, 3 }, { 6, 4 }, { 7, 2 }, { 8, 1 }, { 9, 4 }, { 10, 5 }};

            Assert.AreEqual(true, Program.SeachWin(Castle));
        }
        [TestMethod]
        public void test_search_win_feilure1()
        {
            Dictionary<int, int> Castle = new Dictionary<int, int> { { 1, 5 }, { 2, 5 }, { 3, 5}, { 4, 5 }, 
                                { 5, 5 }, { 6, 5 }, { 7, 5 }, { 8, 5 }, { 9, 5}, { 10, 5 }};

            Assert.AreEqual(false, Program.SeachWin(Castle));
        }
        [TestMethod]
        public void test_search_win_default1()
        {
            Dictionary<int, int> Castle = new Dictionary<int, int> { { 1, 5 }, { 2, 1 }, { 3, 4}, { 4, 1 },
                                { 5, 3 }, { 6, 4 }, { 7, 2 }, { 8, 1 }, { 9, 5 }, { 10, 5 }};

            Assert.AreEqual(true, Program.SeachWin(Castle));
        }
        [TestMethod]
        public void test_search_win_default2()
        {
            Dictionary<int, int> Castle = new Dictionary<int, int> { { 1, 1 }, { 2, 2 }, { 3, 4}, { 4, 4 },
                                { 5, 3 }, { 6, 4 }, { 7, 2 }, { 8, 1 }, { 9, 1 }, { 10, 5 }};

            Assert.AreEqual(true, Program.SeachWin(Castle));
        }
        [TestMethod]
        public void test_search_win_default3()
        {
            Dictionary<int, int> Castle = new Dictionary<int, int> { { 1, 1 }, { 2, 1 }, { 3, 4}, { 4, 4 },
                                { 5, 2 }, { 6, 4 }, { 7, 2 }, { 8, 1 }, { 9, 1 }, { 10, 5 }};
            Assert.AreEqual(true, Program.SeachWin(Castle));
        }
        [TestMethod]
        public void test_search_win_default4()
        {
            Dictionary<int, int> Castle = new Dictionary<int, int> { { 1, 1 }, { 2, 1 }, { 3, 3}, { 4, 4 },
                                { 5, 2 }, { 6, 4 }, { 7, 2 }, { 8, 1 }, { 9, 1 }, { 10, 5 }};
            Assert.AreEqual(true, Program.SeachWin(Castle));
        }
        [TestMethod]
        public void test_search_win_default5()
        {
            Dictionary<int, int> Castle = new Dictionary<int, int> { { 1, 6 }, { 2, 6 }, { 3, 6}, { 4, 6 },
                                { 5, 6 }, { 6, 6 }, { 7, 6 }, { 8, 6 }, { 9, 6 }, { 10, 6 }};
            Assert.AreEqual(false, Program.SeachWin(Castle));
        }
        [TestMethod]
        public void test_search_win_default7()
        {
            Dictionary<int, int> Castle = new Dictionary<int, int> { { 1, 1 }, { 2, 1 }, { 3, 1 }, { 4, 1 },
                                { 5, 1 }, { 6, 1 }, { 7, 1}, { 8, 1 }, { 9, 1 }, { 10, 1 }};
            Assert.AreEqual(false, Program.SeachWin(Castle));
        }
    }
}
