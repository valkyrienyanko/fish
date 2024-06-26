namespace Fish;

public partial class Main : Node
{
    public override void _Ready()
    {
        // Add a single fish to the scene
        Fish fish = Prefabs.Fish.Instantiate<Fish>();
        fish.Position = Vector2.Zero;
        AddChild(fish);
    }
}
