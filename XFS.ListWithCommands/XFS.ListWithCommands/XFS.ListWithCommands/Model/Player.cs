using System;
using System.Collections.Generic;
using System.Text;

namespace XFS.ListWithCommands.Models
{
    public class Player
    {
        public int Id { get; private set; }
        public Player(int id)
        {
            Id = id;
            Nicknames = new List<string>();
        }

        public string Name { get; set; }
        public string Handle { get; set; }
        public List<string> Nicknames { get; set; }
        public Race Race { get; set; }
    }
}
