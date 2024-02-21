using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace pursify.Models;

public class PurseTypeViewModel
{
    public List<Purse>? Purses { get; set; }
    public SelectList? Types { get; set; }
    public string? PurseType { get; set; }
    public string? SearchString { get; set; }
}