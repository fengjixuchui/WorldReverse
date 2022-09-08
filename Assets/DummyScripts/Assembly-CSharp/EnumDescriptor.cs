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

public sealed class EnumDescriptor : DescriptorBase // TypeDefIndex: 26401
{
	// Fields
	private readonly EnumDescriptorProto proto; // 0x28
	private readonly MessageDescriptor containingType; // 0x30
	private readonly IList<EnumValueDescriptor> values; // 0x38
	private readonly System.Type clrType; // 0x40

	// Properties
	internal EnumDescriptorProto Proto { /* [XID] */ /* 0x0000000189A69830-0x0000000189A69850 */ get => default; } // 0x00000001836EC6B0-0x00000001836EC750 
	public override string Name { /* [XID] */ /* 0x0000000189A70B30-0x0000000189A70B50 */ get => default; } // 0x00000001836EC600-0x00000001836EC6B0 
	public System.Type ClrType { /* [XID] */ /* 0x0000000189A78450-0x0000000189A78470 */ get => default; } // 0x00000001836EC560-0x00000001836EC600 
	public MessageDescriptor ContainingType { /* [XID] */ /* 0x0000000189A7FA20-0x0000000189A7FA40 */ get => default; } // 0x00000001836EC4C0-0x00000001836EC560 
	public IList<EnumValueDescriptor> Values { /* [XID] */ /* 0x0000000189A876C0-0x0000000189A876E0 */ get => default; } // 0x00000001836EC890-0x00000001836EC930 
	public CustomOptions CustomOptions { /* [XID] */ /* 0x0000000189A9DA20-0x0000000189A9DA40 */ get => default; } // 0x00000001836EC2B0-0x00000001836EC3E0 

	// Constructors
	public EnumDescriptor() {} // Dummy constructor
	internal EnumDescriptor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, System.Type clrType) {} // 0x00000001836EC930-0x00000001836ECB80

	// Methods
	// [XID] // 0x0000000189A8EE40-0x0000000189A8EE60
	public EnumValueDescriptor FindValueByNumber(int number) => default; // 0x00000001836EC3E0-0x00000001836EC4C0
	// [XID] // 0x0000000189A964D0-0x0000000189A964F0
	public EnumValueDescriptor FindValueByName(string name) => default; // 0x00000001836EC750-0x00000001836EC890
}

