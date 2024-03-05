using WebGoal.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace WebGoal.Pages
{
    public partial class JogosData
    {

        private Root Main;
        private DateTime Date = DateTime.Now;
        private string League = "PPL";
        private string dateFormatString = "yyyy-MM-dd";
        [Parameter]
        public EventCallback<DateTime?> DateChanged { get; set; }
        private async Task GetDataAsync()
        {

                String dateParsed = Date.ToString(dateFormatString);
                string uri = "https://api.football-data.org/v2/competitions/" + League + "/matches?dateFrom=" + dateParsed + "&dateTo=" + dateParsed;
                Main = await Http.GetJsonAsync<Root>(uri);
            }


        protected override async Task OnInitializedAsync()
        {
            await GetDataAsync();
        }

        public async Task OnDateChanged(ChangeEventArgs e)
        {
            var date = (string)e.Value;
            var newDate = DateTime.Parse(date);
            Date = newDate;
            await DateChanged.InvokeAsync(Date);
            await GetDataAsync();
        }


    }
}
