var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte a controllers e views (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura o pipeline de requisições HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); // HTTP Strict Transport Security
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // <-- Este é o correto para servir arquivos estáticos como CSS/JS/imagens

app.UseRouting();

app.UseAuthorization(); // se estiver usando autenticação

// Define a rota padrão da aplicação MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();