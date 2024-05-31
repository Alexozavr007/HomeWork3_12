namespace HomeWork3_12_3;

public class Presenter {
    public MainWindow View { get; }
    public Timer Model { get; }

    public Presenter(MainWindow view, Timer model) {
        View = view;
        Model = model;

        view.btnStart.Click += BtnStart_Click;
        view.btnStop.Click += BtnStop_Click;
        view.btnReset.Click += BtnReset_Click;

        model.OnSecondsChanged += Model_OnSecondsChanged;
    }

    private void Model_OnSecondsChanged() {
        //View.txtTimerValue.Text = Model.TotalSeconds.ToString();
        var hours = Model.TotalSeconds / 3600;
        var minutes = (Model.TotalSeconds - hours * 3600) / 60;
        var seconds = (Model.TotalSeconds - hours * 3600 - minutes * 60);

        View.txtTimerValue.Text = $"{hours:d2}:{minutes:d2}:{seconds:d2}";
    }

    private void BtnReset_Click(object sender, System.Windows.RoutedEventArgs e) {
        Model.Reset();
    }

    private void BtnStop_Click(object sender, System.Windows.RoutedEventArgs e) {
        Model.Stop();
    }

    private void BtnStart_Click(object sender, System.Windows.RoutedEventArgs e) {
        Model.Start();
    }

}
