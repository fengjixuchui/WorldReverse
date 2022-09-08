/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace behaviac
{
	[AttributeUsage(AttributeTargets.All)] // 0x0000000189796610-0x0000000189796650
	public class TypeMetaInfoAttribute : Attribute // TypeDefIndex: 27203
	{
		// Fields
		private string displayName_; // 0x10
		private string desc_; // 0x18
		private ERefType refType_; // 0x20
	
		// Properties
		public string DisplayName { get => default; } // 0x0000000186DFA010-0x0000000186DFA070 
		public string Description { get => default; } // 0x0000000186DF9FB0-0x0000000186DFA010 
		public ERefType RefType { get => default; } // 0x0000000186DFA070-0x0000000186DFA0D0 
	
		// Constructors
		public TypeMetaInfoAttribute(string displayName, string description) {} // 0x0000000186DF9DA0-0x0000000186DF9E30
		public TypeMetaInfoAttribute(string displayName, string description, ERefType refType) {} // 0x0000000186DF9F20-0x0000000186DF9FB0
		public TypeMetaInfoAttribute() {} // 0x0000000186DF9E30-0x0000000186DF9EA0
		public TypeMetaInfoAttribute(ERefType refType) {} // 0x0000000186DF9EA0-0x0000000186DF9F20
	}
}
