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
	internal abstract class FieldAccessorBase : IFieldAccessor // TypeDefIndex: 5189
	{
		// Fields
		private readonly Func<MiHoYo.SDK.Protobuf.IMessage, object> getValueDelegate; // 0x10
		private readonly FieldDescriptor descriptor; // 0x18
	
		// Properties
		public FieldDescriptor Descriptor { get; } // 0x00000001864FB6D0-0x00000001864FB730 
	
		// Constructors
		protected FieldAccessorBase() {} // Dummy constructor
		internal FieldAccessorBase(PropertyInfo property, FieldDescriptor descriptor) {} // 0x00000001864FB600-0x00000001864FB6D0
	
		// Methods
		public object GetValue(MiHoYo.SDK.Protobuf.IMessage message) => default; // 0x00000001864FB570-0x00000001864FB600
		public abstract void SetValue(MiHoYo.SDK.Protobuf.IMessage message, object value);
	}
}
