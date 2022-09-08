/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using Rewired;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired.Demos
{
	// [AddComponentMenu] // 0x0000000189B0FD10-0x0000000189B0FD40
	public class CustomControllerDemo : MonoBehaviour // TypeDefIndex: 9772
	{
		// Fields
		public int playerId; // 0x18
		public string controllerTag; // 0x20
		public bool useUpdateCallbacks; // 0x28
		private int buttonCount; // 0x2C
		private int axisCount; // 0x30
		private float[] axisValues; // 0x38
		private bool[] buttonValues; // 0x40
		private TouchJoystickExample[] joysticks; // 0x48
		private TouchButtonExample[] buttons; // 0x50
		private CustomController controller; // 0x58
		[NonSerialized]
		private bool initialized; // 0x60
	
		// Constructors
		public CustomControllerDemo() {} // 0x00000001865490D0-0x0000000186549130
	
		// Methods
		// [XID] // 0x0000000189934690-0x00000001899346B0
		private void Awake() {} // 0x0000000186547BB0-0x0000000186547C80
		// [XID] // 0x000000018993C1F0-0x000000018993C210
		private void Initialize() {} // 0x00000001865481E0-0x0000000186548580
		// [XID] // 0x0000000189AC50D0-0x0000000189AC50F0
		private void Update() {} // 0x0000000186549000-0x00000001865490D0
		// [XID] // 0x0000000189BB2110-0x0000000189BB2130
		private void OnInputSourceUpdate() {} // 0x0000000186548580-0x0000000186548650
		// [XID] // 0x0000000189ABC2E0-0x0000000189ABC300
		private void GetSourceAxisValues() {} // 0x0000000186547E70-0x0000000186548050
		// [XID] // 0x0000000189959AF0-0x0000000189959B10
		private void GetSourceButtonValues() {} // 0x0000000186548050-0x00000001865481E0
		// [XID] // 0x0000000189961490-0x00000001899614B0
		private void SetControllerAxisValues() {} // 0x0000000186548DD0-0x0000000186548EE0
		// [XID] // 0x0000000189AA5400-0x0000000189AA5420
		private void SetControllerButtonValues() {} // 0x0000000186548EE0-0x0000000186549000
		// [XID] // 0x0000000189970180-0x00000001899701A0
		private float GetAxisValueCallback(int index) => default; // 0x0000000186547C80-0x0000000186547D80
		// [XID] // 0x0000000189977FD0-0x0000000189977FF0
		private bool GetButtonValueCallback(int index) => default; // 0x0000000186547D80-0x0000000186547E70
	}
}
