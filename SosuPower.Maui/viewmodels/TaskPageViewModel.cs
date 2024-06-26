﻿using SosuPower.Entities;
using SosuPower.Services;
using System.Collections.ObjectModel;

namespace SosuPower.Maui.viewmodels
{
    public partial class TaskPageViewModel : BaseViewModel
    {
        // DNF - Did Not Finish
        private readonly ISosuService sosuService;
        public ObservableCollection<SubTask> SubTasks { get; } = new();

        public TaskPageViewModel(ISosuService sosuService)
        {
            this.sosuService = sosuService;
        }


    }
}
