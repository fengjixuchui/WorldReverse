/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InvalidProtocolBufferException : IOException // TypeDefIndex: 26330
{
	// Constructors
	public InvalidProtocolBufferException() {} // Dummy constructor
	internal InvalidProtocolBufferException(string message) {} // 0x0000000185469BC0-0x0000000185469C40
	internal InvalidProtocolBufferException(string message, Exception innerException) {} // 0x0000000185469C40-0x0000000185469CD0

	// Methods
	// [XID] // 0x0000000189A723C0-0x0000000189A723E0
	internal static InvalidProtocolBufferException MoreDataAvailable() => default; // 0x00000001854697F0-0x00000001854698B0
	// [XID] // 0x0000000189A7A040-0x0000000189A7A060
	internal static InvalidProtocolBufferException TruncatedMessage() => default; // 0x00000001854694F0-0x00000001854695B0
	// [XID] // 0x0000000189A814E0-0x0000000189A81500
	internal static InvalidProtocolBufferException NegativeSize() => default; // 0x0000000185469730-0x00000001854697F0
	// [XID] // 0x0000000189A88F00-0x0000000189A88F20
	internal static InvalidProtocolBufferException MalformedVarint() => default; // 0x0000000185469970-0x0000000185469A30
	// [XID] // 0x0000000189A906F0-0x0000000189A90710
	internal static InvalidProtocolBufferException InvalidTag() => default; // 0x00000001854695B0-0x0000000185469670
	// [XID] // 0x0000000189A97EC0-0x0000000189A97EE0
	internal static InvalidProtocolBufferException InvalidBase64(Exception innerException) => default; // 0x0000000185469AF0-0x0000000185469BC0
	// [XID] // 0x0000000189A9F300-0x0000000189A9F320
	internal static InvalidProtocolBufferException InvalidEndTag() => default; // 0x0000000185469A30-0x0000000185469AF0
	// [XID] // 0x0000000189AA6B10-0x0000000189AA6B30
	internal static InvalidProtocolBufferException RecursionLimitExceeded() => default; // 0x0000000185469430-0x00000001854694F0
	// [XID] // 0x0000000189AAE2C0-0x0000000189AAE2E0
	internal static InvalidProtocolBufferException JsonRecursionLimitExceeded() => default; // 0x00000001854698B0-0x0000000185469970
	// [XID] // 0x0000000189AB5B10-0x0000000189AB5B30
	internal static InvalidProtocolBufferException SizeLimitExceeded() => default; // 0x0000000185469370-0x0000000185469430
	// [XID] // 0x0000000189ABD550-0x0000000189ABD570
	internal static InvalidProtocolBufferException InvalidMessageStreamTag() => default; // 0x0000000185469670-0x0000000185469730
}

