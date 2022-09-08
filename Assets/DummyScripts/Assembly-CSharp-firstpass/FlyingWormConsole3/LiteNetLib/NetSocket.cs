/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	internal sealed class NetSocket // TypeDefIndex: 6961
	{
		// Fields
		private Socket _udpSocketv4; // 0x10
		private Socket _udpSocketv6; // 0x18
		private NetEndPoint _localEndPoint; // 0x20
		private Thread _threadv4; // 0x28
		private Thread _threadv6; // 0x30
		private bool _running; // 0x38
		private readonly NetManager.OnMessageReceived _onMessageReceived; // 0x40
		private static readonly IPAddress MulticastAddressV6; // 0x00
		private static readonly bool IPv6Support; // 0x08
		private const int SocketReceivePollTime = 100000; // Metadata: 0x00ADE07D
		private const int SocketSendPollTime = 5000; // Metadata: 0x00ADE081
	
		// Properties
		public NetEndPoint LocalEndPoint { /* [XID] */ /* 0x000000018961E280-0x000000018961E2A0 */ get => default; } // 0x00000001863CF2D0-0x00000001863CF370 
	
		// Constructors
		public NetSocket() {} // Dummy constructor
		static NetSocket() {} // 0x00000001863CF1A0-0x00000001863CF260
		public NetSocket(NetManager.OnMessageReceived onMessageReceived) {} // 0x00000001863CF260-0x00000001863CF2D0
	
		// Methods
		// [XID] // 0x0000000189B35F70-0x0000000189B35F90
		private void ReceiveLogic(object state) {} // 0x00000001863CE6C0-0x00000001863CEB50
		// [XID] // 0x0000000189A57E40-0x0000000189A57E60
		public bool Bind(int port, bool reuseAddress) => default; // 0x00000001863CDCA0-0x00000001863CE480
		// [XID] // 0x0000000189A00600-0x0000000189A00620
		private bool BindSocket(Socket socket, IPEndPoint ep) => default; // 0x00000001863CDAF0-0x00000001863CDCA0
		// [XID] // 0x00000001898F0E00-0x00000001898F0E20
		public bool SendBroadcast(byte[] data, int offset, int size, int port) => default; // 0x00000001863CEB50-0x00000001863CEE30
		// [XID] // 0x0000000189A0F360-0x0000000189A0F380
		public int SendTo(byte[] data, int offset, int size, NetEndPoint remoteEndPoint, ref int errorCode) => default; // 0x00000001863CEE30-0x00000001863CF1A0
		// [XID] // 0x0000000189A169C0-0x0000000189A169E0
		private void CloseSocket(Socket s) {} // 0x00000001863CE480-0x00000001863CE540
		// [XID] // 0x0000000189A1DEE0-0x0000000189A1DF00
		public void Close() {} // 0x00000001863CE540-0x00000001863CE6C0
	}
}
