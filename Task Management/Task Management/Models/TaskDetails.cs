namespace Task_Management.Models
{
    public class TaskDetails
    {
        public int Id { get; set; }
        public string CreatedDate { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        public string TaskStatus { get; set; }
       



        public bool Equals(TaskDetails other)
        {
            throw new NotImplementedException();
        }

        public TaskDetails dataTaskDetails()
        {
            TaskDetails taskDetails = new TaskDetails()
            {
                Id = 0,
                CreatedDate = "",
                TaskName = "",
                TaskDescription = "",
                TaskStatus = ""
            };
        return taskDetails;
        
        }
        
    }
}
