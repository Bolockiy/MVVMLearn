using LearnMVVM.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _title = "Тестовое mvvm";
        public string Title { 
            get => _title;
            //if(value == _title) return;
            //_title = value;
            //    onPropertyChanged();
            //    Set(ref _title, value);
            set => Set(ref _title, value);
        }
    }
}
