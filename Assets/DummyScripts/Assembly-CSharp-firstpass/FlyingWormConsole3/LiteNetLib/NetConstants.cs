/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib
{
	public static class NetConstants // TypeDefIndex: 6902
	{
		// Fields
		public const int HeaderSize = 1; // Metadata: 0x00ADDFBE
		public const int SequencedHeaderSize = 3; // Metadata: 0x00ADDFC2
		public const int FragmentHeaderSize = 6; // Metadata: 0x00ADDFC6
		public const int DefaultWindowSize = 64; // Metadata: 0x00ADDFCA
		public const ushort MaxSequence = 32768; // Metadata: 0x00ADDFCE
		public const ushort HalfMaxSequence = 16384; // Metadata: 0x00ADDFD0
		public const string MulticastGroupIPv4 = "224.0.0.1"; // Metadata: 0x00ADDFD2
		public const string MulticastGroupIPv6 = "FF02:0:0:0:0:0:0:1"; // Metadata: 0x00ADDFDF
		public const int SocketBufferSize = 1048576; // Metadata: 0x00ADDFF5
		public const int SocketTTL = 255; // Metadata: 0x00ADDFF9
		public const int ProtocolId = 1; // Metadata: 0x00ADDFFD
		public const int MaxUdpHeaderSize = 68; // Metadata: 0x00ADE001
		public const int PacketSizeLimit = 65467; // Metadata: 0x00ADE005
		public const int MinPacketSize = 508; // Metadata: 0x00ADE009
		public const int MinPacketDataSize = 507; // Metadata: 0x00ADE00D
		public const int MinSequencedPacketDataSize = 505; // Metadata: 0x00ADE011
		public static readonly int[] PossibleMtu; // 0x00
		public static int MaxPacketSize; // 0x08
		public const int FlowUpdateTime = 1000; // Metadata: 0x00ADE015
		public const int FlowIncreaseThreshold = 4; // Metadata: 0x00ADE019
		public const int DefaultPingInterval = 1000; // Metadata: 0x00ADE01D
	
		// Constructors
		static NetConstants() {} // 0x00000001863BE6B0-0x00000001863BE790
	}
}
