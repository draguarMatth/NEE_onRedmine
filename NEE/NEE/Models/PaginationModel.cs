//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class PaginationModel
//{
//    public PaginationModel()
//    {
//    }
//    public int CurrentPage { get; set; } = 1;
//    public int Count { get; set; }

//    public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

//    public bool ShowPrevious => CurrentPage > 1;
//    public bool ShowNext => CurrentPage < TotalPages;
//}