/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using XInputDotNetPure;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class XInputDevice : InputDevice // TypeDefIndex: 8009
	{
		// Fields
		private const float LowerDeadZone = 0.2f; // Metadata: 0x00ADF3DD
		private const float UpperDeadZone = 0.9f; // Metadata: 0x00ADF3E1
		private XInputDeviceManager owner; // 0x178
		private GamePadState state; // 0x180
	
		// Properties
		public int DeviceIndex { /* [XID] */ /* 0x0000000189838BE0-0x0000000189838C20 */ get; private set; } // 0x0000000187B0C700-0x0000000187B0C760 0x0000000187B0C810-0x0000000187B0C880
		public bool IsConnected { /* [XID] */ /* 0x00000001898604B0-0x00000001898604D0 */ get => default; } // 0x0000000187B0C760-0x0000000187B0C810 
	
		// Constructors
		public XInputDevice() {} // Dummy constructor
		public XInputDevice(int deviceIndex, XInputDeviceManager owner) {} // 0x0000000187B0C2E0-0x0000000187B0C700
	
		// Methods
		// [XID] // 0x0000000189B75D90-0x0000000189B75DB0
		public override void Update(ulong updateTick, float deltaTime) {} // 0x0000000187B0B9C0-0x0000000187B0C1D0
		// [XID] // 0x0000000189851B40-0x0000000189851B60
		public override void Vibrate(float leftMotor, float rightMotor) {} // 0x0000000187B0C1D0-0x0000000187B0C2E0
		// [XID] // 0x0000000189AE15D0-0x0000000189AE15F0
		internal void GetState() {} // 0x0000000187B0B730-0x0000000187B0B8A0
	}
}
