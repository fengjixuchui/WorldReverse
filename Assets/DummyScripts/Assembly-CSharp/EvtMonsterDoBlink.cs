/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtMonsterDoBlink : MessageBase, IMessage<EvtMonsterDoBlink> // TypeDefIndex: 23028
{
	// Fields
	private static readonly MessageParser<EvtMonsterDoBlink> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B02FCB
	private uint entityId_; // 0x18
	public const int TargetPosFieldNumber = 2; // Metadata: 0x00B02FCF
	private Vector targetPos_; // 0x20
	public const int TargetRotFieldNumber = 3; // Metadata: 0x00B02FD3
	private Vector targetRot_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtMonsterDoBlink> Parser { get => default; } // 0x00000001827A93F0-0x00000001827A9480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001827A90E0-0x00000001827A9170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001827A8CB0-0x00000001827A8D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001827A82B0-0x00000001827A8310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001827A9970-0x00000001827A9A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001827A96D0-0x00000001827A9730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001827A9210-0x00000001827A9300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001827A9920-0x00000001827A9970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001827A8DD0-0x00000001827A8EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001827A9630-0x00000001827A96D0 0x00000001827A9A60-0x00000001827A9B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector TargetPos { get => default; set {} } // 0x00000001827A9170-0x00000001827A9210 0x00000001827A8C10-0x00000001827A8CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector TargetRot { get => default; set {} } // 0x00000001827A9730-0x00000001827A97D0 0x00000001827A9B00-0x00000001827A9BA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtMonsterDoBlink() {} // 0x00000001827A9EC0-0x00000001827A9F20
	static EvtMonsterDoBlink() {} // 0x00000001827A9E00-0x00000001827A9EC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtMonsterDoBlink Clone() => default; // 0x00000001827A9300-0x00000001827A93F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtMonsterDoBlink ShallowCopy() => default; // 0x00000001827A8D30-0x00000001827A8DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001827A8510-0x00000001827A85A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827A9510-0x00000001827A95A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827A95A0-0x00000001827A9630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001827A85A0-0x00000001827A8790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001827A88F0-0x00000001827A89C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtMonsterDoBlink other) => default; // 0x00000001827A8790-0x00000001827A88F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001827A8EC0-0x00000001827A90E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001827A9BA0-0x00000001827A9E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001827A97D0-0x00000001827A9920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001827A89C0-0x00000001827A8C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtMonsterDoBlink other) {} // 0x00000001827A8310-0x00000001827A8510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001827A8120-0x00000001827A82B0
}

