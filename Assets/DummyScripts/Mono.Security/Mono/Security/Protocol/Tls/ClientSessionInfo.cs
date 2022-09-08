/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal class ClientSessionInfo : IDisposable // TypeDefIndex: 1114
	{
		// Fields
		private static readonly int ValidityInterval; // 0x00
		private bool disposed; // 0x10
		private DateTime validuntil; // 0x18
		private string host; // 0x28
		private byte[] sid; // 0x30
		private byte[] masterSecret; // 0x38
	
		// Properties
		public string HostName { get => default; } // 0x00000001873B35E0-0x00000001873B3640 
		public byte[] Id { get => default; } // 0x00000001873B3640-0x00000001873B36A0 
		public bool Valid { get => default; } // 0x00000001873B36A0-0x00000001873B3770 
	
		// Constructors
		public ClientSessionInfo() {} // Dummy constructor
		public ClientSessionInfo(string hostname, byte[] id) {} // 0x00000001873B3550-0x00000001873B35E0
		static ClientSessionInfo() {} // 0x00000001873B34B0-0x00000001873B3550
	
		// Methods
		~ClientSessionInfo() {} // 0x00000001873B30A0-0x00000001873B3150
		public void GetContext(Context context) {} // 0x00000001873B3150-0x00000001873B32B0
		public void SetContext(Context context) {} // 0x00000001873B33A0-0x00000001873B34B0
		public void KeepAlive() {} // 0x00000001873B32B0-0x00000001873B33A0
		public void Dispose() {} // 0x00000001873B2F60-0x00000001873B2FD0
		private void Dispose(bool disposing) {} // 0x00000001873B2FD0-0x00000001873B30A0
		private void CheckDisposed() {} // 0x00000001873B2E80-0x00000001873B2F60
	}
}
