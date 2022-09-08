/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class DescriptorPool // TypeDefIndex: 26396
{
	// Fields
	private readonly IDictionary<string, IDescriptor> descriptorsByName; // 0x10
	private readonly IDictionary<DescriptorIntPair, FieldDescriptor> fieldsByNumber; // 0x18
	private readonly IDictionary<DescriptorIntPair, EnumValueDescriptor> enumValuesByNumber; // 0x20
	private readonly HashSet<FileDescriptor> dependencies; // 0x28
	private static readonly Regex ValidationRegex; // 0x00

	// Nested types
	private struct DescriptorIntPair : IEquatable<DescriptorIntPair> // TypeDefIndex: 26397
	{
		// Fields
		private readonly int number; // 0x00
		private readonly IDescriptor descriptor; // 0x08

		// Constructors
		internal DescriptorIntPair(IDescriptor descriptor, int number) {
			this.number = default;
			this.descriptor = default;
		} // 0x00000001839E4260-0x00000001839E42F0

		// Methods
		// [IDTag] // 0x0000000189A3D960-0x0000000189A3D9A0
		// [XID] // 0x0000000189A3D960-0x0000000189A3D9A0
		public bool Equals(DescriptorIntPair other) => default; // 0x00000001839E3FA0-0x00000001839E40C0
		// [IDTag] // 0x0000000189A47FF0-0x0000000189A48030
		// [XID] // 0x0000000189A47FF0-0x0000000189A48030
		public override bool Equals(object obj) => default; // 0x00000001839E40C0-0x00000001839E41A0
		// [XID] // 0x0000000189A52750-0x0000000189A52770
		public override int GetHashCode() => default; // 0x00000001839E41A0-0x00000001839E4250
	}

	// Constructors
	public DescriptorPool() {} // Dummy constructor
	internal DescriptorPool(FileDescriptor[] dependencyFiles) {} // 0x00000001839F3C00-0x00000001839F3DE0
	static DescriptorPool() {} // 0x00000001839F3B30-0x00000001839F3C00

	// Methods
	// [XID] // 0x00000001899FB2E0-0x00000001899FB300
	private void ImportPublicDependencies(FileDescriptor file) {} // 0x00000001839F2FA0-0x00000001839F31C0
	internal T FindSymbol<T>(string fullName)
		where T : class => default;
	// [XID] // 0x0000000189A02500-0x0000000189A02520
	internal void AddPackage(string fullName, FileDescriptor file) {} // 0x00000001839F2B10-0x00000001839F2FA0
	// [XID] // 0x0000000189A09C90-0x0000000189A09CB0
	internal void AddSymbol(IDescriptor descriptor) {} // 0x00000001839F1DB0-0x00000001839F23E0
	// [XID] // 0x0000000189A11470-0x0000000189A11490
	private static void ValidateSymbolName(IDescriptor descriptor) {} // 0x00000001839F34D0-0x00000001839F3710
	// [XID] // 0x0000000189A18880-0x0000000189A188A0
	internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number) => default; // 0x00000001839F2960-0x00000001839F2B10
	// [XID] // 0x0000000189A1FF40-0x0000000189A1FF60
	internal EnumValueDescriptor FindEnumValueByNumber(EnumDescriptor enumDescriptor, int number) => default; // 0x00000001839F3980-0x00000001839F3B30
	// [XID] // 0x0000000189A272D0-0x0000000189A272F0
	internal void AddFieldByNumber(FieldDescriptor field) {} // 0x00000001839F23E0-0x00000001839F2960
	// [XID] // 0x0000000189A2EAB0-0x0000000189A2EAD0
	internal void AddEnumValueByNumber(EnumValueDescriptor enumValue) {} // 0x00000001839F3710-0x00000001839F3980
	// [XID] // 0x0000000189A36400-0x0000000189A36420
	internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo) => default; // 0x00000001839F31C0-0x00000001839F34D0
}

