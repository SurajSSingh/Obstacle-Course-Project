using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private static bool isGamePaused = false;
    private static CursorLockMode originalCursorMode;
    public static bool IsGamePaused => isGamePaused;

    public void LoadLevelByName(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void LoadLevelByIndex(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void ReloadCurrentLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        originalCursorMode = Cursor.lockState;
        Cursor.lockState = CursorLockMode.None;
        isGamePaused = true;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;
        Cursor.lockState = originalCursorMode;
        isGamePaused = false;
    }

    public void TogglePauseGame()
    {
        if (isGamePaused)
        {
            UnpauseGame();
        }
        else
        {
            PauseGame();
        }
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
