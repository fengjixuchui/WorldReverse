/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor> // TypeDefIndex: 26405
{
	// Fields
	private EnumDescriptor enumType; // 0x28
	private MessageDescriptor messageType; // 0x30
	private FieldType fieldType; // 0x38
	private readonly string propertyName; // 0x40
	private IFieldAccessor accessor; // 0x48
	public readonly MessageDescriptor ContainingType; // 0x50
	public readonly OneofDescriptor ContainingOneof; // 0x58
	public readonly string JsonName; // 0x60
	internal readonly FieldDescriptorProto Proto; // 0x68

	// Properties
	public override string Name { /* [XID] */ /* 0x0000000189AE1C50-0x0000000189AE1C70 */ get => default; } // 0x000000018176D2A0-0x000000018176D350 
	public IFieldAccessor Accessor { /* [XID] */ /* 0x0000000189AE9480-0x0000000189AE94A0 */ get => default; } // 0x000000018176DE10-0x000000018176DEB0 
	public bool IsRepeated { /* [XID] */ /* 0x0000000189AF8800-0x0000000189AF8820 */ get => default; } // 0x000000018176D350-0x000000018176D410 
	public bool IsMap { /* [XID] */ /* 0x0000000189AFFD80-0x0000000189AFFDA0 */ get => default; } // 0x000000018176CEF0-0x000000018176D000 
	public bool IsPacked { /* [XID] */ /* 0x0000000189B07370-0x0000000189B07390 */ get => default; } // 0x000000018176D410-0x000000018176D500 
	public FieldType FieldType { /* [XID] */ /* 0x0000000189B0EB50-0x0000000189B0EB70 */ get => default; } // 0x000000018176D5E0-0x000000018176D680 
	public int FieldNumber { /* [XID] */ /* 0x0000000189B15EE0-0x0000000189B15F00 */ get => default; } // 0x000000018176D000-0x000000018176D0B0 
	public EnumDescriptor EnumType { /* [XID] */ /* 0x0000000189B24F00-0x0000000189B24F20 */ get => default; } // 0x000000018176D1C0-0x000000018176D2A0 
	public MessageDescriptor MessageType { /* [XID] */ /* 0x0000000189B2C3C0-0x0000000189B2C3E0 */ get => default; } // 0x000000018176D500-0x000000018176D5E0 
	public CustomOptions CustomOptions { /* [XID] */ /* 0x0000000189B33930-0x0000000189B33950 */ get => default; } // 0x000000018176CDD0-0x000000018176CEF0 

	// Constructors
	public FieldDescriptor() {} // Dummy constructor
	internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName) {} // 0x000000018176DEB0-0x000000018176E210

	// Methods
	// [XID] // 0x0000000189AF1230-0x0000000189AF1250
	private static FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type) => default; // 0x000000018176D680-0x000000018176D840
	// [XID] // 0x0000000189B1D5F0-0x0000000189B1D610
	public int CompareTo(FieldDescriptor other) => default; // 0x000000018176D0B0-0x000000018176D1C0
	// [XID] // 0x0000000189B3B250-0x0000000189B3B270
	internal void CrossLink() {} // 0x000000018176D840-0x000000018176DE10
	// [XID] // 0x0000000189B429E0-0x0000000189B42A00
	private IFieldAccessor CreateAccessor() => default; // 0x000000018176CA70-0x000000018176CDD0
}

