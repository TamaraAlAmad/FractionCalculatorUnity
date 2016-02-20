using System;
using System.Collections.Generic;
using System.Linq;

namespace FractionCalculator
{
  public static class LinkedListsInsertion
  {
    public static LinkedList<int> InsertTolistInt(LinkedList<int> theList,int newValue)
    {
      //Add new item to the list
      theList.AddFirst(newValue);

      //Convert it to list
      var array = theList.ToList();

      //Sort the list
      array.Sort();

      //Return soreted list
      return  new LinkedList<int>(array);
    }
  }
}
