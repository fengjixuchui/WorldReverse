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
using System.Threading;
using Mono.Security.X509;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	public abstract class SslStreamBase : Stream, IDisposable // TypeDefIndex: 1137
	{
		// Fields
		private const int WaitTimeOut = 300000; // Metadata: 0x00ABB9F7
		private static ManualResetEvent record_processing; // 0x00
		internal Stream innerStream; // 0x10
		internal MemoryStream inputBuffer; // 0x18
		internal Context context; // 0x20
		internal RecordProtocol protocol; // 0x28
		internal bool ownsStream; // 0x30
		private bool disposed; // 0x31
		private bool checkCertRevocationStatus; // 0x32
		private object negotiate; // 0x38
		private object read; // 0x40
		private object write; // 0x48
		private ManualResetEvent negotiationComplete; // 0x50
		private byte[] recbuf; // 0x58
		private MemoryStream recordStream; // 0x60
	
		// Properties
		internal bool MightNeedHandshake { get; } // 0x0000000186E278F0-0x0000000186E27A20 
		internal abstract bool HaveRemoteValidation2Callback { get; }
		public bool CheckCertRevocationStatus { get; set; } // 0x0000000186E271E0-0x0000000186E27240 0x0000000186E27E90-0x0000000186E27EF0
		public CipherAlgorithmType CipherAlgorithm { get; } // 0x0000000186E27240-0x0000000186E27340 
		public int CipherStrength { get; } // 0x0000000186E27340-0x0000000186E27440 
		public HashAlgorithmType HashAlgorithm { get; } // 0x0000000186E27440-0x0000000186E27540 
		public int HashStrength { get; } // 0x0000000186E27540-0x0000000186E27640 
		public int KeyExchangeStrength { get; } // 0x0000000186E27740-0x0000000186E27880 
		public ExchangeAlgorithmType KeyExchangeAlgorithm { get; } // 0x0000000186E27640-0x0000000186E27740 
		public SecurityProtocolType SecurityProtocol { get; } // 0x0000000186E27A90-0x0000000186E27B20 
		public System.Security.Cryptography.X509Certificates.X509Certificate ServerCertificate { get; } // 0x0000000186E27B20-0x0000000186E27D30 
		internal Mono.Security.X509.X509CertificateCollection ServerCertificates { get; } // 0x0000000186E27D30-0x0000000186E27DF0 
		public override bool CanRead { get; } // 0x0000000186E27090-0x0000000186E27110 
		public override bool CanSeek { get; } // 0x0000000186E27110-0x0000000186E27160 
		public override bool CanWrite { get; } // 0x0000000186E27160-0x0000000186E271E0 
		public override long Length { get; } // 0x0000000186E27880-0x0000000186E278F0 
		public override long Position { get; set; } // 0x0000000186E27A20-0x0000000186E27A90 0x0000000186E27EF0-0x0000000186E27F60
	
		// Nested types
		private class InternalAsyncResult : IAsyncResult // TypeDefIndex: 1138
		{
			// Fields
			private object locker; // 0x10
			private AsyncCallback _userCallback; // 0x18
			private object _userState; // 0x20
			private Exception _asyncException; // 0x28
			private ManualResetEvent handle; // 0x30
			private bool completed; // 0x38
			private int _bytesRead; // 0x3C
			private bool _fromWrite; // 0x40
			private bool _proceedAfterHandshake; // 0x41
			private byte[] _buffer; // 0x48
			private int _offset; // 0x50
			private int _count; // 0x54
	
			// Properties
			public bool ProceedAfterHandshake { get => default; } // 0x0000000186E10670-0x0000000186E106D0 
			public bool FromWrite { get => default; } // 0x0000000186E10510-0x0000000186E10570 
			public byte[] Buffer { get => default; } // 0x0000000186E10370-0x0000000186E103D0 
			public int Offset { get => default; } // 0x0000000186E10610-0x0000000186E10670 
			public int Count { get => default; } // 0x0000000186E104B0-0x0000000186E10510 
			public int BytesRead { get => default; } // 0x0000000186E103D0-0x0000000186E10430 
			public object AsyncState { get => default; } // 0x0000000186E10200-0x0000000186E10260 
			public Exception AsyncException { get => default; } // 0x0000000186E101A0-0x0000000186E10200 
			public bool CompletedWithError { get => default; } // 0x0000000186E10430-0x0000000186E104B0 
			public WaitHandle AsyncWaitHandle { get => default; } // 0x0000000186E10260-0x0000000186E10370 
			public bool IsCompleted { get => default; } // 0x0000000186E10570-0x0000000186E10610 
	
			// Constructors
			public InternalAsyncResult() {} // Dummy constructor
			public InternalAsyncResult(AsyncCallback userCallback, object userState, byte[] buffer, int offset, int count, bool fromWrite, bool proceedAfterHandshake) {} // 0x0000000186E100D0-0x0000000186E101A0
	
			// Methods
			private void SetComplete(Exception ex, int bytesRead) {} // 0x0000000186E0FE30-0x0000000186E0FF60
			public void SetComplete(Exception ex) {} // 0x0000000186E0FFD0-0x0000000186E10050
			public void SetComplete(int bytesRead) {} // 0x0000000186E10050-0x0000000186E100D0
			public void SetComplete() {} // 0x0000000186E0FF60-0x0000000186E0FFD0
		}
	
		// Constructors
		protected SslStreamBase() {} // Dummy constructor
		protected SslStreamBase(Stream stream, bool ownsStream) {} // 0x0000000186E26DA0-0x0000000186E26FF0
		static SslStreamBase() {} // 0x0000000186E26D20-0x0000000186E26DA0
	
		// Methods
		private void AsyncHandshakeCallback(IAsyncResult asyncResult) {} // 0x0000000186E236F0-0x0000000186E23A20
		internal void NegotiateHandshake() {} // 0x0000000186E25B20-0x0000000186E25C10
		internal abstract IAsyncResult OnBeginNegotiateHandshake(AsyncCallback callback, object state);
		internal abstract void OnNegotiateHandshakeCallback(IAsyncResult asyncResult);
		internal abstract System.Security.Cryptography.X509Certificates.X509Certificate OnLocalCertificateSelection(System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection serverRequestedCertificates);
		internal abstract bool OnRemoteCertificateValidation(System.Security.Cryptography.X509Certificates.X509Certificate certificate, int[] errors);
		internal abstract ValidationResult OnRemoteCertificateValidation2(Mono.Security.X509.X509CertificateCollection collection);
		internal abstract AsymmetricAlgorithm OnLocalPrivateKeySelection(System.Security.Cryptography.X509Certificates.X509Certificate certificate, string targetHost);
		internal System.Security.Cryptography.X509Certificates.X509Certificate RaiseLocalCertificateSelection(System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, System.Security.Cryptography.X509Certificates.X509Certificate remoteCertificate, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection requestedCertificates) => default; // 0x0000000186E25C10-0x0000000186E25CC0
		internal bool RaiseRemoteCertificateValidation(System.Security.Cryptography.X509Certificates.X509Certificate certificate, int[] errors) => default; // 0x0000000186E25DD0-0x0000000186E25E60
		internal ValidationResult RaiseRemoteCertificateValidation2(Mono.Security.X509.X509CertificateCollection collection) => default; // 0x0000000186E25D50-0x0000000186E25DD0
		internal AsymmetricAlgorithm RaiseLocalPrivateKeySelection(System.Security.Cryptography.X509Certificates.X509Certificate certificate, string targetHost) => default; // 0x0000000186E25CC0-0x0000000186E25D50
		private bool BeginNegotiateHandshake(InternalAsyncResult asyncResult) => default; // 0x0000000186E23A20-0x0000000186E23C70
		private void EndNegotiateHandshake(InternalAsyncResult asyncResult) {} // 0x0000000186E242B0-0x0000000186E24410
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) => default; // 0x0000000186E23C70-0x0000000186E23EC0
		private void InternalBeginRead(InternalAsyncResult asyncResult) {} // 0x0000000186E24930-0x0000000186E24E70
		private void InternalReadCallback(IAsyncResult result) {} // 0x0000000186E25180-0x0000000186E259C0
		private void InternalBeginWrite(InternalAsyncResult asyncResult) {} // 0x0000000186E24E70-0x0000000186E25180
		private void InternalWriteCallback(IAsyncResult ar) {} // 0x0000000186E259C0-0x0000000186E25B20
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) => default; // 0x0000000186E23EC0-0x0000000186E24110
		public override int EndRead(IAsyncResult asyncResult) => default; // 0x0000000186E24410-0x0000000186E24620
		public override void EndWrite(IAsyncResult asyncResult) {} // 0x0000000186E24620-0x0000000186E247F0
		public override void Close() {} // 0x0000000186E24110-0x0000000186E24170
		public override void Flush() {} // 0x0000000186E248A0-0x0000000186E24930
		public int Read(byte[] buffer) => default; // 0x0000000186E267A0-0x0000000186E26840
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x0000000186E25E60-0x0000000186E267A0
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x0000000186E26840-0x0000000186E268B0
		public override void SetLength(long value) {} // 0x0000000186E268B0-0x0000000186E26920
		public void Write(byte[] buffer) {} // 0x0000000186E26920-0x0000000186E269C0
		public override void Write(byte[] buffer, int offset, int count) {} // 0x0000000186E269C0-0x0000000186E26D20
		~SslStreamBase() {} // 0x0000000186E247F0-0x0000000186E248A0
		protected override void Dispose(bool disposing) {} // 0x0000000186E24170-0x0000000186E242B0
		private void resetBuffer() {} // 0x0000000186E27DF0-0x0000000186E27E90
		internal void checkDisposed() {} // 0x0000000186E26FF0-0x0000000186E27090
	}
}
