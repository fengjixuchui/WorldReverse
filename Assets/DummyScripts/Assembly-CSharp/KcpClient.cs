/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using AOT;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class KcpClient : IMiNetClient // TypeDefIndex: 21724
{
	// Fields
	public static bool enableSendCheck; // 0x00
	public const uint ASIO_KCP_CONNECTION_TIMEOUT_TIME = 10000; // Metadata: 0x00AFFD16
	protected const uint APP_ID = 1234567890; // Metadata: 0x00AFFD1A
	public static uint ASIO_KCP_MTU; // 0x04
	public static uint ASIO_KCP_SEND_WINSIZE; // 0x08
	public static uint ASIO_KCP_RECEIVE_WINSIZE; // 0x0C
	public static int KcpLogMask; // 0x10
	public const uint KCP_PACKET_MAX_LENGTH = 300000; // Metadata: 0x00AFFD1E
	public const uint UNION_PACKET_COUNT_LIMIT = 20; // Metadata: 0x00AFFD22
	public const uint UNION_PACKET_SIZE_LIMIT = 4096; // Metadata: 0x00AFFD26
	public static uint UNION_PACKET_SEND_INTERVAL; // 0x14
	private UnionCmdNotify messageCombineCache; // 0x10
	private DateTime _nextSendUnionTime; // 0x18
	private int unionCacheSize; // 0x28
	private bool needFlush; // 0x2C
	public static uint kcpConnectToken; // 0x18
	private KcpClientInitParams _initParams; // 0x30
	private IntPtr _client; // 0x48
	private readonly ReaderWriterLockSlim m_sendLock; // 0x50
	private MemoryStream _sendMemorySteam; // 0x58
	private PacketQueue<SendPacketData> _sendPackets; // 0x60
	private PacketQueue<SendPacketData> _recycleSendPackets; // 0x68
	private PacketQueue<KcpPacket> _receivePacket; // 0x70
	private ulong _sumRTT; // 0x98
	private ulong _packetCount; // 0xA0
	private DateTime _nextCalcRTTTime; // 0xA8
	private StoragePool _storagePool; // 0xC0
	private static int global_client_count; // 0x1C
	private State _state; // 0xC8
	private KcpDisconnectRequest _disconnectRequest; // 0xD0
	private const float _disconnectTimeOut = 2f; // Metadata: 0x00AFFD2A
	private static List<ushort> useCombinePacket; // 0x28
	private Thread _networkThread; // 0xD8

	// Properties
	public ReceiveHandler onPacket { /* [XID] */ /* 0x0000000189AF12F0-0x0000000189AF1330 */ get; /* [XID] */ /* 0x0000000189AFB760-0x0000000189AFB7A0 */ set; } // 0x0000000181DB0180-0x0000000181DB01E0 0x0000000181DAE1B0-0x0000000181DAE210
	public ConnectedHandler onConnected { /* [XID] */ /* 0x0000000189B05DA0-0x0000000189B05DE0 */ get; /* [XID] */ /* 0x0000000189B10630-0x0000000189B10670 */ set; } // 0x0000000181DB6140-0x0000000181DB61A0 0x0000000181DAF620-0x0000000181DAF690
	public DisconnectedHandler onDisconnected { /* [XID] */ /* 0x0000000189B1A960-0x0000000189B1A9A0 */ get; /* [XID] */ /* 0x0000000189B24FE0-0x0000000189B25020 */ set; } // 0x0000000181DB4C80-0x0000000181DB4CE0 0x0000000181DB4940-0x0000000181DB49B0
	public AfterDeserializeHandler onAfterDeserializeInWorkThread { /* [XID] */ /* 0x0000000189B2F030-0x0000000189B2F070 */ get; /* [XID] */ /* 0x0000000189B39AF0-0x0000000189B39B30 */ set; } // 0x0000000181DB49B0-0x0000000181DB4A10 0x0000000181DB5AD0-0x0000000181DB5B40
	public float appRTT { /* [XID] */ /* 0x0000000189B445F0-0x0000000189B44610 */ get => default; } // 0x0000000181DB4A10-0x0000000181DB4B10 
	public ulong maxAppRTT { /* [XID] */ /* 0x0000000189B4BD60-0x0000000189B4BDA0 */ get; /* [XID] */ /* 0x0000000189B56580-0x0000000189B565C0 */ private set; } // 0x0000000181DB0120-0x0000000181DB0180 0x0000000181DB3470-0x0000000181DB34E0
	public State state { /* [XID] */ /* 0x0000000189B60DB0-0x0000000189B60DD0 */ get => default; } // 0x0000000181DB0800-0x0000000181DB08A0 
	public static bool isIPv6 { /* [XID] */ /* 0x0000000189BA3630-0x0000000189BA3670 */ get; private set; } // 0x0000000181DAE2C0-0x0000000181DAE350 0x0000000181DAE120-0x0000000181DAE1B0

	// Nested types
	public enum State // TypeDefIndex: 21725
	{
		None = 0,
		Init = 1,
		Connecting = 2,
		Connected = 3,
		Disconnecting = 4,
		Disconnected = 5
	}

	// Constructors
	public KcpClient() {} // 0x0000000181DB6460-0x0000000181DB6650
	static KcpClient() {} // 0x0000000181DB6280-0x0000000181DB6460

	// Methods
	// [XID] // 0x00000001898EDD90-0x00000001898EDDB0
	public bool Initialize(ulong connectTimeout) => default; // 0x0000000181DB41C0-0x0000000181DB4640
	// [MonoPInvokeCallback] // 0x0000000189B6F860-0x0000000189B6F8C0
	// [XID] // 0x0000000189B6F860-0x0000000189B6F8C0
	public static void LogCallback(int level, IntPtr text, IntPtr length) {} // 0x0000000181DAF8D0-0x0000000181DB0070
	// [XID] // 0x0000000189B7E3E0-0x0000000189B7E400
	private void ResetRtt() {} // 0x0000000181DB4DC0-0x0000000181DB4F50
	// [XID] // 0x0000000189B85FF0-0x0000000189B86010
	public void Dispose() {} // 0x0000000181DB0420-0x0000000181DB0800
	// [XID] // 0x0000000189B8D070-0x0000000189B8D090
	public bool IsInitialized() => default; // 0x0000000181DAE210-0x0000000181DAE2C0
	// [XID] // 0x0000000189B94870-0x0000000189B94890
	private void CheckInitialized() {} // 0x0000000181DB4CE0-0x0000000181DB4DC0
	// [XID] // 0x0000000189B9BF40-0x0000000189B9BF60
	public IPAddress GetIPAddress(IPAddress ip, bool isIPV6Environment) => default; // 0x0000000181DB5A10-0x0000000181DB5AD0
	// [XID] // 0x0000000189BB4F00-0x0000000189BB4F20
	private static bool IsIPV6() => default; // 0x0000000181DB5CB0-0x0000000181DB5D70
	// [XID] // 0x0000000189BBC520-0x0000000189BBC540
	public static bool IsValidIP(string ip) => default; // 0x0000000181DB08A0-0x0000000181DB0970
	// [XID] // 0x0000000189BC41E0-0x0000000189BC4200
	public bool Connect(string host, ushort port, ref IPAddress ip) => default; // 0x0000000181DB3730-0x0000000181DB3C30
	// [XID] // 0x0000000189BCBB80-0x0000000189BCBBA0
	private bool ConnectWithoutGetHost(string host, ushort port, bool isIPV6Environment, ref IPAddress realIP) => default; // 0x0000000181DB01E0-0x0000000181DB0420
	// [XID] // 0x0000000189BD30B0-0x0000000189BD30D0
	private bool KcpNativeConnect(IPAddress ip, ushort port, bool isIPV6Environment, ref IPAddress realIP) => default; // 0x0000000181DB4740-0x0000000181DB4940
	// [XID] // 0x0000000189BDA930-0x0000000189BDA950
	public int Reconnect() => default; // 0x0000000181DB4640-0x0000000181DB4740
	// [XID] // 0x00000001895E7330-0x00000001895E7350
	public void Disconnect(uint disconnectReason) {} // 0x0000000181DB5D70-0x0000000181DB6140
	// [XID] // 0x00000001895EEC40-0x00000001895EEC60
	public StoragePool GetStoragePool() => default; // 0x0000000181DB5B40-0x0000000181DB5BF0
	// [XID] // 0x00000001895F6600-0x00000001895F6620
	public bool SendPacket(SendPacketData sendPacketData) => default; // 0x0000000181DB34E0-0x0000000181DB35C0
	// [XID] // 0x00000001895FD9E0-0x00000001895FDA00
	private void DoSendPacketCombine(PacketQueue<SendPacketData> packetList) {} // 0x0000000181DB1C30-0x0000000181DB2080
	// [XID] // 0x00000001896051F0-0x0000000189605210
	public void FlushUnionPacket() {} // 0x0000000181DB4F50-0x0000000181DB55E0
	// [XID] // 0x0000000189743D20-0x0000000189743D40
	public void ClearUnionPacket(ref UnionCmdNotify message) {} // 0x0000000181DB3C30-0x0000000181DB4050
	// [XID] // 0x00000001896141B0-0x00000001896141D0
	private void DoSendPacketInThread(SendPacketData sendPacketData) {} // 0x0000000181DAE410-0x0000000181DAF620
	// [XID] // 0x000000018961BBD0-0x000000018961BBF0
	public bool TryDequeueEvent(ref ClientKcpEvent evt) => default; // 0x0000000181DB1070-0x0000000181DB1150
	// [XID] // 0x0000000189623140-0x0000000189623160
	public int GetRTT() => default; // 0x0000000181DAE350-0x0000000181DAE410
	// [XID] // 0x000000018962A940-0x000000018962A960
	public int GetPacketLoss() => default; // 0x0000000181DB4BC0-0x0000000181DB4C80
	// [XID] // 0x00000001896320C0-0x00000001896320E0
	public int GetRXBandWidth() => default; // 0x0000000181DB0EC0-0x0000000181DB0F80
	// [XID] // 0x0000000189639B90-0x0000000189639BB0
	public int GetTXBandWidth() => default; // 0x0000000181DB5BF0-0x0000000181DB5CB0
	// [XID] // 0x0000000189641020-0x0000000189641040
	public float GetAvgAppRTT() => default; // 0x0000000181DB4B10-0x0000000181DB4BC0
	// [XID] // 0x00000001896489A0-0x00000001896489C0
	public ulong GetMaxAppRTT() => default; // 0x0000000181DB61A0-0x0000000181DB6280
	// [XID] // 0x00000001896500A0-0x00000001896500C0
	public int GetState() => default; // 0x0000000181DB55E0-0x0000000181DB5690
	// [XID] // 0x0000000189657950-0x0000000189657970
	public void AddConnectedHandler(ConnectedHandler onConnected) {} // 0x0000000181DB0970-0x0000000181DB0B90
	// [XID] // 0x000000018965F000-0x000000018965F020
	public void AddReceiveHandler(ReceiveHandler onPacket) {} // 0x0000000181DB5690-0x0000000181DB58B0
	// [XID] // 0x0000000189666830-0x0000000189666850
	public void AddDisconnectedHandler(DisconnectedHandler onDisconnected) {} // 0x0000000181DB0CA0-0x0000000181DB0EC0
	// [XID] // 0x000000018966DF10-0x000000018966DF30
	public void AddAfterDeserializeInWorkThreadHandler(AfterDeserializeHandler onAfterDeserialized) {} // 0x0000000181DB35C0-0x0000000181DB3730
	// [XID] // 0x0000000189675DA0-0x0000000189675DC0
	public void RemoveConnectedHandler(ConnectedHandler onConnected) {} // 0x0000000181DB4050-0x0000000181DB41C0
	// [XID] // 0x000000018967D620-0x000000018967D640
	public void RemoveReceiveHandler(ReceiveHandler onPacket) {} // 0x0000000181DB58B0-0x0000000181DB5A10
	// [XID] // 0x0000000189684CA0-0x0000000189684CC0
	public void RemoveDisconnectedHandler(DisconnectedHandler onDisconnected) {} // 0x0000000181DB0070-0x0000000181DB0120
	// [XID] // 0x000000018968C7E0-0x000000018968C800
	public void RemoveAfterDeserializeInWorkThreadHanler(AfterDeserializeHandler onAfterDeserialized) {} // 0x0000000181DB1AC0-0x0000000181DB1C30
	// [XID] // 0x00000001896942D0-0x00000001896942F0
	private void onDisconnectInternal(uint data) {} // 0x0000000181DAF690-0x0000000181DAF8D0
	// [XID] // 0x000000018969B890-0x000000018969B8B0
	public void Tick() {} // 0x0000000181DB1150-0x0000000181DB1AC0
	// [XID] // 0x00000001896A3000-0x00000001896A3020
	private void StartNetworkThread() {} // 0x0000000181DB0B90-0x0000000181DB0CA0
	// [XID] // 0x00000001896AA450-0x00000001896AA470
	private void StopNetworkThread() {} // 0x0000000181DB0F80-0x0000000181DB1070
	// [XID] // 0x00000001896B1310-0x00000001896B1330
	private void networkThread() {} // 0x0000000181DB2080-0x0000000181DB3470
}

