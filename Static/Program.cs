using System;

namespace Static
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello " + args[0]);
''

      Enemy e1 = new Enemy();
      Enemy e2 = new Enemy();

      Console.WriteLine(Enemy.list.Count);
      
      Console.ReadLine();

      Console.WriteLine("Hello World!");
    }


    public void Hello()
    {
      
    }
  }
}
