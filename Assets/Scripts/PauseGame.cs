using UnityEngine;

public class PauseGame : MonoBehaviour
{
    bool isPaused = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !isPaused)
        {
            Time.timeScale = 0f;
            isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.P) && isPaused)
        {
            Time.timeScale = 1f;
            isPaused = false;
        }
    }
}
