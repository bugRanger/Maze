﻿namespace MagicMaze.Core.Enums
{
    using System;

    [Flags]
    public enum Walls
    {
        None = 0,
        Bottom = 1 << 1, 
        Top = 1 << 2, 
        Left = 1 << 3, 
        Right = 1 << 4,
        All = Bottom | Top | Left | Right,
    }
}
