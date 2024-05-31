namespace HomeWork3_12_3;

public class Timer {

    public delegate void TimerEmptyDelegate();
    public event TimerEmptyDelegate OnSecondsChanged;

    public int TotalSeconds { get; private set; }
    private System.Windows.Threading.DispatcherTimer _innerTimer;

    public Timer() {
        _innerTimer = new System.Windows.Threading.DispatcherTimer();
        _innerTimer.Interval = new TimeSpan(0, 0, 1);
        _innerTimer.Tick += _innerTimer_Tick;
    }

    private void _innerTimer_Tick(object? sender, EventArgs e) {
        TotalSeconds += 1;
        if (OnSecondsChanged != null) {
            OnSecondsChanged();
        }
    }

    public void Start() {
        _innerTimer.Start();
    }

    public void Stop() {
        _innerTimer.Stop();
    }

    public void Reset() {
        _innerTimer.Stop();
        _innerTimer.Start();
        TotalSeconds = 0;
        if (OnSecondsChanged != null) {
            OnSecondsChanged();
        }
    }

}
