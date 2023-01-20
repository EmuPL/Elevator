using System.Collections;
using UnityEngine;

public class RoomButton0 : MonoBehaviour
{
    [HideInInspector] public bool _mouseClickRoomButton0 = false;

    public void OnMouseUpAsButton()
    {
        _mouseClickRoomButton0 = true;
        StartCoroutine(ResetClick());
    }

    private IEnumerator ResetClick()
    {
        yield return new WaitForSeconds(5);
        _mouseClickRoomButton0 = false;
    }
}