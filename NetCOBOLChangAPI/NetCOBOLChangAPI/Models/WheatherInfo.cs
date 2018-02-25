using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetCOBOLChangAPI.Models
{
    public class WheatherInfo
    {
        public static string ErrString = "取得失敗";

        private string maxtmp;
        private string mintmp;

        public string City { get; set; } = "-";
        public string Wheathere { get; set; } = "-";
        public string MaxTemp {
            get { return maxtmp; }
            set {
                if (value == null)
                {
                    maxtmp = "不明";
                }
                else {
                    maxtmp = value + "度";
                }
            }
        }
        public string MinTemp {
            get { return mintmp; }
            set
            {
                if (value == null)
                {
                    mintmp = "不明";
                }
                else
                {
                    mintmp = value + "度";
                }
            }

        }
    }
}