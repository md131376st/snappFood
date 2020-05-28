using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workinterview.Interfaces;
using workinterview.Model;

namespace workinterview.ViewModel
{
    public class VenderBageRepository : IVenderBageRepository
    {
       
        public void AddVenderBage(VenderBage venderBage)
        {
            using (var context = new Model.Model())
            {
                context.VenderBages.AddOrUpdate(vb=>vb.Id,venderBage);
                context.SaveChanges();
            }
        }

        public List<VenderBage> GetVenderBages(int IdVender)
        {
            using (var context = new Model.Model())
            {
                var q= context.VenderBages
                            .Where(vb => vb.IdVender == IdVender).ToList();         
                return q;
            }     
        }
        //~VenderBageRepository()
        //{
        //    using (var context = dataEntities)
        //    {
        //        context.SaveChanges();
        //    }

        //}

    }
}
