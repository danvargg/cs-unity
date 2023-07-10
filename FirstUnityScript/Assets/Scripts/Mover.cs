using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        const float minImpulseForce = 3f;
        const float maxImpulseForce = 5f;

        var angle = Random.Range(0, 2 * Mathf.PI);

        Vector2 direction = new(Mathf.Cos(angle), Mathf.Sin(angle));

        var magnitude = Random.Range(minImpulseForce, maxImpulseForce);

        GetComponent<Rigidbody2D>().AddForce(direction * magnitude, ForceMode2D.Impulse);
    }
    
    /// <summary>
    /// Called on a collision
    /// </summary>
    /// <param name="col"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void OnCollisionEnter2D(Collision2D col)
    {
        throw new NotImplementedException();
    }
}
