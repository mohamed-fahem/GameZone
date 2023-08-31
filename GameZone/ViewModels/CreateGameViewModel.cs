﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameZone.ViewModels
{
    public class CreateGameViewModel
    {
        [MaxLength(250)]
        public string GameName { get; set; } = string.Empty;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();

        [Display(Name = "Supported Devices")]
        public List<int> SelectedDevices { get; set; } = default!;

        public IEnumerable<SelectListItem> Devices { get; set; } = Enumerable.Empty<SelectListItem>();

        [MaxLength(2500)]
        public string Description { get; set; } = string.Empty;

        
        public IFormFile Cover { get; set; } = default!;
    }
}
