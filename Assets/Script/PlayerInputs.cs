//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//namespace Player
//{
//    [System.Serializable]
//    public class Inputs
//    {
//        public KeyCode primary;
//        public KeyCode alternate;

//        public bool Pressed()
//        {
//            return UnityEngine.Input.GetKey(primary) || UnityEngine.Input.GetKey(alternate);
//        }
//        public bool PressDown()
//        {
//            return UnityEngine.Input.GetKeyDown(primary) || UnityEngine.Input.GetKeyDown(alternate);
//        }
//        public bool PressedUp()
//        {
//            return UnityEngine.Input.GetKeyUp(primary) || UnityEngine.Input.GetKeyUp(alternate);
//        }
//    }
//    public class PlayerInputs : MonoBehaviour
//    {
//        public Inputs Forward;
//        public Inputs Backward;
//        public Inputs Left;
//        public Inputs Right;
//        public Inputs Sprint;
//        public Inputs Jump;

//        public int MoveAxisForwardRaw
//        {
//            get
//            {
//                if (Forward.Pressed() && Backward.Pressed()) { return 0; }
//                else if (Forward.Pressed()) { return 1; }
//                else if (Backward.Pressed()) { return -1; }
//                else { return 0; }

//            }
//        }
//        public int MoveAxisRightRaw
//        {
//            get
//            {
//                if (Right.Pressed() && Left.Pressed()) { return 0; }
//                else if (Right.Pressed()) { return 1; }
//                else if (Left.Pressed()) { return -1; }
//                else { return 0; }
//            }
//        }

//        private const string _playerXString = "Mouse X";
//        private const string _playerYString = "Mouse Y";
        

//        public static float PlayerXInput { get => UnityEngine.Input.GetAxis(_playerXString); }
//        public static float PlayerYInput { get => UnityEngine.Input.GetAxis(_playerYString); }
//    }
//}

