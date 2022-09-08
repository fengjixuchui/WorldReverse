/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class Packet : IDisposable // TypeDefIndex: 21703
{
	// Fields
	public static readonly bool deserializeBodyOnWorkThread; // 0x00
	private PacketHead Head; // 0x10
	private MessageBase Body; // 0x18
	private bool _selfAllocBody; // 0x20
	private MemoryStream ReceiveBody; // 0x28
	private AfterDeserializeHandler deserializedCallback; // 0x30
	private uint _packetSize; // 0x38
	public static byte[] dispatchKey; // 0x08
	public static byte[] encryptKey; // 0x10
	private static bool isFirsetProtocal; // 0x18

	// Properties
	public ushort CmdId { /* [XID] */ /* 0x0000000189AD7360-0x0000000189AD73A0 */ get; /* [XID] */ /* 0x0000000189AE1CD0-0x0000000189AE1D10 */ set; } // 0x000000018133B950-0x000000018133B9B0 0x000000018133C980-0x000000018133C9E0
	public uint PacketLen { /* [XID] */ /* 0x0000000189AEC560-0x0000000189AEC580 */ get => default; } // 0x000000018133C8E0-0x000000018133C980 
	public uint UserId { /* [XID] */ /* 0x0000000189AF4030-0x0000000189AF4050 */ get => default; /* [XID] */ /* 0x0000000189AFB7A0-0x0000000189AFB7C0 */ set {} } // 0x000000018133C9E0-0x000000018133CA90 0x000000018133AEF0-0x000000018133AFB0
	public uint PacketId { /* [XID] */ /* 0x0000000189B02E90-0x0000000189B02EB0 */ get => default; /* [XID] */ /* 0x0000000189B0A580-0x0000000189B0A5A0 */ set {} } // 0x000000018133B540-0x000000018133B5F0 0x000000018133E130-0x000000018133E1F0
	public uint RpcId { /* [XID] */ /* 0x0000000189B11D20-0x0000000189B11D40 */ get => default; /* [XID] */ /* 0x0000000189B18F50-0x0000000189B18F70 */ set {} } // 0x000000018133B690-0x000000018133B740 0x000000018133C820-0x000000018133C8E0
	public bool IsReliable { /* [XID] */ /* 0x0000000189B20650-0x0000000189B20670 */ get => default; /* [XID] */ /* 0x0000000189B27D50-0x0000000189B27D70 */ set {} } // 0x000000018133B740-0x000000018133B800 0x000000018133C3D0-0x000000018133C4D0
	public uint EnetChannelId { /* [XID] */ /* 0x0000000189B2F070-0x0000000189B2F090 */ get => default; /* [XID] */ /* 0x0000000189B36990-0x0000000189B369B0 */ set {} } // 0x000000018133AFB0-0x000000018133B060 0x000000018133D3C0-0x000000018133D480
	public uint ClientSequenceId { /* [XID] */ /* 0x0000000189B3E150-0x0000000189B3E170 */ get => default; /* [XID] */ /* 0x0000000189B45EA0-0x0000000189B45EC0 */ set {} } // 0x000000018133AD70-0x000000018133AE20 0x000000018133B480-0x000000018133B540
	public ulong RecvTimeMs { /* [XID] */ /* 0x0000000189BD1110-0x0000000189BD1130 */ get => default; /* [XID] */ /* 0x0000000189A28180-0x0000000189A281A0 */ set {} } // 0x000000018133B8A0-0x000000018133B950 0x000000018133C760-0x000000018133C820
	public uint RecvRtt { /* [XID] */ /* 0x0000000189B5C590-0x0000000189B5C5B0 */ get => default; /* [XID] */ /* 0x0000000189B63C30-0x0000000189B63C50 */ set {} } // 0x000000018133B060-0x000000018133B110 0x000000018133D300-0x000000018133D3C0
	public ulong SentTimeMs { /* [XID] */ /* 0x0000000189B6B3C0-0x0000000189B6B3E0 */ get => default; /* [XID] */ /* 0x0000000189B729D0-0x0000000189B729F0 */ set {} } // 0x000000018133B1C0-0x000000018133B270 0x000000018133CA90-0x000000018133CB50
	public MessageBase Data { /* [XID] */ /* 0x0000000189B79F50-0x0000000189B79F70 */ get => default; /* [XID] */ /* 0x0000000189B816B0-0x0000000189B816D0 */ set {} } // 0x000000018133B5F0-0x000000018133B690 0x000000018133D1D0-0x000000018133D300

	// Constructors
	public Packet() {} // 0x000000018133E290-0x000000018133E300
	static Packet() {} // 0x000000018133E1F0-0x000000018133E290

	// Methods
	// [XID] // 0x0000000189AB8980-0x0000000189AB89A0
	private void InitPacket() {} // 0x000000018133CB50-0x000000018133CDA0
	// [XID] // 0x0000000189AC0550-0x0000000189AC0570
	public static Packet CreatePacket() => default; // 0x000000018133C4D0-0x000000018133C5B0
	// [XID] // 0x0000000189AC7F30-0x0000000189AC7F50
	public void Dispose() {} // 0x000000018133B270-0x000000018133B480
	// [XID] // 0x0000000189ACF5B0-0x0000000189ACF5D0
	public void print() {} // 0x000000018133B800-0x000000018133B8A0
	// [XID] // 0x0000000189B88D30-0x0000000189B88D50
	public object getData(System.Type t) => default; // 0x000000018133B110-0x000000018133B1C0
	public T getData<T>(UseMessageType useMessageType = UseMessageType.UseMessageCache /* Metadata: 0x00AFFC96 */)
		where T : MessageBase, IDeepCloneable<T>, new() => default;
	// [XID] // 0x0000000189B902A0-0x0000000189B902C0
	public static void SetDispatchData(byte[] data) {} // 0x000000018133C2B0-0x000000018133C3D0
	// [XID] // 0x0000000189B976F0-0x0000000189B97710
	public static void ClearDispatchKey() {} // 0x000000018133AE20-0x000000018133AEF0
	// [XID] // 0x0000000189B9EBB0-0x0000000189B9EBD0
	public static void SetEncryptKey(ulong seed) {} // 0x000000018133CDA0-0x000000018133D1D0
	// [XID] // 0x00000001897D76B0-0x00000001897D76D0
	public static void ClearEncrypKey() {} // 0x000000018133D480-0x000000018133D540
	// [XID] // 0x0000000189BAD800-0x0000000189BAD820
	public static void XorEncrypt(ref byte[] buf, int length) {} // 0x000000018133C5B0-0x000000018133C760
	// [XID] // 0x0000000189BB4F20-0x0000000189BB4F40
	public bool serialize(ref MemoryStream ms) => default; // 0x000000018133B9B0-0x000000018133C2B0
	// [XID] // 0x0000000189BBC540-0x0000000189BBC560
	public PacketStatus deserialize(ref byte[] buf, int bufLen, AfterDeserializeHandler callback) => default; // 0x000000018133D540-0x000000018133E130
}

