/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001899D6C00-0x00000001899D6C30
	public class CustomControllerElementTarget // TypeDefIndex: 3534
	{
		// Fields
		[CustomObfuscation] // 0x0000000189916C70-0x0000000189916CD0
		[SerializeField] // 0x0000000189916C70-0x0000000189916CD0
		// [Tooltip] // 0x0000000189916C70-0x0000000189916CD0
		private CustomControllerElementSelector _element; // 0x10
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private ValueRange _valueRange; // 0x18
		[CustomObfuscation] // 0x0000000189930150-0x00000001899301B0
		[SerializeField] // 0x0000000189930150-0x00000001899301B0
		// [Tooltip] // 0x0000000189930150-0x00000001899301B0
		private Pole _valueContribution; // 0x1C
		[CustomObfuscation] // 0x000000018993F0E0-0x000000018993F140
		[SerializeField] // 0x000000018993F0E0-0x000000018993F140
		// [Tooltip] // 0x000000018993F0E0-0x000000018993F140
		private bool _invert; // 0x20
	
		// Properties
		public CustomControllerElementSelector element { get => default; } // 0x0000000185AA2060-0x0000000185AA20C0 
		public Pole valueContribution { get => default; set {} } // 0x0000000185AA2120-0x0000000185AA2180 0x0000000185AA21E0-0x0000000185AA2240
		internal ValueRange valueRange { get => default; set {} } // 0x0000000185AA2180-0x0000000185AA21E0 0x0000000185AA2240-0x0000000185AA22A0
		public bool invert { get => default; } // 0x0000000185AA20C0-0x0000000185AA2120 
	
		// Nested types
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal enum ValueRange // TypeDefIndex: 3535
		{
			Full = 0,
			Positive = 1,
			Negative = 2
		}
	
		// Constructors
		internal CustomControllerElementTarget() {} // 0x0000000185AA1EF0-0x0000000185AA1FA0
		internal CustomControllerElementTarget(CustomControllerElementSelector selector) {} // 0x0000000185AA1FA0-0x0000000185AA2060
	
		// Methods
		internal void ClearElementCaches() {} // 0x0000000185AA1E50-0x0000000185AA1EF0
	}
}
