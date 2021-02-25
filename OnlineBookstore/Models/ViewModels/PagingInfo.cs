using System;
namespace OnlineBookstore.Models.ViewModels
{
    //this is bundling the information to add it to the view
    public class PagingInfo
    {
       public int TotalNumItems { get; set; }
       public int ItemsPerPage { get; set; }
       public int CurrentPage { get; set; }
       public int TotalPages => (int)Math.Ceiling((decimal)TotalNumItems / ItemsPerPage);
    }
}