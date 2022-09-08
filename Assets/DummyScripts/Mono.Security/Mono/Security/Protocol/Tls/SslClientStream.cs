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
	public class SslClientStream : SslStreamBase // TypeDefIndex: 1133
	{
		// Fields
		private CertificateValidationCallback ServerCertValidation; // 0x68
		private CertificateSelectionCallback ClientCertSelection; // 0x70
		private PrivateKeySelectionCallback PrivateKeySelection; // 0x78
		private CertificateValidationCallback2 ServerCertValidation2; // 0x80
	
		// Properties
		internal Stream InputBuffer { get => default; } // 0x0000000186E21680-0x0000000186E216E0 
		public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get => default; } // 0x0000000186E21560-0x0000000186E21620 
		public System.Security.Cryptography.X509Certificates.X509Certificate SelectedClientCertificate { get => default; } // 0x0000000186E21740-0x0000000186E21800 
		public CertificateValidationCallback ServerCertValidationDelegate { get => default; set {} } // 0x0000000186E21800-0x0000000186E21860 0x0000000186E21BB0-0x0000000186E21C10
		public CertificateSelectionCallback ClientCertSelectionDelegate { get => default; set {} } // 0x0000000186E21500-0x0000000186E21560 0x0000000186E21AF0-0x0000000186E21B50
		public PrivateKeySelectionCallback PrivateKeyCertSelectionDelegate { get => default; set {} } // 0x0000000186E216E0-0x0000000186E21740 0x0000000186E21B50-0x0000000186E21BB0
		internal override bool HaveRemoteValidation2Callback { get => default; } // 0x0000000186E21620-0x0000000186E21680 
	
		// Events
		internal event CertificateValidationCallback ServerCertValidation;
		internal event CertificateSelectionCallback ClientCertSelection;
		internal event PrivateKeySelectionCallback PrivateKeySelection;
		public event CertificateValidationCallback2 ServerCertValidation2;
	
		// Constructors
		public SslClientStream() {} // Dummy constructor
		public SslClientStream(Stream stream, string targetHost, bool ownsStream) {} // 0x0000000186E20DC0-0x0000000186E20E60
		public SslClientStream(Stream stream, string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate) {} // 0x0000000186E21130-0x0000000186E21270
		public SslClientStream(Stream stream, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates) {} // 0x0000000186E21090-0x0000000186E21130
		public SslClientStream(Stream stream, string targetHost, bool ownsStream, SecurityProtocolType securityProtocolType) {} // 0x0000000186E20FC0-0x0000000186E21090
		public SslClientStream(Stream stream, string targetHost, bool ownsStream, SecurityProtocolType securityProtocolType, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates) {} // 0x0000000186E20E60-0x0000000186E20FC0
	
		// Methods
		~SslClientStream() {} // 0x0000000186E1FFE0-0x0000000186E20090
		protected override void Dispose(bool disposing) {} // 0x0000000186E1FF50-0x0000000186E1FFE0
		internal override IAsyncResult OnBeginNegotiateHandshake(AsyncCallback callback, object state) => default; // 0x0000000186E20090-0x0000000186E202A0
		private void SafeReceiveRecord(Stream s) {} // 0x0000000186E20D00-0x0000000186E20DC0
		internal override void OnNegotiateHandshakeCallback(IAsyncResult asyncResult) {} // 0x0000000186E203E0-0x0000000186E20990
		internal override System.Security.Cryptography.X509Certificates.X509Certificate OnLocalCertificateSelection(System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection serverRequestedCertificates) => default; // 0x0000000186E202A0-0x0000000186E20350
		internal override ValidationResult OnRemoteCertificateValidation2(Mono.Security.X509.X509CertificateCollection collection) => default; // 0x0000000186E20990-0x0000000186E20A20
		internal override bool OnRemoteCertificateValidation(System.Security.Cryptography.X509Certificates.X509Certificate certificate, int[] errors) => default; // 0x0000000186E20A20-0x0000000186E20AC0
		internal virtual bool RaiseServerCertificateValidation(System.Security.Cryptography.X509Certificates.X509Certificate certificate, int[] certificateErrors) => default; // 0x0000000186E20C70-0x0000000186E20D00
		internal virtual ValidationResult RaiseServerCertificateValidation2(Mono.Security.X509.X509CertificateCollection collection) => default; // 0x0000000186E20BF0-0x0000000186E20C70
		internal System.Security.Cryptography.X509Certificates.X509Certificate RaiseClientCertificateSelection(System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection serverRequestedCertificates) => default; // 0x0000000186E20AC0-0x0000000186E20B60
		internal override AsymmetricAlgorithm OnLocalPrivateKeySelection(System.Security.Cryptography.X509Certificates.X509Certificate certificate, string targetHost) => default; // 0x0000000186E20350-0x0000000186E203E0
		internal AsymmetricAlgorithm RaisePrivateKeySelection(System.Security.Cryptography.X509Certificates.X509Certificate certificate, string targetHost) => default; // 0x0000000186E20B60-0x0000000186E20BF0
	}
}
