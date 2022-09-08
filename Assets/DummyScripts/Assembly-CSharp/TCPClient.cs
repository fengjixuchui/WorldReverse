/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class TCPClient : IMiNetClient // TypeDefIndex: 21324
{
	// Fields
	private string host_; // 0x10
	private ushort port_; // 0x18
	private Socket socket_; // 0x20
	private ManualResetEvent timeout_event_; // 0x28
	private int timeout_ms_; // 0x30
	private Thread client_producer_thread_; // 0x38
	private Queue<Packet> recv_queue_; // 0x40
	private bool connected_before_; // 0x48
	private bool use_thread; // 0x49
	private ConnectedHandler connect_callback_; // 0x50
	private DisconnectedHandler disconnect_callback_; // 0x58
	private ReceiveHandler doCmd_callback_; // 0x60
	private AfterDeserializeHandler after_deserialize_callback_; // 0x68
	private int keepalive_time_ms_; // 0x70
	private DateTime last_keepalive_time_; // 0x78
	private SendPacketData keepalive_packet_; // 0x88
	private byte[] recv_buf_; // 0x90
	private int left_buf_len_; // 0x98
	private EndPoint _remoteEndPoint; // 0xA0
	private MemoryStream _sendStream; // 0xA8
	private StoragePool _storagePool; // 0xB0
	private MiNetClient.State _state; // 0xB8

	// Properties
	public string Host { /* [XID] */ /* 0x0000000189898E30-0x0000000189898E50 */ get => default; } // 0x00000001816FACE0-0x00000001816FAD80 
	public ushort Port { /* [XID] */ /* 0x000000018989FFB0-0x000000018989FFD0 */ get => default; } // 0x00000001816F6F70-0x00000001816F7010 
	public static bool isIPv6 { /* [XID] */ /* 0x0000000189920190-0x00000001899201D0 */ get; private set; } // 0x00000001816F6720-0x00000001816F6780 0x00000001816F63C0-0x00000001816F6420

	// Constructors
	public TCPClient() {} // 0x00000001816FAE20-0x00000001816FAFF0

	// Methods
	// [XID] // 0x00000001898A7830-0x00000001898A7850
	public bool connect(string host, ushort port, ref IPAddress ip, int timeout_ms = 2000 /* Metadata: 0x00AFF45C */) => default; // 0x00000001816F8150-0x00000001816F8E20
	// [XID] // 0x00000001898AF2F0-0x00000001898AF310
	private void connectCallback(IAsyncResult asyncresult) {} // 0x00000001816F7B30-0x00000001816F7E10
	// [XID] // 0x00000001898B6770-0x00000001898B6790
	public void disconnect(uint disconnectReason) {} // 0x00000001816F6420-0x00000001816F6720
	// [XID] // 0x00000001898BDF20-0x00000001898BDF40
	private void Release() {} // 0x00000001816F8070-0x00000001816F8150
	// [XID] // 0x00000001898C57F0-0x00000001898C5810
	public bool isConnected(bool fromUnityThread = false /* Metadata: 0x00AFF460 */) => default; // 0x00000001816F6BD0-0x00000001816F6E90
	// [XID] // 0x00000001898CCED0-0x00000001898CCEF0
	public bool send(SendPacketData packet) => default; // 0x00000001816F9CB0-0x00000001816FA640
	// [XID] // 0x00000001898D4830-0x00000001898D4850
	private int recvPacketList() => default; // 0x00000001816F8F80-0x00000001816F9B60
	// [XID] // 0x00000001898DC230-0x00000001898DC250
	private void clientProducerThreadHandler() {} // 0x00000001816F7E10-0x00000001816F7F40
	// [XID] // 0x00000001898E3C00-0x00000001898E3C20
	private void RecvTick() {} // 0x00000001816F7F40-0x00000001816F8070
	// [XID] // 0x00000001898EB7B0-0x00000001898EB7D0
	private void clientConsumerThreadHandler() {} // 0x00000001816F68E0-0x00000001816F6AC0
	// [XID] // 0x00000001898F3000-0x00000001898F3020
	public int GetPacktNumInQueue() => default; // 0x00000001816FA8A0-0x00000001816FA960
	// [XID] // 0x00000001898FA6E0-0x00000001898FA700
	public Packet recv(int timeout_ms = 0 /* Metadata: 0x00AFF461 */) => default; // 0x00000001816F7620-0x00000001816F77B0
	// [XID] // 0x0000000189902050-0x0000000189902070
	private bool isClientThreadRun() => default; // 0x00000001816F6820-0x00000001816F68E0
	// [XID] // 0x0000000189909880-0x00000001899098A0
	private bool startClientThread() => default; // 0x00000001816F8E20-0x00000001816F8F80
	// [XID] // 0x0000000189910ED0-0x0000000189910EF0
	public bool setKeepalive(int time_ms, SendPacketData packet) => default; // 0x00000001816F6AC0-0x00000001816F6BD0
	// [XID] // 0x00000001899189B0-0x00000001899189D0
	private void keepalive() {} // 0x00000001816F7010-0x00000001816F7180
	// [XID] // 0x0000000189932080-0x00000001899320A0
	public static bool IsIPV6() => default; // 0x00000001816FAB50-0x00000001816FAC30
	// [XID] // 0x0000000189939A30-0x0000000189939A50
	public static IPAddress GetIPAddress(IPAddress ip) => default; // 0x00000001816FA960-0x00000001816FAA00
	// [XID] // 0x0000000189940C00-0x0000000189940C20
	public bool Connect(string host, ushort port, ref IPAddress ip) => default; // 0x00000001816F7950-0x00000001816F7A50
	// [XID] // 0x00000001899485A0-0x00000001899485C0
	public void Disconnect(uint disconnectReason) {} // 0x00000001816FAC30-0x00000001816FACE0
	// [XID] // 0x000000018994FD10-0x000000018994FD30
	public bool SendPacket(SendPacketData sendData) => default; // 0x00000001816F77B0-0x00000001816F7870
	// [XID] // 0x0000000189957280-0x00000001899572A0
	public void AddConnectedHandler(ConnectedHandler onConnected) {} // 0x00000001816F7220-0x00000001816F7300
	// [XID] // 0x000000018995ED70-0x000000018995ED90
	public void AddReceiveHandler(ReceiveHandler onPacket) {} // 0x00000001816FA6E0-0x00000001816FA7C0
	// [XID] // 0x00000001899665D0-0x00000001899665F0
	public void AddDisconnectedHandler(DisconnectedHandler onDisconnected) {} // 0x00000001816F7300-0x00000001816F73E0
	// [XID] // 0x000000018996D9B0-0x000000018996D9D0
	public void AddAfterDeserializeInWorkThreadHandler(AfterDeserializeHandler onAfterDeserialized) {} // 0x00000001816F7870-0x00000001816F7950
	// [XID] // 0x0000000189975550-0x0000000189975570
	public void RemoveConnectedHandler(ConnectedHandler onConnected) {} // 0x00000001816F7A50-0x00000001816F7B30
	// [XID] // 0x000000018997C6F0-0x000000018997C710
	public void RemoveReceiveHandler(ReceiveHandler onPacket) {} // 0x00000001816FA7C0-0x00000001816FA8A0
	// [XID] // 0x0000000189984430-0x0000000189984450
	public void RemoveDisconnectedHandler(DisconnectedHandler onDisconnected) {} // 0x00000001816F6E90-0x00000001816F6F70
	// [XID] // 0x000000018998BED0-0x000000018998BEF0
	public void RemoveAfterDeserializeInWorkThreadHanler(AfterDeserializeHandler onAfterDeserialized) {} // 0x00000001816F7540-0x00000001816F7620
	// [XID] // 0x0000000189993B90-0x0000000189993BB0
	public void Tick() {} // 0x00000001816F7480-0x00000001816F7540
	// [XID] // 0x000000018999B420-0x000000018999B440
	public StoragePool GetStoragePool() => default; // 0x00000001816FAA00-0x00000001816FAAB0
	// [XID] // 0x00000001899A2BD0-0x00000001899A2BF0
	public int GetState() => default; // 0x00000001816FA640-0x00000001816FA6E0
	// [XID] // 0x00000001899AA5E0-0x00000001899AA600
	public int GetRTT() => default; // 0x00000001816F6780-0x00000001816F6820
	// [XID] // 0x00000001899B1F80-0x00000001899B1FA0
	public int GetPacketLoss() => default; // 0x00000001816F9C10-0x00000001816F9CB0
	// [XID] // 0x00000001899B93A0-0x00000001899B93C0
	public float GetAvgAppRTT() => default; // 0x00000001816F9B60-0x00000001816F9C10
	// [XID] // 0x00000001899C0DD0-0x00000001899C0DF0
	public ulong GetMaxAppRTT() => default; // 0x00000001816FAD80-0x00000001816FAE20
	// [XID] // 0x00000001899C83B0-0x00000001899C83D0
	public int GetTXBandWidth() => default; // 0x00000001816FAAB0-0x00000001816FAB50
	// [XID] // 0x00000001899CFE30-0x00000001899CFE50
	public int GetRXBandWidth() => default; // 0x00000001816F73E0-0x00000001816F7480
	// [XID] // 0x00000001899D7260-0x00000001899D7280
	public void Dispose() {} // 0x00000001816F7180-0x00000001816F7220
}

