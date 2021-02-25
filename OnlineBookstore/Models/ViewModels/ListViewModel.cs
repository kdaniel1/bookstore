using System;
using System.Collections.Generic;

namespace OnlineBookstore.Models.ViewModels
{
    public class ListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
