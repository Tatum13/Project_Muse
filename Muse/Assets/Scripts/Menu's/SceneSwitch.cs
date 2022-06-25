using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo) 
    {
        SceneManager.LoadScene(2);
    }
}
