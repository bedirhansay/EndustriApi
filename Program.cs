using EndustriApi.DatabaseContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers(); // MVC veya API kontrolörleri için
builder.Services.AddEndpointsApiExplorer(); // API endpoint'leri için Swagger/OpenAPI desteği
builder.Services.AddSwaggerGen(); // Swagger/OpenAPI dokümantasyonu
// builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add DbContext and configure database connection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))); // appsettings.json'daki bağlantı dizesi

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization(); // Yetkilendirme (Authentication varsa kullanılabilir)

app.MapControllers(); // Tüm kontrolör rotalarını otomatik eşleme

app.Run();