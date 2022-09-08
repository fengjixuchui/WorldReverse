/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	public class InflaterHuffmanTree // TypeDefIndex: 6641
	{
		// Fields
		private short[] tree; // 0x10
		public static InflaterHuffmanTree defLitLenTree; // 0x00
		public static InflaterHuffmanTree defDistTree; // 0x08
	
		// Constructors
		public InflaterHuffmanTree() {} // Dummy constructor
		static InflaterHuffmanTree() {} // 0x000000018947CDD0-0x000000018947D090
		public InflaterHuffmanTree(byte[] codeLengths) {} // 0x000000018947D090-0x000000018947D110
	
		// Methods
		private void BuildTree(byte[] codeLengths) {} // 0x000000018947C6A0-0x000000018947CBA0
		public int GetSymbol(StreamManipulator input) => default; // 0x000000018947CBA0-0x000000018947CDD0
	}
}
