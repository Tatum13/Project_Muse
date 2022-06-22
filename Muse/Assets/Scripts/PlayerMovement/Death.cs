using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private void OnTriggerExit(Collider Trigger)
    {
        Points.Levens = Points.Levens +1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        int recievedPoints = Points.Levens;
        Debug.Log(recievedPoints);
    }
}
