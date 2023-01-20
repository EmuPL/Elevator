using System;
using UnityEngine;

public class DoorsTriggerHandler : MonoBehaviour
{
    [HideInInspector] public bool _playerisinDoors;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("i");
        _playerisinDoors = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _playerisinDoors = false;
        Debug.Log("o");
    }
}