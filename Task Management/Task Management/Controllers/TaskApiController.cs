using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Task_Management.Models;

namespace Task_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskApiController : ControllerBase
    {
        //Suggesions : 1 . Declare file in relative path
        //             2 . Naming Conventions
        //             3 . While Updating the value need to update the specific value only
        //             4 . Follow Object oriented Programming
        //             5 . Avoid Repeatative Code 
        
        /// <summary>
        /// Task Details Saved in Json File named as TaskData
        /// </summary>
        private string jsonFile = @"D:\WebAPI\Task Management\Task Management\DataFile\TaskData.json";

        /// <summary>
        /// Getting all Task realted Details  
        /// </summary>
        /// <returns>All Task</returns>
        // GET: api/<TaskApiController>
        [HttpGet]
        public IEnumerable<TaskDetails> GetAllTask()
        {
            //return taskDeatailsList;
            using (StreamReader reader = new StreamReader(jsonFile))
            {
                string json = reader.ReadToEnd();
                List<TaskDetails> items = JsonConvert.DeserializeObject<List<TaskDetails>>(json);
#pragma warning disable CS8603 // Possible null reference return.
                return items;
#pragma warning restore CS8603 // Possible null reference return.
                reader.Close();
            }
        }

        /// <summary>
        /// Getting Task Details by its id  
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<TaskApiController>/5
        [HttpGet("{id}")]
        public IEnumerable<TaskDetails> GetTaskById(int id)
        {
            using (StreamReader reader = new StreamReader(jsonFile))
            {
                string json = reader.ReadToEnd();
                List<TaskDetails> items = JsonConvert.DeserializeObject<List<TaskDetails>>(json);
                return items.Where(x=>x.Id==id);
                reader.Close();
            }
        }

        //public void PostTasktoJson(global::TestTasKManagement.TaskTestHelper taskTestHelper)
        //{
        //    throw new NotImplementedException();
        //}


        /// <summary>
        /// Adds new Task to the File with all details
        /// </summary>
        /// <param name="postTask"></param>
        /// <returns></returns>
        // POST api/<TaskApiController>
        [HttpPost]
        public IActionResult PostTasktoJson([FromBody] TaskDetails postTask)
        {
            using (StreamReader reader = new StreamReader(jsonFile))
            {
                string json = reader.ReadToEnd();
                List<TaskDetails> items = JsonConvert.DeserializeObject<List<TaskDetails>>(json);

                items.Add(postTask);

                string updatedJson = JsonConvert.SerializeObject(items, Formatting.Indented);
                reader.Close();
                System.IO.File.WriteAllText(jsonFile, updatedJson);
            }
            return Ok();  
        }


        /// <summary>
        /// Update the particular Task Details by using Id 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="putTask"></param>
        // PUT api/<TaskApiController>/5
        [HttpPut("{id}")]
        public IActionResult PutTaskToJasonById(int id, [FromBody] TaskDetails putTask)
        {
                using (StreamReader reader = new StreamReader(jsonFile))
                {
                    string json = reader.ReadToEnd();
                    List<TaskDetails> items = JsonConvert.DeserializeObject<List<TaskDetails>>(json);
                    //items.Insert(id, putTask);
                    items[id] = putTask;
                    string updatedJson = JsonConvert.SerializeObject(items, Formatting.Indented);
                    reader.Close();
                    System.IO.File.WriteAllText(jsonFile, updatedJson);
                }

            return Ok();
        }

        /// <summary>
        /// Deleting the particular Task by using task Id 
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<TaskApiController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteTaskFromJason(int id)
        {
            using (StreamReader reader = new StreamReader(jsonFile))
            {
               
                string json = reader.ReadToEnd();
                List<TaskDetails> items = JsonConvert.DeserializeObject<List<TaskDetails>>(json);

                items.Remove(items.SingleOrDefault(x=>x.Id==id));
                string updatedJson = JsonConvert.SerializeObject(items, Formatting.Indented);
                reader.Close();
                System.IO.File.WriteAllText(jsonFile, updatedJson);
            }
            return Ok();
        }
    }
}
