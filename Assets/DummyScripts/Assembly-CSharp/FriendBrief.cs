/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FriendBrief : MessageBase, IMessage<FriendBrief> // TypeDefIndex: 25533
{
	// Fields
	private static readonly MessageParser<FriendBrief> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B0900B
	private uint uid_; // 0x18
	public const int NicknameFieldNumber = 2; // Metadata: 0x00B0900F
	private string nickname_; // 0x20
	public const int LevelFieldNumber = 3; // Metadata: 0x00B09013
	private uint level_; // 0x28
	public const int AvatarIdFieldNumber = 4; // Metadata: 0x00B09017
	private uint avatarId_; // 0x2C
	public const int WorldLevelFieldNumber = 5; // Metadata: 0x00B0901B
	private uint worldLevel_; // 0x30
	public const int SignatureFieldNumber = 6; // Metadata: 0x00B0901F
	private string signature_; // 0x38
	public const int OnlineStateFieldNumber = 7; // Metadata: 0x00B09023
	private FriendOnlineState onlineState_; // 0x40
	public const int ParamFieldNumber = 8; // Metadata: 0x00B09027
	private uint param_; // 0x44
	public const int IsMpModeAvailableFieldNumber = 10; // Metadata: 0x00B0902B
	private bool isMpModeAvailable_; // 0x48
	public const int OnlineIdFieldNumber = 11; // Metadata: 0x00B0902F
	private string onlineId_; // 0x50
	public const int LastActiveTimeFieldNumber = 12; // Metadata: 0x00B09033
	private uint lastActiveTime_; // 0x58
	public const int NameCardIdFieldNumber = 13; // Metadata: 0x00B09037
	private uint nameCardId_; // 0x5C
	public const int MpPlayerNumFieldNumber = 14; // Metadata: 0x00B0903B
	private uint mpPlayerNum_; // 0x60
	public const int IsChatNoDisturbFieldNumber = 15; // Metadata: 0x00B0903F
	private bool isChatNoDisturb_; // 0x64
	public const int ChatSequenceFieldNumber = 16; // Metadata: 0x00B09043
	private uint chatSequence_; // 0x68
	public const int RemarkNameFieldNumber = 17; // Metadata: 0x00B09047
	private string remarkName_; // 0x70
	public const int ShowAvatarInfoListFieldNumber = 22; // Metadata: 0x00B0904B
	private static readonly FieldCodec<SocialShowAvatarInfo> _repeated_showAvatarInfoList_codec; // 0x08
	private readonly RepeatedMessageField<SocialShowAvatarInfo> showAvatarInfoList_; // 0x78
	public const int FriendEnterHomeOptionFieldNumber = 23; // Metadata: 0x00B0904F
	private FriendEnterHomeOption friendEnterHomeOption_; // 0x80

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FriendBrief> Parser { get => default; } // 0x00000001849FEC80-0x00000001849FED10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849FE280-0x00000001849FE310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849FD7D0-0x00000001849FD850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849FC0A0-0x00000001849FC100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849FF840-0x00000001849FF930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849FF000-0x00000001849FF060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849FE8B0-0x00000001849FE9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849FF7F0-0x00000001849FF840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849FDAD0-0x00000001849FDBC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001849FD5F0-0x00000001849FD690 0x00000001849FE450-0x00000001849FE4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Nickname { get => default; set {} } // 0x00000001849FE590-0x00000001849FE630 0x00000001849FCA20-0x00000001849FCAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x00000001849FC630-0x00000001849FC6D0 0x00000001849FDA30-0x00000001849FDAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x00000001849FD690-0x00000001849FD730 0x00000001849FD730-0x00000001849FD7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WorldLevel { get => default; set {} } // 0x00000001849FE770-0x00000001849FE810 0x00000001849FC8E0-0x00000001849FC980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Signature { get => default; set {} } // 0x00000001849FE810-0x00000001849FE8B0 0x00000001849FE1D0-0x00000001849FE280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FriendOnlineState OnlineState { get => default; set {} } // 0x00000001849FED10-0x00000001849FEDB0 0x00000001849FEBE0-0x00000001849FEC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Param { get => default; set {} } // 0x00000001849FF060-0x00000001849FF100 0x00000001849FF100-0x00000001849FF1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsMpModeAvailable { get => default; set {} } // 0x00000001849FC100-0x00000001849FC1A0 0x00000001849FEB40-0x00000001849FEBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OnlineId { get => default; set {} } // 0x00000001849FE090-0x00000001849FE130 0x00000001849FEA90-0x00000001849FEB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastActiveTime { get => default; set {} } // 0x00000001849FEE40-0x00000001849FEEE0 0x00000001849FF930-0x00000001849FF9D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NameCardId { get => default; set {} } // 0x00000001849FE6D0-0x00000001849FE770 0x00000001849FD990-0x00000001849FDA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayerNum { get => default; set {} } // 0x00000001849FE310-0x00000001849FE3B0 0x00000001849FC980-0x00000001849FCA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsChatNoDisturb { get => default; set {} } // 0x00000001849FD8F0-0x00000001849FD990 0x00000001849FE130-0x00000001849FE1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChatSequence { get => default; set {} } // 0x00000001849FCAD0-0x00000001849FCB70 0x00000001849FC000-0x00000001849FC0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string RemarkName { get => default; set {} } // 0x00000001849FE630-0x00000001849FE6D0 0x00000001849FF1A0-0x00000001849FF250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<SocialShowAvatarInfo> ShowAvatarInfoList { get => default; } // 0x00000001849FC1A0-0x00000001849FC200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FriendEnterHomeOption FriendEnterHomeOption { get => default; set {} } // 0x00000001849FE3B0-0x00000001849FE450 0x00000001849FE4F0-0x00000001849FE590

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FriendBrief() {} // 0x0000000184A00510-0x0000000184A005E0
	static FriendBrief() {} // 0x0000000184A00400-0x0000000184A00510

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FriendBrief Clone() => default; // 0x00000001849FE9A0-0x00000001849FEA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FriendBrief ShallowCopy() => default; // 0x00000001849FD850-0x00000001849FD8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849FC6D0-0x00000001849FC720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849FEEE0-0x00000001849FEF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849FEF70-0x00000001849FF000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849FC720-0x00000001849FC8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849FCF50-0x00000001849FD020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FriendBrief other) => default; // 0x00000001849FCB70-0x00000001849FCF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849FDBC0-0x00000001849FE090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849FF9D0-0x0000000184A00400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849FF250-0x00000001849FF7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849FD020-0x00000001849FD5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FriendBrief other) {} // 0x00000001849FC200-0x00000001849FC630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849FBCA0-0x00000001849FC000
}

