/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001897C3E70-0x00000001897C3EE0
	// [RequireComponent] // 0x00000001897C3E70-0x00000001897C3EE0
	public sealed class TouchPad : TouchInteractable, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 3585
	{
		// Fields
		private const int SMOOTH_DELTA_FRAME_COUNT = 3; // Metadata: 0x00AC406D
		[CustomObfuscation] // 0x00000001897D3010-0x00000001897D3070
		[SerializeField] // 0x00000001897D3010-0x00000001897D3070
		// [Tooltip] // 0x00000001897D3010-0x00000001897D3070
		private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement; // 0x110
		[CustomObfuscation] // 0x00000001897E2170-0x00000001897E21D0
		[SerializeField] // 0x00000001897E2170-0x00000001897E21D0
		// [Tooltip] // 0x00000001897E2170-0x00000001897E21D0
		private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement; // 0x118
		[CustomObfuscation] // 0x00000001897F16F0-0x00000001897F1750
		[SerializeField] // 0x00000001897F16F0-0x00000001897F1750
		// [Tooltip] // 0x00000001897F16F0-0x00000001897F1750
		private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement; // 0x120
		[CustomObfuscation] // 0x0000000189800340-0x00000001898003A0
		[SerializeField] // 0x0000000189800340-0x00000001898003A0
		// [Tooltip] // 0x0000000189800340-0x00000001898003A0
		private CustomControllerElementTargetSetForBoolean _pressCustomControllerElement; // 0x128
		[CustomObfuscation] // 0x000000018980F110-0x000000018980F170
		[SerializeField] // 0x000000018980F110-0x000000018980F170
		// [Tooltip] // 0x000000018980F110-0x000000018980F170
		private AxisDirection _axesToUse; // 0x130
		[CustomObfuscation] // 0x000000018981C9B0-0x000000018981CA10
		[SerializeField] // 0x000000018981C9B0-0x000000018981CA10
		// [Tooltip] // 0x000000018981C9B0-0x000000018981CA10
		private TouchPadMode _touchPadMode; // 0x134
		[CustomObfuscation] // 0x000000018982B880-0x000000018982B8E0
		[SerializeField] // 0x000000018982B880-0x000000018982B8E0
		// [Tooltip] // 0x000000018982B880-0x000000018982B8E0
		private ValueFormat _valueFormat; // 0x138
		[CustomObfuscation] // 0x000000018983A2B0-0x000000018983A310
		[SerializeField] // 0x000000018983A2B0-0x000000018983A310
		// [Tooltip] // 0x000000018983A2B0-0x000000018983A310
		private bool _useInertia; // 0x13C
		[CustomObfuscation] // 0x0000000189848CC0-0x0000000189848D40
		// [FieldRange] // 0x0000000189848CC0-0x0000000189848D40
		[SerializeField] // 0x0000000189848CC0-0x0000000189848D40
		// [Tooltip] // 0x0000000189848CC0-0x0000000189848D40
		private float _inertiaFriction; // 0x140
		[CustomObfuscation] // 0x000000018985AB80-0x000000018985ABE0
		[SerializeField] // 0x000000018985AB80-0x000000018985ABE0
		// [Tooltip] // 0x000000018985AB80-0x000000018985ABE0
		private bool _activateOnSwipeIn; // 0x144
		[CustomObfuscation] // 0x00000001898694A0-0x0000000189869500
		[SerializeField] // 0x00000001898694A0-0x0000000189869500
		// [Tooltip] // 0x00000001898694A0-0x0000000189869500
		private bool _stayActiveOnSwipeOut; // 0x145
		[CustomObfuscation] // 0x0000000189877F70-0x0000000189877FD0
		[SerializeField] // 0x0000000189877F70-0x0000000189877FD0
		// [Tooltip] // 0x0000000189877F70-0x0000000189877FD0
		private bool _allowTap; // 0x146
		[CustomObfuscation] // 0x0000000189885570-0x00000001898855F0
		// [FieldRange] // 0x0000000189885570-0x00000001898855F0
		[SerializeField] // 0x0000000189885570-0x00000001898855F0
		// [Tooltip] // 0x0000000189885570-0x00000001898855F0
		private float _tapTimeout; // 0x148
		[CustomObfuscation] // 0x00000001898954A0-0x0000000189895520
		// [FieldRange] // 0x00000001898954A0-0x0000000189895520
		[SerializeField] // 0x00000001898954A0-0x0000000189895520
		// [Tooltip] // 0x00000001898954A0-0x0000000189895520
		private int _tapDistanceLimit; // 0x14C
		[CustomObfuscation] // 0x00000001898A5D50-0x00000001898A5DB0
		[SerializeField] // 0x00000001898A5D50-0x00000001898A5DB0
		// [Tooltip] // 0x00000001898A5D50-0x00000001898A5DB0
		private bool _allowPress; // 0x150
		[CustomObfuscation] // 0x00000001898B4710-0x00000001898B4770
		[SerializeField] // 0x00000001898B4710-0x00000001898B4770
		// [Tooltip] // 0x00000001898B4710-0x00000001898B4770
		private float _pressStartDelay; // 0x154
		[CustomObfuscation] // 0x00000001898C38A0-0x00000001898C3920
		// [FieldRange] // 0x00000001898C38A0-0x00000001898C3920
		[SerializeField] // 0x00000001898C38A0-0x00000001898C3920
		// [Tooltip] // 0x00000001898C38A0-0x00000001898C3920
		private int _pressDistanceLimit; // 0x158
		[CustomObfuscation] // 0x00000001898D58A0-0x00000001898D5900
		[SerializeField] // 0x00000001898D58A0-0x00000001898D5900
		// [Tooltip] // 0x00000001898D58A0-0x00000001898D5900
		private bool _hideAtRuntime; // 0x15C
		[CustomObfuscation] // 0x00000001898E4D40-0x00000001898E4DA0
		[SerializeField] // 0x00000001898E4D40-0x00000001898E4DA0
		// [Tooltip] // 0x00000001898E4D40-0x00000001898E4DA0
		private StandaloneAxis2D _axis2D; // 0x160
		[CustomObfuscation] // 0x00000001898F2840-0x00000001898F28A0
		[SerializeField] // 0x00000001898F2840-0x00000001898F28A0
		// [Tooltip] // 0x00000001898F2840-0x00000001898F28A0
		private ValueChangedEventHandler _onValueChanged; // 0x168
		[CustomObfuscation] // 0x0000000189A169E0-0x0000000189A16A40
		[SerializeField] // 0x0000000189A169E0-0x0000000189A16A40
		// [Tooltip] // 0x0000000189A169E0-0x0000000189A16A40
		private TapEventHandler _onTap; // 0x170
		[CustomObfuscation] // 0x000000018990F3A0-0x000000018990F400
		[SerializeField] // 0x000000018990F3A0-0x000000018990F400
		// [Tooltip] // 0x000000018990F3A0-0x000000018990F400
		private PressDownEventHandler _onPressDown; // 0x178
		[CustomObfuscation] // 0x000000018991E3A0-0x000000018991E400
		[SerializeField] // 0x000000018991E3A0-0x000000018991E400
		// [Tooltip] // 0x000000018991E3A0-0x000000018991E400
		private PressUpEventHandler _onPressUp; // 0x180
		private bool _useXAxis; // 0x188
		private bool _useYAxis; // 0x189
		private int _pointerId; // 0x18C
		private int _realMousePointerId; // 0x190
		[NonSerialized]
		private bool jYtFWKZUVrechfzATGCgCETBhJCg; // 0x194
		[NonSerialized]
		private bool GXxxUMYvhnAdzwfrIpAYPjIWpue; // 0x195
		private bool _pointerDownIsFake; // 0x196
		private Vector2 _touchStartPosition; // 0x198
		private float _touchStartTime; // 0x1A0
		private Vector3 _currentCenter; // 0x1A4
		private Vector2 _previousTouchPosition; // 0x1B0
		private int _lastTapFrame; // 0x1B8
		private bool _isEligibleForTap; // 0x1BC
		private bool _isEligibleForPress; // 0x1BD
		private bool _pressValue; // 0x1BE
		private nJXHASFXyGjqTJOiSWRFjOLpOSo _smoothDelta; // 0x1C0
		private Dictionary<int, PointerEventData> __fakePointerEventData; // 0x1C8
	
		// Properties
		public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement { get => default; } // 0x0000000186A1AE60-0x0000000186A1AEC0 
		public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement { get => default; } // 0x0000000186A1B6B0-0x0000000186A1B710 
		public CustomControllerElementTargetSetForBoolean tapCustomControllerElement { get => default; } // 0x0000000186A1B120-0x0000000186A1B180 
		public CustomControllerElementTargetSetForBoolean pressCustomControllerElement { get => default; } // 0x0000000186A1AF90-0x0000000186A1AFF0 
		public AxisDirection axesToUse { get => default; set {} } // 0x0000000186A1AB50-0x0000000186A1ABB0 0x0000000186A1CAA0-0x0000000186A1CB60
		public TouchPadMode touchPadMode { get => default; set {} } // 0x0000000186A1B2C0-0x0000000186A1B320 0x0000000186A1D0D0-0x0000000186A1D160
		public ValueFormat valueFormat { get => default; set {} } // 0x0000000186A1B5C0-0x0000000186A1B620 0x0000000186A1D1F0-0x0000000186A1D280
		public bool useInertia { get => default; set {} } // 0x0000000186A1B560-0x0000000186A1B5C0 0x0000000186A1D160-0x0000000186A1D1F0
		public float inertiaFriction { get => default; set {} } // 0x0000000186A1AEC0-0x0000000186A1AF30 0x0000000186A1CBF0-0x0000000186A1CCD0
		public bool activateOnSwipeIn { get => default; set {} } // 0x0000000186A1AA30-0x0000000186A1AA90 0x0000000186A1C8B0-0x0000000186A1C960
		public bool stayActiveOnSwipeOut { get => default; set {} } // 0x0000000186A1B0C0-0x0000000186A1B120 0x0000000186A1CEC0-0x0000000186A1CF70
		public bool allowTap { get => default; set {} } // 0x0000000186A1AAF0-0x0000000186A1AB50 0x0000000186A1C9F0-0x0000000186A1CAA0
		public float tapTimeout { get => default; set {} } // 0x0000000186A1B1E0-0x0000000186A1B250 0x0000000186A1D010-0x0000000186A1D0D0
		public int tapDistanceLimit { get => default; set {} } // 0x0000000186A1B180-0x0000000186A1B1E0 0x0000000186A1CF70-0x0000000186A1D010
		public bool allowPress { get => default; set {} } // 0x0000000186A1AA90-0x0000000186A1AAF0 0x0000000186A1C960-0x0000000186A1C9F0
		public float pressStartDelay { get => default; set {} } // 0x0000000186A1B050-0x0000000186A1B0C0 0x0000000186A1CE00-0x0000000186A1CEC0
		public int pressDistanceLimit { get => default; set {} } // 0x0000000186A1AFF0-0x0000000186A1B050 0x0000000186A1CD40-0x0000000186A1CE00
		public bool hideAtRuntime { get => default; set {} } // 0x0000000186A1AD70-0x0000000186A1ADD0 0x0000000186A1CB60-0x0000000186A1CBF0
		public int pointerId { get => default; set {} } // 0x0000000186A1AF30-0x0000000186A1AF90 0x0000000186A1CCD0-0x0000000186A1CD40
		public bool hasPointer { get => default; } // 0x0000000186A1AD10-0x0000000186A1AD70 
		public Vector2 touchStartPosition { get => default; } // 0x0000000186A1B470-0x0000000186A1B560 
		public Vector2 touchPosition { get => default; } // 0x0000000186A1B320-0x0000000186A1B470 
		public AxisCalibration horizontalAxisCalibration { get => default; } // 0x0000000186A1ADD0-0x0000000186A1AE60 
		public AxisCalibration verticalAxisCalibration { get => default; } // 0x0000000186A1B620-0x0000000186A1B6B0 
		public Axis2DCalibration axis2DCalibration { get => default; } // 0x0000000186A1ABB0-0x0000000186A1AC30 
		internal StandaloneAxis2D axis2D { get => default; } // 0x0000000186A1AC30-0x0000000186A1AC90 
		private int effectivePointerId { get => default; } // 0x0000000186A1AC90-0x0000000186A1AD10 
		private bool tapValue { get => default; } // 0x0000000186A1B250-0x0000000186A1B2C0 
	
		// Events
		public event UnityAction<Vector2> ValueChangedEvent;
		public event UnityAction TapEvent;
		public event UnityAction PressDownEvent;
		public event UnityAction PressUpEvent;
	
		// Nested types
		public enum AxisDirection // TypeDefIndex: 3586
		{
			Both = 0,
			Horizontal = 1,
			Vertical = 2
		}
	
		public enum TouchPadMode // TypeDefIndex: 3587
		{
			Delta = 0,
			ScreenPosition = 1,
			VectorFromCenter = 2,
			VectorFromInitialTouch = 3
		}
	
		public enum ValueFormat // TypeDefIndex: 3588
		{
			Pixels = 0,
			Screen = 1,
			Physical = 2,
			Direction = 3
		}
	
		private class nJXHASFXyGjqTJOiSWRFjOLpOSo // TypeDefIndex: 3589
		{
			// Fields
			private int gYHtosHYzHfFmYMxezlLLEvIBsB; // 0x10
			private EKHjVEExXICPrxCGQroCXCPcuBp[] PvbfvGDQstrrExqmLGQWIcGWljDB; // 0x18
			private int RMmuzLwPyyqjZzFkavzjXDLDVyZ; // 0x20
	
			// Nested types
			private class EKHjVEExXICPrxCGQroCXCPcuBp // TypeDefIndex: 3590
			{
				// Fields
				public float tZfhkeNLltBUGrNOBGFtCGTpEgF; // 0x10
				public float NSawOevekNbKdEGYiDwRoEKHtBBh; // 0x14
				public uint guebJEeuIIBmQDaVIDUbCtSyEDzN; // 0x18
	
				// Constructors
				public EKHjVEExXICPrxCGQroCXCPcuBp() {} // 0x00000001869F8270-0x00000001869F82D0
			}
	
			// Constructors
			public nJXHASFXyGjqTJOiSWRFjOLpOSo() {} // Dummy constructor
			public nJXHASFXyGjqTJOiSWRFjOLpOSo(int maxSmoothFrames) {} // 0x0000000186A1F560-0x0000000186A1F650
	
			// Methods
			public void MPPQJfVkqEnvckKDMacDSmlvhjwB(float param_00007f1a, float param_00007f1b) {} // 0x0000000186A1F050-0x0000000186A1F1A0
			public Vector2 QJaTdhLNVZgOntuRiKaZnMxHFoN() => default; // 0x0000000186A1F1A0-0x0000000186A1F4B0
			private void QfVyzdRKbRAEBqKPLZqCbPglAMc() {} // 0x0000000186A1F4B0-0x0000000186A1F560
			private static int epZfuqvEtgOGWyFTyGgBkCrrGtsd(int param_00007f1c, int param_00007f1d) => default; // 0x0000000186A1F650-0x0000000186A1F6C0
			private int LwQmlBTBIntRAFTRXedrATdkaHG(int param_00007f1e, int param_00007f1f) => default; // 0x0000000186A1EFE0-0x0000000186A1F050
			private static bool HBqSffsIMZIRsFqSMCXDLOqJGdJH(uint param_00007f20, uint param_00007f21) => default; // 0x0000000186A1EF70-0x0000000186A1EFE0
		}
	
		[Serializable]
		public class ValueChangedEventHandler : UnityEvent<Vector2> // TypeDefIndex: 3591
		{
			// Constructors
			public ValueChangedEventHandler() {} // 0x0000000186A1EE90-0x0000000186A1EF00
		}
	
		[Serializable]
		public class TapEventHandler : UnityEvent // TypeDefIndex: 3592
		{
			// Constructors
			public TapEventHandler() {} // 0x00000001869F8C50-0x00000001869F8CB0
		}
	
		[Serializable]
		public class PressDownEventHandler : UnityEvent // TypeDefIndex: 3593
		{
			// Constructors
			public PressDownEventHandler() {} // 0x00000001869F8B30-0x00000001869F8B90
		}
	
		[Serializable]
		public class PressUpEventHandler : UnityEvent // TypeDefIndex: 3594
		{
			// Constructors
			public PressUpEventHandler() {} // 0x00000001869F8B90-0x00000001869F8BF0
		}
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private TouchPad() {} // 0x0000000186A1A0C0-0x0000000186A1A3E0
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void Awake() {} // 0x0000000186A16D00-0x0000000186A16DB0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnValidate() {} // 0x0000000186A18A10-0x0000000186A18AC0
		internal override bool OnInitialize() => default; // 0x0000000186A18290-0x0000000186A18310
		internal override void OnUpdate() {} // 0x0000000186A18950-0x0000000186A18A10
		internal override void OnCustomControllerUpdate() {} // 0x0000000186A17F90-0x0000000186A18290
		internal override void OnSetProperty() {} // 0x0000000186A18830-0x0000000186A18950
		internal override void OnClear() {} // 0x0000000186A17DF0-0x0000000186A17F90
		public override void ClearValue() {} // 0x0000000186A16DB0-0x0000000186A16F20
		private new void NVWqZPEZaDhGVdcEuqvABdsUKUL() {} // 0x0000000186A179A0-0x0000000186A17A80
		private void nQRBjgHZAYAKvocDqONNTpxqTmA() {} // 0x0000000186A1BE10-0x0000000186A1C070
		private void nyzmpEWTMknZYhaJEGiQjqKBXpbI(AxisDirection param_00007f02) {} // 0x0000000186A1C070-0x0000000186A1C230
		private void GLnFKkzcjTCAOtkTuThfdBcbeFU() {} // 0x0000000186A17760-0x0000000186A17930
		private void RaIuFmAMDXfdJjzOssKFhHpZxTs() {} // 0x0000000186A18F20-0x0000000186A19520
		private void UEQoSZqysCkXaofqKejXiFbupQQr() {} // 0x0000000186A19520-0x0000000186A197F0
		private void XWItRFzQtFMTnzwGXepHBSuqEaS() {} // 0x0000000186A19A30-0x0000000186A19C20
		private void pybGhnFNCApJPQjwvJIcNrbEYgc(ref Vector2 param_00007f03) {} // 0x0000000186A1C4C0-0x0000000186A1C670
		private void OhtZoNObgfifckfabmHWHssTvvb(ref Vector2 param_00007f04) {} // 0x0000000186A17A80-0x0000000186A17DF0
		private void PeasfOPFFKtMOzEgnsHBtRnzgbX() {} // 0x0000000186A18AC0-0x0000000186A18D70
		private Vector2 VMYdubkIOGMyJmruGrZwILSCIcw(Vector2 param_00007f05) => default; // 0x0000000186A197F0-0x0000000186A19A30
		private void bajrseiglAhYaEaLDuLcUsmOMPb(bool param_00007f06) {} // 0x0000000186A1A620-0x0000000186A1A730
		private void RTFkZgwwfqcoraXUeOtRrGPTipR(PointerEventData param_00007f07) {} // 0x0000000186A18D70-0x0000000186A18F20
		private void oyVgIoryHcoeYsQAABSabldnFuw(PointerEventData param_00007f08) {} // 0x0000000186A1C380-0x0000000186A1C4C0
		private void kniQNhRGNrdKgAIpgLeavFJtBJvU(PointerEventData param_00007f09) {} // 0x0000000186A1B710-0x0000000186A1BB50
		private void AQKFYYuUyzWMUiyIguWHpBOybED(PointerEventData param_00007f0a) {} // 0x0000000186A16B70-0x0000000186A16D00
		private void oPbGWVlpSTmnotbhVEcMMsRAWvN(int param_00007f0b, Vector2 param_00007f0c) {} // 0x0000000186A1C230-0x0000000186A1C380
		private void lvEXyedGHJXClGybBOaYBiVqimu() {} // 0x0000000186A1BB50-0x0000000186A1BE10
		internal override void OnPointerUp(PointerEventData eventData) {} // 0x0000000186A186D0-0x0000000186A18830
		internal override void OnPointerDown(PointerEventData eventData) {} // 0x0000000186A18310-0x0000000186A18440
		internal override void OnPointerEnter(PointerEventData eventData) {} // 0x0000000186A18440-0x0000000186A185A0
		internal override void OnPointerExit(PointerEventData eventData) {} // 0x0000000186A185A0-0x0000000186A186D0
		private void IVWagqmpVqfBssUpPTaUIrMVFpo() {} // 0x0000000186A17930-0x0000000186A179A0
		private bool xJRpUEtiZlPsigLVVURBBlekxkJ(int param_00007f11) => default; // 0x0000000186A1D320-0x0000000186A1D400
		private PointerEventData FcNxJWJevjAfECcjXghibLdzawa(int param_00007f12, GameObject param_00007f13) => default; // 0x0000000186A16F20-0x0000000186A17760
		private PointerEventData YQzVKdtwLwSZvgQylBxBMwuutwg(int param_00007f14, GameObject param_00007f15) => default; // 0x0000000186A19C20-0x0000000186A19DB0
		private PointerEventData YmNTOnqdWUarvHWIAOOUMxyMuVXg(int param_00007f16) => default; // 0x0000000186A19DB0-0x0000000186A1A0C0
		private void uhbxZnhdAiTocMkidbifwylOKNg(PointerEventData param_00007f17) {} // 0x0000000186A1D280-0x0000000186A1D320
		private PointerEventData eHumJbgUTelnpVVEEkJoClmMzSA(int param_00007f18) => default; // 0x0000000186A1A730-0x0000000186A1AA30
	}
}
