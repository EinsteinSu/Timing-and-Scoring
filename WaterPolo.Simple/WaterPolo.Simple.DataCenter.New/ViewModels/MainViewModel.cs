using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WaterPolo.Simple.DataCenter.New.Views;

namespace WaterPolo.Simple.DataCenter.New
{
    public class MainViewModel : NavigationViewModelBase
    {
        public ReadOnlyCollection<IHamburgerMenuItemViewModel> HamburgerMenuItems { get; }
        public ReadOnlyCollection<IHamburgerMenuBottomBarItemViewModel> HamburgerMenuBottomBarItems { get; }

        public object HamburgerMenuSelectedItem
        {
            get { return GetProperty(() => HamburgerMenuSelectedItem); }
            set
            {
                SetProperty(() => HamburgerMenuSelectedItem, value);
            }
        }

        public MainViewModel()
        {
            HamburgerMenuItems = new ReadOnlyCollection<IHamburgerMenuItemViewModel>(InitializeMenuItems());
            HamburgerMenuBottomBarItems = new ReadOnlyCollection<IHamburgerMenuBottomBarItemViewModel>(InitializeBottomBarItems());
        }

        protected virtual IList<IHamburgerMenuItemViewModel> InitializeMenuItems()
        {
            var result = new List<IHamburgerMenuItemViewModel>();
            result.Add(new NavigationItemModel("Home") { NavigationTarget = typeof(Home), Glyph = "Icons/Home.png" });
            result.Add(new SeparatorItem());
            result.Add(new NavigationItemModel("Members") { NavigationTarget = typeof(PlayerEditView), Glyph = "Icons/Menu.png" });
            result.Add(new NavigationItemModel("Schedules") { NavigationTarget = typeof(ScheduleEditView), Glyph = "Icons/Menu.png" });
            //var subMenu = new SubMenuItemModel("Members") { Glyph = "Icons/Menu.png" };
            //subMenu.Items.Add(new SubMenuNavigationItemModel("Teams", null) { NavigationTarget = typeof(TeamEditView), ShowInPreview = true, SelectOnClick = false });
            //subMenu.Items.Add(new SubMenuNavigationItemModel("Players", null) { NavigationTarget = typeof(PlayerEditView), ShowInPreview = true, SelectOnClick = false });
            //var scheduleMenu = new SubMenuItemModel("Schedules") { Glyph = "Icons/Menu.png" };
            //scheduleMenu.Items.Add(new SubMenuNavigationItemModel("Schedule Edit", null) { NavigationTarget = typeof(ScheduleEditView), ShowInPreview = true, SelectOnClick = false });
            //result.Add(subMenu);
            //result.Add(scheduleMenu);
            result.Add(new HyperlinkItemModel("More information...", new Uri("https://www.devexpress.com/")) { IsAlternatePlacementItem = true, });
            result.Add(new NavigationItemModel("About") { NavigationTarget = typeof(About), IsAlternatePlacementItem = true, Glyph = "Icons/About.png" });
            return result;
        }
        protected virtual IList<IHamburgerMenuBottomBarItemViewModel> InitializeBottomBarItems()
        {
            return new List<IHamburgerMenuBottomBarItemViewModel>() {
                new BottomBarNavigationItemModel() { NavigationTarget = typeof(SettingsView), Glyph = "Icons/Settings.png", IsAlternatePlacementItem = true },
                new BottomBarCheckableItemModel() { Glyph = "Icons/Check.png" },
                new BottomBarRadioItemModel("RadioGroup") { Glyph = "Icons/Radio1.png" },
                new BottomBarRadioItemModel("RadioGroup") { Glyph = "Icons/Radio2.png" }
            };
        }
    }
}
