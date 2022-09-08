/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using IFix.Core;
using MoleMole.AsyncNetwork;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoTools
{
	public class WatchDog // TypeDefIndex: 10212
	{
		// Fields
		private static ConnectionManager _serverSocket; // 0x00
		private static SyncContext _serverContext; // 0x08
		private const int PORT = 6654; // Metadata: 0x00AE7235
		private static Thread _workThread; // 0x10
	
		// Constructors
		public WatchDog() {} // 0x000000018540B3F0-0x000000018540B450
	
		// Methods
		// [XID] // 0x00000001899B3070-0x00000001899B3090
		public static void Start() {} // 0x000000018540B0D0-0x000000018540B170
		// [XID] // 0x00000001899BA2E0-0x00000001899BA300
		public static void Stop() {} // 0x000000018540B290-0x000000018540B330
		// [XID] // 0x00000001899C1D60-0x00000001899C1D80
		private static void InitSocket() {} // 0x000000018540ABA0-0x000000018540AE00
		// [XID] // 0x000000018977C5C0-0x000000018977C5E0
		private static void CloseSocket() {} // 0x000000018540A9A0-0x000000018540AAD0
		// [XID] // 0x00000001899D0D30-0x00000001899D0D50
		private static void StartThread() {} // 0x000000018540AF30-0x000000018540B0D0
		// [XID] // 0x00000001899D80B0-0x00000001899D80D0
		private static void StopThread() {} // 0x000000018540B170-0x000000018540B290
		// [XID] // 0x00000001899DF740-0x00000001899DF760
		private static void ThreadEntry() {} // 0x000000018540B330-0x000000018540B3F0
		// [XID] // 0x00000001899E72F0-0x00000001899E7310
		private static void OnConnectedCallback(IConnection conn) {} // 0x000000018540AE00-0x000000018540AF30
		// [XID] // 0x00000001899EE750-0x00000001899EE770
		private static void Crash() {} // 0x000000018540AAD0-0x000000018540ABA0
	}
}
