/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityInfo : MessageBase, IMessage<ActivityInfo> // TypeDefIndex: 21859
{
	// Fields
	private static readonly MessageParser<ActivityInfo> _parser; // 0x00
	public const int ActivityIdFieldNumber = 1; // Metadata: 0x00B00277
	private uint activityId_; // 0x18
	public const int ScheduleIdFieldNumber = 2; // Metadata: 0x00B0027B
	private uint scheduleId_; // 0x1C
	public const int BeginTimeFieldNumber = 3; // Metadata: 0x00B0027F
	private uint beginTime_; // 0x20
	public const int EndTimeFieldNumber = 4; // Metadata: 0x00B00283
	private uint endTime_; // 0x24
	public const int ActivityTypeFieldNumber = 5; // Metadata: 0x00B00287
	private uint activityType_; // 0x28
	public const int IsPlayOpenAnimFieldNumber = 6; // Metadata: 0x00B0028B
	private bool isPlayOpenAnim_; // 0x2C
	public const int IsFinishedFieldNumber = 7; // Metadata: 0x00B0028F
	private bool isFinished_; // 0x2D
	public const int IsStartingFieldNumber = 8; // Metadata: 0x00B00293
	private bool isStarting_; // 0x2E
	public const int WatcherInfoListFieldNumber = 9; // Metadata: 0x00B00297
	private static readonly FieldCodec<ActivityWatcherInfo> _repeated_watcherInfoList_codec; // 0x08
	private readonly RepeatedMessageField<ActivityWatcherInfo> watcherInfoList_; // 0x30
	public const int MeetCondListFieldNumber = 10; // Metadata: 0x00B0029B
	private static readonly FieldCodec<uint> _repeated_meetCondList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> meetCondList_; // 0x38
	public const int ExpireCondListFieldNumber = 15; // Metadata: 0x00B0029F
	private static readonly FieldCodec<uint> _repeated_expireCondList_codec; // 0x18
	private readonly RepeatedPrimitiveField<uint> expireCondList_; // 0x40
	public const int SelectedAvatarRewardIdFieldNumber = 17; // Metadata: 0x00B002A3
	private uint selectedAvatarRewardId_; // 0x48
	public const int ActivityCoinMapFieldNumber = 18; // Metadata: 0x00B002A7
	private static readonly MapField<uint, uint> _map_activityCoinMap_codec; // 0x20
	private readonly MapField<uint, uint> activityCoinMap_; // 0x50
	public const int ScoreLimitFieldNumber = 19; // Metadata: 0x00B002AB
	private uint scoreLimit_; // 0x58
	public const int CurScoreFieldNumber = 20; // Metadata: 0x00B002AF
	private uint curScore_; // 0x5C
	public const int TakenRewardListFieldNumber = 24; // Metadata: 0x00B002B3
	private static readonly FieldCodec<uint> _repeated_takenRewardList_codec; // 0x28
	private readonly RepeatedPrimitiveField<uint> takenRewardList_; // 0x60
	public const int SamLampInfoFieldNumber = 11; // Metadata: 0x00B002B7
	public const int CrucibleInfoFieldNumber = 12; // Metadata: 0x00B002BB
	public const int SalesmanInfoFieldNumber = 13; // Metadata: 0x00B002BF
	public const int TrialAvatarInfoFieldNumber = 14; // Metadata: 0x00B002C3
	public const int DeliveryInfoFieldNumber = 16; // Metadata: 0x00B002C7
	public const int AsterInfoFieldNumber = 21; // Metadata: 0x00B002CB
	public const int FlightInfoFieldNumber = 25; // Metadata: 0x00B002CF
	public const int DragonSpineInfoFieldNumber = 31; // Metadata: 0x00B002D3
	public const int EffigyInfoFieldNumber = 32; // Metadata: 0x00B002D7
	public const int TreasureMapInfoFieldNumber = 35; // Metadata: 0x00B002DB
	public const int BlessingInfoFieldNumber = 41; // Metadata: 0x00B002DF
	public const int SeaLampInfoFieldNumber = 42; // Metadata: 0x00B002E3
	public const int ExpeditionInfoFieldNumber = 43; // Metadata: 0x00B002E7
	public const int ArenaChallengeInfoFieldNumber = 44; // Metadata: 0x00B002EB
	public const int FleurFairInfoFieldNumber = 51; // Metadata: 0x00B002EF
	public const int WaterSpiritInfoFieldNumber = 52; // Metadata: 0x00B002F3
	public const int ChallnelerSlabInfoFieldNumber = 61; // Metadata: 0x00B002F7
	public const int MistTrialActivityInfoFieldNumber = 62; // Metadata: 0x00B002FB
	public const int HideAndSeekInfoFieldNumber = 63; // Metadata: 0x00B002FF
	public const int FindHilichurlInfoFieldNumber = 64; // Metadata: 0x00B00303
	private object detail_; // 0x68
	private DetailOneofCase detailCase_; // 0x70

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivityInfo> Parser { get => default; } // 0x00000001842BD220-0x00000001842BD2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001842BC380-0x00000001842BC410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001842BB530-0x00000001842BB5B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001842B74A0-0x00000001842B7500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001842BF820-0x00000001842BF910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001842BE7B0-0x00000001842BE810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001842BC830-0x00000001842BC920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001842BF730-0x00000001842BF780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001842BB790-0x00000001842BB880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x00000001842BE670-0x00000001842BE710 0x00000001842B7690-0x00000001842B7730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x00000001842B8F40-0x00000001842B8FE0 0x00000001842BE950-0x00000001842BE9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x00000001842BF520-0x00000001842BF5C0 0x00000001842BE390-0x00000001842BE430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x00000001842BCCF0-0x00000001842BCD90 0x00000001842BE710-0x00000001842BE7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityType { get => default; set {} } // 0x00000001842B8B20-0x00000001842B8BC0 0x00000001842BE2F0-0x00000001842BE390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsPlayOpenAnim { get => default; set {} } // 0x00000001842B8A80-0x00000001842B8B20 0x00000001842BC580-0x00000001842BC620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFinished { get => default; set {} } // 0x00000001842BCC50-0x00000001842BCCF0 0x00000001842B8FE0-0x00000001842B9080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsStarting { get => default; set {} } // 0x00000001842BE810-0x00000001842BE8B0 0x00000001842BE430-0x00000001842BE4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ActivityWatcherInfo> WatcherInfoList { get => default; } // 0x00000001842BF910-0x00000001842BF970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> MeetCondList { get => default; } // 0x00000001842B9150-0x00000001842B91B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ExpireCondList { get => default; } // 0x00000001842B7500-0x00000001842B7560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SelectedAvatarRewardId { get => default; set {} } // 0x00000001842BB6F0-0x00000001842BB790 0x00000001842BC2E0-0x00000001842BC380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> ActivityCoinMap { get => default; } // 0x00000001842B80D0-0x00000001842B8130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScoreLimit { get => default; set {} } // 0x00000001842B9970-0x00000001842B9A10 0x00000001842BC4E0-0x00000001842BC580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurScore { get => default; set {} } // 0x00000001842BF780-0x00000001842BF820 0x00000001842BB650-0x00000001842BB6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TakenRewardList { get => default; } // 0x00000001842BB360-0x00000001842BB3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampActivityDetailInfo SamLampInfo { get => default; set {} } // 0x00000001842BF660-0x00000001842BF730 0x00000001842BC620-0x00000001842BC6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CrucibleActivityDetailInfo CrucibleInfo { get => default; set {} } // 0x00000001842BFA40-0x00000001842BFB10 0x00000001842BA470-0x00000001842BA510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SalesmanActivityDetailInfo SalesmanInfo { get => default; set {} } // 0x00000001842BFB10-0x00000001842BFBE0 0x00000001842BE8B0-0x00000001842BE950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TrialAvatarActivityDetailInfo TrialAvatarInfo { get => default; set {} } // 0x00000001842BE220-0x00000001842BE2F0 0x00000001842B8130-0x00000001842B81D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DeliveryActivityDetailInfo DeliveryInfo { get => default; set {} } // 0x00000001842BCF70-0x00000001842BD040 0x00000001842BA3D0-0x00000001842BA470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AsterActivityDetailInfo AsterInfo { get => default; set {} } // 0x00000001842BC410-0x00000001842BC4E0 0x00000001842BD040-0x00000001842BD0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FlightActivityDetailInfo FlightInfo { get => default; set {} } // 0x00000001842BC9C0-0x00000001842BCA90 0x00000001842BCD90-0x00000001842BCE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DragonSpineActivityDetailInfo DragonSpineInfo { get => default; set {} } // 0x00000001842BE9F0-0x00000001842BEAC0 0x00000001842BC790-0x00000001842BC830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EffigyActivityDetailInfo EffigyInfo { get => default; set {} } // 0x00000001842BE4D0-0x00000001842BE5A0 0x00000001842B7730-0x00000001842B77D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapActivityDetailInfo TreasureMapInfo { get => default; set {} } // 0x00000001842BE5A0-0x00000001842BE670 0x00000001842B8EA0-0x00000001842B8F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingActivityDetailInfo BlessingInfo { get => default; set {} } // 0x00000001842BC6C0-0x00000001842BC790 0x00000001842BCED0-0x00000001842BCF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampActivityInfo SeaLampInfo { get => default; set {} } // 0x00000001842BEAC0-0x00000001842BEB90 0x00000001842BD180-0x00000001842BD220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionActivityDetailInfo ExpeditionInfo { get => default; set {} } // 0x00000001842BF970-0x00000001842BFA40 0x00000001842BC170-0x00000001842BC210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeActivityDetailInfo ArenaChallengeInfo { get => default; set {} } // 0x00000001842BCB80-0x00000001842BCC50 0x00000001842BB490-0x00000001842BB530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairActivityDetailInfo FleurFairInfo { get => default; set {} } // 0x00000001842BC210-0x00000001842BC2E0 0x00000001842BD0E0-0x00000001842BD180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WaterSpiritActivityDetailInfo WaterSpiritInfo { get => default; set {} } // 0x00000001842B9080-0x00000001842B9150 0x00000001842BF5C0-0x00000001842BF660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChannelerSlabActivityDetailInfo ChallnelerSlabInfo { get => default; set {} } // 0x00000001842B89B0-0x00000001842B8A80 0x00000001842BC920-0x00000001842BC9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialActivityDetailInfo MistTrialActivityInfo { get => default; set {} } // 0x00000001842BB880-0x00000001842BB950 0x00000001842B8030-0x00000001842B80D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekActivityDetailInfo HideAndSeekInfo { get => default; set {} } // 0x00000001842BB3C0-0x00000001842BB490 0x00000001842BCE30-0x00000001842BCED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FindHilichurlDetailInfo FindHilichurlInfo { get => default; set {} } // 0x00000001842B75C0-0x00000001842B7690 0x00000001842BC0D0-0x00000001842BC170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DetailOneofCase DetailCase { get => default; } // 0x00000001842B8950-0x00000001842B89B0 

	// Nested types
	public enum DetailOneofCase // TypeDefIndex: 21860
	{
		None = 0,
		SamLampInfo = 11,
		CrucibleInfo = 12,
		SalesmanInfo = 13,
		TrialAvatarInfo = 14,
		DeliveryInfo = 16,
		AsterInfo = 21,
		FlightInfo = 25,
		DragonSpineInfo = 31,
		EffigyInfo = 32,
		TreasureMapInfo = 35,
		BlessingInfo = 41,
		SeaLampInfo = 42,
		ExpeditionInfo = 43,
		ArenaChallengeInfo = 44,
		FleurFairInfo = 51,
		WaterSpiritInfo = 52,
		ChallnelerSlabInfo = 61,
		MistTrialActivityInfo = 62,
		HideAndSeekInfo = 63,
		FindHilichurlInfo = 64
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityInfo() {} // 0x00000001842C1470-0x00000001842C1590
	static ActivityInfo() {} // 0x00000001842C1290-0x00000001842C1470

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityInfo Clone() => default; // 0x00000001842BCA90-0x00000001842BCB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityInfo ShallowCopy() => default; // 0x00000001842BB5B0-0x00000001842BB650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001842B81D0-0x00000001842B8950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842BD340-0x00000001842BDAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842BDAB0-0x00000001842BE220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001842B8BC0-0x00000001842B8EA0
	public void resetDetail() {} // 0x00000001842BA510-0x00000001842BB360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDetail() {} // 0x00000001842B7560-0x00000001842B75C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001842B98A0-0x00000001842B9970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivityInfo other) => default; // 0x00000001842B91B0-0x00000001842B98A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001842BB950-0x00000001842BC0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001842BFBE0-0x00000001842C1290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001842BEB90-0x00000001842BF520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001842B9A10-0x00000001842BA3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivityInfo other) {} // 0x00000001842B77D0-0x00000001842B8030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001842B65B0-0x00000001842B74A0
}

