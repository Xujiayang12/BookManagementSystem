using System;

namespace BookManagementSystem
{
    public class Record
    {
        public Record()
        {
            
        }
        public Record(int rBook, int rUser, DateTime rBegin, DateTime rEnd)
        {
            r_book = rBook;
            r_user = rUser;
            r_begin = rBegin;
            r_end = rEnd;
        }

        public int r_id { get; set; }
        public int r_book { get; set; }
        public int r_user { get; set; }
        public DateTime r_begin { get; set; }
        public DateTime r_end { get; set; }
        public int r_isreturn { get; set; }
    }
}