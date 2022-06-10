using Xunit;

namespace HS.DNDTools.DataAccess.Tests.Providers.Characters
{
    public class Tests : CosmosTestBase
    {
        public Tests() : base()
        {

        }

        [Fact]
        public void InsertItemTest()
        {
            var provider = new Provider(this.Configuration);
            
        }
    }
}