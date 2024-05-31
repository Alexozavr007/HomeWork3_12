using System.Windows;

namespace HomeWork3_12_4 {
   

    public partial class MainWindow : Window {

        private Presenter _presenter;

        public MainWindow() {
            InitializeComponent();
            _presenter = new Presenter(this, new CalculatorModel());
        }

    }
}