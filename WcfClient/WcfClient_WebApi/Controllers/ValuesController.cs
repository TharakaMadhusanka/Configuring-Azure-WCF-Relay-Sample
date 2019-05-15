using Microsoft.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.Web.Http;
using WcfService;


namespace WcfClient_WebApi.Controllers
{

    public class ValuesController : ApiController
    {
        // Create Your Relay Related Properties
        private string RelayName = "https://grip-dev-pass.servicebus.windows.net/adminwcfpochttp";
        private string RelayPolicyKeyName = "RootManageSharedAccessKey";
        private string RelayPolicyKey = "aW6zut6hFF13L52B85DzVC+FAORftibJFvLVGsjH2nM=";


        public string Get() {

            ChannelFactory<IServiceContract> channelFactory;
            // Create shared access signature token credentials for authentication.
            channelFactory = new ChannelFactory<IServiceContract>(new BasicHttpRelayBinding(),RelayName);
            channelFactory.Endpoint.Behaviors.Add(new TransportClientEndpointBehavior
            {
                TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider(RelayPolicyKeyName, RelayPolicyKey)
            });

            // Create Channel & Establish the Communication between relay
            IServiceContract channel = channelFactory.CreateChannel();
            // Call WCF Method
            return channel.Get();

        }
    }
}
