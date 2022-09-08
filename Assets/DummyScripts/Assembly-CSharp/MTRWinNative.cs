/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MTRWinNative // TypeDefIndex: 21184
{
	// Fields
	public const int IP_STATUS_BASE = 11000; // Metadata: 0x00AFEF95
	public const int IP_SUCCESS = 0; // Metadata: 0x00AFEF99
	public const int IP_BUF_TOO_SMALL = 11001; // Metadata: 0x00AFEF9D
	public const int IP_DEST_NET_UNREACHABLE = 11002; // Metadata: 0x00AFEFA1
	public const int IP_DEST_HOST_UNREACHABLE = 11003; // Metadata: 0x00AFEFA5
	public const int IP_DEST_PROT_UNREACHABLE = 11004; // Metadata: 0x00AFEFA9
	public const int IP_DEST_PORT_UNREACHABLE = 11005; // Metadata: 0x00AFEFAD
	public const int IP_NO_RESOURCES = 11006; // Metadata: 0x00AFEFB1
	public const int IP_BAD_OPTION = 11007; // Metadata: 0x00AFEFB5
	public const int IP_HW_ERROR = 11008; // Metadata: 0x00AFEFB9
	public const int IP_PACKET_TOO_BIG = 11009; // Metadata: 0x00AFEFBD
	public const int IP_REQ_TIMED_OUT = 11010; // Metadata: 0x00AFEFC1
	public const int IP_BAD_REQ = 11011; // Metadata: 0x00AFEFC5
	public const int IP_BAD_ROUTE = 11012; // Metadata: 0x00AFEFC9
	public const int IP_TTL_EXPIRED_TRANSIT = 11013; // Metadata: 0x00AFEFCD
	public const int IP_TTL_EXPIRED_REASSEM = 11014; // Metadata: 0x00AFEFD1
	public const int IP_PARAM_PROBLEM = 11015; // Metadata: 0x00AFEFD5
	public const int IP_SOURCE_QUENCH = 11016; // Metadata: 0x00AFEFD9
	public const int IP_OPTION_TOO_BIG = 11017; // Metadata: 0x00AFEFDD
	public const int IP_BAD_DESTINATION = 11018; // Metadata: 0x00AFEFE1
	public const int IP_DEST_NO_ROUTE = 11002; // Metadata: 0x00AFEFE5
	public const int IP_DEST_ADDR_UNREACHABLE = 11003; // Metadata: 0x00AFEFE9
	public const int IP_DEST_PROHIBITED = 11004; // Metadata: 0x00AFEFED
	public const int IP_HOP_LIMIT_EXCEEDED = 11013; // Metadata: 0x00AFEFF1
	public const int IP_REASSEMBLY_TIME_EXCEEDED = 11014; // Metadata: 0x00AFEFF5
	public const int IP_PARAMETER_PROBLEM = 11015; // Metadata: 0x00AFEFF9
	public const int IP_DEST_UNREACHABLE = 11040; // Metadata: 0x00AFEFFD
	public const int IP_TIME_EXCEEDED = 11041; // Metadata: 0x00AFF001
	public const int IP_BAD_HEADER = 11042; // Metadata: 0x00AFF005
	public const int IP_UNRECOGNIZED_NEXT_HEADER = 11043; // Metadata: 0x00AFF009
	public const int IP_ICMP_ERROR = 11044; // Metadata: 0x00AFF00D
	public const int IP_DEST_SCOPE_MISMATCH = 11045; // Metadata: 0x00AFF011
	public const int IP_ADDR_DELETED = 11019; // Metadata: 0x00AFF015
	public const int IP_SPEC_MTU_CHANGE = 11020; // Metadata: 0x00AFF019
	public const int IP_MTU_CHANGE = 11021; // Metadata: 0x00AFF01D
	public const int IP_UNLOAD = 11022; // Metadata: 0x00AFF021
	public const int IP_ADDR_ADDED = 11023; // Metadata: 0x00AFF025
	public const int IP_MEDIA_CONNECT = 11024; // Metadata: 0x00AFF029
	public const int IP_MEDIA_DISCONNECT = 11025; // Metadata: 0x00AFF02D
	public const int IP_BIND_ADAPTER = 11026; // Metadata: 0x00AFF031
	public const int IP_UNBIND_ADAPTER = 11027; // Metadata: 0x00AFF035
	public const int IP_DEVICE_DOES_NOT_EXIST = 11028; // Metadata: 0x00AFF039
	public const int IP_DUPLICATE_ADDRESS = 11029; // Metadata: 0x00AFF03D
	public const int IP_INTERFACE_METRIC_CHANGE = 11030; // Metadata: 0x00AFF041
	public const int IP_RECONFIG_SECFLTR = 11031; // Metadata: 0x00AFF045
	public const int IP_NEGOTIATING_IPSEC = 11032; // Metadata: 0x00AFF049
	public const int IP_INTERFACE_WOL_CAPABILITY_CHANGE = 11033; // Metadata: 0x00AFF04D
	public const int IP_DUPLICATE_IPADD = 11034; // Metadata: 0x00AFF051
	public const int IP_GENERAL_FAILURE = 11050; // Metadata: 0x00AFF055
	public const int MAX_IP_STATUS = 11050; // Metadata: 0x00AFF059
	public const int IP_PENDING = 11255; // Metadata: 0x00AFF05D
	public const uint ERROR_IO_PENDING = 997; // Metadata: 0x00AFF061
	public const uint WAIT_TIMEOUT = 258; // Metadata: 0x00AFF065

	// Nested types
	public struct ICMP_OPTIONS // TypeDefIndex: 21185
	{
		// Fields
		public byte Ttl; // 0x00
		public byte Tos; // 0x01
		public byte Flags; // 0x02
		public byte OptionsSize; // 0x03
		public IntPtr OptionsData; // 0x08
	}

	public struct ICMP_ECHO_REPLY // TypeDefIndex: 21186
	{
		// Fields
		public int Address; // 0x00
		public int Status; // 0x04
		public int RoundTripTime; // 0x08
		public short DataSize; // 0x0C
		public short Reserved; // 0x0E
		public IntPtr DataPtr; // 0x10
		public ICMP_OPTIONS Options; // 0x18
	}

	// Methods
	public static extern IntPtr IcmpCreateFile(); // 0x0000000182C089E0-0x0000000182C08AC0
	public static extern bool IcmpCloseHandle(IntPtr handle); // 0x0000000182C08AC0-0x0000000182C08BB0
	public static extern IntPtr CreateEvent(IntPtr lpEventAttributes, bool bManualReset, bool bInitialState, string lpName); // 0x0000000182C08D50-0x0000000182C08E80
	public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds); // 0x0000000182C088E0-0x0000000182C089E0
	public static extern bool CloseHandle(IntPtr handle); // 0x0000000182C087F0-0x0000000182C088E0
	public static extern int IcmpSendEcho2(IntPtr icmpHandle, IntPtr eventHandle, IntPtr apcRoutine, IntPtr apcContext, int destinationAddress, string requestData, short requestSize, ref ICMP_OPTIONS requestOptions, ref ICMP_ECHO_REPLY replyBuffer, int replySize, int timeout); // 0x0000000182C08BB0-0x0000000182C08D50
}

