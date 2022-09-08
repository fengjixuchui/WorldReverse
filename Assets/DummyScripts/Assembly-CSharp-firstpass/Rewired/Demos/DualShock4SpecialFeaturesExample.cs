/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using Rewired;
using Rewired.ControllerExtensions;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Demos
{
	// [AddComponentMenu] // 0x0000000189B0FD10-0x0000000189B0FD40
	public class DualShock4SpecialFeaturesExample : MonoBehaviour // TypeDefIndex: 9776
	{
		// Fields
		private const int maxTouches = 2; // Metadata: 0x00AE629E
		public int playerId; // 0x18
		public Transform touchpadTransform; // 0x20
		public GameObject lightObject; // 0x28
		public Transform accelerometerTransform; // 0x30
		private List<Touch> touches; // 0x38
		private Queue<Touch> unusedTouches; // 0x40
		private bool isFlashing; // 0x48
		private GUIStyle textStyle; // 0x50
	
		// Properties
		private Player player { /* [XID] */ /* 0x0000000189892910-0x0000000189892930 */ get => default; } // 0x000000018654CC10-0x000000018654CCF0 
	
		// Nested types
		private class Touch // TypeDefIndex: 9777
		{
			// Fields
			public GameObject go; // 0x10
			public int touchId; // 0x18
	
			// Constructors
			public Touch() {} // 0x0000000186563AB0-0x0000000186563B20
		}
	
		// Constructors
		public DualShock4SpecialFeaturesExample() {} // 0x000000018654CBA0-0x000000018654CC10
	
		// Methods
		// [XID] // 0x0000000189875820-0x0000000189875840
		private void Awake() {} // 0x000000018654B0D0-0x000000018654B170
		// [XID] // 0x0000000189A80C60-0x0000000189A80C80
		private void Update() {} // 0x000000018654C780-0x000000018654CBA0
		// [XID] // 0x0000000189A885C0-0x0000000189A885E0
		private void OnGUI() {} // 0x000000018654BC10-0x000000018654C2C0
		// [XID] // 0x0000000189A25ED0-0x0000000189A25EF0
		private void ResetOrientation() {} // 0x000000018654C2C0-0x000000018654C390
		// [XID] // 0x0000000189A976D0-0x0000000189A976F0
		private void SetRandomLightColor() {} // 0x000000018654C390-0x000000018654C5D0
		// [XID] // 0x0000000189A9EA30-0x0000000189A9EA50
		private void StartLightFlash() {} // 0x000000018654C5D0-0x000000018654C6B0
		// [XID] // 0x0000000189AA6400-0x0000000189AA6420
		private void StopLightFlash() {} // 0x000000018654C6B0-0x000000018654C780
		// [XID] // 0x0000000189B816F0-0x0000000189B81710
		private IDualShock4Extension GetFirstDS4(Player player) => default; // 0x000000018654B170-0x000000018654B360
		// [XID] // 0x0000000189AB51D0-0x0000000189AB51F0
		private void InitializeTouchObjects() {} // 0x000000018654B8F0-0x000000018654BC10
		// [XID] // 0x0000000189B88D70-0x0000000189B88D90
		private void HandleTouchpad(IDualShock4Extension ds4) {} // 0x000000018654B360-0x000000018654B8F0
	}
}
