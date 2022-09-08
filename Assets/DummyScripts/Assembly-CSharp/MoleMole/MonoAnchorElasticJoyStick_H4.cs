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
	public class MonoAnchorElasticJoyStick_H4 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 31181
	{
		// Fields
		public bool DebugMode; // 0x18
		public float UNIT_SIZE; // 0x1C
		private float LIMITED_LENGTH_IN_INCH; // 0x20
		private const float LIMITED_LENGTH_FACTOR = 1f; // Metadata: 0x00B11FDB
		private const float START_MOVE_MOLD_THRESHOLD = 0f; // Metadata: 0x00B11FDF
		public float DAMPING; // 0x24
		private RectTransform _parentRectTrans; // 0x28
		private bool _isPointerDown; // 0x30
		private bool _useVirtualJoyStick; // 0x31
		private bool _pointerLeaveTrigger; // 0x32
		private bool _updateAfterEnable; // 0x33
		private const int POINTER_NONE = -253; // Metadata: 0x00B11FE3
		private int _controlPointerID; // 0x34
		private Vector2 _currentScreenHitPos; // 0x38
		private Vector2 _lastScreenHitPos; // 0x40
		private bool _fixedAnchor; // 0x48
		private Vector2 _innerCurrentAnchorPos; // 0x4C
		private Vector2 _fixedAnchorPos; // 0x54
		private float FIXED_ANCHOR_POS_X; // 0x5C
		private float FIXED_ANCHOR_POS_Y; // 0x60
		private float FIXED_ANCHOR_POS_X_WIDE_SCREEN; // 0x64
		private float FIXED_ANCHOR_POS_Y_WIDE_SCREEN; // 0x68
		private static readonly Vector2 OUT_OF_SCREEN_POS; // 0x00
		private RectTransform _stickHeadTrans; // 0x70
		private RectTransform _stickTailTrans; // 0x78
		private static Vector2 ANALOG_HEAD_POS_XY; // 0x08
		public Action<bool, float, float> moveCallback; // 0x90
		private const float REF_DPI = 324f; // Metadata: 0x00B11FE7
		private float _refScreenWidth; // 0x98
		private float _refScreenHeight; // 0x9C
		private float _refScreenWidthInInch; // 0xA0
		private float _screenWidthInInch; // 0xA4
		private bool _joyInputEnabled; // 0xA8
		private bool _keepInputXMin; // 0xA9
		private bool _keepInputXMax; // 0xAA
		private bool _keepInputYMin; // 0xAB
		private bool _keepInputYMax; // 0xAC
		private RectTransform _joystickAreaWalk; // 0xB0
		private RectTransform _joystickAreaRun; // 0xB8
		private float _areaWalkRadiusRatio; // 0xC0
		private VCHumanoidMoveData _moveData; // 0xC8
	
		// Properties
		private Vector2 _currentAnchorPos { /* [XID] */ /* 0x000000018978D1E0-0x000000018978D200 */ get => default; /* [XID] */ /* 0x0000000189794550-0x0000000189794570 */ set {} } // 0x0000000184C8C990-0x0000000184C8CA50 0x0000000184C8BD90-0x0000000184C8BE40
		public bool IsFixedAnchor { /* [XID] */ /* 0x000000018979CA00-0x000000018979CA20 */ get => default; } // 0x0000000184C8DC50-0x0000000184C8DCF0 
		public bool IsMoving { /* [XID] */ /* 0x00000001897E0990-0x00000001897E09D0 */ get; /* [XID] */ /* 0x00000001897EB660-0x00000001897EB6A0 */ private set; } // 0x0000000184C8DCF0-0x0000000184C8DD50 0x0000000184C8A4F0-0x0000000184C8A560
		public float CurrentAngle { /* [XID] */ /* 0x00000001897F5D80-0x00000001897F5DC0 */ get; /* [XID] */ /* 0x0000000189800430-0x0000000189800470 */ private set; } // 0x0000000184C8DB70-0x0000000184C8DBE0 0x0000000184C8A7F0-0x0000000184C8A860
		public float CurrentMold { /* [XID] */ /* 0x000000018980AB20-0x000000018980AB60 */ get; /* [XID] */ /* 0x0000000189815130-0x0000000189815170 */ private set; } // 0x0000000184C8DBE0-0x0000000184C8DC50 0x0000000184C8A560-0x0000000184C8A5D0
		public bool JoyInputEnabled { /* [XID] */ /* 0x000000018981FD50-0x000000018981FD70 */ get => default; } // 0x0000000184C8DD50-0x0000000184C8DE00 
	
		// Constructors
		public MonoAnchorElasticJoyStick_H4() {} // 0x0000000184C8DAA0-0x0000000184C8DB70
		static MonoAnchorElasticJoyStick_H4() {} // 0x0000000184C8D9C0-0x0000000184C8DAA0
	
		// Methods
		// [XID] // 0x00000001897A3E60-0x00000001897A3E80
		public void SwitchJoyStick() {} // 0x0000000184C8D750-0x0000000184C8D800
		// [XID] // 0x00000001897AB3D0-0x00000001897AB3F0
		public void GetDefaultValueInCode(out float x, out float y, out float length, out float threshold) {
			x = default;
			y = default;
			length = default;
			threshold = default;
		} // 0x0000000184C8AF40-0x0000000184C8B070
		// [XID] // 0x00000001897B3210-0x00000001897B3230
		public void ChangeFixedAnchorX(string value) {} // 0x0000000184C8A9F0-0x0000000184C8AB60
		// [XID] // 0x00000001897BB130-0x00000001897BB150
		public void ChangeFixedAnchorY(string value) {} // 0x0000000184C8AB60-0x0000000184C8ACD0
		// [XID] // 0x00000001897C2930-0x00000001897C2950
		public void ChangeFixedAnchorLength(string value) {} // 0x0000000184C8A900-0x0000000184C8A9F0
		// [XID] // 0x00000001897CA0F0-0x00000001897CA110
		public void ChangeToWalkThreshold(string value) {} // 0x0000000184C8ACD0-0x0000000184C8AE00
		// [XID] // 0x00000001897D17D0-0x00000001897D17F0
		private Vector2 GetcurrentAnchorPos() => default; // 0x0000000184C8C8D0-0x0000000184C8C990
		// [XID] // 0x00000001897D9570-0x00000001897D9590
		private void SetCurrentAnchorPos(Vector2 pos) {} // 0x0000000184C8C2E0-0x0000000184C8C390
		// [XID] // 0x00000001898273E0-0x0000000189827400
		public void Awake() {} // 0x0000000184C8A5D0-0x0000000184C8A7F0
		// [XID] // 0x000000018982E620-0x000000018982E640
		public void Start() {} // 0x0000000184C8D370-0x0000000184C8D750
		// [XID] // 0x0000000189835FC0-0x0000000189835FE0
		public void OnEnable() {} // 0x0000000184C8CF00-0x0000000184C8CFA0
		// [XID] // 0x000000018983D4B0-0x000000018983D4D0
		private void OnDisable() {} // 0x0000000184C8CB90-0x0000000184C8CE10
		// [XID] // 0x0000000189844CF0-0x0000000189844D10
		public void Update() {} // 0x0000000184C8D8C0-0x0000000184C8D9C0
		// [XID] // 0x000000018984C0E0-0x000000018984C100
		private void DoOnActive(Vector2 hitPos) {} // 0x0000000184C8BB00-0x0000000184C8BC90
		// [XID] // 0x0000000189853230-0x0000000189853250
		private void DoOnUnactive() {} // 0x0000000184C8A860-0x0000000184C8A900
		// [XID] // 0x000000018985AD40-0x000000018985AD60
		public void TryEnableInput(bool enable) {} // 0x0000000184C8D800-0x0000000184C8D8C0
		// [XID] // 0x0000000189862200-0x0000000189862220
		private void UpdateLength() {} // 0x0000000184C8B070-0x0000000184C8B580
		// [XID] // 0x0000000189869670-0x0000000189869690
		private void UpdateGraphic() {} // 0x0000000184C8C390-0x0000000184C8C8D0
		// [XID] // 0x00000001898708B0-0x00000001898708D0
		public void OnDrag(PointerEventData eventData) {} // 0x0000000184C8CE10-0x0000000184C8CF00
		// [XID] // 0x0000000189878340-0x0000000189878360
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000184C8CFA0-0x0000000184C8D0C0
		// [XID] // 0x000000018987F810-0x000000018987F830
		public void OnPointerUp(PointerEventData eventData) {} // 0x0000000184C8D220-0x0000000184C8D370
		// [XID] // 0x0000000189886EA0-0x0000000189886EC0
		public void OnPointerEnter(PointerEventData eventData) {} // 0x0000000184C8D0C0-0x0000000184C8D170
		// [XID] // 0x000000018988DFE0-0x000000018988E000
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000184C8D170-0x0000000184C8D220
		// [XID] // 0x0000000189895680-0x00000001898956A0
		private void UpdateRealJoyStick() {} // 0x0000000184C8B580-0x0000000184C8B900
		// [XID] // 0x000000018989CDC0-0x000000018989CDE0
		private void SyncData2Controller() {} // 0x0000000184C8B900-0x0000000184C8BB00
		// [XID] // 0x00000001898A4580-0x00000001898A45A0
		private void UpdateAreaUI() {} // 0x0000000184C8BE40-0x0000000184C8C2E0
		// [XID] // 0x00000001898ABA10-0x00000001898ABA30
		public void OnAvatarChanged() {} // 0x0000000184C8CA50-0x0000000184C8CAF0
		// [XID] // 0x00000001898B31D0-0x00000001898B31F0
		private void GetMoveDataRef() {} // 0x0000000184C8AE00-0x0000000184C8AF40
		// [XID] // 0x00000001898BAF10-0x00000001898BAF30
		private void GetMoveData() {} // 0x0000000184C8BC90-0x0000000184C8BD90
		// [XID] // 0x00000001898C2240-0x00000001898C2260
		public void OnDestroy() {} // 0x0000000184C8CAF0-0x0000000184C8CB90
	}
}
