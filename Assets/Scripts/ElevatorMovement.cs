using System.Collections;
using DG.Tweening;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour
{
    [SerializeField] private Transform Elevator;
    [SerializeField] private RoomButton0 RoomButton0;
    [SerializeField] private RoomButton1 RoomButton1;
    [SerializeField] private RoomButton2 RoomButton2;
    [SerializeField] private RoomButton3 RoomButton3;
    [SerializeField] private RoomButton4 RoomButton4;
    [SerializeField] private RoomButton5 RoomButton5;
    [SerializeField] private ElevatorButton0 ElevatorButton0;
    [SerializeField] private ElevatorButton1 ElevatorButton1;
    [SerializeField] private ElevatorButton2 ElevatorButton2;
    [SerializeField] private ElevatorButton3 ElevatorButton3;
    [SerializeField] private ElevatorButton4 ElevatorButton4;
    [SerializeField] private ElevatorButton5 ElevatorButton5;
    [SerializeField] private ElevatorDoorsAnimation ElevatorDoorsAnimation;
    [SerializeField] private DoorsTriggerHandler DoorsTriggerHandler;
    private float _wait = 6;
    private bool _elevatorIsMoving = false;

    private void Start()
    {
        DOTween.SetTweensCapacity(1250, 50);
        ElevatorDoorsAnimation.OnDoorsClosed += Use;
    }

    private void FixedUpdate()
    {
        if (RoomButton0._mouseClickRoomButton0 || RoomButton1._mouseClickRoomButton1 || RoomButton2._mouseClickRoomButton2 || RoomButton3._mouseClickRoomButton3 || RoomButton4._mouseClickRoomButton4 || RoomButton5._mouseClickRoomButton5 && !_elevatorIsMoving)
        {
            ElevatorDoorsAnimation.closeDoor();
            _elevatorIsMoving = true;
        }
        if (ElevatorButton0._mouseClickElevatorButton0 || ElevatorButton1._mouseClickElevatorButton1 || ElevatorButton2._mouseClickElevatorButton2 || ElevatorButton3._mouseClickElevatorButton3 || ElevatorButton4._mouseClickElevatorButton4 || ElevatorButton5._mouseClickElevatorButton5 && !_elevatorIsMoving)
        {
            ElevatorDoorsAnimation.closeDoor();
            _elevatorIsMoving = true;
        }
    }

    private void Use()
    {
        Debug.Log("u");
        if (RoomButton0._mouseClickRoomButton0)
        {
            StartCoroutine(WaitAndMove(new Vector3(2.4f, 0.5f, 15.5f), _wait));
        }
        else if (RoomButton1._mouseClickRoomButton1)
        {
            StartCoroutine(WaitAndMove(new Vector3(2.4f, 15.5f, 15.5f), _wait * 2));
        }
        else if (RoomButton2._mouseClickRoomButton2)
        {
            StartCoroutine(WaitAndMove(new Vector3(2.4f, 30.5f, 15.5f), _wait * 3));
        }
        else if (RoomButton3._mouseClickRoomButton3)
        {
            StartCoroutine(WaitAndMove(new Vector3(2.4f, 45.5f, 15.5f), _wait * 4));
        }
        else if (RoomButton4._mouseClickRoomButton4)
        {
            StartCoroutine(WaitAndMove(new Vector3(2.4f, 60.5f, 15.5f), _wait * 5));
        }
        else if (RoomButton5._mouseClickRoomButton5)
        {
            StartCoroutine(WaitAndMove(new Vector3(2.4f, 75.5f, 15.5f), _wait * 6));
        }
        if (ElevatorButton0._mouseClickElevatorButton0)
        {
            StartCoroutine(WaitAndMove(new Vector3(2.4f, 0.5f, 15.5f), _wait));
        }
        else if (ElevatorButton1._mouseClickElevatorButton1)
        {
            StartCoroutine(WaitAndMove(new Vector3(2.4f, 15.5f, 15.5f), _wait * 2));
        }
        else if (ElevatorButton2._mouseClickElevatorButton2)
        {
            StartCoroutine(WaitAndMove(new Vector3(2.4f, 30.5f, 15.5f), _wait * 3));
        }
        else if (ElevatorButton3._mouseClickElevatorButton3)
        {
            StartCoroutine(WaitAndMove(new Vector3(2.4f, 45.5f, 15.5f), _wait * 4));
        }
        else if (ElevatorButton4._mouseClickElevatorButton4)
        {
            StartCoroutine(WaitAndMove(new Vector3(2.4f, 60.5f, 15.5f), _wait * 5));
        }
        else if (ElevatorButton5._mouseClickElevatorButton5)
        {
            StartCoroutine(WaitAndMove(new Vector3(2.4f, 75.5f, 15.5f), _wait * 6));
        }
    }

    private IEnumerator WaitAndMove(Vector3 _targetPosition, float _waitTime)
    {
        yield return new WaitForSeconds(5);
        Elevator.transform.DOMove(_targetPosition, _waitTime).OnComplete(() =>
        {
            StartCoroutine(ElevatorArrive());
        });
    }

    private IEnumerator ElevatorArrive()
    {
        yield return new WaitForSeconds(5);
        ElevatorDoorsAnimation.openDoor();
        _elevatorIsMoving = false;
        Debug.Log("a");
    }
}