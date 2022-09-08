/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneEntityInfo : MessageBase, IMessage<SceneEntityInfo> // TypeDefIndex: 26053
{
	// Fields
	private static readonly MessageParser<SceneEntityInfo> _parser; // 0x00
	public const int EntityTypeFieldNumber = 1; // Metadata: 0x00B0AE57
	private ProtEntityType entityType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B0AE5B
	private uint entityId_; // 0x1C
	public const int NameFieldNumber = 3; // Metadata: 0x00B0AE5F
	private string name_; // 0x20
	public const int MotionInfoFieldNumber = 4; // Metadata: 0x00B0AE63
	private MotionInfo motionInfo_; // 0x28
	public const int PropListFieldNumber = 5; // Metadata: 0x00B0AE67
	private static readonly FieldCodec<PropPair> _repeated_propList_codec; // 0x08
	private readonly RepeatedMessageField<PropPair> propList_; // 0x30
	public const int FightPropListFieldNumber = 6; // Metadata: 0x00B0AE6B
	private static readonly FieldCodec<FightPropPair> _repeated_fightPropList_codec; // 0x10
	private readonly RepeatedMessageField<FightPropPair> fightPropList_; // 0x38
	public const int LifeStateFieldNumber = 7; // Metadata: 0x00B0AE6F
	private uint lifeState_; // 0x40
	public const int AnimatorParaListFieldNumber = 9; // Metadata: 0x00B0AE73
	private static readonly FieldCodec<AnimatorParameterValueInfoPair> _repeated_animatorParaList_codec; // 0x18
	private readonly RepeatedMessageField<AnimatorParameterValueInfoPair> animatorParaList_; // 0x48
	public const int AvatarFieldNumber = 10; // Metadata: 0x00B0AE77
	public const int MonsterFieldNumber = 11; // Metadata: 0x00B0AE7B
	public const int NpcFieldNumber = 12; // Metadata: 0x00B0AE7F
	public const int GadgetFieldNumber = 13; // Metadata: 0x00B0AE83
	public const int LastMoveSceneTimeMsFieldNumber = 17; // Metadata: 0x00B0AE87
	private uint lastMoveSceneTimeMs_; // 0x50
	public const int LastMoveReliableSeqFieldNumber = 18; // Metadata: 0x00B0AE8B
	private uint lastMoveReliableSeq_; // 0x54
	public const int EntityClientDataFieldNumber = 19; // Metadata: 0x00B0AE8F
	private EntityClientData entityClientData_; // 0x58
	public const int EntityEnvironmentInfoListFieldNumber = 20; // Metadata: 0x00B0AE93
	private static readonly FieldCodec<EntityEnvironmentInfo> _repeated_entityEnvironmentInfoList_codec; // 0x20
	private readonly RepeatedMessageField<EntityEnvironmentInfo> entityEnvironmentInfoList_; // 0x60
	public const int EntityAuthorityInfoFieldNumber = 21; // Metadata: 0x00B0AE97
	private EntityAuthorityInfo entityAuthorityInfo_; // 0x68
	public const int TagListFieldNumber = 22; // Metadata: 0x00B0AE9B
	private static readonly FieldCodec<string> _repeated_tagList_codec; // 0x28
	private readonly RepeatedPrimitiveField<string> tagList_; // 0x70
	private object entity_; // 0x78
	private EntityOneofCase entityCase_; // 0x80

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneEntityInfo> Parser { get => default; } // 0x00000001825F2E10-0x00000001825F2EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001825F2630-0x00000001825F26C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001825F1CE0-0x00000001825F1D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001825EFC70-0x00000001825EFCD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001825F3FF0-0x00000001825F40E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001825F37A0-0x00000001825F3800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001825F2B80-0x00000001825F2C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001825F3F00-0x00000001825F3F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001825F1E00-0x00000001825F1EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProtEntityType EntityType { get => default; set {} } // 0x00000001825F0670-0x00000001825F0710 0x00000001825EFE50-0x00000001825EFEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001825F35C0-0x00000001825F3660 0x00000001825F4180-0x00000001825F4220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { get => default; set {} } // 0x00000001825F1C40-0x00000001825F1CE0 0x00000001825F0F70-0x00000001825F1020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionInfo MotionInfo { get => default; set {} } // 0x00000001825F3700-0x00000001825F37A0 0x00000001825F2F30-0x00000001825F2FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<PropPair> PropList { get => default; } // 0x00000001825F2770-0x00000001825F27D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FightPropPair> FightPropList { get => default; } // 0x00000001825F0570-0x00000001825F05D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LifeState { get => default; set {} } // 0x00000001825F05D0-0x00000001825F0670 0x00000001825F40E0-0x00000001825F4180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AnimatorParameterValueInfoPair> AnimatorParaList { get => default; } // 0x00000001825F3800-0x00000001825F3860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAvatarInfo Avatar { get => default; set {} } // 0x00000001825F3E30-0x00000001825F3F00 0x00000001825F04C0-0x00000001825F0570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneMonsterInfo Monster { get => default; set {} } // 0x00000001825F0930-0x00000001825F0A00 0x00000001825F2D60-0x00000001825F2E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneNpcInfo Npc { get => default; set {} } // 0x00000001825EFCD0-0x00000001825EFDA0 0x00000001825F26C0-0x00000001825F2770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGadgetInfo Gadget { get => default; set {} } // 0x00000001825F3260-0x00000001825F3330 0x00000001825EFDA0-0x00000001825EFE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastMoveSceneTimeMs { get => default; set {} } // 0x00000001825F0ED0-0x00000001825F0F70 0x00000001825F2530-0x00000001825F25D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastMoveReliableSeq { get => default; set {} } // 0x00000001825EFBD0-0x00000001825EFC70 0x00000001825EF490-0x00000001825EF530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityClientData EntityClientData { get => default; set {} } // 0x00000001825EF3F0-0x00000001825EF490 0x00000001825F3F50-0x00000001825F3FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EntityEnvironmentInfo> EntityEnvironmentInfoList { get => default; } // 0x00000001825F3860-0x00000001825F38C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAuthorityInfo EntityAuthorityInfo { get => default; set {} } // 0x00000001825F3660-0x00000001825F3700 0x00000001825F2490-0x00000001825F2530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<string> TagList { get => default; } // 0x00000001825F2B20-0x00000001825F2B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityOneofCase EntityCase { get => default; } // 0x00000001825F25D0-0x00000001825F2630 

	// Nested types
	public enum EntityOneofCase // TypeDefIndex: 26054
	{
		None = 0,
		Avatar = 10,
		Monster = 11,
		Npc = 12,
		Gadget = 13
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityInfo() {} // 0x00000001825F4FE0-0x00000001825F5110
	static SceneEntityInfo() {} // 0x00000001825F4DC0-0x00000001825F4FE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityInfo Clone() => default; // 0x00000001825F2C70-0x00000001825F2D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityInfo ShallowCopy() => default; // 0x00000001825F1D60-0x00000001825F1E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001825F0710-0x00000001825F0930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825F2FD0-0x00000001825F3260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001825F3330-0x00000001825F35C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001825F0A00-0x00000001825F0ED0
	public void resetEntity() {} // 0x00000001825F27D0-0x00000001825F2B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearEntity() {} // 0x00000001825EFEF0-0x00000001825EFF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001825F1020-0x00000001825F10F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneEntityInfo other) => default; // 0x00000001825F10F0-0x00000001825F1500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001825F1EF0-0x00000001825F2490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001825F4220-0x00000001825F4DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001825F38C0-0x00000001825F3E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001825F1500-0x00000001825F1C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneEntityInfo other) {} // 0x00000001825EFF50-0x00000001825F04C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001825EF530-0x00000001825EFBD0
}

