/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace WebSocketSharp.Net
{
	internal class ChunkStream // TypeDefIndex: 10244
	{
		// Fields
		private int _chunkRead; // 0x10
		private int _chunkSize; // 0x14
		private List<Chunk> _chunks; // 0x18
		private bool _gotIt; // 0x20
		private WebHeaderCollection _headers; // 0x28
		private StringBuilder _saved; // 0x30
		private bool _sawCr; // 0x38
		private InputChunkState _state; // 0x3C
		private int _trailerState; // 0x40
	
		// Properties
		internal WebHeaderCollection Headers { /* [XID] */ /* 0x0000000189795DA0-0x0000000189795DC0 */ get => default; } // 0x00000001866FA4B0-0x00000001866FA550 
		public int ChunkLeft { /* [XID] */ /* 0x000000018979E050-0x000000018979E070 */ get => default; } // 0x00000001866FA400-0x00000001866FA4B0 
		public bool WantMore { /* [XID] */ /* 0x00000001897A55D0-0x00000001897A55F0 */ get => default; } // 0x00000001866FA550-0x00000001866FA600 
	
		// Constructors
		public ChunkStream() {} // Dummy constructor
		public ChunkStream(WebHeaderCollection headers) {} // 0x00000001866FA290-0x00000001866FA350
		public ChunkStream(byte[] buffer, int offset, int count, WebHeaderCollection headers) {} // 0x00000001866FA350-0x00000001866FA400
	
		// Methods
		// [XID] // 0x00000001897B4840-0x00000001897B4860
		private int read(byte[] buffer, int offset, int count) => default; // 0x00000001866FA600-0x00000001866FA7A0
		// [XID] // 0x00000001897B4980-0x00000001897B49A0
		private static string removeChunkExtension(string value) => default; // 0x00000001866FA7A0-0x00000001866FA870
		// [XID] // 0x00000001897BC8B0-0x00000001897BC8D0
		private InputChunkState seekCrLf(byte[] buffer, ref int offset, int length) => default; // 0x00000001866FA870-0x00000001866FA9F0
		// [XID] // 0x000000018964E000-0x000000018964E020
		private InputChunkState setChunkSize(byte[] buffer, ref int offset, int length) => default; // 0x00000001866FA9F0-0x00000001866FAC60
		// [XID] // 0x00000001897CB5E0-0x00000001897CB600
		private InputChunkState setTrailer(byte[] buffer, ref int offset, int length) => default; // 0x00000001866FAC60-0x00000001866FAFA0
		// [XID] // 0x00000001897D2DC0-0x00000001897D2DE0
		private static void throwProtocolViolation(string message) {} // 0x00000001866FAFA0-0x00000001866FB080
		// [XID] // 0x0000000189B86ED0-0x0000000189B86EF0
		private void write(byte[] buffer, ref int offset, int length) {} // 0x00000001866FB200-0x00000001866FB400
		// [XID] // 0x00000001897E1F20-0x00000001897E1F40
		private InputChunkState writeData(byte[] buffer, ref int offset, int length) => default; // 0x00000001866FB080-0x00000001866FB200
		// [XID] // 0x00000001897E96B0-0x00000001897E96D0
		internal void ResetBuffer() {} // 0x00000001866F9FC0-0x00000001866FA080
		// [XID] // 0x00000001897F13A0-0x00000001897F13C0
		internal int WriteAndReadBack(byte[] buffer, int offset, int writeCount, int readCount) => default; // 0x00000001866FA080-0x00000001866FA1A0
		// [XID] // 0x00000001897F8A80-0x00000001897F8AA0
		public int Read(byte[] buffer, int offset, int count) => default; // 0x00000001866F9EC0-0x00000001866F9FC0
		// [XID] // 0x00000001898001A0-0x00000001898001C0
		public void Write(byte[] buffer, int offset, int count) {} // 0x00000001866FA1A0-0x00000001866FA290
	}
}
