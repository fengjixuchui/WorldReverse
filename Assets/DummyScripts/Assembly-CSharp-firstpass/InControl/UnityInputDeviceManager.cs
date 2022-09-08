/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class UnityInputDeviceManager : InputDeviceManager // TypeDefIndex: 7993
	{
		// Fields
		private const float deviceRefreshInterval = 1f; // Metadata: 0x00ADF3AF
		private float deviceRefreshTimer; // 0x18
		private readonly List<UnityInputDeviceProfileBase> systemDeviceProfiles; // 0x20
		private readonly List<UnityInputDeviceProfileBase> customDeviceProfiles; // 0x28
		private string[] joystickNames; // 0x30
		private int lastJoystickCount; // 0x38
		private int lastJoystickHash; // 0x3C
		private int joystickCount; // 0x40
		private int joystickHash; // 0x44
	
		// Properties
		private bool JoystickInfoHasChanged { /* [XID] */ /* 0x00000001899C38A0-0x00000001899C38C0 */ get => default; } // 0x0000000187AF9BB0-0x0000000187AF9C60 
	
		// Constructors
		public UnityInputDeviceManager() {} // 0x0000000187AF9A90-0x0000000187AF9BB0
	
		// Methods
		// [XID] // 0x00000001899A6BF0-0x00000001899A6C10
		public override void Update(ulong updateTick, float deltaTime) {} // 0x0000000187AF9970-0x0000000187AF9A90
		// [XID] // 0x00000001899BBCC0-0x00000001899BBCE0
		private void QueryJoystickInfo() {} // 0x0000000187AF9750-0x0000000187AF98B0
		// [XID] // 0x0000000189944CB0-0x0000000189944CD0
		private void AttachDevices() {} // 0x0000000187AF84D0-0x0000000187AF8590
		// [XID] // 0x0000000189AAC0B0-0x0000000189AAC0D0
		private void DetachDevices() {} // 0x0000000187AF8840-0x0000000187AF8990
		// [XID] // 0x00000001899BD2E0-0x00000001899BD300
		public void ReloadDevices() {} // 0x0000000187AF98B0-0x0000000187AF9970
		// [XID] // 0x00000001899E1180-0x00000001899E11A0
		private void AttachDevice(UnityInputDevice device) {} // 0x0000000187AF83E0-0x0000000187AF84D0
		// [XID] // 0x000000018994C2E0-0x000000018994C300
		private void AttachKeyboardDevices() {} // 0x0000000187AF86D0-0x0000000187AF8840
		// [XID] // 0x00000001899F0440-0x00000001899F0460
		private void AttachJoystickDevices() {} // 0x0000000187AF8590-0x0000000187AF86D0
		// [XID] // 0x0000000189980920-0x0000000189980940
		private bool HasAttachedDeviceWithJoystickId(int unityJoystickId) => default; // 0x0000000187AF95E0-0x0000000187AF9750
		// [XID] // 0x0000000189A2C940-0x0000000189A2C960
		private void DetectJoystickDevice(int unityJoystickId, string unityJoystickName) {} // 0x0000000187AF8990-0x0000000187AF95E0
		// [XID] // 0x00000001899C4CD0-0x00000001899C4CF0
		private void AddSystemDeviceProfile(UnityInputDeviceProfile deviceProfile) {} // 0x0000000187AF8150-0x0000000187AF8240
		// [XID] // 0x0000000189A0DF20-0x0000000189A0DF40
		private void AddSystemDeviceProfiles() {} // 0x0000000187AF8240-0x0000000187AF83E0
	}
}
