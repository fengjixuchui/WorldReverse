/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Zip
{
	internal class ZipHelperStream : Stream // TypeDefIndex: 6659
	{
		// Fields
		private bool isOwner_; // 0x10
		private Stream stream_; // 0x18
	
		// Properties
		public override bool CanRead { get => default; } // 0x000000018948AB60-0x000000018948ABE0 
		public override bool CanSeek { get => default; } // 0x000000018948ABE0-0x000000018948AC60 
		public override long Length { get => default; } // 0x000000018948ACE0-0x000000018948AD60 
		public override long Position { get => default; set {} } // 0x000000018948AD60-0x000000018948ADE0 0x000000018948ADE0-0x000000018948AE70
		public override bool CanWrite { get => default; } // 0x000000018948AC60-0x000000018948ACE0 
	
		// Constructors
		public ZipHelperStream() {} // Dummy constructor
		public ZipHelperStream(Stream stream) {} // 0x000000018948AAD0-0x000000018948AB60
	
		// Methods
		public override void Flush() {} // 0x000000018948A4F0-0x000000018948A570
		public override long Seek(long offset, SeekOrigin origin) => default; // 0x000000018948A900-0x000000018948A9A0
		public override void SetLength(long value) {} // 0x000000018948A9A0-0x000000018948AA30
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x000000018948A860-0x000000018948A900
		public override void Write(byte[] buffer, int offset, int count) {} // 0x000000018948AA30-0x000000018948AAD0
		public override void Close() {} // 0x000000018948A460-0x000000018948A4F0
		public long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData) => default; // 0x000000018948A570-0x000000018948A6D0
		public int ReadLEShort() => default; // 0x000000018948A750-0x000000018948A860
		public int ReadLEInt() => default; // 0x000000018948A6D0-0x000000018948A750
	}
}
