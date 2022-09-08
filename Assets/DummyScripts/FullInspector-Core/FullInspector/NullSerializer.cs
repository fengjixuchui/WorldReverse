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
	[Obsolete] // 0x00000001896BCCD0-0x00000001896BCD00
	public class NullSerializer : BaseSerializer // TypeDefIndex: 4820
	{
		// Constructors
		public NullSerializer() {} // 0x0000000185CF52F0-0x0000000185CF5390
	
		// Methods
		public override string Serialize(MemberInfo storageType, object value, ISerializationOperator serializationOperator) => default; // 0x0000000185CF52A0-0x0000000185CF52F0
		public override object Deserialize(MemberInfo storageType, string serializedState, ISerializationOperator serializationOperator) => default; // 0x0000000185CF5250-0x0000000185CF52A0
	}
}
