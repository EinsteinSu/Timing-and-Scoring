using DevExpress.Xpf.Core;

namespace WaterPolo.Simple.DataCenter
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        //protected WaterPoloDataContext Context = new WaterPoloDataContext();
        //protected DataManagerBase ManagerBase;

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Expired

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var button = sender as Button;
        //    var func = button?.Content.ToString();
        //    switch (func)
        //    {
        //        case "Teams":
        //            ManagerBase = new TeamEdit(Context, GridControl);
        //            break;
        //        case "Players":
        //            ManagerBase = new PlayerEdit(Context, GridControl);
        //            break;
        //        case "Schedules":
        //            ManagerBase = new ScheduleEdit(Context, GridControl);
        //            break;
        //        default:
        //            break;
        //    }

        //    ManagerBase?.Refresh();
        //}

        //private void DataEditClick(object sender, RoutedEventArgs e)
        //{
        //    var button = sender as Button;
        //    var func = button?.Content.ToString();
        //    switch (func)
        //    {
        //        case "Refresh":
        //            ManagerBase?.Refresh();
        //            break;
        //        case "Add":
        //            ManagerBase?.AddAndRefresh();
        //            break;
        //        case "Save":
        //            ManagerBase?.Save();
        //            break;
        //        default:
        //            break;
        //    }
        //}

        #endregion
    }
}