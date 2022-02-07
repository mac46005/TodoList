﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList_UI.MVVM.ViewModels
{
    internal interface IViewModel<T>
    {
        T Model { get; set; }
    }
}