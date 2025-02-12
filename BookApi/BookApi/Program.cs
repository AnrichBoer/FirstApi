namespace BookApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //add services
            builder.Services.AddControllers();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyCors",builder =>
                {
                    builder
                    .WithOrigins("http://localhost:4200") //if you are hosting your app, you'd add the url here
                    .AllowAnyHeader()
                    .AllowAnyMethod(); //allows angular to send get requests
                } );
            });

            var app = builder.Build();

            app.UseCors("MyCors");
            
            //add mapping
            app.MapControllers();

            app.MapGet("/", () =>
            {
                return Results.Redirect("/api/books");
            });

            app.Run();
        }
    }
}
//Web API = Application Programming intrface availble via web (http requests)
//Controllers + Routs/Endpoints + Models
//
