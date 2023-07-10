using UnityEngine;

/// <summary>
///     A script to test the timer class
/// </summary>
public class TimerTest : MonoBehaviour
{
    // time measurement
    private float startTime;

    // test object
    private Timer timer;

    private void Start()
    {
        // create and run timer
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 3;
        timer.Run();

        // save start time
        startTime = Time.time;
    }

    private void Update()
    {
        // check for timer just finished
        if (timer.Finished)
        {
            // timer just finished
            var elapsedTime = Time.time - startTime;
            Debug.Log("Timer ran for " + elapsedTime + " seconds");

            // save start time and restart timer
            startTime = Time.time;
            timer.Run();
        }
    }
}