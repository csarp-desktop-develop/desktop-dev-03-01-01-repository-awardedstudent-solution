﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MenuProject.Repos;
using MenuProject.SchoolCitizens;
using MenuProject.ViewModels.Base;
using System.Collections.ObjectModel;

namespace MenuProject.ViewModels.SchoolCitizens
{
    public partial class StudentViewModel : BaseViewModel
    {
        private readonly EducationLevelsRepo _educationLevelsRepo = new();
        private readonly StudentRepo _studentRepo = new();

        [ObservableProperty]
        private ObservableCollection<string> _educationLevels = new();

        [ObservableProperty]
        private ObservableCollection<Student> _students = new();

        [ObservableProperty]
        private Student _selectedStudent;        
        
        public StudentViewModel()
        {
            _selectedStudent = new Student();
            UpdateView();
        }
       
        private void UpdateView()
        {
            EducationLevels = new ObservableCollection<string>(_educationLevelsRepo.FindAll());
            Students = new ObservableCollection<Student>(_studentRepo.FindAll());
        }
    }
}
