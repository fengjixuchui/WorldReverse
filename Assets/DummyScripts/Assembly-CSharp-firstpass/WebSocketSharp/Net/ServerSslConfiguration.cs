/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	public class ServerSslConfiguration // TypeDefIndex: 10281
	{
		// Fields
		private bool _checkCertRevocation; // 0x10
		private bool _clientCertRequired; // 0x11
		private RemoteCertificateValidationCallback _clientCertValidationCallback; // 0x18
		private SslProtocols _enabledSslProtocols; // 0x20
		private X509Certificate2 _serverCert; // 0x28
	
		// Properties
		public bool CheckCertificateRevocation { /* [XID] */ /* 0x0000000189B43C10-0x0000000189B43C30 */ get => default; /* [XID] */ /* 0x0000000189B4B1C0-0x0000000189B4B1E0 */ set {} } // 0x00000001871878B0-0x0000000187187950 0x0000000187187C50-0x0000000187187D00
		public bool ClientCertificateRequired { /* [XID] */ /* 0x0000000189B529C0-0x0000000189B529E0 */ get => default; /* [XID] */ /* 0x0000000189B5A400-0x0000000189B5A420 */ set {} } // 0x0000000187187950-0x00000001871879F0 0x0000000187187D00-0x0000000187187DB0
		public RemoteCertificateValidationCallback ClientCertificateValidationCallback { /* [XID] */ /* 0x00000001896558D0-0x00000001896558F0 */ get => default; /* [XID] */ /* 0x0000000189664670-0x0000000189664690 */ set {} } // 0x00000001871879F0-0x0000000187187B10 0x0000000187187DB0-0x0000000187187E60
		public SslProtocols EnabledSslProtocols { /* [XID] */ /* 0x0000000189673A80-0x0000000189673AA0 */ get => default; /* [XID] */ /* 0x0000000189B77EA0-0x0000000189B77EC0 */ set {} } // 0x0000000187187B10-0x0000000187187BB0 0x0000000187187E60-0x0000000187187F10
		public X509Certificate2 ServerCertificate { /* [XID] */ /* 0x0000000189B7F440-0x0000000189B7F460 */ get => default; /* [XID] */ /* 0x0000000189B87090-0x0000000189B870B0 */ set {} } // 0x0000000187187BB0-0x0000000187187C50 0x0000000187187F10-0x0000000187187FC0
	
		// Constructors
		public ServerSslConfiguration() {} // 0x0000000187187620-0x0000000187187690
		public ServerSslConfiguration(X509Certificate2 serverCertificate) {} // 0x0000000187187760-0x00000001871877E0
		public ServerSslConfiguration(ServerSslConfiguration configuration) {} // 0x0000000187187690-0x0000000187187760
	
		// Methods
		// [XID] // 0x000000018965D0C0-0x000000018965D0E0
		private static bool defaultValidateClientCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => default; // 0x00000001871877E0-0x00000001871878B0
	}
}
