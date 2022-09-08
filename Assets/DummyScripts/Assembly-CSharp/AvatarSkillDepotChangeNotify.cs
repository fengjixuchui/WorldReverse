/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarSkillDepotChangeNotify : MessageBase, IMessage<AvatarSkillDepotChangeNotify> // TypeDefIndex: 25486
{
	// Fields
	private static readonly MessageParser<AvatarSkillDepotChangeNotify> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B08DDB
	private ulong avatarGuid_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B08DDF
	private uint entityId_; // 0x20
	public const int SkillDepotIdFieldNumber = 3; // Metadata: 0x00B08DE3
	private uint skillDepotId_; // 0x24
	public const int TalentIdListFieldNumber = 4; // Metadata: 0x00B08DE7
	private static readonly FieldCodec<uint> _repeated_talentIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> talentIdList_; // 0x28
	public const int ProudSkillListFieldNumber = 5; // Metadata: 0x00B08DEB
	private static readonly FieldCodec<uint> _repeated_proudSkillList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> proudSkillList_; // 0x30
	public const int CoreProudSkillLevelFieldNumber = 6; // Metadata: 0x00B08DEF
	private uint coreProudSkillLevel_; // 0x38
	public const int SkillLevelMapFieldNumber = 7; // Metadata: 0x00B08DF3
	private static readonly MapField<uint, uint> _map_skillLevelMap_codec; // 0x18
	private readonly MapField<uint, uint> skillLevelMap_; // 0x40
	public const int ProudSkillExtraLevelMapFieldNumber = 8; // Metadata: 0x00B08DF7
	private static readonly MapField<uint, uint> _map_proudSkillExtraLevelMap_codec; // 0x20
	private readonly MapField<uint, uint> proudSkillExtraLevelMap_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarSkillDepotChangeNotify> Parser { get => default; } // 0x0000000183D15150-0x0000000183D151E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D14D40-0x0000000183D14DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D14810-0x0000000183D14890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D13BD0-0x0000000183D13C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D15820-0x0000000183D15910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D15410-0x0000000183D15470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D14F10-0x0000000183D15000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D157D0-0x0000000183D15820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D149D0-0x0000000183D14AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000183D14E70-0x0000000183D14F10 0x0000000183D13EA0-0x0000000183D13F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000183D15370-0x0000000183D15410 0x0000000183D15910-0x0000000183D159B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillDepotId { get => default; set {} } // 0x0000000183D15470-0x0000000183D15510 0x0000000183D14930-0x0000000183D149D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TalentIdList { get => default; } // 0x0000000183D13C30-0x0000000183D13C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ProudSkillList { get => default; } // 0x0000000183D15270-0x0000000183D152D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CoreProudSkillLevel { get => default; set {} } // 0x0000000183D14DD0-0x0000000183D14E70 0x0000000183D13F40-0x0000000183D13FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SkillLevelMap { get => default; } // 0x0000000183D13B70-0x0000000183D13BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> ProudSkillExtraLevelMap { get => default; } // 0x0000000183D150F0-0x0000000183D15150 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25487
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25488
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1004
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillDepotChangeNotify() {} // 0x0000000183D16060-0x0000000183D16160
	static AvatarSkillDepotChangeNotify() {} // 0x0000000183D15E90-0x0000000183D16060

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillDepotChangeNotify Clone() => default; // 0x0000000183D15000-0x0000000183D150F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillDepotChangeNotify ShallowCopy() => default; // 0x0000000183D14890-0x0000000183D14930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D13FE0-0x0000000183D14030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D152D0-0x0000000183D15320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D15320-0x0000000183D15370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D14030-0x0000000183D14230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D14230-0x0000000183D14300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarSkillDepotChangeNotify other) => default; // 0x0000000183D14300-0x0000000183D14530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D14AC0-0x0000000183D14D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D159B0-0x0000000183D15E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D15510-0x0000000183D157D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D14530-0x0000000183D14810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarSkillDepotChangeNotify other) {} // 0x0000000183D13C90-0x0000000183D13EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D13850-0x0000000183D13B70
}

