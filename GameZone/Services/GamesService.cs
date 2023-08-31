﻿namespace GameZone.Services;

public class GamesService : IGamesService
{
    private readonly ApplicationDbContext _context;
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly string _imagesPath;

    public GamesService(ApplicationDbContext context,
        IWebHostEnvironment webHostEnvironment)
    {
        _context = context;
        _webHostEnvironment = webHostEnvironment;
        _imagesPath = $"{_webHostEnvironment.WebRootPath}/assets/images";
    }

    public async Task Create(CreateGameViewModel model)
    {
        var coverName = $"{Guid.NewGuid()}{Path.GetExtension(model.Cover.FileName)}";

        var path = Path.Combine(_imagesPath, coverName);

        using var stream = File.Create(path);
        await model.Cover.CopyToAsync(stream);

        Game game = new()
        {
            GameName = model.GameName,
            Description = model.Description,
            CategoryId = model.CategoryId,
            Cover = coverName,
            Devices = model.SelectedDevices.Select(d => new GameDevice { DeviceId = d }).ToList()
        };

        _context.Add(game);
        _context.SaveChanges();
    }
}
