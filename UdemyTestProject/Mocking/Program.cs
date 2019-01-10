namespace UdemyTestProject.Mocking
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new VideoService();
            var title = service.ReadVideoTitle();
        }
    }
}