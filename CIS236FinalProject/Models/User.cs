﻿namespace CIS236FinalProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Team> Teams { get; set; } = new List<Team>();
       
    }
}
