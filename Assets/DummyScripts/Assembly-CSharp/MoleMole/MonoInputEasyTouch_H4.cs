/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using HedgehogTeam.EasyTouch;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoInputEasyTouch_H4 : MonoBehaviour // TypeDefIndex: 31229
	{
		// Fields
		private const float ZOOMING_SCALE_FACTOR = 1f; // Metadata: 0x00B12082
		private FingerUtil _fingerUtil; // 0x18
		private float _screenWidthInInch; // 0x20
		private float _screenHeightInInch; // 0x24
		private UnityEvent _clickCallback; // 0x28
		public bool doRotateScale; // 0x30
		public bool useDefaultScale; // 0x31
		public bool enableRotateX; // 0x32
		public bool enableRotateY; // 0x33
		public bool enableZoom; // 0x34
		private bool _isCloudGame; // 0x35
		private float _rotateCameraScale; // 0x38
	
		// Properties
		public UnityEvent clickCallback { /* [XID] */ /* 0x00000001899BC000-0x00000001899BC020 */ get => default; } // 0x0000000184321820-0x00000001843218C0 
		public float rotateCameraScale { /* [XID] */ /* 0x00000001899C3B30-0x00000001899C3B50 */ set {} } // 0x00000001843218C0-0x0000000184321970
	
		// Constructors
		public MonoInputEasyTouch_H4() {} // 0x0000000184321770-0x0000000184321820
	
		// Methods
		// [XID] // 0x00000001899CB150-0x00000001899CB170
		private void Awake() {} // 0x0000000184320270-0x0000000184320330
		// [XID] // 0x00000001899D2660-0x00000001899D2680
		private void Start() {} // 0x00000001843211E0-0x00000001843212E0
		// [XID] // 0x00000001899D9D70-0x00000001899D9D90
		private void OnEnable() {} // 0x0000000184320A00-0x0000000184320AA0
		// [XID] // 0x00000001899E1630-0x00000001899E1650
		private void OnDisable() {} // 0x0000000184320960-0x0000000184320A00
		// [XID] // 0x00000001899E8CE0-0x00000001899E8D00
		private void OnDestroy() {} // 0x00000001843208C0-0x0000000184320960
		// [XID] // 0x00000001899F0660-0x00000001899F0680
		public void SubscribeEvent() {} // 0x00000001843212E0-0x0000000184321530
		// [XID] // 0x00000001899F7C60-0x00000001899F7C80
		public void UnsubscribeEvent() {} // 0x0000000184321530-0x0000000184321770
		// [XID] // 0x00000001899FF290-0x00000001899FF2B0
		private void On_TouchStart(Gesture gesture) {} // 0x0000000184320F40-0x0000000184321090
		// [XID] // 0x0000000189A06AD0-0x0000000189A06AF0
		private void On_TouchUp(Gesture gesture) {} // 0x0000000184321090-0x00000001843211E0
		// [XID] // 0x0000000189A0E1A0-0x0000000189A0E1C0
		private void On_Swipe(Gesture gesture) {} // 0x0000000184320BF0-0x0000000184320F40
		// [XID] // 0x0000000189A15760-0x0000000189A15780
		private void On_SwipeEnd(Gesture gesture) {} // 0x0000000184320AA0-0x0000000184320BF0
		// [XID] // 0x0000000189A1CC40-0x0000000189A1CC60
		private void On_PinchIn(Gesture gesture) {} // 0x0000000184320650-0x0000000184320810
		// [XID] // 0x0000000189A241C0-0x0000000189A241E0
		private void On_PinchOut(Gesture gesture) {} // 0x0000000184320330-0x00000001843204E0
		// [XID] // 0x0000000189A2B610-0x0000000189A2B630
		private void On_SimpleTap(Gesture gesture) {} // 0x0000000184320590-0x0000000184320650
		// [XID] // 0x0000000189A32C60-0x0000000189A32C80
		public void DoOnUnactive() {} // 0x00000001843204E0-0x0000000184320590
		// [XID] // 0x0000000189A3A510-0x0000000189A3A530
		private void OnApplicationFocus(bool isFocus) {} // 0x0000000184320810-0x00000001843208C0
	}
}
