namespace Fish;

public partial class Fish : CharacterBody2D
{
    RayCast2D[] raycasts;
    int numRaycasts = 25;

    RayCast2D raycastAverage;

    public override void _Ready()
    {
        raycasts = new RayCast2D[numRaycasts];

        for (int i = 0; i < numRaycasts; i++)
        {
            float angle = (i * Mathf.Pi * 2 / numRaycasts);

            RayCast2D raycast = new RayCast2D();
            AddChild(raycast);

            raycast.TargetPosition = new Vector2(50, 0) + Vector2.Right.Rotated(angle) * 50;
            raycasts[i] = raycast;
        }

        raycastAverage = new RayCast2D();
        AddChild(raycastAverage);
        raycastAverage.Position = Vector2.Zero;
        raycastAverage.Modulate = Colors.Green;
    }

    public override void _PhysicsProcess(double delta)
    {
        Vector2 average = new Vector2(0, 0);

        for (int i = 0; i < raycasts.Length; i++)
        {
            if (!raycasts[i].IsColliding())
                average += raycasts[i].TargetPosition;
        }

        average /= raycasts.Length;

        raycastAverage.TargetPosition = average;

        MoveAndCollide(average.Normalized());
    }
}
