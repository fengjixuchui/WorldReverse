/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarEnterSceneInfo : MessageBase, IMessage<AvatarEnterSceneInfo> // TypeDefIndex: 25100
{
	// Fields
	private static readonly MessageParser<AvatarEnterSceneInfo> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B07FBF
	private ulong avatarGuid_; // 0x18
	public const int AvatarEntityIdFieldNumber = 2; // Metadata: 0x00B07FC3
	private uint avatarEntityId_; // 0x20
	public const int AvatarAbilityInfoFieldNumber = 3; // Metadata: 0x00B07FC7
	private AbilitySyncStateInfo avatarAbilityInfo_; // 0x28
	public const int BuffIdListFieldNumber = 4; // Metadata: 0x00B07FCB
	private static readonly FieldCodec<uint> _repeated_buffIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> buffIdList_; // 0x30
	public const int WeaponGuidFieldNumber = 5; // Metadata: 0x00B07FCF
	private ulong weaponGuid_; // 0x38
	public const int WeaponEntityIdFieldNumber = 6; // Metadata: 0x00B07FD3
	private uint weaponEntityId_; // 0x40
	public const int WeaponAbilityInfoFieldNumber = 7; // Metadata: 0x00B07FD7
	private AbilitySyncStateInfo weaponAbilityInfo_; // 0x48
	public const int ServerBuffListFieldNumber = 8; // Metadata: 0x00B07FDB
	private static readonly FieldCodec<ServerBuff> _repeated_serverBuffList_codec; // 0x10
	private readonly RepeatedMessageField<ServerBuff> serverBuffList_; // 0x50

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarEnterSceneInfo> Parser { get => default; } // 0x00000001835F1070-0x00000001835F1100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835F0A40-0x00000001835F0AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001835F0480-0x00000001835F0500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835EF4A0-0x00000001835EF500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835F1770-0x00000001835F1860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835F13F0-0x00000001835F1450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835F0D50-0x00000001835F0E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835F1720-0x00000001835F1770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835F0640-0x00000001835F0730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x00000001835F0B70-0x00000001835F0C10 0x00000001835EF7E0-0x00000001835EF880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarEntityId { get => default; set {} } // 0x00000001835F0340-0x00000001835F03E0 0x00000001835F0AD0-0x00000001835F0B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo AvatarAbilityInfo { get => default; set {} } // 0x00000001835F0FD0-0x00000001835F1070 0x00000001835F03E0-0x00000001835F0480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> BuffIdList { get => default; } // 0x00000001835F12F0-0x00000001835F1350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong WeaponGuid { get => default; set {} } // 0x00000001835EFBF0-0x00000001835EFC90 0x00000001835F0F30-0x00000001835F0FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WeaponEntityId { get => default; set {} } // 0x00000001835F1350-0x00000001835F13F0 0x00000001835F0CB0-0x00000001835F0D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo WeaponAbilityInfo { get => default; set {} } // 0x00000001835F0C10-0x00000001835F0CB0 0x00000001835F05A0-0x00000001835F0640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ServerBuff> ServerBuffList { get => default; } // 0x00000001835F1860-0x00000001835F18C0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarEnterSceneInfo() {} // 0x00000001835F1ED0-0x00000001835F1F80
	static AvatarEnterSceneInfo() {} // 0x00000001835F1DA0-0x00000001835F1ED0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarEnterSceneInfo Clone() => default; // 0x00000001835F0E40-0x00000001835F0F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarEnterSceneInfo ShallowCopy() => default; // 0x00000001835F0500-0x00000001835F05A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835EF880-0x00000001835EF910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835F1190-0x00000001835F1240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835F1240-0x00000001835F12F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001835EF910-0x00000001835EFBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835EFC90-0x00000001835EFD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarEnterSceneInfo other) => default; // 0x00000001835EFD60-0x00000001835EFF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001835F0730-0x00000001835F0A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001835F18C0-0x00000001835F1DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835F1450-0x00000001835F1720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001835EFF70-0x00000001835F0340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarEnterSceneInfo other) {} // 0x00000001835EF500-0x00000001835EF7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835EF1C0-0x00000001835EF4A0
}

