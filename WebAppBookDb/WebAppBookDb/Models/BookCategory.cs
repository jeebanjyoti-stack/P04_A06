﻿using System;
using System.Collections.Generic;

namespace WebAppBookDb.Models;

public partial class BookCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
