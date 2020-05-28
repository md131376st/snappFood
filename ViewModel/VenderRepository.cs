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
    public class VenderRepository : IVenderRepository
    {
       
        public void AddVender(Vender vender)
        {
            using (var context = new Model.Model())
            {
                context.Venders.AddOrUpdate(vender);
                context.SaveChanges();
            }
        }

        public List<Vender> GetVender(SortingParameres value)
        {
            using (var context = new Model.Model())
            {
                var q= new List<Vender>();
                switch (value )
                {
                   
                    case SortingParameres.max_rate:
                        q = context.Venders.OrderByDescending(v => v.rating).Take(10).ToList();
                        break;
                    case SortingParameres.least_expensive:
                        q = context.Venders.Take(10).ToList();
                        break;
                    case SortingParameres.most_expensive:
                        q = context.Venders.Take(10).ToList();
                        break;
                    case SortingParameres.top_performance:
                        q = context.Venders.OrderByDescending(v => v.rate).Take(10).ToList();
                        break;
                    case SortingParameres.defult:
                        q = context.Venders.Take(10).ToList();
                        break;
                }
               
                return q;
            }
        }

        //~VenderRepository()
        //{
        //    using (var context = dataEntities)
        //    {
        //        context.SaveChanges();
        //    }
        //}
    }
}
