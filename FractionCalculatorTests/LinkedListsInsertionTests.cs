using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace FractionCalculator.Tests
{
  [TestClass()]
  public class LinkedListsInsertionTests
  {
    [TestMethod()]
    public void InsertNegativeValueToEmptyList()
    {
      //Act
      LinkedList<int> theList = new LinkedList<int>();

      //Act
      theList = LinkedListsInsertion.InsertTolistInt(theList, -1);

      //Assert
      Assert.AreEqual(-1, theList.First());
    }

    [TestMethod()]
    public void InsertNegativeValueToSortedList()
    {
      //Act
      LinkedList<int> theList = new LinkedList<int>();
      theList.AddFirst(5);
      theList.AddFirst(4);
      theList.AddFirst(3);
      theList.AddFirst(2);

      //Act
      theList = LinkedListsInsertion.InsertTolistInt(theList, -1);

      //Assert
      Assert.AreEqual(-1, theList.First());
    }

    [TestMethod()]
    public void InsertNegativeValueToNonSortedList()
    {
      //Act
      LinkedList<int> theList = new LinkedList<int>();
      theList.AddFirst(53);
      theList.AddFirst(-5);
      theList.AddFirst(10);
      theList.AddFirst(20);

      //Act
      theList = LinkedListsInsertion.InsertTolistInt(theList, -1);

      //Assert
      Assert.AreEqual(-5, theList.First());
      Assert.AreEqual(53, theList.Last());
    }


    [TestMethod()]
    public void InsertintBigValueToNonSortedList()
    {
      //Act
      LinkedList<int> theList = new LinkedList<int>();
      theList.AddFirst(111111111);
      theList.AddFirst(-522919299);
      theList.AddFirst(10);
      theList.AddFirst(20);

      //Act
      theList = LinkedListsInsertion.InsertTolistInt(theList, -1);

      //Assert
      Assert.AreEqual(-522919299, theList.First());
      Assert.AreEqual(111111111, theList.Last());
    }
  }
}