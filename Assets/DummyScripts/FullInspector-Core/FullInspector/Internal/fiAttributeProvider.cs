/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullInspector.Internal
{
	public class fiAttributeProvider : MemberInfo // TypeDefIndex: 4971
	{
		// Fields
		private readonly object[] _attributes; // 0x10
	
		// Properties
		public override System.Type DeclaringType { get => default; } // 0x0000000185CFB130-0x0000000185CFB1A0 
		public override MemberTypes MemberType { get => default; } // 0x0000000185CFB1A0-0x0000000185CFB210 
		public override string Name { get => default; } // 0x0000000185CFB210-0x0000000185CFB280 
		public override System.Type ReflectedType { get => default; } // 0x0000000185CFB280-0x0000000185CFB2F0 
	
		// Constructors
		public fiAttributeProvider() {} // Dummy constructor
		private fiAttributeProvider(object[] attributes) {} // 0x0000000185CFB0C0-0x0000000185CFB130
	
		// Methods
		public static MemberInfo Create(params /* 0x000000018989F6F0-0x000000018989F700 */ object[] attributes) => default; // 0x0000000185CFAD20-0x0000000185CFADE0
		public override object[] GetCustomAttributes(bool inherit) => default; // 0x0000000185CFADE0-0x0000000185CFAE40
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) => default; // 0x0000000185CFAE40-0x0000000185CFAF80
		public override bool IsDefined(System.Type attributeType, bool inherit) => default; // 0x0000000185CFAF80-0x0000000185CFB0C0
	}
}
