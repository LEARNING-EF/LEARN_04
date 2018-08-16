namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
		}

		public DatabaseContext() : base()
		{
		}

		//public DatabaseContext()
		//	: base(nameOrConnectionString: "MyDatabaseContext")
		//{
		//}

		//public DatabaseContext(string nameOrConnectionString)
		//	: base(nameOrConnectionString: nameOrConnectionString)
		//{
		//}

		public System.Data.Entity.DbSet<Person> People { get; set; }
	}
}
