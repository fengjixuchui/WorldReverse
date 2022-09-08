/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	public class NtpSyncModule // TypeDefIndex: 6965
	{
		// Fields
		private readonly NetSocket _socket; // 0x28
		private readonly NetEndPoint _ntpEndPoint; // 0x30
		private readonly ManualResetEvent _waiter; // 0x38
	
		// Properties
		public DateTime? SyncedTime { /* [XID] */ /* 0x0000000189AE0180-0x0000000189AE01C0 */ get; /* [XID] */ /* 0x0000000189AEA7F0-0x0000000189AEA830 */ private set; } // 0x00000001863D14D0-0x00000001863D1540 0x00000001863D1540-0x00000001863D15B0
	
		// Constructors
		public NtpSyncModule() {} // Dummy constructor
		public NtpSyncModule(string ntpServer) {} // 0x00000001863D12F0-0x00000001863D14D0
	
		// Methods
		// [XID] // 0x0000000189AF5060-0x0000000189AF5080
		private void OnMessageReceived(byte[] data, int length, int errorCode, NetEndPoint remoteEndPoint) {} // 0x00000001863D0FE0-0x00000001863D12F0
		// [XID] // 0x00000001899B4670-0x00000001899B4690
		public void GetNetworkTime() {} // 0x00000001863D0DD0-0x00000001863D0FE0
	}
}
