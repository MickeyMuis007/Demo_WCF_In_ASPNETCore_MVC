using System.Collections.Generic;
using System.ServiceModel;

namespace UseWCFInASPNETCoreMVC
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        Product Find();

        [OperationContract]
        List<Product> FindAll();
    }
}
