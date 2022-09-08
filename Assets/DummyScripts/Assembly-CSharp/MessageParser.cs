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

public class MessageParser // TypeDefIndex: 26346
{
	// Fields
	private Func<MessageBase> factory; // 0x10

	// Constructors
	public MessageParser() {} // Dummy constructor
	internal MessageParser(Func<MessageBase> factory) {} // 0x0000000181F8E520-0x0000000181F8E6B0

	// Methods
	// [XID] // 0x0000000189978960-0x0000000189978980
	internal IMessage CreateTemplate() => default; // 0x0000000181F8DEC0-0x0000000181F8DF80
	// [IDTag] // 0x000000018997F9D0-0x000000018997FA10
	// [XID] // 0x000000018997F9D0-0x000000018997FA10
	public IMessage ParseFrom(byte[] data) => default; // 0x0000000181F8E340-0x0000000181F8E430
	// [IDTag] // 0x000000018998A620-0x000000018998A660
	// [XID] // 0x000000018998A620-0x000000018998A660
	public IMessage ParseFrom(ByteString data) => default; // 0x0000000181F8E430-0x0000000181F8E520
	// [IDTag] // 0x00000001899950B0-0x00000001899950F0
	// [XID] // 0x00000001899950B0-0x00000001899950F0
	public IMessage ParseFrom(Stream input) => default; // 0x0000000181F8E170-0x0000000181F8E250
	// [XID] // 0x000000018999F9C0-0x000000018999F9E0
	public IMessage ParseDelimitedFrom(Stream input) => default; // 0x0000000181F8DF80-0x0000000181F8E060
	// [IDTag] // 0x00000001899A7630-0x00000001899A7670
	// [XID] // 0x00000001899A7630-0x00000001899A7670
	public IMessage ParseFrom(CodedInputStream input) => default; // 0x0000000181F8E250-0x0000000181F8E340
	// [XID] // 0x00000001899B1F10-0x00000001899B1F30
	public IMessage ParseJson(string json) => default; // 0x0000000181F8E060-0x0000000181F8E170
}

