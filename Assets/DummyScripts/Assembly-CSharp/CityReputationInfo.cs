/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CityReputationInfo : MessageBase, IMessage<CityReputationInfo> // TypeDefIndex: 24752
{
	// Fields
	private static readonly MessageParser<CityReputationInfo> _parser; // 0x00
	public const int LevelFieldNumber = 1; // Metadata: 0x00B07263
	private uint level_; // 0x18
	public const int ExpFieldNumber = 2; // Metadata: 0x00B07267
	private uint exp_; // 0x1C
	public const int TakenLevelRewardListFieldNumber = 3; // Metadata: 0x00B0726B
	private static readonly FieldCodec<uint> _repeated_takenLevelRewardList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> takenLevelRewardList_; // 0x20
	public const int TotalAcceptRequestNumFieldNumber = 4; // Metadata: 0x00B0726F
	private uint totalAcceptRequestNum_; // 0x28
	public const int NextRefreshTimeFieldNumber = 5; // Metadata: 0x00B07273
	private uint nextRefreshTime_; // 0x2C
	public const int QuestInfoFieldNumber = 10; // Metadata: 0x00B07277
	private CityReputationQuestInfo questInfo_; // 0x30
	public const int RequestInfoFieldNumber = 11; // Metadata: 0x00B0727B
	private CityReputationRequestInfo requestInfo_; // 0x38
	public const int ExploreInfoFieldNumber = 12; // Metadata: 0x00B0727F
	private CityReputationExploreInfo exploreInfo_; // 0x40
	public const int HuntInfoFieldNumber = 13; // Metadata: 0x00B07283
	private CityReputationHuntInfo huntInfo_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CityReputationInfo> Parser { get => default; } // 0x00000001822ECFA0-0x00000001822ED030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001822ECB50-0x00000001822ECBE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001822EC490-0x00000001822EC510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001822EAFF0-0x00000001822EB050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001822ED8D0-0x00000001822ED9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001822ED4A0-0x00000001822ED500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001822ECC80-0x00000001822ECD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001822ED880-0x00000001822ED8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001822EC650-0x00000001822EC740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x00000001822EB4C0-0x00000001822EB560 0x00000001822EC5B0-0x00000001822EC650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Exp { get => default; set {} } // 0x00000001822EBB50-0x00000001822EBBF0 0x00000001822ED160-0x00000001822ED200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TakenLevelRewardList { get => default; } // 0x00000001822EB460-0x00000001822EB4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalAcceptRequestNum { get => default; set {} } // 0x00000001822EB560-0x00000001822EB600 0x00000001822ED200-0x00000001822ED2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextRefreshTime { get => default; set {} } // 0x00000001822ECF00-0x00000001822ECFA0 0x00000001822ED9C0-0x00000001822EDA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationQuestInfo QuestInfo { get => default; set {} } // 0x00000001822EC3F0-0x00000001822EC490 0x00000001822ED030-0x00000001822ED0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationRequestInfo RequestInfo { get => default; set {} } // 0x00000001822EBAB0-0x00000001822EBB50 0x00000001822EB050-0x00000001822EB0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationExploreInfo ExploreInfo { get => default; set {} } // 0x00000001822ECE60-0x00000001822ECF00 0x00000001822ED7E0-0x00000001822ED880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationHuntInfo HuntInfo { get => default; set {} } // 0x00000001822ECBE0-0x00000001822ECC80 0x00000001822ED2A0-0x00000001822ED340

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationInfo() {} // 0x00000001822EE090-0x00000001822EE120
	static CityReputationInfo() {} // 0x00000001822EDFB0-0x00000001822EE090

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationInfo Clone() => default; // 0x00000001822ECD70-0x00000001822ECE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationInfo ShallowCopy() => default; // 0x00000001822EC510-0x00000001822EC5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001822EB600-0x00000001822EB6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822ED340-0x00000001822ED3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822ED3F0-0x00000001822ED4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001822EB6C0-0x00000001822EBAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001822EBE40-0x00000001822EBF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CityReputationInfo other) => default; // 0x00000001822EBBF0-0x00000001822EBE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001822EC740-0x00000001822ECB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001822EDA60-0x00000001822EDFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001822ED500-0x00000001822ED7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001822EBF10-0x00000001822EC3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CityReputationInfo other) {} // 0x00000001822EB0F0-0x00000001822EB460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001822EACD0-0x00000001822EAFF0
}

