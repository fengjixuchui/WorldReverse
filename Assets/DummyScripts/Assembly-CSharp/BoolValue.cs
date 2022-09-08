/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BoolValue : MessageBase, IMessage<BoolValue> // TypeDefIndex: 26473
{
	// Fields
	private static readonly MessageParser<BoolValue> _parser; // 0x00
	public const int ValueFieldNumber = 1; // Metadata: 0x00B0C338
	private bool value_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BoolValue> Parser { /* [XID] */ /* 0x000000018975A940-0x000000018975A960 */ get => default; } // 0x0000000182B9C2A0-0x0000000182B9C370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189762480-0x00000001897624A0 */ get => default; } // 0x0000000182B9BE20-0x0000000182B9BF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189769B30-0x0000000189769B50 */ get => default; } // 0x0000000182B9BA50-0x0000000182B9BB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189771150-0x0000000189771170 */ get => default; } // 0x0000000182B9B2E0-0x0000000182B9B380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001897789B0-0x00000001897789D0 */ get => default; } // 0x0000000182B9C8A0-0x0000000182B9C9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x000000018977FF50-0x000000018977FF70 */ get => default; } // 0x0000000182B9C640-0x0000000182B9C6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001897877C0-0x00000001897877E0 */ get => default; } // 0x0000000182B9C070-0x0000000182B9C170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x000000018978EE90-0x000000018978EEB0 */ get => default; } // 0x0000000182B9C800-0x0000000182B9C8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189796690-0x00000001897966B0 */ get => default; } // 0x0000000182B9BC00-0x0000000182B9BD00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Value { /* [XID] */ /* 0x00000001897DDD00-0x00000001897DDD20 */ get => default; /* [XID] */ /* 0x00000001897E56B0-0x00000001897E56D0 */ set {} } // 0x0000000182B9BF90-0x0000000182B9C070 0x0000000182B9C4B0-0x0000000182B9C590

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BoolValue() {} // 0x0000000182B9CC10-0x0000000182B9CC70
	static BoolValue() {} // 0x0000000182B9CB50-0x0000000182B9CC10

	// Methods
	[DebuggerNonUserCode] // 0x000000018979E6F0-0x000000018979E730
	// [XID] // 0x000000018979E6F0-0x000000018979E730
	public BoolValue Clone() => default; // 0x0000000182B9C170-0x0000000182B9C2A0
	[DebuggerNonUserCode] // 0x00000001897A89C0-0x00000001897A8A00
	// [XID] // 0x00000001897A89C0-0x00000001897A8A00
	public BoolValue ShallowCopy() => default; // 0x0000000182B9BB20-0x0000000182B9BC00
	[DebuggerNonUserCode] // 0x00000001897B36B0-0x00000001897B36F0
	// [XID] // 0x00000001897B36B0-0x00000001897B36F0
	protected override void InternalSetInPool(bool value) {} // 0x0000000182B9B540-0x0000000182B9B5F0
	[DebuggerNonUserCode] // 0x00000001897BE9D0-0x00000001897BEA10
	// [XID] // 0x00000001897BE9D0-0x00000001897BEA10
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B9C400-0x0000000182B9C4B0
	[DebuggerNonUserCode] // 0x00000001897C8FE0-0x00000001897C9020
	// [XID] // 0x00000001897C8FE0-0x00000001897C9020
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B9C590-0x0000000182B9C640
	[DebuggerNonUserCode] // 0x00000001897D3590-0x00000001897D35D0
	// [XID] // 0x00000001897D3590-0x00000001897D35D0
	public override void Reset() {} // 0x0000000182B9B5F0-0x0000000182B9B690
	[DebuggerNonUserCode] // 0x00000001897ED190-0x00000001897ED1E0
	// [IDTag] // 0x00000001897ED190-0x00000001897ED1E0
	// [XID] // 0x00000001897ED190-0x00000001897ED1E0
	public override bool Equals(object other) => default; // 0x0000000182B9B840-0x0000000182B9B950
	[DebuggerNonUserCode] // 0x00000001897FAC50-0x00000001897FACA0
	// [IDTag] // 0x00000001897FAC50-0x00000001897FACA0
	// [XID] // 0x00000001897FAC50-0x00000001897FACA0
	public bool Equals(BoolValue other) => default; // 0x0000000182B9B700-0x0000000182B9B840
	[DebuggerNonUserCode] // 0x0000000189807EF0-0x0000000189807F30
	// [XID] // 0x0000000189807EF0-0x0000000189807F30
	public override int GetHashCode() => default; // 0x0000000182B9BD00-0x0000000182B9BE20
	[DebuggerNonUserCode] // 0x0000000189812480-0x00000001898124C0
	// [XID] // 0x0000000189812480-0x00000001898124C0
	public override string ToString() => default; // 0x0000000182B9C9A0-0x0000000182B9CB50
	[DebuggerNonUserCode] // 0x000000018981CFD0-0x000000018981D010
	// [XID] // 0x000000018981CFD0-0x000000018981D010
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182B9C6E0-0x0000000182B9C800
	[DebuggerNonUserCode] // 0x0000000189827780-0x00000001898277C0
	// [XID] // 0x0000000189827780-0x00000001898277C0
	public override int CalculateSize() => default; // 0x0000000182B9B950-0x0000000182B9BA50
	[DebuggerNonUserCode] // 0x0000000189831A30-0x0000000189831A70
	// [XID] // 0x0000000189831A30-0x0000000189831A70
	public void CopyFrom(BoolValue other) {} // 0x0000000182B9B3F0-0x0000000182B9B540
	[DebuggerNonUserCode] // 0x000000018983C1B0-0x000000018983C1F0
	// [XID] // 0x000000018983C1B0-0x000000018983C1F0
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182B9B1C0-0x0000000182B9B2E0
}

