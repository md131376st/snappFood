using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Serialization.Json;
using workinterview.Model;

namespace workinterview.ViewModel
{
    class ApiHandler
    {
        string apiUrl = "https://snappfood.ir/mobile/v2/restaurant";

        public ApiHandler(SortingParameres filter = SortingParameres.defult)
        {
            CallApi(filter);
        }
        public void CallApi(SortingParameres filter= SortingParameres.defult)
        {
            var client = new RestClient(apiUrl);
            var request = new RestRequest("vendors-list?cityId=1",DataFormat.Json);
            if (filter != SortingParameres.defult)
            {
                request.AddParameter("filters", "{\"sortings\":[\"" + Enum.GetName(typeof(SortingParameres), filter) + "\"]}");
            }

            var response = client.Get(request);
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                ReadFromDB(filter);
            }
            else
            {
                insertOrUpdateDB();
            }
            

        }
        private  void ReadFromDB(SortingParameres filter = SortingParameres.defult)
        {
           
        }

        private async void insertOrUpdateDB()
        {
           
        }
           
    }
        
       
}
