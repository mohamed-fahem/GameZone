namespace GameZone.Controllers
{
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICategoriesService _categoriesService;
        private readonly  IDevicesService _devicesService;
        private readonly IGamesService _gamesService;

        public GamesController(ApplicationDbContext context, ICategoriesService categoriesService, IDevicesService devicesService, IGamesService gamesService)
        {
            _context = context;
            _categoriesService = categoriesService;
            _devicesService = devicesService;
            _gamesService = gamesService;
        }

        // GET: GamesController1
        public ActionResult Index()
        {
            var game = _context.Games.Include(g=>g.Category).ToList();
            return View(game);
        }

        // GET: GamesController1/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var game =  await _context.Games.Include(x => x.Category).SingleOrDefaultAsync(b => b.GameId == id);
                return View(game);
        }

        // GET: GamesController1/Create
        public ActionResult Create()
        {
            var model = new CreateGameViewModel();
            model.Categories = _categoriesService.GetCategories();
            model.Devices = _devicesService.GetSelectList();
            return View(model);
        }

        // POST: GamesController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateGameViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = _categoriesService.GetCategories();
                model.Devices = _devicesService.GetSelectList();
                return View(model);
            }

            await _gamesService.Create(model);

            return RedirectToAction(nameof(Index));
        }

        // GET: GamesController1/Edit/5
        public ActionResult Edit(int id)
        {
            

            return View();
        }

        // POST: GamesController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GamesController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GamesController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
