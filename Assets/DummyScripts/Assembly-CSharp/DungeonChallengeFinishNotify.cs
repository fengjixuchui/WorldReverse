/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonChallengeFinishNotify : MessageBase, IMessage<DungeonChallengeFinishNotify> // TypeDefIndex: 22861
{
	// Fields
	private static readonly MessageParser<DungeonChallengeFinishNotify> _parser; // 0x00
	public const int ChallengeIndexFieldNumber = 1; // Metadata: 0x00B028DF
	private uint challengeIndex_; // 0x18
	public const int IsSuccessFieldNumber = 2; // Metadata: 0x00B028E3
	private bool isSuccess_; // 0x1C
	public const int IsNewRecordFieldNumber = 3; // Metadata: 0x00B028E7
	private bool isNewRecord_; // 0x1D
	public const int ChallengeRecordTypeFieldNumber = 4; // Metadata: 0x00B028EB
	private uint challengeRecordType_; // 0x20
	public const int CurrentValueFieldNumber = 5; // Metadata: 0x00B028EF
	private uint currentValue_; // 0x24
	public const int StrengthenPointDataMapFieldNumber = 6; // Metadata: 0x00B028F3
	private static readonly MapField<uint, StrengthenPointData> _map_strengthenPointDataMap_codec; // 0x08
	private readonly MapField<uint, StrengthenPointData> strengthenPointDataMap_; // 0x28
	public const int ChannellerSlabLoopDungeonResultInfoFieldNumber = 101; // Metadata: 0x00B028F7
	private object detail_; // 0x30
	private DetailOneofCase detailCase_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonChallengeFinishNotify> Parser { get => default; } // 0x00000001841E8950-0x00000001841E89E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001841E8460-0x00000001841E84F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001841E8020-0x00000001841E80A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001841E7260-0x00000001841E72C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001841E9130-0x00000001841E9220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001841E8C90-0x00000001841E8CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001841E86D0-0x00000001841E87C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001841E8F70-0x00000001841E8FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001841E8140-0x00000001841E8230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeIndex { get => default; set {} } // 0x00000001841E78A0-0x00000001841E7940 0x00000001841E84F0-0x00000001841E8590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSuccess { get => default; set {} } // 0x00000001841E8BF0-0x00000001841E8C90 0x00000001841E7320-0x00000001841E73C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsNewRecord { get => default; set {} } // 0x00000001841E8590-0x00000001841E8630 0x00000001841E9220-0x00000001841E92C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeRecordType { get => default; set {} } // 0x00000001841E8630-0x00000001841E86D0 0x00000001841E88B0-0x00000001841E8950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurrentValue { get => default; set {} } // 0x00000001841E8FC0-0x00000001841E9060 0x00000001841E7940-0x00000001841E79E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, StrengthenPointData> StrengthenPointDataMap { get => default; } // 0x00000001841E72C0-0x00000001841E7320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonResultInfo ChannellerSlabLoopDungeonResultInfo { get => default; set {} } // 0x00000001841E9060-0x00000001841E9130 0x00000001841E71C0-0x00000001841E7260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DetailOneofCase DetailCase { get => default; } // 0x00000001841E7730-0x00000001841E7790 

	// Nested types
	public enum DetailOneofCase // TypeDefIndex: 22862
	{
		None = 0,
		ChannellerSlabLoopDungeonResultInfo = 101
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22863
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22864
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 919
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonChallengeFinishNotify() {} // 0x00000001841E9970-0x00000001841E9AD0
	static DungeonChallengeFinishNotify() {} // 0x00000001841E9810-0x00000001841E9970

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonChallengeFinishNotify Clone() => default; // 0x00000001841E87C0-0x00000001841E88B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonChallengeFinishNotify ShallowCopy() => default; // 0x00000001841E80A0-0x00000001841E8140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001841E7670-0x00000001841E7730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841E8A70-0x00000001841E8B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841E8B30-0x00000001841E8BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001841E7790-0x00000001841E78A0
	public void resetDetail() {} // 0x00000001841E7F00-0x00000001841E8020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDetail() {} // 0x00000001841E73C0-0x00000001841E7420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001841E7BF0-0x00000001841E7CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonChallengeFinishNotify other) => default; // 0x00000001841E79E0-0x00000001841E7BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001841E8230-0x00000001841E8460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001841E92C0-0x00000001841E9810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001841E8CF0-0x00000001841E8F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001841E7CC0-0x00000001841E7F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonChallengeFinishNotify other) {} // 0x00000001841E7420-0x00000001841E7670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001841E6F50-0x00000001841E71C0
}

