using System;

namespace Libraty {
  class Program {
    static void Main(string[] args) {
      var book1 = new Book<int>() { Name = "War and Peace", Price = 29 };
      var book2 = new Book<double>() { Name = "Hamlet", Price = 9.99 };
      book1.Show();
      book2.Show();
    }
  }

  class Book<T> {
    private string name;
    
    private T price;
    
    public string Name {
      get => name;
      set => name = value;
    }

    public T Price {
      get => price;
      set => price = value;
    }

    public void Show() {
      Console.WriteLine($"Name: {Name}");
      Console.WriteLine($"Price {Price}");
    }
  }
}
