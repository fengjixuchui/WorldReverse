/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	[AttributeUsage(AttributeTargets.All)] // 0x0000000189787340-0x0000000189787390
	[Obsolete] // 0x0000000189787340-0x0000000189787390
	public class CommentAttribute : Attribute, IInspectorAttributeOrder // TypeDefIndex: 4834
	{
		// Fields
		public string Comment; // 0x10
		public CommentType Type; // 0x18
		public double Order; // 0x20
	
		// Properties
		double IInspectorAttributeOrder.Order { get => default; } // 0x0000000185CE9D40-0x0000000185CE9DB0 
	
		// Constructors
		public CommentAttribute() {} // Dummy constructor
		public CommentAttribute(string comment) {} // 0x0000000185CE9DB0-0x0000000185CE9E30
		public CommentAttribute(CommentType type, string comment) {} // 0x0000000185CE9E30-0x0000000185CE9EC0
	}
}
