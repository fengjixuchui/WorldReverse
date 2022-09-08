/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ZXing.Common;
using ZXing.Rendering;

// Image 43: zxing.unity.dll - Assembly: zxing.unity, Version=0.15.0.0, Culture=neutral, PublicKeyToken=null - Types 4567-4702

namespace ZXing
{
	public class BarcodeWriterGeneric<TOutput> : IBarcodeWriterGeneric<TOutput> // TypeDefIndex: 4578
	{
		// Fields
		private EncodingOptions options;
	
		// Properties
		public BarcodeFormat Format { get; set; }
		public EncodingOptions Options { get => default; set {} }
		public Writer Encoder { get; }
		public IBarcodeRenderer<TOutput> Renderer { get; set; }
	
		// Constructors
		public BarcodeWriterGeneric() {}
	
		// Methods
		public BitMatrix Encode(string contents) => default;
		public TOutput Write(string contents) => default;
	}
}
