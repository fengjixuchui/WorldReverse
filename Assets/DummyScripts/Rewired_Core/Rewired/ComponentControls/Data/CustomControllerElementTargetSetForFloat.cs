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
	[CustomClassObfuscation] // 0x0000000189990060-0x00000001899900B0
	public class CustomControllerElementTargetSetForFloat : CustomControllerElementTargetSet // TypeDefIndex: 3538
	{
		// Fields
		[CustomObfuscation] // 0x000000018999AE30-0x000000018999AE90
		[SerializeField] // 0x000000018999AE30-0x000000018999AE90
		// [Tooltip] // 0x000000018999AE30-0x000000018999AE90
		private bool _splitValue; // 0x10
		[CustomObfuscation] // 0x00000001899A9FA0-0x00000001899AA000
		[SerializeField] // 0x00000001899A9FA0-0x00000001899AA000
		// [Tooltip] // 0x00000001899A9FA0-0x00000001899AA000
		private CustomControllerElementTarget _target; // 0x18
		[CustomObfuscation] // 0x00000001899B8CF0-0x00000001899B8D50
		[SerializeField] // 0x00000001899B8CF0-0x00000001899B8D50
		// [Tooltip] // 0x00000001899B8CF0-0x00000001899B8D50
		private CustomControllerElementTarget _positiveTarget; // 0x20
		[CustomObfuscation] // 0x00000001899C7E40-0x00000001899C7EA0
		[SerializeField] // 0x00000001899C7E40-0x00000001899C7EA0
		// [Tooltip] // 0x00000001899C7E40-0x00000001899C7EA0
		private CustomControllerElementTarget _negativeTarget; // 0x28
	
		// Properties
		public bool splitValue { get => default; } // 0x0000000185AA1CC0-0x0000000185AA1D20 
		public CustomControllerElementTarget target { get => default; } // 0x0000000185AA1D90-0x0000000185AA1DF0 
		public CustomControllerElementTarget positiveTarget { get => default; } // 0x0000000185AA1C60-0x0000000185AA1CC0 
		public CustomControllerElementTarget negativeTarget { get => default; } // 0x0000000185AA1C00-0x0000000185AA1C60 
		internal override int targetCount { get => default; } // 0x0000000185AA1D20-0x0000000185AA1D90 
		internal override CustomControllerElementTarget this[int index] { get => default; } // 0x0000000185AA1AE0-0x0000000185AA1C00 
	
		// Constructors
		internal CustomControllerElementTargetSetForFloat() {} // 0x0000000185AA1480-0x0000000185AA17A0
		internal CustomControllerElementTargetSetForFloat(CustomControllerElementTarget target) {} // 0x0000000185AA17A0-0x0000000185AA1AE0
	
		// Methods
		internal override void ClearElementCaches() {} // 0x0000000185AA1410-0x0000000185AA1480
	}
}
