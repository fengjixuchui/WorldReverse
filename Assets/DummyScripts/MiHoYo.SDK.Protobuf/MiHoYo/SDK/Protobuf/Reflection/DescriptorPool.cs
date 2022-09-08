/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf.Reflection
{
	internal sealed class DescriptorPool // TypeDefIndex: 5181
	{
		// Fields
		private readonly IDictionary<string, IDescriptor> descriptorsByName; // 0x10
		private readonly IDictionary<DescriptorIntPair, FieldDescriptor> fieldsByNumber; // 0x18
		private readonly IDictionary<DescriptorIntPair, EnumValueDescriptor> enumValuesByNumber; // 0x20
		private readonly HashSet<FileDescriptor> dependencies; // 0x28
		private static readonly Regex ValidationRegex; // 0x00
	
		// Nested types
		private struct DescriptorIntPair : IEquatable<DescriptorIntPair> // TypeDefIndex: 5182
		{
			// Fields
			private readonly int number; // 0x00
			private readonly IDescriptor descriptor; // 0x08
	
			// Constructors
			internal DescriptorIntPair(IDescriptor descriptor, int number) {
				this.number = default;
				this.descriptor = default;
			} // 0x00000001864EB680-0x00000001864EB710
	
			// Methods
			public bool Equals(DescriptorIntPair other) => default; // 0x00000001864EB560-0x00000001864EB670
			public override bool Equals(object obj) => default; // 0x00000001864EB4D0-0x00000001864EB560
			public override int GetHashCode() => default; // 0x00000001864EB670-0x00000001864EB680
		}
	
		// Constructors
		public DescriptorPool() {} // Dummy constructor
		internal DescriptorPool(FileDescriptor[] dependencyFiles) {} // 0x00000001864ED2F0-0x00000001864ED4D0
		static DescriptorPool() {} // 0x00000001864ED220-0x00000001864ED2F0
	
		// Methods
		private void ImportPublicDependencies(FileDescriptor file) {} // 0x00000001864ECB00-0x00000001864ECD70
		internal T FindSymbol<T>(string fullName)
			where T : class => default;
		internal void AddPackage(string fullName, FileDescriptor file) {} // 0x00000001864EBF10-0x00000001864EC340
		internal void AddSymbol(IDescriptor descriptor) {} // 0x00000001864EC340-0x00000001864EC990
		private static void ValidateSymbolName(IDescriptor descriptor) {} // 0x00000001864ED030-0x00000001864ED220
		internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number) => default; // 0x00000001864EC990-0x00000001864ECB00
		internal void AddFieldByNumber(FieldDescriptor field) {} // 0x00000001864EB960-0x00000001864EBF10
		internal void AddEnumValueByNumber(EnumValueDescriptor enumValue) {} // 0x00000001864EB710-0x00000001864EB960
		internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo) => default; // 0x00000001864ECD70-0x00000001864ED030
	}
}
