/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MiHoYo.SDK.Protobuf;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.Reflection
{
	public sealed class OneofAccessor // TypeDefIndex: 5203
	{
		// Fields
		private readonly Func<MiHoYo.SDK.Protobuf.IMessage, int> caseDelegate; // 0x10
		private readonly Action<MiHoYo.SDK.Protobuf.IMessage> clearDelegate; // 0x18
		private OneofDescriptor descriptor; // 0x20
	
		// Constructors
		public OneofAccessor() {} // Dummy constructor
		internal OneofAccessor(PropertyInfo caseProperty, MethodInfo clearMethod, OneofDescriptor descriptor) {} // 0x0000000187D64170-0x0000000187D642B0
	
		// Methods
		public FieldDescriptor GetCaseFieldDescriptor(MiHoYo.SDK.Protobuf.IMessage message) => default; // 0x0000000187D64070-0x0000000187D64170
	}
}
