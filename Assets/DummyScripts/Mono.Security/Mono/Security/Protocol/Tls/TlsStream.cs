/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal class TlsStream : Stream // TypeDefIndex: 1143
	{
		// Fields
		private bool canRead; // 0x10
		private bool canWrite; // 0x11
		private MemoryStream buffer; // 0x18
		private byte[] temp; // 0x20
	
		// Properties
		public bool EOF { get => default; } // 0x0000000186E2EA10-0x0000000186E2EAB0 
		public override bool CanWrite { get => default; } // 0x0000000186E2E9B0-0x0000000186E2EA10 
		public override bool CanRead { get => default; } // 0x0000000186E2E8D0-0x0000000186E2E930 
		public override bool CanSeek { get => default; } // 0x0000000186E2E930-0x0000000186E2E9B0 
		public override long Position { get => default; set {} } // 0x0000000186E2EB30-0x0000000186E2EBB0 0x0000000186E2EBB0-0x0000000186E2EC40
		public override long Length { get => default; } // 0x0000000186E2EAB0-0x0000000186E2EB30 
	
		// Constructors
		public TlsStream() {} // 0x0000000186E2E820-0x0000000186E2E8D0
		public TlsStream(byte[] data) {} // 0x0000000186E2E750-0x0000000186E2E820
	
		// Methods
		private byte[] ReadSmallValue(int length) => default; // 0x0000000186E2DC20-0x0000000186E2DDA0
		public new byte ReadByte() => default; // 0x0000000186E2D920-0x0000000186E2D9B0
		public short ReadInt16() => default; // 0x0000000186E2DAA0-0x0000000186E2DB50
		public int ReadInt24() => default; // 0x0000000186E2DB50-0x0000000186E2DC20
		public byte[] ReadBytes(int count) => default; // 0x0000000186E2D9B0-0x0000000186E2DAA0
		public void Write(byte value) {} // 0x0000000186E2E660-0x0000000186E2E750
		public void Write(short value) {} // 0x0000000186E2E230-0x0000000186E2E350
		public void WriteInt24(int value) {} // 0x0000000186E2E0E0-0x0000000186E2E230
		public void Write(int value) {} // 0x0000000186E2E350-0x0000000186E2E4D0
		public void Write(byte[] buffer) {} // 0x0000000186E2E5C0-0x0000000186E2E660
		public void Reset() {} // 0x0000000186E2DE90-0x0000000186E2DF30
		public byte[] ToArray() => default; // 0x0000000186E2E060-0x0000000186E2E0E0
		public override void Flush() {} // 0x0000000186E2D8A0-0x0000000186E2D920
		public override void SetLength(long length) {} // 0x0000000186E2DFD0-0x0000000186E2E060
		public override long Seek(long offset, SeekOrigin loc) => default; // 0x0000000186E2DF30-0x0000000186E2DFD0
		public override int Read(byte[] buffer, int offset, int count) => default; // 0x0000000186E2DDA0-0x0000000186E2DE90
		public override void Write(byte[] buffer, int offset, int count) {} // 0x0000000186E2E4D0-0x0000000186E2E5C0
	}
}
