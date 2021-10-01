using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace CanCandir.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] float _playerSpeed;

        private CharacterController2D _controller;
        private Rigidbody2D _myRigidbody;

        private Vector2 horizontalMove = Vector2.zero;

        private bool _canJump = false;

        private PlayerMovementInput _playerMovementInput;
        private InputAction _movement;

        private void Awake()
        {
            _controller = GetComponent<CharacterController2D>();
            _myRigidbody = GetComponent<Rigidbody2D>();

            _playerMovementInput = new PlayerMovementInput();
        }

        private void OnEnable()
        {
            _movement = _playerMovementInput.Player.Movement;
            _movement.Enable();
        }

        private void OnDisable()
        {
            _movement.Disable();
        }

        private void Update()
        {
            horizontalMove = _movement.ReadValue<Vector2>() * _playerSpeed;
        }

        private void FixedUpdate()
        {
            _controller.Move(horizontalMove.x * Time.fixedDeltaTime, false, _canJump);

            _canJump = false;
        } 

        public void CanJump(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                _canJump = true;
            }
        }
    }
}

/*
 * 
 * 
 * public class PlayerMovement : MonoBehaviour
    {
        [Header("Move")]
        [SerializeField] float _playerSpeed;

        [Header("Jump")]
        [SerializeField] float _jumpForce;
        [Range(0f, 5f)]
        [SerializeField] float _jumpSensibility;


        private Rigidbody2D _myRigidbody;

        private void Awake()
        {
            _myRigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            PlayerMove();
            PlayerJump();

            if (Input.GetKeyDown(KeyCode.A))
                Debug.Log(_myRigidbody.velocity);
        }

        private void PlayerMove()
        {
            float move = Input.GetAxis("Horizontal");

            transform.position += new Vector3(move, 0f, 0f) * _playerSpeed * Time.deltaTime;
        }

        private void PlayerJump()
        {
            if (Input.GetButtonDown("Jump") && Mathf.Abs(_myRigidbody.velocity.y) < _jumpSensibility)
            {
                _myRigidbody.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
            } 
        }
    }
*/

/*
 * 
 * public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] float _thrust;

        private Rigidbody2D _myRigidbody;

        private void Awake()
        {
            _myRigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Move();
            }
        }
        private void Move()
        {
            _myRigidbody.velocity = Vector2.zero;

            _myRigidbody.AddForce(MoveDirection() * _thrust, ForceMode2D.Impulse);
        }

        private Vector3 MoveDirection()
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            return transform.position - mousePosition;
        }
    }

 */