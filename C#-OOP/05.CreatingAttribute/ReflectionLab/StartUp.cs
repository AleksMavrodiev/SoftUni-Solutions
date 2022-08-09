using System;

namespace AuthorProblem
{
    [Author("Gosho")]
    public class StartUp
    {
        [Author("Pesho")]
        static void Main(string[] args)
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();

        }
    }
}
