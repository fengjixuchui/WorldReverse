/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetHuntingOfferRewardRsp : MessageBase, IMessage<GetHuntingOfferRewardRsp> // TypeDefIndex: 23544
{
	// Fields
	private static readonly MessageParser<GetHuntingOfferRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B04403
	private int retcode_; // 0x18
	public const int CityIdFieldNumber = 2; // Metadata: 0x00B04407
	private uint cityId_; // 0x1C
	public const int HuntingPairFieldNumber = 3; // Metadata: 0x00B0440B
	private HuntingPair huntingPair_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetHuntingOfferRewardRsp> Parser { get => default; } // 0x0000000182E7D520-0x0000000182E7D5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E7D2B0-0x0000000182E7D340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E7CEF0-0x0000000182E7CF70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182E7C4A0-0x0000000182E7C500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182E7D9F0-0x0000000182E7DAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182E7D7E0-0x0000000182E7D840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182E7D340-0x0000000182E7D430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182E7D9A0-0x0000000182E7D9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182E7D010-0x0000000182E7D100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182E7CE50-0x0000000182E7CEF0 0x0000000182E7C9B0-0x0000000182E7CA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000182E7C6B0-0x0000000182E7C750 0x0000000182E7D640-0x0000000182E7D6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingPair HuntingPair { get => default; set {} } // 0x0000000182E7C750-0x0000000182E7C7F0 0x0000000182E7C2A0-0x0000000182E7C340

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23545
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23546
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4306
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetHuntingOfferRewardRsp() {} // 0x0000000182E7DE10-0x0000000182E7DE70
	static GetHuntingOfferRewardRsp() {} // 0x0000000182E7DD50-0x0000000182E7DE10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetHuntingOfferRewardRsp Clone() => default; // 0x0000000182E7D430-0x0000000182E7D520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetHuntingOfferRewardRsp ShallowCopy() => default; // 0x0000000182E7CF70-0x0000000182E7D010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E7C7F0-0x0000000182E7C870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E7D6E0-0x0000000182E7D760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E7D760-0x0000000182E7D7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182E7C870-0x0000000182E7C9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182E7CA50-0x0000000182E7CB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetHuntingOfferRewardRsp other) => default; // 0x0000000182E7CB20-0x0000000182E7CC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182E7D100-0x0000000182E7D2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182E7DAE0-0x0000000182E7DD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E7D840-0x0000000182E7D9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182E7CC70-0x0000000182E7CE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetHuntingOfferRewardRsp other) {} // 0x0000000182E7C500-0x0000000182E7C6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E7C340-0x0000000182E7C4A0
}

