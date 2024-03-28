using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Domain.Repositories;
using ProyectoFinal.InfrastructureData.Data;
using ProyectoFinal.InfrastructureData.Repositories;
using ProyectoFinal.Application.Services;
using ProyectoFinal.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IFichaClienteRepository), typeof(FichaClienteRepository));
builder.Services.AddScoped(typeof(IRegistroRepository), typeof(RegistroRepository));
builder.Services.AddScoped(typeof(IUsuarioSalonRepository), typeof(UsuarioSalonRepository));
builder.Services.AddScoped(typeof(IRoleRepository), typeof(RoleRepository));

builder.Services.AddScoped(typeof(IFichaServices), typeof(FichaServices));
builder.Services.AddScoped(typeof(IRegistroServices), typeof(RegistroServices));
builder.Services.AddScoped(typeof(IUsuarioSalonServices), typeof(UsuarioSalonServices));
builder.Services.AddScoped(typeof(IJWTService), typeof(JWTService));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder
    .AllowAnyOrigin()
       .AllowAnyMethod()
        .AllowAnyHeader());


app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
