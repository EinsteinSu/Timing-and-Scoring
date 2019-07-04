using DevExpress.Mvvm;

namespace WaterPolo.Simple.Core.Display
{
    public class Player : ViewModelBase, IPlayerRaw
    {
        public Player()
        {

        }

        public const int TwSeconds = 20;
        public virtual string Number { get; set; }

        public virtual string Name { get; set; }

        private int _fouls;
        public virtual int Fouls
        {
            get
            {
                return _fouls;
            }
            set
            {
                SetProperty(ref _fouls, value, () => Fouls);
                FoulTime = TwSeconds;
                RaisePropertiesChanged("FoulTime");
            }
        }

        public virtual int FoulTime { get; set; }

        public int OrderNumber { get; set; }

        public void DecreaseFoulTime()
        {
            if (FoulTime > 0)
            {
                FoulTime--;
            }
        }
    }
}
