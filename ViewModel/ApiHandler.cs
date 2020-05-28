using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serialization.Json;
using workinterview.Model;

namespace workinterview.ViewModel
{
    class ApiHandler
    {
        private VenderBageRepository venderBage = new VenderBageRepository();
        private VenderRepository vender = new VenderRepository();
        string apiUrl = "https://snappfood.ir/mobile/v2/restaurant";
        public List<Vender> VenderLst = new List<Vender>();

        public ApiHandler(SortingParameres filter = SortingParameres.defult)
        {
            CallApi(filter);
        }
        public void CallApi(SortingParameres filter= SortingParameres.defult)
        {
            var client = new RestClient(apiUrl);
            var request = new RestRequest("vendors-list?cityId=1", DataFormat.Json);
            if (filter != SortingParameres.defult)
            {
                request.AddParameter("filters", "{\"sortings\":[\"" + Enum.GetName(typeof(SortingParameres), filter) + "\"]}");
            }
            var response = client.Get(request);
            extractData(filter, response);
        }
        private void extractData(SortingParameres filter, IRestResponse response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                ReadFromDB(filter);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<ApiResponseRoot>(response.Content);
                resToVender(result);
                InsertOrUpdateDB(result);
            }
        }
        private void resToVender(ApiResponseRoot response) {
            VenderLst.Clear();
            foreach (var vender_ in response.data.finalResult) if (vender_.type != "BANNER")
                {
                    var data = vender_.data;

                    var vender__ = new Vender(data.id, data.vendorCode, data.onlineOrder, data.title, data.description,
                        (byte)data.rate, (byte)data.rating, data.logo, data.defLogo,data.address);
                    foreach (var badge in data.badges)
                    {

                        vender__.VenderBages.Add(new VenderBage(data.id, badge));
                    }
                    VenderLst.Add(vender__);
                }
        }
        private void ReadFromDB(SortingParameres filter = SortingParameres.defult)
        {
            var venders=vender.GetVender(filter);
            foreach( var vender_ in venders){
               vender_.VenderBages= venderBage.GetVenderBages(vender_.id);
            }
            VenderLst = venders;
        }
        private async  void InsertOrUpdateDB(ApiResponseRoot response)
        {
            await Task.Run(() =>
            {
                foreach (var vender_ in response.data.finalResult) if (vender_.type!= "BANNER")
                    {
                        var data = vender_.data;

                        vender.AddVender(new Vender(data.id, data.vendorCode, data.onlineOrder, data.title,
                            data.description,(byte)data.rate, (byte)data.rating, data.logo, data.defLogo,data.address));
                        foreach( var badge in data.badges)
                        {
                            venderBage.AddVenderBage(new VenderBage(data.id, badge));
                        }
                      
                    }
            });

            //foreach (var vender_ in response.data.finalResult) if (vender_.type != "BANNER")
            //    {
            //        var data = vender_.data;
            //        await Task.Run(() =>
            //        {
            //            vender.AddVender(new Vender(data.id, data.vendorCode, data.onlineOrder,
            //            data.title, data.description, (byte)data.rate,
            //            (byte)data.rating, data.logo, data.defLogo));
            //        });
            //        Vender vender__ = new Vender(data.id, data.vendorCode, data.onlineOrder,
            //            data.title, data.description, (byte)data.rate,
            //            (byte)data.rating, data.logo, data.defLogo);
            //        foreach (var badge in data.badges)
            //        {
            //            vender__.VenderBages.Add(new VenderBage(data.id, badge));
            //            await Task.Run(() =>
            //            {
            //                venderBage.AddVenderBage(new VenderBage(data.id, badge));
            //            });
            //        }
            //        VenderLst.Add(vender__);
            //    }
        }      
    }  
}
