using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_UI.Core;

namespace ToDoList_UI.MVVM.ViewModels
{
    public class MainViewModel : ObservableObject, IViewModel<List<object>>
    {
        public List<object> Model { get; set; }
        public static 
        public MainViewModel()
        {
            
        }
    }
}
