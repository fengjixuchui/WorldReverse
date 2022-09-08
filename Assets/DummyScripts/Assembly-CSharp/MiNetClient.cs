/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MiNetClient // TypeDefIndex: 21197
{
	// Fields
	private IMiNetClient _curClient; // 0x10
	private Type _type; // 0x18

	// Nested types
	public enum Type // TypeDefIndex: 21198
	{
		UDP = 0,
		TCP = 1
	}

	public enum State // TypeDefIndex: 21199
	{
		None = 0,
		Init = 1,
		Connecting = 2,
		Connected = 3,
		Disconnecting = 4,
		Disconnected = 5
	}

	// Constructors
	public MiNetClient() {} // 0x0000000181D7C2F0-0x0000000181D7C350

	// Methods
	// [XID] // 0x00000001895F0580-0x00000001895F05A0
	public bool Inistialize(Type type) => default; // 0x0000000181D7BFE0-0x0000000181D7C160
	// [XID] // 0x0000000189A718D0-0x0000000189A718F0
	public bool Connect(string host, ushort port, ref IPAddress ip) => default; // 0x0000000181D7B7B0-0x0000000181D7B8F0
	// [XID] // 0x00000001895FF3D0-0x00000001895FF3F0
	public void Disconnect(uint disconnectReason) {} // 0x0000000181D7C160-0x0000000181D7C230
	// [XID] // 0x000000018961CCA0-0x000000018961CCC0
	public bool SendPacket(SendPacketData sendData) => default; // 0x0000000181D7B5D0-0x0000000181D7B6E0
	// [XID] // 0x000000018960E580-0x000000018960E5A0
	public void AddConnectedHandler(ConnectedHandler onConnected) {} // 0x0000000181D7B1F0-0x0000000181D7B2C0
	// [XID] // 0x00000001899E8AE0-0x00000001899E8B00
	public void AddReceiveHandler(ReceiveHandler onPacket) {} // 0x0000000181D7BC10-0x0000000181D7BCE0
	// [XID] // 0x000000018961D450-0x000000018961D470
	public void AddDisconnectedHandler(DisconnectedHandler onDisconnected) {} // 0x0000000181D7B2C0-0x0000000181D7B390
	// [XID] // 0x0000000189624950-0x0000000189624970
	public void AddAfterDeserializeInWorkThreadHandler(AfterDeserializeHandler onAfterDeserialized) {} // 0x0000000181D7B6E0-0x0000000181D7B7B0
	// [XID] // 0x000000018962C0D0-0x000000018962C0F0
	public void RemoveConnectedHandler(ConnectedHandler onConnected) {} // 0x0000000181D7B8F0-0x0000000181D7B9C0
	// [XID] // 0x0000000189633C10-0x0000000189633C30
	public void RemoveReceiveHandler(ReceiveHandler onPacket) {} // 0x0000000181D7BD90-0x0000000181D7BE60
	// [XID] // 0x000000018963B4B0-0x000000018963B4D0
	public void RemoveDisconnectedHandler(DisconnectedHandler onDisconnected) {} // 0x0000000181D7B120-0x0000000181D7B1F0
	// [XID] // 0x0000000189642C60-0x0000000189642C80
	public void RemoveAfterDeserializeInWorkThreadHanler(AfterDeserializeHandler onAfterDeserialized) {} // 0x0000000181D7B500-0x0000000181D7B5D0
	// [XID] // 0x000000018964A290-0x000000018964A2B0
	public void Tick() {} // 0x0000000181D7B450-0x0000000181D7B500
	// [XID] // 0x00000001896519E0-0x0000000189651A00
	public StoragePool GetStoragePool() => default; // 0x0000000181D7BE60-0x0000000181D7BF20
	// [XID] // 0x00000001896592B0-0x00000001896592D0
	public int GetRTT() => default; // 0x0000000181D7B060-0x0000000181D7B120
	// [XID] // 0x0000000189660970-0x0000000189660990
	public int GetPacketLoss() => default; // 0x0000000181D7BA90-0x0000000181D7BB50
	// [XID] // 0x0000000189668380-0x00000001896683A0
	public float GetAvgAppRTT() => default; // 0x0000000181D7B9C0-0x0000000181D7BA90
	// [XID] // 0x000000018966FE50-0x000000018966FE70
	public ulong GetMaxAppRTT() => default; // 0x0000000181D7C230-0x0000000181D7C2F0
	// [XID] // 0x0000000189677680-0x00000001896776A0
	public State GetState() => default; // 0x0000000181D7BB50-0x0000000181D7BC10
	// [XID] // 0x000000018967EC20-0x000000018967EC40
	public int GetTXBandWidth() => default; // 0x0000000181D7BF20-0x0000000181D7BFE0
	// [XID] // 0x0000000189686510-0x0000000189686530
	public int GetRXBandWidth() => default; // 0x0000000181D7B390-0x0000000181D7B450
	// [XID] // 0x000000018968E370-0x000000018968E390
	public void Dispose() {} // 0x0000000181D7BCE0-0x0000000181D7BD90
}

