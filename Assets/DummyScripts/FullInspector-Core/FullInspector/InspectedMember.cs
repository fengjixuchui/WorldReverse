/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector
{
	public struct InspectedMember // TypeDefIndex: 4822
	{
		// Fields
		private InspectedProperty _property; // 0x00
		private InspectedMethod _method; // 0x08
	
		// Properties
		public InspectedProperty Property { get => default; } // 0x0000000185CED770-0x0000000185CED7A0 
		public InspectedMethod Method { get => default; } // 0x0000000185CED5E0-0x0000000185CED680 
		public bool IsMethod { get => default; } // 0x0000000185CED2F0-0x0000000185CED350 
		public bool IsProperty { get => default; } // 0x0000000185CED350-0x0000000185CED4F0 
		public string Name { get => default; } // 0x0000000185CED680-0x0000000185CED770 
		public MemberInfo MemberInfo { get => default; } // 0x0000000185CED4F0-0x0000000185CED5E0 
	
		// Constructors
		public InspectedMember(InspectedProperty property) : this() {
			_property = default;
			_method = default;
		} // 0x0000000185CED280-0x0000000185CED2F0
		public InspectedMember(InspectedMethod method) : this() {
			_property = default;
			_method = default;
		} // 0x0000000185CED210-0x0000000185CED280
	}
}
