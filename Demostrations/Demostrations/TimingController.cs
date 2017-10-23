using System;
using System.Threading;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace Demostrations
{
    public class TimingController : IDisposable
    {
        protected TimeSpan Time;
        protected Task TimingTask;
        private long _initializeSeconds;
        readonly ManualResetEvent _resetEvent = new ManualResetEvent(false);
        protected CancellationTokenSource TokenSource = new CancellationTokenSource();
        public TimingController()
        {
            TimingTask = new Task(Timing, TokenSource.Token);
            TimingTask.Start();
        }

        public TimingType Type { get; set; }

        public long InitializeSeconds
        {
            get { return _initializeSeconds; }
            set
            {
                _initializeSeconds = value;
                Time = TimeSpan.FromSeconds(value);
            }
        }

        public Action<string> DisplayAction { get; set; }

        public string DisplayTime => $"{Time.Minutes:00}:{Time.Seconds:00}";

        public void Dispose()
        {
            TokenSource.Cancel();
        }

        private void Timing()
        {
            while (true)
            {
                if (Time.Milliseconds < 0)
                {
                    break;
                }
                Console.WriteLine(TimingTask.Status);
                _resetEvent.WaitOne();
                Time = Type == TimingType.Increase
                    ? Time.Add(TimeSpan.FromMilliseconds(100))
                    : Time.Add(-TimeSpan.FromMilliseconds(100));
                if (TokenSource.Token.IsCancellationRequested)
                {
                    Console.WriteLine("Cancelled");
                    break;
                }
                if (Type == TimingType.Decrease && Time.Seconds == 0 && Time.Milliseconds == 0)
                {
                    Console.WriteLine("Time up");
                    break;
                }
                DisplayAction?.Invoke(DisplayTime);
                Thread.Sleep(100);
            }
        }

        public void Start()
        {
            if (TimingTask.Status == TaskStatus.RanToCompletion)
            {
                TimingTask = new Task(Timing, TokenSource.Token);
                TimingTask.Start();
            }
            _resetEvent.Set();
        }

        public void Pause()
        {
            _resetEvent.Reset();
        }

        public void Reset()
        {
            Time = TimeSpan.FromSeconds(InitializeSeconds);
        }

        public void Quit()
        {
            TokenSource.Cancel();
        }
    }

    public enum TimingType
    {
        Increase,
        Decrease
    }
}