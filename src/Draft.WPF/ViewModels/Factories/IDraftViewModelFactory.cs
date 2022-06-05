using Draft.WPF.States.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.WPF.ViewModels.Factories
{
    public interface IDraftViewModelFactory
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
