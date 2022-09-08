/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.X509;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	public class SslServerStream : SslStreamBase // TypeDefIndex: 1136
	{
		// Fields
		private CertificateValidationCallback ClientCertValidation; // 0x68
		private PrivateKeySelectionCallback PrivateKeySelection; // 0x70
		private CertificateValidationCallback2 ClientCertValidation2; // 0x78
	
		// Properties
		public CertificateValidationCallback ClientCertValidationDelegate { set {} } // 0x0000000186E23630-0x0000000186E23690
		public PrivateKeySelectionCallback PrivateKeyCertSelectionDelegate { get => default; set {} } // 0x0000000186E235D0-0x0000000186E23630 0x0000000186E23690-0x0000000186E236F0
		internal override bool HaveRemoteValidation2Callback { get => default; } // 0x0000000186E23570-0x0000000186E235D0 
	
		// Constructors
		public SslServerStream() {} // Dummy constructor
		public SslServerStream(Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool ownsStream) {} // 0x0000000186E232B0-0x0000000186E23350
		public SslServerStream(Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool ownsStream, SecurityProtocolType securityProtocolType) {} // 0x0000000186E23350-0x0000000186E23400
		public SslServerStream(Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool requestClientCertificate, bool ownsStream, SecurityProtocolType securityProtocolType) {} // 0x0000000186E23400-0x0000000186E23570
	
		// Methods
		~SslServerStream() {} // 0x0000000186E227B0-0x0000000186E22860
		protected override void Dispose(bool disposing) {} // 0x0000000186E22730-0x0000000186E227B0
		internal override IAsyncResult OnBeginNegotiateHandshake(AsyncCallback callback, object state) => default; // 0x0000000186E22860-0x0000000186E229A0
		internal override void OnNegotiateHandshakeCallback(IAsyncResult asyncResult) {} // 0x0000000186E22AA0-0x0000000186E23070
		internal override System.Security.Cryptography.X509Certificates.X509Certificate OnLocalCertificateSelection(System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection serverRequestedCertificates) => default; // 0x0000000186E229A0-0x0000000186E22A10
		internal override bool OnRemoteCertificateValidation(System.Security.Cryptography.X509Certificates.X509Certificate certificate, int[] errors) => default; // 0x0000000186E230F0-0x0000000186E23190
		internal override ValidationResult OnRemoteCertificateValidation2(Mono.Security.X509.X509CertificateCollection collection) => default; // 0x0000000186E23070-0x0000000186E230F0
		internal bool RaiseClientCertificateValidation(System.Security.Cryptography.X509Certificates.X509Certificate certificate, int[] certificateErrors) => default; // 0x0000000186E23190-0x0000000186E23220
		internal override AsymmetricAlgorithm OnLocalPrivateKeySelection(System.Security.Cryptography.X509Certificates.X509Certificate certificate, string targetHost) => default; // 0x0000000186E22A10-0x0000000186E22AA0
		internal AsymmetricAlgorithm RaisePrivateKeySelection(System.Security.Cryptography.X509Certificates.X509Certificate certificate, string targetHost) => default; // 0x0000000186E23220-0x0000000186E232B0
	}
}
