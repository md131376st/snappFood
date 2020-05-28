using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workinterview.Model;

namespace workinterview.Interfaces
{
    public interface IVenderBageRepository
    {
        void AddVenderBage(VenderBage venderBage);
        List<VenderBage> GetVenderBages(int IdVender);
    }
}
