/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public struct HttpPacket // TypeDefIndex: 26115
{
	// Fields
	private ClientLogHead _head; // 0x00
	private MessageBase _body; // 0x08

	// Methods
	// [XID] // 0x0000000189B4BCB0-0x0000000189B4BCD0
	public void SetHead(ClientLogHead head) {} // 0x00000001847A0FB0-0x00000001847A1060
	// [XID] // 0x0000000189B53210-0x0000000189B53230
	public ClientLogHead GetHead() => default; // 0x00000001847A1060-0x00000001847A11B0
	public void SetBody<ProtoClassType>(ProtoClassType body)
		where ProtoClassType : MessageBase, IMessage<ProtoClassType> {}
	public ProtoClassType GetBody<ProtoClassType>()
		where ProtoClassType : MessageBase => default;
	// [XID] // 0x0000000189B5AB60-0x0000000189B5AB80
	public string ToContent() => default; // 0x00000001847A11B0-0x00000001847A11E0
}

