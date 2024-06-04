using System.Text.Json;
using ClaimTheSquareFullStack.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/textobject", () =>
{
    var json = File.ReadAllText("textobjects.json");
    var textobjects = JsonSerializer.Deserialize<List<TextObject>>(json);
    return textobjects;
});
app.MapPost("/textobject", (TextObject textobject) =>
{
    var json = File.ReadAllText("textobjects.json");
    var textobjects = JsonSerializer.Deserialize<List<TextObject>>(json);
    textobjects.Add(textobject);
    json = JsonSerializer.Serialize(textobjects);
    File.WriteAllText("textobjects.json", json);
});
app.UseStaticFiles();
app.Run();

/*
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
   Console.WriteLine($"{p.Name} {p.Email}");
   });
 */
