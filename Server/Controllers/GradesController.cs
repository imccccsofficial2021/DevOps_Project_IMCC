using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MudBlazorWASM.Server.Data;
using MudBlazorWASM.Shared.Models;

namespace MudBlazorWASM.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly WebAppDbContext _webAppDb;
        public GradesController(WebAppDbContext webAppDb)
        {
            _webAppDb = webAppDb;
        }

        [HttpGet]
        [Route("GetAllGrades")]
        public async Task<ActionResult<List<SummaryGrade>>> GetAllGrades()
        {
            if (_webAppDb.SummaryGrades == null)
                return NotFound();

            var grades = await _webAppDb.SummaryGrades.ToListAsync();
            return Ok(grades);
        }

        [HttpGet]
        [Route("GetStudentID")]
        public async Task<ActionResult<List<SummaryGrade>>> GetStudentID(int offerno)
        {
            if (_webAppDb.SummaryGrades == null)
                return NotFound();

            var grades = await _webAppDb.SummaryGrades.FirstOrDefaultAsync(sh => sh.Offerno == offerno);
            return Ok(grades);
        }

        [HttpPost]
        [Route("AddNewGrade")]
        public async Task<ActionResult<List<SummaryGrade>>> CreateNewGrade([FromBody] SummaryGrade summaryGrade)
        {
            _webAppDb.SummaryGrades.Add(summaryGrade);
            await _webAppDb.SaveChangesAsync();

            return Ok(await GetDbListGrades());
        }

        [HttpPut("{offerno}")]
        [Route("UpdateAllGrades")]
        public async Task<ActionResult<List<SummaryGrade>>> UpdateAllGrades([FromBody] SummaryGrade summaryGrade, int offerno)
        {
            var grades = await _webAppDb.SummaryGrades.FirstOrDefaultAsync(sh => sh.Offerno == offerno);
            if (grades == null)
                return NotFound("Sorry, Offer Number Not Found!");

            grades.Deptno = summaryGrade.Deptno;
            grades.Offerno = summaryGrade.Offerno;
            grades.Courseno = summaryGrade.Courseno;
            grades.Studno = summaryGrade.Studno;
            grades.Last = summaryGrade.Last;
            grades.First = summaryGrade.First;
            grades.Mi = summaryGrade.Mi;
            grades.Term1 = summaryGrade.Term1;
            grades.Term2 = summaryGrade.Term2;
            grades.Term3 = summaryGrade.Term3;
            grades.Term4 = summaryGrade.Term4;
            grades.Average = summaryGrade.Average;
            grades.Subjects = summaryGrade.Subjects;

            await _webAppDb.SaveChangesAsync();

            return Ok(await GetDbListGrades());

        }

        [HttpDelete("{offerno}")]
        public async Task<ActionResult<List<SummaryGrade>>> DeleteGradesByOfferNo([FromBody] int offerno)
        {
            var grades = await _webAppDb.SummaryGrades
                .FirstOrDefaultAsync(sh => sh.Offerno == offerno);
            if (grades == null)
                return NotFound("Sorry, Offer Number Not Found!");

            _webAppDb.SummaryGrades.Remove(grades);
            await _webAppDb.SaveChangesAsync();

            return Ok(await GetDbListGrades());
        }

        private async Task<ActionResult<List<SummaryGrade>>> GetDbListGrades()
        {
            return await _webAppDb.SummaryGrades.ToListAsync();
        }

    }
}
