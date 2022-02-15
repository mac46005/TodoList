using System;
using System.Windows.Threading;
using ToDo_ClassLib.Interfaces;

namespace ToDoList_UI.MVVM.ViewModels
{
    /// <summary>
    /// The ToDoItem ViewModel. Designed to represent the user a single ToDoItem.
    /// It also has the logic for editing, and deleting the ToDoItem
    /// </summary>
    public class ToDoItemViewModel : BaseViewModel<IToDoItem>
    {
        /// <summary>
        /// Dispatcher timer is set to count in milliseconds...unless I changed it later.
        /// </summary>
        DispatcherTimer _timer;







        private TimeSpan _dateCountDown;
        /// <summary>
        /// Counts down the amount of time left from the ITodoItem.DueDate
        /// </summary>
        public TimeSpan DateCountDown
        {
            get { return _dateCountDown; }
            set 
            { 
                _dateCountDown = value;
                OnPropertyChanged("DateCountDown");
            }
        }

        /// <summary>
        /// Constructor recieves a IToDoItem From the CategoryData models from the WPF project
        /// </summary>
        /// <param name="toDoItem"></param>
        public ToDoItemViewModel(IToDoItem toDoItem)
        {
            Model = toDoItem;
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        /// <summary>
        /// Tick updates every millisecond and updates the DateCountDown as well as the Model (ItemToDo object)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _timer_Tick(object? sender, EventArgs e)
        {
            OnPropertyChanged("Model");
            DateCountDown = Model.DueDate - DateTime.Now;
        }
    }
}
