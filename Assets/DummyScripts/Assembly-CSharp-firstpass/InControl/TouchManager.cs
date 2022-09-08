/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class TouchManager : SingletonMonoBehavior<InControl.TouchManager> // TypeDefIndex: 7836
	{
		// Fields
		[Space] // 0x00000001896B5980-0x00000001896B59A0
		public Camera touchCamera; // 0x18
		public GizmoShowOption controlsShowGizmos; // 0x20
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool enableControlsOnTouch; // 0x24
		[HideInInspector] // 0x00000001896ACE20-0x00000001896ACE50
		[SerializeField] // 0x00000001896ACE20-0x00000001896ACE50
		private bool _controlsEnabled; // 0x25
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public int controlsLayer; // 0x28
		private InputDevice device; // 0x30
		private Vector3 viewSize; // 0x38
		private Vector2 screenSize; // 0x44
		private Vector2 halfScreenSize; // 0x4C
		private float percentToWorld; // 0x54
		private float halfPercentToWorld; // 0x58
		private float pixelToWorld; // 0x5C
		private float halfPixelToWorld; // 0x60
		private TouchControl[] touchControls; // 0x68
		private TouchPool cachedTouches; // 0x70
		private List<Touch> activeTouches; // 0x78
		private ReadOnlyCollection<Touch> readOnlyActiveTouches; // 0x80
		private Vector2 lastMousePosition; // 0x88
		private bool isReady; // 0x90
		private Touch mouseTouch; // 0x98
	
		// Properties
		public bool controlsEnabled { /* [XID] */ /* 0x000000018979E210-0x000000018979E230 */ get => default; /* [XID] */ /* 0x0000000189971F10-0x0000000189971F30 */ set {} } // 0x00000001877E0940-0x00000001877E09E0 0x00000001877E0CB0-0x00000001877E0DF0
		public static ReadOnlyCollection<Touch> Touches { /* [XID] */ /* 0x00000001897ACDF0-0x00000001897ACE10 */ get => default; } // 0x00000001877E0750-0x00000001877E0830 
		public static int TouchCount { /* [XID] */ /* 0x00000001897B4A90-0x00000001897B4AB0 */ get => default; } // 0x00000001877E0660-0x00000001877E0750 
		public static Camera Camera { /* [XID] */ /* 0x0000000189745610-0x0000000189745630 */ get => default; } // 0x00000001877DFDD0-0x00000001877DFEA0 
		public static InputDevice Device { /* [XID] */ /* 0x000000018980D730-0x000000018980D750 */ get => default; } // 0x00000001877E0050-0x00000001877E0120 
		public static Vector3 ViewSize { /* [XID] */ /* 0x0000000189ADCDD0-0x0000000189ADCDF0 */ get => default; } // 0x00000001877E0830-0x00000001877E0940 
		public static float PercentToWorld { /* [XID] */ /* 0x0000000189AD5400-0x0000000189AD5420 */ get => default; } // 0x00000001877E03C0-0x00000001877E04A0 
		public static float HalfPercentToWorld { /* [XID] */ /* 0x0000000189B31A00-0x0000000189B31A20 */ get => default; } // 0x00000001877E0120-0x00000001877E0200 
		public static float PixelToWorld { /* [XID] */ /* 0x000000018982B840-0x000000018982B860 */ get => default; } // 0x00000001877E04A0-0x00000001877E0580 
		public static float HalfPixelToWorld { /* [XID] */ /* 0x0000000189BA12E0-0x0000000189BA1300 */ get => default; } // 0x00000001877E0200-0x00000001877E02E0 
		public static Vector2 ScreenSize { /* [XID] */ /* 0x0000000189736530-0x0000000189736550 */ get => default; } // 0x00000001877E0580-0x00000001877E0660 
		public static Vector2 HalfScreenSize { /* [XID] */ /* 0x0000000189841780-0x00000001898417A0 */ get => default; } // 0x00000001877E02E0-0x00000001877E03C0 
		public static GizmoShowOption ControlsShowGizmos { /* [XID] */ /* 0x0000000189848C20-0x0000000189848C40 */ get => default; } // 0x00000001877DFF80-0x00000001877E0050 
		public static bool ControlsEnabled { /* [XID] */ /* 0x000000018973E340-0x000000018973E360 */ get => default; /* [XID] */ /* 0x0000000189857770-0x0000000189857790 */ set {} } // 0x00000001877DFEA0-0x00000001877DFF80 0x00000001877E0BD0-0x00000001877E0CB0
	
		// Events
		public static event Action OnSetup;
	
		// Nested types
		public enum GizmoShowOption // TypeDefIndex: 7837
		{
			Never = 0,
			WhenSelected = 1,
			UnlessPlaying = 2,
			Always = 3
		}
	
		// Constructors
		protected TouchManager() {} // 0x00000001877DFC10-0x00000001877DFCB0
	
		// Methods
		// [XID] // 0x0000000189A2F950-0x0000000189A2F970
		private void OnEnable() {} // 0x00000001877DDD50-0x00000001877DDFA0
		// [XID] // 0x00000001896FAC70-0x00000001896FAC90
		private void OnDisable() {} // 0x00000001877DDBC0-0x00000001877DDD50
		// [XID] // 0x000000018997D540-0x000000018997D560
		private void Setup() {} // 0x00000001877DEB20-0x00000001877DEC20
		// [XID] // 0x0000000189702280-0x00000001897022A0
		private void Reset() {} // 0x00000001877DE3C0-0x00000001877DE490
		[DebuggerHidden] // 0x000000018970CA90-0x000000018970CAD0
		// [XID] // 0x000000018970CA90-0x000000018970CAD0
		private IEnumerator UpdateScreenSizeAtEndOfFrame() => default; // 0x00000001877DF190-0x00000001877DF2A0
		// [XID] // 0x0000000189718980-0x00000001897189A0
		private void Update() {} // 0x00000001877DF960-0x00000001877DFAF0
		// [XID] // 0x000000018971EA40-0x000000018971EA60
		private void CreateDevice() {} // 0x00000001877DD090-0x00000001877DD540
		// [XID] // 0x0000000189726160-0x0000000189726180
		private void UpdateDevice(ulong updateTick, float deltaTime) {} // 0x00000001877DF0B0-0x00000001877DF190
		// [XID] // 0x00000001896EBE50-0x00000001896EBE70
		private void CommitDevice(ulong updateTick, float deltaTime) {} // 0x00000001877DC800-0x00000001877DC8D0
		// [XID] // 0x00000001896C0FE0-0x00000001896C1000
		private void SubmitControlStates(ulong updateTick, float deltaTime) {} // 0x00000001877DEC20-0x00000001877DEDB0
		// [XID] // 0x000000018973CAB0-0x000000018973CAD0
		private void CommitControlStates(ulong updateTick, float deltaTime) {} // 0x00000001877DC670-0x00000001877DC800
		// [XID] // 0x0000000189743F80-0x0000000189743FA0
		private void UpdateScreenSize(Vector2 currentScreenSize) {} // 0x00000001877DF2A0-0x00000001877DF5F0
		// [XID] // 0x000000018974BBB0-0x000000018974BBD0
		private void CreateTouches() {} // 0x00000001877DD540-0x00000001877DD700
		// [XID] // 0x00000001895EE510-0x00000001895EE530
		private void UpdateTouches(ulong updateTick, float deltaTime) {} // 0x00000001877DF5F0-0x00000001877DF960
		// [XID] // 0x000000018975A1E0-0x000000018975A200
		private void SendTouchBegan(Touch touch) {} // 0x00000001877DE6D0-0x00000001877DE840
		// [XID] // 0x0000000189761F40-0x0000000189761F60
		private void SendTouchMoved(Touch touch) {} // 0x00000001877DE9B0-0x00000001877DEB20
		// [XID] // 0x0000000189769390-0x00000001897693B0
		private void SendTouchEnded(Touch touch) {} // 0x00000001877DE840-0x00000001877DE9B0
		// [XID] // 0x0000000189770A80-0x0000000189770AA0
		private void InvokeTouchEvents() {} // 0x00000001877DDA20-0x00000001877DDBC0
		// [XID] // 0x0000000189778370-0x0000000189778390
		private bool TouchCameraIsValid() => default; // 0x00000001877DEDB0-0x00000001877DF0B0
		// [XID] // 0x00000001897EA220-0x00000001897EA240
		private Vector3 ConvertScreenToWorldPoint(Vector2 point) => default; // 0x00000001877DCAC0-0x00000001877DCCB0
		// [XID] // 0x0000000189AF37E0-0x0000000189AF3800
		private Vector3 ConvertViewToWorldPoint(Vector2 point) => default; // 0x00000001877DCEA0-0x00000001877DD090
		// [XID] // 0x00000001898EDCF0-0x00000001898EDD10
		private Vector3 ConvertScreenToViewPoint(Vector2 point) => default; // 0x00000001877DC8D0-0x00000001877DCAC0
		// [XID] // 0x00000001899B2FB0-0x00000001899B2FD0
		private Vector2 GetCurrentScreenSize() => default; // 0x00000001877DD700-0x00000001877DD840
		// [XID] // 0x00000001897BC9E0-0x00000001897BCA00
		public static Touch GetTouch(int touchIndex) => default; // 0x00000001877DD930-0x00000001877DDA20
		// [XID] // 0x0000000189727880-0x00000001897278A0
		public static Touch GetTouchByFingerId(int fingerId) => default; // 0x00000001877DD840-0x00000001877DD930
		// [XID] // 0x00000001897DB310-0x00000001897DB330
		public static Vector3 ScreenToWorldPoint(Vector2 point) => default; // 0x00000001877DE5B0-0x00000001877DE6D0
		// [XID] // 0x0000000189AEBD70-0x0000000189AEBD90
		public static Vector3 ViewToWorldPoint(Vector2 point) => default; // 0x00000001877DFAF0-0x00000001877DFC10
		// [XID] // 0x00000001897DAB70-0x00000001897DAB90
		public static Vector3 ScreenToViewPoint(Vector2 point) => default; // 0x00000001877DE490-0x00000001877DE5B0
		// [IDTag] // 0x00000001897E20C0-0x00000001897E2100
		// [XID] // 0x00000001897E20C0-0x00000001897E2100
		public static float ConvertToWorld(float value, TouchUnitType unitType) => default; // 0x00000001877DCCB0-0x00000001877DCD80
		// [XID] // 0x00000001897ECBF0-0x00000001897ECC10
		public static Rect PercentToWorldRect(Rect rect) => default; // 0x00000001877DDFA0-0x00000001877DE190
		// [XID] // 0x00000001897F44A0-0x00000001897F44C0
		public static Rect PixelToWorldRect(Rect rect) => default; // 0x00000001877DE190-0x00000001877DE3C0
		// [IDTag] // 0x00000001897FBF60-0x00000001897FBFA0
		// [XID] // 0x00000001897FBF60-0x00000001897FBFA0
		public static Rect ConvertToWorld(Rect rect, TouchUnitType unitType) => default; // 0x00000001877DCD80-0x00000001877DCEA0
		// [XID] // 0x000000018985E930-0x000000018985E950
		public static implicit operator bool(TouchManager instance) => default; // 0x00000001877E09E0-0x00000001877E0AB0
	}
}
