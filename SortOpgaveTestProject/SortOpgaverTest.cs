using SortOpgaverClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace SortOpgaveTestProject
{
    
    
    /// <summary>
    ///This is a test class for SortOpgaverTest and is intended
    ///to contain all SortOpgaverTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SortOpgaverTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        // Hjælpemetode for test af om listen er sorteret
        private bool IsSorted(List<int> list2test4sorted)
        {
            List<int> dataCopy = new List<int>(list2test4sorted);
            dataCopy.Sort();
            for (int i = 0; i < dataCopy.Count; ++i)
            {
                if (list2test4sorted[i] != dataCopy[i])
                    return false;
            }
            return true;
        }
        private bool IsInSameOrder(List<int> l1, List<int> l2)
        {
            if (l1.Count != l1.Count)
                return false;
            for (int i = 0; i < l1.Count; ++i)
            {
                if (l1[i] != l2[i])
                    return false;
            }
            return true;
        }
        // Hjælpemetode for test af om listen har samme elementer som originalen - primitiv og lidt dyr, men skulle være gennemskueligt
        private bool HasSameElements(int[] orgData, List<int> newData)
        {
            // send videre for løsning, men med 2 lister - som giver let kopiering
            return HasSameElements(new List<int>(orgData), newData);
        }
        // Hjælpemetode for test af om listen har samme elementer som originalen - primitiv og lidt dyr, men skulle være gennemskueligt
        private bool HasSameElements(List<int> orgData, List<int> newData)
        {
            if (orgData.Count != newData.Count)
                return false;
            int[] orgCopy = orgData.ToArray();      // kopi af begge
            int[] newCopy = newData.ToArray();
            Array.Sort(orgCopy);                    // sorteres
            Array.Sort(newCopy);
            for (int i = 0; i < orgData.Count; ++i) // og elementer sammenlignes 
            {
                if (orgCopy[i] != newCopy[i])
                    return false;
            }
            return true;
        }


        [TestMethod(), Timeout(1500)]
        public void BubbleSort_PrimitiveTest()
        {
            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17 };

            SortOpgaver opgaver = new SortOpgaver();
            opgaver.FillList(data);
            opgaver.BubbleSort_Primitive();
            List<int> sortedData = opgaver.GetIntListCopy();
            Assert.IsTrue(IsSorted(sortedData), "Data er ikke sorteret");
            Assert.IsTrue(HasSameElements(data, sortedData), "Der er ikke sammme elementer i det sorterede som i data før");
        }


        [TestMethod(), Timeout(500)]
        public void BubbleSort_Primitive_OptimizedTest()
        {
            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17 };

            SortOpgaver opgaver = new SortOpgaver();
            opgaver.FillList(data);
            opgaver.BubbleSort_Primitive_Optimized();
            List<int> sortedData = opgaver.GetIntListCopy();
            Assert.IsTrue(IsSorted(sortedData), "Data er ikke sorteret");
            Assert.IsTrue(HasSameElements(data, sortedData), "Der er ikke sammme elementer i det sorterede som i data før");
        }



        [TestMethod(), Timeout(500)]
        public void InsertElementInOrderedListTest_01()
        {
            int insertElementValue = 21;
            int[] data = { 5, 8, 13, 20, 30, 31 };

            List<int> expectedDataWithElement = new List<int>(data);

            SortOpgaver opgaver = new SortOpgaver();
            opgaver.FillList(data);
            opgaver.InsertElementInOrderedList(insertElementValue);
            List<int> sortedData = opgaver.GetIntListCopy();

            Assert.IsTrue(IsSorted(sortedData), "Data er ikke sorteret");
            Assert.IsTrue(HasSameElements(expectedDataWithElement, sortedData), "Der er ikke sammme elementer i det sorterede som i data før");
        }

        [TestMethod(), Timeout(500)]
        public void InsertElementInOrderedListTest_02()
        {
            int insertElementValue = 4;
            int[] data = { 5, 8, 13, 20, 30, 31 };

            List<int> expectedDataWithElement = new List<int>(data);

            SortOpgaver opgaver = new SortOpgaver();
            opgaver.FillList(data);
            opgaver.InsertElementInOrderedList(insertElementValue);
            List<int> sortedData = opgaver.GetIntListCopy();

            Assert.IsTrue(IsSorted(sortedData), "Data er ikke sorteret");
            Assert.IsTrue(HasSameElements(expectedDataWithElement, sortedData), "Der er ikke sammme elementer i det sorterede som i data før");
        }

        [TestMethod(), Timeout(500)]
        public void InsertElementInOrderedListTest_03()
        {
            int insertElementValue = 32;
            int[] data = { 5, 8, 13, 20, 30, 31 };

            List<int> expectedDataWithElement = new List<int>(data);

            SortOpgaver opgaver = new SortOpgaver();
            opgaver.FillList(data);
            opgaver.InsertElementInOrderedList(insertElementValue);
            List<int> sortedData = opgaver.GetIntListCopy();

            Assert.IsTrue(IsSorted(sortedData), "Data er ikke sorteret");
            Assert.IsTrue(HasSameElements(expectedDataWithElement, sortedData), "Der er ikke sammme elementer i det sorterede som i data før");
        }

        [TestMethod(), Timeout(500)]
        public void InsertElementInOrderedListTest_04()
        {
            int insertElementValue = 4;
            int[] data = {  };          // ingen data

            List<int> expectedDataWithElement = new List<int>(data);

            SortOpgaver opgaver = new SortOpgaver();
            opgaver.FillList(data);
            opgaver.InsertElementInOrderedList(insertElementValue);
            List<int> sortedData = opgaver.GetIntListCopy();

            Assert.IsTrue(IsSorted(sortedData), "Data er ikke sorteret");
            Assert.IsTrue(HasSameElements(expectedDataWithElement, sortedData), "Der er ikke sammme elementer i det sorterede som i data før");
        }





        [TestMethod(),Timeout(500)]
        public void InsertionSortTest()
        {
            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17 };

            SortOpgaver opgaver = new SortOpgaver();
            opgaver.FillList(data);
            opgaver.InsertionSort();
            List<int> sortedData = opgaver.GetIntListCopy();
            Assert.IsTrue(IsSorted(sortedData), "Data er ikke sorteret");
            Assert.IsTrue(HasSameElements(data, sortedData), "Der er ikke sammme elementer i det sorterede som i data før");
        }

        [TestMethod(), Timeout(500)]
        public void AnotherSortOfYourChoiceTest()
        {
            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17 };

            SortOpgaver opgaver = new SortOpgaver();
            opgaver.FillList(data);
            opgaver.AnotherSortOfYourChoice();
            List<int> sortedData = opgaver.GetIntListCopy();
            Assert.IsTrue(IsSorted(sortedData), "Data er ikke sorteret");
            Assert.IsTrue(HasSameElements(data, sortedData), "Der er ikke sammme elementer i det sorterede som i data før");
        
        }

        [TestMethod(), Timeout(500)]
        public void EasyReverseSort_UsingBuildInSortOnListTest()
        {
            int[] data = { 24, 37, 1, 21, 5, 8, 4, 31, 32, 17 };
            List<int> reverseSortedData = new List<int>(data);
            reverseSortedData.Sort((elm1,elm2) => elm2-elm1);   // lamda expression for sorterings rækkefølge

            SortOpgaver opgaver = new SortOpgaver();
            opgaver.FillList(data);
            opgaver.EasyReverseSort_UsingBuildInSortOnList();
            List<int> sortedData = opgaver.GetIntListCopy();
            Assert.IsTrue(IsInSameOrder(reverseSortedData, sortedData), "Data er ikke sorteret i faldende orden");
        }
    
    }
}
