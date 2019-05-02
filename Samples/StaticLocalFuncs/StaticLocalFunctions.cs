using System;

namespace StaticLocalFuncs
{
    public class StaticLocalFunctions
    {
        int ClassicLocalFunction()
        {
            int y;
            LocalFunction();
            return y;

            // References y in the outer scope, no static allowed
            void LocalFunction() => y = 0;
        }

        int NewLocalFunction()
        {
            int y = 5;
            int x = 7;
            return Add(x, y);

            // all references are within the scope. Static is allowed!
            static int Add(int left, int right) => left + right;
        }
    }
}
