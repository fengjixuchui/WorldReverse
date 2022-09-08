/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EnumValue : MessageBase, IMessage<EnumValue> // TypeDefIndex: 26464
{
	// Fields
	private static readonly MessageParser<EnumValue> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0C308
	private string name_; // 0x18
	public const int NumberFieldNumber = 2; // Metadata: 0x00B0C30C
	private int number_; // 0x20
	public const int OptionsFieldNumber = 3; // Metadata: 0x00B0C310
	private static readonly FieldCodec<Option> _repeated_options_codec; // 0x08
	private readonly RepeatedMessageField<Option> options_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnumValue> Parser { /* [XID] */ /* 0x00000001898EA040-0x00000001898EA060 */ get => default; } // 0x00000001818C2770-0x00000001818C2840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001898F1820-0x00000001898F1840 */ get => default; } // 0x00000001818C22F0-0x00000001818C23E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001898F8FA0-0x00000001898F8FC0 */ get => default; } // 0x00000001818C1DD0-0x00000001818C1EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001899008E0-0x0000000189900900 */ get => default; } // 0x00000001818C1210-0x00000001818C12B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189908120-0x0000000189908140 */ get => default; } // 0x00000001818C2E20-0x00000001818C2F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x000000018990F8A0-0x000000018990F8C0 */ get => default; } // 0x00000001818C2A70-0x00000001818C2B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189917390-0x00000001899173B0 */ get => default; } // 0x00000001818C2540-0x00000001818C2640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x000000018991E990-0x000000018991E9B0 */ get => default; } // 0x00000001818C2D80-0x00000001818C2E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189926230-0x0000000189926250 */ get => default; } // 0x00000001818C1F80-0x00000001818C2080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x000000018996C230-0x000000018996C250 */ get => default; /* [XID] */ /* 0x0000000189973CE0-0x0000000189973D00 */ set {} } // 0x00000001818C1CF0-0x00000001818C1DD0 0x00000001818C1730-0x00000001818C1820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Number { /* [XID] */ /* 0x000000018997B470-0x000000018997B490 */ get => default; /* [XID] */ /* 0x0000000189982EA0-0x0000000189982EC0 */ set {} } // 0x00000001818C2210-0x00000001818C22F0 0x00000001818C2460-0x00000001818C2540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Option> Options { /* [XID] */ /* 0x000000018998A600-0x000000018998A620 */ get => default; } // 0x00000001818C2B10-0x00000001818C2BB0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnumValue() {} // 0x00000001818C32D0-0x00000001818C3370
	static EnumValue() {} // 0x00000001818C31C0-0x00000001818C32D0

	// Methods
	[DebuggerNonUserCode] // 0x000000018992D960-0x000000018992D9A0
	// [XID] // 0x000000018992D960-0x000000018992D9A0
	public EnumValue Clone() => default; // 0x00000001818C2640-0x00000001818C2770
	[DebuggerNonUserCode] // 0x0000000189937D40-0x0000000189937D80
	// [XID] // 0x0000000189937D40-0x0000000189937D80
	public EnumValue ShallowCopy() => default; // 0x00000001818C1EA0-0x00000001818C1F80
	[DebuggerNonUserCode] // 0x00000001899421D0-0x0000000189942210
	// [XID] // 0x00000001899421D0-0x0000000189942210
	protected override void InternalSetInPool(bool value) {} // 0x00000001818C1510-0x00000001818C15C0
	[DebuggerNonUserCode] // 0x000000018994CA80-0x000000018994CAC0
	// [XID] // 0x000000018994CA80-0x000000018994CAC0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818C28D0-0x00000001818C29A0
	[DebuggerNonUserCode] // 0x00000001899571F0-0x0000000189957230
	// [XID] // 0x00000001899571F0-0x0000000189957230
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818C29A0-0x00000001818C2A70
	[DebuggerNonUserCode] // 0x0000000189961DD0-0x0000000189961E10
	// [XID] // 0x0000000189961DD0-0x0000000189961E10
	public override void Reset() {} // 0x00000001818C15C0-0x00000001818C16C0
	[DebuggerNonUserCode] // 0x0000000189991F40-0x0000000189991F90
	// [IDTag] // 0x0000000189991F40-0x0000000189991F90
	// [XID] // 0x0000000189991F40-0x0000000189991F90
	public override bool Equals(object other) => default; // 0x00000001818C1820-0x00000001818C1930
	[DebuggerNonUserCode] // 0x000000018999F970-0x000000018999F9C0
	// [IDTag] // 0x000000018999F970-0x000000018999F9C0
	// [XID] // 0x000000018999F970-0x000000018999F9C0
	public bool Equals(EnumValue other) => default; // 0x00000001818C1930-0x00000001818C1B00
	[DebuggerNonUserCode] // 0x00000001899AD490-0x00000001899AD4D0
	// [XID] // 0x00000001899AD490-0x00000001899AD4D0
	public override int GetHashCode() => default; // 0x00000001818C2080-0x00000001818C2210
	[DebuggerNonUserCode] // 0x00000001899B7AA0-0x00000001899B7AE0
	// [XID] // 0x00000001899B7AA0-0x00000001899B7AE0
	public override string ToString() => default; // 0x00000001818C2F20-0x00000001818C31C0
	[DebuggerNonUserCode] // 0x00000001899C2480-0x00000001899C24C0
	// [XID] // 0x00000001899C2480-0x00000001899C24C0
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818C2BB0-0x00000001818C2D80
	[DebuggerNonUserCode] // 0x00000001899CCCF0-0x00000001899CCD30
	// [XID] // 0x00000001899CCCF0-0x00000001899CCD30
	public override int CalculateSize() => default; // 0x00000001818C1B00-0x00000001818C1CF0
	[DebuggerNonUserCode] // 0x00000001899D70D0-0x00000001899D7110
	// [XID] // 0x00000001899D70D0-0x00000001899D7110
	public void CopyFrom(EnumValue other) {} // 0x00000001818C1320-0x00000001818C1510
	[DebuggerNonUserCode] // 0x00000001899E1AF0-0x00000001899E1B30
	// [XID] // 0x00000001899E1AF0-0x00000001899E1B30
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001818C1050-0x00000001818C1210
}

