/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PacketHead : MessageBase, IMessage<PacketHead> // TypeDefIndex: 21705
{
	// Fields
	private static readonly MessageParser<PacketHead> _parser; // 0x00
	public const int PacketIdFieldNumber = 1; // Metadata: 0x00AFFCA6
	private uint packetId_; // 0x18
	public const int RpcIdFieldNumber = 2; // Metadata: 0x00AFFCAA
	private uint rpcId_; // 0x1C
	public const int ClientSequenceIdFieldNumber = 3; // Metadata: 0x00AFFCAE
	private uint clientSequenceId_; // 0x20
	public const int EnetChannelIdFieldNumber = 4; // Metadata: 0x00AFFCB2
	private uint enetChannelId_; // 0x24
	public const int EnetIsReliableFieldNumber = 5; // Metadata: 0x00AFFCB6
	private uint enetIsReliable_; // 0x28
	public const int SentMsFieldNumber = 6; // Metadata: 0x00AFFCBA
	private ulong sentMs_; // 0x30
	public const int UserIdFieldNumber = 11; // Metadata: 0x00AFFCBE
	private uint userId_; // 0x38
	public const int UserIpFieldNumber = 12; // Metadata: 0x00AFFCC2
	private uint userIp_; // 0x3C
	public const int UserSessionIdFieldNumber = 13; // Metadata: 0x00AFFCC6
	private uint userSessionId_; // 0x40
	public const int RecvTimeMsFieldNumber = 21; // Metadata: 0x00AFFCCA
	private ulong recvTimeMs_; // 0x48
	public const int RpcBeginTimeMsFieldNumber = 22; // Metadata: 0x00AFFCCE
	private uint rpcBeginTimeMs_; // 0x50
	public const int ExtMapFieldNumber = 23; // Metadata: 0x00AFFCD2
	private static readonly MapField<uint, uint> _map_extMap_codec; // 0x08
	private readonly MapField<uint, uint> extMap_; // 0x58
	public const int SenderAppIdFieldNumber = 24; // Metadata: 0x00AFFCD6
	private uint senderAppId_; // 0x60
	public const int SourceServiceFieldNumber = 31; // Metadata: 0x00AFFCDA
	private uint sourceService_; // 0x64
	public const int TargetServiceFieldNumber = 32; // Metadata: 0x00AFFCDE
	private uint targetService_; // 0x68
	public const int ServiceAppIdMapFieldNumber = 33; // Metadata: 0x00AFFCE2
	private static readonly MapField<uint, uint> _map_serviceAppIdMap_codec; // 0x10
	private readonly MapField<uint, uint> serviceAppIdMap_; // 0x70
	public const int IsSetGameThreadFieldNumber = 34; // Metadata: 0x00AFFCE6
	private bool isSetGameThread_; // 0x78
	public const int GameThreadIndexFieldNumber = 35; // Metadata: 0x00AFFCEA
	private uint gameThreadIndex_; // 0x7C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PacketHead> Parser { get => default; } // 0x0000000184CB8660-0x0000000184CB86F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184CB7B60-0x0000000184CB7BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184CB7580-0x0000000184CB7600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184CB6060-0x0000000184CB60C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184CB9280-0x0000000184CB9370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184CB8B20-0x0000000184CB8B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184CB8050-0x0000000184CB8140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184CB9230-0x0000000184CB9280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184CB76A0-0x0000000184CB7790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PacketId { get => default; set {} } // 0x0000000184CB69D0-0x0000000184CB6A70 0x0000000184CB9410-0x0000000184CB94B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RpcId { get => default; set {} } // 0x0000000184CB6F30-0x0000000184CB6FD0 0x0000000184CB8140-0x0000000184CB81E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClientSequenceId { get => default; set {} } // 0x0000000184CB5FC0-0x0000000184CB6060 0x0000000184CB6930-0x0000000184CB69D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EnetChannelId { get => default; set {} } // 0x0000000184CB67F0-0x0000000184CB6890 0x0000000184CB90F0-0x0000000184CB9190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EnetIsReliable { get => default; set {} } // 0x0000000184CB8520-0x0000000184CB85C0 0x0000000184CB6A70-0x0000000184CB6B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong SentMs { get => default; set {} } // 0x0000000184CB9190-0x0000000184CB9230 0x0000000184CB7BF0-0x0000000184CB7C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint UserId { get => default; set {} } // 0x0000000184CB8340-0x0000000184CB83E0 0x0000000184CB65E0-0x0000000184CB6680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint UserIp { get => default; set {} } // 0x0000000184CB60C0-0x0000000184CB6160 0x0000000184CB6890-0x0000000184CB6930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint UserSessionId { get => default; set {} } // 0x0000000184CB86F0-0x0000000184CB8790 0x0000000184CB8A80-0x0000000184CB8B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong RecvTimeMs { get => default; set {} } // 0x0000000184CB7600-0x0000000184CB76A0 0x0000000184CB7FB0-0x0000000184CB8050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RpcBeginTimeMs { get => default; set {} } // 0x0000000184CB82A0-0x0000000184CB8340 0x0000000184CB9370-0x0000000184CB9410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> ExtMap { get => default; } // 0x0000000184CB8850-0x0000000184CB88F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SenderAppId { get => default; set {} } // 0x0000000184CB85C0-0x0000000184CB8660 0x0000000184CB7DD0-0x0000000184CB7E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SourceService { get => default; set {} } // 0x0000000184CB89E0-0x0000000184CB8A80 0x0000000184CB64F0-0x0000000184CB6590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetService { get => default; set {} } // 0x0000000184CB8480-0x0000000184CB8520 0x0000000184CB7E70-0x0000000184CB7F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> ServiceAppIdMap { get => default; } // 0x0000000184CB7C90-0x0000000184CB7D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSetGameThread { get => default; set {} } // 0x0000000184CB7D30-0x0000000184CB7DD0 0x0000000184CB8940-0x0000000184CB89E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GameThreadIndex { get => default; set {} } // 0x0000000184CB83E0-0x0000000184CB8480 0x0000000184CB7F10-0x0000000184CB7FB0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PacketHead() {} // 0x0000000184CBA1D0-0x0000000184CBA280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PacketHead(PacketHead other) {} // 0x0000000184CBA0B0-0x0000000184CBA1D0
	static PacketHead() {} // 0x0000000184CB9F20-0x0000000184CBA0B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PacketHead Clone() => default; // 0x0000000184CB81E0-0x0000000184CB82A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CB88F0-0x0000000184CB8940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CB8800-0x0000000184CB8850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184CB6590-0x0000000184CB65E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184CB6680-0x0000000184CB67F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184CB6E60-0x0000000184CB6F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PacketHead other) => default; // 0x0000000184CB6B10-0x0000000184CB6E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184CB7790-0x0000000184CB7B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184CB94B0-0x0000000184CB9F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184CB8B80-0x0000000184CB90F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184CB6FD0-0x0000000184CB7580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PacketHead other) {} // 0x0000000184CB6160-0x0000000184CB64F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184CB5C00-0x0000000184CB5FC0
}

