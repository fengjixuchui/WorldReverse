/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class McoinExchangeHcoinReq : MessageBase, IMessage<McoinExchangeHcoinReq> // TypeDefIndex: 23745
{
	// Fields
	private static readonly MessageParser<McoinExchangeHcoinReq> _parser; // 0x00
	public const int McoinCostFieldNumber = 1; // Metadata: 0x00B04BBB
	private uint mcoinCost_; // 0x18
	public const int HcoinFieldNumber = 2; // Metadata: 0x00B04BBF
	private uint hcoin_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<McoinExchangeHcoinReq> Parser { get => default; } // 0x0000000182F55E70-0x0000000182F55F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182F55AC0-0x0000000182F55B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182F557B0-0x0000000182F55830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182F55100-0x0000000182F55160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182F56200-0x0000000182F562F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182F56030-0x0000000182F56090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182F55B50-0x0000000182F55C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182F561B0-0x0000000182F56200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182F558D0-0x0000000182F559C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint McoinCost { get => default; set {} } // 0x0000000182F55670-0x0000000182F55710 0x0000000182F55DD0-0x0000000182F55E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Hcoin { get => default; set {} } // 0x0000000182F55710-0x0000000182F557B0 0x0000000182F55D30-0x0000000182F55DD0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23746
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23747
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 655
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public McoinExchangeHcoinReq() {} // 0x0000000182F565B0-0x0000000182F56610
	static McoinExchangeHcoinReq() {} // 0x0000000182F564F0-0x0000000182F565B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public McoinExchangeHcoinReq Clone() => default; // 0x0000000182F55C40-0x0000000182F55D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public McoinExchangeHcoinReq ShallowCopy() => default; // 0x0000000182F55830-0x0000000182F558D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182F55290-0x0000000182F552E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F55F90-0x0000000182F55FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F55FE0-0x0000000182F56030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182F552E0-0x0000000182F55350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182F55350-0x0000000182F55420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(McoinExchangeHcoinReq other) => default; // 0x0000000182F55420-0x0000000182F55540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182F559C0-0x0000000182F55AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182F562F0-0x0000000182F564F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182F56090-0x0000000182F561B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182F55540-0x0000000182F55670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(McoinExchangeHcoinReq other) {} // 0x0000000182F55160-0x0000000182F55290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182F55000-0x0000000182F55100
}

