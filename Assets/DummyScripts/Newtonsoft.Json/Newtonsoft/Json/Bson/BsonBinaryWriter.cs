/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Newtonsoft.Json.Shims;

// Image 47: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5228-5529

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001897D5F50-0x00000001897D5F60
	internal class BsonBinaryWriter // TypeDefIndex: 5510
	{
		// Fields
		private static readonly Encoding Encoding; // 0x00
		private readonly BinaryWriter _writer; // 0x10
		private byte[] _largeByteBuffer; // 0x18
	
		// Properties
		public DateTimeKind DateTimeKindHandling { get; } // 0x0000000185CB9F00-0x0000000185CB9F60 
	
		// Constructors
		public BsonBinaryWriter() {} // Dummy constructor
		static BsonBinaryWriter() {} // 0x0000000185CB9E80-0x0000000185CB9F00
	
		// Methods
		public void Close() {} // 0x0000000185CB8C40-0x0000000185CB8CC0
		public void WriteToken(BsonToken t) {} // 0x0000000185CB9C30-0x0000000185CB9CB0
		private void WriteTokenInternal(BsonToken t) {} // 0x0000000185CB8DC0-0x0000000185CB9C30
		private void WriteString(string s, int byteCount, int? calculatedlengthPrefix) {} // 0x0000000185CB8CC0-0x0000000185CB8DC0
		public void WriteUtf8Bytes(string s, int byteCount) {} // 0x0000000185CB9CB0-0x0000000185CB9E80
		private int CalculateSize(int stringByteCount) => default; // 0x0000000185CB8500-0x0000000185CB8560
		private int CalculateSizeWithLength(int stringByteCount, bool includeSize) => default; // 0x0000000185CB8490-0x0000000185CB8500
		private int CalculateSize(BsonToken t) => default; // 0x0000000185CB8560-0x0000000185CB8C40
	}
}
