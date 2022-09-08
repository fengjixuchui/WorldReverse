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
	public sealed class InvalidProtocolBufferException : IOException // TypeDefIndex: 5084
	{
		// Constructors
		public InvalidProtocolBufferException() {} // Dummy constructor
		internal InvalidProtocolBufferException(string message) {} // 0x000000018650A330-0x000000018650A3B0
	
		// Methods
		internal static InvalidProtocolBufferException MoreDataAvailable() => default; // 0x0000000186509F20-0x0000000186509FF0
		internal static InvalidProtocolBufferException TruncatedMessage() => default; // 0x000000018650A260-0x000000018650A330
		internal static InvalidProtocolBufferException NegativeSize() => default; // 0x0000000186509FF0-0x000000018650A0C0
		internal static InvalidProtocolBufferException MalformedVarint() => default; // 0x0000000186509E50-0x0000000186509F20
		internal static InvalidProtocolBufferException InvalidTag() => default; // 0x0000000186509D80-0x0000000186509E50
		internal static InvalidProtocolBufferException RecursionLimitExceeded() => default; // 0x000000018650A0C0-0x000000018650A190
		internal static InvalidProtocolBufferException SizeLimitExceeded() => default; // 0x000000018650A190-0x000000018650A260
	}
}
