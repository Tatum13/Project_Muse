using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private bool _isPaused = false;
    [SerializeField] private GameObject _pauseMenuUI;

    private void Start()
    {
        _pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void PauseGame(InputAction.CallbackContext context)
    {
        if (_pauseMenuUI == null) return; //Wanneer die de canvas niet kan vinden GA dan terug.
        if (_isPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
    public void Resume()
    {
        _pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        _isPaused = false;
    }
    public void Pause()
    {
        _pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        _isPaused = true;
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
