using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gatekeeper
{
    public class ClassSO
    {
        public int ServiceNum {  get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public string ResponsibleTech {  get; set; }
        public DateTime OpenedDate { get; set; }
        public DateTime Term { get; set; }
        public ServiceStatus Status {  get; set; }
        public Priority Prior {  get; set; }
        public DateTime? FinishedDate { get; set; }

        public enum Priority
        {
            VERY_HIGH,
            HIGH,
            MEDIUM,
            LOW,
            VERY_LOW
        }
        public enum ServiceStatus
        {
            OPEN,
            IN_PROGRESS,
            FINISHED
        }
    }
}
