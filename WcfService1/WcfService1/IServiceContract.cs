using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceContract
    {
        [OperationContract]
        string Get();

        [OperationContract]
        string GetData(int value);

        // TODO: Add your service operations here
    }

    // Interface To Set Set Up The Communication Channel with the WCF Client
    interface IServiceChannel : IServiceContract, IClientChannel
    {
    }
}
