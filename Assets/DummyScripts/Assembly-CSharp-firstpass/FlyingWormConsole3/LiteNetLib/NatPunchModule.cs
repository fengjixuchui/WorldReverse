/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib.Utils;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	public sealed class NatPunchModule // TypeDefIndex: 6898
	{
		// Fields
		private readonly NetManager _netBase; // 0x10
		private readonly Queue<RequestEventData> _requestEvents; // 0x18
		private readonly Queue<SuccessEventData> _successEvents; // 0x20
		private const byte HostByte = 1; // Metadata: 0x00ADDFA8
		private const byte ClientByte = 0; // Metadata: 0x00ADDFA9
		public const int MaxTokenLength = 256; // Metadata: 0x00ADDFAA
		private INatPunchListener _natPunchListener; // 0x28
	
		// Nested types
		private struct RequestEventData // TypeDefIndex: 6899
		{
			// Fields
			public NetEndPoint LocalEndPoint; // 0x00
			public NetEndPoint RemoteEndPoint; // 0x08
			public string Token; // 0x10
		}
	
		private struct SuccessEventData // TypeDefIndex: 6900
		{
			// Fields
			public NetEndPoint TargetEndPoint; // 0x00
			public string Token; // 0x08
		}
	
		// Constructors
		public NatPunchModule() {} // Dummy constructor
		internal NatPunchModule(NetManager netBase) {} // 0x00000001863BE5F0-0x00000001863BE6B0
	
		// Methods
		// [XID] // 0x0000000189BC03A0-0x0000000189BC03C0
		public void Init(INatPunchListener listener) {} // 0x00000001863BDBF0-0x00000001863BDCA0
		// [XID] // 0x00000001896CD0A0-0x00000001896CD0C0
		public void NatIntroduce(NetEndPoint hostInternal, NetEndPoint hostExternal, NetEndPoint clientInternal, NetEndPoint clientExternal, string additionalInfo) {} // 0x00000001863BDCA0-0x00000001863BDF00
		// [XID] // 0x00000001896D4510-0x00000001896D4530
		public void PollEvents() {} // 0x00000001863BDF00-0x00000001863BE210
		// [XID] // 0x00000001896DBD40-0x00000001896DBD60
		public void SendNatIntroduceRequest(NetEndPoint masterServerEndPoint, string additionalInfo) {} // 0x00000001863BE370-0x00000001863BE5F0
		// [XID] // 0x00000001896257D0-0x00000001896257F0
		private void HandleNatPunch(NetEndPoint senderEndPoint, NetDataReader dr) {} // 0x00000001863BDA50-0x00000001863BDBF0
		// [XID] // 0x00000001896EA940-0x00000001896EA960
		private void HandleNatIntroduction(NetDataReader dr) {} // 0x00000001863BD820-0x00000001863BDA50
		// [XID] // 0x00000001896F1A10-0x00000001896F1A30
		private void HandleNatIntroductionRequest(NetEndPoint senderEndPoint, NetDataReader dr) {} // 0x00000001863BD670-0x00000001863BD820
		// [XID] // 0x000000018963C280-0x000000018963C2A0
		internal void ProcessMessage(NetEndPoint senderEndPoint, NetPacket packet) {} // 0x00000001863BE210-0x00000001863BE370
	}
}
