using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public void Switch()
    {
        Points.Levens = 0;
        SceneManager.LoadScene(0);
    }
}
