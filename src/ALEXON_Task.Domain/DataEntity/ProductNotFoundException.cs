using Volo.Abp;

namespace ALEXON_Task.DataEntity
{
    public class ProductNotFoundException : BusinessException
    {
        public ProductNotFoundException(int id) : base(ALEXON_TaskDomainErrorCodes.ProductNotFound)
        {
            WithData("id",id);
        }
    }
}