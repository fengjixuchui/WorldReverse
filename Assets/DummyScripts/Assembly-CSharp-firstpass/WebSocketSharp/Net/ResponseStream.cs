/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	internal class ResponseStream : Stream // TypeDefIndex: 10280
	{
		// Fields
		private MemoryStream _bodyBuffer; // 0x10
		private static readonly byte[] _crlf; // 0x00
		private bool _disposed; // 0x18
		private Stream _innerStream; // 0x20
		private static readonly byte[] _lastChunk; // 0x08
		private static readonly int _maxHeadersLength; // 0x10
		private HttpListenerResponse _response; // 0x28
		private bool _sendChunked; // 0x30
		private Action<byte[], int, int> _write; // 0x38
		private Action<byte[], int, int> _writeBody; // 0x40
		private Action<byte[], int, int> _writeChunked; // 0x48
	
		// Properties
		public override bool CanRead { /* [XID] */ /* 0x0000000189A733E0-0x0000000189A73400 */ get => default; } // 0x0000000187186E10-0x0000000187186EB0 
		public override bool CanSeek { /* [XID] */ /* 0x0000000189A7AF10-0x0000000189A7AF30 */ get => default; } // 0x0000000187186EB0-0x0000000187186F50 
		public override bool CanWrite { /* [XID] */ /* 0x0000000189A82560-0x0000000189A82580 */ get => default; } // 0x0000000187186F50-0x0000000187186FF0 
		public override long Length { /* [XID] */ /* 0x0000000189A659E0-0x0000000189A65A00 */ get => default; } // 0x0000000187186FF0-0x00000001871870C0 
		public override long Position { /* [XID] */ /* 0x0000000189A6D0F0-0x0000000189A6D110 */ get => default; /* [XID] */ /* 0x0000000189A99140-0x0000000189A99160 */ set {} } // 0x00000001871870C0-0x0000000187187190 0x0000000187187190-0x0000000187187260
	
		// Constructors
		public ResponseStream() {} // Dummy constructor
		static ResponseStream() {} // 0x00000001871861B0-0x00000001871862E0
		internal ResponseStream(Stream innerStream, HttpListenerResponse response, bool ignoreWriteExceptions) {} // 0x00000001871862E0-0x0000000187186450
	
		// Methods
		// [XID] // 0x0000000189AA0210-0x0000000189AA0230
		private bool flush(bool closing) => default; // 0x0000000187186B90-0x0000000187186CD0
		// [XID] // 0x0000000189AA7A30-0x0000000189AA7A50
		private void flushBody(bool closing) {} // 0x0000000187186450-0x0000000187186750
		// [XID] // 0x0000000189AAF2F0-0x0000000189AAF310
		private bool flushHeaders() => default; // 0x0000000187186750-0x0000000187186B90
		// [XID] // 0x0000000189AB6C10-0x0000000189AB6C30
		private static byte[] getChunkSizeBytes(int size) => default; // 0x0000000187186CD0-0x0000000187186E10
		// [XID] // 0x0000000189ABE600-0x0000000189ABE620
		private void writeChunked(byte[] buffer, int offset, int count) {} // 0x0000000187187360-0x0000000187187510
		// [XID] // 0x0000000189AC6170-0x0000000189AC6190
		private void writeChunkedWithoutThrowingException(byte[] buffer, int offset, int count) {} // 0x0000000187187260-0x0000000187187360
		// [XID] // 0x0000000189AF3760-0x0000000189AF3780
		private void writeWithoutThrowingException(byte[] buffer, int offset, int count) {} // 0x0000000187187510-0x0000000187187620
		// [IDTag] // 0x0000000189AD5520-0x0000000189AD5560
		// [XID] // 0x0000000189AD5520-0x0000000189AD5560
		internal void Close(bool force) {} // 0x0000000187185330-0x00000001871854E0
		// [XID] // 0x000000018973CB10-0x000000018973CB30
		internal void InternalWrite(byte[] buffer, int offset, int count) {} // 0x0000000187185920-0x0000000187185A20
		// [XID] // 0x0000000189AFAFA0-0x0000000189AFAFC0
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) => default; // 0x0000000187185060-0x0000000187185180
		// [XID] // 0x0000000189A5CD30-0x0000000189A5CD50
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) => default; // 0x0000000187185180-0x0000000187185330
		// [IDTag] // 0x0000000189AF6640-0x0000000189AF6680
		// [XID] // 0x0000000189AF6640-0x0000000189AF6680
		public override void Close() {} // 0x00000001871854E0-0x0000000187185580
		// [XID] // 0x0000000189B00CB0-0x0000000189B00CD0
		protected override void Dispose(bool disposing) {} // 0x0000000187185580-0x0000000187185640
		// [XID] // 0x0000000189B08360-0x0000000189B08380
		public override int EndRead(IAsyncResult asyncResult) => default; // 0x0000000187185640-0x0000000187185710
		// [XID] // 0x0000000189B0FC10-0x0000000189B0FC30
		public override void EndWrite(IAsyncResult asyncResult) {} // 0x0000000187185710-0x0000000187185850
		// [XID] // 0x0000000189B16DC0-0x0000000189B16DE0
		public override void Flush() {} // 0x0000000187185850-0x0000000187185920
		// [XID] // 0x0000000189B7F320-0x0000000189B7F340
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x0000000187185A20-0x0000000187185B20
		// [XID] // 0x0000000189B954E0-0x0000000189B95500
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x0000000187185B20-0x0000000187185C10
		// [XID] // 0x0000000189B2D1F0-0x0000000189B2D210
		public override void SetLength(long value) {} // 0x0000000187185C10-0x0000000187185CE0
		// [XID] // 0x0000000189BBA160-0x0000000189BBA180
		public override void Write(byte[] buffer, int offset, int count) {} // 0x0000000187186040-0x00000001871861B0
	}
}
