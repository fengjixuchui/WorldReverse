/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneAvatarInfo : MessageBase, IMessage<SceneAvatarInfo> // TypeDefIndex: 26014
{
	// Fields
	private static readonly MessageParser<SceneAvatarInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B0AAE7
	private uint uid_; // 0x18
	public const int AvatarIdFieldNumber = 2; // Metadata: 0x00B0AAEB
	private uint avatarId_; // 0x1C
	public const int GuidFieldNumber = 3; // Metadata: 0x00B0AAEF
	private ulong guid_; // 0x20
	public const int PeerIdFieldNumber = 4; // Metadata: 0x00B0AAF3
	private uint peerId_; // 0x28
	public const int EquipIdListFieldNumber = 5; // Metadata: 0x00B0AAF7
	private static readonly FieldCodec<uint> _repeated_equipIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> equipIdList_; // 0x30
	public const int SkillDepotIdFieldNumber = 6; // Metadata: 0x00B0AAFB
	private uint skillDepotId_; // 0x38
	public const int TalentIdListFieldNumber = 7; // Metadata: 0x00B0AAFF
	private static readonly FieldCodec<uint> _repeated_talentIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> talentIdList_; // 0x40
	public const int WeaponFieldNumber = 8; // Metadata: 0x00B0AB03
	private SceneWeaponInfo weapon_; // 0x48
	public const int ReliquaryListFieldNumber = 9; // Metadata: 0x00B0AB07
	private static readonly FieldCodec<SceneReliquaryInfo> _repeated_reliquaryList_codec; // 0x18
	private readonly RepeatedMessageField<SceneReliquaryInfo> reliquaryList_; // 0x50
	public const int CoreProudSkillLevelFieldNumber = 11; // Metadata: 0x00B0AB0B
	private uint coreProudSkillLevel_; // 0x58
	public const int InherentProudSkillListFieldNumber = 12; // Metadata: 0x00B0AB0F
	private static readonly FieldCodec<uint> _repeated_inherentProudSkillList_codec; // 0x20
	private readonly RepeatedPrimitiveField<uint> inherentProudSkillList_; // 0x60
	public const int SkillLevelMapFieldNumber = 13; // Metadata: 0x00B0AB13
	private static readonly MapField<uint, uint> _map_skillLevelMap_codec; // 0x28
	private readonly MapField<uint, uint> skillLevelMap_; // 0x68
	public const int ProudSkillExtraLevelMapFieldNumber = 14; // Metadata: 0x00B0AB17
	private static readonly MapField<uint, uint> _map_proudSkillExtraLevelMap_codec; // 0x30
	private readonly MapField<uint, uint> proudSkillExtraLevelMap_; // 0x70
	public const int ServerBuffListFieldNumber = 15; // Metadata: 0x00B0AB1B
	private static readonly FieldCodec<ServerBuff> _repeated_serverBuffList_codec; // 0x38
	private readonly RepeatedMessageField<ServerBuff> serverBuffList_; // 0x78
	public const int TeamResonanceListFieldNumber = 16; // Metadata: 0x00B0AB1F
	private static readonly FieldCodec<uint> _repeated_teamResonanceList_codec; // 0x40
	private readonly RepeatedPrimitiveField<uint> teamResonanceList_; // 0x80
	public const int WearingFlycloakIdFieldNumber = 17; // Metadata: 0x00B0AB23
	private uint wearingFlycloakId_; // 0x88
	public const int BornTimeFieldNumber = 18; // Metadata: 0x00B0AB27
	private uint bornTime_; // 0x8C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneAvatarInfo> Parser { get => default; } // 0x00000001818575E0-0x0000000181857670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181857030-0x00000001818570C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181856890-0x0000000181856910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181854D20-0x0000000181854D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181857F50-0x0000000181858040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818578E0-0x0000000181857940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181857260-0x0000000181857350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181857F00-0x0000000181857F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181856AF0-0x0000000181856BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001818566B0-0x0000000181856750 0x00000001818571C0-0x0000000181857260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x0000000181856750-0x00000001818567F0 0x00000001818567F0-0x0000000181856890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x0000000181855380-0x0000000181855420 0x0000000181855A50-0x0000000181855AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PeerId { get => default; set {} } // 0x00000001818569B0-0x0000000181856A50 0x0000000181854EE0-0x0000000181854F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> EquipIdList { get => default; } // 0x0000000181857160-0x00000001818571C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillDepotId { get => default; set {} } // 0x0000000181857940-0x00000001818579E0 0x0000000181856A50-0x0000000181856AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TalentIdList { get => default; } // 0x0000000181854DE0-0x0000000181854E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneWeaponInfo Weapon { get => default; set {} } // 0x0000000181857540-0x00000001818575E0 0x0000000181857350-0x00000001818573F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<SceneReliquaryInfo> ReliquaryList { get => default; } // 0x0000000181855AF0-0x0000000181855B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CoreProudSkillLevel { get => default; set {} } // 0x00000001818570C0-0x0000000181857160 0x0000000181855420-0x00000001818554C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> InherentProudSkillList { get => default; } // 0x0000000181854D80-0x0000000181854DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SkillLevelMap { get => default; } // 0x0000000181854CC0-0x0000000181854D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> ProudSkillExtraLevelMap { get => default; } // 0x00000001818574E0-0x0000000181857540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ServerBuff> ServerBuffList { get => default; } // 0x0000000181858040-0x00000001818580A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TeamResonanceList { get => default; } // 0x0000000181857880-0x00000001818578E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WearingFlycloakId { get => default; set {} } // 0x0000000181856610-0x00000001818566B0 0x0000000181855B50-0x0000000181855BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BornTime { get => default; set {} } // 0x0000000181854E40-0x0000000181854EE0 0x00000001818559B0-0x0000000181855A50

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAvatarInfo() {} // 0x0000000181858CB0-0x0000000181858E30
	static SceneAvatarInfo() {} // 0x0000000181858A00-0x0000000181858CB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAvatarInfo Clone() => default; // 0x00000001818573F0-0x00000001818574E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAvatarInfo ShallowCopy() => default; // 0x0000000181856910-0x00000001818569B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001818554C0-0x0000000181855540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181857700-0x00000001818577C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001818577C0-0x0000000181857880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181855540-0x00000001818559B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181855F80-0x0000000181856050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneAvatarInfo other) => default; // 0x0000000181855BF0-0x0000000181855F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181856BE0-0x0000000181857030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001818580A0-0x0000000181858A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001818579E0-0x0000000181857F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181856050-0x0000000181856610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneAvatarInfo other) {} // 0x0000000181854F80-0x0000000181855380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181854710-0x0000000181854CC0
}

