using DevExpress.Mvvm;

namespace WaterPolo.Simple.DisplayConsole
{
    public class DisplaySettings : ViewModelBase
    {
        private double _x;
        private double _y;
        private double _height;
        private double _width;
        private int _listeningPort;
        private int _compacity;

        public double X
        {
            get => _x;
            set => SetProperty(ref _x, value, () => X);
        }

        public double Y
        {
            get => _y;
            set => SetProperty(ref _y, value, () => Y);
        }

        public double Height
        {
            get => _height;
            set => SetProperty(ref _height, value, () => Height);
        }

        public double Width
        {
            get => _width;
            set => SetProperty(ref _width, value, () => Width);
        }

        public int ListeningPort
        {
            get => _listeningPort;
            set => SetProperty(ref _listeningPort, value, () => ListeningPort);
        }

        public int Compacity
        {
            get => _compacity;
            set => SetProperty(ref _compacity, value, () => Compacity);
        }
    }
}