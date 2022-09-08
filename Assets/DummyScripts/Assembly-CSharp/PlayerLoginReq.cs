/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerLoginReq : MessageBase, IMessage<PlayerLoginReq> // TypeDefIndex: 24304
{
	// Fields
	private static readonly MessageParser<PlayerLoginReq> _parser; // 0x00
	public const int TokenFieldNumber = 1; // Metadata: 0x00B06193
	private string token_; // 0x18
	public const int ClientVersionFieldNumber = 2; // Metadata: 0x00B06197
	private string clientVersion_; // 0x20
	public const int SystemVersionFieldNumber = 3; // Metadata: 0x00B0619B
	private string systemVersion_; // 0x28
	public const int DeviceNameFieldNumber = 4; // Metadata: 0x00B0619F
	private string deviceName_; // 0x30
	public const int DeviceUuidFieldNumber = 5; // Metadata: 0x00B061A3
	private string deviceUuid_; // 0x38
	public const int TargetUidFieldNumber = 6; // Metadata: 0x00B061A7
	private uint targetUid_; // 0x40
	public const int LoginRandFieldNumber = 7; // Metadata: 0x00B061AB
	private ulong loginRand_; // 0x48
	public const int IsEditorFieldNumber = 8; // Metadata: 0x00B061AF
	private bool isEditor_; // 0x50
	public const int LanguageTypeFieldNumber = 9; // Metadata: 0x00B061B3
	private uint languageType_; // 0x54
	public const int AccountTypeFieldNumber = 10; // Metadata: 0x00B061B7
	private uint accountType_; // 0x58
	public const int AccountUidFieldNumber = 11; // Metadata: 0x00B061BB
	private string accountUid_; // 0x60
	public const int PlatformFieldNumber = 12; // Metadata: 0x00B061BF
	private string platform_; // 0x68
	public const int DeviceInfoFieldNumber = 13; // Metadata: 0x00B061C3
	private string deviceInfo_; // 0x70
	public const int PlatformTypeFieldNumber = 14; // Metadata: 0x00B061C7
	private uint platformType_; // 0x78
	public const int IsGuestFieldNumber = 15; // Metadata: 0x00B061CB
	private bool isGuest_; // 0x7C
	public const int CloudClientIpFieldNumber = 16; // Metadata: 0x00B061CF
	private uint cloudClientIp_; // 0x80
	public const int GmUidFieldNumber = 17; // Metadata: 0x00B061D3
	private uint gmUid_; // 0x84
	public const int ChecksumFieldNumber = 18; // Metadata: 0x00B061D7
	private string checksum_; // 0x88
	public const int OnlineIdFieldNumber = 19; // Metadata: 0x00B061DB
	private string onlineId_; // 0x90
	public const int ClientTokenFieldNumber = 20; // Metadata: 0x00B061DF
	private uint clientToken_; // 0x98
	public const int SecurityCmdReplyFieldNumber = 21; // Metadata: 0x00B061E3
	private ByteString securityCmdReply_; // 0xA0
	public const int ExtraBinDataFieldNumber = 22; // Metadata: 0x00B061E7
	private ByteString extraBinData_; // 0xA8
	public const int CpsFieldNumber = 23; // Metadata: 0x00B061EB
	private string cps_; // 0xB0
	public const int ChannelIdFieldNumber = 24; // Metadata: 0x00B061EF
	private uint channelId_; // 0xB8
	public const int SubChannelIdFieldNumber = 25; // Metadata: 0x00B061F3
	private uint subChannelId_; // 0xBC
	public const int ChecksumClientVersionFieldNumber = 26; // Metadata: 0x00B061F7
	private string checksumClientVersion_; // 0xC0
	public const int TagFieldNumber = 27; // Metadata: 0x00B061FB
	private uint tag_; // 0xC8
	public const int TrackingIoInfoFieldNumber = 28; // Metadata: 0x00B061FF
	private TrackingIOInfo trackingIoInfo_; // 0xD0
	public const int CountryCodeFieldNumber = 29; // Metadata: 0x00B06203
	private string countryCode_; // 0xD8
	public const int ClientDataVersionFieldNumber = 30; // Metadata: 0x00B06207
	private uint clientDataVersion_; // 0xE0
	public const int EnvironmentErrorCodeFieldNumber = 31; // Metadata: 0x00B0620B
	private ByteString environmentErrorCode_; // 0xE8
	public const int TargetHomeOwnerUidFieldNumber = 32; // Metadata: 0x00B0620F
	private uint targetHomeOwnerUid_; // 0xF0
	public const int PsnIdFieldNumber = 33; // Metadata: 0x00B06213
	private string psnId_; // 0xF8

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerLoginReq> Parser { get => default; } // 0x0000000183067780-0x0000000183067810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183066AD0-0x0000000183066B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183065B70-0x0000000183065BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183062B10-0x0000000183062B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183068E00-0x0000000183068EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001830680C0-0x0000000183068120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183067120-0x0000000183067210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183068DB0-0x0000000183068E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183065E80-0x0000000183065F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Token { get => default; set {} } // 0x0000000183066CB0-0x0000000183066D50 0x0000000183062C10-0x0000000183062CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientVersion { get => default; set {} } // 0x0000000183069170-0x0000000183069210 0x0000000183064A60-0x0000000183064B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string SystemVersion { get => default; set {} } // 0x0000000183066D50-0x0000000183066DF0 0x0000000183066B60-0x0000000183066C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string DeviceName { get => default; set {} } // 0x0000000183062B70-0x0000000183062C10 0x0000000183062A60-0x0000000183062B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string DeviceUuid { get => default; set {} } // 0x00000001830637D0-0x0000000183063870 0x0000000183065A20-0x0000000183065AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x00000001830668F0-0x0000000183066990 0x0000000183065980-0x0000000183065A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong LoginRand { get => default; set {} } // 0x0000000183068D10-0x0000000183068DB0 0x0000000183064020-0x00000001830640C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsEditor { get => default; set {} } // 0x0000000183067E20-0x0000000183067EC0 0x0000000183062CC0-0x0000000183062D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LanguageType { get => default; set {} } // 0x00000001830674E0-0x0000000183067580 0x0000000183066DF0-0x0000000183066E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AccountType { get => default; set {} } // 0x0000000183063DA0-0x0000000183063E40 0x0000000183065AD0-0x0000000183065B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AccountUid { get => default; set {} } // 0x0000000183069030-0x00000001830690D0 0x0000000183067F60-0x0000000183068010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Platform { get => default; set {} } // 0x0000000183066A30-0x0000000183066AD0 0x0000000183062EA0-0x0000000183062F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string DeviceInfo { get => default; set {} } // 0x0000000183066C10-0x0000000183066CB0 0x0000000183063720-0x00000001830637D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlatformType { get => default; set {} } // 0x0000000183063D00-0x0000000183063DA0 0x0000000183067EC0-0x0000000183067F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsGuest { get => default; set {} } // 0x0000000183068F90-0x0000000183069030 0x0000000183063E40-0x0000000183063EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CloudClientIp { get => default; set {} } // 0x0000000183063EE0-0x0000000183063F80 0x0000000183062D60-0x0000000183062E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GmUid { get => default; set {} } // 0x0000000183067210-0x00000001830672B0 0x00000001830681C0-0x0000000183068260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Checksum { get => default; set {} } // 0x0000000183067950-0x00000001830679F0 0x0000000183066F30-0x0000000183066FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OnlineId { get => default; set {} } // 0x0000000183066990-0x0000000183066A30 0x0000000183067580-0x0000000183067630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClientToken { get => default; set {} } // 0x00000001830690D0-0x0000000183069170 0x0000000183067630-0x00000001830676D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString SecurityCmdReply { get => default; set {} } // 0x00000001830673A0-0x0000000183067440 0x0000000183065DD0-0x0000000183065E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString ExtraBinData { get => default; set {} } // 0x0000000183066FE0-0x0000000183067080 0x00000001830658D0-0x0000000183065980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Cps { get => default; set {} } // 0x0000000183064B10-0x0000000183064BB0 0x00000001830676D0-0x0000000183067780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChannelId { get => default; set {} } // 0x0000000183063F80-0x0000000183064020 0x0000000183067C40-0x0000000183067CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SubChannelId { get => default; set {} } // 0x0000000183067080-0x0000000183067120 0x0000000183065D30-0x0000000183065DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ChecksumClientVersion { get => default; set {} } // 0x0000000183068120-0x00000001830681C0 0x00000001830678A0-0x0000000183067950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Tag { get => default; set {} } // 0x0000000183062E00-0x0000000183062EA0 0x0000000183067CE0-0x0000000183067D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrackingIOInfo TrackingIoInfo { get => default; set {} } // 0x0000000183065BF0-0x0000000183065C90 0x00000001830638F0-0x0000000183063990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string CountryCode { get => default; set {} } // 0x0000000183067D80-0x0000000183067E20 0x0000000183065820-0x00000001830658D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClientDataVersion { get => default; set {} } // 0x0000000183068EF0-0x0000000183068F90 0x0000000183066E90-0x0000000183066F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString EnvironmentErrorCode { get => default; set {} } // 0x00000001830679F0-0x0000000183067A90 0x0000000183068010-0x00000001830680C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetHomeOwnerUid { get => default; set {} } // 0x00000001830640C0-0x0000000183064160 0x0000000183067440-0x00000001830674E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PsnId { get => default; set {} } // 0x0000000183065780-0x0000000183065820 0x0000000183067B10-0x0000000183067BC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24305
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24306
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 103
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerLoginReq() {} // 0x000000018306A410-0x000000018306A570
	static PlayerLoginReq() {} // 0x000000018306A350-0x000000018306A410

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerLoginReq Clone() => default; // 0x00000001830672B0-0x00000001830673A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerLoginReq ShallowCopy() => default; // 0x0000000183065C90-0x0000000183065D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183063870-0x00000001830638F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183067A90-0x0000000183067B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183067BC0-0x0000000183067C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183063990-0x0000000183063D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183064160-0x0000000183064230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerLoginReq other) => default; // 0x0000000183064230-0x0000000183064A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183065F70-0x00000001830668F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183069210-0x000000018306A350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183068260-0x0000000183068D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183064BB0-0x0000000183065780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerLoginReq other) {} // 0x0000000183062F50-0x0000000183063720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183062500-0x0000000183062A60
}

