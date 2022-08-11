namespace PScope
{
    delegate void ScopeCallback();

    class Scope
    {
        static void Main(string[] args)
        {

        }
        static void Method()
        {
            for (int i = 0; i < 1000; i++) { }
        }
    }
}