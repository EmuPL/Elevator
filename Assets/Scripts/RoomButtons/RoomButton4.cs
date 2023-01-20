using System.Collections;
using UnityEngine;

public class RoomButton4 : MonoBehaviour
{
    [HideInInspector] public bool _mouseClickRoomButton4 = false;

    public void OnMouseUpAsButton()
    {
        _mouseClickRoomButton4 = true;
        StartCoroutine(ResetClick());
    }

    private IEnumerator ResetClick()
    {
        yield return new WaitForSeconds(5);
        _mouseClickRoomButton4 = false;
    }
}