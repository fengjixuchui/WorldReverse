/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Mono.Security.Protocol.Tls.Handshake;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal abstract class RecordProtocol // TypeDefIndex: 1122
	{
		// Fields
		private static ManualResetEvent record_processing; // 0x00
		protected Stream innerStream; // 0x10
		protected Context context; // 0x18
	
		// Properties
		public Context Context { get; } // 0x0000000186E1CAA0-0x0000000186E1CB00 
	
		// Nested types
		private class ReceiveRecordAsyncResult : IAsyncResult // TypeDefIndex: 1123
		{
			// Fields
			private object locker; // 0x10
			private AsyncCallback _userCallback; // 0x18
			private object _userState; // 0x20
			private Exception _asyncException; // 0x28
			private ManualResetEvent handle; // 0x30
			private byte[] _resultingBuffer; // 0x38
			private Stream _record; // 0x40
			private bool completed; // 0x48
			private byte[] _initialBuffer; // 0x50
	
			// Properties
			public Stream Record { get => default; } // 0x0000000186E19630-0x0000000186E19690 
			public byte[] ResultingBuffer { get => default; } // 0x0000000186E19690-0x0000000186E196F0 
			public byte[] InitialBuffer { get => default; } // 0x0000000186E19530-0x0000000186E19590 
			public object AsyncState { get => default; } // 0x0000000186E19340-0x0000000186E193A0 
			public Exception AsyncException { get => default; } // 0x0000000186E192E0-0x0000000186E19340 
			public bool CompletedWithError { get => default; } // 0x0000000186E194B0-0x0000000186E19530 
			public WaitHandle AsyncWaitHandle { get => default; } // 0x0000000186E193A0-0x0000000186E194B0 
			public bool IsCompleted { get => default; } // 0x0000000186E19590-0x0000000186E19630 
	
			// Constructors
			public ReceiveRecordAsyncResult() {} // Dummy constructor
			public ReceiveRecordAsyncResult(AsyncCallback userCallback, object userState, byte[] initialBuffer, Stream record) {} // 0x0000000186E19220-0x0000000186E192E0
	
			// Methods
			private void SetComplete(Exception ex, byte[] resultingBuffer) {} // 0x0000000186E18FF0-0x0000000186E19120
			public void SetComplete(Exception ex) {} // 0x0000000186E19120-0x0000000186E191A0
			public void SetComplete(byte[] resultingBuffer) {} // 0x0000000186E191A0-0x0000000186E19220
		}
	
		private class SendRecordAsyncResult : IAsyncResult // TypeDefIndex: 1124
		{
			// Fields
			private object locker; // 0x10
			private AsyncCallback _userCallback; // 0x18
			private object _userState; // 0x20
			private Exception _asyncException; // 0x28
			private ManualResetEvent handle; // 0x30
			private HandshakeMessage _message; // 0x38
			private bool completed; // 0x40
	
			// Properties
			public HandshakeMessage Message { get => default; } // 0x0000000186E1D480-0x0000000186E1D4E0 
			public object AsyncState { get => default; } // 0x0000000186E1D1F0-0x0000000186E1D250 
			public Exception AsyncException { get => default; } // 0x0000000186E1D190-0x0000000186E1D1F0 
			public bool CompletedWithError { get => default; } // 0x0000000186E1D360-0x0000000186E1D3E0 
			public WaitHandle AsyncWaitHandle { get => default; } // 0x0000000186E1D250-0x0000000186E1D360 
			public bool IsCompleted { get => default; } // 0x0000000186E1D3E0-0x0000000186E1D480 
	
			// Constructors
			public SendRecordAsyncResult() {} // Dummy constructor
			public SendRecordAsyncResult(AsyncCallback userCallback, object userState, HandshakeMessage message) {} // 0x0000000186E1D0E0-0x0000000186E1D190
	
			// Methods
			public void SetComplete(Exception ex) {} // 0x0000000186E1CF50-0x0000000186E1D070
			public void SetComplete() {} // 0x0000000186E1D070-0x0000000186E1D0E0
		}
	
		// Constructors
		protected RecordProtocol() {} // Dummy constructor
		public RecordProtocol(Stream innerStream, Context context) {} // 0x0000000186E1C330-0x0000000186E1C3D0
		static RecordProtocol() {} // 0x0000000186E1C2B0-0x0000000186E1C330
	
		// Methods
		public virtual void SendRecord(HandshakeType type) {} // 0x0000000186E1C180-0x0000000186E1C210
		protected abstract void ProcessHandshakeMessage(TlsStream handMsg);
		protected virtual void ProcessChangeCipherSpec() {} // 0x0000000186E1AF90-0x0000000186E1B0A0
		public virtual HandshakeMessage GetMessage(HandshakeType type) => default; // 0x0000000186E1A410-0x0000000186E1A480
		public IAsyncResult BeginReceiveRecord(Stream record, AsyncCallback callback, object state) => default; // 0x0000000186E196F0-0x0000000186E19960
		private void InternalReceiveRecordCallback(IAsyncResult asyncResult) {} // 0x0000000186E1A480-0x0000000186E1A9B0
		public byte[] EndReceiveRecord(IAsyncResult asyncResult) => default; // 0x0000000186E1A060-0x0000000186E1A260
		public byte[] ReceiveRecord(Stream record) => default; // 0x0000000186E1BD20-0x0000000186E1BDB0
		private byte[] ReadRecordBuffer(int contentType, Stream record) => default; // 0x0000000186E1B8E0-0x0000000186E1BA40
		private byte[] ReadClientHelloV2(Stream record) => default; // 0x0000000186E1B3F0-0x0000000186E1B8E0
		private byte[] ReadStandardRecordBuffer(Stream record) => default; // 0x0000000186E1BA40-0x0000000186E1BD20
		private void ProcessAlert(AlertLevel alertLevel, AlertDescription alertDesc) {} // 0x0000000186E1AEC0-0x0000000186E1AF90
		public void SendAlert(AlertDescription description) {} // 0x0000000186E1BDB0-0x0000000186E1BE50
		public void SendAlert(AlertLevel level, AlertDescription description) {} // 0x0000000186E1BE50-0x0000000186E1BF00
		public void SendAlert(Alert alert) {} // 0x0000000186E1BF00-0x0000000186E1C040
		public void SendChangeCipherSpec() {} // 0x0000000186E1C040-0x0000000186E1C180
		public IAsyncResult BeginSendRecord(HandshakeType handshakeType, AsyncCallback callback, object state) => default; // 0x0000000186E19AA0-0x0000000186E19BF0
		private void InternalSendRecordCallback(IAsyncResult ar) {} // 0x0000000186E1A9B0-0x0000000186E1ABD0
		public IAsyncResult BeginSendRecord(ContentType contentType, byte[] recordData, AsyncCallback callback, object state) => default; // 0x0000000186E19960-0x0000000186E19AA0
		public void EndSendRecord(IAsyncResult asyncResult) {} // 0x0000000186E1A260-0x0000000186E1A410
		public void SendRecord(ContentType contentType, byte[] recordData) {} // 0x0000000186E1C210-0x0000000186E1C2B0
		public byte[] EncodeRecord(ContentType contentType, byte[] recordData) => default; // 0x0000000186E19CD0-0x0000000186E19D80
		public byte[] EncodeRecord(ContentType contentType, byte[] recordData, int offset, int count) => default; // 0x0000000186E19D80-0x0000000186E1A060
		private byte[] encryptRecordFragment(ContentType contentType, byte[] fragment) => default; // 0x0000000186E1C7C0-0x0000000186E1CAA0
		private byte[] decryptRecordFragment(ContentType contentType, byte[] fragment) => default; // 0x0000000186E1C3D0-0x0000000186E1C7C0
		private bool Compare(byte[] array1, byte[] array2) => default; // 0x0000000186E19BF0-0x0000000186E19CD0
		private void ProcessCipherSpecV2Buffer(SecurityProtocolType protocol, byte[] buffer) {} // 0x0000000186E1B0A0-0x0000000186E1B3F0
		private CipherSuite MapV2CipherCode(string prefix, int code) => default; // 0x0000000186E1ABD0-0x0000000186E1AEC0
	}
}
