using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LevelRotate : MonoBehaviour
{
    public FPControl.PlayerControlsActions _inputControls;
    public InputParse _input;
    [SerializeField] private GameObject world;
    [SerializeField] private GameObject worldOrigin;
    [SerializeField] private bool _isTurning = false;
    [SerializeField] private float rotateDir;

    public Dictionary<Vector2, Vector3> directions = new Dictionary<Vector2, Vector3>();

    private IEnumerator routine;
    private void Start()
    {
        world = GameObject.Find("Level");
        AllDirections();
    }
    public void AllDirections()
    {
        directions.Add(Vector2.left, new Vector3(0, 90, 0));
        directions.Add(Vector2.right, new Vector3(0, -90, 0));
        directions.Add(Vector2.up, new Vector3(90, 0, 0));
        directions.Add(Vector2.down, new Vector3(-90, 0, 0));
    }

    IEnumerator YKeys(Vector2 dir)
    {
        _isTurning = true;
        //var angle = world.transform.eulerAngles;//Kijkt naar wat de angle nu is.
        var angle = transform.eulerAngles;
        var targetAngle = angle + directions[dir];//Kijkt naar de angle waar die naartoe moet.

        float time = 0;
        float duration = 0.5f;

        while (time< duration)//Wanneer de angle dat die is niet gelijk is aan de angle waar die naartoe moet.
        {
            var newPosition = Vector3.Lerp(angle, targetAngle, time / duration);
            time += Time.deltaTime;
            world.transform.eulerAngles = newPosition;
            yield return null;
        }
        _isTurning = false;
    }
    /*
    IEnumerator XKeys(Vector2 dir)
    {
        _isTurning = true;
        var angle = worldOrigin.transform.eulerAngles;//Kijkt naar wat de angle nu is.
        var targetAngle = angle + directions[dir];//Kijkt naar de angle waar die naartoe moet.

        float time = 0;
        float duration = 0.5f;

        while (time < duration)//Wanneer de angle dat die is niet gelijk is aan de angle waar die naartoe moet.
        {
            var newPosition = Vector3.Lerp(angle, targetAngle, time / duration);
            time += Time.deltaTime;
            worldOrigin.transform.eulerAngles = newPosition;
            yield return null;
        }
        _isTurning = false;
    }
    */
    public void Pressed(InputAction.CallbackContext context)//Kijkt naar welke knop je indrukt.
    {
        //Debug.Log(_inputControls.Rotate.ReadValue<Vector2>());
        if (!_isTurning)
        {
            var dir = _inputControls.Rotate.ReadValue<Vector2>(); //kijkt naar welke knoppen je indrukt.
            if (routine != null)
            {
                StopCoroutine(routine);
                /*
                if(dir.x == 1 || dir.x == -1)
                {
                    routine = YKeys(dir);
                }
                else if(dir.y == 0 || dir.y == -1)
                {
                    routine = XKeys(dir);
                }
                */
            }
            routine = YKeys(dir);
            StartCoroutine(routine);
        }
        else
        {
            Debug.Log("i'm busy ");
        }
    }
}

