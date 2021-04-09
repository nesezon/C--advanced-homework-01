using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
  class Program {
    static void Main(string[] args) {
      var calcInt = new Calculator<int, int>();
      Console.WriteLine($"3 + 2 = {calcInt.Add(3, 2)}");
      Console.WriteLine($"3 - 2 = {calcInt.Sub(3, 2)}");
      Console.WriteLine($"3 * 2 = {calcInt.Mlt(3, 2)}");

      var calcDouble = new Calculator<double, double>();
      Console.WriteLine($"3 + 2 = {calcDouble.Add(3, 2)}");
      Console.WriteLine($"3 - 2 = {calcDouble.Sub(3, 2)}");
      Console.WriteLine($"3 * 2 = {calcDouble.Mlt(3, 2)}");

      var calcUByte = new Calculator<byte, byte>();
      Console.WriteLine($"3 + 2 = {calcUByte.Add(3, 2)}");
      Console.WriteLine($"3 - 2 = {calcUByte.Sub(3, 2)}");
      Console.WriteLine($"3 * 2 = {calcUByte.Mlt(3, 2)}");

      var calcUShort = new Calculator<ushort, ushort>();
      Console.WriteLine($"3 + 2 = {calcUShort.Add(3, 2)}");
      Console.WriteLine($"3 - 2 = {calcUShort.Sub(3, 2)}");
      Console.WriteLine($"3 * 2 = {calcUShort.Mlt(3, 2)}");
    }
  }

  class Calculator<T1, T2> {
    public double Add(T1 arg1, T2 arg2) {
      return Convert.ToDouble(arg1) + Convert.ToDouble(arg2);
    }

    public double Sub(T1 arg1, T2 arg2) {
      return Convert.ToDouble(arg1) - Convert.ToDouble(arg2);
    }

    public double Mlt(T1 arg1, T2 arg2) {
      return Convert.ToDouble(arg1) * Convert.ToDouble(arg2);
    }
  }
}
