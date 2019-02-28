namespace UseWCFInASPNETCoreMVC
{
    public class DemoService : IDemoService
    {
        public string Hello()
        {
            return "Hello World";
        }

        public string Hi(string name)
        {
            return "Hi" + name;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
