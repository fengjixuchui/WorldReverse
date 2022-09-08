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
	public sealed class InspectedProperty // TypeDefIndex: 4831
	{
		// Fields
		public string Name; // 0x18
		public string DisplayName; // 0x20
		private bool? _isPublicCache; // 0x28
		private bool? _isAutoPropertyCache; // 0x2A
		public System.Type StorageType; // 0x30
	
		// Properties
		public MemberInfo MemberInfo { get; private set; } // 0x0000000185CEF670-0x0000000185CEF6D0 0x0000000185CEF790-0x0000000185CEF7F0
		public bool IsPublic { get => default; } // 0x0000000185CEF3B0-0x0000000185CEF610 
		public bool IsAutoProperty { get => default; } // 0x0000000185CEF060-0x0000000185CEF3B0 
		public bool IsStatic { get; private set; } // 0x0000000185CEF610-0x0000000185CEF670 0x0000000185CEF730-0x0000000185CEF790
		public bool CanWrite { get; private set; } // 0x0000000185CEEF00-0x0000000185CEEF60 0x0000000185CEF6D0-0x0000000185CEF730
		public object DefaultValue { get => default; } // 0x0000000185CEEF60-0x0000000185CEF060 
	
		// Constructors
		public InspectedProperty() {} // Dummy constructor
		public InspectedProperty(PropertyInfo property) {} // 0x0000000185CEEBE0-0x0000000185CEED90
		public InspectedProperty(FieldInfo field) {} // 0x0000000185CEED90-0x0000000185CEEF00
	
		// Methods
		public void Write(object context, object value) {} // 0x0000000185CEE7C0-0x0000000185CEEBE0
		public object Read(object context) => default; // 0x0000000185CEE230-0x0000000185CEE620
		private void SetupNames() {} // 0x0000000185CEE620-0x0000000185CEE7C0
		public override bool Equals(object obj) => default; // 0x0000000185CEE0B0-0x0000000185CEE180
		public bool Equals(InspectedProperty p) => default; // 0x0000000185CEDFF0-0x0000000185CEE0B0
		public override int GetHashCode() => default; // 0x0000000185CEE180-0x0000000185CEE230
	}
}
