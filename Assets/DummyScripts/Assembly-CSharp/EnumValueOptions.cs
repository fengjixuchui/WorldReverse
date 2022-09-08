/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class EnumValueOptions : MessageBase, IMessage<EnumValueOptions> // TypeDefIndex: 26381
{
	// Fields
	private static readonly MessageParser<EnumValueOptions> _parser; // 0x00
	internal CustomOptions CustomOptions; // 0x18
	public const int DeprecatedFieldNumber = 1; // Metadata: 0x00B0C09D
	private bool deprecated_; // 0x20
	public const int UninterpretedOptionFieldNumber = 999; // Metadata: 0x00B0C0A1
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x08
	private readonly RepeatedMessageField<UninterpretedOption> uninterpretedOption_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnumValueOptions> Parser { /* [XID] */ /* 0x00000001898F77C0-0x00000001898F77E0 */ get => default; } // 0x00000001834403F0-0x00000001834404C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001898FEE40-0x00000001898FEE60 */ get => default; } // 0x000000018343FF70-0x0000000183440060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189906640-0x0000000189906660 */ get => default; } // 0x000000018343FB80-0x000000018343FC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x000000018990E060-0x000000018990E080 */ get => default; } // 0x000000018343F240-0x000000018343F2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001899157D0-0x00000001899157F0 */ get => default; } // 0x0000000183440A90-0x0000000183440B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x000000018991D200-0x000000018991D220 */ get => default; } // 0x00000001834407D0-0x0000000183440870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189924A90-0x0000000189924AB0 */ get => default; } // 0x00000001834400E0-0x00000001834401E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x000000018992BFE0-0x000000018992C000 */ get => default; } // 0x00000001834409F0-0x0000000183440A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189933490-0x00000001899334B0 */ get => default; } // 0x000000018343FD30-0x000000018343FE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Deprecated { /* [XID] */ /* 0x0000000189979EA0-0x0000000189979EC0 */ get => default; /* [XID] */ /* 0x0000000189981610-0x0000000189981630 */ set {} } // 0x0000000183440310-0x00000001834403F0 0x00000001834404C0-0x00000001834405A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<UninterpretedOption> UninterpretedOption { /* [XID] */ /* 0x0000000189988E60-0x0000000189988E80 */ get => default; } // 0x000000018343F990-0x000000018343FA30 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnumValueOptions() {} // 0x0000000183440ED0-0x0000000183440FA0
	static EnumValueOptions() {} // 0x0000000183440DC0-0x0000000183440ED0

	// Methods
	[DebuggerNonUserCode] // 0x000000018993B0A0-0x000000018993B0E0
	// [XID] // 0x000000018993B0A0-0x000000018993B0E0
	public EnumValueOptions Clone() => default; // 0x00000001834401E0-0x0000000183440310
	[DebuggerNonUserCode] // 0x0000000189945590-0x00000001899455D0
	// [XID] // 0x0000000189945590-0x00000001899455D0
	public EnumValueOptions ShallowCopy() => default; // 0x000000018343FC50-0x000000018343FD30
	[DebuggerNonUserCode] // 0x000000018994FBD0-0x000000018994FC10
	// [XID] // 0x000000018994FBD0-0x000000018994FC10
	protected override void InternalSetInPool(bool value) {} // 0x000000018343F500-0x000000018343F5B0
	[DebuggerNonUserCode] // 0x000000018995A370-0x000000018995A3B0
	// [XID] // 0x000000018995A370-0x000000018995A3B0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183440630-0x0000000183440700
	[DebuggerNonUserCode] // 0x0000000189964C60-0x0000000189964CA0
	// [XID] // 0x0000000189964C60-0x0000000189964CA0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183440700-0x00000001834407D0
	[DebuggerNonUserCode] // 0x000000018996EF50-0x000000018996EF90
	// [XID] // 0x000000018996EF50-0x000000018996EF90
	public override void Reset() {} // 0x000000018343F5B0-0x000000018343F6A0
	[DebuggerNonUserCode] // 0x0000000189990710-0x0000000189990760
	// [IDTag] // 0x0000000189990710-0x0000000189990760
	// [XID] // 0x0000000189990710-0x0000000189990760
	public override bool Equals(object other) => default; // 0x000000018343F710-0x000000018343F820
	[DebuggerNonUserCode] // 0x000000018999E450-0x000000018999E4A0
	// [IDTag] // 0x000000018999E450-0x000000018999E4A0
	// [XID] // 0x000000018999E450-0x000000018999E4A0
	public bool Equals(EnumValueOptions other) => default; // 0x000000018343F820-0x000000018343F990
	[DebuggerNonUserCode] // 0x00000001899ABE40-0x00000001899ABE80
	// [XID] // 0x00000001899ABE40-0x00000001899ABE80
	public override int GetHashCode() => default; // 0x000000018343FE30-0x000000018343FF70
	[DebuggerNonUserCode] // 0x00000001899B61C0-0x00000001899B6200
	// [XID] // 0x00000001899B61C0-0x00000001899B6200
	public override string ToString() => default; // 0x0000000183440B90-0x0000000183440DC0
	[DebuggerNonUserCode] // 0x00000001899C0C20-0x00000001899C0C60
	// [XID] // 0x00000001899C0C20-0x00000001899C0C60
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183440870-0x00000001834409F0
	[DebuggerNonUserCode] // 0x00000001899CB5D0-0x00000001899CB610
	// [XID] // 0x00000001899CB5D0-0x00000001899CB610
	public override int CalculateSize() => default; // 0x000000018343FA30-0x000000018343FB80
	[DebuggerNonUserCode] // 0x00000001899D5B80-0x00000001899D5BC0
	// [XID] // 0x00000001899D5B80-0x00000001899D5BC0
	public void CopyFrom(EnumValueOptions other) {} // 0x000000018343F350-0x000000018343F500
	[DebuggerNonUserCode] // 0x00000001899E0000-0x00000001899E0040
	// [XID] // 0x00000001899E0000-0x00000001899E0040
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018343F090-0x000000018343F240
}

