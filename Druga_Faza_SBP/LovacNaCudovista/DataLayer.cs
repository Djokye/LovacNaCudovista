
namespace LovacNaCudovista
{

    static class DataLayer
    {
        private static ISessionFactory? factory;
        private static object lockObj;

        static DataLayer()
        {
            factory = null;
            lockObj = new object();
        }

        public static ISession? GetSession()
        {
            if (factory == null)
            {
                lock (lockObj)
                {
                    if (factory == null)
                    {
                        factory = CreateSessionFactory();
                    }
                }
            }

            return factory?.OpenSession();
            }

        private static ISessionFactory? CreateSessionFactory()
        {
            try
            {
                
                string cs = "Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S18796;Password=S18796";
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                            .ShowSql()
                            .ConnectionString(c => c.Is(cs));

                return Fluently.Configure()
                        .Database(cfg)
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Bajalica>())
                        //.ExposeConfiguration(BuildSchema)
                        .BuildSessionFactory();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }


    }
}