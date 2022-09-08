/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class McoinExchangeHcoinRsp : MessageBase, IMessage<McoinExchangeHcoinRsp> // TypeDefIndex: 23748
{
	// Fields
	private static readonly MessageParser<McoinExchangeHcoinRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04BD7
	private int retcode_; // 0x18
	public const int McoinCostFieldNumber = 2; // Metadata: 0x00B04BDB
	private uint mcoinCost_; // 0x1C
	public const int HcoinFieldNumber = 3; // Metadata: 0x00B04BDF
	private uint hcoin_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<McoinExchangeHcoinRsp> Parser { get => default; } // 0x0000000182FDE610-0x0000000182FDE6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182FDE260-0x0000000182FDE2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182FDDF20-0x0000000182FDDFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182FDD680-0x0000000182FDD6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182FDE9E0-0x0000000182FDEAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182FDE7D0-0x0000000182FDE830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182FDE2F0-0x0000000182FDE3E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182FDE990-0x0000000182FDE9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182FDE040-0x0000000182FDE130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182FDDE80-0x0000000182FDDF20 0x0000000182FDD910-0x0000000182FDD9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint McoinCost { get => default; set {} } // 0x0000000182FDDD40-0x0000000182FDDDE0 0x0000000182FDE570-0x0000000182FDE610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Hcoin { get => default; set {} } // 0x0000000182FDDDE0-0x0000000182FDDE80 0x0000000182FDE4D0-0x0000000182FDE570

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23749
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23750
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 656
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public McoinExchangeHcoinRsp() {} // 0x0000000182FDEE20-0x0000000182FDEE80
	static McoinExchangeHcoinRsp() {} // 0x0000000182FDED60-0x0000000182FDEE20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public McoinExchangeHcoinRsp Clone() => default; // 0x0000000182FDE3E0-0x0000000182FDE4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public McoinExchangeHcoinRsp ShallowCopy() => default; // 0x0000000182FDDFA0-0x0000000182FDE040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182FDD840-0x0000000182FDD890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FDE730-0x0000000182FDE780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FDE780-0x0000000182FDE7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182FDD890-0x0000000182FDD910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182FDDAF0-0x0000000182FDDBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(McoinExchangeHcoinRsp other) => default; // 0x0000000182FDD9B0-0x0000000182FDDAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182FDE130-0x0000000182FDE260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182FDEAD0-0x0000000182FDED60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182FDE830-0x0000000182FDE990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182FDDBC0-0x0000000182FDDD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(McoinExchangeHcoinRsp other) {} // 0x0000000182FDD6E0-0x0000000182FDD840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182FDD570-0x0000000182FDD680
}

