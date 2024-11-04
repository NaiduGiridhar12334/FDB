using FDBApiConnector.Common;
using FDBApiConnector.CoreDrug;
using FDBApiConnector.CoreDrug.Interface;
using FDBOrchestration.CoreDrug;
using FDBOrchestration.CoreDrug.Interface;
using FDBViewModel.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection("ApiSettings"));

//orchestartion
builder.Services.AddScoped<ICoreDrugOrchestration, CoreDrugOrchestration>();

//service
builder.Services.AddScoped<ICoreDrugService, CoreDrugService>();
builder.Services.AddHttpClient<IApiClient, ApiClient>();


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
