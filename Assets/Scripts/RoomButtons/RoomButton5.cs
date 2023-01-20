using System.Collections;
using UnityEngine;

public class RoomButton5 : MonoBehaviour
{
    [HideInInspector] public bool _mouseClickRoomButton5 = false;

    public void OnMouseUpAsButton()
    {
        _mouseClickRoomButton5 = true;
        StartCoroutine(ResetClick());
    }

    private IEnumerator ResetClick()
    {
        yield return new WaitForSeconds(5);
        _mouseClickRoomButton5 = false;
    }
}