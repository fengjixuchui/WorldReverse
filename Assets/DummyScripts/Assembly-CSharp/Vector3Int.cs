/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Vector3Int : MessageBase, IMessage<Vector3Int> // TypeDefIndex: 26007
{
	// Fields
	private static readonly MessageParser<Vector3Int> _parser; // 0x00
	public const int XFieldNumber = 1; // Metadata: 0x00B0AA53
	private int x_; // 0x18
	public const int YFieldNumber = 2; // Metadata: 0x00B0AA57
	private int y_; // 0x1C
	public const int ZFieldNumber = 3; // Metadata: 0x00B0AA5B
	private int z_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Vector3Int> Parser { get => default; } // 0x00000001821F6840-0x00000001821F68D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001821F6490-0x00000001821F6520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001821F60B0-0x00000001821F6130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001821F5A90-0x00000001821F5AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001821F6CB0-0x00000001821F6DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001821F6A00-0x00000001821F6A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001821F6520-0x00000001821F6610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001821F6C60-0x00000001821F6CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001821F6270-0x00000001821F6360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int X { get => default; set {} } // 0x00000001821F6700-0x00000001821F67A0 0x00000001821F5840-0x00000001821F58E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Y { get => default; set {} } // 0x00000001821F61D0-0x00000001821F6270 0x00000001821F6BC0-0x00000001821F6C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Z { get => default; set {} } // 0x00000001821F59F0-0x00000001821F5A90 0x00000001821F67A0-0x00000001821F6840

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector3Int() {} // 0x00000001821F70F0-0x00000001821F7150
	static Vector3Int() {} // 0x00000001821F7030-0x00000001821F70F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector3Int Clone() => default; // 0x00000001821F6610-0x00000001821F6700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector3Int ShallowCopy() => default; // 0x00000001821F6130-0x00000001821F61D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001821F5C50-0x00000001821F5CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821F6960-0x00000001821F69B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001821F69B0-0x00000001821F6A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001821F5CA0-0x00000001821F5D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001821F5D20-0x00000001821F5DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Vector3Int other) => default; // 0x00000001821F5DF0-0x00000001821F5F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001821F6360-0x00000001821F6490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001821F6DA0-0x00000001821F7030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001821F6A60-0x00000001821F6BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001821F5F30-0x00000001821F60B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Vector3Int other) {} // 0x00000001821F5AF0-0x00000001821F5C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001821F58E0-0x00000001821F59F0
}

