/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class EnumDescriptorProto : MessageBase, IMessage<EnumDescriptorProto> // TypeDefIndex: 26367
{
	// Fields
	private static readonly MessageParser<EnumDescriptorProto> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0BFB1
	private string name_; // 0x18
	public const int ValueFieldNumber = 2; // Metadata: 0x00B0BFB5
	private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec; // 0x08
	private readonly RepeatedMessageField<EnumValueDescriptorProto> value_; // 0x20
	public const int OptionsFieldNumber = 3; // Metadata: 0x00B0BFB9
	private EnumOptions options_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnumDescriptorProto> Parser { /* [XID] */ /* 0x0000000189BC1120-0x0000000189BC1140 */ get => default; } // 0x00000001845996B0-0x0000000184599780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189BC88F0-0x0000000189BC8910 */ get => default; } // 0x0000000184599270-0x0000000184599360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189BD0110-0x0000000189BD0130 */ get => default; } // 0x0000000184598E30-0x0000000184598F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189BD7750-0x0000000189BD7770 */ get => default; } // 0x00000001845981B0-0x0000000184598250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189BDF250-0x0000000189BDF270 */ get => default; } // 0x0000000184599DC0-0x0000000184599EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x00000001895EBEA0-0x00000001895EBEC0 */ get => default; } // 0x00000001845999D0-0x0000000184599A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001895F32A0-0x00000001895F32C0 */ get => default; } // 0x0000000184599480-0x0000000184599580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001895FAB70-0x00000001895FAB90 */ get => default; } // 0x0000000184599D20-0x0000000184599DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001896024F0-0x0000000189602510 */ get => default; } // 0x0000000184598FE0-0x00000001845990E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x00000001896488F0-0x0000000189648910 */ get => default; /* [XID] */ /* 0x0000000189650050-0x0000000189650070 */ set {} } // 0x0000000184598D50-0x0000000184598E30 0x0000000184598770-0x0000000184598860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EnumValueDescriptorProto> Value { /* [XID] */ /* 0x0000000189657900-0x0000000189657920 */ get => default; } // 0x00000001845993E0-0x0000000184599480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnumOptions Options { /* [XID] */ /* 0x000000018965EF80-0x000000018965EFA0 */ get => default; /* [XID] */ /* 0x0000000189666780-0x00000001896667A0 */ set {} } // 0x0000000184599A70-0x0000000184599B50 0x0000000184599EC0-0x0000000184599FA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnumDescriptorProto() {} // 0x000000018459A320-0x000000018459A3C0
	static EnumDescriptorProto() {} // 0x000000018459A210-0x000000018459A320

	// Methods
	[DebuggerNonUserCode] // 0x0000000189609D10-0x0000000189609D50
	// [XID] // 0x0000000189609D10-0x0000000189609D50
	public EnumDescriptorProto Clone() => default; // 0x0000000184599580-0x00000001845996B0
	[DebuggerNonUserCode] // 0x0000000189614140-0x0000000189614180
	// [XID] // 0x0000000189614140-0x0000000189614180
	public EnumDescriptorProto ShallowCopy() => default; // 0x0000000184598F00-0x0000000184598FE0
	[DebuggerNonUserCode] // 0x000000018961ECC0-0x000000018961ED00
	// [XID] // 0x000000018961ECC0-0x000000018961ED00
	protected override void InternalSetInPool(bool value) {} // 0x0000000184598500-0x00000001845985C0
	[DebuggerNonUserCode] // 0x0000000189629260-0x00000001896292A0
	// [XID] // 0x0000000189629260-0x00000001896292A0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184599810-0x00000001845998F0
	[DebuggerNonUserCode] // 0x0000000189633B00-0x0000000189633B40
	// [XID] // 0x0000000189633B00-0x0000000189633B40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001845998F0-0x00000001845999D0
	[DebuggerNonUserCode] // 0x000000018963E230-0x000000018963E270
	// [XID] // 0x000000018963E230-0x000000018963E270
	public override void Reset() {} // 0x00000001845985C0-0x0000000184598700
	[DebuggerNonUserCode] // 0x000000018966DEC0-0x000000018966DF10
	// [IDTag] // 0x000000018966DEC0-0x000000018966DF10
	// [XID] // 0x000000018966DEC0-0x000000018966DF10
	public override bool Equals(object other) => default; // 0x0000000184598A50-0x0000000184598B60
	[DebuggerNonUserCode] // 0x000000018967BDD0-0x000000018967BE20
	// [IDTag] // 0x000000018967BDD0-0x000000018967BE20
	// [XID] // 0x000000018967BDD0-0x000000018967BE20
	public bool Equals(EnumDescriptorProto other) => default; // 0x0000000184598860-0x0000000184598A50
	[DebuggerNonUserCode] // 0x0000000189689780-0x00000001896897C0
	// [XID] // 0x0000000189689780-0x00000001896897C0
	public override int GetHashCode() => default; // 0x00000001845990E0-0x0000000184599270
	[DebuggerNonUserCode] // 0x0000000189694200-0x0000000189694240
	// [XID] // 0x0000000189694200-0x0000000189694240
	public override string ToString() => default; // 0x0000000184599FA0-0x000000018459A210
	[DebuggerNonUserCode] // 0x000000018969E9E0-0x000000018969EA20
	// [XID] // 0x000000018969E9E0-0x000000018969EA20
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184599B50-0x0000000184599D20
	[DebuggerNonUserCode] // 0x00000001896A8BC0-0x00000001896A8C00
	// [XID] // 0x00000001896A8BC0-0x00000001896A8C00
	public override int CalculateSize() => default; // 0x0000000184598B60-0x0000000184598D50
	[DebuggerNonUserCode] // 0x00000001896B2B80-0x00000001896B2BC0
	// [XID] // 0x00000001896B2B80-0x00000001896B2BC0
	public void CopyFrom(EnumDescriptorProto other) {} // 0x00000001845982C0-0x0000000184598500
	[DebuggerNonUserCode] // 0x00000001896BD1F0-0x00000001896BD230
	// [XID] // 0x00000001896BD1F0-0x00000001896BD230
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184597FC0-0x00000001845981B0
}

