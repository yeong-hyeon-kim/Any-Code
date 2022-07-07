namespace PScope
{
    delegate void ScopeCallback();

    class Scope
    {
        void Method()
        {
            for (int i = 0; i < 1000; i++){}
        }
    }
}