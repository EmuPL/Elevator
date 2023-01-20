using System.Collections;
using UnityEngine;

public class ElevatorButton0 : MonoBehaviour
{
    [HideInInspector] public bool _mouseClickElevatorButton0 = false;

    public void OnMouseUpAsButton()
    {
        _mouseClickElevatorButton0 = true;
        StartCoroutine(ResetButton());
    }

    private IEnumerator ResetButton()
    {
        yield return new WaitForSeconds(5);
        _mouseClickElevatorButton0 = false;
    }
}