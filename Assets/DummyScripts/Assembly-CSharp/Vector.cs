/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Vector : MessageBase, IMessage<Vector> // TypeDefIndex: 26006
{
	// Fields
	private static readonly MessageParser<Vector> _parser; // 0x00
	public const int XFieldNumber = 1; // Metadata: 0x00B0AA47
	private float x_; // 0x18
	public const int YFieldNumber = 2; // Metadata: 0x00B0AA4B
	private float y_; // 0x1C
	public const int ZFieldNumber = 3; // Metadata: 0x00B0AA4F
	private float z_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Vector> Parser { get => default; } // 0x0000000181B884D0-0x0000000181B88560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181B88120-0x0000000181B881B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181B87D10-0x0000000181B87D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181B87770-0x0000000181B877D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181B88960-0x0000000181B88A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181B88690-0x0000000181B886F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181B881B0-0x0000000181B882A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181B88910-0x0000000181B88960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181B87ED0-0x0000000181B87FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float X { get => default; set {} } // 0x0000000181B88390-0x0000000181B88430 0x0000000181B87510-0x0000000181B875B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Y { get => default; set {} } // 0x0000000181B87E30-0x0000000181B87ED0 0x0000000181B88870-0x0000000181B88910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Z { get => default; set {} } // 0x0000000181B876D0-0x0000000181B87770 0x0000000181B88430-0x0000000181B884D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector() {} // 0x0000000181B88DB0-0x0000000181B88E10
	static Vector() {} // 0x0000000181B88CF0-0x0000000181B88DB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Clone() => default; // 0x0000000181B882A0-0x0000000181B88390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector ShallowCopy() => default; // 0x0000000181B87D90-0x0000000181B87E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181B87940-0x0000000181B87990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B885F0-0x0000000181B88640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B88640-0x0000000181B88690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181B87990-0x0000000181B87A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181B87B50-0x0000000181B87C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Vector other) => default; // 0x0000000181B87A10-0x0000000181B87B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181B87FC0-0x0000000181B88120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181B88A50-0x0000000181B88CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181B886F0-0x0000000181B88870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181B87C20-0x0000000181B87D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Vector other) {} // 0x0000000181B877D0-0x0000000181B87940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181B875B0-0x0000000181B876D0
}

