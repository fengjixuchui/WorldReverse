/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	[AttributeUsage(AttributeTargets.All)] // 0x00000001897DBF20-0x00000001897DBF40
	public class InspectorMarginAttribute : Attribute, IInspectorAttributeOrder // TypeDefIndex: 4842
	{
		// Fields
		public int Margin; // 0x10
		public double Order; // 0x18
	
		// Properties
		double IInspectorAttributeOrder.Order { get => default; } // 0x0000000185CF4680-0x0000000185CF46F0 
	
		// Constructors
		public InspectorMarginAttribute() {} // Dummy constructor
		public InspectorMarginAttribute(int margin) {} // 0x0000000185CF46F0-0x0000000185CF4760
	}
}
