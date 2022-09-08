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
	public class HardwareAxisInfo : IDeepCloneable // TypeDefIndex: 3943
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		internal AxisCoordinateMode _dataFormat; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		internal bool _excludeFromPolling; // 0x14
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		internal SpecialAxisType _specialAxisType; // 0x18
	
		// Properties
		public AxisCoordinateMode dataFormat { get => default; } // 0x00000001869BB880-0x00000001869BB8E0 
		public bool excludeFromPolling { get => default; } // 0x00000001869BB8E0-0x00000001869BB940 
		public SpecialAxisType specialAxisType { get => default; } // 0x00000001869BB940-0x00000001869BB9A0 
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal static HardwareAxisInfo Default { get => default; } // 0x00000001869BB800-0x00000001869BB880 
	
		// Constructors
		public HardwareAxisInfo() {} // 0x00000001869BB790-0x00000001869BB800
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal HardwareAxisInfo(AxisCoordinateMode dataFormat, bool excludeFromPolling, SpecialAxisType specialAxisType) {} // 0x00000001869BB6D0-0x00000001869BB790
	
		// Methods
		public object DeepClone() => default; // 0x00000001869BB630-0x00000001869BB6D0
	}
}
