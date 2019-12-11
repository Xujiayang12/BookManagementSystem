using System;

namespace BookManagementSystem
{
    public class Book
    {
        public Book()
        {
            
        }
        public Book(string bkTitle, string bkAuthor, string bkPress, DateTime bkTime, string bkCategory, string bkIntro, string bkIsbn, string bkLocation)
        {
            bk_title = bkTitle;
            bk_author = bkAuthor;
            bk_press = bkPress;
            bk_time = bkTime;
            bk_category = bkCategory;
            bk_intro = bkIntro;
            bk_isbn = bkIsbn;
            bk_location = bkLocation;
        }

        public int bk_id { get; set; }
        public string bk_title { get; set; }
        public string bk_author { get; set; }
        public string bk_press { get; set; }
        public DateTime bk_time { get; set; }
        public string bk_category { get; set; }
        public string bk_intro { get; set; }
        public string bk_isbn { get; set; }
        public string bk_location { get; set; }
        public int bk_lent { get; set; }
    }
}