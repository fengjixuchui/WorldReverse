/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityActionGenerateElemBall : MessageBase, IMessage<AbilityActionGenerateElemBall> // TypeDefIndex: 21774
{
	// Fields
	private static readonly MessageParser<AbilityActionGenerateElemBall> _parser; // 0x00
	public const int PosFieldNumber = 1; // Metadata: 0x00AFFF8B
	private Vector pos_; // 0x18
	public const int RotFieldNumber = 2; // Metadata: 0x00AFFF8F
	private Vector rot_; // 0x20
	public const int RoomIdFieldNumber = 3; // Metadata: 0x00AFFF93
	private uint roomId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityActionGenerateElemBall> Parser { get => default; } // 0x0000000184B80870-0x0000000184B80900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184B804C0-0x0000000184B80550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184B80090-0x0000000184B80110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184B7F5F0-0x0000000184B7F650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184B80DF0-0x0000000184B80EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184B80B50-0x0000000184B80BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184B80690-0x0000000184B80780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184B80DA0-0x0000000184B80DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184B801B0-0x0000000184B802A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000184B80AB0-0x0000000184B80B50 0x0000000184B80D00-0x0000000184B80DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Rot { get => default; set {} } // 0x0000000184B80550-0x0000000184B805F0 0x0000000184B7F6F0-0x0000000184B7F790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RoomId { get => default; set {} } // 0x0000000184B7F650-0x0000000184B7F6F0 0x0000000184B805F0-0x0000000184B80690

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityActionGenerateElemBall() {} // 0x0000000184B81200-0x0000000184B81260
	static AbilityActionGenerateElemBall() {} // 0x0000000184B81140-0x0000000184B81200

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityActionGenerateElemBall Clone() => default; // 0x0000000184B80780-0x0000000184B80870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityActionGenerateElemBall ShallowCopy() => default; // 0x0000000184B80110-0x0000000184B801B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B7F990-0x0000000184B7FA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B80990-0x0000000184B80A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B80A20-0x0000000184B80AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184B7FA20-0x0000000184B7FC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184B7FC10-0x0000000184B7FCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityActionGenerateElemBall other) => default; // 0x0000000184B7FCE0-0x0000000184B7FE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184B802A0-0x0000000184B804C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184B80EE0-0x0000000184B81140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B80BB0-0x0000000184B80D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184B7FE40-0x0000000184B80090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityActionGenerateElemBall other) {} // 0x0000000184B7F790-0x0000000184B7F990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B7F460-0x0000000184B7F5F0
}

