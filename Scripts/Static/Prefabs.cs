namespace Fish;

public static class Prefabs
{
    public static PackedScene Options { get; } = Load("UI/options");
    public static PackedScene Fish { get; } = Load("fish");

    static PackedScene Load(string path) =>
        GD.Load<PackedScene>($"res://Scenes/Prefabs/{path}.tscn");
}
