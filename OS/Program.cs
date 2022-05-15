using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using OS.Controllers;
using OS.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IAnimalStorage, AnimalStorage>();
builder.Services.AddSingleton<IArealStorage, ArealStorage>();

builder.Services.AddHealthChecks().AddCheck<HealthCheckController>("health");
builder.Host.UseSystemd();

var app = builder.Build();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapHealthChecks("/health").RequireHost("localhost:5000");
});
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// убираем редирект, чтобы не париться с ssl сертификатом
//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

