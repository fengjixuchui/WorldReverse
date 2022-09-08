/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf
{
	public sealed class CodedInputStream : IDisposable // TypeDefIndex: 5071
	{
		// Fields
		private readonly bool leaveOpen; // 0x10
		private readonly byte[] buffer; // 0x18
		private int bufferSize; // 0x20
		private int bufferSizeAfterLimit; // 0x24
		private int bufferPos; // 0x28
		private readonly Stream input; // 0x30
		private uint lastTag; // 0x38
		private uint nextTag; // 0x3C
		private bool hasNextTag; // 0x40
		private int totalBytesRetired; // 0x44
		private int currentLimit; // 0x48
		private int recursionDepth; // 0x4C
		private readonly int recursionLimit; // 0x50
		private readonly int sizeLimit; // 0x54
	
		// Properties
		internal uint LastTag { get => default; } // 0x00000001864E9240-0x00000001864E92A0 
		internal bool ReachedLimit { get => default; } // 0x00000001864E92A0-0x00000001864E9310 
		public bool IsAtEnd { get => default; } // 0x00000001864E91C0-0x00000001864E9240 
	
		// Constructors
		public CodedInputStream() {} // Dummy constructor
		public CodedInputStream(byte[] buffer) {} // 0x00000001864E9110-0x00000001864E91C0
		internal CodedInputStream(Stream input, byte[] buffer, int bufferPos, int bufferSize) {} // 0x00000001864E9060-0x00000001864E9110
	
		// Methods
		public void Dispose() {} // 0x00000001864E6FA0-0x00000001864E7020
		internal void CheckReadEndOfStreamTag() {} // 0x00000001864E6F20-0x00000001864E6FA0
		public uint PeekTag() => default; // 0x00000001864E70B0-0x00000001864E7140
		public uint ReadTag() => default; // 0x00000001864E84A0-0x00000001864E8600
		public void SkipLastField() {} // 0x00000001864E8C80-0x00000001864E8DD0
		private void SkipGroup(uint startGroupTag) {} // 0x00000001864E88C0-0x00000001864E8A90
		public double ReadDouble() => default; // 0x00000001864E7430-0x00000001864E74D0
		public ulong ReadUInt64() => default; // 0x00000001864E8600-0x00000001864E8670
		public long ReadInt64() => default; // 0x00000001864E7690-0x00000001864E7700
		public int ReadInt32() => default; // 0x00000001864E7620-0x00000001864E7690
		public ulong ReadFixed64() => default; // 0x00000001864E75B0-0x00000001864E7620
		public uint ReadFixed32() => default; // 0x00000001864E7540-0x00000001864E75B0
		public bool ReadBool() => default; // 0x00000001864E7270-0x00000001864E72E0
		public string ReadString() => default; // 0x00000001864E82F0-0x00000001864E84A0
		public void ReadMessage(IMessage builder) {} // 0x00000001864E7770-0x00000001864E78D0
		public ByteString ReadBytes() => default; // 0x00000001864E72E0-0x00000001864E7430
		public int ReadEnum() => default; // 0x00000001864E74D0-0x00000001864E7540
		public int ReadLength() => default; // 0x00000001864E7700-0x00000001864E7770
		public bool MaybeConsumeTag(uint tag) => default; // 0x00000001864E7020-0x00000001864E70B0
		private uint SlowReadRawVarint32() => default; // 0x00000001864E8F10-0x00000001864E9060
		internal uint ReadRawVarint32() => default; // 0x00000001864E8000-0x00000001864E8220
		internal ulong ReadRawVarint64() => default; // 0x00000001864E8220-0x00000001864E82F0
		internal uint ReadRawLittleEndian32() => default; // 0x00000001864E7E30-0x00000001864E7EE0
		internal ulong ReadRawLittleEndian64() => default; // 0x00000001864E7EE0-0x00000001864E8000
		internal int PushLimit(int byteLimit) => default; // 0x00000001864E71B0-0x00000001864E7270
		private void RecomputeBufferSizeAfterLimit() {} // 0x00000001864E8670-0x00000001864E86F0
		internal void PopLimit(int oldLimit) {} // 0x00000001864E7140-0x00000001864E71B0
		private bool RefillBuffer(bool mustSucceed) => default; // 0x00000001864E86F0-0x00000001864E88C0
		internal byte ReadRawByte() => default; // 0x00000001864E78D0-0x00000001864E7980
		internal byte[] ReadRawBytes(int size) => default; // 0x00000001864E7980-0x00000001864E7E30
		private void SkipRawBytes(int size) {} // 0x00000001864E8DD0-0x00000001864E8F10
		private void SkipImpl(int amountToSkip) {} // 0x00000001864E8A90-0x00000001864E8C80
	}
}
