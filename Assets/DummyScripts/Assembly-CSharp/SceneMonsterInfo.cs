/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneMonsterInfo : MessageBase, IMessage<SceneMonsterInfo> // TypeDefIndex: 26015
{
	// Fields
	private static readonly MessageParser<SceneMonsterInfo> _parser; // 0x00
	public const int MonsterIdFieldNumber = 1; // Metadata: 0x00B0AB2B
	private uint monsterId_; // 0x18
	public const int GroupIdFieldNumber = 2; // Metadata: 0x00B0AB2F
	private uint groupId_; // 0x1C
	public const int ConfigIdFieldNumber = 3; // Metadata: 0x00B0AB33
	private uint configId_; // 0x20
	public const int WeaponListFieldNumber = 4; // Metadata: 0x00B0AB37
	private static readonly FieldCodec<SceneWeaponInfo> _repeated_weaponList_codec; // 0x08
	private readonly RepeatedMessageField<SceneWeaponInfo> weaponList_; // 0x28
	public const int AuthorityPeerIdFieldNumber = 5; // Metadata: 0x00B0AB3B
	private uint authorityPeerId_; // 0x30
	public const int AffixListFieldNumber = 6; // Metadata: 0x00B0AB3F
	private static readonly FieldCodec<uint> _repeated_affixList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> affixList_; // 0x38
	public const int IsEliteFieldNumber = 7; // Metadata: 0x00B0AB43
	private bool isElite_; // 0x40
	public const int OwnerEntityIdFieldNumber = 8; // Metadata: 0x00B0AB47
	private uint ownerEntityId_; // 0x44
	public const int SummonedTagFieldNumber = 9; // Metadata: 0x00B0AB4B
	private uint summonedTag_; // 0x48
	public const int SummonTagMapFieldNumber = 10; // Metadata: 0x00B0AB4F
	private static readonly MapField<uint, uint> _map_summonTagMap_codec; // 0x18
	private readonly MapField<uint, uint> summonTagMap_; // 0x50
	public const int PoseIdFieldNumber = 11; // Metadata: 0x00B0AB53
	private uint poseId_; // 0x58
	public const int BornTypeFieldNumber = 12; // Metadata: 0x00B0AB57
	private MonsterBornType bornType_; // 0x5C
	public const int BlockIdFieldNumber = 13; // Metadata: 0x00B0AB5B
	private uint blockId_; // 0x60
	public const int MarkFlagFieldNumber = 14; // Metadata: 0x00B0AB5F
	private uint markFlag_; // 0x64
	public const int TitleIdFieldNumber = 15; // Metadata: 0x00B0AB63
	private uint titleId_; // 0x68
	public const int SpecialNameIdFieldNumber = 16; // Metadata: 0x00B0AB67
	private uint specialNameId_; // 0x6C
	public const int AttackTargetIdFieldNumber = 17; // Metadata: 0x00B0AB6B
	private uint attackTargetId_; // 0x70
	public const int MonsterRouteFieldNumber = 18; // Metadata: 0x00B0AB6F
	private MonsterRoute monsterRoute_; // 0x78
	public const int AiConfigIdFieldNumber = 19; // Metadata: 0x00B0AB73
	private uint aiConfigId_; // 0x80

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneMonsterInfo> Parser { get => default; } // 0x000000018392DED0-0x000000018392DF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018392D480-0x000000018392D510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018392CD10-0x000000018392CD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018392B450-0x000000018392B4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018392EB50-0x000000018392EC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018392E310-0x000000018392E370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018392D9D0-0x000000018392DAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018392EB00-0x000000018392EB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018392CE30-0x000000018392CF20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MonsterId { get => default; set {} } // 0x000000018392DCF0-0x000000018392DD90 0x000000018392B5B0-0x000000018392B650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x000000018392DAC0-0x000000018392DB60 0x000000018392CC70-0x000000018392CD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x000000018392D890-0x000000018392D930 0x000000018392B510-0x000000018392B5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<SceneWeaponInfo> WeaponList { get => default; } // 0x000000018392D510-0x000000018392D570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AuthorityPeerId { get => default; set {} } // 0x000000018392DF60-0x000000018392E000 0x000000018392DD90-0x000000018392DE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AffixList { get => default; } // 0x000000018392B350-0x000000018392B3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsElite { get => default; set {} } // 0x000000018392B3B0-0x000000018392B450 0x000000018392D3E0-0x000000018392D480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OwnerEntityId { get => default; set {} } // 0x000000018392B650-0x000000018392B6F0 0x000000018392D750-0x000000018392D7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SummonedTag { get => default; set {} } // 0x000000018392D930-0x000000018392D9D0 0x000000018392EC40-0x000000018392ECE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SummonTagMap { get => default; } // 0x000000018392B4B0-0x000000018392B510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PoseId { get => default; set {} } // 0x000000018392CB30-0x000000018392CBD0 0x000000018392BFF0-0x000000018392C090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterBornType BornType { get => default; set {} } // 0x000000018392D7F0-0x000000018392D890 0x000000018392E270-0x000000018392E310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BlockId { get => default; set {} } // 0x000000018392E1D0-0x000000018392E270 0x000000018392E370-0x000000018392E410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MarkFlag { get => default; set {} } // 0x000000018392CBD0-0x000000018392CC70 0x000000018392DE30-0x000000018392DED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TitleId { get => default; set {} } // 0x000000018392D6B0-0x000000018392D750 0x000000018392E410-0x000000018392E4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SpecialNameId { get => default; set {} } // 0x000000018392BF50-0x000000018392BFF0 0x000000018392DC50-0x000000018392DCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AttackTargetId { get => default; set {} } // 0x000000018392B6F0-0x000000018392B790 0x000000018392D570-0x000000018392D610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterRoute MonsterRoute { get => default; set {} } // 0x000000018392ED80-0x000000018392EE20 0x000000018392D610-0x000000018392D6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AiConfigId { get => default; set {} } // 0x000000018392ECE0-0x000000018392ED80 0x000000018392EA60-0x000000018392EB00

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneMonsterInfo() {} // 0x000000018392FA90-0x000000018392FB70
	static SceneMonsterInfo() {} // 0x000000018392F8F0-0x000000018392FA90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneMonsterInfo Clone() => default; // 0x000000018392DB60-0x000000018392DC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneMonsterInfo ShallowCopy() => default; // 0x000000018392CD90-0x000000018392CE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018392BBC0-0x000000018392BC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018392E090-0x000000018392E130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018392E130-0x000000018392E1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018392BC40-0x000000018392BF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018392C400-0x000000018392C4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneMonsterInfo other) => default; // 0x000000018392C090-0x000000018392C400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018392CF20-0x000000018392D3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018392EE20-0x000000018392F8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018392E4B0-0x000000018392EA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018392C4D0-0x000000018392CB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneMonsterInfo other) {} // 0x000000018392B790-0x000000018392BBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018392AF00-0x000000018392B350
}

