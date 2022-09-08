/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerAllDataRsp : MessageBase, IMessage<TowerAllDataRsp> // TypeDefIndex: 25719
{
	// Fields
	private static readonly MessageParser<TowerAllDataRsp> _parser; // 0x00
	public const int TowerScheduleIdFieldNumber = 1; // Metadata: 0x00B096A7
	private uint towerScheduleId_; // 0x18
	public const int TowerFloorRecordListFieldNumber = 2; // Metadata: 0x00B096AB
	private static readonly FieldCodec<TowerFloorRecord> _repeated_towerFloorRecordList_codec; // 0x08
	private readonly RepeatedMessageField<TowerFloorRecord> towerFloorRecordList_; // 0x20
	public const int DailyFloorIdFieldNumber = 3; // Metadata: 0x00B096AF
	private uint dailyFloorId_; // 0x28
	public const int DailyLevelIndexFieldNumber = 4; // Metadata: 0x00B096B3
	private uint dailyLevelIndex_; // 0x2C
	public const int CurLevelRecordFieldNumber = 5; // Metadata: 0x00B096B7
	private TowerCurLevelRecord curLevelRecord_; // 0x30
	public const int NextScheduleChangeTimeFieldNumber = 6; // Metadata: 0x00B096BB
	private uint nextScheduleChangeTime_; // 0x38
	public const int FloorOpenTimeMapFieldNumber = 7; // Metadata: 0x00B096BF
	private static readonly MapField<uint, uint> _map_floorOpenTimeMap_codec; // 0x10
	private readonly MapField<uint, uint> floorOpenTimeMap_; // 0x40
	public const int IsFirstInteractFieldNumber = 8; // Metadata: 0x00B096C3
	private bool isFirstInteract_; // 0x48
	public const int MonthlyBriefFieldNumber = 9; // Metadata: 0x00B096C7
	private TowerMonthlyBrief monthlyBrief_; // 0x50
	public const int SkipToFloorIndexFieldNumber = 10; // Metadata: 0x00B096CB
	private uint skipToFloorIndex_; // 0x58
	public const int CommemorativeRewardIdFieldNumber = 11; // Metadata: 0x00B096CF
	private uint commemorativeRewardId_; // 0x5C
	public const int SkipFloorGrantedRewardItemMapFieldNumber = 12; // Metadata: 0x00B096D3
	private static readonly MapField<uint, uint> _map_skipFloorGrantedRewardItemMap_codec; // 0x18
	private readonly MapField<uint, uint> skipFloorGrantedRewardItemMap_; // 0x60
	public const int ValidTowerRecordNumFieldNumber = 13; // Metadata: 0x00B096D7
	private uint validTowerRecordNum_; // 0x68
	public const int RetcodeFieldNumber = 14; // Metadata: 0x00B096DB
	private int retcode_; // 0x6C
	public const int IsFinishedEntranceFloorFieldNumber = 15; // Metadata: 0x00B096DF
	private bool isFinishedEntranceFloor_; // 0x70
	public const int ScheduleStartTimeFieldNumber = 16; // Metadata: 0x00B096E3
	private uint scheduleStartTime_; // 0x74
	public const int LastScheduleMonthlyBriefFieldNumber = 17; // Metadata: 0x00B096E7
	private TowerMonthlyBrief lastScheduleMonthlyBrief_; // 0x78

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerAllDataRsp> Parser { get => default; } // 0x000000018490C460-0x000000018490C4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018490BE70-0x000000018490BF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018490B5C0-0x000000018490B640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849097C0-0x0000000184909820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018490CF50-0x000000018490D040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018490C840-0x000000018490C8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018490C140-0x000000018490C230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018490CE60-0x000000018490CEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018490B6E0-0x000000018490B7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TowerScheduleId { get => default; set {} } // 0x000000018490B1A0-0x000000018490B240 0x000000018490BD30-0x000000018490BDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<TowerFloorRecord> TowerFloorRecordList { get => default; } // 0x000000018490B4C0-0x000000018490B520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DailyFloorId { get => default; set {} } // 0x000000018490B240-0x000000018490B2E0 0x000000018490C320-0x000000018490C3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DailyLevelIndex { get => default; set {} } // 0x000000018490BDD0-0x000000018490BE70 0x0000000184909720-0x00000001849097C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerCurLevelRecord CurLevelRecord { get => default; set {} } // 0x000000018490A650-0x000000018490A6F0 0x000000018490CEB0-0x000000018490CF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextScheduleChangeTime { get => default; set {} } // 0x0000000184909960-0x0000000184909A00 0x000000018490C640-0x000000018490C6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> FloorOpenTimeMap { get => default; } // 0x000000018490A060-0x000000018490A0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFirstInteract { get => default; set {} } // 0x0000000184909F10-0x0000000184909FB0 0x000000018490C040-0x000000018490C0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyBrief MonthlyBrief { get => default; set {} } // 0x000000018490B420-0x000000018490B4C0 0x0000000184909680-0x0000000184909720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkipToFloorIndex { get => default; set {} } // 0x000000018490C3C0-0x000000018490C460 0x000000018490BFA0-0x000000018490C040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CommemorativeRewardId { get => default; set {} } // 0x000000018490D040-0x000000018490D0E0 0x000000018490BF00-0x000000018490BFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SkipFloorGrantedRewardItemMap { get => default; } // 0x000000018490C0E0-0x000000018490C140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ValidTowerRecordNum { get => default; set {} } // 0x000000018490B520-0x000000018490B5C0 0x0000000184909820-0x00000001849098C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018490B380-0x000000018490B420 0x000000018490A5B0-0x000000018490A650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFinishedEntranceFloor { get => default; set {} } // 0x00000001849098C0-0x0000000184909960 0x0000000184909A00-0x0000000184909AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleStartTime { get => default; set {} } // 0x000000018490C8A0-0x000000018490C940 0x000000018490B2E0-0x000000018490B380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerMonthlyBrief LastScheduleMonthlyBrief { get => default; set {} } // 0x000000018490A510-0x000000018490A5B0 0x000000018490C7A0-0x000000018490C840

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25720
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25721
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2409
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerAllDataRsp() {} // 0x000000018490DC40-0x000000018490DD10
	static TowerAllDataRsp() {} // 0x000000018490DA60-0x000000018490DC40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerAllDataRsp Clone() => default; // 0x000000018490C230-0x000000018490C320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerAllDataRsp ShallowCopy() => default; // 0x000000018490B640-0x000000018490B6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184909FB0-0x000000018490A060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018490C580-0x000000018490C640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018490C6E0-0x000000018490C7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018490A0C0-0x000000018490A510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018490AA60-0x000000018490AB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerAllDataRsp other) => default; // 0x000000018490A6F0-0x000000018490AA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018490B7D0-0x000000018490BD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018490D0E0-0x000000018490DA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018490C940-0x000000018490CE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018490AB30-0x000000018490B1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerAllDataRsp other) {} // 0x0000000184909AA0-0x0000000184909F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184909210-0x0000000184909680
}

