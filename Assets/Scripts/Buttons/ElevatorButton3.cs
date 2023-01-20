using System.Collections;
using UnityEngine;

public class ElevatorButton3 : MonoBehaviour
{
    [HideInInspector] public bool _mouseClickElevatorButton3 = false;

    public void OnMouseUpAsButton()
    {
        _mouseClickElevatorButton3 = true;
        StartCoroutine(ResetButton());
    }

    private IEnumerator ResetButton()
    {
        yield return new WaitForSeconds(5);
        _mouseClickElevatorButton3 = false;
    }
}