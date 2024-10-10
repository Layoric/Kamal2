using ServiceStack;
using Kamal2.ServiceModel;

namespace Kamal2.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };
    }

    public object Get(KamalUp request)
    {
        return new KamalUpResponse();
    }
}