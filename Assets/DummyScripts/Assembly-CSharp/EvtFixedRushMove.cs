/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtFixedRushMove : MessageBase, IMessage<EvtFixedRushMove> // TypeDefIndex: 23029
{
	// Fields
	private static readonly MessageParser<EvtFixedRushMove> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B02FD7
	private uint entityId_; // 0x18
	public const int SpeedFieldNumber = 2; // Metadata: 0x00B02FDB
	private float speed_; // 0x1C
	public const int TargetPosFieldNumber = 3; // Metadata: 0x00B02FDF
	private Vector targetPos_; // 0x20
	public const int OverrideColliderFieldNumber = 4; // Metadata: 0x00B02FE3
	private string overrideCollider_; // 0x28
	public const int AnimatorStateIdListFieldNumber = 5; // Metadata: 0x00B02FE7
	private static readonly FieldCodec<uint> _repeated_animatorStateIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> animatorStateIdList_; // 0x30
	public const int NeedSetIsInAirFieldNumber = 6; // Metadata: 0x00B02FEB
	private bool needSetIsInAir_; // 0x38
	public const int CheckAnimatorStateOnExitOnlyFieldNumber = 7; // Metadata: 0x00B02FEF
	private bool checkAnimatorStateOnExitOnly_; // 0x39

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtFixedRushMove> Parser { get => default; } // 0x00000001845769E0-0x0000000184576A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184576630-0x00000001845766C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001845760D0-0x0000000184576150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184575280-0x00000001845752E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184577090-0x0000000184577180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184576CA0-0x0000000184576D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184576760-0x0000000184576850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184577040-0x0000000184577090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001845761F0-0x00000001845762E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000184576C00-0x0000000184576CA0 0x0000000184577180-0x0000000184577220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Speed { get => default; set {} } // 0x0000000184575F90-0x0000000184576030 0x0000000184576590-0x0000000184576630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector TargetPos { get => default; set {} } // 0x00000001845766C0-0x0000000184576760 0x0000000184575EF0-0x0000000184575F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OverrideCollider { get => default; set {} } // 0x0000000184576940-0x00000001845769E0 0x0000000184575E40-0x0000000184575EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AnimatorStateIdList { get => default; } // 0x0000000184574FE0-0x0000000184575040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool NeedSetIsInAir { get => default; set {} } // 0x0000000184576030-0x00000001845760D0 0x0000000184575550-0x00000001845755F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool CheckAnimatorStateOnExitOnly { get => default; set {} } // 0x0000000184575B10-0x0000000184575BB0 0x0000000184576D00-0x0000000184576DA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFixedRushMove() {} // 0x0000000184577770-0x0000000184577810
	static EvtFixedRushMove() {} // 0x0000000184577690-0x0000000184577770

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFixedRushMove Clone() => default; // 0x0000000184576850-0x0000000184576940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtFixedRushMove ShallowCopy() => default; // 0x0000000184576150-0x00000001845761F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001845755F0-0x0000000184575670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184576B00-0x0000000184576B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184576B80-0x0000000184576C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184575670-0x0000000184575830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184575830-0x0000000184575900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtFixedRushMove other) => default; // 0x0000000184575900-0x0000000184575B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001845762E0-0x0000000184576590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184577220-0x0000000184577690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184576DA0-0x0000000184577040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184575BB0-0x0000000184575E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtFixedRushMove other) {} // 0x00000001845752E0-0x0000000184575550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184575040-0x0000000184575280
}

