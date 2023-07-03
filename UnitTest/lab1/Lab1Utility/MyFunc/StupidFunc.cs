namespace Lab1Utility.MyFunc
{
    public class StupidFunc
    {
        public string Say(string name)
        {
            if (name is null)
            {
                return "Hello";
            }

            return "Hello, " + name;
        }

        public int Sum(int a, int b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException();
            }

            return a + b;
        }
    }
}