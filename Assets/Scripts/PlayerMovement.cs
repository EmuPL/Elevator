using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController Controller;
    [SerializeField] private float Speed = 12f;
    [SerializeField] private float Gravity = -9.81f;
    [SerializeField] private float JumpHeight = 3f;

    [SerializeField] private Transform GroundCheck;
    [SerializeField] private float GroundDistance = 0.4f;
    [SerializeField] private LayerMask GroundMask;

    private bool _isGrounded = true;
    private Vector3 _Velocity;

    private void Update()
    {
        _isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);

        if (_isGrounded && _Velocity.y < 0)
        {
            _Velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        Controller.Move(move * Speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _Velocity.y = Mathf.Sqrt(JumpHeight * -2f * Gravity);
        }

        _Velocity.y += Gravity * Time.deltaTime;

        Controller.Move(_Velocity * Time.deltaTime);
    }
}