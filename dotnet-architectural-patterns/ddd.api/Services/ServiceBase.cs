namespace ddd.api.Services
{
    public abstract class ServiceBase : IServiceBase
    {
        protected internal IUnitOfWork UnitOfWork { get; set; }

        protected ServiceBase(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}
