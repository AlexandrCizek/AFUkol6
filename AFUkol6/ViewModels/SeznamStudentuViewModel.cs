using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFUkol6.ViewModels
{
    public class SeznamStudentuViewModel: ViewModelBase
    {
        public ObservableCollection<StudentViewModel> Studenti { get; set; }
        [Reactive]
        public StudentViewModel VybranyStudent { get; set; }

        public SeznamStudentuViewModel()
        {
            Studenti = new ObservableCollection<StudentViewModel>()
            {
                new StudentViewModel(1, "Alex", 60),
                new StudentViewModel(2, "Marek", 80),
                new StudentViewModel(3, "Mikulas", 53),
                new StudentViewModel(4, "Josef", 25),
                new StudentViewModel(5, "Adam", 65),
                new StudentViewModel(6, "Lukas", 81),
                new StudentViewModel(7, "David", 57),
                new StudentViewModel(8, "Jan", 35)
            };
            VybranyStudent = Studenti.First();
        }
    }
}
