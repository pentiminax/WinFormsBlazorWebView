using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Projet.Components;

namespace Projet.WinForms;

public partial class Form1 : Form
{
    private BlazorWebView blazorWebView;
    private ServiceCollection serviceCollection;

    public Form1()
    {
        InitializeComponent();

        serviceCollection = new();
        serviceCollection.AddBlazorWebView();
        serviceCollection.AddMudServices();

        blazorWebView = new()
        {
            Dock = DockStyle.Fill,
            HostPage = "wwwroot/index.html",
            Services = serviceCollection.BuildServiceProvider()
        };

        blazorWebView.RootComponents.Add<MainLayout>("#app");

        Controls.Add(blazorWebView);
    }
}