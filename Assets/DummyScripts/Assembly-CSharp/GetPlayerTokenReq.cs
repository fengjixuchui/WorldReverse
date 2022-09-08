/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetPlayerTokenReq : MessageBase, IMessage<GetPlayerTokenReq> // TypeDefIndex: 24297
{
	// Fields
	private static readonly MessageParser<GetPlayerTokenReq> _parser; // 0x00
	public const int AccountTypeFieldNumber = 1; // Metadata: 0x00B060C7
	private uint accountType_; // 0x18
	public const int AccountUidFieldNumber = 2; // Metadata: 0x00B060CB
	private string accountUid_; // 0x20
	public const int AccountTokenFieldNumber = 3; // Metadata: 0x00B060CF
	private string accountToken_; // 0x28
	public const int AccountExtFieldNumber = 4; // Metadata: 0x00B060D3
	private string accountExt_; // 0x30
	public const int UidFieldNumber = 5; // Metadata: 0x00B060D7
	private uint uid_; // 0x38
	public const int IsGuestFieldNumber = 6; // Metadata: 0x00B060DB
	private bool isGuest_; // 0x3C
	public const int PlatformTypeFieldNumber = 7; // Metadata: 0x00B060DF
	private uint platformType_; // 0x40
	public const int CloudClientIpFieldNumber = 8; // Metadata: 0x00B060E3
	private uint cloudClientIp_; // 0x44
	public const int OnlineIdFieldNumber = 9; // Metadata: 0x00B060E7
	private string onlineId_; // 0x48
	public const int PsnRegionFieldNumber = 10; // Metadata: 0x00B060EB
	private string psnRegion_; // 0x50
	public const int ChannelIdFieldNumber = 11; // Metadata: 0x00B060EF
	private uint channelId_; // 0x58
	public const int SubChannelIdFieldNumber = 12; // Metadata: 0x00B060F3
	private uint subChannelId_; // 0x5C
	public const int CountryCodeFieldNumber = 13; // Metadata: 0x00B060F7
	private string countryCode_; // 0x60
	public const int PsnIdFieldNumber = 14; // Metadata: 0x00B060FB
	private string psnId_; // 0x68

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetPlayerTokenReq> Parser { get => default; } // 0x00000001819A9B60-0x00000001819A9BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001819A9500-0x00000001819A9590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001819A8D80-0x00000001819A8E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001819A75D0-0x00000001819A7630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001819AA5E0-0x00000001819AA6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001819AA060-0x00000001819AA0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001819A9830-0x00000001819A9920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001819AA590-0x00000001819AA5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001819A8F40-0x00000001819A9030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AccountType { get => default; set {} } // 0x00000001819A7DE0-0x00000001819A7E80 0x00000001819A8CE0-0x00000001819A8D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AccountUid { get => default; set {} } // 0x00000001819AA770-0x00000001819AA810 0x00000001819A9FB0-0x00000001819AA060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AccountToken { get => default; set {} } // 0x00000001819A7630-0x00000001819A76D0 0x00000001819A7FC0-0x00000001819A8070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AccountExt { get => default; set {} } // 0x00000001819A9AC0-0x00000001819A9B60 0x00000001819A96E0-0x00000001819A9790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001819A8C40-0x00000001819A8CE0 0x00000001819A9640-0x00000001819A96E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsGuest { get => default; set {} } // 0x00000001819AA6D0-0x00000001819AA770 0x00000001819A7E80-0x00000001819A7F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlatformType { get => default; set {} } // 0x00000001819A7D40-0x00000001819A7DE0 0x00000001819A9F10-0x00000001819A9FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CloudClientIp { get => default; set {} } // 0x00000001819A7F20-0x00000001819A7FC0 0x00000001819A76D0-0x00000001819A7770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OnlineId { get => default; set {} } // 0x00000001819A9460-0x00000001819A9500 0x00000001819A9A10-0x00000001819A9AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PsnRegion { get => default; set {} } // 0x00000001819A7B70-0x00000001819A7C10 0x00000001819A9590-0x00000001819A9640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChannelId { get => default; set {} } // 0x00000001819A8070-0x00000001819A8110 0x00000001819A9DD0-0x00000001819A9E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SubChannelId { get => default; set {} } // 0x00000001819A9790-0x00000001819A9830 0x00000001819A8EA0-0x00000001819A8F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string CountryCode { get => default; set {} } // 0x00000001819A9E70-0x00000001819A9F10 0x00000001819A8B90-0x00000001819A8C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PsnId { get => default; set {} } // 0x00000001819A8AF0-0x00000001819A8B90 0x00000001819A9CD0-0x00000001819A9D80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24298
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24299
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 101
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerTokenReq() {} // 0x00000001819AB0B0-0x00000001819AB160
	static GetPlayerTokenReq() {} // 0x00000001819AAFF0-0x00000001819AB0B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerTokenReq Clone() => default; // 0x00000001819A9920-0x00000001819A9A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerTokenReq ShallowCopy() => default; // 0x00000001819A8E00-0x00000001819A8EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001819A7B20-0x00000001819A7B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819A9C80-0x00000001819A9CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001819A9D80-0x00000001819A9DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001819A7C10-0x00000001819A7D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001819A8110-0x00000001819A81E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetPlayerTokenReq other) => default; // 0x00000001819A81E0-0x00000001819A85D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001819A9030-0x00000001819A9460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001819AA810-0x00000001819AAFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001819AA0C0-0x00000001819AA590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001819A85D0-0x00000001819A8AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetPlayerTokenReq other) {} // 0x00000001819A7770-0x00000001819A7B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001819A7370-0x00000001819A75D0
}

