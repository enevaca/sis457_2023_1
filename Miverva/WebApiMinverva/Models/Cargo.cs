﻿using System;
using System.Collections.Generic;

namespace WebApiMinverva.Models;

public partial class Cargo
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;
}
