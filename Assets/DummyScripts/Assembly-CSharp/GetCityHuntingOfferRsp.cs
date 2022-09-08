/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetCityHuntingOfferRsp : MessageBase, IMessage<GetCityHuntingOfferRsp> // TypeDefIndex: 23538
{
	// Fields
	private static readonly MessageParser<GetCityHuntingOfferRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B043BF
	private int retcode_; // 0x18
	public const int CityIdFieldNumber = 2; // Metadata: 0x00B043C3
	private uint cityId_; // 0x1C
	public const int HuntingOfferListFieldNumber = 3; // Metadata: 0x00B043C7
	private static readonly FieldCodec<HuntingOfferData> _repeated_huntingOfferList_codec; // 0x08
	private readonly RepeatedMessageField<HuntingOfferData> huntingOfferList_; // 0x20
	public const int CurWeekFinishedCountFieldNumber = 4; // Metadata: 0x00B043CB
	private uint curWeekFinishedCount_; // 0x28
	public const int OngoingHuntingPairFieldNumber = 5; // Metadata: 0x00B043CF
	private HuntingPair ongoingHuntingPair_; // 0x30
	public const int NextRefreshTimeFieldNumber = 6; // Metadata: 0x00B043D3
	private uint nextRefreshTime_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetCityHuntingOfferRsp> Parser { get => default; } // 0x0000000183ABD520-0x0000000183ABD5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183ABD070-0x0000000183ABD100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183ABCC20-0x0000000183ABCCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183ABBEB0-0x0000000183ABBF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183ABDB10-0x0000000183ABDC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183ABD820-0x0000000183ABD880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183ABD200-0x0000000183ABD2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183ABDAC0-0x0000000183ABDB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183ABCD40-0x0000000183ABCE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183ABCB80-0x0000000183ABCC20 0x0000000183ABC4E0-0x0000000183ABC580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000183ABC160-0x0000000183ABC200 0x0000000183ABD640-0x0000000183ABD6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HuntingOfferData> HuntingOfferList { get => default; } // 0x0000000183ABD100-0x0000000183ABD160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurWeekFinishedCount { get => default; set {} } // 0x0000000183ABD160-0x0000000183ABD200 0x0000000183ABC440-0x0000000183ABC4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingPair OngoingHuntingPair { get => default; set {} } // 0x0000000183ABD480-0x0000000183ABD520 0x0000000183ABC580-0x0000000183ABC620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextRefreshTime { get => default; set {} } // 0x0000000183ABD3E0-0x0000000183ABD480 0x0000000183ABDC00-0x0000000183ABDCA0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23539
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23540
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4304
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetCityHuntingOfferRsp() {} // 0x0000000183ABE1B0-0x0000000183ABE240
	static GetCityHuntingOfferRsp() {} // 0x0000000183ABE0A0-0x0000000183ABE1B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetCityHuntingOfferRsp Clone() => default; // 0x0000000183ABD2F0-0x0000000183ABD3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetCityHuntingOfferRsp ShallowCopy() => default; // 0x0000000183ABCCA0-0x0000000183ABCD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183ABC200-0x0000000183ABC280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183ABD6E0-0x0000000183ABD780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183ABD780-0x0000000183ABD820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183ABC280-0x0000000183ABC440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183ABC7E0-0x0000000183ABC8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetCityHuntingOfferRsp other) => default; // 0x0000000183ABC620-0x0000000183ABC7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183ABCE30-0x0000000183ABD070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183ABDCA0-0x0000000183ABE0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183ABD880-0x0000000183ABDAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183ABC8B0-0x0000000183ABCB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetCityHuntingOfferRsp other) {} // 0x0000000183ABBF10-0x0000000183ABC160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183ABBCA0-0x0000000183ABBEB0
}

