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
using ICSharpCode.SharpZipLib.Zip.Compression;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	public class InflaterInputBuffer // TypeDefIndex: 6635
	{
		// Fields
		private int rawLength; // 0x10
		private byte[] rawData; // 0x18
		private int clearTextLength; // 0x20
		private byte[] clearText; // 0x28
		private int available; // 0x30
		private ICryptoTransform cryptoTransform; // 0x38
		private Stream inputStream; // 0x40
	
		// Properties
		public int RawLength { get => default; } // 0x000000018947D3D0-0x000000018947D430 
		public int Available { get => default; } // 0x000000018947D370-0x000000018947D3D0 
	
		// Constructors
		public InflaterInputBuffer() {} // Dummy constructor
		public InflaterInputBuffer(Stream stream, int bufferSize) {} // 0x000000018947D2C0-0x000000018947D370
	
		// Methods
		public void SetInflaterInput(Inflater inflater) {} // 0x000000018947D220-0x000000018947D2C0
		public void Fill() {} // 0x000000018947D110-0x000000018947D220
	}
}
