/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ListValue : MessageBase, IMessage<ListValue> // TypeDefIndex: 26452
{
	// Fields
	private static readonly MessageParser<ListValue> _parser; // 0x00
	public const int ValuesFieldNumber = 1; // Metadata: 0x00B0C228
	private static readonly FieldCodec<Value> _repeated_values_codec; // 0x08
	private readonly RepeatedMessageField<Value> values_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ListValue> Parser { /* [XID] */ /* 0x0000000189BB36A0-0x0000000189BB36C0 */ get => default; } // 0x000000018452A180-0x000000018452A250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189BBAD10-0x0000000189BBAD30 */ get => default; } // 0x0000000184529DE0-0x0000000184529ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189BC2D00-0x0000000189BC2D20 */ get => default; } // 0x0000000184529A30-0x0000000184529B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189BCA420-0x0000000189BCA440 */ get => default; } // 0x0000000184529210-0x00000001845292B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189BD1A70-0x0000000189BD1A90 */ get => default; } // 0x000000018452A7A0-0x000000018452A8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189BD90D0-0x0000000189BD90F0 */ get => default; } // 0x000000018452A520-0x000000018452A5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001895E5C10-0x00000001895E5C30 */ get => default; } // 0x0000000184529F50-0x000000018452A050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001895ED5A0-0x00000001895ED5C0 */ get => default; } // 0x000000018452A700-0x000000018452A7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001895F4C10-0x00000001895F4C30 */ get => default; } // 0x0000000184529BE0-0x0000000184529CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Value> Values { /* [XID] */ /* 0x000000018963B370-0x000000018963B390 */ get => default; } // 0x000000018452A480-0x000000018452A520 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ListValue() {} // 0x000000018452AB40-0x000000018452ABD0
	static ListValue() {} // 0x000000018452AA30-0x000000018452AB40

	// Methods
	[DebuggerNonUserCode] // 0x00000001895FC360-0x00000001895FC3A0
	// [XID] // 0x00000001895FC360-0x00000001895FC3A0
	public ListValue Clone() => default; // 0x000000018452A050-0x000000018452A180
	[DebuggerNonUserCode] // 0x0000000189606B10-0x0000000189606B50
	// [XID] // 0x0000000189606B10-0x0000000189606B50
	public ListValue ShallowCopy() => default; // 0x0000000184529B00-0x0000000184529BE0
	[DebuggerNonUserCode] // 0x00000001896114E0-0x0000000189611520
	// [XID] // 0x00000001896114E0-0x0000000189611520
	protected override void InternalSetInPool(bool value) {} // 0x00000001845294A0-0x0000000184529550
	[DebuggerNonUserCode] // 0x000000018961BAC0-0x000000018961BB00
	// [XID] // 0x000000018961BAC0-0x000000018961BB00
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018452A2E0-0x000000018452A3B0
	[DebuggerNonUserCode] // 0x0000000189626080-0x00000001896260C0
	// [XID] // 0x0000000189626080-0x00000001896260C0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018452A3B0-0x000000018452A480
	[DebuggerNonUserCode] // 0x0000000189630B40-0x0000000189630B80
	// [XID] // 0x0000000189630B40-0x0000000189630B80
	public override void Reset() {} // 0x0000000184529550-0x0000000184529630
	[DebuggerNonUserCode] // 0x0000000189642AE0-0x0000000189642B30
	// [IDTag] // 0x0000000189642AE0-0x0000000189642B30
	// [XID] // 0x0000000189642AE0-0x0000000189642B30
	public override bool Equals(object other) => default; // 0x00000001845296A0-0x00000001845297B0
	[DebuggerNonUserCode] // 0x0000000189650000-0x0000000189650050
	// [IDTag] // 0x0000000189650000-0x0000000189650050
	// [XID] // 0x0000000189650000-0x0000000189650050
	public bool Equals(ListValue other) => default; // 0x00000001845297B0-0x0000000184529900
	[DebuggerNonUserCode] // 0x000000018965D880-0x000000018965D8C0
	// [XID] // 0x000000018965D880-0x000000018965D8C0
	public override int GetHashCode() => default; // 0x0000000184529CE0-0x0000000184529DE0
	[DebuggerNonUserCode] // 0x00000001896681E0-0x0000000189668220
	// [XID] // 0x00000001896681E0-0x0000000189668220
	public override string ToString() => default; // 0x000000018452A8A0-0x000000018452AA30
	[DebuggerNonUserCode] // 0x0000000189672E30-0x0000000189672E70
	// [XID] // 0x0000000189672E30-0x0000000189672E70
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018452A5C0-0x000000018452A700
	[DebuggerNonUserCode] // 0x000000018967D5B0-0x000000018967D5F0
	// [XID] // 0x000000018967D5B0-0x000000018967D5F0
	public override int CalculateSize() => default; // 0x0000000184529900-0x0000000184529A30
	[DebuggerNonUserCode] // 0x0000000189688130-0x0000000189688170
	// [XID] // 0x0000000189688130-0x0000000189688170
	public void CopyFrom(ListValue other) {} // 0x0000000184529320-0x00000001845294A0
	[DebuggerNonUserCode] // 0x0000000189692C90-0x0000000189692CD0
	// [XID] // 0x0000000189692C90-0x0000000189692CD0
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184529090-0x0000000184529210
}

