/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.Reflection
{
	public abstract class DescriptorBase : IDescriptor // TypeDefIndex: 5180
	{
		// Fields
		private readonly FileDescriptor file; // 0x10
		private readonly string fullName; // 0x18
		private readonly int index; // 0x20
	
		// Properties
		public abstract string Name { get; }
		public string FullName { get; } // 0x00000001864EB370-0x00000001864EB4D0 
		public FileDescriptor File { get; } // 0x00000001864EB310-0x00000001864EB370 
	
		// Constructors
		protected DescriptorBase() {} // Dummy constructor
		internal DescriptorBase(FileDescriptor file, string fullName, int index) {} // 0x00000001864EB280-0x00000001864EB310
	}
}
