﻿namespace SpaceGame;

public static class GVector2
{
    /// <summary>
    /// Returns a random vector between 0 and 1 (inclusive) for X and Y.
    /// </summary>
    public static Vector2 Random() => 
        new Vector2((float)GD.RandRange(-1.0, 1.0), (float)GD.RandRange(-1.0, 1.0)).Normalized();
}
