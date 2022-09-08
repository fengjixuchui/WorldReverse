/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Data;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class ControllerMap_Editor // TypeDefIndex: 4145
	{
		// Fields
		public int id; // 0x10
		public int categoryId; // 0x14
		public int layoutId; // 0x18
		public string name; // 0x20
		public string hardwareGuidString; // 0x28
		public int customControllerUid; // 0x30
		public List<ActionElementMap> actionElementMaps; // 0x38
	
		// Properties
		public Guid hardwareGuid { get => default; } // 0x00000001869B6810-0x00000001869B68B0 
	
		// Constructors
		public ControllerMap_Editor() {} // 0x00000001869B6780-0x00000001869B6810
	
		// Methods
		public ControllerMap_Editor Clone() => default; // 0x00000001869B5520-0x00000001869B5730
		internal JoystickMap TyUTxlDNKLwRFZInoPVPjtZOZoL(Func<int, bool> param_00008a70, HardwareControllerMapIdentifier param_00008a71, HardwareJoystickMap param_00008a72, bool param_00008a73) => default; // 0x00000001869B6570-0x00000001869B6690
		internal KeyboardMap SdulnsJvJXcicAJaRRIxFADCpHO(Func<int, bool> param_00008a74) => default; // 0x00000001869B6480-0x00000001869B6570
		internal MouseMap ZuyHHsYuJPhMvykrNfAaAsRJVhK(Func<int, bool> param_00008a75) => default; // 0x00000001869B6690-0x00000001869B6780
		internal CustomControllerMap tWxTCuxQtTvCiNyEQtHSPhPKIKL(Func<int, bool> param_00008a76, CustomController_Editor param_00008a77) => default; // 0x00000001869B68B0-0x00000001869B6990
		private void FBOEnJucvmQAxhIxjRxTRPyKeDK(Func<int, bool> param_00008a78, ControllerMap param_00008a79, HardwareControllerMapIdentifier param_00008a7a, HardwareJoystickMap param_00008a7b, bool param_00008a7c) {} // 0x00000001869B5730-0x00000001869B5E10
		private void IRjODmJcqADnuKUkyMgZgJVwRXhh(Func<int, bool> param_00008a7d, InputSource param_00008a7e, CustomControllerMap param_00008a7f, CustomController_Editor param_00008a80) {} // 0x00000001869B5E10-0x00000001869B6480
	}
}
