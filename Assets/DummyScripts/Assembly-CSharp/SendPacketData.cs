/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SendPacketData // TypeDefIndex: 21214
{
	// Fields
	public MessageBase message; // 0x10
	public bool reliable; // 0x18
	public uint enetChannelId; // 0x1C
	public uint clientSequencedId; // 0x20
	public bool needFlush; // 0x24

	// Constructors
	public SendPacketData() {} // 0x0000000180F74070-0x0000000180F740E0

	// Methods
	public static ByteString MessageToByteStrInThread<T>(T message)
		where T : MessageBase => default;
	// [XID] // 0x0000000189761E40-0x0000000189761E60
	public virtual void SerializeProtoBuf() {} // 0x0000000180F73D90-0x0000000180F73E30
	// [XID] // 0x00000001897A8BE0-0x00000001897A8C00
	protected void FlushInternal() {} // 0x0000000180F73F90-0x0000000180F74070
	// [XID] // 0x00000001897B0500-0x00000001897B0520
	public virtual void Flush() {} // 0x0000000180F73E30-0x0000000180F73EE0
	// [XID] // 0x00000001897B8300-0x00000001897B8320
	public void Dispose() {} // 0x0000000180F73EE0-0x0000000180F73F90
	// [XID] // 0x00000001897C0360-0x00000001897C0380
	public ByteString SerializeMessage() => default; // 0x0000000180F73B40-0x0000000180F73D90
}

