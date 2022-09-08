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
	public class ClientSslConfiguration // TypeDefIndex: 10245
	{
		// Fields
		private bool _checkCertRevocation; // 0x10
		private LocalCertificateSelectionCallback _clientCertSelectionCallback; // 0x18
		private X509CertificateCollection _clientCerts; // 0x20
		private SslProtocols _enabledSslProtocols; // 0x28
		private RemoteCertificateValidationCallback _serverCertValidationCallback; // 0x30
		private string _targetHost; // 0x38
	
		// Properties
		public bool CheckCertificateRevocation { /* [XID] */ /* 0x0000000189816490-0x00000001898164B0 */ get => default; /* [XID] */ /* 0x00000001898697D0-0x00000001898697F0 */ set {} } // 0x00000001866FCB00-0x00000001866FCBA0 0x00000001866FCFC0-0x00000001866FD070
		public X509CertificateCollection ClientCertificates { /* [XID] */ /* 0x0000000189825460-0x0000000189825480 */ get => default; /* [XID] */ /* 0x0000000189825220-0x0000000189825240 */ set {} } // 0x00000001866FCCC0-0x00000001866FCD60 0x00000001866FD120-0x00000001866FD1D0
		public LocalCertificateSelectionCallback ClientCertificateSelectionCallback { /* [XID] */ /* 0x000000018985AE80-0x000000018985AEA0 */ get => default; /* [XID] */ /* 0x000000018983B830-0x000000018983B850 */ set {} } // 0x00000001866FCBA0-0x00000001866FCCC0 0x00000001866FD070-0x00000001866FD120
		public SslProtocols EnabledSslProtocols { /* [XID] */ /* 0x0000000189834340-0x0000000189834360 */ get => default; /* [XID] */ /* 0x000000018983B710-0x000000018983B730 */ set {} } // 0x00000001866FCD60-0x00000001866FCE00 0x00000001866FD1D0-0x00000001866FD280
		public RemoteCertificateValidationCallback ServerCertificateValidationCallback { /* [XID] */ /* 0x00000001898430D0-0x00000001898430F0 */ get => default; /* [XID] */ /* 0x000000018984A330-0x000000018984A350 */ set {} } // 0x00000001866FCE00-0x00000001866FCF20 0x00000001866FD280-0x00000001866FD330
		public string TargetHost { /* [XID] */ /* 0x00000001898603D0-0x00000001898603F0 */ get => default; /* [XID] */ /* 0x00000001898679F0-0x0000000189867A10 */ set {} } // 0x00000001866FCF20-0x00000001866FCFC0 0x00000001866FD330-0x00000001866FD3E0
	
		// Constructors
		public ClientSslConfiguration() {} // 0x00000001866FC8D0-0x00000001866FC940
		public ClientSslConfiguration(string targetHost) {} // 0x00000001866FC770-0x00000001866FC7F0
		public ClientSslConfiguration(ClientSslConfiguration configuration) {} // 0x00000001866FC7F0-0x00000001866FC8D0
	
		// Methods
		// [XID] // 0x00000001898B9A70-0x00000001898B9A90
		private static X509Certificate defaultSelectClientCertificate(object sender, string targetHost, X509CertificateCollection clientCertificates, X509Certificate serverCertificate, string[] acceptableIssuers) => default; // 0x00000001866FC940-0x00000001866FCA30
		// [XID] // 0x00000001898765D0-0x00000001898765F0
		private static bool defaultValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => default; // 0x00000001866FCA30-0x00000001866FCB00
	}
}
