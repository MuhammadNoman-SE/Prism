using Prism.Mvvm;
using Core.Business;
using Prism.Regions;

namespace L.ViewModels
{
    public class PersonDetailViewModel : BindableBase,INavigationAware
    {
        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { SetProperty(ref _selectedPerson, value); }
        }

        public PersonDetailViewModel()
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            if (navigationContext.Parameters.ContainsKey("person"))
                SelectedPerson = navigationContext.Parameters.GetValue<Person>("person");
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            Person p = navigationContext.Parameters.GetValue<Person>("person");
            if (p.FirstName.Equals(SelectedPerson.FirstName) &&
                p.LastName.Equals(SelectedPerson.LastName) &&
                p.Age.Equals(SelectedPerson.Age))
                return true;
            else
                return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}
