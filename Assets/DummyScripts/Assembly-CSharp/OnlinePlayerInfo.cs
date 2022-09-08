/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OnlinePlayerInfo : MessageBase, IMessage<OnlinePlayerInfo> // TypeDefIndex: 26079
{
	// Fields
	private static readonly MessageParser<OnlinePlayerInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B0B09B
	private uint uid_; // 0x18
	public const int NicknameFieldNumber = 2; // Metadata: 0x00B0B09F
	private string nickname_; // 0x20
	public const int PlayerLevelFieldNumber = 3; // Metadata: 0x00B0B0A3
	private uint playerLevel_; // 0x28
	public const int AvatarIdFieldNumber = 4; // Metadata: 0x00B0B0A7
	private uint avatarId_; // 0x2C
	public const int MpSettingTypeFieldNumber = 5; // Metadata: 0x00B0B0AB
	private MpSettingType mpSettingType_; // 0x30
	public const int CurPlayerNumInWorldFieldNumber = 6; // Metadata: 0x00B0B0AF
	private uint curPlayerNumInWorld_; // 0x34
	public const int WorldLevelFieldNumber = 7; // Metadata: 0x00B0B0B3
	private uint worldLevel_; // 0x38
	public const int OnlineIdFieldNumber = 8; // Metadata: 0x00B0B0B7
	private string onlineId_; // 0x40
	public const int NameCardIdFieldNumber = 9; // Metadata: 0x00B0B0BB
	private uint nameCardId_; // 0x48
	public const int BlacklistUidListFieldNumber = 10; // Metadata: 0x00B0B0BF
	private static readonly FieldCodec<uint> _repeated_blacklistUidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> blacklistUidList_; // 0x50
	public const int SignatureFieldNumber = 11; // Metadata: 0x00B0B0C3
	private string signature_; // 0x58

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OnlinePlayerInfo> Parser { get => default; } // 0x00000001828C6660-0x00000001828C66F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001828C5F80-0x00000001828C6010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001828C57A0-0x00000001828C5820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001828C4780-0x00000001828C47E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001828C6E70-0x00000001828C6F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001828C68C0-0x00000001828C6920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001828C63D0-0x00000001828C64C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001828C6D80-0x00000001828C6DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001828C5960-0x00000001828C5A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001828C55C0-0x00000001828C5660 0x00000001828C60B0-0x00000001828C6150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Nickname { get => default; set {} } // 0x00000001828C6150-0x00000001828C61F0 0x00000001828C4CF0-0x00000001828C4DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayerLevel { get => default; set {} } // 0x00000001828C6920-0x00000001828C69C0 0x00000001828C6820-0x00000001828C68C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x00000001828C5660-0x00000001828C5700 0x00000001828C5700-0x00000001828C57A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpSettingType MpSettingType { get => default; set {} } // 0x00000001828C6010-0x00000001828C60B0 0x00000001828C5EE0-0x00000001828C5F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurPlayerNumInWorld { get => default; set {} } // 0x00000001828C6DD0-0x00000001828C6E70 0x00000001828C6F60-0x00000001828C7000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WorldLevel { get => default; set {} } // 0x00000001828C6290-0x00000001828C6330 0x00000001828C4C50-0x00000001828C4CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OnlineId { get => default; set {} } // 0x00000001828C5D90-0x00000001828C5E30 0x00000001828C65B0-0x00000001828C6660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NameCardId { get => default; set {} } // 0x00000001828C61F0-0x00000001828C6290 0x00000001828C58C0-0x00000001828C5960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> BlacklistUidList { get => default; } // 0x00000001828C5560-0x00000001828C55C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Signature { get => default; set {} } // 0x00000001828C6330-0x00000001828C63D0 0x00000001828C5E30-0x00000001828C5EE0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OnlinePlayerInfo() {} // 0x00000001828C7760-0x00000001828C7820
	static OnlinePlayerInfo() {} // 0x00000001828C7680-0x00000001828C7760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OnlinePlayerInfo Clone() => default; // 0x00000001828C64C0-0x00000001828C65B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OnlinePlayerInfo ShallowCopy() => default; // 0x00000001828C5820-0x00000001828C58C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001828C4AB0-0x00000001828C4B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828C6780-0x00000001828C67D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828C67D0-0x00000001828C6820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001828C4B00-0x00000001828C4C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001828C5070-0x00000001828C5140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OnlinePlayerInfo other) => default; // 0x00000001828C4DA0-0x00000001828C5070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001828C5A50-0x00000001828C5D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001828C7000-0x00000001828C7680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001828C69C0-0x00000001828C6D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001828C5140-0x00000001828C5560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OnlinePlayerInfo other) {} // 0x00000001828C47E0-0x00000001828C4AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001828C4520-0x00000001828C4780
}

