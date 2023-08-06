using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GenshinCharacterPreview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinCharacterPreview.ViewModels
{
    public partial class MainWindowViewModel:ObservableObject
    {
        [ObservableProperty]
        public Character character = new();

        [ObservableProperty]
        Character selectedItem;

        [RelayCommand]
        private void LoadCity()
        {

        }
    }
}
