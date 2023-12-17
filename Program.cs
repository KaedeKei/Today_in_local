using System.Globalization;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/local", (string? language) => GetNow(language));
app.Run();

string GetNow(string language)
{
    CultureInfo culture = new CultureInfo(language, false);
    var today = DateTime.Now;
    string result = culture.NativeName + " " + today.ToString(culture);
    return result;
}
