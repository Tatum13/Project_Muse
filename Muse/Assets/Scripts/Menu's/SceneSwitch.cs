using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] private bool level1;
    [SerializeField] private bool level2;
    private int level;
    private void Start()
    {
        if (level1 == true)
        {
            level = 1;
        }
        else if (level2 == true)
        {
            level = 2;
        }
    }
    private void OnCollisionEnter(Collision collisionInfo) 
    {
        SceneManager.LoadScene(sceneBuildIndex: level);
    }
}
