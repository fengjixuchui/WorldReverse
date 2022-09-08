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
	[AttributeUsage(AttributeTargets.All)] // 0x00000001897A5E40-0x00000001897A5E80
	public sealed class MemberMetaInfoAttribute : TypeMetaInfoAttribute // TypeDefIndex: 27205
	{
		// Fields
		private bool m_bIsReadonly; // 0x28
		private float m_range; // 0x2C
	
		// Properties
		public bool IsReadonly { get => default; } // 0x0000000186DEC880-0x0000000186DEC8E0 
		public float Range { get => default; } // 0x0000000186DEC8E0-0x0000000186DEC950 
	
		// Constructors
		public MemberMetaInfoAttribute(string displayName, string description, bool bReadOnly) {} // 0x0000000186DEC470-0x0000000186DEC500
		public MemberMetaInfoAttribute(string displayName, string description) {} // 0x0000000186DEC6C0-0x0000000186DEC750
		public MemberMetaInfoAttribute(string displayName, string description, float range) {} // 0x0000000186DEC500-0x0000000186DEC5A0
		public MemberMetaInfoAttribute() {} // 0x0000000186DEC610-0x0000000186DEC6C0
		public MemberMetaInfoAttribute(bool bReadonly) {} // 0x0000000186DEC5A0-0x0000000186DEC610
	
		// Methods
		private static string getEnumName(object obj) => default; // 0x0000000186DEC750-0x0000000186DEC880
		public static string GetEnumDisplayName(object obj) => default; // 0x0000000186DEC240-0x0000000186DEC470
		public static string GetEnumDescription(object obj) => default; // 0x0000000186DEC010-0x0000000186DEC240
	}
}
