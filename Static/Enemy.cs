using System.Collections.Generic;
using System;

namespace Static
{
    public class Enemy
    {
      public static List<Enemy> list = new List<Enemy>();

      static Random generator = new Random();

      public string name = "";

      public int hp;

      public Enemy()
      {
        list.Add(this);
      }

      public void SayHello()
      {
        hp += generator.Next(10);

        hp++;
        Console.WriteLine("How do you do?");
      }
    }
}
