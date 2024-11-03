using FDBApiConnector.CoreDrug;
using FDBApiConnector.CoreDrug.Interface;
using FDBOrchestration.CoreDrug;
using FDBOrchestration.CoreDrug.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


//orchestartion
builder.Services.AddScoped<ICoreDrugOrchestration, CoreDrugOrchestration>();

//service
builder.Services.AddHttpClient<ICoreDrugService, CoreDrugService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();





// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
