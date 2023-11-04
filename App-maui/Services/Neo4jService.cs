
using Neo4j.Driver;

namespace CraftEd
{
    public class Neo4jService : IDisposable
    {
        private readonly IDriver _driver;
        private readonly string _uri;
        private readonly string _user;
        private readonly string _password;

        public Neo4jService(string uri, string user, string password)
        {
            _uri = uri;
            _user = user;
            _password = password;
            _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
        }

        public void Dispose()
        {
            _driver?.Dispose();
        }

        public void RunQuery(string query)
        {
            using (var session = _driver.AsyncSession())
            {
                var result = session.WriteTransactionAsync(async tx =>
                {
                    var cursor = await tx.RunAsync(query);
                    return cursor;
                }).Result;

            }
        }
    }
}
