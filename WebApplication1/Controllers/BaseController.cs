using Microsoft.AspNetCore.Mvc;
using Excitel.Data;

namespace Excitel.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public abstract class BaseController<TEntity, TRepository> : Controller
       where TEntity : class, IEntity
       where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public BaseController(TRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TEntity>>> GetAll()
        {
            return View(await repository.GetAll());
        }

        [HttpGet("Details/{id}")]
        public virtual async Task<ActionResult<TEntity>> Get(int id)
        {
            var entity = await repository.Get(id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        [HttpGet("Edit/{id}")]
        public virtual async Task<IActionResult> Update(int id)
        {
            var entity = await repository.Get(id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Update(int id, [FromForm] TEntity entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await repository.Update(entity);
            return RedirectToAction(nameof(GetAll)); ;
        }

        [HttpGet("Create")]
        public virtual IActionResult Add()
        {
            return View();
        }

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public virtual async Task<ActionResult<TEntity>> Add([FromForm] TEntity entity)
        {
            await repository.Add(entity);
            return RedirectToAction(nameof(GetAll));
        }
    }
}
