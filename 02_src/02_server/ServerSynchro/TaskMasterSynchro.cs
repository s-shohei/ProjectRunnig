using System;
using System.Collections;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ServerSynchro
{
    public class TaskMasterSynchro : AbstractServerSynchro
    {
        public override void send()
        {
            Hashtable param = setParams();

            sendServerReq(param, EnumConnectType.GET);
        }

        protected override Hashtable setParams()
        {
            Hashtable param = new Hashtable();

            param["hoge"] = "hoge";
            param["hogehoge"] = "hogehoge";

            return param;
        }
    }
}
