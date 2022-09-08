/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SocialDetail : MessageBase, IMessage<SocialDetail> // TypeDefIndex: 25532
{
	// Fields
	private static readonly MessageParser<SocialDetail> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B08FAB
	private uint uid_; // 0x18
	public const int NicknameFieldNumber = 2; // Metadata: 0x00B08FAF
	private string nickname_; // 0x20
	public const int LevelFieldNumber = 3; // Metadata: 0x00B08FB3
	private uint level_; // 0x28
	public const int AvatarIdFieldNumber = 4; // Metadata: 0x00B08FB7
	private uint avatarId_; // 0x2C
	public const int SignatureFieldNumber = 5; // Metadata: 0x00B08FBB
	private string signature_; // 0x30
	public const int BirthdayFieldNumber = 6; // Metadata: 0x00B08FBF
	private Birthday birthday_; // 0x38
	public const int WorldLevelFieldNumber = 7; // Metadata: 0x00B08FC3
	private uint worldLevel_; // 0x40
	public const int ReservedListFieldNumber = 8; // Metadata: 0x00B08FC7
	private static readonly FieldCodec<uint> _repeated_reservedList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> reservedList_; // 0x48
	public const int OnlineStateFieldNumber = 9; // Metadata: 0x00B08FCB
	private FriendOnlineState onlineState_; // 0x50
	public const int ParamFieldNumber = 10; // Metadata: 0x00B08FCF
	private uint param_; // 0x54
	public const int IsFriendFieldNumber = 11; // Metadata: 0x00B08FD3
	private bool isFriend_; // 0x58
	public const int IsMpModeAvailableFieldNumber = 12; // Metadata: 0x00B08FD7
	private bool isMpModeAvailable_; // 0x59
	public const int OnlineIdFieldNumber = 13; // Metadata: 0x00B08FDB
	private string onlineId_; // 0x60
	public const int NameCardIdFieldNumber = 14; // Metadata: 0x00B08FDF
	private uint nameCardId_; // 0x68
	public const int IsInBlacklistFieldNumber = 15; // Metadata: 0x00B08FE3
	private bool isInBlacklist_; // 0x6C
	public const int IsChatNoDisturbFieldNumber = 16; // Metadata: 0x00B08FE7
	private bool isChatNoDisturb_; // 0x6D
	public const int RemarkNameFieldNumber = 17; // Metadata: 0x00B08FEB
	private string remarkName_; // 0x70
	public const int FinishAchievementNumFieldNumber = 18; // Metadata: 0x00B08FEF
	private uint finishAchievementNum_; // 0x78
	public const int TowerFloorIndexFieldNumber = 19; // Metadata: 0x00B08FF3
	private uint towerFloorIndex_; // 0x7C
	public const int TowerLevelIndexFieldNumber = 20; // Metadata: 0x00B08FF7
	private uint towerLevelIndex_; // 0x80
	public const int IsShowAvatarFieldNumber = 21; // Metadata: 0x00B08FFB
	private bool isShowAvatar_; // 0x84
	public const int ShowAvatarInfoListFieldNumber = 22; // Metadata: 0x00B08FFF
	private static readonly FieldCodec<SocialShowAvatarInfo> _repeated_showAvatarInfoList_codec; // 0x10
	private readonly RepeatedMessageField<SocialShowAvatarInfo> showAvatarInfoList_; // 0x88
	public const int ShowNameCardIdListFieldNumber = 23; // Metadata: 0x00B09003
	private static readonly FieldCodec<uint> _repeated_showNameCardIdList_codec; // 0x18
	private readonly RepeatedPrimitiveField<uint> showNameCardIdList_; // 0x90
	public const int FriendEnterHomeOptionFieldNumber = 24; // Metadata: 0x00B09007
	private FriendEnterHomeOption friendEnterHomeOption_; // 0x98

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SocialDetail> Parser { get => default; } // 0x00000001855375D0-0x0000000185537660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185536AD0-0x0000000185536B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185535CC0-0x0000000185535D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185533DC0-0x0000000185533E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185538450-0x0000000185538540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001855378D0-0x0000000185537930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001855370C0-0x00000001855371B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185538400-0x0000000185538450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185536060-0x0000000185536150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000185535A40-0x0000000185535AE0 0x0000000185536C60-0x0000000185536D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Nickname { get => default; set {} } // 0x0000000185536DA0-0x0000000185536E40 0x0000000185534C20-0x0000000185534CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000185534700-0x00000001855347A0 0x0000000185535F20-0x0000000185535FC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x0000000185535B80-0x0000000185535C20 0x0000000185535C20-0x0000000185535CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Signature { get => default; set {} } // 0x0000000185537020-0x00000001855370C0 0x0000000185536980-0x0000000185536A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Birthday Birthday { get => default; set {} } // 0x0000000185535260-0x0000000185535300 0x0000000185537BC0-0x0000000185537C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WorldLevel { get => default; set {} } // 0x0000000185536F80-0x0000000185537020 0x0000000185534B80-0x0000000185534C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ReservedList { get => default; } // 0x0000000185536B60-0x0000000185536BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FriendOnlineState OnlineState { get => default; set {} } // 0x0000000185537660-0x0000000185537700 0x0000000185537530-0x00000001855375D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Param { get => default; set {} } // 0x0000000185537930-0x00000001855379D0 0x0000000185537A70-0x0000000185537B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFriend { get => default; set {} } // 0x00000001855368E0-0x0000000185536980 0x0000000185533E20-0x0000000185533EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsMpModeAvailable { get => default; set {} } // 0x0000000185533EC0-0x0000000185533F60 0x0000000185537490-0x0000000185537530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OnlineId { get => default; set {} } // 0x00000001855367A0-0x0000000185536840 0x00000001855373E0-0x0000000185537490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NameCardId { get => default; set {} } // 0x0000000185536EE0-0x0000000185536F80 0x0000000185535E80-0x0000000185535F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsInBlacklist { get => default; set {} } // 0x0000000185533FC0-0x0000000185534060 0x0000000185535AE0-0x0000000185535B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsChatNoDisturb { get => default; set {} } // 0x0000000185535DE0-0x0000000185535E80 0x0000000185536840-0x00000001855368E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string RemarkName { get => default; set {} } // 0x0000000185536E40-0x0000000185536EE0 0x0000000185537B10-0x0000000185537BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishAchievementNum { get => default; set {} } // 0x0000000185536A30-0x0000000185536AD0 0x0000000185534060-0x0000000185534100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TowerFloorIndex { get => default; set {} } // 0x00000001855371B0-0x0000000185537250 0x0000000185537340-0x00000001855373E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TowerLevelIndex { get => default; set {} } // 0x00000001855379D0-0x0000000185537A70 0x0000000185535FC0-0x0000000185536060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsShowAvatar { get => default; set {} } // 0x0000000185538540-0x00000001855385E0 0x0000000185534660-0x0000000185534700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<SocialShowAvatarInfo> ShowAvatarInfoList { get => default; } // 0x0000000185533F60-0x0000000185533FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ShowNameCardIdList { get => default; } // 0x00000001855383A0-0x0000000185538400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FriendEnterHomeOption FriendEnterHomeOption { get => default; set {} } // 0x0000000185536BC0-0x0000000185536C60 0x0000000185536D00-0x0000000185536DA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SocialDetail() {} // 0x0000000185539460-0x0000000185539580
	static SocialDetail() {} // 0x0000000185539310-0x0000000185539460

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SocialDetail Clone() => default; // 0x0000000185537250-0x0000000185537340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SocialDetail ShallowCopy() => default; // 0x0000000185535D40-0x0000000185535DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001855347A0-0x0000000185534820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185537790-0x0000000185537830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185537830-0x00000001855378D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185534820-0x0000000185534B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185534CD0-0x0000000185534DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SocialDetail other) => default; // 0x0000000185534DA0-0x0000000185535260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185536150-0x00000001855367A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001855385E0-0x0000000185539310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185537C60-0x00000001855383A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185535300-0x0000000185535A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SocialDetail other) {} // 0x0000000185534100-0x0000000185534660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185533890-0x0000000185533DC0
}

