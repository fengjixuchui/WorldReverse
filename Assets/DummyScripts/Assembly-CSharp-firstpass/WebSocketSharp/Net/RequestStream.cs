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
	internal class RequestStream : Stream // TypeDefIndex: 10279
	{
		// Fields
		private long _bodyLeft; // 0x10
		private byte[] _buffer; // 0x18
		private int _count; // 0x20
		private bool _disposed; // 0x24
		private int _offset; // 0x28
		private Stream _stream; // 0x30
	
		// Properties
		public override bool CanRead { /* [XID] */ /* 0x00000001899F4BC0-0x00000001899F4BE0 */ get => default; } // 0x0000000187184C10-0x0000000187184CB0 
		public override bool CanSeek { /* [XID] */ /* 0x00000001899FC1E0-0x00000001899FC200 */ get => default; } // 0x0000000187184CB0-0x0000000187184D50 
		public override bool CanWrite { /* [XID] */ /* 0x000000018995C9A0-0x000000018995C9C0 */ get => default; } // 0x0000000187184D50-0x0000000187184DF0 
		public override long Length { /* [XID] */ /* 0x0000000189A0AC10-0x0000000189A0AC30 */ get => default; } // 0x0000000187184DF0-0x0000000187184EC0 
		public override long Position { /* [XID] */ /* 0x0000000189A12480-0x0000000189A124A0 */ get => default; /* [XID] */ /* 0x0000000189A19870-0x0000000189A19890 */ set {} } // 0x0000000187184EC0-0x0000000187184F90 0x0000000187184F90-0x0000000187185060
	
		// Constructors
		public RequestStream() {} // Dummy constructor
		internal RequestStream(Stream stream, byte[] buffer, int offset, int count) {} // 0x0000000187184880-0x0000000187184920
		internal RequestStream(Stream stream, byte[] buffer, int offset, int count, long contentLength) {} // 0x0000000187184920-0x00000001871849D0
	
		// Methods
		// [XID] // 0x0000000189A20EB0-0x0000000189A20ED0
		private int fillFromBuffer(byte[] buffer, int offset, int count) => default; // 0x00000001871849D0-0x0000000187184C10
		// [XID] // 0x0000000189A28200-0x0000000189A28220
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) => default; // 0x0000000187183990-0x0000000187183BE0
		// [XID] // 0x0000000189A2FA30-0x0000000189A2FA50
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) => default; // 0x0000000187183BE0-0x0000000187183D00
		// [XID] // 0x0000000189A37400-0x0000000189A37420
		public override void Close() {} // 0x0000000187183D00-0x0000000187183DA0
		// [XID] // 0x0000000189A3EAF0-0x0000000189A3EB10
		public override int EndRead(IAsyncResult asyncResult) => default; // 0x0000000187183DA0-0x0000000187183FB0
		// [XID] // 0x0000000189A46220-0x0000000189A46240
		public override void EndWrite(IAsyncResult asyncResult) {} // 0x0000000187183FB0-0x0000000187184080
		// [XID] // 0x0000000189A4D910-0x0000000189A4D930
		public override void Flush() {} // 0x0000000187184080-0x0000000187184120
		// [XID] // 0x0000000189A55130-0x0000000189A55150
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x0000000187184120-0x00000001871842E0
		// [XID] // 0x0000000189A003B0-0x0000000189A003D0
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x00000001871842E0-0x00000001871843D0
		// [XID] // 0x0000000189A64370-0x0000000189A64390
		public override void SetLength(long value) {} // 0x00000001871843D0-0x00000001871844A0
		// [XID] // 0x0000000189A6BC60-0x0000000189A6BC80
		public override void Write(byte[] buffer, int offset, int count) {} // 0x0000000187184780-0x0000000187184880
	}
}
