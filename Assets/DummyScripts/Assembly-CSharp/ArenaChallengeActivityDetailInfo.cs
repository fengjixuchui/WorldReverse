/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ArenaChallengeActivityDetailInfo : MessageBase, IMessage<ArenaChallengeActivityDetailInfo> // TypeDefIndex: 22241
{
	// Fields
	private static readonly MessageParser<ArenaChallengeActivityDetailInfo> _parser; // 0x00
	public const int WorldLevelFieldNumber = 1; // Metadata: 0x00B011F7
	private uint worldLevel_; // 0x18
	public const int LevelListFieldNumber = 2; // Metadata: 0x00B011FB
	private static readonly FieldCodec<ArenaChallengeMonsterLevel> _repeated_levelList_codec; // 0x08
	private readonly RepeatedMessageField<ArenaChallengeMonsterLevel> levelList_; // 0x20
	public const int LevelOpenTimeMapFieldNumber = 3; // Metadata: 0x00B011FF
	private static readonly MapField<uint, uint> _map_levelOpenTimeMap_codec; // 0x10
	private readonly MapField<uint, uint> levelOpenTimeMap_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ArenaChallengeActivityDetailInfo> Parser { get => default; } // 0x0000000184053840-0x00000001840538D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184053530-0x00000001840535C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001840531C0-0x0000000184053240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184052920-0x0000000184052980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184053CA0-0x0000000184053D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184053A80-0x0000000184053AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184053660-0x0000000184053750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184053C50-0x0000000184053CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001840532E0-0x00000001840533D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WorldLevel { get => default; set {} } // 0x00000001840535C0-0x0000000184053660 0x0000000184052CA0-0x0000000184052D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ArenaChallengeMonsterLevel> LevelList { get => default; } // 0x0000000184053160-0x00000001840531C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> LevelOpenTimeMap { get => default; } // 0x0000000184053100-0x0000000184053160 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeActivityDetailInfo() {} // 0x0000000184054170-0x0000000184054220
	static ArenaChallengeActivityDetailInfo() {} // 0x0000000184053FF0-0x0000000184054170

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeActivityDetailInfo Clone() => default; // 0x0000000184053750-0x0000000184053840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeActivityDetailInfo ShallowCopy() => default; // 0x0000000184053240-0x00000001840532E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184052B10-0x0000000184052B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184053960-0x00000001840539F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001840539F0-0x0000000184053A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184052B60-0x0000000184052CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184052D40-0x0000000184052E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ArenaChallengeActivityDetailInfo other) => default; // 0x0000000184052E10-0x0000000184052F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001840533D0-0x0000000184053530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184053D90-0x0000000184053FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184053AE0-0x0000000184053C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184052F80-0x0000000184053100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ArenaChallengeActivityDetailInfo other) {} // 0x0000000184052980-0x0000000184052B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184052750-0x0000000184052920
}

