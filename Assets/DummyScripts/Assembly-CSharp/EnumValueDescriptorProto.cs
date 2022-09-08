/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class EnumValueDescriptorProto : MessageBase, IMessage<EnumValueDescriptorProto> // TypeDefIndex: 26368
{
	// Fields
	private static readonly MessageParser<EnumValueDescriptorProto> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0BFBD
	private string name_; // 0x18
	public const int NumberFieldNumber = 2; // Metadata: 0x00B0BFC1
	private int number_; // 0x20
	public const int OptionsFieldNumber = 3; // Metadata: 0x00B0BFC5
	private EnumValueOptions options_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnumValueDescriptorProto> Parser { /* [XID] */ /* 0x000000018972F6A0-0x000000018972F6C0 */ get => default; } // 0x00000001834FB170-0x00000001834FB240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189737110-0x0000000189737130 */ get => default; } // 0x00000001834FACF0-0x00000001834FADE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x000000018973EC80-0x000000018973ECA0 */ get => default; } // 0x00000001834FA7C0-0x00000001834FA890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189745F00-0x0000000189745F20 */ get => default; } // 0x00000001834F9BC0-0x00000001834F9C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x000000018974D990-0x000000018974D9B0 */ get => default; } // 0x00000001834FB830-0x00000001834FB930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189754FB0-0x0000000189754FD0 */ get => default; } // 0x00000001834FB450-0x00000001834FB4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x000000018975C180-0x000000018975C1A0 */ get => default; } // 0x00000001834FAF40-0x00000001834FB040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189763B20-0x0000000189763B40 */ get => default; } // 0x00000001834FB790-0x00000001834FB830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x000000018976B2F0-0x000000018976B310 */ get => default; } // 0x00000001834FA970-0x00000001834FAA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x00000001897B1B80-0x00000001897B1BA0 */ get => default; /* [XID] */ /* 0x00000001897B9660-0x00000001897B9680 */ set {} } // 0x00000001834FA6E0-0x00000001834FA7C0 0x00000001834FA120-0x00000001834FA210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Number { /* [XID] */ /* 0x00000001897C1610-0x00000001897C1630 */ get => default; /* [XID] */ /* 0x00000001897C90C0-0x00000001897C90E0 */ set {} } // 0x00000001834FAC10-0x00000001834FACF0 0x00000001834FAE60-0x00000001834FAF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnumValueOptions Options { /* [XID] */ /* 0x00000001897D0680-0x00000001897D06A0 */ get => default; /* [XID] */ /* 0x00000001897D8410-0x00000001897D8430 */ set {} } // 0x00000001834FB4F0-0x00000001834FB5D0 0x00000001834FB930-0x00000001834FBA10

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnumValueDescriptorProto() {} // 0x00000001834FBD70-0x00000001834FBDE0
	static EnumValueDescriptorProto() {} // 0x00000001834FBCB0-0x00000001834FBD70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189772920-0x0000000189772960
	// [XID] // 0x0000000189772920-0x0000000189772960
	public EnumValueDescriptorProto Clone() => default; // 0x00000001834FB040-0x00000001834FB170
	[DebuggerNonUserCode] // 0x000000018977D110-0x000000018977D150
	// [XID] // 0x000000018977D110-0x000000018977D150
	public EnumValueDescriptorProto ShallowCopy() => default; // 0x00000001834FA890-0x00000001834FA970
	[DebuggerNonUserCode] // 0x0000000189787860-0x00000001897878A0
	// [XID] // 0x0000000189787860-0x00000001897878A0
	protected override void InternalSetInPool(bool value) {} // 0x00000001834F9EE0-0x00000001834F9FA0
	[DebuggerNonUserCode] // 0x0000000189791DB0-0x0000000189791DF0
	// [XID] // 0x0000000189791DB0-0x0000000189791DF0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001834FB2D0-0x00000001834FB390
	[DebuggerNonUserCode] // 0x000000018979CF80-0x000000018979CFC0
	// [XID] // 0x000000018979CF80-0x000000018979CFC0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001834FB390-0x00000001834FB450
	[DebuggerNonUserCode] // 0x00000001897A7370-0x00000001897A73B0
	// [XID] // 0x00000001897A7370-0x00000001897A73B0
	public override void Reset() {} // 0x00000001834F9FA0-0x00000001834FA0B0
	[DebuggerNonUserCode] // 0x00000001897DF420-0x00000001897DF470
	// [IDTag] // 0x00000001897DF420-0x00000001897DF470
	// [XID] // 0x00000001897DF420-0x00000001897DF470
	public override bool Equals(object other) => default; // 0x00000001834FA210-0x00000001834FA320
	[DebuggerNonUserCode] // 0x00000001897ED220-0x00000001897ED270
	// [IDTag] // 0x00000001897ED220-0x00000001897ED270
	// [XID] // 0x00000001897ED220-0x00000001897ED270
	public bool Equals(EnumValueDescriptorProto other) => default; // 0x00000001834FA320-0x00000001834FA500
	[DebuggerNonUserCode] // 0x00000001897FAD20-0x00000001897FAD60
	// [XID] // 0x00000001897FAD20-0x00000001897FAD60
	public override int GetHashCode() => default; // 0x00000001834FAA70-0x00000001834FAC10
	[DebuggerNonUserCode] // 0x0000000189804ED0-0x0000000189804F10
	// [XID] // 0x0000000189804ED0-0x0000000189804F10
	public override string ToString() => default; // 0x00000001834FBA10-0x00000001834FBCB0
	[DebuggerNonUserCode] // 0x000000018980F870-0x000000018980F8B0
	// [XID] // 0x000000018980F870-0x000000018980F8B0
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001834FB5D0-0x00000001834FB790
	[DebuggerNonUserCode] // 0x000000018981A110-0x000000018981A150
	// [XID] // 0x000000018981A110-0x000000018981A150
	public override int CalculateSize() => default; // 0x00000001834FA500-0x00000001834FA6E0
	[DebuggerNonUserCode] // 0x00000001898243C0-0x0000000189824400
	// [XID] // 0x00000001898243C0-0x0000000189824400
	public void CopyFrom(EnumValueDescriptorProto other) {} // 0x00000001834F9CD0-0x00000001834F9EE0
	[DebuggerNonUserCode] // 0x000000018982EA60-0x000000018982EAA0
	// [XID] // 0x000000018982EA60-0x000000018982EAA0
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001834F9A10-0x00000001834F9BC0
}

