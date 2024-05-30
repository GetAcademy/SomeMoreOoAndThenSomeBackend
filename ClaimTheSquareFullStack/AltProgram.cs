using ClaimTheSquareFullStack.Model;

namespace ClaimTheSquareFullStack
{
    public class AltProgram
    {
        public static void Mainx(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseHttpsRedirection();
            //app.MapGet("/terje", GetPerson);
            app.MapGet("/terje", () =>
            {
                return new Person
                {
                    Name = "Terje",
                    Email = "terje@getacademy.no"
                };
            });

            app.MapPost("/terje", (Person p) =>
            {
                Console.WriteLine($"{p.Name} {p.Email}" );
            });
            app.UseStaticFiles();
            app.Run();
        }

        /*
           private static Person GetPerson()
           {
             return new Person
             {
               Name = "Terje",
               Email = "terje@getacademy.no"
             };
           }
         */
    }
}
