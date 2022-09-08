/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ZXing;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing.Datamatrix.Encoder
{
	internal sealed class EncoderContext // TypeDefIndex: 4646
	{
		// Fields
		private readonly string msg; // 0x10
		private SymbolShapeHint shape; // 0x18
		private Dimension minSize; // 0x20
		private Dimension maxSize; // 0x28
		private readonly StringBuilder codewords; // 0x30
		private int pos; // 0x38
		private int newEncoding; // 0x3C
		private SymbolInfo symbolInfo; // 0x40
		private int skipAtEnd; // 0x48
		private static readonly Encoding encoding; // 0x00
	
		// Properties
		public char CurrentChar { get => default; } // 0x0000000186AF0E30-0x0000000186AF0EB0 
		public int CodewordCount { get => default; } // 0x0000000186AF0D50-0x0000000186AF0DD0 
		public bool HasMoreCharacters { get => default; } // 0x0000000186AF0EB0-0x0000000186AF0F30 
		private int TotalMessageCharCount { get => default; } // 0x0000000186AF1120-0x0000000186AF11A0 
		public int RemainingCharacters { get => default; } // 0x0000000186AF1050-0x0000000186AF10C0 
		public int Pos { get => default; set {} } // 0x0000000186AF0FF0-0x0000000186AF1050 0x0000000186AF13A0-0x0000000186AF1400
		public StringBuilder Codewords { get => default; } // 0x0000000186AF0DD0-0x0000000186AF0E30 
		public SymbolInfo SymbolInfo { get => default; } // 0x0000000186AF10C0-0x0000000186AF1120 
		public int NewEncoding { get => default; } // 0x0000000186AF0F90-0x0000000186AF0FF0 
		public string Message { get => default; } // 0x0000000186AF0F30-0x0000000186AF0F90 
	
		// Constructors
		public EncoderContext() {} // Dummy constructor
		static EncoderContext() {} // 0x0000000186AF0A00-0x0000000186AF0A90
		public EncoderContext(string msg) {} // 0x0000000186AF0A90-0x0000000186AF0D50
	
		// Methods
		public void setSymbolShape(SymbolShapeHint shape) {} // 0x0000000186AF1340-0x0000000186AF13A0
		public void setSizeConstraints(Dimension minSize, Dimension maxSize) {} // 0x0000000186AF1260-0x0000000186AF12E0
		public void setSkipAtEnd(int count) {} // 0x0000000186AF12E0-0x0000000186AF1340
		public void writeCodewords(string codewords) {} // 0x0000000186AF1690-0x0000000186AF1710
		public void writeCodeword(char codeword) {} // 0x0000000186AF1610-0x0000000186AF1690
		public void signalEncoderChange(int encoding) {} // 0x0000000186AF1400-0x0000000186AF1460
		public void resetEncoderSignal() {} // 0x0000000186AF11A0-0x0000000186AF1200
		public void updateSymbolInfo() {} // 0x0000000186AF1460-0x0000000186AF1530
		public void updateSymbolInfo(int len) {} // 0x0000000186AF1530-0x0000000186AF1610
		public void resetSymbolInfo() {} // 0x0000000186AF1200-0x0000000186AF1260
	}
}
