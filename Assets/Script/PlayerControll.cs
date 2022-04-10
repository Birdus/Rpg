//using UnityEngine;

//namespace Player
//{
//    public class PlayerControll : MonoBehaviour
//    {
//        [Header("Seting Move Player")]
//        [SerializeField] private float _walkingSpeed = 7.5f;
//        [SerializeField] private float _sprintSpeed = 11.5f;
//        [SerializeField] private Camera _camera;
//        [SerializeField] private float _moveSharpnes = 10f;
//        [SerializeField, Range(0, 20)] private float _lookSpeed = 2.0f;
        

//        //Private
//        private float _jumpSpeed = 8.0f;
//        private float _gravity = 20.0f;
//        private float _lookXLimit = 45f;
//        private Vector3 _moveDirection = Vector3.zero;
//        private CharacterController _characterController;
//        private bool _canMove = true;
//        private Vector3 _newVelocity;
//        private PlayerInputs _inputs;
//        private float _rotationX;
//        private float _rotationY;
//        private float _targetSpeed;
//        private float _newSpeed;
//        [HideInInspector]
//        public bool canMove = true;

//        private void Start()
//        {
//            _characterController = GetComponent<CharacterController>();
//            _inputs = GetComponent<PlayerInputs>();
//            Cursor.visible = false;
//            Cursor.lockState = CursorLockMode.Locked;
//        }

//        private void Update()
//        {

//            Vector3 forward = new Vector3(_inputs.MoveAxisForwardRaw,0,0);
//            Vector3 right = new Vector3(_inputs.MoveAxisRightRaw, 0, 0);
//            // Нажитие Shift = бег
//            bool isRunning = _inputs.Sprint.Pressed();
//            float curSpeedX = canMove ? (isRunning ? _sprintSpeed : _walkingSpeed) * Input.GetAxis("Vertical") : 0;
//            float curSpeedY = canMove ? (isRunning ? _sprintSpeed : _walkingSpeed) * Input.GetAxis("Horizontal") : 0;
//            float movementDirectionY = _moveDirection.y;
//            _moveDirection = (forward * curSpeedX) + (right * curSpeedY);
            

//            if (_inputs.Jump.PressDown() && canMove && _characterController.isGrounded)
//            {
//                _moveDirection.y = _jumpSpeed;
//            }
//            else
//            {
//                _moveDirection.y = movementDirectionY;
//            }

//            //Гравитация
//            if (!_characterController.isGrounded)
//            {
//                _moveDirection.y -= _gravity * Time.deltaTime;
//            }

//            _characterController.Move(_moveDirection * Time.deltaTime);

//            // Поворот камеры  и игрока
//            if (canMove)
//            {
//                _rotationX += -PlayerInputs.PlayerYInput * _lookSpeed;
//                _rotationX = Mathf.Clamp(_rotationX, - _lookXLimit, _lookXLimit);
//                _camera.transform.localRotation = Quaternion.Euler(_rotationX, 0, 0);
//                transform.rotation *= Quaternion.Euler(0, PlayerInputs.PlayerXInput * _lookSpeed, 0);
//            }
//        }
//    }
//}

