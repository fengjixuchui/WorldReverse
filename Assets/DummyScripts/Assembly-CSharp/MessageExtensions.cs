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

public static class MessageExtensions // TypeDefIndex: 26345
{
	// Extension methods
	// [IDTag] // 0x000000018991BBA0-0x000000018991BBF0
	// [XID] // 0x000000018991BBA0-0x000000018991BBF0
	public static void MergeFrom(this IMessage message, byte[] data) {} // 0x0000000183D9F5E0-0x0000000183D9F720
	// [IDTag] // 0x0000000189929280-0x00000001899292D0
	// [XID] // 0x0000000189929280-0x00000001899292D0
	public static void MergeFrom(this IMessage message, ByteString data) {} // 0x0000000183D9F720-0x0000000183D9F840
	// [IDTag] // 0x0000000189936450-0x00000001899364A0
	// [XID] // 0x0000000189936450-0x00000001899364A0
	public static void MergeFrom(this IMessage message, Stream input) {} // 0x0000000183D9F840-0x0000000183D9F980
	// [XID] // 0x0000000189943F30-0x0000000189943F70
	public static void MergeDelimitedFrom(this IMessage message, Stream input) {} // 0x0000000183D9FE80-0x0000000183D9FFB0
	// [XID] // 0x000000018994E4F0-0x000000018994E530
	public static byte[] ToByteArray(this IMessage message) => default; // 0x0000000183D9F980-0x0000000183D9FAF0
	// [XID] // 0x0000000189958C70-0x0000000189958CB0
	public static void WriteTo(this IMessage message, Stream output) {} // 0x0000000183D9FD40-0x0000000183D9FE80
	// [XID] // 0x0000000189963640-0x0000000189963680
	public static void WriteDelimitedTo(this IMessage message, Stream output) {} // 0x0000000183D9FAF0-0x0000000183D9FC50
	// [XID] // 0x000000018996D900-0x000000018996D940
	public static ByteString ToByteString(this IMessage message) => default; // 0x0000000183D9FC50-0x0000000183D9FD40
}

