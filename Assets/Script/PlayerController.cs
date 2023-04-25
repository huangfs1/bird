using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerCharacter _playerCharacter;
    

    void Awake()
    {
        _playerCharacter = FindObjectOfType<PlayerCharacter>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _playerCharacter.Up();
        }
    }
}
