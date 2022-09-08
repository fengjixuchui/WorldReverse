/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IMiNetClient : IDisposable // TypeDefIndex: 21196
{
	// Methods
	bool Connect(string host, ushort port, ref IPAddress ip);
	void Disconnect(uint disconnectReason);
	bool SendPacket(SendPacketData sendData);
	void Tick();
	StoragePool GetStoragePool();
	int GetState();
	int GetRTT();
	int GetPacketLoss();
	float GetAvgAppRTT();
	ulong GetMaxAppRTT();
	int GetTXBandWidth();
	int GetRXBandWidth();
	void AddConnectedHandler(ConnectedHandler onConnected);
	void AddReceiveHandler(ReceiveHandler onPacket);
	void AddDisconnectedHandler(DisconnectedHandler onDisconnected);
	void AddAfterDeserializeInWorkThreadHandler(AfterDeserializeHandler onAfterDeserialized);
	void RemoveConnectedHandler(ConnectedHandler onConnected);
	void RemoveReceiveHandler(ReceiveHandler onPacket);
	void RemoveDisconnectedHandler(DisconnectedHandler onDisconnected);
	void RemoveAfterDeserializeInWorkThreadHanler(AfterDeserializeHandler onAfterDeserialized);
}

