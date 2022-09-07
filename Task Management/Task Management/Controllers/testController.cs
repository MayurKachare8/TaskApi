using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task_Management.Models;

namespace Task_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testController : ControllerBase
    {
        List<TaskDetails>testList = new List<TaskDetails>();

            [HttpPost]
        public async Task<ActionResult<TaskDetails>> New(TaskDetails tDetails)
        {
            //db.Products.Add(product);
            //await db.SaveChangesAsync();

            testList.Add(tDetails);
            

            

            return CreatedAtAction("GetProduct", new { id = tDetails.Id }, tDetails);
        }
    }
}
