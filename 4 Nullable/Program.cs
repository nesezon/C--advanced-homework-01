using System;

namespace Nullable {
  class Program {
    static void Main(string[] args) {
      // Значимые типы по умолчанию не nullable
      // DateTime time;

      // Чтобы DateTime позволял хранить null нужно его уговорить (добавить вопросик)
      DateTime? time = null;
      if (time == null) {
        /* do something */
      }
    }
  }
}
