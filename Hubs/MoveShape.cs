using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace WebSignalR.Hubs
{
    [HubName("moveShape")]
    public class MoveShape: Hub
    {
        public void moveShape(double x, double y)
        {
            Clients.Others.shapeMoved(x,y);
        }
    }
}