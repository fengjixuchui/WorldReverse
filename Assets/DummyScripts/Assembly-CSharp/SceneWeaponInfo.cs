/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneWeaponInfo : MessageBase, IMessage<SceneWeaponInfo> // TypeDefIndex: 26011
{
	// Fields
	private static readonly MessageParser<SceneWeaponInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0AA9F
	private uint entityId_; // 0x18
	public const int GadgetIdFieldNumber = 2; // Metadata: 0x00B0AAA3
	private uint gadgetId_; // 0x1C
	public const int ItemIdFieldNumber = 3; // Metadata: 0x00B0AAA7
	private uint itemId_; // 0x20
	public const int GuidFieldNumber = 4; // Metadata: 0x00B0AAAB
	private ulong guid_; // 0x28
	public const int LevelFieldNumber = 5; // Metadata: 0x00B0AAAF
	private uint level_; // 0x30
	public const int PromoteLevelFieldNumber = 6; // Metadata: 0x00B0AAB3
	private uint promoteLevel_; // 0x34
	public const int AbilityInfoFieldNumber = 7; // Metadata: 0x00B0AAB7
	private AbilitySyncStateInfo abilityInfo_; // 0x38
	public const int AffixMapFieldNumber = 8; // Metadata: 0x00B0AABB
	private static readonly MapField<uint, uint> _map_affixMap_codec; // 0x08
	private readonly MapField<uint, uint> affixMap_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneWeaponInfo> Parser { get => default; } // 0x00000001853B9EF0-0x00000001853B9F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001853B9BE0-0x00000001853B9C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001853B9530-0x00000001853B95B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001853B8650-0x00000001853B86B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001853BA650-0x00000001853BA740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001853BA250-0x00000001853BA2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001853B9C70-0x00000001853B9D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001853BA560-0x00000001853BA5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001853B96F0-0x00000001853B97E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001853BA1B0-0x00000001853BA250 0x00000001853BA740-0x00000001853BA7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GadgetId { get => default; set {} } // 0x00000001853B93F0-0x00000001853B9490 0x00000001853B9B40-0x00000001853B9BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x00000001853BA010-0x00000001853BA0B0 0x00000001853BA5B0-0x00000001853BA650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x00000001853B8920-0x00000001853B89C0 0x00000001853B8CB0-0x00000001853B8D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x00000001853B89C0-0x00000001853B8A60 0x00000001853B9650-0x00000001853B96F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PromoteLevel { get => default; set {} } // 0x00000001853B9490-0x00000001853B9530 0x00000001853B9E50-0x00000001853B9EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo AbilityInfo { get => default; set {} } // 0x00000001853B85B0-0x00000001853B8650 0x00000001853B9AA0-0x00000001853B9B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> AffixMap { get => default; } // 0x00000001853B9390-0x00000001853B93F0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneWeaponInfo() {} // 0x00000001853BAE20-0x00000001853BAEB0
	static SceneWeaponInfo() {} // 0x00000001853BACF0-0x00000001853BAE20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneWeaponInfo Clone() => default; // 0x00000001853B9D60-0x00000001853B9E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneWeaponInfo ShallowCopy() => default; // 0x00000001853B95B0-0x00000001853B9650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001853B8A60-0x00000001853B8AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001853BA0B0-0x00000001853BA130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001853BA130-0x00000001853BA1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001853B8AE0-0x00000001853B8CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001853B8F60-0x00000001853B9030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneWeaponInfo other) => default; // 0x00000001853B8D50-0x00000001853B8F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001853B97E0-0x00000001853B9AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001853BA7E0-0x00000001853BACF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001853BA2B0-0x00000001853BA560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001853B9030-0x00000001853B9390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneWeaponInfo other) {} // 0x00000001853B86B0-0x00000001853B8920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001853B8360-0x00000001853B85B0
}

