/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InvestigationMonster : MessageBase, IMessage<InvestigationMonster> // TypeDefIndex: 23595
{
	// Fields
	private static readonly MessageParser<InvestigationMonster> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B045C7
	private uint id_; // 0x18
	public const int CityIdFieldNumber = 2; // Metadata: 0x00B045CB
	private uint cityId_; // 0x1C
	public const int LevelFieldNumber = 3; // Metadata: 0x00B045CF
	private uint level_; // 0x20
	public const int IsAliveFieldNumber = 4; // Metadata: 0x00B045D3
	private bool isAlive_; // 0x24
	public const int NextRefreshTimeFieldNumber = 5; // Metadata: 0x00B045D7
	private uint nextRefreshTime_; // 0x28
	public const int RefreshIntervalFieldNumber = 6; // Metadata: 0x00B045DB
	private uint refreshInterval_; // 0x2C
	public const int PosFieldNumber = 7; // Metadata: 0x00B045DF
	private Vector pos_; // 0x30
	public const int LockStateFieldNumber = 8; // Metadata: 0x00B045E3
	private Types.LockState lockState_; // 0x38
	public const int MaxBossChestNumFieldNumber = 9; // Metadata: 0x00B045E7
	private uint maxBossChestNum_; // 0x3C
	public const int BossChestNumFieldNumber = 10; // Metadata: 0x00B045EB
	private uint bossChestNum_; // 0x40
	public const int ResinFieldNumber = 11; // Metadata: 0x00B045EF
	private uint resin_; // 0x44
	public const int IsAreaLockedFieldNumber = 12; // Metadata: 0x00B045F3
	private bool isAreaLocked_; // 0x48
	public const int NextBossChestRefreshTimeFieldNumber = 13; // Metadata: 0x00B045F7
	private uint nextBossChestRefreshTime_; // 0x4C
	public const int WeeklyBossResinDiscountInfoFieldNumber = 14; // Metadata: 0x00B045FB
	private WeeklyBossResinDiscountInfo weeklyBossResinDiscountInfo_; // 0x50

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InvestigationMonster> Parser { get => default; } // 0x0000000182624910-0x00000001826249A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182624240-0x00000001826242D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182623AC0-0x0000000182623B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182622640-0x00000001826226A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182625650-0x0000000182625740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182624FB0-0x0000000182625010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001826244B0-0x00000001826245A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182625560-0x00000001826255B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182623D20-0x0000000182623E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x0000000182623A20-0x0000000182623AC0 0x00000001826249A0-0x0000000182624A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000182622AE0-0x0000000182622B80 0x0000000182624AD0-0x0000000182624B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000182622B80-0x0000000182622C20 0x0000000182623C80-0x0000000182623D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAlive { get => default; set {} } // 0x0000000182622FD0-0x0000000182623070 0x0000000182624E70-0x0000000182624F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextRefreshTime { get => default; set {} } // 0x00000001826247D0-0x0000000182624870 0x0000000182625740-0x00000001826257E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RefreshInterval { get => default; set {} } // 0x00000001826242D0-0x0000000182624370 0x0000000182623110-0x00000001826231B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000182624DD0-0x0000000182624E70 0x0000000182625420-0x00000001826254C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.LockState LockState { get => default; set {} } // 0x0000000182624690-0x0000000182624730 0x0000000182624B70-0x0000000182624C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxBossChestNum { get => default; set {} } // 0x0000000182623B40-0x0000000182623BE0 0x00000001826255B0-0x0000000182625650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BossChestNum { get => default; set {} } // 0x0000000182624410-0x00000001826244B0 0x00000001826254C0-0x0000000182625560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Resin { get => default; set {} } // 0x0000000182622F30-0x0000000182622FD0 0x00000001826226A0-0x0000000182622740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAreaLocked { get => default; set {} } // 0x0000000182624870-0x0000000182624910 0x0000000182624730-0x00000001826247D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextBossChestRefreshTime { get => default; set {} } // 0x0000000182624F10-0x0000000182624FB0 0x0000000182624370-0x0000000182624410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WeeklyBossResinDiscountInfo WeeklyBossResinDiscountInfo { get => default; set {} } // 0x0000000182623070-0x0000000182623110 0x0000000182624C10-0x0000000182624CB0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23596
	{
		// Nested types
		public enum LockState // TypeDefIndex: 23597
		{
			LockNone = 0,
			LockQuest = 1
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InvestigationMonster() {} // 0x00000001826260E0-0x0000000182626150
	static InvestigationMonster() {} // 0x0000000182626020-0x00000001826260E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InvestigationMonster Clone() => default; // 0x00000001826245A0-0x0000000182624690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InvestigationMonster ShallowCopy() => default; // 0x0000000182623BE0-0x0000000182623C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182622C20-0x0000000182622CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182624CB0-0x0000000182624D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182624D40-0x0000000182624DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182622CB0-0x0000000182622F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001826231B0-0x0000000182623280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InvestigationMonster other) => default; // 0x0000000182623280-0x0000000182623530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182623E10-0x0000000182624240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001826257E0-0x0000000182626020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182625010-0x0000000182625420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182623530-0x0000000182623A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InvestigationMonster other) {} // 0x0000000182622740-0x0000000182622AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182622350-0x0000000182622640
}

