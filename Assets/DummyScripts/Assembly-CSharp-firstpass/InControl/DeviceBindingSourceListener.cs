/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class DeviceBindingSourceListener : BindingSourceListener // TypeDefIndex: 7600
	{
		// Fields
		private InputControlType detectFound; // 0x10
		private int detectPhase; // 0x14
	
		// Constructors
		public DeviceBindingSourceListener() {} // 0x0000000187DAD8F0-0x0000000187DAD950
	
		// Methods
		// [XID] // 0x00000001896380A0-0x00000001896380C0
		public void Reset() {} // 0x0000000187DAD850-0x0000000187DAD8F0
		// [XID] // 0x000000018963F290-0x000000018963F2B0
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device) => default; // 0x0000000187DAD6D0-0x0000000187DAD850
		// [IDTag] // 0x0000000189646AE0-0x0000000189646B20
		// [XID] // 0x0000000189646AE0-0x0000000189646B20
		private bool IsPressed(InputControl control) => default; // 0x0000000187DAD320-0x0000000187DAD420
		// [IDTag] // 0x00000001896511F0-0x0000000189651230
		// [XID] // 0x00000001896511F0-0x0000000189651230
		private bool IsPressed(InputControlType control, InputDevice device) => default; // 0x0000000187DAD420-0x0000000187DAD510
		// [XID] // 0x000000018965BC90-0x000000018965BCB0
		private InputControlType ListenForControl(BindingListenOptions listenOptions, InputDevice device) => default; // 0x0000000187DAD510-0x0000000187DAD6D0
	}
}
