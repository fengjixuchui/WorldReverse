/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BargainOfferPriceRsp : MessageBase, IMessage<BargainOfferPriceRsp> // TypeDefIndex: 24636
{
	// Fields
	private static readonly MessageParser<BargainOfferPriceRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B06E4B
	private int retcode_; // 0x18
	public const int BargainResultFieldNumber = 2; // Metadata: 0x00B06E4F
	private BargainResultType bargainResult_; // 0x1C
	public const int ResultParamFieldNumber = 3; // Metadata: 0x00B06E53
	private uint resultParam_; // 0x20
	public const int CurMoodFieldNumber = 4; // Metadata: 0x00B06E57
	private int curMood_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BargainOfferPriceRsp> Parser { get => default; } // 0x00000001829643E0-0x0000000182964470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182964030-0x00000001829640C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182963C80-0x0000000182963D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182963210-0x0000000182963270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001829647F0-0x00000001829648E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001829645A0-0x0000000182964600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182964160-0x0000000182964250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001829647A0-0x00000001829647F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182963DA0-0x0000000182963E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182963B40-0x0000000182963BE0 0x0000000182963570-0x0000000182963610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainResultType BargainResult { get => default; set {} } // 0x0000000182963BE0-0x0000000182963C80 0x00000001829640C0-0x0000000182964160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ResultParam { get => default; set {} } // 0x0000000182963440-0x00000001829634E0 0x0000000182963610-0x00000001829636B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int CurMood { get => default; set {} } // 0x00000001829636B0-0x0000000182963750 0x0000000182964340-0x00000001829643E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24637
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24638
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 425
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainOfferPriceRsp() {} // 0x0000000182964CC0-0x0000000182964D30
	static BargainOfferPriceRsp() {} // 0x0000000182964C00-0x0000000182964CC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainOfferPriceRsp Clone() => default; // 0x0000000182964250-0x0000000182964340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainOfferPriceRsp ShallowCopy() => default; // 0x0000000182963D00-0x0000000182963DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001829633F0-0x0000000182963440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182964500-0x0000000182964550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182964550-0x00000001829645A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001829634E0-0x0000000182963570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001829638A0-0x0000000182963970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BargainOfferPriceRsp other) => default; // 0x0000000182963750-0x00000001829638A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182963E90-0x0000000182964030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001829648E0-0x0000000182964C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182964600-0x00000001829647A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182963970-0x0000000182963B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BargainOfferPriceRsp other) {} // 0x0000000182963270-0x00000001829633F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001829630F0-0x0000000182963210
}

