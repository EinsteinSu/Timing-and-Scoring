﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Mvvm;
using WaterPolo.Simple.DataCenter.DataEdit;

namespace WaterPolo.Simple.DataCenter
{
    public class MainWindowViewModel : ViewModelBase
    {
        private Feature _currentFeature;
        private object _itemSource;

        public MainWindowViewModel()
        {
            Features = new List<Feature>
            {
                new Feature("Teams", FeatureClick) {DataManager = new TeamEdit()},
                new Feature("Players", FeatureClick) {DataManager = new PlayerEdit()},
                new Feature("Schedules", FeatureClick) {DataManager = new ScheduleEdit()}
            };
            RefreshCommand = new DelegateCommand(OnRefresh, () => CurrentFeature?.DataManager != null);
            AddCommand = new DelegateCommand(OnAdd, () => CurrentFeature?.DataManager != null);
            EditCommand = new DelegateCommand(OnEdit, () => CurrentFeature?.DataManager != null);
            DeleteCommand = new DelegateCommand(OnDelete, () => CurrentFeature?.DataManager != null);
            SaveCommand = new DelegateCommand(OnSave, () => CurrentFeature?.DataManager != null);
            ImportCommand = new DelegateCommand(null, () => CurrentFeature?.DataManager != null);
            ExportCommand = new DelegateCommand(null, () => CurrentFeature?.DataManager != null);
            CopyCommand = new DelegateCommand(OnCopy, () => CurrentFeature?.DataManager != null);
            PasteCommand = new DelegateCommand(OnPaste, () => CurrentFeature?.DataManager != null);
        }

        private IDialogService DialogService => GetService<IDialogService>(CurrentFeature.Name);

        public Feature CurrentFeature
        {
            get => _currentFeature;
            set
            {
                SetProperty(ref _currentFeature, value, () => CurrentFeature);
                OnRefresh();
            }
        }

        public object ItemSource
        {
            get => _itemSource;
            set { SetProperty(ref _itemSource, value, () => ItemSource); }
        }

        public List<Feature> Features { get; set; }

        protected void FeatureClick(Feature feature)
        {
            CurrentFeature = feature;
        }

        protected void OnCopy()
        {
            CurrentFeature?.DataManager.Copy();
        }

        protected void OnPaste()
        {
            CurrentFeature?.DataManager.Paste();
            OnRefresh();
        }

        protected void OnAdd()
        {
            #region  Create Buttons

            var okCommand = new UICommand
            {
                Caption = "Ok",
                IsCancel = false,
                IsDefault = true,
                Command = new DelegateCommand<CancelEventArgs>(
                    x =>
                    {
                        //implement the validation in the dataedit layer
                    }, x => true)
            };
            var cancelCommand = new UICommand
            {
                Caption = "Close",
                IsCancel = true
            };

            #endregion

            var vm = CurrentFeature?.DataManager?.NewItem();
            var result = DialogService.ShowDialog(new List<UICommand> { okCommand, cancelCommand },
                CurrentFeature?.Name, vm);
            if (result == okCommand)
            {
                CurrentFeature?.DataManager?.Add(vm);
                OnRefresh();
            }
        }

        protected void OnSave()
        {
            _currentFeature?.DataManager?.Save();
        }

        protected void OnRefresh()
        {
            ItemSource = _currentFeature?.DataManager?.GetItemSource();
        }

        protected void OnDelete()
        {
            _currentFeature?.DataManager?.Delete();
            OnRefresh();
        }

        protected void OnEdit()
        {
        }

        #region Commands

        public DelegateCommand AddCommand { get; set; }

        public DelegateCommand RefreshCommand { get; set; }

        public DelegateCommand DeleteCommand { get; set; }

        public DelegateCommand EditCommand { get; set; }

        public DelegateCommand ImportCommand { get; set; }

        public DelegateCommand ExportCommand { get; set; }

        public DelegateCommand SaveCommand { get; set; }

        public DelegateCommand CopyCommand { get; set; }

        public DelegateCommand PasteCommand { get; set; }

        #endregion
    }

    public class Feature : ViewModelBase
    {
        public Feature(string name, Action<Feature> onClick)
        {
            Name = name;
            ClickCommand = new DelegateCommand(() => { onClick?.Invoke(this); });
        }

        public string Name { get; set; }

        public DelegateCommand ClickCommand { get; set; }

        public IDataManager DataManager { get; set; }
    }
}