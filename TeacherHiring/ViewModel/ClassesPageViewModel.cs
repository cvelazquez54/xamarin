using Domain.Teacher;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TeacherHiring.ViewModel
{
    public class ClassesPageViewModel : BaseViewModel
    {
        public ObservableCollection<DtoClassAvailable> Items { get; set; }
        
        public ClassesPageViewModel()
        {
            //Items = new ObservableCollection<DtoClassAvailable>(getAvailableClassesDataSource());
        }

        private List<DtoClassAvailable> getAvailableClassesDataSource()
        {
            return new List<DtoClassAvailable>() { new DtoClassAvailable { ClassID = 1, ClassName = "Matematicas" }, new DtoClassAvailable { ClassID = 2, ClassName = "Español" } };
        }

    }
}
