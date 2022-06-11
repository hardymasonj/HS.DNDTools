﻿namespace HS.DNDTools.SpellPoints.Domain.Characters
{
    public interface IClassLevel
    {
        string Name { get; }
        string Subclass { get; } //these would be better in
        int Level { get; }
        Enums.ClassEnums.CasterType CasterType { get; }
    }
}