namespace MiniORM
{
    public class DbSet<T>
    {
        public IEnumerable<T> Entities { get; set; }
    }
}
