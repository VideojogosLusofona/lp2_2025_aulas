using UnityEngine;

public class PlayerAttribs : MonoBehaviour
{
    [field: Range(0, 100)]
    [field: SerializeField]
    public float Health { get; private set; }

    public (string, Color) Status => Health switch
        {
            0 => ("Player is dead", Color.gray),
            <= 30 and > 0 => ("Critical health", Color.red),
            <= 70 => ("Injured", new Color(1f, 0.5f, 0f)), // Laranja +-
            <= 100 => ("Healthy", Color.green),
            _ => ("Invalid health value", Color.white)
        };
}
