/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MessageParser<T> : MessageParser // TypeDefIndex: 26347
	where T : MessageBase, IMessage<T>
{
	// Fields
	private readonly Func<T> factory;

	// Constructors
	public MessageParser() {} // Dummy constructor
	public MessageParser(Func<T> factory) {}

	// Methods
	internal new T CreateTemplate() => default;
	public new T ParseFrom(byte[] data) => default;
	public new T ParseFrom(ByteString data) => default;
	public new T ParseFrom(Stream input) => default;
	public new T ParseDelimitedFrom(Stream input) => default;
	public new T ParseFrom(CodedInputStream input) => default;
	public new T ParseJson(string json) => default;
}

