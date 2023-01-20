using System.Collections;
using UnityEngine;

public class RoomButton3 : MonoBehaviour
{
    [HideInInspector] public bool _mouseClickRoomButton3 = false;

    public void OnMouseUpAsButton()
    {
        _mouseClickRoomButton3 = true;
        StartCoroutine(ResetClick());
    }

    private IEnumerator ResetClick()
    {
        yield return new WaitForSeconds(5);
        _mouseClickRoomButton3 = false;
    }
}