using System;
using System.Text;

namespace Facroty {
  class Program {
    static void Main(string[] args) {
      var a = MyClass<int>.FacrotyMethod();
      var b = MyClass<double>.FacrotyMethod();
      var c = MyClass<string>.FacrotyMethod();
      var d = MyClass<StringBuilder>.FacrotyMethod();
      Console.WriteLine(a.GetType());
      Console.WriteLine(b.GetType());
      Console.WriteLine(c.GetType());
      Console.WriteLine(d.GetType());
    }
  }

  class MyClass<T> {
    public static T FacrotyMethod() {
      if (typeof(T) == typeof(string)) return (T) (object) string.Empty;
      else return (T)Activator.CreateInstance(typeof(T));
    }
  }
}
