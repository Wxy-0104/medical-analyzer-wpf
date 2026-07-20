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


        public string SampleText => Status switch
        {
            SampleStatus.Registered => "受付済み",
            SampleStatus.Measuring => "測定中",
            SampleStatus.Completed => "完了",
            SampleStatus.Error => "エラー",
            SampleStatus.Cancelled => "中止"
        };


    }
}
