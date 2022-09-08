/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Encryption
{
	internal class ZipAESStream : CryptoStream // TypeDefIndex: 6632
	{
		// Fields
		private Stream _stream; // 0x70
		private ZipAESTransform _transform; // 0x78
		private byte[] _slideBuffer; // 0x80
		private int _slideBufStartPos; // 0x88
		private int _slideBufFreePos; // 0x8C
		private int _blockAndAuth; // 0x90
	
		// Constructors
		public ZipAESStream() {} // Dummy constructor
		public ZipAESStream(Stream stream, ZipAESTransform transform, CryptoStreamMode mode) {} // 0x00000001894832F0-0x00000001894833F0
	
		// Methods
		public override int Read(byte[] outBuffer, int offset, int count) => default; // 0x0000000189482F40-0x0000000189483280
		public override void Write(byte[] buffer, int offset, int count) {} // 0x0000000189483280-0x00000001894832F0
	}
}
