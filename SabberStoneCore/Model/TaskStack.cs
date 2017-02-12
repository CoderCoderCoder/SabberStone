﻿using System.Collections.Generic;
using System.Linq;

namespace SabberStoneCore.Model
{
    public class TaskStack
    {
        public Game Game { get; set; }

        public List<IPlayable> Playables { get; set; }
        public List<string> CardIds { get; set; }
        public bool Flag { get; set; }
        public int Number { get; set; }

        public TaskStack(Game game)
        {
            Game = game;
        }

        public void Reset()
        {
            Playables = new List<IPlayable>();
            CardIds = new List<string>();
            Flag = false;
            Number = 0;
        }

        public void Stamp(TaskStack taskStack)
        {
            Playables = new List<IPlayable>();
            Playables = taskStack.Playables?.Select(p => Game.IdEntityDic[p.Id]).ToList();
            CardIds = taskStack.CardIds;
            Flag = taskStack.Flag;
            Number = taskStack.Number;
        }
    }
}