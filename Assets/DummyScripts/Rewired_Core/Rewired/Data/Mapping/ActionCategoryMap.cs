/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class ActionCategoryMap // TypeDefIndex: 3758
	{
		// Fields
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private List<Entry> list; // 0x10
	
		// Nested types
		[Serializable]
		public class Entry // TypeDefIndex: 3759
		{
			// Fields
			public int categoryId; // 0x10
			public List<int> actionIds; // 0x18
	
			// Properties
			public IEnumerable<int> ActionIds { get => default; } // 0x0000000185D6AB60-0x0000000185D6AC00 
	
			// Constructors
			public Entry() {} // 0x0000000185D6AA60-0x0000000185D6AAF0
			public Entry(int categoryId) {} // 0x0000000185D6AAF0-0x0000000185D6AB60
		}
	
		// Constructors
		public ActionCategoryMap() {} // 0x0000000185D54520-0x0000000185D545B0
	
		// Methods
		public IEnumerable<int> ActionIdsInCategory(int categoryId) => default; // 0x0000000185D54290-0x0000000185D54330
		public void AddCategory(int id) {} // 0x0000000185D54330-0x0000000185D54420
		public int IndexOfCategory(int id) => default; // 0x0000000185D54420-0x0000000185D54520
	}
}
