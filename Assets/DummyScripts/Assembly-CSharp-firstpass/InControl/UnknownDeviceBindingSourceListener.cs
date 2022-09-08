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
	public class UnknownDeviceBindingSourceListener : BindingSourceListener // TypeDefIndex: 7614
	{
		// Fields
		private UnknownDeviceControl detectFound; // 0x10
		private DetectPhase detectPhase; // 0x1C
	
		// Nested types
		private enum DetectPhase // TypeDefIndex: 7615
		{
			WaitForInitialRelease = 0,
			WaitForControlPress = 1,
			WaitForControlRelease = 2
		}
	
		// Constructors
		public UnknownDeviceBindingSourceListener() {} // 0x0000000187B02FF0-0x0000000187B03050
	
		// Methods
		// [XID] // 0x00000001896480A0-0x00000001896480C0
		public void Reset() {} // 0x0000000187B02D60-0x0000000187B02E50
		// [XID] // 0x0000000189665E60-0x0000000189665E80
		private void TakeSnapshotOnUnknownDevices() {} // 0x0000000187B02E50-0x0000000187B02FF0
		// [XID] // 0x000000018996DF20-0x000000018996DF40
		public BindingSource Listen(BindingListenOptions listenOptions, InputDevice device) => default; // 0x0000000187B02AF0-0x0000000187B02D60
		// [XID] // 0x00000001896A28E0-0x00000001896A2900
		private bool IsPressed(UnknownDeviceControl control, InputDevice device) => default; // 0x0000000187B027B0-0x0000000187B028D0
		// [XID] // 0x00000001897A0D10-0x00000001897A0D30
		private UnknownDeviceControl ListenForControl(BindingListenOptions listenOptions, InputDevice device) => default; // 0x0000000187B028D0-0x0000000187B02AF0
	}
}
