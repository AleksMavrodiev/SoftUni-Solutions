using System.Reflection;

namespace MiniORM
{
    public abstract class DbContext
    {
        private readonly DatabaseConnection connection;
        private readonly IDictionary<Type, PropertyInfo> dbSets;

        public static Type[] AllowedSqlTypes;
    }
}
