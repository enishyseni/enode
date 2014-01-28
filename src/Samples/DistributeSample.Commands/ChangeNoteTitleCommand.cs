﻿using System;
using ENode.Commanding;

namespace DistributeSample.Commands
{
    [Serializable]
    public class ChangeNoteTitleCommand : Command<Guid>
    {
        public string Title { get; private set; }

        public ChangeNoteTitleCommand(Guid noteId, string title) : base(noteId)
        {
            Title = title;
        }
    }
}
