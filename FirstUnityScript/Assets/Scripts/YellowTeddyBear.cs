using UnityEngine;

/// <summary>
///     Prints a message
/// </summary>
public class YellowTeddyBear : MonoBehaviour
{
    /// <summary>
    ///     Start is called before the first frame update
    /// </summary>
    private void Start()
    {
        
        // quadruple width and height
        
        Vector3 newScale = transform.localScale;
        
        newScale.x *= 4;
        newScale.y *= 4;
        
        transform.localScale = newScale;
        
        // var totalSecondsPlayed = 100;
        // const int secondsPerMinute = 60;
        // var totalDamage = MathF.Cos(350);
        //
        // // calculate minutes played
        // var minutesPlayed = totalSecondsPlayed / secondsPerMinute;
        // var secondsPlayed = totalSecondsPlayed % secondsPerMinute;
        // var damagePerSecond = totalDamage / totalSecondsPlayed;
        //
        // // print minutes, seconds played, and dps
        // Debug.Log("Minutes played: " + minutesPlayed);
        // Debug.Log("Seconds played: " + secondsPlayed);
        // Debug.Log("Damage per Second: " + damagePerSecond);
        //
        // // const message = "Don't wanna print anything";
        // Debug.Log("Don't wanna print anything");
    }
    // void Update()
    // {

    // }
}