using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Net;
namespace NetCOBOLChangAPI.Models
{
    public class WheatherInfoGetter
    {

        /// <summary>
        /// ライブドアのAPIにアクセスし、天気情報を取得する
        /// </summary>
        /// <returns></returns>
        public static async Task<WheatherInfo> WheatherInfo()
        {
            
            using (HttpClient client = new HttpClient() { BaseAddress = new Uri("http://weather.livedoor.com/") })
            {
                WheatherInfo info = new WheatherInfo() { City = NetCOBOLChangAPI.Models.WheatherInfo.ErrString};

                //天気APIにアクセスし、天気情報を取得する
                HttpResponseMessage response = await client.GetAsync("forecast/webservice/json/v1?city=220030");

                //OKでなけらば取得失敗とする
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return info;
                }

                //天気・最大気温・最低気温を取得する
                string responseContentStr = await response.Content.ReadAsStringAsync();

                dynamic responseContentObj = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(responseContentStr);

                //int locationIndex = 0;
                //for (; locationIndex < responseContentObj.pinpointLocations.Count; locationIndex++)
                //{
                //    if (cityName.Equals(responseContentObj.pinpointLocations[locationIndex].name.ToString()))
                //    {
                //        break;
                //    }
                    
                //}


                //if (locationIndex > responseContentObj.pinpointLocations.Count)
                //{
                //    return info;
                //}
                info.City = "静岡県東部";
                info.MaxTemp = responseContentObj.forecasts[0].temperature.max;
                info.MinTemp = responseContentObj.forecasts[0].temperature.min;
                info.Wheathere = responseContentObj.forecasts[0].telop;

                return info;
            }
        }
    }
}