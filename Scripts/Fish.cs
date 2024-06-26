namespace Fish;

public partial class Fish : CharacterBody2D
{
    public override void _Ready()
    {
        
    }

    public override void _PhysicsProcess(double delta)
    {
        MoveAndCollide(Vector2.Right * 2);
    }
}
