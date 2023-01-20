using System.Collections;
using UnityEngine;

public class ElevatorButton2 : MonoBehaviour
{
    [HideInInspector] public bool _mouseClickElevatorButton2 = false;

    public void OnMouseUpAsButton()
    {
        _mouseClickElevatorButton2 = true;
        StartCoroutine(ResetButton());
    }

    private IEnumerator ResetButton()
    {
        yield return new WaitForSeconds(5);
        _mouseClickElevatorButton2 = false;
    }
}