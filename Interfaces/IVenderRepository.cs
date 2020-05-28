using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workinterview.Model;
using workinterview.ViewModel;

namespace workinterview.Interfaces
{
    public interface IVenderRepository
    {
        void AddVender(Vender vender);
        List<Vender> GetVender(SortingParameres value);
    }
}
