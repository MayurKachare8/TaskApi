using NUnit.Framework;
using Task_Management.Controllers;
using Task_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Castle.Core.Configuration;

namespace TestTasKManagement
{
    public class TaskTest
    {
        TaskApiController ap = new TaskApiController();

        /// <summary>
        /// Getting All tasks
        /// </summary>
        [Test]
        public void GetTask()
        {
            var check = ap.GetAllTask();
            Assert.NotNull(check); 
        }

        /// <summary>
        /// Checking Task with available id
        /// </summary>
        [Test]
        public void GetTaskByAvailableId()
        {
           
            int id = 1;
            var check = ap.GetTaskById(id);
            Assert.NotNull(check);
        }
        /// <summary>
        /// Checking with task id which is not available in file
        /// </summary>
        [Test]
        public void GetTaskByUnavailableId()
        {
            int id =11;
            var check = ap.GetTaskById(id);
            Assert.IsEmpty(check);
  
        }

        /// <summary>
        /// Checking task inserted or not
        /// </summary>
        [Test]
        public void InsertDataTest()
        {
            var control = new TaskApiController();
            TaskDetails taskfakedetails = new TaskDetails() {
                Id = 8,
                CreatedDate="23 march",
                TaskName = "Join Meeting",
                TaskDescription ="Yoga Day Meeting",
                TaskStatus ="Incomplete",
            };
           
            IActionResult ActionResult = control.PostTasktoJson(taskfakedetails);
          

            Assert.IsNotNull(ActionResult);

        }

        /// <summary>
        /// checking task updating or not
        /// </summary>
        [Test]
        public void UpdateTaskTest()
        { 
            var control=new TaskApiController();
            int id = 2;
            var taskfakedetails = new TaskDetails()
            {
                Id = 8,
                CreatedDate = "28 march",
                TaskName = "Join Meeting",
                TaskDescription = "Yoga Day Meeting",
                TaskStatus = "Incomplete",
            };
           IActionResult ad= control.PutTaskToJasonById(id, taskfakedetails);
            Assert.IsNotNull(ad);
        }

        /// <summary>
        /// checking task is deleting or not
        /// </summary>
        [Test]
        public void DeleteTaskTest()
        {
            var control= new TaskApiController();
            int id = 8;
            IActionResult actionResult = control.DeleteTaskFromJason(id);
            Assert.IsNotNull(actionResult);
        }
    }
}