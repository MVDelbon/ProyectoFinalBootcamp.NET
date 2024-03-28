using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ProyectoFinalBlazor2.Data;
using ProyectoFinalBlazor2.Data.Services;
using Radzen;


var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddRadzenComponents();

builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<RegistroService>();
builder.Services.AddScoped<IUsuarioSalonService, UsuarioSalonService>();

builder.Services.AddSweetAlert2();

HttpClient client = new();
client.BaseAddress = new Uri(uriString: "https://localhost:7006/");
builder.Services.AddSingleton<HttpClient>(client);





var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
