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
using Rewired.Utils.Attributes;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001899D6C00-0x00000001899D6C30
	public sealed class CustomControllerElementSelector // TypeDefIndex: 3539
	{
		// Fields
		[CustomObfuscation] // 0x00000001899DE140-0x00000001899DE1A0
		[SerializeField] // 0x00000001899DE140-0x00000001899DE1A0
		// [Tooltip] // 0x00000001899DE140-0x00000001899DE1A0
		private ElementType _elementType; // 0x10
		[CustomObfuscation] // 0x00000001899ED100-0x00000001899ED160
		[SerializeField] // 0x00000001899ED100-0x00000001899ED160
		// [Tooltip] // 0x00000001899ED100-0x00000001899ED160
		private SelectorType _selectorType; // 0x14
		[CustomObfuscation] // 0x00000001899FC350-0x00000001899FC3B0
		[SerializeField] // 0x00000001899FC350-0x00000001899FC3B0
		// [Tooltip] // 0x00000001899FC350-0x00000001899FC3B0
		private string _elementName; // 0x18
		[CustomObfuscation] // 0x0000000189A0AE00-0x0000000189A0AE80
		// [FieldRange] // 0x0000000189A0AE00-0x0000000189A0AE80
		[SerializeField] // 0x0000000189A0AE00-0x0000000189A0AE80
		// [Tooltip] // 0x0000000189A0AE00-0x0000000189A0AE80
		private int _elementIndex; // 0x20
		[CustomObfuscation] // 0x0000000189A1C890-0x0000000189A1C910
		// [FieldRange] // 0x0000000189A1C890-0x0000000189A1C910
		[SerializeField] // 0x0000000189A1C890-0x0000000189A1C910
		// [Tooltip] // 0x0000000189A1C890-0x0000000189A1C910
		private int _elementId; // 0x24
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		private int WhtgVNHjOtdqEbyRkoIvbSSWheqT; // 0x28
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		private int WlyPqvmSKKSpkCanggOqCXcYbUtk; // 0x2C
	
		// Properties
		public ElementType elementType { get => default; set {} } // 0x0000000185AA0E20-0x0000000185AA0E80 0x0000000185AA1010-0x0000000185AA10B0
		public SelectorType selectorType { get => default; } // 0x0000000185AA0FB0-0x0000000185AA1010 
		public string elementName { get => default; } // 0x0000000185AA0DC0-0x0000000185AA0E20 
		public int elementIndex { get => default; } // 0x0000000185AA0D60-0x0000000185AA0DC0 
		public int elementId { get => default; } // 0x0000000185AA0D00-0x0000000185AA0D60 
		public bool isAssigned { get => default; } // 0x0000000185AA0E80-0x0000000185AA0FB0 
	
		// Nested types
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public enum ElementType // TypeDefIndex: 3540
		{
			Axis = 0,
			Button = 1
		}
	
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public enum SelectorType // TypeDefIndex: 3541
		{
			Name = 0,
			Index = 1,
			Id = 2
		}
	
		// Constructors
		public CustomControllerElementSelector() {} // 0x0000000185AA0C80-0x0000000185AA0D00
	
		// Methods
		public int GetElementIndex(CustomController customController) => default; // 0x0000000185AA05E0-0x0000000185AA09F0
		public string GetSelectorFormattedString() => default; // 0x0000000185AA09F0-0x0000000185AA0BA0
		private IList<ControllerElementIdentifier> TDbQJhgSJbtFTTCZMuhhvoRYbpL(CustomController param_00007d99, ElementType param_00007d9a) => default; // 0x0000000185AA0BA0-0x0000000185AA0C80
		public void ClearCache() {} // 0x0000000185AA0580-0x0000000185AA05E0
	}
}
