using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace MMS.MicroService.MessageService.Services
{
    public class TimerController
    {
        private TimerCallback deliverQueueListenerCallback;

        private Timer deliverListenerTimer;

        private DeliverQueueListener deliverQueueListener;

        public static readonly TimerController Instance = new TimerController();

        private TimerController()
        {
            deliverQueueListener = new DeliverQueueListener();
        }

        public void StartupListen(int interval)
        {
            deliverQueueListenerCallback = new TimerCallback(deliverQueueListener.Listen);
            deliverListenerTimer = new Timer(deliverQueueListenerCallback,null, interval, interval);
        }

    }
}
