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
	internal class ChunkedRequestStream : RequestStream // TypeDefIndex: 10243
	{
		// Fields
		private const int _bufferLength = 8192; // Metadata: 0x00AE72AA
		private HttpListenerContext _context; // 0x38
		private ChunkStream _decoder; // 0x40
		private bool _disposed; // 0x48
		private bool _noMoreData; // 0x49
	
		// Properties
		internal ChunkStream Decoder { /* [XID] */ /* 0x0000000189708100-0x0000000189708120 */ get => default; /* [XID] */ /* 0x000000018970FB90-0x000000018970FBB0 */ set {} } // 0x00000001866FC240-0x00000001866FC2E0 0x00000001866FC6C0-0x00000001866FC770
	
		// Constructors
		public ChunkedRequestStream() {} // Dummy constructor
		internal ChunkedRequestStream(Stream stream, byte[] buffer, int offset, int count, HttpListenerContext context) {} // 0x00000001866FC0F0-0x00000001866FC240
	
		// Methods
		// [XID] // 0x0000000189770910-0x0000000189770930
		private void onRead(IAsyncResult asyncResult) {} // 0x00000001866FC2E0-0x00000001866FC6C0
		// [XID] // 0x00000001897E9570-0x00000001897E9590
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) => default; // 0x00000001866FB650-0x00000001866FBAB0
		// [XID] // 0x000000018977F680-0x000000018977F6A0
		public override void Close() {} // 0x00000001866FBAB0-0x00000001866FBB60
		// [XID] // 0x0000000189787040-0x0000000189787060
		public override int EndRead(IAsyncResult asyncResult) => default; // 0x00000001866FBB60-0x00000001866FBD90
		// [XID] // 0x00000001897D2C40-0x00000001897D2C60
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x00000001866FBD90-0x00000001866FBEB0
	}
}
