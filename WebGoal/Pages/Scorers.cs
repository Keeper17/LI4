using WebGoal.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace WebGoal.Pages
{
    public partial class Scorers

    {
        private Root Main;
        private string League = "PPL";
        private async Task GetDataAsync()
        {
                string uri = "https://api.football-data.org/v2/competitions/"+League+"/scorers";
                Main = await Http.GetJsonAsync<Root>(uri);
        }


        protected override async Task OnInitializedAsync()
        {
            await GetDataAsync();
        }

    }
}
