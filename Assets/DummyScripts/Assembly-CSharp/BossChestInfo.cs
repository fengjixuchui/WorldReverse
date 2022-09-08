/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BossChestInfo : MessageBase, IMessage<BossChestInfo> // TypeDefIndex: 26031
{
	// Fields
	private static readonly MessageParser<BossChestInfo> _parser; // 0x00
	public const int MonsterConfigIdFieldNumber = 1; // Metadata: 0x00B0AC67
	private uint monsterConfigId_; // 0x18
	public const int ResinFieldNumber = 2; // Metadata: 0x00B0AC6B
	private uint resin_; // 0x1C
	public const int RemainUidListFieldNumber = 3; // Metadata: 0x00B0AC6F
	private static readonly FieldCodec<uint> _repeated_remainUidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> remainUidList_; // 0x20
	public const int QualifyUidListFieldNumber = 4; // Metadata: 0x00B0AC73
	private static readonly FieldCodec<uint> _repeated_qualifyUidList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> qualifyUidList_; // 0x28
	public const int UidDiscountMapFieldNumber = 5; // Metadata: 0x00B0AC77
	private static readonly MapField<uint, WeeklyBossResinDiscountInfo> _map_uidDiscountMap_codec; // 0x18
	private readonly MapField<uint, WeeklyBossResinDiscountInfo> uidDiscountMap_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BossChestInfo> Parser { get => default; } // 0x0000000183D099C0-0x0000000183D09A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D095F0-0x0000000183D09680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D091D0-0x0000000183D09250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D087A0-0x0000000183D08800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D09E10-0x0000000183D09F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D09B80-0x0000000183D09BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D09740-0x0000000183D09830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D09DC0-0x0000000183D09E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D092F0-0x0000000183D093E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MonsterConfigId { get => default; set {} } // 0x0000000183D09920-0x0000000183D099C0 0x0000000183D08800-0x0000000183D088A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Resin { get => default; set {} } // 0x0000000183D08CC0-0x0000000183D08D60 0x0000000183D088A0-0x0000000183D08940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> RemainUidList { get => default; } // 0x0000000183D09590-0x0000000183D095F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> QualifyUidList { get => default; } // 0x0000000183D09680-0x0000000183D096E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, WeeklyBossResinDiscountInfo> UidDiscountMap { get => default; } // 0x0000000183D096E0-0x0000000183D09740 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BossChestInfo() {} // 0x0000000183D0A3F0-0x0000000183D0A4C0
	static BossChestInfo() {} // 0x0000000183D0A250-0x0000000183D0A3F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BossChestInfo Clone() => default; // 0x0000000183D09830-0x0000000183D09920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BossChestInfo ShallowCopy() => default; // 0x0000000183D09250-0x0000000183D092F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D08AE0-0x0000000183D08B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D09AE0-0x0000000183D09B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D09B30-0x0000000183D09B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D08B30-0x0000000183D08CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D08F10-0x0000000183D08FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BossChestInfo other) => default; // 0x0000000183D08D60-0x0000000183D08F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D093E0-0x0000000183D09590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D09F00-0x0000000183D0A250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D09BE0-0x0000000183D09DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D08FE0-0x0000000183D091D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BossChestInfo other) {} // 0x0000000183D08940-0x0000000183D08AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D08530-0x0000000183D087A0
}

