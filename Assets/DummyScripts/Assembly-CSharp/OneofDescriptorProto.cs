/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class OneofDescriptorProto : MessageBase, IMessage<OneofDescriptorProto> // TypeDefIndex: 26366
{
	// Fields
	private static readonly MessageParser<OneofDescriptorProto> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0BFA9
	private string name_; // 0x18
	public const int OptionsFieldNumber = 2; // Metadata: 0x00B0BFAD
	private OneofOptions options_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OneofDescriptorProto> Parser { /* [XID] */ /* 0x0000000189A661E0-0x0000000189A66200 */ get => default; } // 0x0000000184A41840-0x0000000184A41910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189A6D930-0x0000000189A6D950 */ get => default; } // 0x0000000184A414A0-0x0000000184A41590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189A75020-0x0000000189A75040 */ get => default; } // 0x0000000184A41080-0x0000000184A41150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189A7CC00-0x0000000189A7CC20 */ get => default; } // 0x0000000184A40520-0x0000000184A405C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189A84540-0x0000000189A84560 */ get => default; } // 0x0000000184A41EB0-0x0000000184A41FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189A8BEB0-0x0000000189A8BED0 */ get => default; } // 0x0000000184A41B20-0x0000000184A41BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189A933C0-0x0000000189A933E0 */ get => default; } // 0x0000000184A41610-0x0000000184A41710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189A9AEF0-0x0000000189A9AF10 */ get => default; } // 0x0000000184A41E10-0x0000000184A41EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189AA21F0-0x0000000189AA2210 */ get => default; } // 0x0000000184A41230-0x0000000184A41330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x0000000189AE94A0-0x0000000189AE94C0 */ get => default; /* [XID] */ /* 0x0000000189AF1250-0x0000000189AF1270 */ set {} } // 0x0000000184A40FA0-0x0000000184A41080 0x0000000184A40A50-0x0000000184A40B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OneofOptions Options { /* [XID] */ /* 0x0000000189AF8820-0x0000000189AF8840 */ get => default; /* [XID] */ /* 0x0000000189AFFDE0-0x0000000189AFFE00 */ set {} } // 0x0000000184A41BC0-0x0000000184A41CA0 0x0000000184A41FB0-0x0000000184A42090

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OneofDescriptorProto() {} // 0x0000000184A42350-0x0000000184A423C0
	static OneofDescriptorProto() {} // 0x0000000184A42290-0x0000000184A42350

	// Methods
	[DebuggerNonUserCode] // 0x0000000189AA96D0-0x0000000189AA9710
	// [XID] // 0x0000000189AA96D0-0x0000000189AA9710
	public OneofDescriptorProto Clone() => default; // 0x0000000184A41710-0x0000000184A41840
	[DebuggerNonUserCode] // 0x0000000189AB43D0-0x0000000189AB4410
	// [XID] // 0x0000000189AB43D0-0x0000000189AB4410
	public OneofDescriptorProto ShallowCopy() => default; // 0x0000000184A41150-0x0000000184A41230
	[DebuggerNonUserCode] // 0x0000000189ABECE0-0x0000000189ABED20
	// [XID] // 0x0000000189ABECE0-0x0000000189ABED20
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A40820-0x0000000184A408E0
	[DebuggerNonUserCode] // 0x0000000189AC9590-0x0000000189AC95D0
	// [XID] // 0x0000000189AC9590-0x0000000189AC95D0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A419A0-0x0000000184A41A60
	[DebuggerNonUserCode] // 0x0000000189AD4200-0x0000000189AD4240
	// [XID] // 0x0000000189AD4200-0x0000000189AD4240
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A41A60-0x0000000184A41B20
	[DebuggerNonUserCode] // 0x0000000189ADED50-0x0000000189ADED90
	// [XID] // 0x0000000189ADED50-0x0000000189ADED90
	public override void Reset() {} // 0x0000000184A408E0-0x0000000184A409E0
	[DebuggerNonUserCode] // 0x0000000189B07390-0x0000000189B073E0
	// [IDTag] // 0x0000000189B07390-0x0000000189B073E0
	// [XID] // 0x0000000189B07390-0x0000000189B073E0
	public override bool Equals(object other) => default; // 0x0000000184A40D00-0x0000000184A40E10
	[DebuggerNonUserCode] // 0x0000000189B14940-0x0000000189B14990
	// [IDTag] // 0x0000000189B14940-0x0000000189B14990
	// [XID] // 0x0000000189B14940-0x0000000189B14990
	public bool Equals(OneofDescriptorProto other) => default; // 0x0000000184A40B40-0x0000000184A40D00
	[DebuggerNonUserCode] // 0x0000000189B21F00-0x0000000189B21F40
	// [XID] // 0x0000000189B21F00-0x0000000189B21F40
	public override int GetHashCode() => default; // 0x0000000184A41330-0x0000000184A414A0
	[DebuggerNonUserCode] // 0x0000000189B2C420-0x0000000189B2C460
	// [XID] // 0x0000000189B2C420-0x0000000189B2C460
	public override string ToString() => default; // 0x0000000184A42090-0x0000000184A42290
	[DebuggerNonUserCode] // 0x0000000189B368F0-0x0000000189B36930
	// [XID] // 0x0000000189B368F0-0x0000000189B36930
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A41CA0-0x0000000184A41E10
	[DebuggerNonUserCode] // 0x0000000189B412D0-0x0000000189B41310
	// [XID] // 0x0000000189B412D0-0x0000000189B41310
	public override int CalculateSize() => default; // 0x0000000184A40E10-0x0000000184A40FA0
	[DebuggerNonUserCode] // 0x0000000189B4BC50-0x0000000189B4BC90
	// [XID] // 0x0000000189B4BC50-0x0000000189B4BC90
	public void CopyFrom(OneofDescriptorProto other) {} // 0x0000000184A40630-0x0000000184A40820
	[DebuggerNonUserCode] // 0x0000000189B564E0-0x0000000189B56520
	// [XID] // 0x0000000189B564E0-0x0000000189B56520
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A40390-0x0000000184A40520
}

