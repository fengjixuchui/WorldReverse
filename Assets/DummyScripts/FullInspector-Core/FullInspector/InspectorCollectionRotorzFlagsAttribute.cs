/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FullInspector.Rotorz.ReorderableList;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	[AttributeUsage(AttributeTargets.All)] // 0x00000001897DBF20-0x00000001897DBF40
	public sealed class InspectorCollectionRotorzFlagsAttribute : Attribute // TypeDefIndex: 4851
	{
		// Fields
		public ReorderableListFlags Flags; // 0x10
	
		// Properties
		public bool DisableReordering { get => default; set {} } // 0x0000000185CF3880-0x0000000185CF3920 0x0000000185CF3B00-0x0000000185CF3BB0
		public bool HideAddButton { get => default; set {} } // 0x0000000185CF3920-0x0000000185CF39C0 0x0000000185CF3BB0-0x0000000185CF3C60
		public bool HideRemoveButtons { get => default; set {} } // 0x0000000185CF39C0-0x0000000185CF3A60 0x0000000185CF3C60-0x0000000185CF3D10
		public bool ShowIndices { get => default; set {} } // 0x0000000185CF3A60-0x0000000185CF3B00 0x0000000185CF3D10-0x0000000185CF3DC0
	
		// Constructors
		public InspectorCollectionRotorzFlagsAttribute() {} // 0x0000000185CF3820-0x0000000185CF3880
	
		// Methods
		private void UpdateFlag(bool shouldSet, ReorderableListFlags flag) {} // 0x0000000185CF37A0-0x0000000185CF3820
		private bool HasFlag(ReorderableListFlags flag) => default; // 0x0000000185CF3730-0x0000000185CF37A0
	}
}
