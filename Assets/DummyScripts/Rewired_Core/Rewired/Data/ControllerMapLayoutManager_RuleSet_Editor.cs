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
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001898461E0-0x0000000189846220
	[Preserve] // 0x00000001898461E0-0x0000000189846220
	public sealed class ControllerMapLayoutManager_RuleSet_Editor // TypeDefIndex: 4124
	{
		// Fields
		[Serialize] // 0x0000000189928BD0-0x0000000189928C00
		[SerializeField] // 0x0000000189928BD0-0x0000000189928C00
		private int _id; // 0x10
		[Serialize] // 0x0000000189928BD0-0x0000000189928C00
		[SerializeField] // 0x0000000189928BD0-0x0000000189928C00
		private string _name; // 0x18
		[Serialize] // 0x00000001899A3E40-0x00000001899A3E70
		[SerializeField] // 0x00000001899A3E40-0x00000001899A3E70
		private string _tag; // 0x20
		[Serialize] // 0x00000001899A3E40-0x00000001899A3E70
		[SerializeField] // 0x00000001899A3E40-0x00000001899A3E70
		private List<ControllerMapLayoutManager_Rule_Editor> _rules; // 0x28
	
		// Properties
		public int id { get => default; } // 0x0000000185D5AEC0-0x0000000185D5AF20 
	
		// Constructors
		public ControllerMapLayoutManager_RuleSet_Editor() {} // 0x0000000185D5AE30-0x0000000185D5AEC0
	
		// Methods
		internal ControllerMapLayoutManager.RuleSet ToRuntime() => default; // 0x0000000185D5AC40-0x0000000185D5AE30
	}
}
