/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShowAvatarInfo : MessageBase, IMessage<ShowAvatarInfo> // TypeDefIndex: 26073
{
	// Fields
	private static readonly MessageParser<ShowAvatarInfo> _parser; // 0x00
	public const int AvatarIdFieldNumber = 1; // Metadata: 0x00B0AFF3
	private uint avatarId_; // 0x18
	public const int PropMapFieldNumber = 2; // Metadata: 0x00B0AFF7
	private static readonly MapField<uint, PropValue> _map_propMap_codec; // 0x08
	private readonly MapField<uint, PropValue> propMap_; // 0x20
	public const int TalentIdListFieldNumber = 3; // Metadata: 0x00B0AFFB
	private static readonly FieldCodec<uint> _repeated_talentIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> talentIdList_; // 0x28
	public const int FightPropMapFieldNumber = 4; // Metadata: 0x00B0AFFF
	private static readonly MapField<uint, float> _map_fightPropMap_codec; // 0x18
	private readonly MapField<uint, float> fightPropMap_; // 0x30
	public const int SkillDepotIdFieldNumber = 5; // Metadata: 0x00B0B003
	private uint skillDepotId_; // 0x38
	public const int CoreProudSkillLevelFieldNumber = 6; // Metadata: 0x00B0B007
	private uint coreProudSkillLevel_; // 0x3C
	public const int InherentProudSkillListFieldNumber = 7; // Metadata: 0x00B0B00B
	private static readonly FieldCodec<uint> _repeated_inherentProudSkillList_codec; // 0x20
	private readonly RepeatedPrimitiveField<uint> inherentProudSkillList_; // 0x40
	public const int SkillLevelMapFieldNumber = 8; // Metadata: 0x00B0B00F
	private static readonly MapField<uint, uint> _map_skillLevelMap_codec; // 0x28
	private readonly MapField<uint, uint> skillLevelMap_; // 0x48
	public const int ProudSkillExtraLevelMapFieldNumber = 9; // Metadata: 0x00B0B013
	private static readonly MapField<uint, uint> _map_proudSkillExtraLevelMap_codec; // 0x30
	private readonly MapField<uint, uint> proudSkillExtraLevelMap_; // 0x50
	public const int EquipListFieldNumber = 10; // Metadata: 0x00B0B017
	private static readonly FieldCodec<ShowEquip> _repeated_equipList_codec; // 0x38
	private readonly RepeatedMessageField<ShowEquip> equipList_; // 0x58
	public const int FetterInfoFieldNumber = 11; // Metadata: 0x00B0B01B
	private AvatarFetterInfo fetterInfo_; // 0x60

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ShowAvatarInfo> Parser { get => default; } // 0x0000000184689650-0x00000001846896E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001846891E0-0x0000000184689270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184688B40-0x0000000184688BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001846878F0-0x0000000184687950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184689DF0-0x0000000184689EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001846898B0-0x0000000184689910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184689410-0x0000000184689500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184689DA0-0x0000000184689DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184688D00-0x0000000184688DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x0000000184688A00-0x0000000184688AA0 0x0000000184688AA0-0x0000000184688B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, PropValue> PropMap { get => default; } // 0x0000000184689EE0-0x0000000184689F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TalentIdList { get => default; } // 0x0000000184687A10-0x0000000184687A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, float> FightPropMap { get => default; } // 0x00000001846879B0-0x0000000184687A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillDepotId { get => default; set {} } // 0x0000000184689910-0x00000001846899B0 0x0000000184688C60-0x0000000184688D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CoreProudSkillLevel { get => default; set {} } // 0x00000001846892D0-0x0000000184689370 0x0000000184687D70-0x0000000184687E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> InherentProudSkillList { get => default; } // 0x0000000184687950-0x00000001846879B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SkillLevelMap { get => default; } // 0x0000000184687890-0x00000001846878F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> ProudSkillExtraLevelMap { get => default; } // 0x00000001846895F0-0x0000000184689650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ShowEquip> EquipList { get => default; } // 0x0000000184689270-0x00000001846892D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFetterInfo FetterInfo { get => default; set {} } // 0x0000000184689D00-0x0000000184689DA0 0x0000000184689370-0x0000000184689410

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowAvatarInfo() {} // 0x000000018468A870-0x000000018468A9D0
	static ShowAvatarInfo() {} // 0x000000018468A560-0x000000018468A870

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowAvatarInfo Clone() => default; // 0x0000000184689500-0x00000001846895F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowAvatarInfo ShallowCopy() => default; // 0x0000000184688BC0-0x0000000184688C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184687E10-0x0000000184687E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184689770-0x0000000184689810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184689810-0x00000001846898B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184687E90-0x0000000184688270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184688560-0x0000000184688630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ShowAvatarInfo other) => default; // 0x0000000184688270-0x0000000184688560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184688DF0-0x00000001846891E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184689F40-0x000000018468A560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001846899B0-0x0000000184689D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184688630-0x0000000184688A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ShowAvatarInfo other) {} // 0x0000000184687A70-0x0000000184687D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184687420-0x0000000184687890
}

