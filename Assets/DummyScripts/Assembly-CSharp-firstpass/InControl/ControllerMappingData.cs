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
	[Serializable]
	public class ControllerMappingData // TypeDefIndex: 7592
	{
		// Fields
		public InputDeviceStyle deviceStyle; // 0x10
		private Dictionary<int, ControllerElementMap> _mapDic; // 0x18
		public List<ControllerElementMap> elementMaps; // 0x20
	
		// Constructors
		public ControllerMappingData() {} // 0x0000000187DAC020-0x0000000187DAC0C0
	
		// Methods
		// [XID] // 0x0000000189ADB1F0-0x0000000189ADB210
		public void BuildIndex() {} // 0x0000000187DAB9E0-0x0000000187DABBD0
		// [XID] // 0x0000000189AE28E0-0x0000000189AE2900
		public void AddMap(int actionID, InputControlType element) {} // 0x0000000187DAB8A0-0x0000000187DAB9E0
		// [IDTag] // 0x0000000189AFF770-0x0000000189AFF7B0
		// [XID] // 0x0000000189AFF770-0x0000000189AFF7B0
		public void UpdateMap(int actionID, InputControlType element) {} // 0x0000000187DABE50-0x0000000187DAC020
		// [IDTag] // 0x0000000189B09EB0-0x0000000189B09EF0
		// [XID] // 0x0000000189B09EB0-0x0000000189B09EF0
		public void UpdateMap(int actionID, ControllerElementMap map) {} // 0x0000000187DABCB0-0x0000000187DABE50
		// [XID] // 0x0000000189B14290-0x0000000189B142B0
		public bool TryGetMap(int actionID, out ControllerElementMap map) {
			map = default;
			return default;
		} // 0x0000000187DABBD0-0x0000000187DABCB0
	}
}
