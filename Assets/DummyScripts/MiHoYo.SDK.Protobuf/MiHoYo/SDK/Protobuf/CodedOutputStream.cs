/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf
{
	public sealed class CodedOutputStream : IDisposable // TypeDefIndex: 5072
	{
		// Fields
		internal static readonly Encoding Utf8Encoding; // 0x00
		public static readonly int DefaultBufferSize; // 0x08
		private readonly bool leaveOpen; // 0x10
		private readonly byte[] buffer; // 0x18
		private readonly int limit; // 0x20
		private int position; // 0x24
		private readonly Stream output; // 0x28
	
		// Properties
		public int SpaceLeft { get => default; } // 0x00000001864EB1E0-0x00000001864EB280 
	
		// Nested types
		public sealed class OutOfSpaceException : IOException // TypeDefIndex: 5073
		{
			// Constructors
			internal OutOfSpaceException() {} // 0x0000000186512B20-0x0000000186512B90
		}
	
		// Constructors
		public CodedOutputStream() {} // Dummy constructor
		public CodedOutputStream(byte[] flatArray) {} // 0x00000001864EB150-0x00000001864EB1E0
		private CodedOutputStream(byte[] buffer, int offset, int length) {} // 0x00000001864EB0C0-0x00000001864EB150
		static CodedOutputStream() {} // 0x00000001864EB020-0x00000001864EB0C0
	
		// Methods
		public static int ComputeUInt64Size(ulong value) => default; // 0x00000001864E9A50-0x00000001864E9AE0
		public static int ComputeInt64Size(long value) => default; // 0x00000001864E9630-0x00000001864E96C0
		public static int ComputeInt32Size(int value) => default; // 0x00000001864E9590-0x00000001864E9630
		public static int ComputeStringSize(string value) => default; // 0x00000001864E9990-0x00000001864E9A50
		public static int ComputeMessageSize(IMessage value) => default; // 0x00000001864E9750-0x00000001864E9800
		public static int ComputeBytesSize(ByteString value) => default; // 0x00000001864E93B0-0x00000001864E9500
		public static int ComputeEnumSize(int value) => default; // 0x00000001864E9500-0x00000001864E9590
		public static int ComputeLengthSize(int length) => default; // 0x00000001864E96C0-0x00000001864E9750
		public static int ComputeRawVarint32Size(uint value) => default; // 0x00000001864E9800-0x00000001864E9890
		public static int ComputeRawVarint64Size(ulong value) => default; // 0x00000001864E9890-0x00000001864E9990
		public void WriteDouble(double value) {} // 0x00000001864E9EE0-0x00000001864E9F80
		public void WriteUInt64(ulong value) {} // 0x00000001864EAFA0-0x00000001864EB020
		public void WriteInt64(long value) {} // 0x00000001864EA080-0x00000001864EA100
		public void WriteInt32(int value) {} // 0x00000001864E9FF0-0x00000001864EA080
		public void WriteBool(bool value) {} // 0x00000001864E9D20-0x00000001864E9DB0
		public void WriteString(string value) {} // 0x00000001864EAC90-0x00000001864EAF30
		public void WriteMessage(IMessage value) {} // 0x00000001864EA170-0x00000001864EA270
		public void WriteBytes(ByteString value) {} // 0x00000001864E9DB0-0x00000001864E9EE0
		public void WriteEnum(int value) {} // 0x00000001864E9F80-0x00000001864E9FF0
		public void WriteLength(int length) {} // 0x00000001864EA100-0x00000001864EA170
		public void WriteTag(uint tag) {} // 0x00000001864EAF30-0x00000001864EAFA0
		public void WriteRawTag(byte b1) {} // 0x00000001864EA7D0-0x00000001864EA850
		public void WriteRawTag(byte b1, byte b2) {} // 0x00000001864EA850-0x00000001864EA8E0
		internal void WriteRawVarint32(uint value) {} // 0x00000001864EA8E0-0x00000001864EAAE0
		internal void WriteRawVarint64(ulong value) {} // 0x00000001864EAAE0-0x00000001864EAC90
		internal void WriteRawLittleEndian64(ulong value) {} // 0x00000001864EA4F0-0x00000001864EA7D0
		internal void WriteRawByte(byte value) {} // 0x00000001864EA270-0x00000001864EA320
		internal void WriteRawBytes(byte[] value) {} // 0x00000001864EA320-0x00000001864EA3B0
		internal void WriteRawBytes(byte[] value, int offset, int length) {} // 0x00000001864EA3B0-0x00000001864EA4F0
		private void RefreshBuffer() {} // 0x00000001864E9C20-0x00000001864E9D20
		public void Dispose() {} // 0x00000001864E9AE0-0x00000001864E9BB0
		public void Flush() {} // 0x00000001864E9BB0-0x00000001864E9C20
		public void CheckNoSpaceLeft() {} // 0x00000001864E9310-0x00000001864E93B0
	}
}
