using Leson3DatabasesDevelopmentftheProgramOnWinForms.Database;

namespace Leson3DatabasesDevelopmentftheProgramOnWinForms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DB db = new DB();
            db.ConectToDb();
        }
    }
}