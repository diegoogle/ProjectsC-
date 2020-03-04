using System;

namespace Monitor {
    class Program {
        static void Main(string[] args) {
            Log log = new Log(@"C:\Release\");
            log.Add("Hola Mundo otra vez");
        }
    }
}
