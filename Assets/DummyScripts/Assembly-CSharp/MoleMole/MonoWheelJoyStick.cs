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
	public class MonoWheelJoyStick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 31092
	{
		// Fields
		public bool DebugMode; // 0x18
		public float UNIT_SIZE; // 0x1C
		private float LIMITED_LENGTH_IN_INCH; // 0x20
		private const float LIMITED_LENGTH_FACTOR = 1f; // Metadata: 0x00B11EA2
		private const float START_MOVE_MOLD_THRESHOLD = 0f; // Metadata: 0x00B11EA6
		private float FIXED_ANCHOR_POS_X; // 0x24
		private float FIXED_ANCHOR_POS_Y; // 0x28
		public float DAMPING; // 0x2C
		private RectTransform _parentRectTrans; // 0x30
		private bool _isPointerDown; // 0x38
		private bool _pointerLeaveTrigger; // 0x39
		private const int POINTER_NONE = -253; // Metadata: 0x00B11EAA
		private int _controlPointerID; // 0x3C
		private Vector2 _innerCurrentAnchorPos; // 0x40
		private Vector2 _fixedAnchorPos; // 0x48
		private Vector2 _currentScreenHitPos; // 0x50
		private Vector2 _lastScreenHitPos; // 0x58
		private static readonly Vector2 OUT_OF_SCREEN_POS; // 0x00
		private RectTransform _stickHeadTrans; // 0x60
		private RectTransform _stickTailTrans; // 0x68
		private static Vector2 ANALOG_HEAD_POS_XY; // 0x08
		public Action<bool, float, float> moveCallback; // 0x80
		public Action downCallback; // 0x88
		public Action upCallback; // 0x90
		private const float REF_DPI = 324f; // Metadata: 0x00B11EAE
		private float _refScreenWidth; // 0x98
		private float _refScreenWidthInInch; // 0x9C
		private float _screenWidthInInch; // 0xA0
		private bool _fixedAnchor; // 0xA4
		private bool _isEnable; // 0xA5
	
		// Properties
		public bool IsMoving { /* [XID] */ /* 0x00000001899B02B0-0x00000001899B02F0 */ get; /* [XID] */ /* 0x00000001899BA7B0-0x00000001899BA7F0 */ private set; } // 0x00000001824AA450-0x00000001824AA4B0 0x00000001824A7E20-0x00000001824A7E80
		public float CurrentAngle { /* [XID] */ /* 0x00000001899C5220-0x00000001899C5260 */ get; /* [XID] */ /* 0x00000001899CF920-0x00000001899CF960 */ private set; } // 0x00000001824AA2C0-0x00000001824AA330 0x00000001824A8100-0x00000001824A8170
		public float CurrentMold { /* [XID] */ /* 0x00000001899D9DD0-0x00000001899D9E10 */ get; /* [XID] */ /* 0x00000001899E46F0-0x00000001899E4730 */ private set; } // 0x00000001824AA330-0x00000001824AA3A0 0x00000001824A7E80-0x00000001824A7EF0
		private Vector2 _currentAnchorPos { /* [XID] */ /* 0x00000001899EEC10-0x00000001899EEC30 */ get => default; /* [XID] */ /* 0x00000001899F6490-0x00000001899F64B0 */ set {} } // 0x00000001824A94A0-0x00000001824A9560 0x00000001824A8B60-0x00000001824A8C10
		public bool IsFixedAnchor { /* [XID] */ /* 0x00000001899FD9F0-0x00000001899FDA10 */ get => default; } // 0x00000001824AA3A0-0x00000001824AA450 
	
		// Constructors
		public MonoWheelJoyStick() {} // 0x00000001824AA200-0x00000001824AA2C0
		static MonoWheelJoyStick() {} // 0x00000001824AA120-0x00000001824AA200
	
		// Methods
		// [XID] // 0x0000000189A05430-0x0000000189A05450
		public void SwitchJoyStick() {} // 0x00000001824A9F80-0x00000001824AA040
		// [XID] // 0x0000000189A0C750-0x0000000189A0C770
		public void ChangeFixedAnchorPos(Vector2 pos) {} // 0x00000001824A82D0-0x00000001824A8380
		// [XID] // 0x0000000189A14120-0x0000000189A14140
		public void ChangeFixedAnchorLength(float temp) {} // 0x00000001824A8210-0x00000001824A82D0
		// [XID] // 0x0000000189A1B350-0x0000000189A1B370
		private Vector2 GetcurrentAnchorPos() => default; // 0x00000001824A93E0-0x00000001824A94A0
		// [XID] // 0x0000000189A22C50-0x0000000189A22C70
		private void SetCurrentAnchorPos(Vector2 pos) {} // 0x00000001824A8D30-0x00000001824A8DE0
		// [XID] // 0x0000000189A29EE0-0x0000000189A29F00
		public void Awake() {} // 0x00000001824A7EF0-0x00000001824A8100
		// [XID] // 0x0000000189A31420-0x0000000189A31440
		public void Start() {} // 0x00000001824A9C70-0x00000001824A9F80
		// [XID] // 0x0000000189A38EF0-0x0000000189A38F10
		private void OnDisable() {} // 0x00000001824A9560-0x00000001824A9770
		// [XID] // 0x0000000189A40650-0x0000000189A40670
		public void Update() {} // 0x00000001824AA040-0x00000001824AA120
		// [XID] // 0x0000000189A47D50-0x0000000189A47D70
		private void DoOnActive(Vector2 hitPos) {} // 0x00000001824A89E0-0x00000001824A8B60
		// [XID] // 0x0000000189A4F4B0-0x0000000189A4F4D0
		private void DoOnUnactive() {} // 0x00000001824A8170-0x00000001824A8210
		// [XID] // 0x0000000189A56C10-0x0000000189A56C30
		private void UpdateLength() {} // 0x00000001824A84D0-0x00000001824A89E0
		// [XID] // 0x0000000189A5E720-0x0000000189A5E740
		private void UpdateGraphic(bool showObj = true /* Metadata: 0x00B11EA1 */) {} // 0x00000001824A8DE0-0x00000001824A93E0
		// [XID] // 0x0000000189A65EE0-0x0000000189A65F00
		public void OnDrag(PointerEventData eventData) {} // 0x00000001824A9770-0x00000001824A9870
		// [XID] // 0x0000000189A6D530-0x0000000189A6D550
		public void OnPointerDown(PointerEventData eventData) {} // 0x00000001824A9870-0x00000001824A99B0
		// [XID] // 0x0000000189A74CB0-0x0000000189A74CD0
		public void OnPointerUp(PointerEventData eventData) {} // 0x00000001824A9B10-0x00000001824A9C70
		// [XID] // 0x0000000189A7C8E0-0x0000000189A7C900
		public void OnPointerEnter(PointerEventData eventData) {} // 0x00000001824A99B0-0x00000001824A9A60
		// [XID] // 0x0000000189A84170-0x0000000189A84190
		public void OnPointerExit(PointerEventData eventData) {} // 0x00000001824A9A60-0x00000001824A9B10
		// [XID] // 0x0000000189A8BAF0-0x0000000189A8BB10
		private void WheelMoveCallback() {} // 0x00000001824A8380-0x00000001824A84D0
		// [XID] // 0x0000000189A93100-0x0000000189A93120
		private void UpdateAreaUI() {} // 0x00000001824A8C10-0x00000001824A8D30
	}
}
