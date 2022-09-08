/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal class HttpsClientStream : SslClientStream // TypeDefIndex: 1121
	{
		// Fields
		private HttpWebRequest _request; // 0x88
		private int _status; // 0x90
	
		// Properties
		public bool TrustFailure { get => default; } // 0x0000000186E0FDC0-0x0000000186E0FE30 
	
		// Constructors
		public HttpsClientStream() {} // Dummy constructor
		public HttpsClientStream(Stream stream, X509CertificateCollection clientCertificates, HttpWebRequest request, byte[] buffer) {} // 0x0000000186E0FAB0-0x0000000186E0FDC0
	
		// Methods
		internal override bool RaiseServerCertificateValidation(X509Certificate certificate, int[] certificateErrors) => default; // 0x0000000186E0F6A0-0x0000000186E0F970
	}
}
