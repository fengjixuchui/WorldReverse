/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class MessageOptions : MessageBase, IMessage<MessageOptions> // TypeDefIndex: 26374
{
	// Fields
	private static readonly MessageParser<MessageOptions> _parser; // 0x00
	internal CustomOptions CustomOptions; // 0x18
	public const int MessageSetWireFormatFieldNumber = 1; // Metadata: 0x00B0C045
	private bool messageSetWireFormat_; // 0x20
	public const int NoStandardDescriptorAccessorFieldNumber = 2; // Metadata: 0x00B0C049
	private bool noStandardDescriptorAccessor_; // 0x21
	public const int DeprecatedFieldNumber = 3; // Metadata: 0x00B0C04D
	private bool deprecated_; // 0x22
	public const int MapEntryFieldNumber = 7; // Metadata: 0x00B0C051
	private bool mapEntry_; // 0x23
	public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x00B0C055
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
	private readonly RepeatedMessageField<UninterpretedOption> uninterpretedOption_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MessageOptions> Parser { /* [XID] */ /* 0x00000001898B4E10-0x00000001898B4E30 */ get => default; } // 0x000000018253F190-0x000000018253F260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001898BC940-0x00000001898BC960 */ get => default; } // 0x000000018253EB50-0x000000018253EC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001898C3FA0-0x00000001898C3FC0 */ get => default; } // 0x000000018253E5F0-0x000000018253E6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001898CB720-0x00000001898CB740 */ get => default; } // 0x000000018253D9D0-0x000000018253DA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001898D2E50-0x00000001898D2E70 */ get => default; } // 0x000000018253F9D0-0x000000018253FAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x00000001898DA7A0-0x00000001898DA7C0 */ get => default; } // 0x000000018253F650-0x000000018253F6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001898E25A0-0x00000001898E25C0 */ get => default; } // 0x000000018253EE80-0x000000018253EF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001898EA080-0x00000001898EA0A0 */ get => default; } // 0x000000018253F930-0x000000018253F9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001898F1860-0x00000001898F1880 */ get => default; } // 0x000000018253E7A0-0x000000018253E8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool MessageSetWireFormat { /* [XID] */ /* 0x0000000189937D80-0x0000000189937DA0 */ get => default; /* [XID] */ /* 0x000000018993F810-0x000000018993F830 */ set {} } // 0x000000018253ED20-0x000000018253EE00 0x000000018253E510-0x000000018253E5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool NoStandardDescriptorAccessor { /* [XID] */ /* 0x0000000189946EC0-0x0000000189946EE0 */ get => default; /* [XID] */ /* 0x000000018994E4D0-0x000000018994E4F0 */ set {} } // 0x000000018253F340-0x000000018253F420 0x000000018253DDB0-0x000000018253DE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Deprecated { /* [XID] */ /* 0x0000000189955B40-0x0000000189955B60 */ get => default; /* [XID] */ /* 0x000000018995D5D0-0x000000018995D5F0 */ set {} } // 0x000000018253F0B0-0x000000018253F190 0x000000018253F260-0x000000018253F340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool MapEntry { /* [XID] */ /* 0x0000000189964CA0-0x0000000189964CC0 */ get => default; /* [XID] */ /* 0x000000018996C250-0x000000018996C270 */ set {} } // 0x000000018253EC40-0x000000018253ED20 0x000000018253EA70-0x000000018253EB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<UninterpretedOption> UninterpretedOption { /* [XID] */ /* 0x0000000189973D00-0x0000000189973D20 */ get => default; } // 0x000000018253E2F0-0x000000018253E390 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MessageOptions() {} // 0x000000018253FFB0-0x0000000182540080
	static MessageOptions() {} // 0x000000018253FEA0-0x000000018253FFB0

	// Methods
	[DebuggerNonUserCode] // 0x00000001898F8FE0-0x00000001898F9020
	// [XID] // 0x00000001898F8FE0-0x00000001898F9020
	public MessageOptions Clone() => default; // 0x000000018253EF80-0x000000018253F0B0
	[DebuggerNonUserCode] // 0x00000001899038E0-0x0000000189903920
	// [XID] // 0x00000001899038E0-0x0000000189903920
	public MessageOptions ShallowCopy() => default; // 0x000000018253E6C0-0x000000018253E7A0
	[DebuggerNonUserCode] // 0x000000018990E080-0x000000018990E0C0
	// [XID] // 0x000000018990E080-0x000000018990E0C0
	protected override void InternalSetInPool(bool value) {} // 0x000000018253DD00-0x000000018253DDB0
	[DebuggerNonUserCode] // 0x0000000189918860-0x00000001899188A0
	// [XID] // 0x0000000189918860-0x00000001899188A0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018253F4B0-0x000000018253F580
	[DebuggerNonUserCode] // 0x0000000189923140-0x0000000189923180
	// [XID] // 0x0000000189923140-0x0000000189923180
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018253F580-0x000000018253F650
	[DebuggerNonUserCode] // 0x000000018992D9A0-0x000000018992D9E0
	// [XID] // 0x000000018992D9A0-0x000000018992D9E0
	public override void Reset() {} // 0x000000018253DE90-0x000000018253DFA0
	[DebuggerNonUserCode] // 0x000000018997B490-0x000000018997B4E0
	// [IDTag] // 0x000000018997B490-0x000000018997B4E0
	// [XID] // 0x000000018997B490-0x000000018997B4E0
	public override bool Equals(object other) => default; // 0x000000018253E010-0x000000018253E120
	[DebuggerNonUserCode] // 0x0000000189988E80-0x0000000189988ED0
	// [IDTag] // 0x0000000189988E80-0x0000000189988ED0
	// [XID] // 0x0000000189988E80-0x0000000189988ED0
	public bool Equals(MessageOptions other) => default; // 0x000000018253E120-0x000000018253E2F0
	[DebuggerNonUserCode] // 0x00000001899969D0-0x0000000189996A10
	// [XID] // 0x00000001899969D0-0x0000000189996A10
	public override int GetHashCode() => default; // 0x000000018253E8A0-0x000000018253EA70
	[DebuggerNonUserCode] // 0x00000001899A1340-0x00000001899A1380
	// [XID] // 0x00000001899A1340-0x00000001899A1380
	public override string ToString() => default; // 0x000000018253FAD0-0x000000018253FEA0
	[DebuggerNonUserCode] // 0x00000001899ABE80-0x00000001899ABEC0
	// [XID] // 0x00000001899ABE80-0x00000001899ABEC0
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018253F6F0-0x000000018253F930
	[DebuggerNonUserCode] // 0x00000001899B6200-0x00000001899B6240
	// [XID] // 0x00000001899B6200-0x00000001899B6240
	public override int CalculateSize() => default; // 0x000000018253E390-0x000000018253E510
	[DebuggerNonUserCode] // 0x00000001899C0C60-0x00000001899C0CA0
	// [XID] // 0x00000001899C0C60-0x00000001899C0CA0
	public void CopyFrom(MessageOptions other) {} // 0x000000018253DAE0-0x000000018253DD00
	[DebuggerNonUserCode] // 0x00000001899CB610-0x00000001899CB650
	// [XID] // 0x00000001899CB610-0x00000001899CB650
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018253D7C0-0x000000018253D9D0
}

