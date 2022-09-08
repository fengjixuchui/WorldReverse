/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public sealed class CustomController : ControllerWithAxes // TypeDefIndex: 3641
	{
		// Fields
		private int _sourceControllerId; // 0x148
		private Func<int, float> axisUpdateCallback; // 0x150
		private Func<int, bool> buttonUpdateCallback; // 0x158
		private bool useUpdateCallbacks; // 0x160
		private Guid _deviceInstanceGuid; // 0x164
	
		// Properties
		public int sourceControllerId { get => default; } // 0x0000000185D6A5B0-0x0000000185D6A610 
		public override Guid deviceInstanceGuid { get => default; } // 0x0000000185D6A490-0x0000000185D6A5B0 
	
		// Constructors
		public CustomController() {} // Dummy constructor
		internal CustomController(kSarBqLUpbjSYJYRRnTdWDHCPuD data) {} // 0x0000000185D69FF0-0x0000000185D6A150
		private CustomController(int controllerId, int sourceControllerId, Guid hardwareTypeGuid, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, int axisCount, int buttonCount, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater) {} // 0x0000000185D6A150-0x0000000185D6A490
	
		// Methods
		internal void FillData() {} // 0x0000000185D697C0-0x0000000185D699F0
		public void SetAxisValue(int index, float value) {} // 0x0000000185D69B00-0x0000000185D69CE0
		public void SetButtonValue(int index, bool value) {} // 0x0000000185D69DF0-0x0000000185D69FF0
		public void SetAxisUpdateCallback(Func<int, float> callback) {} // 0x0000000185D699F0-0x0000000185D69B00
		public void SetButtonUpdateCallback(Func<int, bool> callback) {} // 0x0000000185D69CE0-0x0000000185D69DF0
		public void ClearAxisValue(int index) {} // 0x0000000185D67810-0x0000000185D67A20
		public void ClearButtonValue(int index) {} // 0x0000000185D67A20-0x0000000185D67C40
	}
}
