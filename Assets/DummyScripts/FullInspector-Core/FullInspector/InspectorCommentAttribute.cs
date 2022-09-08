/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	[AttributeUsage(AttributeTargets.All)] // 0x0000000189793000-0x0000000189793020
	public class InspectorCommentAttribute : Attribute, IInspectorAttributeOrder // TypeDefIndex: 4836
	{
		// Fields
		public string Comment; // 0x10
		public CommentType Type; // 0x18
		public double Order; // 0x20
	
		// Properties
		double IInspectorAttributeOrder.Order { get => default; } // 0x0000000185CF3E90-0x0000000185CF3F00 
	
		// Constructors
		public InspectorCommentAttribute() {} // Dummy constructor
		public InspectorCommentAttribute(string comment) {} // 0x0000000185CF3F00-0x0000000185CF3FB0
		public InspectorCommentAttribute(CommentType type, string comment) {} // 0x0000000185CF3FB0-0x0000000185CF4040
	}
}
