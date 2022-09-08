/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeCityReputationExploreRewardRsp : MessageBase, IMessage<TakeCityReputationExploreRewardRsp> // TypeDefIndex: 24795
{
	// Fields
	private static readonly MessageParser<TakeCityReputationExploreRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B07413
	private int retcode_; // 0x18
	public const int CityIdFieldNumber = 2; // Metadata: 0x00B07417
	private uint cityId_; // 0x1C
	public const int ExploreIdListFieldNumber = 3; // Metadata: 0x00B0741B
	private static readonly FieldCodec<uint> _repeated_exploreIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> exploreIdList_; // 0x20
	public const int ItemListFieldNumber = 4; // Metadata: 0x00B0741F
	private static readonly FieldCodec<ItemParam> _repeated_itemList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> itemList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeCityReputationExploreRewardRsp> Parser { get => default; } // 0x0000000185532DA0-0x0000000185532E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185532A70-0x0000000185532B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185532710-0x0000000185532790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185531D80-0x0000000185531DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001855332E0-0x00000001855333D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185533080-0x00000001855330E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185532B60-0x0000000185532C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185533290-0x00000001855332E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185532830-0x0000000185532920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000185532670-0x0000000185532710 0x00000001855321D0-0x0000000185532270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000185531F90-0x0000000185532030 0x0000000185532EC0-0x0000000185532F60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ExploreIdList { get => default; } // 0x0000000185532D40-0x0000000185532DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemList { get => default; } // 0x0000000185532B00-0x0000000185532B60 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24796
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24797
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2815
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCityReputationExploreRewardRsp() {} // 0x00000001855337E0-0x0000000185533890
	static TakeCityReputationExploreRewardRsp() {} // 0x00000001855336B0-0x00000001855337E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCityReputationExploreRewardRsp Clone() => default; // 0x0000000185532C50-0x0000000185532D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCityReputationExploreRewardRsp ShallowCopy() => default; // 0x0000000185532790-0x0000000185532830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185532030-0x0000000185532080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185532F60-0x0000000185532FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185532FF0-0x0000000185533080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185532080-0x00000001855321D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001855323E0-0x00000001855324B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeCityReputationExploreRewardRsp other) => default; // 0x0000000185532270-0x00000001855323E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185532920-0x0000000185532A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001855333D0-0x00000001855336B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001855330E0-0x0000000185533290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001855324B0-0x0000000185532670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeCityReputationExploreRewardRsp other) {} // 0x0000000185531DE0-0x0000000185531F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185531B80-0x0000000185531D80
}

