using Backet.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backet.WebApi.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public BaseController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult ReturnOk()
        {
            unitOfWork.Commit();
            return Ok();
        }

        public IActionResult ReturnOk<T>(T data)
        {
            unitOfWork.Commit();
            return Ok(data);
        }
    }
}
