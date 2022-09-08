/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf
{
	// [DefaultMember] // 0x0000000189A8E950-0x0000000189A8E980
	public sealed class ByteString : IEnumerable<byte>, IEquatable<ByteString> // TypeDefIndex: 5070
	{
		// Fields
		private static readonly ByteString empty; // 0x00
		private readonly byte[] bytes; // 0x10
	
		// Properties
		public static ByteString Empty { get => default; } // 0x00000001864E6C20-0x00000001864E6CB0 
		public int Length { get => default; } // 0x00000001864E6CB0-0x00000001864E6D20 
	
		// Constructors
		public ByteString() {} // Dummy constructor
		private ByteString(byte[] bytes) {} // 0x00000001864E6BB0-0x00000001864E6C20
		static ByteString() {} // 0x00000001864E6AC0-0x00000001864E6BB0
	
		// Methods
		internal static ByteString AttachBytes(byte[] bytes) => default; // 0x00000001864E6320-0x00000001864E63E0
		public string ToBase64() => default; // 0x00000001864E6990-0x00000001864E6A20
		public static ByteString CopyFrom(params /* 0x000000018989F6F0-0x000000018989F700 */ byte[] bytes) => default; // 0x00000001864E6500-0x00000001864E6610
		public static ByteString CopyFrom(byte[] bytes, int offset, int count) => default; // 0x00000001864E63E0-0x00000001864E6500
		public IEnumerator<byte> GetEnumerator() => default; // 0x00000001864E67F0-0x00000001864E6870
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x00000001864E6920-0x00000001864E6990
		public CodedInputStream CreateCodedInput() => default; // 0x00000001864E6610-0x00000001864E66A0
		public static bool operator ==(ByteString lhs, ByteString rhs) => default; // 0x00000001864E6D20-0x00000001864E6E80
		public static bool operator !=(ByteString lhs, ByteString rhs) => default; // 0x00000001864E6E80-0x00000001864E6F20
		public override bool Equals(object obj) => default; // 0x00000001864E66A0-0x00000001864E6750
		public override int GetHashCode() => default; // 0x00000001864E6870-0x00000001864E6920
		public bool Equals(ByteString other) => default; // 0x00000001864E6750-0x00000001864E67F0
		internal void WriteRawBytesTo(CodedOutputStream outputStream) {} // 0x00000001864E6A20-0x00000001864E6AC0
	}
}
