/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerCurLevelRecord : MessageBase, IMessage<TowerCurLevelRecord> // TypeDefIndex: 25696
{
	// Fields
	private static readonly MessageParser<TowerCurLevelRecord> _parser; // 0x00
	public const int CurFloorIdFieldNumber = 1; // Metadata: 0x00B095CB
	private uint curFloorId_; // 0x18
	public const int CurLevelIndexFieldNumber = 2; // Metadata: 0x00B095CF
	private uint curLevelIndex_; // 0x1C
	public const int TowerTeamListFieldNumber = 3; // Metadata: 0x00B095D3
	private static readonly FieldCodec<TowerTeam> _repeated_towerTeamList_codec; // 0x08
	private readonly RepeatedMessageField<TowerTeam> towerTeamList_; // 0x20
	public const int BuffIdListFieldNumber = 4; // Metadata: 0x00B095D7
	private static readonly FieldCodec<uint> _repeated_buffIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> buffIdList_; // 0x28
	public const int IsEmptyFieldNumber = 5; // Metadata: 0x00B095DB
	private bool isEmpty_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerCurLevelRecord> Parser { get => default; } // 0x000000018203F550-0x000000018203F5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018203F240-0x000000018203F2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018203EEB0-0x000000018203EF30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018203E4C0-0x000000018203E520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018203FAF0-0x000000018203FBE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018203F7F0-0x000000018203F850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018203F2D0-0x000000018203F3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018203FAA0-0x000000018203FAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018203EFD0-0x000000018203F0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurFloorId { get => default; set {} } // 0x000000018203F3C0-0x000000018203F460 0x000000018203E660-0x000000018203E700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurLevelIndex { get => default; set {} } // 0x000000018203E420-0x000000018203E4C0 0x000000018203E520-0x000000018203E5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<TowerTeam> TowerTeamList { get => default; } // 0x000000018203FA40-0x000000018203FAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> BuffIdList { get => default; } // 0x000000018203F790-0x000000018203F7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsEmpty { get => default; set {} } // 0x000000018203E5C0-0x000000018203E660 0x000000018203FBE0-0x000000018203FC80

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerCurLevelRecord() {} // 0x0000000182040120-0x00000001820401D0
	static TowerCurLevelRecord() {} // 0x000000018203FFF0-0x0000000182040120

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerCurLevelRecord Clone() => default; // 0x000000018203F460-0x000000018203F550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerCurLevelRecord ShallowCopy() => default; // 0x000000018203EF30-0x000000018203EFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018203E8E0-0x000000018203E930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018203F670-0x000000018203F700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018203F700-0x000000018203F790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018203E930-0x000000018203EA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018203EC10-0x000000018203ECE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerCurLevelRecord other) => default; // 0x000000018203EA80-0x000000018203EC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018203F0C0-0x000000018203F240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018203FC80-0x000000018203FFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018203F850-0x000000018203FA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018203ECE0-0x000000018203EEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerCurLevelRecord other) {} // 0x000000018203E700-0x000000018203E8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018203E210-0x000000018203E420
}

