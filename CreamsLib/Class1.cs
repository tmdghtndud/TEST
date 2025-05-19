namespace CreamsLib
{
    public class Class1
    {
        public int DoSomething(int a , int b)
        {
            int rv = a + b;

            return rv;
        }

        public void DoError()
        {
            throw new Exception("Error in CreamsLib");
        }
    }
}
