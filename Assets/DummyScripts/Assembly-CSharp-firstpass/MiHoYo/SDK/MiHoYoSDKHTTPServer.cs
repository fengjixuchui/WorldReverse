/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	public class MiHoYoSDKHTTPServer // TypeDefIndex: 8662
	{
		// Fields
		public readonly string ResourcePath; // 0x18
		private TcpListener tcpListener; // 0x28
	
		// Properties
		public bool IsRunning { /* [XID] */ /* 0x00000001897158D0-0x0000000189715910 */ get; /* [XID] */ /* 0x00000001897202E0-0x0000000189720320 */ private set; } // 0x0000000184DFD620-0x0000000184DFD680 0x0000000184DFD740-0x0000000184DFD7A0
		public int Port { /* [XID] */ /* 0x000000018972A780-0x000000018972A7C0 */ get; /* [XID] */ /* 0x0000000189734EB0-0x0000000189734EF0 */ private set; } // 0x0000000184DFD680-0x0000000184DFD6E0 0x0000000184DFD7A0-0x0000000184DFD800
		public X509Certificate Certificate { /* [XID] */ /* 0x000000018973FD00-0x000000018973FD40 */ get; private set; } // 0x0000000184DFD5C0-0x0000000184DFD620 0x0000000184DFD6E0-0x0000000184DFD740
	
		// Constructors
		public MiHoYoSDKHTTPServer() {} // Dummy constructor
		public MiHoYoSDKHTTPServer(string resourcePath, int port = 0 /* Metadata: 0x00AE1EB9 */, X509Certificate certificate = null) {} // 0x0000000184DFD400-0x0000000184DFD5C0
	
		// Methods
		~MiHoYoSDKHTTPServer() {} // 0x0000000184DFC3D0-0x0000000184DFC480
		// [XID] // 0x00000001899B5A60-0x00000001899B5A80
		public void Start() {} // 0x0000000184DFCE60-0x0000000184DFD1F0
		// [XID] // 0x00000001897589F0-0x0000000189758A10
		public void StartAsync() {} // 0x0000000184DFCD80-0x0000000184DFCE60
		// [XID] // 0x0000000189A07AE0-0x0000000189A07B00
		public void Stop() {} // 0x0000000184DFD1F0-0x0000000184DFD340
		// [XID] // 0x00000001899E27A0-0x00000001899E27C0
		private void BeginAcceptTcpClient() {} // 0x0000000184DFC220-0x0000000184DFC3D0
		// [XID] // 0x00000001899F8DF0-0x00000001899F8E10
		private void HandleRequest(TcpClient client) {} // 0x0000000184DFC730-0x0000000184DFCD80
		// [XID] // 0x0000000189A003F0-0x0000000189A00410
		private Stream GetStream(TcpClient client) => default; // 0x0000000184DFC480-0x0000000184DFC730
	}
}
