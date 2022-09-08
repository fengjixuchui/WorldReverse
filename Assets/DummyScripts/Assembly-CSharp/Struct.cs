/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Struct : MessageBase, IMessage<Struct> // TypeDefIndex: 26449
{
	// Fields
	private static readonly MessageParser<Struct> _parser; // 0x00
	public const int FieldsFieldNumber = 1; // Metadata: 0x00B0C1F0
	private static readonly MapField<string, Value> _map_fields_codec; // 0x08
	private readonly MapField<string, Value> fields_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Struct> Parser { /* [XID] */ /* 0x000000018986C800-0x000000018986C820 */ get => default; } // 0x000000018180CD40-0x000000018180CE10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189873C30-0x0000000189873C50 */ get => default; } // 0x000000018180C9A0-0x000000018180CA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x000000018987B6F0-0x000000018987B710 */ get => default; } // 0x000000018180C5F0-0x000000018180C6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001898828B0-0x00000001898828D0 */ get => default; } // 0x000000018180BD70-0x000000018180BE10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x000000018988A060-0x000000018988A080 */ get => default; } // 0x000000018180D280-0x000000018180D380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189891520-0x0000000189891540 */ get => default; } // 0x000000018180D000-0x000000018180D0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189898D20-0x0000000189898D40 */ get => default; } // 0x000000018180CB10-0x000000018180CC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x000000018989FD90-0x000000018989FDB0 */ get => default; } // 0x000000018180D1E0-0x000000018180D280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001898A7740-0x00000001898A7760 */ get => default; } // 0x000000018180C7A0-0x000000018180C8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<string, Value> Fields { /* [XID] */ /* 0x00000001898EE790-0x00000001898EE7B0 */ get => default; } // 0x000000018180C080-0x000000018180C120 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Struct() {} // 0x000000018180D670-0x000000018180D700
	static Struct() {} // 0x000000018180D510-0x000000018180D670

	// Methods
	[DebuggerNonUserCode] // 0x00000001898AF0E0-0x00000001898AF120
	// [XID] // 0x00000001898AF0E0-0x00000001898AF120
	public Struct Clone() => default; // 0x000000018180CC10-0x000000018180CD40
	[DebuggerNonUserCode] // 0x00000001898B9C50-0x00000001898B9C90
	// [XID] // 0x00000001898B9C50-0x00000001898B9C90
	public Struct ShallowCopy() => default; // 0x000000018180C6C0-0x000000018180C7A0
	[DebuggerNonUserCode] // 0x00000001898C3F00-0x00000001898C3F40
	// [XID] // 0x00000001898C3F00-0x00000001898C3F40
	protected override void InternalSetInPool(bool value) {} // 0x000000018180BFD0-0x000000018180C080
	[DebuggerNonUserCode] // 0x00000001898CE4E0-0x00000001898CE520
	// [XID] // 0x00000001898CE4E0-0x00000001898CE520
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018180CEA0-0x000000018180CF50
	[DebuggerNonUserCode] // 0x00000001898D8F10-0x00000001898D8F50
	// [XID] // 0x00000001898D8F10-0x00000001898D8F50
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018180CF50-0x000000018180D000
	[DebuggerNonUserCode] // 0x00000001898E3A00-0x00000001898E3A40
	// [XID] // 0x00000001898E3A00-0x00000001898E3A40
	public override void Reset() {} // 0x000000018180C120-0x000000018180C1E0
	[DebuggerNonUserCode] // 0x00000001898F5F60-0x00000001898F5FB0
	// [IDTag] // 0x00000001898F5F60-0x00000001898F5FB0
	// [XID] // 0x00000001898F5F60-0x00000001898F5FB0
	public override bool Equals(object other) => default; // 0x000000018180C250-0x000000018180C360
	[DebuggerNonUserCode] // 0x0000000189903870-0x00000001899038C0
	// [IDTag] // 0x0000000189903870-0x00000001899038C0
	// [XID] // 0x0000000189903870-0x00000001899038C0
	public bool Equals(Struct other) => default; // 0x000000018180C360-0x000000018180C4C0
	[DebuggerNonUserCode] // 0x0000000189910CD0-0x0000000189910D10
	// [XID] // 0x0000000189910CD0-0x0000000189910D10
	public override int GetHashCode() => default; // 0x000000018180C8A0-0x000000018180C9A0
	[DebuggerNonUserCode] // 0x000000018991BB60-0x000000018991BBA0
	// [XID] // 0x000000018991BB60-0x000000018991BBA0
	public override string ToString() => default; // 0x000000018180D380-0x000000018180D510
	[DebuggerNonUserCode] // 0x0000000189926250-0x0000000189926290
	// [XID] // 0x0000000189926250-0x0000000189926290
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018180D0A0-0x000000018180D1E0
	[DebuggerNonUserCode] // 0x00000001899308B0-0x00000001899308F0
	// [XID] // 0x00000001899308B0-0x00000001899308F0
	public override int CalculateSize() => default; // 0x000000018180C4C0-0x000000018180C5F0
	[DebuggerNonUserCode] // 0x000000018993B060-0x000000018993B0A0
	// [XID] // 0x000000018993B060-0x000000018993B0A0
	public void CopyFrom(Struct other) {} // 0x000000018180BE80-0x000000018180BFD0
	[DebuggerNonUserCode] // 0x0000000189945550-0x0000000189945590
	// [XID] // 0x0000000189945550-0x0000000189945590
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018180BBF0-0x000000018180BD70
}

