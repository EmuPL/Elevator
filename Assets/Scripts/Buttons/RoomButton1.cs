using System.Collections;
using UnityEngine;

public class RoomButton1 : MonoBehaviour
{
    [HideInInspector] public bool _mouseClickRoomButton1 = false;

    public void OnMouseUpAsButton()
    {
        _mouseClickRoomButton1 = true;
        StartCoroutine(ResetClick());
    }

    private IEnumerator ResetClick()
    {
        yield return new WaitForSeconds(5);
        _mouseClickRoomButton1 = false;
    }
}