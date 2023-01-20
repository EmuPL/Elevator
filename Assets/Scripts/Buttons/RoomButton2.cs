using System.Collections;
using UnityEngine;

public class RoomButton2 : MonoBehaviour
{
    [HideInInspector] public bool _mouseClickRoomButton2 = false;

    public void OnMouseUpAsButton()
    {
        _mouseClickRoomButton2 = true;
        StartCoroutine(ResetClick());
    }

    private IEnumerator ResetClick()
    {
        yield return new WaitForSeconds(5);
        _mouseClickRoomButton2 = false;
    }
}