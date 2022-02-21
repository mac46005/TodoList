using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DataAccess_ClassLib.DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDo_ClassLib.DataAccess;
using ToDo_ClassLib.Interfaces;
using ToDo_ClassLib.Models;
using ToDoList_UI.MVVM.Models;
using ToDoList_UI.MVVM.ViewModels;

namespace ToDoList_UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IServiceProvider ServiceProvider { get; set; }
        public IConfiguration Configuration { get; set; }



        protected override void OnStartup(StartupEventArgs e)
        {
            Configuration = BuildConfiguration();
            ServiceProvider = CreateServiceProvider();



            Window window = new MainWindow();
            var mainViewModel = ServiceProvider.GetRequiredService<MainViewModel>();
            
            window.DataContext = mainViewModel;
            
            window.Show();
            base.OnStartup(e);
        }



        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddScoped<MainViewModel>();
            services.AddSingleton<IConfiguration>(this.Configuration);
            // Data services
            services.AddTransient<ISqlDataAccess<IConfiguration>, SqlDataAccess>();
            services.AddTransient<ICategoryItemDataAccess<IToDoItem,int>, ToDoItemsDataAccess>();
            services.AddTransient<ICategoryItemDataAccess<ICompletedItem, int>, CompletedItemsDataAccess>();
            services.AddTransient<IDataAccessAsync<ICategory, int>, CategoriesDataAccess>();
            // ViewModels
            services.AddTransient<IToDoItem, ToDoItem>();
            services.AddTransient<ICompletedItem,CompletedItem>();
            services.AddTransient<ICategory, Category>();
            services.AddSingleton<ToDoOperationManager>();
            services.AddTransient<CategoryData>( (s) => 
            {
                var toDoOps = s.GetService<ToDoOperationManager>();
                ICategoryData? categoryData;
                Task.Run(async () => categoryData = await toDoOps.GetCategoryData());
                var catData = new CategoryData(categoryData);
                s.
                return s.GetService<CategoryData>(catData);
            });
            // Models
            //services.AddTransient<CategoryData>();

            
            return services.BuildServiceProvider();
        }

        private IConfiguration BuildConfiguration()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json",optional:false);
            return builder.Build();
        }

    }
}
