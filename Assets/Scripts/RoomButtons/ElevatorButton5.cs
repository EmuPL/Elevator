using System.Collections;
using UnityEngine;

public class ElevatorButton5 : MonoBehaviour
{
    [HideInInspector] public bool _mouseClickElevatorButton5 = false;

    public void OnMouseUpAsButton()
    {
        _mouseClickElevatorButton5 = true;
        StartCoroutine(ResetButton());
    }

    private IEnumerator ResetButton()
    {
        yield return new WaitForSeconds(5);
        _mouseClickElevatorButton5 = false;
    }
}