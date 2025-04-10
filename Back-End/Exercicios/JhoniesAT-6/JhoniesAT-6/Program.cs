var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte a controllers e views (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura o pipeline de requisi��es HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // HTTP Strict Transport Security
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // <-- Este � o correto para servir arquivos est�ticos como CSS/JS/imagens

app.UseRouting();

app.UseAuthorization(); // se estiver usando autentica��o

// Define a rota padr�o da aplica��o MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();