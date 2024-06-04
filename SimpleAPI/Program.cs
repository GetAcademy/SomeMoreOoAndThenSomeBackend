var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.MapGet("/terje", () =>
{
    return new int[] { 1, 2, 3 };
});

app.MapPost("/terje", (int[] numbers) =>
{
    Console.WriteLine(string.Join(',', numbers));
});
app.UseStaticFiles();
app.Run();
