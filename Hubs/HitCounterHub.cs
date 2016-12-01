using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebSignalR.Hubs
{
    [HubName("HitCounter")]
    public class HitCounterHub: Hub
    {
        private static int _hitCounter = 0;
        public override Task OnConnected()
        {
            _hitCounter += 1;
            base.Clients.All.hitReceived(_hitCounter);
            return base.OnConnected();
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            _hitCounter -= 1;
            base.Clients.All.hitReceived(_hitCounter);
            return base.OnDisconnected(stopCalled);
        }
    }
}