namespace Fish;

public partial class Fish : CharacterBody2D
{
    public override void _Ready()
    {
        int numRaycasts = 25;

        for (int i = 0; i < numRaycasts; i++)
        {
            float angle = (i * Mathf.Pi * 2 / numRaycasts);

            RayCast2D raycast = new RayCast2D();
            AddChild(raycast);

            raycast.TargetPosition = new Vector2(50, 0) + Vector2.Right.Rotated(angle) * 50;
            raycast.Modulate = Colors.Green;
        }
    }

    public override void _PhysicsProcess(double delta)
    {
        //MoveAndCollide(Vector2.Right * 2);
    }
}
