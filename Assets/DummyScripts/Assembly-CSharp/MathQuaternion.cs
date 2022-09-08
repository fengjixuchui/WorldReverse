/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MathQuaternion : MessageBase, IMessage<MathQuaternion> // TypeDefIndex: 26018
{
	// Fields
	private static readonly MessageParser<MathQuaternion> _parser; // 0x00
	public const int XFieldNumber = 1; // Metadata: 0x00B0AB8F
	private float x_; // 0x18
	public const int YFieldNumber = 2; // Metadata: 0x00B0AB93
	private float y_; // 0x1C
	public const int ZFieldNumber = 3; // Metadata: 0x00B0AB97
	private float z_; // 0x20
	public const int WFieldNumber = 4; // Metadata: 0x00B0AB9B
	private float w_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MathQuaternion> Parser { get => default; } // 0x0000000183701BF0-0x0000000183701C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183701840-0x00000001837018D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183701400-0x0000000183701480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183700CA0-0x0000000183700D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001837020C0-0x00000001837021B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183701DB0-0x0000000183701E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001837018D0-0x00000001837019C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183702070-0x00000001837020C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001837015C0-0x00000001837016B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float X { get => default; set {} } // 0x0000000183701AB0-0x0000000183701B50 0x0000000183700A20-0x0000000183700AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Y { get => default; set {} } // 0x0000000183701520-0x00000001837015C0 0x0000000183701FD0-0x0000000183702070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Z { get => default; set {} } // 0x0000000183700C00-0x0000000183700CA0 0x0000000183701B50-0x0000000183701BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float W { get => default; set {} } // 0x0000000183700F80-0x0000000183701020 0x0000000183701020-0x00000001837010C0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MathQuaternion() {} // 0x00000001837025A0-0x0000000183702600
	static MathQuaternion() {} // 0x00000001837024E0-0x00000001837025A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MathQuaternion Clone() => default; // 0x00000001837019C0-0x0000000183701AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MathQuaternion ShallowCopy() => default; // 0x0000000183701480-0x0000000183701520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183700EA0-0x0000000183700EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183701D10-0x0000000183701D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183701D60-0x0000000183701DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183700EF0-0x0000000183700F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001837010C0-0x0000000183701190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MathQuaternion other) => default; // 0x0000000183701190-0x0000000183701300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001837016B0-0x0000000183701840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001837021B0-0x00000001837024E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183701E10-0x0000000183701FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183701300-0x0000000183701400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MathQuaternion other) {} // 0x0000000183700D00-0x0000000183700EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183700AC0-0x0000000183700C00
}

