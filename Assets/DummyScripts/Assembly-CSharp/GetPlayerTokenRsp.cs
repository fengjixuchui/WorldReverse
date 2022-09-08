/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetPlayerTokenRsp : MessageBase, IMessage<GetPlayerTokenRsp> // TypeDefIndex: 24300
{
	// Fields
	private static readonly MessageParser<GetPlayerTokenRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06113
	private int retcode_; // 0x18
	public const int MsgFieldNumber = 2; // Metadata: 0x00B06117
	private string msg_; // 0x20
	public const int UidFieldNumber = 3; // Metadata: 0x00B0611B
	private uint uid_; // 0x28
	public const int TokenFieldNumber = 4; // Metadata: 0x00B0611F
	private string token_; // 0x30
	public const int BlackUidEndTimeFieldNumber = 5; // Metadata: 0x00B06123
	private uint blackUidEndTime_; // 0x38
	public const int AccountTypeFieldNumber = 6; // Metadata: 0x00B06127
	private uint accountType_; // 0x3C
	public const int AccountUidFieldNumber = 7; // Metadata: 0x00B0612B
	private string accountUid_; // 0x40
	public const int IsProficientPlayerFieldNumber = 8; // Metadata: 0x00B0612F
	private bool isProficientPlayer_; // 0x48
	public const int SecretKeyFieldNumber = 9; // Metadata: 0x00B06133
	private string secretKey_; // 0x50
	public const int GmUidFieldNumber = 10; // Metadata: 0x00B06137
	private uint gmUid_; // 0x58
	public const int SecretKeySeedFieldNumber = 11; // Metadata: 0x00B0613B
	private ulong secretKeySeed_; // 0x60
	public const int SecurityCmdBufferFieldNumber = 12; // Metadata: 0x00B0613F
	private ByteString securityCmdBuffer_; // 0x68
	public const int PlatformTypeFieldNumber = 13; // Metadata: 0x00B06143
	private uint platformType_; // 0x70
	public const int ExtraBinDataFieldNumber = 14; // Metadata: 0x00B06147
	private ByteString extraBinData_; // 0x78
	public const int IsGuestFieldNumber = 15; // Metadata: 0x00B0614B
	private bool isGuest_; // 0x80
	public const int ChannelIdFieldNumber = 16; // Metadata: 0x00B0614F
	private uint channelId_; // 0x84
	public const int SubChannelIdFieldNumber = 17; // Metadata: 0x00B06153
	private uint subChannelId_; // 0x88
	public const int TagFieldNumber = 18; // Metadata: 0x00B06157
	private uint tag_; // 0x8C
	public const int CountryCodeFieldNumber = 19; // Metadata: 0x00B0615B
	private string countryCode_; // 0x90
	public const int IsLoginWhiteListFieldNumber = 20; // Metadata: 0x00B0615F
	private bool isLoginWhiteList_; // 0x98
	public const int PsnIdFieldNumber = 21; // Metadata: 0x00B06163
	private string psnId_; // 0xA0

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetPlayerTokenRsp> Parser { get => default; } // 0x0000000184D1B0C0-0x0000000184D1B150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184D1AA90-0x0000000184D1AB20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184D1A070-0x0000000184D1A0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184D181D0-0x0000000184D18230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184D1BF00-0x0000000184D1BFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184D1B700-0x0000000184D1B760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184D1ADA0-0x0000000184D1AE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184D1BEB0-0x0000000184D1BF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184D1A230-0x0000000184D1A320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184D19E90-0x0000000184D19F30 0x0000000184D18CE0-0x0000000184D18D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Msg { get => default; set {} } // 0x0000000184D1A8A0-0x0000000184D1A940 0x0000000184D1C320-0x0000000184D1C3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000184D19F30-0x0000000184D19FD0 0x0000000184D1ABC0-0x0000000184D1AC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Token { get => default; set {} } // 0x0000000184D1AB20-0x0000000184D1ABC0 0x0000000184D18230-0x0000000184D182E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BlackUidEndTime { get => default; set {} } // 0x0000000184D1A9F0-0x0000000184D1AA90 0x0000000184D1B660-0x0000000184D1B700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AccountType { get => default; set {} } // 0x0000000184D18BA0-0x0000000184D18C40 0x0000000184D19FD0-0x0000000184D1A070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AccountUid { get => default; set {} } // 0x0000000184D1C1E0-0x0000000184D1C280 0x0000000184D1B5B0-0x0000000184D1B660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsProficientPlayer { get => default; set {} } // 0x0000000184D19DF0-0x0000000184D19E90 0x0000000184D18850-0x0000000184D188F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string SecretKey { get => default; set {} } // 0x0000000184D18130-0x0000000184D181D0 0x0000000184D1A940-0x0000000184D1A9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GmUid { get => default; set {} } // 0x0000000184D1AE90-0x0000000184D1AF30 0x0000000184D1B760-0x0000000184D1B800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong SecretKeySeed { get => default; set {} } // 0x0000000184D18EC0-0x0000000184D18F60 0x0000000184D1C280-0x0000000184D1C320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString SecurityCmdBuffer { get => default; set {} } // 0x0000000184D1C090-0x0000000184D1C130 0x0000000184D1C130-0x0000000184D1C1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlatformType { get => default; set {} } // 0x0000000184D18B00-0x0000000184D18BA0 0x0000000184D1B510-0x0000000184D1B5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString ExtraBinData { get => default; set {} } // 0x0000000184D1AC60-0x0000000184D1AD00 0x0000000184D19D40-0x0000000184D19DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsGuest { get => default; set {} } // 0x0000000184D1BFF0-0x0000000184D1C090 0x0000000184D18C40-0x0000000184D18CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChannelId { get => default; set {} } // 0x0000000184D18E20-0x0000000184D18EC0 0x0000000184D1B330-0x0000000184D1B3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SubChannelId { get => default; set {} } // 0x0000000184D1AD00-0x0000000184D1ADA0 0x0000000184D1A190-0x0000000184D1A230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Tag { get => default; set {} } // 0x0000000184D182E0-0x0000000184D18380 0x0000000184D1B3D0-0x0000000184D1B470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string CountryCode { get => default; set {} } // 0x0000000184D1B470-0x0000000184D1B510 0x0000000184D19C90-0x0000000184D19D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsLoginWhiteList { get => default; set {} } // 0x0000000184D18D80-0x0000000184D18E20 0x0000000184D1B020-0x0000000184D1B0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string PsnId { get => default; set {} } // 0x0000000184D19BF0-0x0000000184D19C90 0x0000000184D1B230-0x0000000184D1B2E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24301
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24302
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 102
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerTokenRsp() {} // 0x0000000184D1D020-0x0000000184D1D100
	static GetPlayerTokenRsp() {} // 0x0000000184D1CF60-0x0000000184D1D020

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerTokenRsp Clone() => default; // 0x0000000184D1AF30-0x0000000184D1B020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetPlayerTokenRsp ShallowCopy() => default; // 0x0000000184D1A0F0-0x0000000184D1A190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184D188F0-0x0000000184D18940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D1B1E0-0x0000000184D1B230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184D1B2E0-0x0000000184D1B330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184D18940-0x0000000184D18B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184D18F60-0x0000000184D19030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetPlayerTokenRsp other) => default; // 0x0000000184D19030-0x0000000184D19520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184D1A320-0x0000000184D1A8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184D1C3D0-0x0000000184D1CF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184D1B800-0x0000000184D1BEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184D19520-0x0000000184D19BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetPlayerTokenRsp other) {} // 0x0000000184D18380-0x0000000184D18850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184D17DF0-0x0000000184D18130
}

