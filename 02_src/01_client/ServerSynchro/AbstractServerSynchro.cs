using System;
using System.Collections;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ServerSynchro
{
    public abstract class AbstractServerSynchro
    {
        /// <summary>
        /// サーバリクエスト送信
        /// </summary>
        protected void sendServerReq(Hashtable param, EnumConnectType type)
        {
            try
            {
                HttpClient client = new HttpClient();
                JavaScriptSerializer se = new JavaScriptSerializer();

                // リクエストパラメータ加工
                var reqParam = se.Serialize(param);
                Console.WriteLine(reqParam);
                var content = new StringContent(reqParam);

                // URL取得
                string url = getUrl(type);

                // 通信
                var response = client.PostAsync(url, content).Result;
                Console.WriteLine(response);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
            }
        }

        private string getUrl(EnumConnectType type)
        {
            string url = null;

            switch (type.ToString())
            {
                case "GET":
                    url = ConstServerSynchro.GET_TASK_MASTER;
                    break;

                case "POST":
                    url = "";
                    break;

                case "PUT":
                    url = "";
                    break;

                case "DELETE":
                    url = "";
                    break;

                default:
                    break;
            }

            return url;
        }
        
        /// <summary>
        /// 通信処理
        /// </summary>
        public abstract void send();
        
        /// <summary>
        /// パラーメタセット
        /// </summary>
        protected abstract Hashtable setParams();
    }
}
