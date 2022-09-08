/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StringValue : MessageBase, IMessage<StringValue> // TypeDefIndex: 26474
{
	// Fields
	private static readonly MessageParser<StringValue> _parser; // 0x00
	public const int ValueFieldNumber = 1; // Metadata: 0x00B0C33C
	private string value_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<StringValue> Parser { /* [XID] */ /* 0x000000018989E700-0x000000018989E720 */ get => default; } // 0x0000000184D31400-0x0000000184D314D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001898A6220-0x00000001898A6240 */ get => default; } // 0x0000000184D30FA0-0x0000000184D31070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001898AD940-0x00000001898AD960 */ get => default; } // 0x0000000184D30BB0-0x0000000184D30C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001898B4DF0-0x00000001898B4E10 */ get => default; } // 0x0000000184D303A0-0x0000000184D30440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001898BC900-0x00000001898BC920 */ get => default; } // 0x0000000184D31A30-0x0000000184D31B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x00000001898C3EE0-0x00000001898C3F00 */ get => default; } // 0x0000000184D317B0-0x0000000184D31850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001898CB6E0-0x00000001898CB700 */ get => default; } // 0x0000000184D311D0-0x0000000184D312D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001898D2E10-0x00000001898D2E30 */ get => default; } // 0x0000000184D31990-0x0000000184D31A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001898DA760-0x00000001898DA780 */ get => default; } // 0x0000000184D30D60-0x0000000184D30E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Value { /* [XID] */ /* 0x0000000189921B40-0x0000000189921B60 */ get => default; /* [XID] */ /* 0x0000000189929260-0x0000000189929280 */ set {} } // 0x0000000184D310F0-0x0000000184D311D0 0x0000000184D31610-0x0000000184D31700

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StringValue() {} // 0x0000000184D31D80-0x0000000184D31DF0
	static StringValue() {} // 0x0000000184D31CC0-0x0000000184D31D80

	// Methods
	[DebuggerNonUserCode] // 0x00000001898E24B0-0x00000001898E24F0
	// [XID] // 0x00000001898E24B0-0x00000001898E24F0
	public StringValue Clone() => default; // 0x0000000184D312D0-0x0000000184D31400
	[DebuggerNonUserCode] // 0x00000001898ECCA0-0x00000001898ECCE0
	// [XID] // 0x00000001898ECCA0-0x00000001898ECCE0
	public StringValue ShallowCopy() => default; // 0x0000000184D30C80-0x0000000184D30D60
	[DebuggerNonUserCode] // 0x00000001898F7730-0x00000001898F7770
	// [XID] // 0x00000001898F7730-0x00000001898F7770
	protected override void InternalSetInPool(bool value) {} // 0x0000000184D30620-0x0000000184D306D0
	[DebuggerNonUserCode] // 0x0000000189901F20-0x0000000189901F60
	// [XID] // 0x0000000189901F20-0x0000000189901F60
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D31560-0x0000000184D31610
	[DebuggerNonUserCode] // 0x000000018990C8A0-0x000000018990C8E0
	// [XID] // 0x000000018990C8A0-0x000000018990C8E0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D31700-0x0000000184D317B0
	[DebuggerNonUserCode] // 0x0000000189917350-0x0000000189917390
	// [XID] // 0x0000000189917350-0x0000000189917390
	public override void Reset() {} // 0x0000000184D306D0-0x0000000184D30780
	[DebuggerNonUserCode] // 0x0000000189930860-0x00000001899308B0
	// [IDTag] // 0x0000000189930860-0x00000001899308B0
	// [XID] // 0x0000000189930860-0x00000001899308B0
	public override bool Equals(object other) => default; // 0x0000000184D30960-0x0000000184D30A70
	[DebuggerNonUserCode] // 0x000000018993DE40-0x000000018993DE90
	// [IDTag] // 0x000000018993DE40-0x000000018993DE90
	// [XID] // 0x000000018993DE40-0x000000018993DE90
	public bool Equals(StringValue other) => default; // 0x0000000184D307F0-0x0000000184D30960
	[DebuggerNonUserCode] // 0x000000018994B4E0-0x000000018994B520
	// [XID] // 0x000000018994B4E0-0x000000018994B520
	public override int GetHashCode() => default; // 0x0000000184D30E60-0x0000000184D30FA0
	[DebuggerNonUserCode] // 0x0000000189955AE0-0x0000000189955B20
	// [XID] // 0x0000000189955AE0-0x0000000189955B20
	public override string ToString() => default; // 0x0000000184D31B30-0x0000000184D31CC0
	[DebuggerNonUserCode] // 0x0000000189960310-0x0000000189960350
	// [XID] // 0x0000000189960310-0x0000000189960350
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184D31850-0x0000000184D31990
	[DebuggerNonUserCode] // 0x000000018996A960-0x000000018996A9A0
	// [XID] // 0x000000018996A960-0x000000018996A9A0
	public override int CalculateSize() => default; // 0x0000000184D30A70-0x0000000184D30BB0
	[DebuggerNonUserCode] // 0x0000000189975460-0x00000001899754A0
	// [XID] // 0x0000000189975460-0x00000001899754A0
	public void CopyFrom(StringValue other) {} // 0x0000000184D304B0-0x0000000184D30620
	[DebuggerNonUserCode] // 0x000000018997F970-0x000000018997F9B0
	// [XID] // 0x000000018997F970-0x000000018997F9B0
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184D30280-0x0000000184D303A0
}

