using System.ServiceModel;

namespace UseWCFInASPNETCoreMVC
{
    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        string Hello();

        [OperationContract]
        string Hi(string name);

        [OperationContract]
        int Sum(int a, int b);
    }
}
