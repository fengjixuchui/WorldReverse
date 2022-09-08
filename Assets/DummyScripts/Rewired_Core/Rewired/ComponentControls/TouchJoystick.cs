/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using Rewired.Utils.Attributes;
using Rewired.Utils.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent] // 0x00000001898F1200-0x00000001898F1210
	public sealed class TouchJoystick : TouchInteractable // TypeDefIndex: 3559
	{
		// Fields
		private const float MAX_MOVE_SPEED = 20f; // Metadata: 0x00AC4001
		[CustomObfuscation] // 0x000000018981CA10-0x000000018981CA70
		[SerializeField] // 0x000000018981CA10-0x000000018981CA70
		// [Tooltip] // 0x000000018981CA10-0x000000018981CA70
		private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement; // 0x110
		[CustomObfuscation] // 0x000000018982B8E0-0x000000018982B940
		[SerializeField] // 0x000000018982B8E0-0x000000018982B940
		// [Tooltip] // 0x000000018982B8E0-0x000000018982B940
		private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement; // 0x118
		[CustomObfuscation] // 0x000000018983A310-0x000000018983A370
		[SerializeField] // 0x000000018983A310-0x000000018983A370
		// [Tooltip] // 0x000000018983A310-0x000000018983A370
		private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement; // 0x120
		[CustomObfuscation] // 0x0000000189848D40-0x0000000189848DA0
		[SerializeField] // 0x0000000189848D40-0x0000000189848DA0
		// [Tooltip] // 0x0000000189848D40-0x0000000189848DA0
		private RectTransform _stickTransform; // 0x128
		[CustomObfuscation] // 0x0000000189857830-0x0000000189857890
		[SerializeField] // 0x0000000189857830-0x0000000189857890
		// [Tooltip] // 0x0000000189857830-0x0000000189857890
		private JoystickMode _joystickMode; // 0x130
		[CustomObfuscation] // 0x0000000189866130-0x00000001898661B0
		// [Range] // 0x0000000189866130-0x00000001898661B0
		[SerializeField] // 0x0000000189866130-0x00000001898661B0
		// [Tooltip] // 0x0000000189866130-0x00000001898661B0
		private float _digitalModeDeadZone; // 0x134
		[CustomObfuscation] // 0x0000000189877FD0-0x0000000189878050
		// [Range] // 0x0000000189877FD0-0x0000000189878050
		[SerializeField] // 0x0000000189877FD0-0x0000000189878050
		// [Tooltip] // 0x0000000189877FD0-0x0000000189878050
		private float _stickRange; // 0x138
		[CustomObfuscation] // 0x0000000189889AC0-0x0000000189889B20
		[SerializeField] // 0x0000000189889AC0-0x0000000189889B20
		// [Tooltip] // 0x0000000189889AC0-0x0000000189889B20
		private bool _scaleStickRange; // 0x13C
		[CustomObfuscation] // 0x00000001898984E0-0x0000000189898540
		[SerializeField] // 0x00000001898984E0-0x0000000189898540
		// [Tooltip] // 0x00000001898984E0-0x0000000189898540
		private StickBounds _stickBounds; // 0x140
		[CustomObfuscation] // 0x00000001898A7200-0x00000001898A7260
		[SerializeField] // 0x00000001898A7200-0x00000001898A7260
		// [Tooltip] // 0x00000001898A7200-0x00000001898A7260
		private AxisDirection _axesToUse; // 0x144
		[CustomObfuscation] // 0x00000001898B6060-0x00000001898B60C0
		[SerializeField] // 0x00000001898B6060-0x00000001898B60C0
		// [Tooltip] // 0x00000001898B6060-0x00000001898B60C0
		private SnapDirections _snapDirections; // 0x148
		[CustomObfuscation] // 0x00000001898C51D0-0x00000001898C5230
		[SerializeField] // 0x00000001898C51D0-0x00000001898C5230
		// [Tooltip] // 0x00000001898C51D0-0x00000001898C5230
		private bool _snapStickToTouch; // 0x14C
		[CustomObfuscation] // 0x00000001898D4170-0x00000001898D41D0
		[SerializeField] // 0x00000001898D4170-0x00000001898D41D0
		// [Tooltip] // 0x00000001898D4170-0x00000001898D41D0
		private bool _centerStickOnRelease; // 0x14D
		[CustomObfuscation] // 0x00000001898E4D40-0x00000001898E4DA0
		[SerializeField] // 0x00000001898E4D40-0x00000001898E4DA0
		// [Tooltip] // 0x00000001898E4D40-0x00000001898E4DA0
		private StandaloneAxis2D _axis2D; // 0x150
		[CustomObfuscation] // 0x00000001898F28A0-0x00000001898F2900
		[SerializeField] // 0x00000001898F28A0-0x00000001898F2900
		// [Tooltip] // 0x00000001898F28A0-0x00000001898F2900
		private bool _activateOnSwipeIn; // 0x158
		[CustomObfuscation] // 0x0000000189901A50-0x0000000189901AB0
		[SerializeField] // 0x0000000189901A50-0x0000000189901AB0
		// [Tooltip] // 0x0000000189901A50-0x0000000189901AB0
		private bool _stayActiveOnSwipeOut; // 0x159
		[CustomObfuscation] // 0x00000001899106F0-0x0000000189910750
		[SerializeField] // 0x00000001899106F0-0x0000000189910750
		// [Tooltip] // 0x00000001899106F0-0x0000000189910750
		private bool _allowTap; // 0x15A
		[CustomObfuscation] // 0x000000018991F8E0-0x000000018991F960
		// [FieldRange] // 0x000000018991F8E0-0x000000018991F960
		[SerializeField] // 0x000000018991F8E0-0x000000018991F960
		// [Tooltip] // 0x000000018991F8E0-0x000000018991F960
		private float _tapTimeout; // 0x15C
		[CustomObfuscation] // 0x0000000189931890-0x0000000189931910
		// [FieldRange] // 0x0000000189931890-0x0000000189931910
		[SerializeField] // 0x0000000189931890-0x0000000189931910
		// [Tooltip] // 0x0000000189931890-0x0000000189931910
		private int _tapDistanceLimit; // 0x160
		[CustomObfuscation] // 0x0000000189943710-0x0000000189943770
		[SerializeField] // 0x0000000189943710-0x0000000189943770
		// [Tooltip] // 0x0000000189943710-0x0000000189943770
		private TouchRegion _touchRegion; // 0x168
		[CustomObfuscation] // 0x00000001899527C0-0x0000000189952820
		[SerializeField] // 0x00000001899527C0-0x0000000189952820
		// [Tooltip] // 0x00000001899527C0-0x0000000189952820
		private bool _useTouchRegionOnly; // 0x170
		[CustomObfuscation] // 0x0000000189961730-0x0000000189961790
		[SerializeField] // 0x0000000189961730-0x0000000189961790
		// [Tooltip] // 0x0000000189961730-0x0000000189961790
		private bool _moveToTouchPosition; // 0x171
		[CustomObfuscation] // 0x0000000189970440-0x00000001899704A0
		[SerializeField] // 0x0000000189970440-0x00000001899704A0
		// [Tooltip] // 0x0000000189970440-0x00000001899704A0
		private bool _returnOnRelease; // 0x172
		[CustomObfuscation] // 0x000000018997F300-0x000000018997F360
		[SerializeField] // 0x000000018997F300-0x000000018997F360
		// [Tooltip] // 0x000000018997F300-0x000000018997F360
		private bool _followTouchPosition; // 0x173
		[CustomObfuscation] // 0x000000018998E7C0-0x000000018998E820
		[SerializeField] // 0x000000018998E7C0-0x000000018998E820
		// [Tooltip] // 0x000000018998E7C0-0x000000018998E820
		private bool _animateOnMoveToTouch; // 0x174
		[CustomObfuscation] // 0x000000018999DDD0-0x000000018999DE50
		// [Range] // 0x000000018999DDD0-0x000000018999DE50
		[SerializeField] // 0x000000018999DDD0-0x000000018999DE50
		// [Tooltip] // 0x000000018999DDD0-0x000000018999DE50
		private float _moveToTouchSpeed; // 0x178
		[CustomObfuscation] // 0x00000001899B00C0-0x00000001899B0120
		[SerializeField] // 0x00000001899B00C0-0x00000001899B0120
		// [Tooltip] // 0x00000001899B00C0-0x00000001899B0120
		private bool _animateOnReturn; // 0x17C
		[CustomObfuscation] // 0x00000001899BEED0-0x00000001899BEF50
		// [Range] // 0x00000001899BEED0-0x00000001899BEF50
		[SerializeField] // 0x00000001899BEED0-0x00000001899BEF50
		// [Tooltip] // 0x00000001899BEED0-0x00000001899BEF50
		private float _returnSpeed; // 0x180
		[CustomObfuscation] // 0x00000001899D0F40-0x00000001899D0FA0
		[SerializeField] // 0x00000001899D0F40-0x00000001899D0FA0
		// [Tooltip] // 0x00000001899D0F40-0x00000001899D0FA0
		private bool _manageRaycasting; // 0x184
		private bool _useXAxis; // 0x185
		private bool _useYAxis; // 0x186
		private GQyqfJDHwYrVtpSHvKcqDWlbnVJ.HierarchyEventHelper<IValueChangedHandler, Vector2> _hierarchyValueChangedHandlers; // 0x188
		private GQyqfJDHwYrVtpSHvKcqDWlbnVJ.HierarchyEventHelper<IStickPositionChangedHandler, Vector2> _hierarchyStickPositionChangedHandlers; // 0x190
		private TouchRegion _workingTouchRegion; // 0x198
		private Vector2 _origAnchoredPosition; // 0x1A0
		private Vector2 _origStickAnchoredPosition; // 0x1A8
		private Vector2 _lastPressAnchoredPosition; // 0x1B0
		private bool _isMoving; // 0x1B8
		private bool _isMovedFromDefaultPosition; // 0x1B9
		private ynWUqBPMQTEMtlodYrfUADbwzmX _moveDirection; // 0x1BC
		private int _pointerId; // 0x1C0
		private int _realMousePointerId; // 0x1C4
		[NonSerialized]
		private bool jYtFWKZUVrechfzATGCgCETBhJCg; // 0x1C8
		[NonSerialized]
		private bool GXxxUMYvhnAdzwfrIpAYPjIWpue; // 0x1C9
		private bool _pointerDownIsFake; // 0x1CA
		private Vector2 _lastPressStartingValue; // 0x1CC
		private lfggsvJHPvryrXYDjukFAqXNbzH _lastClaimSource; // 0x1D4
		private float _touchStartTime; // 0x1D8
		private Vector2 _touchStartPosition; // 0x1DC
		private IEnumerator _coroutineMove; // 0x1E8
		private RXykqpoobZXbeYNAmfMakWSBJalU _imageRaycastHelper; // 0x1F0
		private int _calculatedStickRange_lastUpdatedFrame; // 0x1F8
		private int _lastTapFrame; // 0x1FC
		private bool _isEligibleForTap; // 0x200
		private float __calculatedStickRange_cachedValue; // 0x204
		private Action<ynWUqBPMQTEMtlodYrfUADbwzmX> __moveStartedDelegate; // 0x208
		private Action<ynWUqBPMQTEMtlodYrfUADbwzmX> __moveEndedDelegate; // 0x210
		[CustomObfuscation] // 0x00000001899DFA50-0x00000001899DFAB0
		[SerializeField] // 0x00000001899DFA50-0x00000001899DFAB0
		// [Tooltip] // 0x00000001899DFA50-0x00000001899DFAB0
		private ValueChangedEventHandler _onValueChanged; // 0x218
		[CustomObfuscation] // 0x00000001899EEA50-0x00000001899EEAB0
		[SerializeField] // 0x00000001899EEA50-0x00000001899EEAB0
		// [Tooltip] // 0x00000001899EEA50-0x00000001899EEAB0
		private ValueChangedEventHandler _onStickPositionChanged; // 0x220
		[CustomObfuscation] // 0x00000001899FD930-0x00000001899FD990
		[SerializeField] // 0x00000001899FD930-0x00000001899FD990
		// [Tooltip] // 0x00000001899FD930-0x00000001899FD990
		private TouchStartedEventHandler _onTouchStarted; // 0x228
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private TouchEndedEventHandler _onTouchEnded; // 0x230
		[CustomObfuscation] // 0x0000000189A169E0-0x0000000189A16A40
		[SerializeField] // 0x0000000189A169E0-0x0000000189A16A40
		// [Tooltip] // 0x0000000189A169E0-0x0000000189A16A40
		private TapEventHandler _onTap; // 0x238
		private Dictionary<int, PointerEventData> __fakePointerEventData; // 0x240
		private static GQyqfJDHwYrVtpSHvKcqDWlbnVJ.EventFunction<IValueChangedHandler, Vector2> __valueChangedHandlerDelegate; // 0x00
		private static GQyqfJDHwYrVtpSHvKcqDWlbnVJ.EventFunction<IStickPositionChangedHandler, Vector2> __stickPositionChangedHandlerDelegate; // 0x08
	
		// Properties
		public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement { get => default; } // 0x0000000186A11C30-0x0000000186A11C90 
		public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement { get => default; } // 0x0000000186A12970-0x0000000186A129D0 
		public CustomControllerElementTargetSetForBoolean tapCustomControllerElement { get => default; } // 0x0000000186A124B0-0x0000000186A12510 
		public RectTransform stickTransform { get => default; set {} } // 0x0000000186A12450-0x0000000186A124B0 0x0000000186A15EF0-0x0000000186A15FC0
		public JoystickMode joystickMode { get => default; set {} } // 0x0000000186A11C90-0x0000000186A11CF0 0x0000000186A155F0-0x0000000186A156B0
		public float digitalModeDeadZone { get => default; set {} } // 0x0000000186A119F0-0x0000000186A11A60 0x0000000186A15490-0x0000000186A15530
		public float stickRange { get => default; set {} } // 0x0000000186A123E0-0x0000000186A12450 0x0000000186A15E00-0x0000000186A15EF0
		public bool scaleStickRange { get => default; set {} } // 0x0000000186A120D0-0x0000000186A12130 0x0000000186A15AC0-0x0000000186A15B70
		private StickBounds stickBounds { get => default; set {} } // 0x0000000186A12270-0x0000000186A122D0 0x0000000186A15D40-0x0000000186A15E00
		public AxisDirection axesToUse { get => default; set {} } // 0x0000000186A11230-0x0000000186A11290 0x0000000186A15340-0x0000000186A153E0
		public SnapDirections snapDirections { get => default; set {} } // 0x0000000186A12130-0x0000000186A12190 0x0000000186A15B70-0x0000000186A15C00
		public bool snapStickToTouch { get => default; set {} } // 0x0000000186A12190-0x0000000186A121F0 0x0000000186A15C00-0x0000000186A15C90
		public bool centerStickOnRelease { get => default; set {} } // 0x0000000186A11910-0x0000000186A11970 0x0000000186A153E0-0x0000000186A15490
		public bool activateOnSwipeIn { get => default; set {} } // 0x0000000186A110B0-0x0000000186A11110 0x0000000186A15060-0x0000000186A15120
		public bool stayActiveOnSwipeOut { get => default; set {} } // 0x0000000186A121F0-0x0000000186A12270 0x0000000186A15C90-0x0000000186A15D40
		public bool allowTap { get => default; set {} } // 0x0000000186A11110-0x0000000186A11170 0x0000000186A15120-0x0000000186A151D0
		public float tapTimeout { get => default; set {} } // 0x0000000186A12570-0x0000000186A125E0 0x0000000186A16060-0x0000000186A16130
		public int tapDistanceLimit { get => default; set {} } // 0x0000000186A12510-0x0000000186A12570 0x0000000186A15FC0-0x0000000186A16060
		public TouchRegion touchRegion { get => default; set {} } // 0x0000000186A12710-0x0000000186A12770 0x0000000186A16130-0x0000000186A161F0
		public bool useTouchRegionOnly { get => default; set {} } // 0x0000000186A12770-0x0000000186A127D0 0x0000000186A161F0-0x0000000186A162A0
		public bool moveToTouchPosition { get => default; set {} } // 0x0000000186A11ED0-0x0000000186A11F30 0x0000000186A157B0-0x0000000186A15840
		public bool returnOnRelease { get => default; set {} } // 0x0000000186A12000-0x0000000186A12060 0x0000000186A15960-0x0000000186A15A10
		public bool followTouchPosition { get => default; set {} } // 0x0000000186A11AE0-0x0000000186A11B40 0x0000000186A15530-0x0000000186A155F0
		public bool animateOnMoveToTouch { get => default; set {} } // 0x0000000186A11170-0x0000000186A111D0 0x0000000186A151D0-0x0000000186A15280
		public float moveToTouchSpeed { get => default; set {} } // 0x0000000186A11F30-0x0000000186A11FA0 0x0000000186A15840-0x0000000186A158F0
		public bool animateOnReturn { get => default; set {} } // 0x0000000186A111D0-0x0000000186A11230 0x0000000186A15280-0x0000000186A15340
		public float returnSpeed { get => default; set {} } // 0x0000000186A12060-0x0000000186A120D0 0x0000000186A15A10-0x0000000186A15AC0
		public bool manageRaycasting { get => default; set {} } // 0x0000000186A11CF0-0x0000000186A11D50 0x0000000186A156B0-0x0000000186A157B0
		public AxisCalibration horizontalAxisCalibration { get => default; } // 0x0000000186A11BA0-0x0000000186A11C30 
		public AxisCalibration verticalAxisCalibration { get => default; } // 0x0000000186A128E0-0x0000000186A12970 
		[Obsolete] // 0x0000000189B4B420-0x0000000189B4B450
		public Axis2DCalibration deadZoneType { get => default; } // 0x0000000186A11970-0x0000000186A119F0 
		public Axis2DCalibration axis2DCalibration { get => default; } // 0x0000000186A11290-0x0000000186A11310 
		public int pointerId { get => default; set {} } // 0x0000000186A11FA0-0x0000000186A12000 0x0000000186A158F0-0x0000000186A15960
		public bool hasPointer { get => default; } // 0x0000000186A11B40-0x0000000186A11BA0 
		private bool tapValue { get => default; } // 0x0000000186A125E0-0x0000000186A12650 
		internal StandaloneAxis2D axis2D { get => default; } // 0x0000000186A11310-0x0000000186A11370 
		private Action<ynWUqBPMQTEMtlodYrfUADbwzmX> moveStartedDelegate { get => default; } // 0x0000000186A11E00-0x0000000186A11ED0 
		private Action<ynWUqBPMQTEMtlodYrfUADbwzmX> moveEndedDelegate { get => default; } // 0x0000000186A11D50-0x0000000186A11E00 
		private int effectivePointerId { get => default; } // 0x0000000186A11A60-0x0000000186A11AE0 
		private RectTransform touchReferenceTransform { get => default; } // 0x0000000186A12650-0x0000000186A12710 
		private float calculatedStickRange { get => default; } // 0x0000000186A11370-0x0000000186A11910 
		internal static GQyqfJDHwYrVtpSHvKcqDWlbnVJ.EventFunction<IValueChangedHandler, Vector2> valueChangedHandlerDelegate { get => default; } // 0x0000000186A127D0-0x0000000186A128E0 
		internal static GQyqfJDHwYrVtpSHvKcqDWlbnVJ.EventFunction<IStickPositionChangedHandler, Vector2> stickPositionChangedHandlerDelegate { get => default; } // 0x0000000186A122D0-0x0000000186A123E0 
	
		// Events
		public event UnityAction<Vector2> ValueChangedEvent;
		public event UnityAction<Vector2> StickPositionChangedEvent;
		public event UnityAction TouchDownEvent;
		public event UnityAction TouchUpEvent;
		public event UnityAction TapEvent;
	
		// Nested types
		public enum AxisDirection // TypeDefIndex: 3560
		{
			Both = 0,
			Horizontal = 1,
			Vertical = 2
		}
	
		public enum JoystickMode // TypeDefIndex: 3561
		{
			Analog = 0,
			Digital = 1
		}
	
		public enum SnapDirections // TypeDefIndex: 3562
		{
			None = 0,
			Four = 4,
			Eight = 8,
			Sixteen = 16,
			ThirtyTwo = 32,
			SixtyFour = 64
		}
	
		private enum ynWUqBPMQTEMtlodYrfUADbwzmX // TypeDefIndex: 3563
		{
			TCGihQKDgeeGtvEXifcuojmabzj = 0,
			euXYneYPthVhveBWhDzbgcsApkRZ = 1,
			HwWCoknLLuvDCNsHCSIjJkwLMtB = 2
		}
	
		private enum lfggsvJHPvryrXYDjukFAqXNbzH // TypeDefIndex: 3564
		{
			UMtjEaOogDDwQiplOLpTuwxTdbQ = 0,
			qBvlHFfTVaijZsMuBaXfTPCbahL = 1
		}
	
		public enum StickBounds // TypeDefIndex: 3565
		{
			Circle = 0,
			Square = 1
		}
	
		[Serializable]
		public class ValueChangedEventHandler : UnityEvent<Vector2> // TypeDefIndex: 3566
		{
			// Constructors
			public ValueChangedEventHandler() {} // 0x0000000186A1EE20-0x0000000186A1EE90
		}
	
		[Serializable]
		public class TapEventHandler : UnityEvent // TypeDefIndex: 3567
		{
			// Constructors
			public TapEventHandler() {} // 0x00000001869F8BF0-0x00000001869F8C50
		}
	
		[Serializable]
		public class TouchStartedEventHandler : UnityEvent // TypeDefIndex: 3568
		{
			// Constructors
			public TouchStartedEventHandler() {} // 0x0000000186A1EDC0-0x0000000186A1EE20
		}
	
		[Serializable]
		public class TouchEndedEventHandler : UnityEvent // TypeDefIndex: 3569
		{
			// Constructors
			public TouchEndedEventHandler() {} // 0x0000000186A041C0-0x0000000186A04220
		}
	
		public interface IValueChangedHandler // TypeDefIndex: 3570
		{
			// Methods
			void OnValueChanged(Vector2 value);
		}
	
		public interface IStickPositionChangedHandler // TypeDefIndex: 3571
		{
			// Methods
			void OnStickPositionChanged(Vector2 value);
		}
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private TouchJoystick() {} // 0x0000000186A0FF60-0x0000000186A10300
	
		// Methods
		public Vector2 GetValue() => default; // 0x0000000186A0BC00-0x0000000186A0BCB0
		public Vector2 GetRawValue() => default; // 0x0000000186A0BB50-0x0000000186A0BC00
		public void SetRawValue(Vector2 value) {} // 0x0000000186A0EE10-0x0000000186A0F190
		public void SetDefaultPosition() {} // 0x0000000186A0ED80-0x0000000186A0EE10
		private void xbYqhNfPiSuHkPeDMsDiMfQJiRv(Vector2 param_00007e32) {} // 0x0000000186A168D0-0x0000000186A16950
		public void ReturnToDefaultPosition(bool instant) {} // 0x0000000186A0E770-0x0000000186A0E860
		public void ReturnToDefaultPosition() {} // 0x0000000186A0E630-0x0000000186A0E770
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void Awake() {} // 0x0000000186A0A4D0-0x0000000186A0A6E0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnEnable() {} // 0x0000000186A0D620-0x0000000186A0D6A0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnDisable() {} // 0x0000000186A0D390-0x0000000186A0D430
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnValidate() {} // 0x0000000186A0E2A0-0x0000000186A0E350
		internal override void OnUpdate() {} // 0x0000000186A0E210-0x0000000186A0E2A0
		internal override bool OnInitialize() => default; // 0x0000000186A0D870-0x0000000186A0D900
		internal override void OnCustomControllerUpdate() {} // 0x0000000186A0D170-0x0000000186A0D390
		internal override void OnSubscribeEvents() {} // 0x0000000186A0E070-0x0000000186A0E150
		internal override void OnUnsubscribeEvents() {} // 0x0000000186A0E150-0x0000000186A0E210
		internal override void OnSetProperty() {} // 0x0000000186A0DF90-0x0000000186A0E070
		internal override void OnClear() {} // 0x0000000186A0CEC0-0x0000000186A0D170
		internal override void FindEventHandlers() {} // 0x0000000186A0B680-0x0000000186A0B860
		public override void ClearValue() {} // 0x0000000186A0A990-0x0000000186A0AB20
		internal override bool IsPressed() => default; // 0x0000000186A0C2B0-0x0000000186A0C330
		internal override bool IsThisOrTouchRegionGameObject(GameObject param_00007e34) => default; // 0x0000000186A0C330-0x0000000186A0C480
		private new void NVWqZPEZaDhGVdcEuqvABdsUKUL() {} // 0x0000000186A0CC20-0x0000000186A0CD00
		private void BpIrxrTAZovcjjJKjdrhqiRYbUtH() {} // 0x0000000186A0A850-0x0000000186A0A900
		private bool jRYzOZIJAJApqJNFeBYzaySiWHvl() => default; // 0x0000000186A129D0-0x0000000186A12A80
		private void WgGdgRGLGuNKILyWzVQUgvhaIKf(TouchRegion param_00007e35) {} // 0x0000000186A0F300-0x0000000186A0F810
		private void ScBbWfMbGgWRkVPrsqLkpPjeHhR(TouchRegion param_00007e36) {} // 0x0000000186A0E860-0x0000000186A0ED80
		private void dByKttBtodosJPFybBXLHsYfHmZw() {} // 0x0000000186A105D0-0x0000000186A106D0
		private void EngeuFiINqVonFKGMsOZSqAIstKQ(Vector2 param_00007e37, bool param_00007e38, float param_00007e39, ynWUqBPMQTEMtlodYrfUADbwzmX param_00007e3a) {} // 0x0000000186A0AB20-0x0000000186A0AEF0
		private void KXGXneOjslBgCoFxDokJHtUpHCr(Vector2 param_00007e3b, PositionType param_00007e3c, bool param_00007e3d, float param_00007e3e, ynWUqBPMQTEMtlodYrfUADbwzmX param_00007e3f) {} // 0x0000000186A0C590-0x0000000186A0CC20
		private IEnumerator YwNxjLvllECYgmvWvRLPlgYahiJ(Vector2 param_00007e40, PositionType param_00007e41, float param_00007e42, ynWUqBPMQTEMtlodYrfUADbwzmX param_00007e43) => default; // 0x0000000186A0FE40-0x0000000186A0FF60
		private void yFIryXiFmAheSzYjuuUCpBvLoYn(ynWUqBPMQTEMtlodYrfUADbwzmX param_00007e44, Vector2 param_00007e45, PositionType param_00007e46) {} // 0x0000000186A16950-0x0000000186A16AF0
		private void ebwjYhEqRdpMXwLKPVkBqUQNcEDa(ynWUqBPMQTEMtlodYrfUADbwzmX param_00007e47) {} // 0x0000000186A10E20-0x0000000186A110B0
		private void juHmsVQdOwsmtGcmTviVInzkJKk(ynWUqBPMQTEMtlodYrfUADbwzmX param_00007e48) {} // 0x0000000186A12A80-0x0000000186A12CE0
		private void CgelQMRxKcNpSeEdjHrUgepUNWaw() {} // 0x0000000186A0A900-0x0000000186A0A990
		private void dyGGqqDNKdJMvZlREoTIYHXTftYS(int param_00007e49, Vector2 param_00007e4a, PositionType param_00007e4b) {} // 0x0000000186A10820-0x0000000186A10A50
		private void GLnFKkzcjTCAOtkTuThfdBcbeFU() {} // 0x0000000186A0B860-0x0000000186A0BB50
		private void XWItRFzQtFMTnzwGXepHBSuqEaS() {} // 0x0000000186A0F810-0x0000000186A0FA00
		private void pybGhnFNCApJPQjwvJIcNrbEYgc(ref Vector2 param_00007e4c) {} // 0x0000000186A14AD0-0x0000000186A14C70
		private bool eOHzHpzQRbBLjxcuQVfnfVkaPND() => default; // 0x0000000186A10D60-0x0000000186A10E20
		private void IVWagqmpVqfBssUpPTaUIrMVFpo() {} // 0x0000000186A0C240-0x0000000186A0C2B0
		private bool xJRpUEtiZlPsigLVVURBBlekxkJ(int param_00007e4d) => default; // 0x0000000186A167D0-0x0000000186A168D0
		private PointerEventData FcNxJWJevjAfECcjXghibLdzawa(int param_00007e4e, GameObject param_00007e4f) => default; // 0x0000000186A0AEF0-0x0000000186A0B680
		private PointerEventData YQzVKdtwLwSZvgQylBxBMwuutwg(int param_00007e50, GameObject param_00007e51) => default; // 0x0000000186A0FA00-0x0000000186A0FBB0
		private PointerEventData YmNTOnqdWUarvHWIAOOUMxyMuVXg(int param_00007e52) => default; // 0x0000000186A0FBB0-0x0000000186A0FE40
		private void uhbxZnhdAiTocMkidbifwylOKNg(PointerEventData param_00007e53) {} // 0x0000000186A16440-0x0000000186A16570
		private void vKlEhocfjmbSFgtXzOsMTqmeMWoR(PointerEventData param_00007e54, lfggsvJHPvryrXYDjukFAqXNbzH param_00007e55) {} // 0x0000000186A16570-0x0000000186A16750
		private PointerEventData eHumJbgUTelnpVVEEkJoClmMzSA(int param_00007e56) => default; // 0x0000000186A10A50-0x0000000186A10D60
		private void nQRBjgHZAYAKvocDqONNTpxqTmA() {} // 0x0000000186A137C0-0x0000000186A139A0
		private void nyzmpEWTMknZYhaJEGiQjqKBXpbI(AxisDirection param_00007e57) {} // 0x0000000186A139A0-0x0000000186A13CA0
		private void RTFkZgwwfqcoraXUeOtRrGPTipR(PointerEventData param_00007e58, lfggsvJHPvryrXYDjukFAqXNbzH param_00007e59) {} // 0x0000000186A0E4A0-0x0000000186A0E630
		private void oyVgIoryHcoeYsQAABSabldnFuw(PointerEventData param_00007e5a, lfggsvJHPvryrXYDjukFAqXNbzH param_00007e5b) {} // 0x0000000186A14830-0x0000000186A14960
		private void kniQNhRGNrdKgAIpgLeavFJtBJvU(PointerEventData param_00007e5c, lfggsvJHPvryrXYDjukFAqXNbzH param_00007e5d) {} // 0x0000000186A12CE0-0x0000000186A13370
		private void AQKFYYuUyzWMUiyIguWHpBOybED(PointerEventData param_00007e5e, lfggsvJHPvryrXYDjukFAqXNbzH param_00007e5f) {} // 0x0000000186A0A2F0-0x0000000186A0A4D0
		private void JRkEqNmrQbBydBquNGteZdaKdfdJ(PointerEventData param_00007e60, lfggsvJHPvryrXYDjukFAqXNbzH param_00007e61) {} // 0x0000000186A0C480-0x0000000186A0C590
		private void oZDVbyDorizVIzkVjNvchfTADTLa(PointerEventData param_00007e62, lfggsvJHPvryrXYDjukFAqXNbzH param_00007e63) {} // 0x0000000186A14040-0x0000000186A14830
		private void qCDVnsBmJowpycpyHMQTezgiJlz(PointerEventData param_00007e64, lfggsvJHPvryrXYDjukFAqXNbzH param_00007e65) {} // 0x0000000186A14C70-0x0000000186A14D90
		private void oPbGWVlpSTmnotbhVEcMMsRAWvN(int param_00007e66, Vector2 param_00007e67, lfggsvJHPvryrXYDjukFAqXNbzH param_00007e68) {} // 0x0000000186A13CA0-0x0000000186A14040
		private void lvEXyedGHJXClGybBOaYBiVqimu() {} // 0x0000000186A13370-0x0000000186A13670
		internal override void OnPointerUp(PointerEventData eventData) {} // 0x0000000186A0DE10-0x0000000186A0DF90
		internal override void OnPointerDown(PointerEventData eventData) {} // 0x0000000186A0D900-0x0000000186A0DAD0
		internal override void OnPointerEnter(PointerEventData eventData) {} // 0x0000000186A0DAD0-0x0000000186A0DC40
		internal override void OnPointerExit(PointerEventData eventData) {} // 0x0000000186A0DC40-0x0000000186A0DE10
		internal override void OnBeginDrag(PointerEventData eventData) {} // 0x0000000186A0CD00-0x0000000186A0CEC0
		internal override void OnDrag(PointerEventData eventData) {} // 0x0000000186A0D430-0x0000000186A0D620
		internal override void OnEndDrag(PointerEventData eventData) {} // 0x0000000186A0D6A0-0x0000000186A0D870
		private void WIePpjCcsUBMIhAWGtGpDSlJlip(PointerEventData param_00007e70) {} // 0x0000000186A0F190-0x0000000186A0F300
		private void pEabpejZnFXyFYVtSEnxCGboYRd(PointerEventData param_00007e71) {} // 0x0000000186A14960-0x0000000186A14AD0
		private void dcgoqSOZQngElokwIQkKjPdIlML(PointerEventData param_00007e72) {} // 0x0000000186A106D0-0x0000000186A10820
		private void mErQunVxoylvoyoLVaOLThnRYfr(PointerEventData param_00007e73) {} // 0x0000000186A13670-0x0000000186A137C0
		private void tSprHwabWAeayCELWdqRtWpZHTy(PointerEventData param_00007e74) {} // 0x0000000186A162A0-0x0000000186A16440
		private void BTVEajulvNaTWgPgwHHzcBOiDqbm(PointerEventData param_00007e75) {} // 0x0000000186A0A6E0-0x0000000186A0A850
		private void QtHeMsbLBSdgMrevetMzBIueeeSv(PointerEventData param_00007e76) {} // 0x0000000186A0E350-0x0000000186A0E4A0
		private void HWFhkFlLkYUKyhTUFbGsyGCYFc(Vector2 param_00007e77) {} // 0x0000000186A0BCB0-0x0000000186A0C240
	}
}
