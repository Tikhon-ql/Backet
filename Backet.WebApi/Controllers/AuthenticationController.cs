using Backet.Common.Interfaces;

namespace Backet.WebApi.Controllers
{
    public class AuthenticationController : BaseController
    {
        public AuthenticationController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
