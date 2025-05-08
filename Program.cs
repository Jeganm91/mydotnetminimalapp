var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content(
    @"<html>
      <body style='background-color: lightgreen;'>
        <h1>Welcome to Production Slot!</h1>
        <p>Thank you</p>
      </body>
    </html>", 
    "text/html"
));

app.Run();
