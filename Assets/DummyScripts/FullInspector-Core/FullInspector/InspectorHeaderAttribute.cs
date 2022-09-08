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
	public class InspectorHeaderAttribute : Attribute, IInspectorAttributeOrder // TypeDefIndex: 4839
	{
		// Fields
		public double Order; // 0x10
		public string Header; // 0x18
	
		// Properties
		double IInspectorAttributeOrder.Order { get => default; } // 0x0000000185CF42C0-0x0000000185CF4330 
	
		// Constructors
		public InspectorHeaderAttribute() {} // Dummy constructor
		public InspectorHeaderAttribute(string header) {} // 0x0000000185CF4330-0x0000000185CF43B0
	}
}
