/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public class NativeInputDeviceManager : InputDeviceManager // TypeDefIndex: 7816
	{
		// Fields
		public static Func<NativeDeviceInfo, ReadOnlyCollection<NativeInputDevice>, NativeInputDevice> CustomFindDetachedDevice; // 0x00
		private List<NativeInputDevice> attachedDevices; // 0x18
		private List<NativeInputDevice> detachedDevices; // 0x20
		private List<NativeInputDeviceProfile> systemDeviceProfiles; // 0x28
		private List<NativeInputDeviceProfile> customDeviceProfiles; // 0x30
		private uint[] deviceEvents; // 0x38
	
		// Constructors
		public NativeInputDeviceManager() {} // 0x0000000188870310-0x00000001888705B0
	
		// Methods
		// [XID] // 0x00000001897C10D0-0x00000001897C10F0
		public override void Destroy() {} // 0x000000018886E960-0x000000018886EA00
		// [XID] // 0x00000001897C8A40-0x00000001897C8A60
		private uint NextPowerOfTwo(uint x) => default; // 0x000000018886F380-0x000000018886F450
		// [XID] // 0x00000001897D00D0-0x00000001897D00F0
		public override void Update(ulong updateTick, float deltaTime) {} // 0x000000018886FD50-0x0000000188870310
		// [XID] // 0x00000001897D7A00-0x00000001897D7A20
		private void DetectDevice(uint deviceHandle, NativeDeviceInfo deviceInfo) {} // 0x000000018886EB10-0x000000018886EE40
		// [XID] // 0x00000001896B3D90-0x00000001896B3DB0
		private void AttachDevice(NativeInputDevice device) {} // 0x000000018886E3B0-0x000000018886E4C0
		// [XID] // 0x00000001897E6940-0x00000001897E6960
		private void DetachDevice(NativeInputDevice device) {} // 0x000000018886EA00-0x000000018886EB10
		// [XID] // 0x00000001897EE290-0x00000001897EE2B0
		private NativeInputDevice FindAttachedDevice(uint deviceHandle) => default; // 0x000000018886F080-0x000000018886F200
		// [XID] // 0x00000001897F5A30-0x00000001897F5A50
		private NativeInputDevice FindDetachedDevice(NativeDeviceInfo deviceInfo) => default; // 0x000000018886F200-0x000000018886F380
		// [XID] // 0x0000000189696B90-0x0000000189696BB0
		private static NativeInputDevice SystemFindDetachedDevice(NativeDeviceInfo deviceInfo, ReadOnlyCollection<NativeInputDevice> detachedDevices) => default; // 0x000000018886F450-0x000000018886FCF0
		// [XID] // 0x0000000189804940-0x0000000189804960
		private void AddSystemDeviceProfile(NativeInputDeviceProfile deviceProfile) {} // 0x000000018886E120-0x000000018886E210
		// [XID] // 0x000000018980BE10-0x000000018980BE30
		private void AddSystemDeviceProfiles() {} // 0x000000018886E210-0x000000018886E3B0
		// [XID] // 0x0000000189813620-0x0000000189813640
		public static bool CheckPlatformSupport(ICollection<string> errors) => default; // 0x000000018886E4C0-0x000000018886E960
		// [XID] // 0x0000000189AF1750-0x0000000189AF1770
		internal static bool Enable() => default; // 0x000000018886EE40-0x000000018886F080
	}
}
