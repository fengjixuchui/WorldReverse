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
	public class OuyaEverywhereDevice : InputDevice // TypeDefIndex: 7585
	{
		// Fields
		private const float LowerDeadZone = 0.2f; // Metadata: 0x00ADED62
		private const float UpperDeadZone = 0.9f; // Metadata: 0x00ADED66
	
		// Properties
		public int DeviceIndex { get; private set; } // 0x0000000187EF8D10-0x0000000187EF8D70 0x0000000187EF8E10-0x0000000187EF8E80
		public bool IsConnected { /* [XID] */ /* 0x0000000189AC3070-0x0000000189AC3090 */ get => default; } // 0x0000000187EF8D70-0x0000000187EF8E10 
	
		// Constructors
		public OuyaEverywhereDevice() {} // Dummy constructor
		public OuyaEverywhereDevice(int deviceIndex) {} // 0x0000000187EF89E0-0x0000000187EF8D10
	
		// Methods
		// [XID] // 0x0000000189902680-0x00000001899026A0
		public void BeforeAttach() {} // 0x0000000187EF87F0-0x0000000187EF8890
		// [XID] // 0x0000000189ABB8D0-0x0000000189ABB8F0
		public override void Update(ulong updateTick, float deltaTime) {} // 0x0000000187EF8920-0x0000000187EF89E0
	}
}
