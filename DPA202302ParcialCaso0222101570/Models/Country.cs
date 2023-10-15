using System;
using System.Collections.Generic;

namespace DPA202302ParcialCaso0222101570.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int Code { get; set; }

    public string Currency { get; set; } = null!;
}
