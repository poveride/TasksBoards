using Microsoft.EntityFrameworkCore;

namespace TasksBoards.Entities
{
    public class WorkItem
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string Area { get; set; }
        public string IterationPath { get; set; }
        public int Priority { get; set; }

        // Epic
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        //Issue
        public Decimal Efford { get; set; }
        //Task
        public string Activity { get; set; }
        [Precision(14,2)]
        public Decimal RemainingWork { get; set; }

    }
}
