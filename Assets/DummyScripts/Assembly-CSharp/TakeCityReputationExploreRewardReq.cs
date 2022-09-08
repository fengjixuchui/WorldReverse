/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeCityReputationExploreRewardReq : MessageBase, IMessage<TakeCityReputationExploreRewardReq> // TypeDefIndex: 24792
{
	// Fields
	private static readonly MessageParser<TakeCityReputationExploreRewardReq> _parser; // 0x00
	public const int CityIdFieldNumber = 1; // Metadata: 0x00B073F7
	private uint cityId_; // 0x18
	public const int ExploreIdListFieldNumber = 2; // Metadata: 0x00B073FB
	private static readonly FieldCodec<uint> _repeated_exploreIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> exploreIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeCityReputationExploreRewardReq> Parser { get => default; } // 0x00000001817F4F50-0x00000001817F4FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001817F4C80-0x00000001817F4D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001817F4970-0x00000001817F49F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001817F42F0-0x00000001817F4350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001817F53A0-0x00000001817F5490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001817F51B0-0x00000001817F5210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001817F4D10-0x00000001817F4E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001817F5350-0x00000001817F53A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001817F4A90-0x00000001817F4B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x00000001817F4480-0x00000001817F4520 0x00000001817F5070-0x00000001817F5110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ExploreIdList { get => default; } // 0x00000001817F4EF0-0x00000001817F4F50 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24793
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24794
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2814
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCityReputationExploreRewardReq() {} // 0x00000001817F5750-0x00000001817F57E0
	static TakeCityReputationExploreRewardReq() {} // 0x00000001817F5670-0x00000001817F5750

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCityReputationExploreRewardReq Clone() => default; // 0x00000001817F4E00-0x00000001817F4EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeCityReputationExploreRewardReq ShallowCopy() => default; // 0x00000001817F49F0-0x00000001817F4A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001817F4520-0x00000001817F4570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817F5110-0x00000001817F5160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817F5160-0x00000001817F51B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001817F4570-0x00000001817F4630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001817F4760-0x00000001817F4830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeCityReputationExploreRewardReq other) => default; // 0x00000001817F4630-0x00000001817F4760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001817F4B80-0x00000001817F4C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001817F5490-0x00000001817F5670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001817F5210-0x00000001817F5350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001817F4830-0x00000001817F4970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeCityReputationExploreRewardReq other) {} // 0x00000001817F4350-0x00000001817F4480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001817F4180-0x00000001817F42F0
}

