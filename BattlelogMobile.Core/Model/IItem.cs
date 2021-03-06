﻿using System;
using System.Windows.Media.Imaging;

namespace BattlelogMobile.Core.Model
{
    public interface IItem
    {
        string Name { get; set; }
        string DisplayName { get; }
        string Slug { get; set; }
        int Kills { get; set; }
        int? Headshots { get; set; }
        int? ServiceStars { get; set; }
        BitmapImage ServiceStarImage { get; set; }
        TimeSpan? TimeIn { get; set; }
        BitmapImage Image { get; set; }
    }
}