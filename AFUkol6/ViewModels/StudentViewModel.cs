using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFUkol6.ViewModels
{
    public class StudentViewModel: ViewModelBase
    {
        public int Id { get; }
        public string Jmeno { get; set; }
        [Reactive]
        public int Body { get; set; }

        public StudentViewModel(int id, string jmeno, int body)
        {
            Id = id;
            Jmeno = jmeno;
            Body = body;
        }
    }
}
