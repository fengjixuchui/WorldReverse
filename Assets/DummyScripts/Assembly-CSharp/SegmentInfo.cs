/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SegmentInfo : MessageBase, IMessage<SegmentInfo> // TypeDefIndex: 24003
{
	// Fields
	private static readonly MessageParser<SegmentInfo> _parser; // 0x00
	public const int ModuleFieldNumber = 1; // Metadata: 0x00B05543
	private uint module_; // 0x18
	public const int OffsetFieldNumber = 2; // Metadata: 0x00B05547
	private uint offset_; // 0x1C
	public const int SizeFieldNumber = 3; // Metadata: 0x00B0554B
	private uint size_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SegmentInfo> Parser { get => default; } // 0x0000000181088080-0x0000000181088110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181087CD0-0x0000000181087D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001810878F0-0x0000000181087970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001810870F0-0x0000000181087150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181088450-0x0000000181088540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181088240-0x00000001810882A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181087E00-0x0000000181087EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181088400-0x0000000181088450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181087AB0-0x0000000181087BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Module { get => default; set {} } // 0x00000001810872B0-0x0000000181087350 0x0000000181087970-0x0000000181087A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Offset { get => default; set {} } // 0x0000000181087850-0x00000001810878F0 0x0000000181087420-0x00000001810874C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Size { get => default; set {} } // 0x0000000181087FE0-0x0000000181088080 0x0000000181087D60-0x0000000181087E00

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SegmentInfo() {} // 0x0000000181088890-0x00000001810888F0
	static SegmentInfo() {} // 0x00000001810887D0-0x0000000181088890

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SegmentInfo Clone() => default; // 0x0000000181087EF0-0x0000000181087FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SegmentInfo ShallowCopy() => default; // 0x0000000181087A10-0x0000000181087AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181087350-0x00000001810873A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001810881A0-0x00000001810881F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001810881F0-0x0000000181088240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001810873A0-0x0000000181087420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001810874C0-0x0000000181087590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SegmentInfo other) => default; // 0x0000000181087590-0x00000001810876D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181087BA0-0x0000000181087CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181088540-0x00000001810887D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001810882A0-0x0000000181088400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001810876D0-0x0000000181087850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SegmentInfo other) {} // 0x0000000181087150-0x00000001810872B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181086FE0-0x00000001810870F0
}

