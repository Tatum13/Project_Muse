using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private GameObject _player;
    public bool isWalking;

    private void Start()
    {
        _player = GameObject.Find("Player");
    }
    public void Walking(Vector3 position)
    {
            var moveDirection = new Vector3(position.x, 0, position.y); //de z word een y wegens dat je niet springt.
            transform.position += moveDirection * speed * Time.deltaTime;
            _player.transform.rotation = Quaternion.LookRotation(moveDirection);
    }

}
