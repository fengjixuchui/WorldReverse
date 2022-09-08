/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonSettleNotify : MessageBase, IMessage<DungeonSettleNotify> // TypeDefIndex: 22832
{
	// Fields
	private static readonly MessageParser<DungeonSettleNotify> _parser; // 0x00
	public const int DungeonIdFieldNumber = 1; // Metadata: 0x00B0279B
	private uint dungeonId_; // 0x18
	public const int IsSuccessFieldNumber = 2; // Metadata: 0x00B0279F
	private bool isSuccess_; // 0x1C
	public const int FailCondListFieldNumber = 3; // Metadata: 0x00B027A3
	private static readonly FieldCodec<uint> _repeated_failCondList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> failCondList_; // 0x20
	public const int SettleShowFieldNumber = 4; // Metadata: 0x00B027A7
	private static readonly MapField<uint, ParamList> _map_settleShow_codec; // 0x10
	private readonly MapField<uint, ParamList> settleShow_; // 0x28
	public const int CloseTimeFieldNumber = 5; // Metadata: 0x00B027AB
	private uint closeTime_; // 0x30
	public const int StrengthenPointDataMapFieldNumber = 6; // Metadata: 0x00B027AF
	private static readonly MapField<uint, StrengthenPointData> _map_strengthenPointDataMap_codec; // 0x18
	private readonly MapField<uint, StrengthenPointData> strengthenPointDataMap_; // 0x38
	public const int ResultFieldNumber = 7; // Metadata: 0x00B027B3
	private uint result_; // 0x40
	public const int TowerLevelEndNotifyFieldNumber = 101; // Metadata: 0x00B027B7
	public const int TrialAvatarFirstPassDungeonNotifyFieldNumber = 102; // Metadata: 0x00B027BB
	public const int ChannellerSlabLoopDungeonResultInfoFieldNumber = 103; // Metadata: 0x00B027BF
	public const int EffigyChallengeDungeonResultInfoFieldNumber = 104; // Metadata: 0x00B027C3
	private object detail_; // 0x48
	private DetailOneofCase detailCase_; // 0x50

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonSettleNotify> Parser { get => default; } // 0x0000000182981520-0x00000001829815B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182980FD0-0x0000000182981060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001829809F0-0x0000000182980A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018297F4E0-0x000000018297F540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001829822A0-0x0000000182982390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182981B20-0x0000000182981B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182981130-0x0000000182981220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001829820E0-0x0000000182982130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182980BB0-0x0000000182980CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonId { get => default; set {} } // 0x0000000182980B10-0x0000000182980BB0 0x0000000182981FA0-0x0000000182982040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSuccess { get => default; set {} } // 0x0000000182981A80-0x0000000182981B20 0x000000018297F5A0-0x000000018297F640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FailCondList { get => default; } // 0x000000018297F480-0x000000018297F4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, ParamList> SettleShow { get => default; } // 0x000000018297F810-0x000000018297F870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CloseTime { get => default; set {} } // 0x00000001829819E0-0x0000000182981A80 0x000000018297F6A0-0x000000018297F740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, StrengthenPointData> StrengthenPointDataMap { get => default; } // 0x000000018297F540-0x000000018297F5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Result { get => default; set {} } // 0x0000000182981480-0x0000000182981520 0x0000000182982130-0x00000001829821D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelEndNotify TowerLevelEndNotify { get => default; set {} } // 0x0000000182981060-0x0000000182981130 0x0000000182982040-0x00000001829820E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarFirstPassDungeonNotify TrialAvatarFirstPassDungeonNotify { get => default; set {} } // 0x00000001829813B0-0x0000000182981480 0x0000000182981B80-0x0000000182981C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannellerSlabLoopDungeonResultInfo ChannellerSlabLoopDungeonResultInfo { get => default; set {} } // 0x00000001829821D0-0x00000001829822A0 0x000000018297F3E0-0x000000018297F480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyChallengeDungeonResultInfo EffigyChallengeDungeonResultInfo { get => default; set {} } // 0x000000018297F740-0x000000018297F810 0x0000000182981310-0x00000001829813B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DetailOneofCase DetailCase { get => default; } // 0x000000018297FD70-0x000000018297FDD0 

	// Nested types
	public enum DetailOneofCase // TypeDefIndex: 22833
	{
		None = 0,
		TowerLevelEndNotify = 101,
		TrialAvatarFirstPassDungeonNotify = 102,
		ChannellerSlabLoopDungeonResultInfo = 103,
		EffigyChallengeDungeonResultInfo = 104
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22834
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22835
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 910
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonSettleNotify() {} // 0x0000000182982D20-0x0000000182982E00
	static DungeonSettleNotify() {} // 0x0000000182982B10-0x0000000182982D20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonSettleNotify Clone() => default; // 0x0000000182981220-0x0000000182981310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonSettleNotify ShallowCopy() => default; // 0x0000000182980A70-0x0000000182980B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018297FB90-0x000000018297FD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182981640-0x0000000182981810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182981810-0x00000001829819E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018297FDD0-0x000000018297FF80
	public void resetDetail() {} // 0x00000001829806C0-0x00000001829809F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDetail() {} // 0x000000018297F640-0x000000018297F6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182980270-0x0000000182980340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonSettleNotify other) => default; // 0x000000018297FF80-0x0000000182980270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182980CA0-0x0000000182980FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182982390-0x0000000182982B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182981C20-0x0000000182981FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182980340-0x00000001829806C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonSettleNotify other) {} // 0x000000018297F870-0x000000018297FB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018297EF30-0x000000018297F3E0
}

