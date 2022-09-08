/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarInfo : MessageBase, IMessage<AvatarInfo> // TypeDefIndex: 26070
{
	// Fields
	private static readonly MessageParser<AvatarInfo> _parser; // 0x00
	public const int AvatarIdFieldNumber = 1; // Metadata: 0x00B0AF7F
	private uint avatarId_; // 0x18
	public const int GuidFieldNumber = 2; // Metadata: 0x00B0AF83
	private ulong guid_; // 0x20
	public const int PropMapFieldNumber = 3; // Metadata: 0x00B0AF87
	private static readonly MapField<uint, PropValue> _map_propMap_codec; // 0x08
	private readonly MapField<uint, PropValue> propMap_; // 0x28
	public const int LifeStateFieldNumber = 4; // Metadata: 0x00B0AF8B
	private uint lifeState_; // 0x30
	public const int EquipGuidListFieldNumber = 5; // Metadata: 0x00B0AF8F
	private static readonly FieldCodec<ulong> _repeated_equipGuidList_codec; // 0x10
	private readonly RepeatedPrimitiveField<ulong> equipGuidList_; // 0x38
	public const int TalentIdListFieldNumber = 6; // Metadata: 0x00B0AF93
	private static readonly FieldCodec<uint> _repeated_talentIdList_codec; // 0x18
	private readonly RepeatedPrimitiveField<uint> talentIdList_; // 0x40
	public const int FightPropMapFieldNumber = 7; // Metadata: 0x00B0AF97
	private static readonly MapField<uint, float> _map_fightPropMap_codec; // 0x20
	private readonly MapField<uint, float> fightPropMap_; // 0x48
	public const int TrialAvatarInfoFieldNumber = 9; // Metadata: 0x00B0AF9B
	private TrialAvatarInfo trialAvatarInfo_; // 0x50
	public const int SkillMapFieldNumber = 10; // Metadata: 0x00B0AF9F
	private static readonly MapField<uint, AvatarSkillInfo> _map_skillMap_codec; // 0x28
	private readonly MapField<uint, AvatarSkillInfo> skillMap_; // 0x58
	public const int SkillDepotIdFieldNumber = 11; // Metadata: 0x00B0AFA3
	private uint skillDepotId_; // 0x60
	public const int FetterInfoFieldNumber = 12; // Metadata: 0x00B0AFA7
	private AvatarFetterInfo fetterInfo_; // 0x68
	public const int CoreProudSkillLevelFieldNumber = 13; // Metadata: 0x00B0AFAB
	private uint coreProudSkillLevel_; // 0x70
	public const int InherentProudSkillListFieldNumber = 14; // Metadata: 0x00B0AFAF
	private static readonly FieldCodec<uint> _repeated_inherentProudSkillList_codec; // 0x30
	private readonly RepeatedPrimitiveField<uint> inherentProudSkillList_; // 0x78
	public const int SkillLevelMapFieldNumber = 15; // Metadata: 0x00B0AFB3
	private static readonly MapField<uint, uint> _map_skillLevelMap_codec; // 0x38
	private readonly MapField<uint, uint> skillLevelMap_; // 0x80
	public const int ExpeditionStateFieldNumber = 16; // Metadata: 0x00B0AFB7
	private AvatarExpeditionState expeditionState_; // 0x88
	public const int ProudSkillExtraLevelMapFieldNumber = 17; // Metadata: 0x00B0AFBB
	private static readonly MapField<uint, uint> _map_proudSkillExtraLevelMap_codec; // 0x40
	private readonly MapField<uint, uint> proudSkillExtraLevelMap_; // 0x90
	public const int IsFocusFieldNumber = 18; // Metadata: 0x00B0AFBF
	private bool isFocus_; // 0x98
	public const int AvatarTypeFieldNumber = 19; // Metadata: 0x00B0AFC3
	private uint avatarType_; // 0x9C
	public const int TeamResonanceListFieldNumber = 20; // Metadata: 0x00B0AFC7
	private static readonly FieldCodec<uint> _repeated_teamResonanceList_codec; // 0x48
	private readonly RepeatedPrimitiveField<uint> teamResonanceList_; // 0xA0
	public const int WearingFlycloakIdFieldNumber = 21; // Metadata: 0x00B0AFCB
	private uint wearingFlycloakId_; // 0xA8
	public const int EquipAffixListFieldNumber = 22; // Metadata: 0x00B0AFCF
	private static readonly FieldCodec<AvatarEquipAffixInfo> _repeated_equipAffixList_codec; // 0x50
	private readonly RepeatedMessageField<AvatarEquipAffixInfo> equipAffixList_; // 0xB0
	public const int BornTimeFieldNumber = 23; // Metadata: 0x00B0AFD3
	private uint bornTime_; // 0xB8
	public const int PendingPromoteRewardListFieldNumber = 24; // Metadata: 0x00B0AFD7
	private static readonly FieldCodec<uint> _repeated_pendingPromoteRewardList_codec; // 0x58
	private readonly RepeatedPrimitiveField<uint> pendingPromoteRewardList_; // 0xC0

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarInfo> Parser { get => default; } // 0x00000001850BB340-0x00000001850BB3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001850BAE30-0x00000001850BAEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001850BA440-0x00000001850BA4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001850B8050-0x00000001850B80B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001850BBFC0-0x00000001850BC0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001850BB6C0-0x00000001850BB720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001850BB060-0x00000001850BB150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001850BBF70-0x00000001850BBFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001850BA600-0x00000001850BA6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x00000001850BA300-0x00000001850BA3A0 0x00000001850BA3A0-0x00000001850BA440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x00000001850B8820-0x00000001850B88C0 0x00000001850B9220-0x00000001850B92C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, PropValue> PropMap { get => default; } // 0x00000001850BC290-0x00000001850BC2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LifeState { get => default; set {} } // 0x00000001850B8960-0x00000001850B8A00 0x00000001850BC1F0-0x00000001850BC290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> EquipGuidList { get => default; } // 0x00000001850B7FF0-0x00000001850B8050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TalentIdList { get => default; } // 0x00000001850B8170-0x00000001850B81D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, float> FightPropMap { get => default; } // 0x00000001850B8110-0x00000001850B8170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarInfo TrialAvatarInfo { get => default; set {} } // 0x00000001850BB620-0x00000001850BB6C0 0x00000001850B8A00-0x00000001850B8AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, AvatarSkillInfo> SkillMap { get => default; } // 0x00000001850B92C0-0x00000001850B9320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillDepotId { get => default; set {} } // 0x00000001850BB720-0x00000001850BB7C0 0x00000001850BA560-0x00000001850BA600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFetterInfo FetterInfo { get => default; set {} } // 0x00000001850BBED0-0x00000001850BBF70 0x00000001850BAFC0-0x00000001850BB060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CoreProudSkillLevel { get => default; set {} } // 0x00000001850BAEC0-0x00000001850BAF60 0x00000001850B88C0-0x00000001850B8960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> InherentProudSkillList { get => default; } // 0x00000001850B80B0-0x00000001850B8110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SkillLevelMap { get => default; } // 0x00000001850B7F90-0x00000001850B7FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionState ExpeditionState { get => default; set {} } // 0x00000001850BC150-0x00000001850BC1F0 0x00000001850BB240-0x00000001850BB2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> ProudSkillExtraLevelMap { get => default; } // 0x00000001850BB2E0-0x00000001850BB340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFocus { get => default; set {} } // 0x00000001850BA160-0x00000001850BA200 0x00000001850BC0B0-0x00000001850BC150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarType { get => default; set {} } // 0x00000001850BAD90-0x00000001850BAE30 0x00000001850B8780-0x00000001850B8820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TeamResonanceList { get => default; } // 0x00000001850BB5C0-0x00000001850BB620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WearingFlycloakId { get => default; set {} } // 0x00000001850BA200-0x00000001850BA2A0 0x00000001850B9320-0x00000001850B93C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AvatarEquipAffixInfo> EquipAffixList { get => default; } // 0x00000001850BA2A0-0x00000001850BA300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BornTime { get => default; set {} } // 0x00000001850B81D0-0x00000001850B8270 0x00000001850B9180-0x00000001850B9220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> PendingPromoteRewardList { get => default; } // 0x00000001850BAF60-0x00000001850BAFC0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarInfo() {} // 0x00000001850BD350-0x00000001850BD550
	static AvatarInfo() {} // 0x00000001850BCF50-0x00000001850BD350

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarInfo Clone() => default; // 0x00000001850BB150-0x00000001850BB240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarInfo ShallowCopy() => default; // 0x00000001850BA4C0-0x00000001850BA560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001850B8AA0-0x00000001850B8B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850BB460-0x00000001850BB510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850BB510-0x00000001850BB5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001850B8B30-0x00000001850B9180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001850B93C0-0x00000001850B9490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarInfo other) => default; // 0x00000001850B9490-0x00000001850B9960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001850BA6F0-0x00000001850BAD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001850BC2F0-0x00000001850BCF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001850BB7C0-0x00000001850BBED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001850B9960-0x00000001850BA160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarInfo other) {} // 0x00000001850B8270-0x00000001850B8780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001850B77F0-0x00000001850B7F90
}

