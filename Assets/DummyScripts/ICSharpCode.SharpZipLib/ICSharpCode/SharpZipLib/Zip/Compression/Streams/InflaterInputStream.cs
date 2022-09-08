/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using ICSharpCode.SharpZipLib.Zip.Compression;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	public class InflaterInputStream : Stream // TypeDefIndex: 6634
	{
		// Fields
		protected Inflater inf; // 0x10
		protected InflaterInputBuffer inputBuffer; // 0x18
		private Stream baseInputStream; // 0x20
		private bool isClosed; // 0x28
		private bool isStreamOwner; // 0x29
	
		// Properties
		public override bool CanRead { get => default; } // 0x000000018947DD20-0x000000018947DDA0 
		public override bool CanSeek { get => default; } // 0x000000018947DDA0-0x000000018947DDF0 
		public override bool CanWrite { get => default; } // 0x000000018947DDF0-0x000000018947DE40 
		public override long Length { get => default; } // 0x000000018947DE40-0x000000018947DEF0 
		public override long Position { get => default; set {} } // 0x000000018947DEF0-0x000000018947DF70 0x000000018947DF70-0x000000018947DFF0
	
		// Constructors
		public InflaterInputStream() {} // Dummy constructor
		public InflaterInputStream(Stream baseInputStream, Inflater inf) {} // 0x000000018947DC90-0x000000018947DD20
		public InflaterInputStream(Stream baseInputStream, Inflater inflater, int bufferSize) {} // 0x000000018947DB20-0x000000018947DC90
	
		// Methods
		protected void Fill() {} // 0x000000018947D540-0x000000018947D6B0
		public override void Flush() {} // 0x000000018947D6B0-0x000000018947D730
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x000000018947D920-0x000000018947D9A0
		public override void SetLength(long value) {} // 0x000000018947D9A0-0x000000018947DA20
		public override void Write(byte[] buffer, int offset, int count) {} // 0x000000018947DAA0-0x000000018947DB20
		public override void WriteByte(byte value) {} // 0x000000018947DA20-0x000000018947DAA0
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) => default; // 0x000000018947D430-0x000000018947D4B0
		public override void Close() {} // 0x000000018947D4B0-0x000000018947D540
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x000000018947D730-0x000000018947D920
	}
}
