/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 46: MiHoYo.SDK.Protobuf.dll - Assembly: MiHoYo.SDK.Protobuf, Version=3.0.0.0, Culture=neutral, PublicKeyToken=a7d26565bac4d604 - Types 5068-5227

namespace MiHoYo.SDK.Protobuf
{
	public sealed class MessageParser<T> : MessageParser // TypeDefIndex: 5091
		where T : IMessage<T>
	{
		// Fields
		private readonly Func<T> factory;
	
		// Constructors
		public MessageParser() {} // Dummy constructor
		public MessageParser(Func<T> factory) {}
	
		// Methods
		internal T CreateTemplate() => default;
		public T ParseFrom(byte[] data) => default;
	}
}
