using Amazon.Lambda.Core;
using Amazon.Lambda.RuntimeSupport;
using Amazon.Lambda.Serialization.SystemTextJson;
using System.Text.Json.Serialization;

namespace Project1
{
	public class Function
	{
		private static async Task Main()
		{
			Func<string, ILambdaContext, string> handler = FunctionHandler;
			await LambdaBootstrapBuilder.Create(handler, new SourceGeneratorLambdaJsonSerializer<LambdaFunctionJsonSerializerContext>())
				.Build()
				.RunAsync();
		}
		
		public static string FunctionHandler(string input, ILambdaContext context)
		{
			return "hw";
		}
	}
	
	[JsonSerializable(typeof(string))]
	public partial class LambdaFunctionJsonSerializerContext : JsonSerializerContext
	{
	}
}