/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer.Internal
{
	public class fsMetaProperty // TypeDefIndex: 9275
	{
		// Fields
		private MemberInfo _memberInfo; // 0x10
	
		// Properties
		public System.Type StorageType { /* [XID] */ /* 0x0000000189B39010-0x0000000189B39050 */ get; private set; } // 0x000000018659D070-0x000000018659D0D0 0x000000018659D2B0-0x000000018659D310
		public bool CanRead { /* [XID] */ /* 0x0000000189B4B340-0x0000000189B4B380 */ get; private set; } // 0x000000018659CE90-0x000000018659CEF0 0x000000018659D0D0-0x000000018659D130
		public bool CanWrite { /* [XID] */ /* 0x0000000189B5D4C0-0x0000000189B5D500 */ get; private set; } // 0x000000018659CEF0-0x000000018659CF50 0x000000018659D130-0x000000018659D190
		public string JsonName { /* [XID] */ /* 0x0000000189B6F060-0x0000000189B6F0A0 */ get; private set; } // 0x000000018659CFB0-0x000000018659D010 0x000000018659D1F0-0x000000018659D250
		public string MemberName { /* [XID] */ /* 0x0000000189B80B00-0x0000000189B80B40 */ get; private set; } // 0x000000018659D010-0x000000018659D070 0x000000018659D250-0x000000018659D2B0
		public bool IsPublic { /* [XID] */ /* 0x0000000189B927E0-0x0000000189B92820 */ get; private set; } // 0x000000018659CF50-0x000000018659CFB0 0x000000018659D190-0x000000018659D1F0
	
		// Constructors
		public fsMetaProperty() {} // Dummy constructor
		internal fsMetaProperty(FieldInfo field) {} // 0x000000018659CC60-0x000000018659CE90
		internal fsMetaProperty(PropertyInfo property) {} // 0x000000018659C9B0-0x000000018659CC60
	
		// Methods
		// [XID] // 0x0000000189BA44B0-0x0000000189BA44D0
		public void Write(object context, object value) {} // 0x000000018659C7A0-0x000000018659C9B0
		// [XID] // 0x0000000189BABA10-0x0000000189BABA30
		public object Read(object context) => default; // 0x000000018659C5F0-0x000000018659C7A0
		// [XID] // 0x0000000189BB2FA0-0x0000000189BB2FC0
		private static string GetJsonName(MemberInfo member) => default; // 0x000000018659C4B0-0x000000018659C5F0
	}
}
