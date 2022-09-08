/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientLogHead : MessageBase, IMessage<ClientLogHead> // TypeDefIndex: 26114
{
	// Fields
	private static readonly MessageParser<ClientLogHead> _parser; // 0x00
	public const int EventTimeFieldNumber = 1; // Metadata: 0x00B0BD5F
	private string eventTime_; // 0x18
	public const int LogSerialNumberFieldNumber = 2; // Metadata: 0x00B0BD63
	private string logSerialNumber_; // 0x20
	public const int ActionIdFieldNumber = 3; // Metadata: 0x00B0BD67
	private uint actionId_; // 0x28
	public const int ActionNameFieldNumber = 4; // Metadata: 0x00B0BD6B
	private string actionName_; // 0x30
	public const int UploadIpFieldNumber = 5; // Metadata: 0x00B0BD6F
	private string uploadIp_; // 0x38
	public const int ProductIdFieldNumber = 6; // Metadata: 0x00B0BD73
	private string productId_; // 0x40
	public const int ChannelIdFieldNumber = 7; // Metadata: 0x00B0BD77
	private string channelId_; // 0x48
	public const int RegionNameFieldNumber = 8; // Metadata: 0x00B0BD7B
	private string regionName_; // 0x50
	public const int GameVersionFieldNumber = 9; // Metadata: 0x00B0BD7F
	private string gameVersion_; // 0x58
	public const int DeviceTypeFieldNumber = 10; // Metadata: 0x00B0BD83
	private string deviceType_; // 0x60
	public const int DeviceUuidFieldNumber = 11; // Metadata: 0x00B0BD87
	private string deviceUuid_; // 0x68
	public const int MacAddrFieldNumber = 12; // Metadata: 0x00B0BD8B
	private string macAddr_; // 0x70
	public const int AccountNameFieldNumber = 13; // Metadata: 0x00B0BD8F
	private string accountName_; // 0x78
	public const int AccountUuidFieldNumber = 14; // Metadata: 0x00B0BD93
	private string accountUuid_; // 0x80

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientLogHead> Parser { get => default; } // 0x0000000182B68630-0x0000000182B686C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182B681D0-0x0000000182B68260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182B67950-0x0000000182B679D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182B65D60-0x0000000182B65DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182B69150-0x0000000182B69240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182B689F0-0x0000000182B68A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182B68300-0x0000000182B683F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182B68FB0-0x0000000182B69000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182B67B10-0x0000000182B67C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string EventTime { get => default; set {} } // 0x0000000182B68950-0x0000000182B689F0 0x0000000182B65F00-0x0000000182B65FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string LogSerialNumber { get => default; set {} } // 0x0000000182B66840-0x0000000182B668E0 0x0000000182B66490-0x0000000182B66540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActionId { get => default; set {} } // 0x0000000182B690B0-0x0000000182B69150 0x0000000182B65DC0-0x0000000182B65E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ActionName { get => default; set {} } // 0x0000000182B65910-0x0000000182B659B0 0x0000000182B66590-0x0000000182B66640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string UploadIp { get => default; set {} } // 0x0000000182B65CC0-0x0000000182B65D60 0x0000000182B678A0-0x0000000182B67950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ProductId { get => default; set {} } // 0x0000000182B684E0-0x0000000182B68580 0x0000000182B68580-0x0000000182B68630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ChannelId { get => default; set {} } // 0x0000000182B66980-0x0000000182B66A20 0x0000000182B688A0-0x0000000182B68950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string RegionName { get => default; set {} } // 0x0000000182B66A20-0x0000000182B66AC0 0x0000000182B66640-0x0000000182B666F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GameVersion { get => default; set {} } // 0x0000000182B65E60-0x0000000182B65F00 0x0000000182B66AC0-0x0000000182B66B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string DeviceType { get => default; set {} } // 0x0000000182B67150-0x0000000182B671F0 0x0000000182B65C10-0x0000000182B65CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string DeviceUuid { get => default; set {} } // 0x0000000182B663F0-0x0000000182B66490 0x0000000182B677F0-0x0000000182B678A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string MacAddr { get => default; set {} } // 0x0000000182B67A70-0x0000000182B67B10 0x0000000182B69000-0x0000000182B690B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AccountName { get => default; set {} } // 0x0000000182B68260-0x0000000182B68300 0x0000000182B68750-0x0000000182B68800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AccountUuid { get => default; set {} } // 0x0000000182B668E0-0x0000000182B66980 0x0000000182B68120-0x0000000182B681D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientLogHead() {} // 0x0000000182B69A40-0x0000000182B69B40
	static ClientLogHead() {} // 0x0000000182B69980-0x0000000182B69A40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientLogHead Clone() => default; // 0x0000000182B683F0-0x0000000182B684E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientLogHead ShallowCopy() => default; // 0x0000000182B679D0-0x0000000182B67A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182B66540-0x0000000182B66590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B68800-0x0000000182B68850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B68850-0x0000000182B688A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182B666F0-0x0000000182B66840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182B66B70-0x0000000182B66C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientLogHead other) => default; // 0x0000000182B66C40-0x0000000182B67150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182B67C00-0x0000000182B68120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182B69240-0x0000000182B69980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182B68A50-0x0000000182B68FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182B671F0-0x0000000182B677F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientLogHead other) {} // 0x0000000182B65FB0-0x0000000182B663F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182B659B0-0x0000000182B65C10
}

