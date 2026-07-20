using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAnalyzer.App.Models
{
    //Sample對象數據形式
    public class Sample
    {
        public string Id { get; set; } = string.Empty;
        public string TestItem { get; set; } = string.Empty;
        public SampleStatus Status { get; set; } = SampleStatus.Registered;
        public DateTime RegisteredAt { get; set; } = DateTime.Now;
        public int Progress { get; set; }

     
    }
}
