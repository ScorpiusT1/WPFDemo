using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GenshinCharacterPreview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        private async Task LoadCity(int id)
        {
            string url = $"https://content-static.mihoyo.com/content/ysCn/getContentList?pageSize=20&pageNum=1&order=asc&channelId={id}";

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
        }
    }
}
