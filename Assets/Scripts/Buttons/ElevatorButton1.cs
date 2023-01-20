using System.Collections;
using UnityEngine;

public class ElevatorButton1 : MonoBehaviour
{
    [HideInInspector] public bool _mouseClickElevatorButton1 = false;

    public void OnMouseUpAsButton()
    {
        _mouseClickElevatorButton1 = true;
        StartCoroutine(ResetButton());
    }

    private IEnumerator ResetButton()
    {
        yield return new WaitForSeconds(5);
        _mouseClickElevatorButton1 = false;
    }
}