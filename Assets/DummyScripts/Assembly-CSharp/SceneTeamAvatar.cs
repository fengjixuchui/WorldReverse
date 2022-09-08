/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneTeamAvatar : MessageBase, IMessage<SceneTeamAvatar> // TypeDefIndex: 22492
{
	// Fields
	private static readonly MessageParser<SceneTeamAvatar> _parser; // 0x00
	public const int PlayerUidFieldNumber = 1; // Metadata: 0x00B01B13
	private uint playerUid_; // 0x18
	public const int AvatarGuidFieldNumber = 2; // Metadata: 0x00B01B17
	private ulong avatarGuid_; // 0x20
	public const int SceneIdFieldNumber = 3; // Metadata: 0x00B01B1B
	private uint sceneId_; // 0x28
	public const int EntityIdFieldNumber = 4; // Metadata: 0x00B01B1F
	private uint entityId_; // 0x2C
	public const int AvatarInfoFieldNumber = 5; // Metadata: 0x00B01B23
	private AvatarInfo avatarInfo_; // 0x30
	public const int SceneAvatarInfoFieldNumber = 6; // Metadata: 0x00B01B27
	private SceneAvatarInfo sceneAvatarInfo_; // 0x38
	public const int AvatarAbilityInfoFieldNumber = 7; // Metadata: 0x00B01B2B
	private AbilitySyncStateInfo avatarAbilityInfo_; // 0x40
	public const int ServerBuffListFieldNumber = 8; // Metadata: 0x00B01B2F
	private static readonly FieldCodec<ServerBuff> _repeated_serverBuffList_codec; // 0x08
	private readonly RepeatedMessageField<ServerBuff> serverBuffList_; // 0x48
	public const int SceneEntityInfoFieldNumber = 9; // Metadata: 0x00B01B33
	private SceneEntityInfo sceneEntityInfo_; // 0x50
	public const int WeaponGuidFieldNumber = 10; // Metadata: 0x00B01B37
	private ulong weaponGuid_; // 0x58
	public const int WeaponEntityIdFieldNumber = 11; // Metadata: 0x00B01B3B
	private uint weaponEntityId_; // 0x60
	public const int WeaponAbilityInfoFieldNumber = 12; // Metadata: 0x00B01B3F
	private AbilitySyncStateInfo weaponAbilityInfo_; // 0x68
	public const int AbilityControlBlockFieldNumber = 13; // Metadata: 0x00B01B43
	private AbilityControlBlock abilityControlBlock_; // 0x70
	public const int IsReconnectFieldNumber = 14; // Metadata: 0x00B01B47
	private bool isReconnect_; // 0x78
	public const int IsPlayerCurAvatarFieldNumber = 15; // Metadata: 0x00B01B4B
	private bool isPlayerCurAvatar_; // 0x79
	public const int IsOnSceneFieldNumber = 16; // Metadata: 0x00B01B4F
	private bool isOnScene_; // 0x7A

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneTeamAvatar> Parser { get => default; } // 0x0000000184BC2900-0x0000000184BC2990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184BC2050-0x0000000184BC20E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184BC1620-0x0000000184BC16A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184BBFA60-0x0000000184BBFAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184BC35D0-0x0000000184BC36C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184BC2EA0-0x0000000184BC2F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184BC24A0-0x0000000184BC2590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184BC34E0-0x0000000184BC3530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184BC1920-0x0000000184BC1A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayerUid { get => default; set {} } // 0x0000000184BC3440-0x0000000184BC34E0 0x0000000184BC0880-0x0000000184BC0920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000184BC2180-0x0000000184BC2220 0x0000000184BC0000-0x0000000184BC00A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000184BC07E0-0x0000000184BC0880 0x0000000184BC1580-0x0000000184BC1620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000184BC2D60-0x0000000184BC2E00 0x0000000184BC3720-0x0000000184BC37C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarInfo AvatarInfo { get => default; set {} } // 0x0000000184BC1880-0x0000000184BC1920 0x0000000184BC2C20-0x0000000184BC2CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneAvatarInfo SceneAvatarInfo { get => default; set {} } // 0x0000000184BC20E0-0x0000000184BC2180 0x0000000184BBF920-0x0000000184BBF9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo AvatarAbilityInfo { get => default; set {} } // 0x0000000184BC27C0-0x0000000184BC2860 0x0000000184BC14E0-0x0000000184BC1580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ServerBuff> ServerBuffList { get => default; } // 0x0000000184BC36C0-0x0000000184BC3720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityInfo SceneEntityInfo { get => default; set {} } // 0x0000000184BC2860-0x0000000184BC2900 0x0000000184BC2680-0x0000000184BC2720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong WeaponGuid { get => default; set {} } // 0x0000000184BC0740-0x0000000184BC07E0 0x0000000184BC2720-0x0000000184BC27C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WeaponEntityId { get => default; set {} } // 0x0000000184BC2CC0-0x0000000184BC2D60 0x0000000184BC22C0-0x0000000184BC2360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilitySyncStateInfo WeaponAbilityInfo { get => default; set {} } // 0x0000000184BC2220-0x0000000184BC22C0 0x0000000184BC17E0-0x0000000184BC1880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityControlBlock AbilityControlBlock { get => default; set {} } // 0x0000000184BC0920-0x0000000184BC09C0 0x0000000184BBF9C0-0x0000000184BBFA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsReconnect { get => default; set {} } // 0x0000000184BC2F00-0x0000000184BC2FA0 0x0000000184BC2400-0x0000000184BC24A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsPlayerCurAvatar { get => default; set {} } // 0x0000000184BC16A0-0x0000000184BC1740 0x0000000184BC2E00-0x0000000184BC2EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOnScene { get => default; set {} } // 0x0000000184BC3530-0x0000000184BC35D0 0x0000000184BC2360-0x0000000184BC2400

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneTeamAvatar() {} // 0x0000000184BC41D0-0x0000000184BC4260
	static SceneTeamAvatar() {} // 0x0000000184BC40C0-0x0000000184BC41D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneTeamAvatar Clone() => default; // 0x0000000184BC2590-0x0000000184BC2680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneTeamAvatar ShallowCopy() => default; // 0x0000000184BC1740-0x0000000184BC17E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184BC00A0-0x0000000184BC0190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BC2A20-0x0000000184BC2B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184BC2B20-0x0000000184BC2C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184BC0190-0x0000000184BC0740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184BC0D00-0x0000000184BC0DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneTeamAvatar other) => default; // 0x0000000184BC09C0-0x0000000184BC0D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184BC1A10-0x0000000184BC2050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184BC37C0-0x0000000184BC40C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184BC2FA0-0x0000000184BC3440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184BC0DD0-0x0000000184BC14E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneTeamAvatar other) {} // 0x0000000184BBFAC0-0x0000000184BC0000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184BBF4E0-0x0000000184BBF920
}

