/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using InControl;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace VirtualDeviceExample
{
	public class VirtualDevice : InputDevice // TypeDefIndex: 7583
	{
		// Fields
		private const float sensitivity = 0.1f; // Metadata: 0x00ADED5A
		private const float mouseScale = 0.05f; // Metadata: 0x00ADED5E
		private float kx; // 0x178
		private float ky; // 0x17C
		private float mx; // 0x180
		private float my; // 0x184
	
		// Constructors
		public VirtualDevice() {} // 0x0000000186EAAB00-0x0000000186EAAC90
	
		// Methods
		// [XID] // 0x0000000189997670-0x0000000189997690
		public override void Update(ulong updateTick, float deltaTime) {} // 0x0000000186EAA900-0x0000000186EAAB00
		// [XID] // 0x0000000189A53A50-0x0000000189A53A70
		private Vector2 GetVectorFromKeyboard(float deltaTime, bool smoothed) => default; // 0x0000000186EAA230-0x0000000186EAA3E0
		// [XID] // 0x0000000189A5B140-0x0000000189A5B160
		private float GetXFromKeyboard() => default; // 0x0000000186EAA610-0x0000000186EAA740
		// [XID] // 0x0000000189A53730-0x0000000189A53750
		private float GetYFromKeyboard() => default; // 0x0000000186EAA740-0x0000000186EAA870
		// [XID] // 0x0000000189A6A720-0x0000000189A6A740
		private Vector2 GetVectorFromMouse(float deltaTime, bool smoothed) => default; // 0x0000000186EAA3E0-0x0000000186EAA610
		// [XID] // 0x0000000189A71C50-0x0000000189A71C70
		private float ApplySmoothing(float lastValue, float thisValue, float deltaTime, float sensitivity) => default; // 0x0000000186EAA080-0x0000000186EAA230
	}
}
