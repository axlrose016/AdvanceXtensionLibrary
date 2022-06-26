using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvanceXtensionLibrary_Repository.Core.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceXtensionLibrary_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentRepository SRepo;
        public StudentController(IStudentRepository repo) { SRepo = repo; }
        [HttpGet, Route("GetStudentListByBranch/{brachId}")]
        public async Task<ActionResult> GetStudentListByBranch([FromRoute] string branchId)
        {
            int id = Convert.ToInt32(branchId);
            var StudList = await SRepo.GetStudentByBranch(id);
            int count = StudList.Count();
            if (count <= 0)
                return NotFound("No Record Found.");
            else
                return Ok(StudList);
        }
    }
}