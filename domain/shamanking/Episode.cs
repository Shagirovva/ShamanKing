using System;

namespace shamanking
{
    public class Episode
    {
        public int Id { get; }//идентификатор, чтобы не путать
        public string Title { get;  }//название эпизода,возвращаемый
        public Episode(int id, string title)//
        {
            Id = id;
            Title = title; //проинициализировать
        }
    }
}
