/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CardProductRewardNotify : MessageBase, IMessage<CardProductRewardNotify> // TypeDefIndex: 24702
{
	// Fields
	private static readonly MessageParser<CardProductRewardNotify> _parser; // 0x00
	public const int ProductIdFieldNumber = 1; // Metadata: 0x00B0708B
	private string productId_; // 0x18
	public const int HcoinFieldNumber = 2; // Metadata: 0x00B0708F
	private uint hcoin_; // 0x20
	public const int RemainDaysFieldNumber = 3; // Metadata: 0x00B07093
	private uint remainDays_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CardProductRewardNotify> Parser { get => default; } // 0x000000018325E460-0x000000018325E4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018325DF60-0x000000018325DFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018325DBF0-0x000000018325DC70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018325D410-0x000000018325D470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018325E850-0x000000018325E940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018325E620-0x000000018325E680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018325DFF0-0x000000018325E0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018325E800-0x000000018325E850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018325DD10-0x000000018325DE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ProductId { get => default; set {} } // 0x000000018325E1D0-0x000000018325E270 0x000000018325E310-0x000000018325E3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Hcoin { get => default; set {} } // 0x000000018325DB50-0x000000018325DBF0 0x000000018325E3C0-0x000000018325E460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RemainDays { get => default; set {} } // 0x000000018325E270-0x000000018325E310 0x000000018325DAB0-0x000000018325DB50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24703
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24704
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4104
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CardProductRewardNotify() {} // 0x000000018325EC70-0x000000018325ECE0
	static CardProductRewardNotify() {} // 0x000000018325EBB0-0x000000018325EC70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CardProductRewardNotify Clone() => default; // 0x000000018325E0E0-0x000000018325E1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CardProductRewardNotify ShallowCopy() => default; // 0x000000018325DC70-0x000000018325DD10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018325D5F0-0x000000018325D640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018325E580-0x000000018325E5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018325E5D0-0x000000018325E620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018325D640-0x000000018325D6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018325D840-0x000000018325D910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CardProductRewardNotify other) => default; // 0x000000018325D6D0-0x000000018325D840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018325DE00-0x000000018325DF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018325E940-0x000000018325EBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018325E680-0x000000018325E800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018325D910-0x000000018325DAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CardProductRewardNotify other) {} // 0x000000018325D470-0x000000018325D5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018325D300-0x000000018325D410
}

