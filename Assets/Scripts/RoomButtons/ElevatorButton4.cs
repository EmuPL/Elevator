using System.Collections;
using UnityEngine;

public class ElevatorButton4 : MonoBehaviour
{
    [HideInInspector] public bool _mouseClickElevatorButton4 = false;

    public void OnMouseUpAsButton()
    {
        _mouseClickElevatorButton4 = true;
        StartCoroutine(ResetButton());
    }

    private IEnumerator ResetButton()
    {
        yield return new WaitForSeconds(5);
        _mouseClickElevatorButton4 = false;
    }
}