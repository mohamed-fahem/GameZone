namespace GameZone.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ApplicationDbContext _context;

        public CategoriesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetCategories()
        {
            return _context.Categories.Select(s => new SelectListItem
            {
                Value = s.CategoryId.ToString(),
                Text = s.CategoryName
            })
            .OrderBy(s=>s.Text)
            .AsNoTracking()
            .ToList();
            
        }

        
    }
}
