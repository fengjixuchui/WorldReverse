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
using Rewired.Platforms;

// Image 49: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5537-5827

namespace Rewired.Dev.Tools
{
	internal sealed class RawInputJoystickElementIdentifier_Internal : IElementIdentifierTool // TypeDefIndex: 5824
	{
		// Fields
		private GUIText text; // 0x10
		private string textBuffer; // 0x18
		private int currentDeviceId; // 0x20
		private ToVVOkLlyfGfCymNVHdVmAohoaz oAncdCDeuarlyAVWrkNljduAgRv; // 0x28
		private IQFNbAfLsEWvVnPpdRQbxxyYJpW PSZKcVVfVmWuwyrmRaPnqSTTRBB; // 0x30
		private Guid deviceInstanceGuid; // 0x38
		private IList<IQFNbAfLsEWvVnPpdRQbxxyYJpW> TrlMVMJnBEgzUCjZPEEWgkjzDUkL; // 0x48
		private bool showAllDevices; // 0x50
		private bool refreshNow; // 0x51
		private bool ready; // 0x52
		private string[] axisNames; // 0x58
		private int[] axisValues; // 0x60
	
		// Constructors
		public RawInputJoystickElementIdentifier_Internal() {} // 0x0000000183E8DB60-0x0000000183E8DBC0
	
		// Methods
		public void Initialize(GUIText text) {} // 0x0000000183E8A280-0x0000000183E8A3B0
		public void Start() {} // 0x0000000183E8AAD0-0x0000000183E8AD50
		public void Update() {} // 0x0000000183E8AF10-0x0000000183E8DB60
		public void OnDestroy() {} // 0x0000000183E8A960-0x0000000183E8A9D0
		private void UpdateDeviceList() {} // 0x0000000183E8AE90-0x0000000183E8AF10
		private void SystemDeviceConnected() {} // 0x0000000183E8AD50-0x0000000183E8ADF0
		private void SystemDeviceDisconnected() {} // 0x0000000183E8ADF0-0x0000000183E8AE90
		private void Refresh() {} // 0x0000000183E8AA60-0x0000000183E8AAD0
		private void Clear() {} // 0x0000000183E8A1D0-0x0000000183E8A280
		private void Log(string key, object value) {} // 0x0000000183E8A620-0x0000000183E8A890
		private void LogSet(string label, object value) {} // 0x0000000183E8A3B0-0x0000000183E8A620
		private int QkOJeQjNoGuvJJcCjzkxhFnepjH(RawInputAxis param_0000b62d, int param_0000b62e, aXvsRAkEsCpkQyhsfGemHvAYTiJM param_0000b62f) => default; // 0x0000000183E8A9D0-0x0000000183E8AA60
		private float NormalizeAxis(int value) => default; // 0x0000000183E8A890-0x0000000183E8A960
	}
}
