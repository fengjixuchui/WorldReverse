/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtSyncEntityPositionInfo : MessageBase, IMessage<EvtSyncEntityPositionInfo> // TypeDefIndex: 23038
{
	// Fields
	private static readonly MessageParser<EvtSyncEntityPositionInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0306B
	private uint entityId_; // 0x18
	public const int StateHashFieldNumber = 2; // Metadata: 0x00B0306F
	private uint stateHash_; // 0x1C
	public const int NormalizedTimeCompactFieldNumber = 3; // Metadata: 0x00B03073
	private uint normalizedTimeCompact_; // 0x20
	public const int FaceAngleCompactFieldNumber = 4; // Metadata: 0x00B03077
	private int faceAngleCompact_; // 0x24
	public const int PosFieldNumber = 5; // Metadata: 0x00B0307B
	private Vector pos_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtSyncEntityPositionInfo> Parser { get => default; } // 0x0000000182707CD0-0x0000000182707D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182707920-0x00000001827079B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182707460-0x00000001827074E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182706AC0-0x0000000182706B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182708490-0x0000000182708580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182708170-0x00000001827081D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182707A50-0x0000000182707B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182708440-0x0000000182708490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182707580-0x0000000182707670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001827080D0-0x0000000182708170 0x0000000182708580-0x0000000182708620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StateHash { get => default; set {} } // 0x00000001827079B0-0x0000000182707A50 0x0000000182706EF0-0x0000000182706F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NormalizedTimeCompact { get => default; set {} } // 0x0000000182707E70-0x0000000182707F10 0x0000000182707C30-0x0000000182707CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int FaceAngleCompact { get => default; set {} } // 0x0000000182707880-0x0000000182707920 0x0000000182708030-0x00000001827080D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000182707F90-0x0000000182708030 0x00000001827083A0-0x0000000182708440

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSyncEntityPositionInfo() {} // 0x0000000182708A70-0x0000000182708AD0
	static EvtSyncEntityPositionInfo() {} // 0x00000001827089B0-0x0000000182708A70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSyncEntityPositionInfo Clone() => default; // 0x0000000182707B40-0x0000000182707C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtSyncEntityPositionInfo ShallowCopy() => default; // 0x00000001827074E0-0x0000000182707580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182706D10-0x0000000182706D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182707DF0-0x0000000182707E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182707F10-0x0000000182707F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182706D90-0x0000000182706EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182706F90-0x0000000182707060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtSyncEntityPositionInfo other) => default; // 0x0000000182707060-0x00000001827071F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182707670-0x0000000182707880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182708620-0x00000001827089B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001827081D0-0x00000001827083A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001827071F0-0x0000000182707460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtSyncEntityPositionInfo other) {} // 0x0000000182706B20-0x0000000182706D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182706920-0x0000000182706AC0
}

