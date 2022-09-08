/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtRushMoveInfo : MessageBase, IMessage<EvtRushMoveInfo> // TypeDefIndex: 23034
{
	// Fields
	private static readonly MessageParser<EvtRushMoveInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0301B
	private uint entityId_; // 0x18
	public const int VelocityFieldNumber = 2; // Metadata: 0x00B0301F
	private Vector velocity_; // 0x20
	public const int TimeRangeFieldNumber = 3; // Metadata: 0x00B03023
	private float timeRange_; // 0x28
	public const int StateNameHashFieldNumber = 4; // Metadata: 0x00B03027
	private int stateNameHash_; // 0x2C
	public const int FaceAngleCompactFieldNumber = 5; // Metadata: 0x00B0302B
	private int faceAngleCompact_; // 0x30
	public const int PosFieldNumber = 6; // Metadata: 0x00B0302F
	private Vector pos_; // 0x38
	public const int RushAttackTargetPosFieldNumber = 7; // Metadata: 0x00B03033
	private Vector rushAttackTargetPos_; // 0x40
	public const int RushToPosFieldNumber = 8; // Metadata: 0x00B03037
	private Vector rushToPos_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtRushMoveInfo> Parser { get => default; } // 0x0000000181F62D50-0x0000000181F62DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181F629A0-0x0000000181F62A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181F622F0-0x0000000181F62370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181F61070-0x0000000181F610D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181F636D0-0x0000000181F637C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181F63250-0x0000000181F632B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181F62AD0-0x0000000181F62BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181F63680-0x0000000181F636D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181F62410-0x0000000181F62500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181F631B0-0x0000000181F63250 0x0000000181F637C0-0x0000000181F63860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Velocity { get => default; set {} } // 0x0000000181F614C0-0x0000000181F61560 0x0000000181F62A30-0x0000000181F62AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float TimeRange { get => default; set {} } // 0x0000000181F60FD0-0x0000000181F61070 0x0000000181F61560-0x0000000181F61600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int StateNameHash { get => default; set {} } // 0x0000000181F62E70-0x0000000181F62F10 0x0000000181F635E0-0x0000000181F63680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int FaceAngleCompact { get => default; set {} } // 0x0000000181F62900-0x0000000181F629A0 0x0000000181F63110-0x0000000181F631B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000181F63070-0x0000000181F63110 0x0000000181F63540-0x0000000181F635E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector RushAttackTargetPos { get => default; set {} } // 0x0000000181F61AF0-0x0000000181F61B90 0x0000000181F62CB0-0x0000000181F62D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector RushToPos { get => default; set {} } // 0x0000000181F610D0-0x0000000181F61170 0x0000000181F616C0-0x0000000181F61760

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtRushMoveInfo() {} // 0x0000000181F63E00-0x0000000181F63E60
	static EvtRushMoveInfo() {} // 0x0000000181F63D40-0x0000000181F63E00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtRushMoveInfo Clone() => default; // 0x0000000181F62BC0-0x0000000181F62CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtRushMoveInfo ShallowCopy() => default; // 0x0000000181F62370-0x0000000181F62410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181F61600-0x0000000181F616C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F62F10-0x0000000181F62FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181F62FC0-0x0000000181F63070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181F61760-0x0000000181F61AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181F61B90-0x0000000181F61C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtRushMoveInfo other) => default; // 0x0000000181F61C60-0x0000000181F61E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181F62500-0x0000000181F62900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181F63860-0x0000000181F63D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181F632B0-0x0000000181F63540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181F61E90-0x0000000181F622F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtRushMoveInfo other) {} // 0x0000000181F61170-0x0000000181F614C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181F60D30-0x0000000181F60FD0
}

