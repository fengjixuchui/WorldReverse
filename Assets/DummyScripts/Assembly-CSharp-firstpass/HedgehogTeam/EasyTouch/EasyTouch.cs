/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace HedgehogTeam.EasyTouch
{
	public class EasyTouch : MonoBehaviour // TypeDefIndex: 7292
	{
		// Fields
		private static EasyTouch _instance; // 0x138
		private Gesture _currentGesture; // 0x18
		private List<Gesture> _currentGestures; // 0x20
		public bool enable; // 0x28
		public bool enableRemote; // 0x29
		public GesturePriority gesturePriority; // 0x2C
		public float StationaryTolerance; // 0x30
		public float longTapTime; // 0x34
		public float swipeTolerance; // 0x38
		public float minPinchLength; // 0x3C
		public float minTwistAngle; // 0x40
		public DoubleTapDetection doubleTapDetection; // 0x44
		public float doubleTapTime; // 0x48
		public bool alwaysSendSwipe; // 0x4C
		public bool enable2FingersGesture; // 0x4D
		public bool enableTwist; // 0x4E
		public bool enablePinch; // 0x4F
		public bool enable2FingersSwipe; // 0x50
		public TwoFingerPickMethod twoFingerPickMethod; // 0x54
		public List<ECamera> touchCameras; // 0x58
		public bool autoSelect; // 0x60
		public LayerMask pickableLayers3D; // 0x64
		public bool enable2D; // 0x68
		public LayerMask pickableLayers2D; // 0x6C
		public bool autoUpdatePickedObject; // 0x70
		public bool allowUIDetection; // 0x71
		public bool enableUIMode; // 0x72
		public bool autoUpdatePickedUI; // 0x73
		public bool enableUpdatePickedUI; // 0x74
		public bool enabledNGuiMode; // 0x75
		public LayerMask nGUILayers; // 0x78
		public List<Camera> nGUICameras; // 0x80
		public bool enableSimulation; // 0x88
		public KeyCode twistKey; // 0x8C
		public KeyCode swipeKey; // 0x90
		public bool showGuiInspector; // 0x94
		public bool showSelectInspector; // 0x95
		public bool showGestureInspector; // 0x96
		public bool showTwoFingerInspector; // 0x97
		public bool showSecondFingerInspector; // 0x98
		private EasyTouchInput input; // 0xA0
		private Finger[] fingers; // 0xA8
		public Texture secondFingerTexture; // 0xB0
		private TwoFingerGesture twoFinger; // 0xB8
		private int oldTouchCount; // 0xC0
		private DoubleTap[] singleDoubleTap; // 0xC8
		private Finger[] tmpArray; // 0xD0
		private PickedObject pickedObject; // 0xD8
		private List<RaycastResult> uiRaycastResultCache; // 0xE0
		private PointerEventData uiPointerEventData; // 0xE8
		private EventSystem uiEventSystem; // 0xF0
		private static bool _isSkipFitst; // 0x140
		private static HashSet<int> _skipSet; // 0x148
		public int notOverGUIFingerCount; // 0xF8
	
		// Properties
		public static EasyTouch instance { /* [XID] */ /* 0x00000001899F79D0-0x00000001899F79F0 */ get => default; } // 0x0000000185A32080-0x0000000185A32330 
		public static Gesture current { /* [XID] */ /* 0x00000001899FF070-0x00000001899FF090 */ get => default; } // 0x0000000185A31FB0-0x0000000185A32080 
		public static bool isSkipFitst { /* [XID] */ /* 0x0000000189A06930-0x0000000189A06950 */ get => default; /* [XID] */ /* 0x0000000189A0DF40-0x0000000189A0DF60 */ set {} } // 0x0000000185A32330-0x0000000185A32400 0x0000000185A359A0-0x0000000185A35A70
	
		// Events
		public static event TouchCancelHandler On_Cancel;
		public static event Cancel2FingersHandler On_Cancel2Fingers;
		public static event TouchStartHandler On_TouchStart;
		public static event TouchDownHandler On_TouchDown;
		public static event TouchUpHandler On_TouchUp;
		public static event SimpleTapHandler On_SimpleTap;
		public static event DoubleTapHandler On_DoubleTap;
		public static event LongTapStartHandler On_LongTapStart;
		public static event LongTapHandler On_LongTap;
		public static event LongTapEndHandler On_LongTapEnd;
		public static event DragStartHandler On_DragStart;
		public static event DragHandler On_Drag;
		public static event DragEndHandler On_DragEnd;
		public static event SwipeStartHandler On_SwipeStart;
		public static event SwipeHandler On_Swipe;
		public static event SwipeEndHandler On_SwipeEnd;
		public static event TouchStart2FingersHandler On_TouchStart2Fingers;
		public static event TouchDown2FingersHandler On_TouchDown2Fingers;
		public static event TouchUp2FingersHandler On_TouchUp2Fingers;
		public static event SimpleTap2FingersHandler On_SimpleTap2Fingers;
		public static event DoubleTap2FingersHandler On_DoubleTap2Fingers;
		public static event LongTapStart2FingersHandler On_LongTapStart2Fingers;
		public static event LongTap2FingersHandler On_LongTap2Fingers;
		public static event LongTapEnd2FingersHandler On_LongTapEnd2Fingers;
		public static event TwistHandler On_Twist;
		public static event TwistEndHandler On_TwistEnd;
		public static event PinchHandler On_Pinch;
		public static event PinchInHandler On_PinchIn;
		public static event PinchOutHandler On_PinchOut;
		public static event PinchEndHandler On_PinchEnd;
		public static event DragStart2FingersHandler On_DragStart2Fingers;
		public static event Drag2FingersHandler On_Drag2Fingers;
		public static event DragEnd2FingersHandler On_DragEnd2Fingers;
		public static event SwipeStart2FingersHandler On_SwipeStart2Fingers;
		public static event Swipe2FingersHandler On_Swipe2Fingers;
		public static event SwipeEnd2FingersHandler On_SwipeEnd2Fingers;
		public static event EasyTouchIsReadyHandler On_EasyTouchIsReady;
		public static event OverUIElementHandler On_OverUIElement;
		public static event UIElementTouchUpHandler On_UIElementTouchUp;
	
		// Nested types
		[Serializable]
		private class DoubleTap // TypeDefIndex: 7293
		{
			// Fields
			public bool inDoubleTap; // 0x10
			public bool inWait; // 0x11
			public float time; // 0x14
			public int count; // 0x18
			public Finger finger; // 0x20
	
			// Constructors
			public DoubleTap() {} // 0x0000000180B2BA80-0x0000000180B2BAF0
	
			// Methods
			// [XID] // 0x00000001896C9E40-0x00000001896C9E60
			public void Stop() {} // 0x0000000180B2B9D0-0x0000000180B2BA80
		}
	
		private class PickedObject // TypeDefIndex: 7294
		{
			// Fields
			public GameObject pickedObj; // 0x10
			public Camera pickedCamera; // 0x18
			public bool isGUI; // 0x20
	
			// Constructors
			public PickedObject() {} // 0x0000000180C9AE00-0x0000000180C9AE60
		}
	
		public delegate void TouchCancelHandler(Gesture gesture); // TypeDefIndex: 7295; 0x0000000180CA5300-0x0000000180CA5560
	
		public delegate void Cancel2FingersHandler(Gesture gesture); // TypeDefIndex: 7296; 0x0000000180B2AF10-0x0000000180B2B170
	
		public delegate void TouchStartHandler(Gesture gesture); // TypeDefIndex: 7297; 0x0000000180CA62C0-0x0000000180CA6520
	
		public delegate void TouchDownHandler(Gesture gesture); // TypeDefIndex: 7298; 0x0000000180CA5AE0-0x0000000180CA5D40
	
		public delegate void TouchUpHandler(Gesture gesture); // TypeDefIndex: 7299; 0x0000000180CA6AA0-0x0000000180CA6D00
	
		public delegate void SimpleTapHandler(Gesture gesture); // TypeDefIndex: 7300; 0x0000000180CA3770-0x0000000180CA39D0
	
		public delegate void DoubleTapHandler(Gesture gesture); // TypeDefIndex: 7301; 0x0000000180B2B6F0-0x0000000180B2B950
	
		public delegate void LongTapStartHandler(Gesture gesture); // TypeDefIndex: 7302; 0x0000000180C9A180-0x0000000180C9A3E0
	
		public delegate void LongTapHandler(Gesture gesture); // TypeDefIndex: 7303; 0x0000000180C999A0-0x0000000180C99C00
	
		public delegate void LongTapEndHandler(Gesture gesture); // TypeDefIndex: 7304; 0x0000000180C995B0-0x0000000180C99810
	
		public delegate void DragStartHandler(Gesture gesture); // TypeDefIndex: 7305; 0x0000000180B2CFB0-0x0000000180B2D210
	
		public delegate void DragHandler(Gesture gesture); // TypeDefIndex: 7306; 0x0000000180B2C7D0-0x0000000180B2CA30
	
		public delegate void DragEndHandler(Gesture gesture); // TypeDefIndex: 7307; 0x0000000180B2C3E0-0x0000000180B2C640
	
		public delegate void SwipeStartHandler(Gesture gesture); // TypeDefIndex: 7308; 0x0000000180CA4F10-0x0000000180CA5170
	
		public delegate void SwipeHandler(Gesture gesture); // TypeDefIndex: 7309; 0x0000000180CA4730-0x0000000180CA4990
	
		public delegate void SwipeEndHandler(Gesture gesture); // TypeDefIndex: 7310; 0x0000000180CA4340-0x0000000180CA45A0
	
		public delegate void TouchStart2FingersHandler(Gesture gesture); // TypeDefIndex: 7311; 0x0000000180CA5ED0-0x0000000180CA6130
	
		public delegate void TouchDown2FingersHandler(Gesture gesture); // TypeDefIndex: 7312; 0x0000000180CA56F0-0x0000000180CA5950
	
		public delegate void TouchUp2FingersHandler(Gesture gesture); // TypeDefIndex: 7313; 0x0000000180CA66B0-0x0000000180CA6910
	
		public delegate void SimpleTap2FingersHandler(Gesture gesture); // TypeDefIndex: 7314; 0x0000000180CA3380-0x0000000180CA35E0
	
		public delegate void DoubleTap2FingersHandler(Gesture gesture); // TypeDefIndex: 7315; 0x0000000180B2B300-0x0000000180B2B560
	
		public delegate void LongTapStart2FingersHandler(Gesture gesture); // TypeDefIndex: 7316; 0x0000000180C99D90-0x0000000180C99FF0
	
		public delegate void LongTap2FingersHandler(Gesture gesture); // TypeDefIndex: 7317; 0x0000000180C98DD0-0x0000000180C99030
	
		public delegate void LongTapEnd2FingersHandler(Gesture gesture); // TypeDefIndex: 7318; 0x0000000180C991C0-0x0000000180C99420
	
		public delegate void TwistHandler(Gesture gesture); // TypeDefIndex: 7319; 0x0000000180CA7280-0x0000000180CA74E0
	
		public delegate void TwistEndHandler(Gesture gesture); // TypeDefIndex: 7320; 0x0000000180CA6E90-0x0000000180CA70F0
	
		public delegate void PinchInHandler(Gesture gesture); // TypeDefIndex: 7321; 0x0000000180C9B750-0x0000000180C9B9B0
	
		public delegate void PinchOutHandler(Gesture gesture); // TypeDefIndex: 7322; 0x0000000180C9BB40-0x0000000180C9BDA0
	
		public delegate void PinchEndHandler(Gesture gesture); // TypeDefIndex: 7323; 0x0000000180C9AF70-0x0000000180C9B1D0
	
		public delegate void PinchHandler(Gesture gesture); // TypeDefIndex: 7324; 0x0000000180C9B360-0x0000000180C9B5C0
	
		public delegate void DragStart2FingersHandler(Gesture gesture); // TypeDefIndex: 7325; 0x0000000180B2CBC0-0x0000000180B2CE20
	
		public delegate void Drag2FingersHandler(Gesture gesture); // TypeDefIndex: 7326; 0x0000000180B2BC00-0x0000000180B2BE60
	
		public delegate void DragEnd2FingersHandler(Gesture gesture); // TypeDefIndex: 7327; 0x0000000180B2BFF0-0x0000000180B2C250
	
		public delegate void SwipeStart2FingersHandler(Gesture gesture); // TypeDefIndex: 7328; 0x0000000180CA4B20-0x0000000180CA4D80
	
		public delegate void Swipe2FingersHandler(Gesture gesture); // TypeDefIndex: 7329; 0x0000000180CA3B60-0x0000000180CA3DC0
	
		public delegate void SwipeEnd2FingersHandler(Gesture gesture); // TypeDefIndex: 7330; 0x0000000180CA3F50-0x0000000180CA41B0
	
		public delegate void EasyTouchIsReadyHandler(); // TypeDefIndex: 7331; 0x0000000180B2EE70-0x0000000180B2EFD0
	
		public delegate void OverUIElementHandler(Gesture gesture); // TypeDefIndex: 7332; 0x0000000180C9AB20-0x0000000180C9AD80
	
		public delegate void UIElementTouchUpHandler(Gesture gesture); // TypeDefIndex: 7333; 0x0000000180CA8980-0x0000000180CA8BE0
	
		public enum GesturePriority // TypeDefIndex: 7334
		{
			Tap = 0,
			Slips = 1
		}
	
		public enum DoubleTapDetection // TypeDefIndex: 7335
		{
			BySystem = 0,
			ByTime = 1
		}
	
		public enum GestureType // TypeDefIndex: 7336
		{
			Tap = 0,
			Drag = 1,
			Swipe = 2,
			None = 3,
			LongTap = 4,
			Pinch = 5,
			Twist = 6,
			Cancel = 7,
			Acquisition = 8
		}
	
		public enum SwipeDirection // TypeDefIndex: 7337
		{
			None = 0,
			Left = 1,
			Right = 2,
			Up = 3,
			Down = 4,
			UpLeft = 5,
			UpRight = 6,
			DownLeft = 7,
			DownRight = 8,
			Other = 9,
			All = 10
		}
	
		public enum TwoFingerPickMethod // TypeDefIndex: 7338
		{
			Finger = 0,
			Average = 1
		}
	
		public enum EvtType // TypeDefIndex: 7339
		{
			None = 0,
			On_TouchStart = 1,
			On_TouchDown = 2,
			On_TouchUp = 3,
			On_SimpleTap = 4,
			On_DoubleTap = 5,
			On_LongTapStart = 6,
			On_LongTap = 7,
			On_LongTapEnd = 8,
			On_DragStart = 9,
			On_Drag = 10,
			On_DragEnd = 11,
			On_SwipeStart = 12,
			On_Swipe = 13,
			On_SwipeEnd = 14,
			On_TouchStart2Fingers = 15,
			On_TouchDown2Fingers = 16,
			On_TouchUp2Fingers = 17,
			On_SimpleTap2Fingers = 18,
			On_DoubleTap2Fingers = 19,
			On_LongTapStart2Fingers = 20,
			On_LongTap2Fingers = 21,
			On_LongTapEnd2Fingers = 22,
			On_Twist = 23,
			On_TwistEnd = 24,
			On_Pinch = 25,
			On_PinchIn = 26,
			On_PinchOut = 27,
			On_PinchEnd = 28,
			On_DragStart2Fingers = 29,
			On_Drag2Fingers = 30,
			On_DragEnd2Fingers = 31,
			On_SwipeStart2Fingers = 32,
			On_Swipe2Fingers = 33,
			On_SwipeEnd2Fingers = 34,
			On_EasyTouchIsReady = 35,
			On_Cancel = 36,
			On_Cancel2Fingers = 37,
			On_OverUIElement = 38,
			On_UIElementTouchUp = 39
		}
	
		// Constructors
		public EasyTouch() {} // 0x0000000185A2E780-0x0000000185A2EA10
		static EasyTouch() {} // 0x0000000185A2E6E0-0x0000000185A2E780
	
		// Methods
		// [XID] // 0x0000000189A15510-0x0000000189A15530
		private void OnEnable() {} // 0x0000000185A255E0-0x0000000185A256A0
		// [XID] // 0x0000000189A1C800-0x0000000189A1C820
		private void Awake() {} // 0x0000000185A1EA80-0x0000000185A1EB20
		// [XID] // 0x0000000189A24030-0x0000000189A24050
		private void Start() {} // 0x0000000185A2AEC0-0x0000000185A2B1E0
		// [XID] // 0x0000000189A2B370-0x0000000189A2B390
		private void Init() {} // 0x0000000185A24C20-0x0000000185A24CC0
		// [XID] // 0x0000000189A329B0-0x0000000189A329D0
		private void OnDrawGizmos() {} // 0x0000000185A25540-0x0000000185A255E0
		// [XID] // 0x0000000189A3A370-0x0000000189A3A390
		private void Update() {} // 0x0000000185A2E140-0x0000000185A2E6E0
		// [XID] // 0x0000000189A41C40-0x0000000189A41C60
		private void UpdateIsOverGUI() {} // 0x0000000185A2D3E0-0x0000000185A2D540
		// [XID] // 0x0000000189A49250-0x0000000189A49270
		private void LateUpdate() {} // 0x0000000185A253D0-0x0000000185A25540
		// [XID] // 0x0000000189A50B40-0x0000000189A50B60
		private void UpdateTouches(bool realTouch, int touchCount) {} // 0x0000000185A2D540-0x0000000185A2E140
		// [XID] // 0x0000000189A58000-0x0000000189A58020
		public void ResetTouches() {} // 0x0000000185A28ED0-0x0000000185A28FA0
		// [XID] // 0x0000000189A5FCA0-0x0000000189A5FCC0
		private void OneFinger(int fingerIndex) {} // 0x0000000185A259D0-0x0000000185A27180
		// [XID] // 0x0000000189A67700-0x0000000189A67720
		private void OnFingerTouchStart(int fingerIndex) {} // 0x0000000185A256A0-0x0000000185A259D0
		[DebuggerHidden] // 0x0000000189A6EC00-0x0000000189A6EC40
		// [XID] // 0x0000000189A6EC00-0x0000000189A6EC40
		private IEnumerator SingleOrDouble(int fingerIndex) => default; // 0x0000000185A2ADE0-0x0000000185A2AEC0
		// [XID] // 0x0000000189A795D0-0x0000000189A795F0
		private void CreateGesture(int touchIndex, EvtType message, Finger finger, SwipeDirection swipe, float swipeLength, Vector2 swipeVector) {} // 0x0000000185A1F010-0x0000000185A1F590
		// [XID] // 0x0000000189A80E30-0x0000000189A80E50
		private void TwoFinger() {} // 0x0000000185A2B1E0-0x0000000185A2D330
		// [XID] // 0x0000000189A88720-0x0000000189A88740
		private void DetectPinch(float currentDelta) {} // 0x0000000185A20550-0x0000000185A20BA0
		// [XID] // 0x0000000189A90030-0x0000000189A90050
		private void DetecTwist(Vector2 previousDistance, Vector2 currentDistance, float currentDelta) {} // 0x0000000185A20030-0x0000000185A20550
		// [XID] // 0x0000000189A978D0-0x0000000189A978F0
		private void CreateStateEnd2Fingers(GestureType gesture, Vector2 startPosition, Vector2 position, Vector2 deltaPosition, float time, bool realEnd, float fingerDistance, float twist = 0f /* Metadata: 0x00ADE886 */, float pinch = 0f /* Metadata: 0x00ADE88A */) {} // 0x0000000185A1F590-0x0000000185A20030
		[DebuggerHidden] // 0x0000000189A9EBB0-0x0000000189A9EBF0
		// [XID] // 0x0000000189A9EBB0-0x0000000189A9EBF0
		private IEnumerator SingleOrDouble2Fingers() => default; // 0x0000000185A2AD10-0x0000000185A2ADE0
		// [XID] // 0x0000000189AA9050-0x0000000189AA9070
		private void CreateGesture2Finger(EvtType message, Vector2 startPosition, Vector2 position, Vector2 deltaPosition, float actionTime, SwipeDirection swipe, float swipeLength, Vector2 swipeVector, float twist, float pinch, float twoDistance) {} // 0x0000000185A1EB20-0x0000000185A1F010
		// [XID] // 0x0000000189AB0C60-0x0000000189AB0C80
		private int GetTwoFinger(int index) => default; // 0x0000000185A248A0-0x0000000185A249B0
		// [XID] // 0x0000000189AB8340-0x0000000189AB8360
		private bool GetTwoFingerPickedObject() => default; // 0x0000000185A24220-0x0000000185A244D0
		// [XID] // 0x0000000189ABFE70-0x0000000189ABFE90
		private bool GetTwoFingerPickedUIElement() => default; // 0x0000000185A244D0-0x0000000185A248A0
		// [XID] // 0x0000000189AC79E0-0x0000000189AC7A00
		private void RaiseEvent(EvtType evnt, Gesture gesture) {} // 0x0000000185A27180-0x0000000185A28B20
		// [XID] // 0x0000000189ACEFB0-0x0000000189ACEFD0
		private bool GetPickedGameObject(Finger finger, bool isTowFinger = false /* Metadata: 0x00ADE88E */) => default; // 0x0000000185A233F0-0x0000000185A237D0
		// [IDTag] // 0x0000000189AD6DD0-0x0000000189AD6E10
		// [XID] // 0x0000000189AD6DD0-0x0000000189AD6E10
		private bool GetGameObjectAt(Vector2 position, Camera cam, bool isGuiCam) => default; // 0x0000000185A22720-0x0000000185A22A70
		// [XID] // 0x0000000189AE17A0-0x0000000189AE17C0
		private SwipeDirection GetSwipe(Vector2 start, Vector2 end) => default; // 0x0000000185A23B80-0x0000000185A23FB0
		// [XID] // 0x0000000189AE8C70-0x0000000189AE8C90
		private bool FingerInTolerance(Finger finger) => default; // 0x0000000185A20BA0-0x0000000185A20CE0
		// [XID] // 0x0000000189AF0AF0-0x0000000189AF0B10
		private bool IsTouchOverNGui(Vector2 position, bool isTwoFingers = false /* Metadata: 0x00ADE88F */) => default; // 0x0000000185A250A0-0x0000000185A253D0
		// [XID] // 0x0000000189AF8130-0x0000000189AF8150
		private Finger GetFinger(int finderId) => default; // 0x0000000185A22380-0x0000000185A224E0
		// [XID] // 0x0000000189AFF7B0-0x0000000189AFF7D0
		private bool IsScreenPositionOverUI(Vector2 position) => default; // 0x0000000185A24E50-0x0000000185A250A0
		// [XID] // 0x0000000189B06E00-0x0000000189B06E20
		private GameObject GetFirstUIElementFromCache() => default; // 0x0000000185A224E0-0x0000000185A22650
		// [XID] // 0x0000000189B0E650-0x0000000189B0E670
		private GameObject GetFirstUIElement(Vector2 position) => default; // 0x0000000185A22650-0x0000000185A22720
		// [XID] // 0x0000000189B15860-0x0000000189B15880
		public static bool IsFingerOverUIElement(int fingerIndex) => default; // 0x0000000185A24CC0-0x0000000185A24E50
		// [XID] // 0x0000000189B1D1E0-0x0000000189B1D200
		public static GameObject GetCurrentPickedUIElement(int fingerIndex, bool isTwoFinger) => default; // 0x0000000185A21680-0x0000000185A218C0
		// [XID] // 0x0000000189B24810-0x0000000189B24830
		public static GameObject GetCurrentPickedObject(int fingerIndex, bool isTwoFinger) => default; // 0x0000000185A21480-0x0000000185A21680
		// [IDTag] // 0x0000000189B2BD00-0x0000000189B2BD40
		// [XID] // 0x0000000189B2BD00-0x0000000189B2BD40
		public static GameObject GetGameObjectAt(Vector2 position, bool isTwoFinger = false /* Metadata: 0x00ADE890 */) => default; // 0x0000000185A22A70-0x0000000185A22F10
		// [XID] // 0x0000000189B362E0-0x0000000189B36300
		public static int GetTouchCount() => default; // 0x0000000185A23FB0-0x0000000185A240F0
		// [XID] // 0x0000000189B3D890-0x0000000189B3D8B0
		public static void ResetTouch(int fingerIndex) {} // 0x0000000185A28D80-0x0000000185A28ED0
		// [XID] // 0x0000000189B45740-0x0000000189B45760
		public static void ResetTouchs() {} // 0x0000000185A28FA0-0x0000000185A290D0
		// [XID] // 0x0000000189B4CD30-0x0000000189B4CD50
		public static void SetEnabled(bool enable) {} // 0x0000000185A29FA0-0x0000000185A2A0B0
		// [XID] // 0x0000000189B54360-0x0000000189B54380
		public static bool GetEnabled() => default; // 0x0000000185A22250-0x0000000185A22380
		// [XID] // 0x0000000189B5BF90-0x0000000189B5BFB0
		public static void SetEnableUIDetection(bool enable) {} // 0x0000000185A29E60-0x0000000185A29FA0
		// [XID] // 0x0000000189B63450-0x0000000189B63470
		public static bool GetEnableUIDetection() => default; // 0x0000000185A22120-0x0000000185A22250
		// [XID] // 0x0000000189B6AD90-0x0000000189B6ADB0
		public static void SetUICompatibily(bool value) {} // 0x0000000185A2ABD0-0x0000000185A2AD10
		// [XID] // 0x0000000189B724A0-0x0000000189B724C0
		public static bool GetUIComptability() => default; // 0x0000000185A249B0-0x0000000185A24AE0
		// [XID] // 0x0000000189B79980-0x0000000189B799A0
		public static void SetAutoUpdateUI(bool value) {} // 0x0000000185A29470-0x0000000185A295B0
		// [XID] // 0x0000000189B80C90-0x0000000189B80CB0
		public static bool GetAutoUpdateUI() => default; // 0x0000000185A21190-0x0000000185A212C0
		// [XID] // 0x0000000189B88880-0x0000000189B888A0
		public static void SetNGUICompatibility(bool value) {} // 0x0000000185A2A5A0-0x0000000185A2A6E0
		// [XID] // 0x0000000189B8FB50-0x0000000189B8FB70
		public static bool GetNGUICompatibility() => default; // 0x0000000185A232C0-0x0000000185A233F0
		// [XID] // 0x0000000189B97000-0x0000000189B97020
		public static void SetEnableAutoSelect(bool value) {} // 0x0000000185A29AA0-0x0000000185A29BE0
		// [XID] // 0x0000000189B9E520-0x0000000189B9E540
		public static bool GetEnableAutoSelect() => default; // 0x0000000185A21D90-0x0000000185A21EC0
		// [XID] // 0x0000000189BA5EA0-0x0000000189BA5EC0
		public static void SetAutoUpdatePickedObject(bool value) {} // 0x0000000185A29330-0x0000000185A29470
		// [XID] // 0x0000000189BAD240-0x0000000189BAD260
		public static bool GetAutoUpdatePickedObject() => default; // 0x0000000185A21060-0x0000000185A21190
		// [XID] // 0x0000000189631900-0x0000000189631920
		public static void Set3DPickableLayer(LayerMask mask) {} // 0x0000000185A29200-0x0000000185A29330
		// [XID] // 0x000000018962A160-0x000000018962A180
		public static LayerMask Get3DPickableLayer() => default; // 0x0000000185A20EA0-0x0000000185A21060
		// [XID] // 0x0000000189BC3CF0-0x0000000189BC3D10
		public static void AddCamera(Camera cam, bool guiCam = false /* Metadata: 0x00ADE891 */) {} // 0x0000000185A1E8F0-0x0000000185A1EA80
		// [XID] // 0x0000000189BCB580-0x0000000189BCB5A0
		public static void RemoveCamera(Camera cam) {} // 0x0000000185A28B20-0x0000000185A28D80
		// [XID] // 0x0000000189BD2B80-0x0000000189BD2BA0
		public static Camera GetCamera(int index = 0 /* Metadata: 0x00ADE892 */) => default; // 0x0000000185A212C0-0x0000000185A21480
		// [XID] // 0x0000000189BDA090-0x0000000189BDA0B0
		public static void SetEnable2DCollider(bool value) {} // 0x0000000185A29820-0x0000000185A29960
		// [XID] // 0x00000001895E6C90-0x00000001895E6CB0
		public static bool GetEnable2DCollider() => default; // 0x0000000185A21B30-0x0000000185A21C60
		// [XID] // 0x00000001895EE710-0x00000001895EE730
		public static void Set2DPickableLayer(LayerMask mask) {} // 0x0000000185A290D0-0x0000000185A29200
		// [XID] // 0x00000001895F6030-0x00000001895F6050
		public static LayerMask Get2DPickableLayer() => default; // 0x0000000185A20CE0-0x0000000185A20EA0
		// [XID] // 0x00000001895FD3F0-0x00000001895FD410
		public static void SetGesturePriority(GesturePriority value) {} // 0x0000000185A2A0B0-0x0000000185A2A1E0
		// [XID] // 0x0000000189604D90-0x0000000189604DB0
		public static GesturePriority GetGesturePriority() => default; // 0x0000000185A22F10-0x0000000185A23040
		// [XID] // 0x000000018960C560-0x000000018960C580
		public static void SetStationaryTolerance(float tolerance) {} // 0x0000000185A2A820-0x0000000185A2A960
		// [XID] // 0x0000000189613C80-0x0000000189613CA0
		public static float GetStationaryTolerance() => default; // 0x0000000185A23900-0x0000000185A23A40
		// [XID] // 0x000000018961B480-0x000000018961B4A0
		public static void SetLongTapTime(float time) {} // 0x0000000185A2A1E0-0x0000000185A2A320
		// [XID] // 0x0000000189622AE0-0x0000000189622B00
		public static float GetlongTapTime() => default; // 0x0000000185A24AE0-0x0000000185A24C20
		// [XID] // 0x000000018962A340-0x000000018962A360
		public static void SetDoubleTapTime(float time) {} // 0x0000000185A296E0-0x0000000185A29820
		// [XID] // 0x0000000189631AC0-0x0000000189631AE0
		public static float GetDoubleTapTime() => default; // 0x0000000185A219F0-0x0000000185A21B30
		// [XID] // 0x00000001896395F0-0x0000000189639610
		public static void SetDoubleTapMethod(DoubleTapDetection detection) {} // 0x0000000185A295B0-0x0000000185A296E0
		// [XID] // 0x0000000189640AF0-0x0000000189640B10
		public static DoubleTapDetection GetDoubleTapMethod() => default; // 0x0000000185A218C0-0x0000000185A219F0
		// [XID] // 0x0000000189648440-0x0000000189648460
		public static void SetSwipeTolerance(float tolerance) {} // 0x0000000185A2A960-0x0000000185A2AAA0
		// [XID] // 0x000000018964FA70-0x000000018964FA90
		public static float GetSwipeTolerance() => default; // 0x0000000185A23A40-0x0000000185A23B80
		// [XID] // 0x0000000189657380-0x00000001896573A0
		public static void SetEnable2FingersGesture(bool enable) {} // 0x0000000185A29960-0x0000000185A29AA0
		// [XID] // 0x000000018965E9F0-0x000000018965EA10
		public static bool GetEnable2FingersGesture() => default; // 0x0000000185A21C60-0x0000000185A21D90
		// [XID] // 0x00000001896660A0-0x00000001896660C0
		public static void SetTwoFingerPickMethod(TwoFingerPickMethod pickMethod) {} // 0x0000000185A2AAA0-0x0000000185A2ABD0
		// [XID] // 0x000000018966D8B0-0x000000018966D8D0
		public static TwoFingerPickMethod GetTwoFingerPickMethod() => default; // 0x0000000185A240F0-0x0000000185A24220
		// [XID] // 0x0000000189675730-0x0000000189675750
		public static void SetEnablePinch(bool enable) {} // 0x0000000185A29BE0-0x0000000185A29D20
		// [XID] // 0x000000018967CEA0-0x000000018967CEC0
		public static bool GetEnablePinch() => default; // 0x0000000185A21EC0-0x0000000185A21FF0
		// [XID] // 0x00000001896844E0-0x0000000189684500
		public static void SetMinPinchLength(float length) {} // 0x0000000185A2A320-0x0000000185A2A460
		// [XID] // 0x000000018968C0E0-0x000000018968C100
		public static float GetMinPinchLength() => default; // 0x0000000185A23040-0x0000000185A23180
		// [XID] // 0x0000000189693BB0-0x0000000189693BD0
		public static void SetEnableTwist(bool enable) {} // 0x0000000185A29D20-0x0000000185A29E60
		// [XID] // 0x000000018969B050-0x000000018969B070
		public static bool GetEnableTwist() => default; // 0x0000000185A21FF0-0x0000000185A22120
		// [XID] // 0x00000001896A2A40-0x00000001896A2A60
		public static void SetMinTwistAngle(float angle) {} // 0x0000000185A2A460-0x0000000185A2A5A0
		// [XID] // 0x00000001896A9DB0-0x00000001896A9DD0
		public static float GetMinTwistAngle() => default; // 0x0000000185A23180-0x0000000185A232C0
		// [XID] // 0x00000001896B0BE0-0x00000001896B0C00
		public static bool GetSecondeFingerSimulation() => default; // 0x0000000185A237D0-0x0000000185A23900
		// [XID] // 0x00000001896B8830-0x00000001896B8850
		public static void SetSecondFingerSimulation(bool value) {} // 0x0000000185A2A6E0-0x0000000185A2A820
	}
}
