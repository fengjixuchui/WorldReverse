/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

// Image 54: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 6620-6667

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	public class Inflater // TypeDefIndex: 6639
	{
		// Fields
		private static readonly int[] CPLENS; // 0x00
		private static readonly int[] CPLEXT; // 0x08
		private static readonly int[] CPDIST; // 0x10
		private static readonly int[] CPDEXT; // 0x18
		private int mode; // 0x10
		private int readAdler; // 0x14
		private int neededBits; // 0x18
		private int repLength; // 0x1C
		private int repDist; // 0x20
		private int uncomprLen; // 0x24
		private bool isLastBlock; // 0x28
		private long totalOut; // 0x30
		private long totalIn; // 0x38
		private bool noHeader; // 0x40
		private StreamManipulator input; // 0x48
		private OutputWindow outputWindow; // 0x50
		private InflaterDynHeader dynHeader; // 0x58
		private InflaterHuffmanTree litlenTree; // 0x60
		private InflaterHuffmanTree distTree; // 0x68
		private Adler32 adler; // 0x70
	
		// Properties
		public bool IsNeedingInput { get => default; } // 0x000000018947F5B0-0x000000018947F660 
		public bool IsNeedingDictionary { get => default; } // 0x000000018947F540-0x000000018947F5B0 
		public bool IsFinished { get => default; } // 0x000000018947F480-0x000000018947F540 
	
		// Constructors
		public Inflater() {} // Dummy constructor
		public Inflater(bool noHeader) {} // 0x000000018947F360-0x000000018947F480
		static Inflater() {} // 0x000000018947F1F0-0x000000018947F360
	
		// Methods
		private bool DecodeHeader() => default; // 0x000000018947E410-0x000000018947E5B0
		private bool DecodeDict() => default; // 0x000000018947E350-0x000000018947E410
		private bool DecodeHuffman() => default; // 0x000000018947E5B0-0x000000018947EA10
		private bool DecodeChksum() => default; // 0x000000018947DFF0-0x000000018947E350
		private bool Decode() => default; // 0x000000018947EA10-0x000000018947EEF0
		public void SetInput(byte[] buffer, int index, int count) {} // 0x000000018947F150-0x000000018947F1F0
		public int Inflate(byte[] buffer, int offset, int count) => default; // 0x000000018947EEF0-0x000000018947F150
	}
}
