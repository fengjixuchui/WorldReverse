/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TypeRegistry // TypeDefIndex: 26431
{
	// Fields
	public static readonly TypeRegistry Empty; // 0x00
	private readonly Dictionary<string, MessageDescriptor> fullNameToMessageMap; // 0x10

	// Nested types
	private class Builder // TypeDefIndex: 26432
	{
		// Fields
		private readonly Dictionary<string, MessageDescriptor> types; // 0x10
		private readonly HashSet<string> fileDescriptorNames; // 0x18

		// Constructors
		internal Builder() {} // 0x0000000181656F30-0x0000000181656FE0

		// Methods
		// [XID] // 0x0000000189833420-0x0000000189833440
		internal void AddFile(FileDescriptor fileDescriptor) {} // 0x0000000181656BB0-0x0000000181656F30
		// [XID] // 0x000000018983A910-0x000000018983A930
		private void AddMessage(MessageDescriptor messageDescriptor) {} // 0x00000001816568A0-0x0000000181656AE0
		// [XID] // 0x0000000189841F10-0x0000000189841F30
		internal TypeRegistry Build() => default; // 0x0000000181656AE0-0x0000000181656BB0
	}

	// Constructors
	public TypeRegistry() {} // Dummy constructor
	private TypeRegistry(Dictionary<string, MessageDescriptor> fullNameToMessageMap) {} // 0x000000018166D1E0-0x000000018166D250
	static TypeRegistry() {} // 0x000000018166D0F0-0x000000018166D1E0

	// Methods
	// [XID] // 0x00000001897E84D0-0x00000001897E84F0
	public MessageDescriptor Find(string fullName) => default; // 0x000000018166CC70-0x000000018166CD50
	// [IDTag] // 0x00000001897F01F0-0x00000001897F0230
	// [XID] // 0x00000001897F01F0-0x00000001897F0230
	public static TypeRegistry FromFiles(params /* 0x000000018989F6F0-0x000000018989F700 */ FileDescriptor[] fileDescriptors) => default; // 0x000000018166CDD0-0x000000018166CEA0
	// [IDTag] // 0x00000001898022C0-0x0000000189802300
	// [XID] // 0x00000001898022C0-0x0000000189802300
	public static TypeRegistry FromFiles(IEnumerable<FileDescriptor> fileDescriptors) => default; // 0x000000018166CEA0-0x000000018166D0F0
	// [IDTag] // 0x000000018980C410-0x000000018980C450
	// [XID] // 0x000000018980C410-0x000000018980C450
	public static TypeRegistry FromMessages(params /* 0x000000018989F6F0-0x000000018989F700 */ MessageDescriptor[] messageDescriptors) => default; // 0x000000018166C9F0-0x000000018166CAC0
	// [IDTag] // 0x000000018981E770-0x000000018981E7B0
	// [XID] // 0x000000018981E770-0x000000018981E7B0
	public static TypeRegistry FromMessages(IEnumerable<MessageDescriptor> messageDescriptors) => default; // 0x000000018166CAC0-0x000000018166CC70
}

