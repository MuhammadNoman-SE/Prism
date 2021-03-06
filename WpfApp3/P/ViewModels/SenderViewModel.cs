﻿using Core.Business;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Windows;
using WpfApp3.Core.Evenets;

namespace P.ViewModels
{
    public class SenderViewModel : BindableBase,INavigationAware,IConfirmNavigationRequest
    {
        private DelegateCommand s;
        private DelegateCommand GoForwardCommand;
        public DelegateCommand S
        {
            get { return s; }
            set { SetProperty(ref s, value); }
        }
        private IEventAggregator e;

        public IEventAggregator E
        {
            get { return e; }
            set { e = value; }
        }
        private string fn;

        public string FirstName
        {
            get { return fn; }
            set {
                SetProperty(ref fn , value);
                Person.FirstName = fn;
            }
        }

        private string ln;

        public string LastName
        {
            get { return ln; }
            set
            {
                SetProperty(ref ln, value);
                Person.LastName = ln;
            }
        }
        private int ag;

        public int Age
        {
            get { return ag; }
            set
            {
                SetProperty(ref ag, value);
                Person.Age = ag;
            }
        }

        private Person p = new Person("","",0);

        public Person Person
        {
            get { return p; }
            set {SetProperty(ref p , value); }
        }

        private IDialogService d;
        public SenderViewModel(IEventAggregator e, IDialogService ds)
        {
            S = new DelegateCommand(sm);
            E = e;
            GoForwardCommand = new DelegateCommand(gf,cgf);
            d = ds;
        }
        public void sm() {
            E.GetEvent<Events>().Publish(Person);
        }
        IRegionNavigationJournal j;
        private void gf() {
            j.GoForward();
        }
        private bool cgf() {
            return null != j && j.CanGoForward;

        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            C+=1;
            j = navigationContext.NavigationService.Journal;
            GoForwardCommand.RaiseCanExecuteChanged();
                }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            bool result = false;
            Core.DialogService.ShowDialog(d,"Show?",res=> { 
            if(res.Result==ButtonResult.OK)
                result = true; 
            });
            continuationCallback(result);
        }

        private int c=0;

        public int C
        {
            get { return c; }
            set { SetProperty(ref c, value);
                Count= c.ToString();
            }
        }
        private string count="0";

        public string Count
        {
            get { return count; }
            set {SetProperty(ref count , value); }
        }


    }
}
