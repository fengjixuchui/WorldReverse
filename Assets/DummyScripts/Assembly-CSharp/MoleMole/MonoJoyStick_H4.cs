/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoJoyStick_H4 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler // TypeDefIndex: 31233
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _joystickHead; // 0x18
		public bool DebugMode; // 0x20
		public float WALK_SCALE; // 0x24
		public float JOYPAD_SCALE; // 0x28
		private float _joystickPhysicalRadius; // 0x2C
		private const float LIMITED_LENGTH_FACTOR = 1f; // Metadata: 0x00B1208F
		private const float START_MOVE_MOLD_THRESHOLD = 0f; // Metadata: 0x00B12093
		public float DAMPING; // 0x30
		private RectTransform _parentRectTrans; // 0x38
		private bool _isPointerDown; // 0x40
		private bool _useVirtualJoyStick; // 0x41
		private const int POINTER_NONE = -253; // Metadata: 0x00B12097
		private int _controlPointerID; // 0x44
		private Vector2 _currentScreenHitPos; // 0x48
		private Vector2 _lastScreenHitPos; // 0x50
		private bool _fixedAnchor; // 0x58
		private Vector2 _innerCurrentAnchorPos; // 0x5C
		private Vector2 _fixedAnchorPos; // 0x64
		private Vector2 FIXED_ANCHOR_POS; // 0x6C
		private Vector2 FIXED_ANCHOR_POS_WIDE_SCREEN; // 0x74
		private static readonly Vector2 OUT_OF_SCREEN_POS; // 0x00
		private float _lastAnalogInputX; // 0x7C
		private float _lastAnalogInputY; // 0x80
		public Action<float, float> moveCallback; // 0x88
		private const float REF_DPI = 324f; // Metadata: 0x00B1209B
		private float _refScreenWidth; // 0x90
		private float _refScreenHeight; // 0x94
		private float _dpi; // 0x98
		private int _screenWidth; // 0x9C
		private int _screenHeight; // 0xA0
		private float _deviceWidth; // 0xA4
		private bool isWalking; // 0xA8
		private bool isRuning; // 0xA9
		private RectTransform _grpJoystick; // 0xB0
		private RectTransform _joystickBack; // 0xB8
		private RectTransform _markWalk; // 0xC0
		private RectTransform _markRun; // 0xC8
	
		// Properties
		public bool isPointerDown { /* [XID] */ /* 0x000000018960F9C0-0x000000018960F9E0 */ get => default; } // 0x0000000183F80900-0x0000000183F809A0 
		public Vector2 currentAnchorPos { /* [XID] */ /* 0x0000000189616C10-0x0000000189616C30 */ get => default; /* [XID] */ /* 0x000000018961E7C0-0x000000018961E7E0 */ set {} } // 0x0000000183F80840-0x0000000183F80900 0x0000000183F809A0-0x0000000183F80A50
	
		// Constructors
		public MonoJoyStick_H4() {} // 0x0000000183F80720-0x0000000183F80840
		static MonoJoyStick_H4() {} // 0x0000000183F80670-0x0000000183F80720
	
		// Methods
		// [XID] // 0x0000000189625BA0-0x0000000189625BC0
		public void SwitchJoyStick() {} // 0x0000000183F7F960-0x0000000183F7FA10
		// [XID] // 0x000000018962D4C0-0x000000018962D4E0
		public void GetDefaultValueInCode(out float x, out float y, out float length, out float threshold) {
			x = default;
			y = default;
			length = default;
			threshold = default;
		} // 0x0000000183F7EC00-0x0000000183F7ED30
		// [XID] // 0x0000000189635080-0x00000001896350A0
		public void ChangeFixedAnchorX(string value) {} // 0x0000000183F7E090-0x0000000183F7E1B0
		// [XID] // 0x000000018963C6A0-0x000000018963C6C0
		public void ChangeFixedAnchorY(string value) {} // 0x0000000183F7E1B0-0x0000000183F7E2D0
		// [XID] // 0x0000000189643DF0-0x0000000189643E10
		public void ChangeToWalkThreshold(string value) {} // 0x0000000183F7E2D0-0x0000000183F7E400
		// [XID] // 0x000000018964B530-0x000000018964B550
		private void Awake() {} // 0x0000000183F7DDA0-0x0000000183F7E090
		// [XID] // 0x0000000189652D60-0x0000000189652D80
		private void Start() {} // 0x0000000183F7F850-0x0000000183F7F960
		// [XID] // 0x000000018965A440-0x000000018965A460
		private void OnEnable() {} // 0x0000000183F7F4B0-0x0000000183F7F5C0
		// [XID] // 0x0000000189661A90-0x0000000189661AB0
		private void OnDisable() {} // 0x0000000183F7F250-0x0000000183F7F3C0
		// [XID] // 0x0000000189669630-0x0000000189669650
		private void OnResolutionChange() {} // 0x0000000183F7ED30-0x0000000183F7F120
		// [XID] // 0x0000000189671140-0x0000000189671160
		private void SetRectTransScale(RectTransform rectTrans, float scale) {} // 0x0000000183F7EAD0-0x0000000183F7EC00
		// [XID] // 0x00000001896789A0-0x00000001896789C0
		public void UpdateView() {} // 0x0000000183F80060-0x0000000183F80670
		// [XID] // 0x000000018967FFA0-0x000000018967FFC0
		public void UpdateCameraView(bool isMoving, float angle) {} // 0x0000000183F7FD20-0x0000000183F80060
		// [XID] // 0x0000000189687C10-0x0000000189687C30
		public void DoOnUnactive() {} // 0x0000000183F7EA10-0x0000000183F7EAD0
		// [XID] // 0x000000018968F610-0x000000018968F630
		private void ProcessInput() {} // 0x0000000183F7E400-0x0000000183F7EA10
		// [XID] // 0x0000000189697070-0x0000000189697090
		public void TranslateAxisInput(float inputX, float inputY) {} // 0x0000000183F7FA10-0x0000000183F7FC50
		// [XID] // 0x000000018969E550-0x000000018969E570
		public void OnDrag(PointerEventData eventData) {} // 0x0000000183F7F3C0-0x0000000183F7F4B0
		// [XID] // 0x00000001896A55E0-0x00000001896A5600
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000183F7F5C0-0x0000000183F7F6F0
		// [XID] // 0x00000001896ACE70-0x00000001896ACE90
		public void OnPointerUp(PointerEventData eventData) {} // 0x0000000183F7F6F0-0x0000000183F7F850
		// [XID] // 0x00000001896B4490-0x00000001896B44B0
		public void TryResetJoystickPhysicalRadius(float physicalRadius) {} // 0x0000000183F7FC50-0x0000000183F7FD20
		// [XID] // 0x00000001896BB770-0x00000001896BB790
		private void OnApplicationFocus(bool isFocus) {} // 0x0000000183F7F120-0x0000000183F7F250
	}
}
