/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Interfaces;
using Rewired.Internal;
using Rewired.Libraries.SharpDX.DirectInput;
using Rewired.Platforms;
using Rewired.Utils.Classes.Utility;

// Image 49: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5537-5827

namespace Rewired.Dev.Tools
{
	internal sealed class DirectInputJoystickElementIdentifier_Internal : IElementIdentifierTool // TypeDefIndex: 5823
	{
		// Fields
		private GUIText text; // 0x10
		private string textBuffer; // 0x18
		private int currentDeviceId; // 0x20
		private DirectInput fTUmdlBklWTlvmAQYJjrEkdriSN; // 0x28
		private hCkwWPjbZHHQuLPwssAiovZoKVX PSZKcVVfVmWuwyrmRaPnqSTTRBB; // 0x30
		private Guid deviceInstanceGuid; // 0x38
		private IList<rrkiWNHnEkzBYEXAvbDAWsEtjKd> TrlMVMJnBEgzUCjZPEEWgkjzDUkL; // 0x48
		private IList<rrkiWNHnEkzBYEXAvbDAWsEtjKd> VQkWWQYcJVRbcBsWaSxsFRAHwlN; // 0x50
		private bool showAllDevices; // 0x58
		private bool refreshNow; // 0x59
		private bool ready; // 0x5A
		private int rawDeviceCount; // 0x5C
		private TimerRealTime BAQCuUxBdKKwqZqjVZdkRBTPwCh; // 0x60
	
		// Constructors
		public DirectInputJoystickElementIdentifier_Internal() {} // 0x0000000183E837F0-0x0000000183E83850
	
		// Methods
		public void Initialize(GUIText text) {} // 0x0000000183E81220-0x0000000183E81280
		public void Start() {} // 0x0000000183E81C20-0x0000000183E81F00
		public void Update() {} // 0x0000000183E82100-0x0000000183E837F0
		private void UpdateDeviceList() {} // 0x0000000183E82040-0x0000000183E82100
		private void SystemDeviceConnected() {} // 0x0000000183E81F00-0x0000000183E81FA0
		private void SystemDeviceDisconnected() {} // 0x0000000183E81FA0-0x0000000183E82040
		private void Refresh() {} // 0x0000000183E81BB0-0x0000000183E81C20
		private void Clear() {} // 0x0000000183E81170-0x0000000183E81220
		private void Log(string key, object value) {} // 0x0000000183E81280-0x0000000183E814F0
		private int QkOJeQjNoGuvJJcCjzkxhFnepjH(DirectInputAxis param_0000b625, POJetljaOyAGVgWkwdAAfDSJZTf param_0000b626) => default; // 0x0000000183E81630-0x0000000183E81BB0
		private float NormalizeAxis(int value) => default; // 0x0000000183E814F0-0x0000000183E815C0
		public void OnDestroy() {} // 0x0000000183E815C0-0x0000000183E81630
	}
}
