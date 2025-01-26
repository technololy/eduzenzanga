using EduZanga.Web.Components;
using MudBlazor;
using MudBlazor.Services;

namespace EduZanga;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMudServices();
        
        // Change the default appearance of all MudButton components
        MudGlobal.ButtonDefaults.Variant = Variant.Filled;
        
        
        // Change the default appearance of all MudButton components
        MudGlobal.InputDefaults.Variant = Variant.Outlined;

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

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
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode()
            .AddAdditionalAssemblies(typeof(EduZanga.Shared._Imports).Assembly);

        app.Run();
    }
}
