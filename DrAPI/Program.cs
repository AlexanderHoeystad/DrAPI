using DrAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(option =>
{
    option.AddPolicy(name: "AllowAll",
              builder =>
              {
                  builder.AllowAnyOrigin(); // WithOrigins("http://localhost:3000");
                  builder.AllowAnyMethod(); // WithMethods("GET", "POST", "PUT", "DELETE");
                  builder.AllowAnyHeader(); // WithHeaders("Accept", "Content-Type", "Origin", "X-My-Header");
              });
});

builder.Services.AddControllers();
builder.Services.AddSingleton<MusicRecordsRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
