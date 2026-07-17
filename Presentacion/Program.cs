using Negocio; // Permite conectar con la capa de negocio

var builder = WebApplication.CreateBuilder(args);

// 1. Lee la cadena de conexión desde el appsettings.json
var cadena = builder.Configuration.GetConnectionString("DefaultConnection")!;

// 2. Registra la capa de negocio (que a su vez registra el acceso a datos)
builder.Services.AddLogicaNegocio(cadena);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();