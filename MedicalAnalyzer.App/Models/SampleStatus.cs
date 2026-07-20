using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAnalyzer.App.Models
{
    //枚举状态
    public enum SampleStatus
    {
        
        Registered,　　　//受付済み
        Measuring,       //測定中
        Completed,　　　 //完了
        Error,　　　　　//エラー
        Cancelled　　　　//中止
    }
}
