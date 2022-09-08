/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Mono.Security.Protocol.Tls.Handshake;

// Image 1: Mono.Security.dll - Assembly: Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756 - Types 1030-1183

namespace Mono.Security.Protocol.Tls
{
	internal abstract class Context // TypeDefIndex: 1117
	{
		// Fields
		private SecurityProtocolType securityProtocol; // 0x10
		private byte[] sessionId; // 0x18
		private SecurityCompressionType compressionMethod; // 0x20
		private TlsServerSettings serverSettings; // 0x28
		private TlsClientSettings clientSettings; // 0x30
		private SecurityParameters current; // 0x38
		private SecurityParameters negotiating; // 0x40
		private SecurityParameters read; // 0x48
		private SecurityParameters write; // 0x50
		private CipherSuiteCollection supportedCiphers; // 0x58
		private HandshakeType lastHandshakeMsg; // 0x60
		private HandshakeState handshakeState; // 0x64
		private bool abbreviatedHandshake; // 0x68
		private bool receivedConnectionEnd; // 0x69
		private bool sentConnectionEnd; // 0x6A
		private bool protocolNegotiated; // 0x6B
		private ulong writeSequenceNumber; // 0x70
		private ulong readSequenceNumber; // 0x78
		private byte[] clientRandom; // 0x80
		private byte[] serverRandom; // 0x88
		private byte[] randomCS; // 0x90
		private byte[] randomSC; // 0x98
		private byte[] masterSecret; // 0xA0
		private byte[] clientWriteKey; // 0xA8
		private byte[] serverWriteKey; // 0xB0
		private byte[] clientWriteIV; // 0xB8
		private byte[] serverWriteIV; // 0xC0
		private TlsStream handshakeMessages; // 0xC8
		private RandomNumberGenerator random; // 0xD0
		private RecordProtocol recordProtocol; // 0xD8
	
		// Properties
		public bool AbbreviatedHandshake { get; set; } // 0x00000001873B47C0-0x00000001873B4820 0x00000001873B5580-0x00000001873B55E0
		public bool ProtocolNegotiated { get; set; } // 0x00000001873B4DA0-0x00000001873B4E00 0x00000001873B58C0-0x00000001873B5920
		public SecurityProtocolType SecurityProtocol { get; set; } // 0x00000001873B5160-0x00000001873B5220 0x00000001873B5B30-0x00000001873B5B90
		public SecurityProtocolType SecurityProtocolFlags { get; } // 0x00000001873B5100-0x00000001873B5160 
		public short Protocol { get; } // 0x00000001873B4E00-0x00000001873B4EC0 
		public byte[] SessionId { get; set; } // 0x00000001873B5400-0x00000001873B5460 0x00000001873B5D40-0x00000001873B5DA0
		public SecurityCompressionType CompressionMethod { get; set; } // 0x00000001873B49A0-0x00000001873B4A00 0x00000001873B5730-0x00000001873B5790
		public TlsServerSettings ServerSettings { get; } // 0x00000001873B52E0-0x00000001873B5340 
		public TlsClientSettings ClientSettings { get; } // 0x00000001873B4880-0x00000001873B48E0 
		public HandshakeType LastHandshakeMsg { get; set; } // 0x00000001873B4BD0-0x00000001873B4C30 0x00000001873B57F0-0x00000001873B5850
		public HandshakeState HandshakeState { get; set; } // 0x00000001873B4B70-0x00000001873B4BD0 0x00000001873B5790-0x00000001873B57F0
		public bool ReceivedConnectionEnd { get; set; } // 0x00000001873B5040-0x00000001873B50A0 0x00000001873B5A60-0x00000001873B5AC0
		public bool SentConnectionEnd { get; set; } // 0x00000001873B5220-0x00000001873B5280 0x00000001873B5B90-0x00000001873B5BF0
		public CipherSuiteCollection SupportedCiphers { get; set; } // 0x00000001873B5460-0x00000001873B54C0 0x00000001873B5DA0-0x00000001873B5E00
		public TlsStream HandshakeMessages { get; } // 0x00000001873B4B10-0x00000001873B4B70 
		public ulong WriteSequenceNumber { get; set; } // 0x00000001873B54C0-0x00000001873B5520 0x00000001873B5E00-0x00000001873B5E60
		public ulong ReadSequenceNumber { get; set; } // 0x00000001873B4F80-0x00000001873B4FE0 0x00000001873B5A00-0x00000001873B5A60
		public byte[] ClientRandom { get; set; } // 0x00000001873B4820-0x00000001873B4880 0x00000001873B55E0-0x00000001873B5650
		public byte[] ServerRandom { get; set; } // 0x00000001873B5280-0x00000001873B52E0 0x00000001873B5BF0-0x00000001873B5C60
		public byte[] RandomCS { get; set; } // 0x00000001873B4EC0-0x00000001873B4F20 0x00000001873B5920-0x00000001873B5990
		public byte[] RandomSC { get; set; } // 0x00000001873B4F20-0x00000001873B4F80 0x00000001873B5990-0x00000001873B5A00
		public byte[] MasterSecret { get; set; } // 0x00000001873B4C30-0x00000001873B4C90 0x00000001873B5850-0x00000001873B58C0
		public byte[] ClientWriteKey { get; set; } // 0x00000001873B4940-0x00000001873B49A0 0x00000001873B56C0-0x00000001873B5730
		public byte[] ServerWriteKey { get; set; } // 0x00000001873B53A0-0x00000001873B5400 0x00000001873B5CD0-0x00000001873B5D40
		public byte[] ClientWriteIV { get; set; } // 0x00000001873B48E0-0x00000001873B4940 0x00000001873B5650-0x00000001873B56C0
		public byte[] ServerWriteIV { get; set; } // 0x00000001873B5340-0x00000001873B53A0 0x00000001873B5C60-0x00000001873B5CD0
		public RecordProtocol RecordProtocol { get; set; } // 0x00000001873B50A0-0x00000001873B5100 0x00000001873B5AC0-0x00000001873B5B30
		public SecurityParameters Current { get; } // 0x00000001873B4A00-0x00000001873B4B10 
		public SecurityParameters Negotiating { get; } // 0x00000001873B4C90-0x00000001873B4DA0 
		public SecurityParameters Read { get; } // 0x00000001873B4FE0-0x00000001873B5040 
		public SecurityParameters Write { get; } // 0x00000001873B5520-0x00000001873B5580 
	
		// Constructors
		protected Context() {} // Dummy constructor
		public Context(SecurityProtocolType securityProtocolType) {} // 0x00000001873B4690-0x00000001873B47C0
	
		// Methods
		public int GetUnixTime() => default; // 0x00000001873B4540-0x00000001873B4610
		public byte[] GetSecureRandomBytes(int count) => default; // 0x00000001873B4480-0x00000001873B4540
		public virtual void Clear() {} // 0x00000001873B4250-0x00000001873B4340
		public virtual void ClearKeyInfo() {} // 0x00000001873B4070-0x00000001873B4250
		public SecurityProtocolType DecodeProtocolCode(short code) => default; // 0x00000001873B4340-0x00000001873B43F0
		public void ChangeProtocol(short protocol) {} // 0x00000001873B3E20-0x00000001873B4070
		public void StartSwitchingSecurityParameters(bool client) {} // 0x00000001873B4610-0x00000001873B4690
		public void EndSwitchingSecurityParameters(bool client) {} // 0x00000001873B43F0-0x00000001873B4480
	}
}
