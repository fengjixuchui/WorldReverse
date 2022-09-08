/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CellInfo : MessageBase, IMessage<CellInfo> // TypeDefIndex: 26107
{
	// Fields
	private static readonly MessageParser<CellInfo> _parser; // 0x00
	public const int TypeFieldNumber = 1; // Metadata: 0x00B0B273
	private SceneSurfaceMaterial type_; // 0x18
	public const int YFieldNumber = 2; // Metadata: 0x00B0B277
	private int y_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CellInfo> Parser { get => default; } // 0x0000000182113C70-0x0000000182113D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182113A00-0x0000000182113A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182113600-0x0000000182113680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182113090-0x00000001821130F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182114140-0x0000000182114230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182113E30-0x0000000182113E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182113A90-0x0000000182113B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182114050-0x00000001821140A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001821137C0-0x00000001821138B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneSurfaceMaterial Type { get => default; set {} } // 0x0000000182112F00-0x0000000182112FA0 0x00000001821140A0-0x0000000182114140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Y { get => default; set {} } // 0x0000000182113720-0x00000001821137C0 0x0000000182113FB0-0x0000000182114050

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CellInfo() {} // 0x00000001821144F0-0x0000000182114560
	static CellInfo() {} // 0x0000000182114430-0x00000001821144F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CellInfo Clone() => default; // 0x0000000182113B80-0x0000000182113C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CellInfo ShallowCopy() => default; // 0x0000000182113680-0x0000000182113720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182113220-0x0000000182113270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182113D90-0x0000000182113DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182113DE0-0x0000000182113E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182113270-0x00000001821132E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001821132E0-0x00000001821133B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CellInfo other) => default; // 0x00000001821133B0-0x00000001821134D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001821138B0-0x0000000182113A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182114230-0x0000000182114430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182113E90-0x0000000182113FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001821134D0-0x0000000182113600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CellInfo other) {} // 0x00000001821130F0-0x0000000182113220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182112FA0-0x0000000182113090
}

