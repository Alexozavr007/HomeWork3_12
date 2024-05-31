using System.Windows;

namespace HomeWork3_12_3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {

    private Presenter _presenter;

    public MainWindow() {
        InitializeComponent();
        _presenter = new Presenter(this, new Timer());
    }



}