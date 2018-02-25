using NetCOBOLChangAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NetCOBOLChangAPI.Controllers
{
    public class WheatherController : ApiController
    {
        // GET: api/Wheather
        public async Task<IHttpActionResult> Get()
        {
            NetCOBOLChangResponse res = new NetCOBOLChangResponse() { text = "情報取得に失敗したようじゃ。ポンコツですまんのぅ。" };

            var info = await WheatherInfoGetter.WheatherInfo();

            if (info.City.Equals(WheatherInfo.ErrString)) {
                return Json(res);
            }

            res.text = info.City + "の天気は" + info.Wheathere + "なのじゃ。" + Environment.NewLine;
            res.text += "最高気温は" + info.MaxTemp + "、最低気温は" + info.MinTemp + "なのじゃ。";
            return Json(res);
        }


        // GET: api/Wheather/5
        //public async Task<IHttpActionResult> Get([FromUri]string id)
        //{
        //    NetCOBOLChangResponse res = new NetCOBOLChangResponse() { text = "情報取得に失敗したのじゃ！妾の知らない街の名前を入れるのはやめるのじゃ！！" };

        //    var info = await WheatherInfoGetter.WheatherInfo();

        //    if (info.City.Equals(WheatherInfo.ErrString))
        //    {
        //        return Json(res);
        //    }
        //    res.text = info.City + "の天気は" + info.Wheathere + "なのじゃ。" + Environment.NewLine;
        //    res.text += "最高気温は" + info.MaxTemp + "、最低気温は" + info.MinTemp + "なのじゃ。";

        //    return Json(res);
        //}

        // POST: api/Wheather
        public async Task<IHttpActionResult> Post()
        {
            NetCOBOLChangResponse res = new NetCOBOLChangResponse() { text = "情報取得に失敗したようじゃ。ポンコツですまんのぅ。" };

            var info = await WheatherInfoGetter.WheatherInfo();

            if (info.City.Equals(WheatherInfo.ErrString))
            {
                return Json(res);
            }

            res.text = info.City + "の天気は" + info.Wheathere + "なのじゃ。" + Environment.NewLine;
            res.text += "最高気温は" + info.MaxTemp + "、最低気温は" + info.MinTemp + "なのじゃ。";
            return Json(res);
        }

        // PUT: api/Wheather/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Wheather/5
        public void Delete(int id)
        {
        }
    }
}
