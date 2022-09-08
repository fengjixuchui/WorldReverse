/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	public class BsonReader : JsonReader // TypeDefIndex: 5511
	{
		// Fields
		private static readonly byte[] SeqRange1; // 0x00
		private static readonly byte[] SeqRange2; // 0x08
		private static readonly byte[] SeqRange3; // 0x10
		private static readonly byte[] SeqRange4; // 0x18
		private readonly BinaryReader _reader; // 0x78
		private readonly List<ContainerContext> _stack; // 0x80
		private byte[] _byteBuffer; // 0x88
		private char[] _charBuffer; // 0x90
		private BsonType _currentElementType; // 0x98
		private BsonReaderState _bsonReaderState; // 0x9C
		private ContainerContext _currentContext; // 0xA0
		private bool _readRootValueAsArray; // 0xA8
		private bool _jsonNet35BinaryCompatibility; // 0xA9
		private DateTimeKind _dateTimeKindHandling; // 0xAC
	
		// Properties
		public DateTimeKind DateTimeKindHandling { get => default; } // 0x0000000185CBD640-0x0000000185CBD6A0 
	
		// Nested types
		private enum BsonReaderState // TypeDefIndex: 5512
		{
			Normal = 0,
			ReferenceStart = 1,
			ReferenceRef = 2,
			ReferenceId = 3,
			CodeWScopeStart = 4,
			CodeWScopeCode = 5,
			CodeWScopeScope = 6,
			CodeWScopeScopeObject = 7,
			CodeWScopeScopeEnd = 8
		}
	
		private class ContainerContext // TypeDefIndex: 5513
		{
			// Fields
			public readonly BsonType Type; // 0x10
			public int Length; // 0x14
			public int Position; // 0x18
	
			// Constructors
			public ContainerContext() {} // Dummy constructor
			public ContainerContext(BsonType type) {} // 0x0000000185CBFAC0-0x0000000185CBFB30
		}
	
		// Constructors
		public BsonReader() {} // Dummy constructor
		static BsonReader() {} // 0x0000000185CBD430-0x0000000185CBD640
	
		// Methods
		private string ReadElement() => default; // 0x0000000185CBBE30-0x0000000185CBBEB0
		public override bool Read() => default; // 0x0000000185CBD2B0-0x0000000185CBD430
		public override void Close() {} // 0x0000000185CBB030-0x0000000185CBB130
		private bool ReadCodeWScope() => default; // 0x0000000185CBBB40-0x0000000185CBBD50
		private bool ReadReference() => default; // 0x0000000185CBC3D0-0x0000000185CBC6C0
		private bool ReadNormal() => default; // 0x0000000185CBC100-0x0000000185CBC3D0
		private void PopContext() {} // 0x0000000185CBB770-0x0000000185CBB890
		private void PushContext(ContainerContext newContext) {} // 0x0000000185CBB890-0x0000000185CBB920
		private byte ReadByte() => default; // 0x0000000185CBB9D0-0x0000000185CBBAA0
		private void ReadType(BsonType type) {} // 0x0000000185CBCC00-0x0000000185CBD2B0
		private byte[] ReadBinary(out BsonBinaryType binaryType) {
			binaryType = default;
			return default;
		} // 0x0000000185CBB920-0x0000000185CBB9D0
		private string ReadString() => default; // 0x0000000185CBC6C0-0x0000000185CBCB30
		private string ReadLengthString() => default; // 0x0000000185CBC050-0x0000000185CBC100
		private string GetString(int length) => default; // 0x0000000185CBB310-0x0000000185CBB6F0
		private int GetLastFullCharStop(int start) => default; // 0x0000000185CBB240-0x0000000185CBB310
		private int BytesInSequence(byte b) => default; // 0x0000000185CBAD70-0x0000000185CBB030
		private void EnsureBuffers() {} // 0x0000000185CBB130-0x0000000185CBB240
		private double ReadDouble() => default; // 0x0000000185CBBD50-0x0000000185CBBE30
		private int ReadInt32() => default; // 0x0000000185CBBEB0-0x0000000185CBBF80
		private long ReadInt64() => default; // 0x0000000185CBBF80-0x0000000185CBC050
		private BsonType ReadType() => default; // 0x0000000185CBCB30-0x0000000185CBCC00
		private void MovePosition(int count) {} // 0x0000000185CBB6F0-0x0000000185CBB770
		private byte[] ReadBytes(int count) => default; // 0x0000000185CBBAA0-0x0000000185CBBB40
	}
}
