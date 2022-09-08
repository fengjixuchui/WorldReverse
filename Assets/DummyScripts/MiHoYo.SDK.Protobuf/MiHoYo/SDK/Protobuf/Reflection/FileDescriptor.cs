/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using MiHoYo.SDK.Protobuf;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.Reflection
{
	public sealed class FileDescriptor : IDescriptor // TypeDefIndex: 5192
	{
		// Properties
		internal FileDescriptorProto Proto { get; } // 0x0000000186506680-0x00000001865066E0 
		public string Name { get => default; } // 0x00000001865064C0-0x00000001865065A0 
		public string Package { get => default; } // 0x00000001865065A0-0x0000000186506680 
		public IList<MessageDescriptor> MessageTypes { get; } // 0x0000000186506460-0x00000001865064C0 
		public IList<ServiceDescriptor> Services { get; } // 0x0000000186506740-0x00000001865067A0 
		public IList<FileDescriptor> PublicDependencies { get; } // 0x00000001865066E0-0x0000000186506740 
		string IDescriptor.FullName { get => default; } // 0x0000000186505F70-0x0000000186505FE0 
		FileDescriptor IDescriptor.File { get => default; } // 0x0000000186505F10-0x0000000186505F70 
		internal DescriptorPool DescriptorPool { get; } // 0x0000000186506400-0x0000000186506460 
	
		// Constructors
		public FileDescriptor() {} // Dummy constructor
		private FileDescriptor(MiHoYo.SDK.Protobuf.ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) {} // 0x0000000186506080-0x0000000186506400
	
		// Methods
		internal string ComputeFullName(MessageDescriptor parent, string name) => default; // 0x0000000186505390-0x00000001865054C0
		private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor @this, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies) => default; // 0x0000000186505980-0x0000000186505D20
		private static FileDescriptor BuildFrom(MiHoYo.SDK.Protobuf.ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) => default; // 0x0000000186504F80-0x0000000186505390
		private void CrossLink() {} // 0x00000001865054C0-0x0000000186505980
		public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo) => default; // 0x0000000186505D20-0x0000000186505F10
		public override string ToString() => default; // 0x0000000186505FE0-0x0000000186506080
	}
}
