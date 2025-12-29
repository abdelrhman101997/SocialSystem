using Microsoft.Data.SqlClient;
using Social.Application.Configration;
using Social.Infrastructure.Configration;
using Social.PL.API.Configration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddInfastructureService(builder.Configuration);
builder.Services.AddApplicationService();
builder.Services.AddAPIService();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    // ?????? ????? ???? ???API
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Social Network API",
        Version = "v1",
        Description = "Demo project with Clean Architecture"
    });

    // ?????? ???????? JWT Bearer ?? ??????? (?? ??????? JWT ????)
    options.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Description = "???? ?????? ???: Bearer {token}",
        Name = "Authorization",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "Bearer"
    });

    options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
            
        }
    });
});


builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.AddAPIWeb();
app.AddInfastructureWeb();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
