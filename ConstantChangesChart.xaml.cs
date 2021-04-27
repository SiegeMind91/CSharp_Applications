using System.Windows;
using System.Windows.Controls;
using LiveCharts;
using CodeClinic;
using System.Threading;
using LiveCharts.Configuration;
using System.ComponentModel;

namespace Dashboard
{
    ///<summary>
    ///Interaction logic for ConstantChangesChart.xaml
    ///</summary>

    public partial class ConstantChangesChart : UserControl, NotifyPropertyChanged
    {
        private static long tickZero = DateTime.Parse("2018-01-01T08:00:00Z").Ticks;

        public Func<double, string> X_Axis_LabelFormatter { get; set; } = d => TimeSpan.FromTicks((long)d - tickZero).TotalSeconds.ToString();

        public ConstantChangesChart()
        {
            InitializeComponent();

            lsEfficiency.Configuration = Mappers.Xy<FactoryTelemetry>().X(ft => ft.TimeStamp.Ticks).Y(ft => ft.Efficiency);

            lsPulse.Configuration = Mappers.Xy<FactoryTelemetry>().X(ft => ft.TimeStamp.Ticks).Y(ft => ft.Pulse);

            lsRed.Configuration = Mappers.Xy<FactoryTelemetry>().X(ft => ft.TimeStamp.Ticks).Y(ft => ft.Red);
            lsBlue.Configuration = Mappers.Xy<FactoryTelemetry>().X(ft => ft.TimeStamp.Ticks).Y(ft => ft.Blue);
            lsGreen.Configuration = Mappers.Xy<FactoryTelemetry>().X(ft => ft.TimeStamp.Ticks).Y(ft => ft.Green);

            DataContext = this;
        }

        public ChartValues<FactoryTelemetry> Chartvalues { get; set; } = new ChartValues<FactoryTelemetry>();

        private bool readingData = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!readingData)
            {
                Task.Factory.StartNew(ReadData);
            }
            readingData = !readingData
        }

        private void ReadData()
        {
            //ToDo: Populate the collection ChartValues 
            string filename = @"SampleDataFile.csv";

            foreach (var ft in FactoryTelemetry.Load(filename))
            {
                if(!readingData)
                    return; //This allows us to stop the data read when we click the stop button

                ChartValues.Add(ft);

                this.EngineEfficiency = ft.Efficiency;

                AdjustAxis(ft.TimeStamp.Ticks);

                if (ChartValues.Count > 30) 
                {
                    ChartValues.RemoveAt(0);
                }

                Thread.Sleep(50); //This controls the speed at which the data is read, the higher the number the slower it goes
            }
        }

        public double AxisStep { get; set; } = TimeSpan.FromSeconds(5).Ticks;
        public double AxisUnit { get; set; } = TimeSpan.FromSeconds(1).Ticks;

        private double _axisMax = tickZero + TimeSpan.FromSeconds(30).Ticks;
        public double AxisMax { get => _axisMax; set { _axisMax = value; OnPropertyChanged(nameof(AxisMax)); }}

        private double _axisMin = tickZero;
        public double AxisMin { get => _axisMin; set { _axisMin = value; OnPropertyChanged(nameof(AxisMin)); }}

        private void AdjustAxis(long ticks)
        {
            var width = TimeSpan.FromSeconds(30).Ticks;

            AxisMin = (ticks - tickZero < width) ? tickZero : ticks-width;
            AxisMax = (ticks - tickZero < width) ? tickZero + width : ticks;
        }

        private double _EngineEfficiency = 65;
        public double EngineEfficiency 
        { 
            get 
            {
                return _EngineEfficiency;
            }
            set 
            {
                _EngineEfficiency = value;
                OnPropertyChanged(nameof(EngineEfficiency));
            }
        }; 

        //Here we're creating an event handler for any time a property changes
        //This allows the xaml to recognize that the value changed and should be updated, 
        // which gives us the flow of data to the visual
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name = null) => 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}