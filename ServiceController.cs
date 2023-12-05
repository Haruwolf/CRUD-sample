public class ServiceController
{
    public IService service {get; private set;}

    public ServiceController(IService svc)
    {
        service = svc;
    }
}

