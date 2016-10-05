using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSynchro
{
    public enum EnumConnectType
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class ConstServerSynchro
    {
        public const string GET_TASK_MASTER = "http://192.168.207.130:3000/testapi";
    }
}
