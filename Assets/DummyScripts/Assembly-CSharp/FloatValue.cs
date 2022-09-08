/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FloatValue : MessageBase, IMessage<FloatValue> // TypeDefIndex: 26468
{
	// Fields
	private static readonly MessageParser<FloatValue> _parser; // 0x00
	public const int ValueFieldNumber = 1; // Metadata: 0x00B0C324
	private float value_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FloatValue> Parser { /* [XID] */ /* 0x00000001896FFC00-0x00000001896FFC20 */ get => default; } // 0x00000001821FA9B0-0x00000001821FAA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189707310-0x0000000189707330 */ get => default; } // 0x00000001821FA520-0x00000001821FA610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x000000018970EBB0-0x000000018970EBD0 */ get => default; } // 0x00000001821FA140-0x00000001821FA210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189715FB0-0x0000000189715FD0 */ get => default; } // 0x00000001821F99B0-0x00000001821F9A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x000000018971D9F0-0x000000018971DA10 */ get => default; } // 0x00000001821FAFC0-0x00000001821FB0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189724E90-0x0000000189724EB0 */ get => default; } // 0x00000001821FAD50-0x00000001821FADF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x000000018972C5E0-0x000000018972C600 */ get => default; } // 0x00000001821FA780-0x00000001821FA880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189733D00-0x0000000189733D20 */ get => default; } // 0x00000001821FAF20-0x00000001821FAFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x000000018973B4A0-0x000000018973B4C0 */ get => default; } // 0x00000001821FA2F0-0x00000001821FA3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Value { /* [XID] */ /* 0x0000000189781BD0-0x0000000189781BF0 */ get => default; /* [XID] */ /* 0x0000000189789050-0x0000000189789070 */ set {} } // 0x00000001821FA690-0x00000001821FA780 0x00000001821FABC0-0x00000001821FACA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FloatValue() {} // 0x00000001821FB340-0x00000001821FB3A0
	static FloatValue() {} // 0x00000001821FB280-0x00000001821FB340

	// Methods
	[DebuggerNonUserCode] // 0x0000000189742E00-0x0000000189742E40
	// [XID] // 0x0000000189742E00-0x0000000189742E40
	public FloatValue Clone() => default; // 0x00000001821FA880-0x00000001821FA9B0
	[DebuggerNonUserCode] // 0x000000018974D910-0x000000018974D950
	// [XID] // 0x000000018974D910-0x000000018974D950
	public FloatValue ShallowCopy() => default; // 0x00000001821FA210-0x00000001821FA2F0
	[DebuggerNonUserCode] // 0x0000000189757B90-0x0000000189757BD0
	// [XID] // 0x0000000189757B90-0x0000000189757BD0
	protected override void InternalSetInPool(bool value) {} // 0x00000001821F9C20-0x00000001821F9CD0
	[DebuggerNonUserCode] // 0x00000001897624A0-0x00000001897624E0
	// [XID] // 0x00000001897624A0-0x00000001897624E0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821FAB10-0x00000001821FABC0
	[DebuggerNonUserCode] // 0x000000018976CAC0-0x000000018976CB00
	// [XID] // 0x000000018976CAC0-0x000000018976CB00
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821FACA0-0x00000001821FAD50
	[DebuggerNonUserCode] // 0x0000000189777060-0x00000001897770A0
	// [XID] // 0x0000000189777060-0x00000001897770A0
	public override void Reset() {} // 0x00000001821F9CD0-0x00000001821F9D70
	[DebuggerNonUserCode] // 0x0000000189790660-0x00000001897906B0
	// [IDTag] // 0x0000000189790660-0x00000001897906B0
	// [XID] // 0x0000000189790660-0x00000001897906B0
	public override bool Equals(object other) => default; // 0x00000001821F9F30-0x00000001821FA040
	[DebuggerNonUserCode] // 0x000000018979E730-0x000000018979E780
	// [IDTag] // 0x000000018979E730-0x000000018979E780
	// [XID] // 0x000000018979E730-0x000000018979E780
	public bool Equals(FloatValue other) => default; // 0x00000001821F9DE0-0x00000001821F9F30
	[DebuggerNonUserCode] // 0x00000001897AB7E0-0x00000001897AB820
	// [XID] // 0x00000001897AB7E0-0x00000001897AB820
	public override int GetHashCode() => default; // 0x00000001821FA3F0-0x00000001821FA520
	[DebuggerNonUserCode] // 0x00000001897B6B30-0x00000001897B6B70
	// [XID] // 0x00000001897B6B30-0x00000001897B6B70
	public override string ToString() => default; // 0x00000001821FB0C0-0x00000001821FB280
	[DebuggerNonUserCode] // 0x00000001897C15B0-0x00000001897C15F0
	// [XID] // 0x00000001897C15B0-0x00000001897C15F0
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001821FADF0-0x00000001821FAF20
	[DebuggerNonUserCode] // 0x00000001897CBC00-0x00000001897CBC40
	// [XID] // 0x00000001897CBC00-0x00000001897CBC40
	public override int CalculateSize() => default; // 0x00000001821FA040-0x00000001821FA140
	[DebuggerNonUserCode] // 0x00000001897D64A0-0x00000001897D64E0
	// [XID] // 0x00000001897D64A0-0x00000001897D64E0
	public void CopyFrom(FloatValue other) {} // 0x00000001821F9AC0-0x00000001821F9C20
	[DebuggerNonUserCode] // 0x00000001897E0DD0-0x00000001897E0E10
	// [XID] // 0x00000001897E0DD0-0x00000001897E0E10
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001821F9890-0x00000001821F99B0
}

