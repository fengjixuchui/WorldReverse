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
	public sealed class ControllerMapLayoutManager_Rule_Editor : IDeepCloneable // TypeDefIndex: 4125
	{
		// Fields
		[Serialize] // 0x0000000189928BD0-0x0000000189928C00
		[SerializeField] // 0x0000000189928BD0-0x0000000189928C00
		private string _tag; // 0x10
		[Serialize] // 0x00000001899A3E40-0x00000001899A3E70
		[SerializeField] // 0x00000001899A3E40-0x00000001899A3E70
		private List<int> _categoryIds; // 0x18
		[Serialize] // 0x0000000189928BD0-0x0000000189928C00
		[SerializeField] // 0x0000000189928BD0-0x0000000189928C00
		private int _layoutId; // 0x20
		[Serialize] // 0x0000000189928BD0-0x0000000189928C00
		[SerializeField] // 0x0000000189928BD0-0x0000000189928C00
		private ControllerSetSelector_Editor _controllerSetSelector; // 0x28
	
		// Constructors
		public ControllerMapLayoutManager_Rule_Editor() {} // 0x0000000185D5B1A0-0x0000000185D5B2C0
		public ControllerMapLayoutManager_Rule_Editor(ControllerMapLayoutManager_Rule_Editor source) {} // 0x0000000185D5B0A0-0x0000000185D5B1A0
	
		// Methods
		internal ControllerMapLayoutManager.Rule ToRuntime() => default; // 0x0000000185D5AFA0-0x0000000185D5B0A0
		object IDeepCloneable.DeepClone() => default; // 0x0000000185D5AF20-0x0000000185D5AFA0
	}
}
