using Microsoft.AspNetCore.Components;
using MudBlazorWASM.Shared.Models;

namespace MudBlazorWASM.Server.Services
{
    public class GradeService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public GradeService(HttpClient http, NavigationManager navigationManager)
        {
            _http = http;
            _navigationManager = navigationManager;
        }

        public List<SummaryGrade> AllGrades { get; set; } = new List<SummaryGrade>();

        public async Task GetAllGrades()
        {
            //return AllGrades.ToList();
            // _navigationManager.NavigateTo("egrades");
            var result = await _http.GetFromJsonAsync<List<SummaryGrade>>("api/grades/GetAllGrades");
            if (result != null)
                AllGrades = result;
        }

        public async Task<SummaryGrade> GetStudentID(int offerno)
        {
            var studno = await _http.GetFromJsonAsync<SummaryGrade>("api/grades/{offerno}");
            if (studno != null)
                return studno;
            throw new Exception("Student Details Not Found!");

        }

        public async Task DeleteGradesByOfferNo(int offerno)
        {
            var result = await _http.DeleteAsync($"api/grades/{offerno}");
            await SetGrades(result);
        }

        private async Task SetGrades(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<SummaryGrade>>();
            AllGrades = response;
            _navigationManager.NavigateTo("egrades");
        }



    }
}
