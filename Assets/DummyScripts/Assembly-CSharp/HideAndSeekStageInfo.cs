/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HideAndSeekStageInfo : MessageBase, IMessage<HideAndSeekStageInfo> // TypeDefIndex: 24177
{
	// Fields
	private static readonly MessageParser<HideAndSeekStageInfo> _parser; // 0x00
	public const int StageTypeFieldNumber = 1; // Metadata: 0x00B05C7B
	private HideAndSeekStageType stageType_; // 0x18
	public const int HunterUidFieldNumber = 2; // Metadata: 0x00B05C7F
	private uint hunterUid_; // 0x1C
	public const int HiderUidListFieldNumber = 3; // Metadata: 0x00B05C83
	private static readonly FieldCodec<uint> _repeated_hiderUidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> hiderUidList_; // 0x20
	public const int BattleInfoMapFieldNumber = 4; // Metadata: 0x00B05C87
	private static readonly MapField<uint, HideAndSeekPlayerBattleInfo> _map_battleInfoMap_codec; // 0x10
	private readonly MapField<uint, HideAndSeekPlayerBattleInfo> battleInfoMap_; // 0x28
	public const int MapIdFieldNumber = 5; // Metadata: 0x00B05C8B
	private uint mapId_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HideAndSeekStageInfo> Parser { get => default; } // 0x000000018521A8F0-0x000000018521A980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018521A5E0-0x000000018521A670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018521A130-0x000000018521A1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001852196D0-0x0000000185219730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018521AE50-0x000000018521AF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018521AB10-0x000000018521AB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018521A670-0x000000018521A760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018521AE00-0x000000018521AE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018521A250-0x000000018521A340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekStageType StageType { get => default; set {} } // 0x0000000185219730-0x00000001852197D0 0x000000018521A540-0x000000018521A5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HunterUid { get => default; set {} } // 0x0000000185219970-0x0000000185219A10 0x000000018521A850-0x000000018521A8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> HiderUidList { get => default; } // 0x000000018521AAB0-0x000000018521AB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, HideAndSeekPlayerBattleInfo> BattleInfoMap { get => default; } // 0x0000000185219A10-0x0000000185219A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MapId { get => default; set {} } // 0x0000000185219E80-0x0000000185219F20 0x000000018521AD60-0x000000018521AE00

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekStageInfo() {} // 0x000000018521B430-0x000000018521B4F0
	static HideAndSeekStageInfo() {} // 0x000000018521B2B0-0x000000018521B430

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekStageInfo Clone() => default; // 0x000000018521A760-0x000000018521A850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekStageInfo ShallowCopy() => default; // 0x000000018521A1B0-0x000000018521A250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185219A70-0x0000000185219AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018521AA10-0x000000018521AA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018521AA60-0x000000018521AAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185219AC0-0x0000000185219C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185219DB0-0x0000000185219E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HideAndSeekStageInfo other) => default; // 0x0000000185219C00-0x0000000185219DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018521A340-0x000000018521A540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018521AF40-0x000000018521B2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018521AB70-0x000000018521AD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185219F20-0x000000018521A130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HideAndSeekStageInfo other) {} // 0x00000001852197D0-0x0000000185219970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001852194C0-0x00000001852196D0
}

