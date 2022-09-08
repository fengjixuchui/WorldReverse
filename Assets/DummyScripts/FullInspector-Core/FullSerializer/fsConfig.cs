/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 44: FullInspector-Core.dll - Assembly: FullInspector-Core, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4703-5032

namespace FullSerializer
{
	public class fsConfig // TypeDefIndex: 4713
	{
		// Fields
		public System.Type[] SerializeAttributes; // 0x10
		public System.Type[] IgnoreSerializeAttributes; // 0x18
		public fsMemberSerialization DefaultMemberSerialization; // 0x20
		public Func<string, MemberInfo, string> GetJsonNameFromMemberName; // 0x28
		public bool SerializeNonAutoProperties; // 0x30
		public bool SerializeNonPublicSetProperties; // 0x31
		public string CustomDateTimeFormatString; // 0x38
		public bool Serialize64BitIntegerAsString; // 0x40
		public bool SerializeEnumsAsInteger; // 0x41
	
		// Constructors
		public fsConfig() {} // 0x0000000185D08B80-0x0000000185D08E80
	}
}
