﻿using TaskList.ViewModels;
using Xamarin.Forms;

namespace TaskList.Pages
{
    public partial class TaskList : ContentPage
    {
        public TaskList()
        {
            InitializeComponent();
            BindingContext = new TaskListViewModel();
        }
    }
}
