using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using ToDo_ClassLib.Interfaces;
using ToDo_ClassLib.Models;

namespace ToDoList_UI.MVVM.ViewModels
{
    /// <summary>
    /// Single ToDoItem viewmodel
    /// </summary>
    public class ToDoItemViewModel : BaseViewModel<IToDoItem>
    {

        DispatcherTimer _timer;



        private TimeSpan _dateCountDown;
        public TimeSpan DateCountDown
        {
            get { return _dateCountDown; }
            set 
            { 
                _dateCountDown = value;
                OnPropertyChanged("DateCountDown");
            }
        }


        public ToDoItemViewModel(IToDoItem toDoItem)
        {
            Model = toDoItem;
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            OnPropertyChanged("Model");
            DateCountDown = Model.DueDate - DateTime.Now;
        }
    }
}
