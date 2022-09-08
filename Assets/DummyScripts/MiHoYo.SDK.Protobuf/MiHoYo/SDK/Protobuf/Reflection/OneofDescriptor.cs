/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.Reflection
{
	public sealed class OneofDescriptor : DescriptorBase // TypeDefIndex: 5204
	{
		// Fields
		private readonly OneofDescriptorProto proto; // 0x28
		private MessageDescriptor containingType; // 0x30
		private IList<FieldDescriptor> fields; // 0x38
		private readonly OneofAccessor accessor; // 0x40
	
		// Properties
		public override string Name { get => default; } // 0x0000000187D65B20-0x0000000187D65BD0 
		public MessageDescriptor ContainingType { get => default; } // 0x0000000187D65AC0-0x0000000187D65B20 
		public OneofAccessor Accessor { get => default; } // 0x0000000187D65A60-0x0000000187D65AC0 
	
		// Constructors
		public OneofDescriptor() {} // Dummy constructor
		internal OneofDescriptor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName) {} // 0x0000000187D65920-0x0000000187D65A60
	
		// Methods
		internal void CrossLink() {} // 0x0000000187D655A0-0x0000000187D65920
		private OneofAccessor CreateAccessor(string clrName) => default; // 0x0000000187D65230-0x0000000187D655A0
	}
}
