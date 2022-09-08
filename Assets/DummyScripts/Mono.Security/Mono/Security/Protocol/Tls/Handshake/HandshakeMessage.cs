/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Security.Protocol.Tls;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls.Handshake
{
	internal abstract class HandshakeMessage : TlsStream // TypeDefIndex: 1145
	{
		// Fields
		private Context context; // 0x28
		private HandshakeType handshakeType; // 0x30
		private ContentType contentType; // 0x31
		private byte[] cache; // 0x38
	
		// Properties
		public Context Context { get; } // 0x00000001873B8990-0x00000001873B89F0 
		public HandshakeType HandshakeType { get; } // 0x00000001873B89F0-0x00000001873B8A50 
		public ContentType ContentType { get; } // 0x00000001873B8930-0x00000001873B8990 
	
		// Constructors
		protected HandshakeMessage() {} // Dummy constructor
		public HandshakeMessage(Context context, HandshakeType handshakeType) {} // 0x00000001873B8860-0x00000001873B8930
		public HandshakeMessage(Context context, HandshakeType handshakeType, ContentType contentType) {} // 0x00000001873B8740-0x00000001873B87D0
		public HandshakeMessage(Context context, HandshakeType handshakeType, byte[] data) {} // 0x00000001873B87D0-0x00000001873B8860
	
		// Methods
		protected abstract void ProcessAsTls1();
		protected abstract void ProcessAsSsl3();
		public void Process() {} // 0x00000001873B84F0-0x00000001873B8620
		public virtual void Update() {} // 0x00000001873B8620-0x00000001873B8740
		public virtual byte[] EncodeMessage() => default; // 0x00000001873B8300-0x00000001873B84F0
		public static bool Compare(byte[] buffer1, byte[] buffer2) => default; // 0x00000001873B8230-0x00000001873B8300
	}
}
