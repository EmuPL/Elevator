using System;
using DG.Tweening;
using UnityEngine;

public class ElevatorDoorsAnimation : MonoBehaviour
{
    [SerializeField] private Transform Elevator;
    [SerializeField] private Transform ElevatorDoorRight;
    [SerializeField] private Transform ElevatorDoorLeft;
    [HideInInspector] public event Action OnDoorsClosed;
    private int _doorLenght = 1;

    public void closeDoor()
    {
        ElevatorDoorRight.transform.DOMove(new Vector3(Elevator.position.x, Elevator.position.y + 1.83f, Elevator.position.z), _doorLenght);
        ElevatorDoorLeft.transform.DOMove(new Vector3(Elevator.position.x, Elevator.position.y + 1.83f, Elevator.position.z + 2f), _doorLenght).OnComplete(() =>
        {
            OnDoorsClosed?.Invoke();
        });
    }

    public void openDoor()
    {
        ElevatorDoorRight.transform.DOMove(new Vector3(Elevator.position.x, Elevator.position.y + 1.83f, Elevator.position.z - 1.32f), _doorLenght);
        ElevatorDoorLeft.transform.DOMove(new Vector3(Elevator.position.x, Elevator.position.y + 1.83f, Elevator.position.z + 3.6f), _doorLenght);
    }
}