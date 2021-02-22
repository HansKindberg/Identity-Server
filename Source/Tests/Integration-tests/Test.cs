using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTests
{
	[TestClass]
	[SuppressMessage("Naming", "CA1724:Type names should not match namespaces")]
	public class Test
	{
		#region Methods

		[TestMethod]
		[SuppressMessage("Usage", "CA2234:Pass system uri objects instead of strings")]
		public async Task Test_1()
		{
			using(var webApplicationFactory = new WebApplicationFactory())
			{
				using(var httpClient = webApplicationFactory.CreateClient())
				{
					var result = await httpClient.GetStringAsync(string.Empty);

					Assert.IsNotNull(result);
				}
			}
		}

		#endregion
	}
}