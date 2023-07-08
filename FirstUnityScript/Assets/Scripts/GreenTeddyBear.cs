using UnityEngine;

/// <summary>
///     Prints a message
/// </summary>
public class GreenTeddyBear : MonoBehaviour
{
    /// <summary>
    ///     Start is called before the first frame update
    /// </summary>
    private void Start()
    {
        // quadruple width and height
        var newScale = transform.localScale;

        newScale.x *= 2;
        newScale.y *= 2;

        transform.localScale = newScale;

        // get the game object moving

        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(0, -1),
            ForceMode2D.Impulse
        );
    }
}