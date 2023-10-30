namespace Asp.Net_MVC
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			// with AddMvc razorpage to use possible
			builder.Services.AddMvc();
			var app = builder.Build();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Product}/{action=List}");
			app.Run();
		}
	}
}