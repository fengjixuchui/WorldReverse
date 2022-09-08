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
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001898B7860-0x00000001898B78A0
	[Preserve] // 0x00000001898B7860-0x00000001898B78A0
	public sealed class ControllerMapEnabler_Rule_Editor : IDeepCloneable // TypeDefIndex: 4119
	{
		// Fields
		[Serialize] // 0x00000001899A3E40-0x00000001899A3E70
		[SerializeField] // 0x00000001899A3E40-0x00000001899A3E70
		private string _tag; // 0x10
		[Serialize] // 0x0000000189928BD0-0x0000000189928C00
		[SerializeField] // 0x0000000189928BD0-0x0000000189928C00
		private bool _enable; // 0x18
		[Serialize] // 0x00000001899A3E40-0x00000001899A3E70
		[SerializeField] // 0x00000001899A3E40-0x00000001899A3E70
		private List<int> _categoryIds; // 0x20
		[Serialize] // 0x00000001899A3E40-0x00000001899A3E70
		[SerializeField] // 0x00000001899A3E40-0x00000001899A3E70
		private List<int> _layoutIds; // 0x28
		[Serialize] // 0x0000000189928BD0-0x0000000189928C00
		[SerializeField] // 0x0000000189928BD0-0x0000000189928C00
		private ControllerSetSelector_Editor _controllerSetSelector; // 0x30
	
		// Constructors
		public ControllerMapEnabler_Rule_Editor() {} // 0x0000000185D5A9E0-0x0000000185D5AB20
		public ControllerMapEnabler_Rule_Editor(ControllerMapEnabler_Rule_Editor source) {} // 0x0000000185D5AB20-0x0000000185D5AC40
	
		// Methods
		internal ControllerMapEnabler.Rule ToRuntime() => default; // 0x0000000185D5A8A0-0x0000000185D5A9E0
		object IDeepCloneable.DeepClone() => default; // 0x0000000185D5A820-0x0000000185D5A8A0
	}
}
