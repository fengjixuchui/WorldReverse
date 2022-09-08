/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data.Mapping
{
	[Serializable]
	public class HardwareButtonInfo : IDeepCloneable // TypeDefIndex: 3944
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		internal bool _excludeFromPolling; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		internal bool _isPressureSensitive; // 0x11
	
		// Properties
		public bool excludeFromPolling { get => default; } // 0x00000001869BBB40-0x00000001869BBBA0 
		public bool isPressureSensitive { get => default; } // 0x00000001869BBBA0-0x00000001869BBC00 
	
		// Constructors
		public HardwareButtonInfo() {} // 0x00000001869BBAD0-0x00000001869BBB40
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal HardwareButtonInfo(bool excludeFromPolling, bool isPressureSensitive) {} // 0x00000001869BBA40-0x00000001869BBAD0
	
		// Methods
		public object DeepClone() => default; // 0x00000001869BB9A0-0x00000001869BBA40
	}
}
