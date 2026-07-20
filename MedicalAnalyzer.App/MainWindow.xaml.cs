using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using MedicalAnalyzer.App.Models;

namespace MedicalAnalyzer.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Sample> Samples { get; } = new();

        public MainWindow()
        {
            InitializeComponent();

            CreateSampleData();

            DataContext = this;
        }

        private void CreateSampleData()
        {
            Samples.Add(new Sample
            {
                Id = "S-001",
                TestItem = "血液一般検査",
                Status = SampleStatus.Registered,
                RegisteredAt = DateTime.Now.AddMinutes(-15),
                Progress = 0
            });

            Samples.Add(new Sample
            {
                Id = "S-002",
                TestItem = "生化学検査",
                Status = SampleStatus.Measuring,
                RegisteredAt = DateTime.Now.AddMinutes(-10),
                Progress = 50
            });

            Samples.Add(new Sample
            {
                Id = "S-003",
                TestItem = "免疫検査",
                Status = SampleStatus.Completed,
                RegisteredAt = DateTime.Now.AddMinutes(-5),
                Progress = 100
            });
        }
    }
}
