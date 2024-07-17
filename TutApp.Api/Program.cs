using TutApp.Api.Data;
using TutApp.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = "Data Source=GameStore.db";
builder.Services.AddSqlite<GameStoreContext>(connString); 
 
var app = builder.Build();

app.MapGamesEndpoints();

app.Run();
