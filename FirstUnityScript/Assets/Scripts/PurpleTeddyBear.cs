using UnityEngine;

/// <summary>
///     Prints a message
/// </summary>
public class PurpleTeddyBear : MonoBehaviour
{
    /// <summary>
    ///     Start is called before the first frame update
    /// </summary>
    private void Start()
    {
        // quadruple width and height
        var newScale = transform.localScale;

        newScale.x *= 3;
        newScale.y *= 3;

        transform.localScale = newScale;

        GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 0), ForceMode2D.Impulse);
    }
}