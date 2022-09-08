/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtSyncTransform : MessageBase, IMessage<EvtSyncTransform> // TypeDefIndex: 23030
{
	// Fields
	private static readonly MessageParser<EvtSyncTransform> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B02FF3
	private uint entityId_; // 0x18
	public const int EntityPosFieldNumber = 2; // Metadata: 0x00B02FF7
	private Vector entityPos_; // 0x20
	public const int EntityRotFieldNumber = 3; // Metadata: 0x00B02FFB
	private Vector entityRot_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtSyncTransform> Parser { get => default; } // 0x00000001840C25E0-0x00000001840C2670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001840C22D0-0x00000001840C2360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001840C1EA0-0x00000001840C1F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001840C14A0-0x00000001840C1500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001840C2C00-0x00000001840C2CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001840C2A00-0x00000001840C2A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001840C2360-0x00000001840C2450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001840C2BB0-0x00000001840C2C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001840C1FC0-0x00000001840C20B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001840C2960-0x00000001840C2A00 0x00000001840C2CF0-0x00000001840C2D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector EntityPos { get => default; set {} } // 0x00000001840C28C0-0x00000001840C2960 0x00000001840C2540-0x00000001840C25E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector EntityRot { get => default; set {} } // 0x00000001840C1700-0x00000001840C17A0 0x00000001840C2820-0x00000001840C28C0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSyncTransform() {} // 0x00000001840C30B0-0x00000001840C3110
	static EvtSyncTransform() {} // 0x00000001840C2FF0-0x00000001840C30B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSyncTransform Clone() => default; // 0x00000001840C2450-0x00000001840C2540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSyncTransform ShallowCopy() => default; // 0x00000001840C1F20-0x00000001840C1FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001840C17A0-0x00000001840C1830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001840C2700-0x00000001840C2790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001840C2790-0x00000001840C2820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001840C1830-0x00000001840C1A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001840C1A20-0x00000001840C1AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtSyncTransform other) => default; // 0x00000001840C1AF0-0x00000001840C1C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001840C20B0-0x00000001840C22D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001840C2D90-0x00000001840C2FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001840C2A60-0x00000001840C2BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001840C1C50-0x00000001840C1EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtSyncTransform other) {} // 0x00000001840C1500-0x00000001840C1700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001840C1310-0x00000001840C14A0
}

