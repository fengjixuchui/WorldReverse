/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GachaInfo : MessageBase, IMessage<GachaInfo> // TypeDefIndex: 23160
{
	// Fields
	private static readonly MessageParser<GachaInfo> _parser; // 0x00
	public const int GachaTypeFieldNumber = 1; // Metadata: 0x00B0352F
	private uint gachaType_; // 0x18
	public const int ScheduleIdFieldNumber = 2; // Metadata: 0x00B03533
	private uint scheduleId_; // 0x1C
	public const int BeginTimeFieldNumber = 3; // Metadata: 0x00B03537
	private uint beginTime_; // 0x20
	public const int EndTimeFieldNumber = 4; // Metadata: 0x00B0353B
	private uint endTime_; // 0x24
	public const int CostItemIdFieldNumber = 5; // Metadata: 0x00B0353F
	private uint costItemId_; // 0x28
	public const int CostItemNumFieldNumber = 6; // Metadata: 0x00B03543
	private uint costItemNum_; // 0x2C
	public const int GachaPrefabPathFieldNumber = 7; // Metadata: 0x00B03547
	private string gachaPrefabPath_; // 0x30
	public const int GachaProbUrlFieldNumber = 8; // Metadata: 0x00B0354B
	private string gachaProbUrl_; // 0x38
	public const int GachaRecordUrlFieldNumber = 9; // Metadata: 0x00B0354F
	private string gachaRecordUrl_; // 0x40
	public const int GachaPreviewPrefabPathFieldNumber = 10; // Metadata: 0x00B03553
	private string gachaPreviewPrefabPath_; // 0x48
	public const int TenCostItemIdFieldNumber = 11; // Metadata: 0x00B03557
	private uint tenCostItemId_; // 0x50
	public const int TenCostItemNumFieldNumber = 12; // Metadata: 0x00B0355B
	private uint tenCostItemNum_; // 0x54
	public const int LeftGachaTimesFieldNumber = 13; // Metadata: 0x00B0355F
	private uint leftGachaTimes_; // 0x58
	public const int GachaTimesLimitFieldNumber = 14; // Metadata: 0x00B03563
	private uint gachaTimesLimit_; // 0x5C
	public const int GachaSortIdFieldNumber = 15; // Metadata: 0x00B03567
	private uint gachaSortId_; // 0x60
	public const int GachaProbUrlOverseaFieldNumber = 16; // Metadata: 0x00B0356B
	private string gachaProbUrlOversea_; // 0x68
	public const int GachaRecordUrlOverseaFieldNumber = 17; // Metadata: 0x00B0356F
	private string gachaRecordUrlOversea_; // 0x70
	public const int GachaUpInfoListFieldNumber = 18; // Metadata: 0x00B03573
	private static readonly FieldCodec<GachaUpInfo> _repeated_gachaUpInfoList_codec; // 0x08
	private readonly RepeatedMessageField<GachaUpInfo> gachaUpInfoList_; // 0x78

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GachaInfo> Parser { get => default; } // 0x0000000184760690-0x0000000184760720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018475FFF0-0x0000000184760080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018475F4C0-0x000000018475F540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018475DC30-0x000000018475DC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001847615B0-0x00000001847616A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184760D50-0x0000000184760DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184760220-0x0000000184760310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184761560-0x00000001847615B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018475F730-0x000000018475F820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GachaType { get => default; set {} } // 0x0000000184760E50-0x0000000184760EF0 0x000000018475FF50-0x000000018475FFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x000000018475E4E0-0x000000018475E580 0x0000000184760DB0-0x0000000184760E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x00000001847614C0-0x0000000184761560 0x0000000184760B70-0x0000000184760C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x0000000184760550-0x00000001847605F0 0x0000000184760C10-0x0000000184760CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CostItemId { get => default; set {} } // 0x000000018475DC90-0x000000018475DD30 0x000000018475E620-0x000000018475E6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CostItemNum { get => default; set {} } // 0x0000000184760CB0-0x0000000184760D50 0x000000018475E800-0x000000018475E8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GachaPrefabPath { get => default; set {} } // 0x00000001847605F0-0x0000000184760690 0x00000001847607C0-0x0000000184760870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GachaProbUrl { get => default; set {} } // 0x00000001847603C0-0x0000000184760460 0x000000018475F680-0x000000018475F730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GachaRecordUrl { get => default; set {} } // 0x000000018475F5E0-0x000000018475F680 0x00000001847616A0-0x0000000184761750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GachaPreviewPrefabPath { get => default; set {} } // 0x0000000184760080-0x0000000184760120 0x0000000184760310-0x00000001847603C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TenCostItemId { get => default; set {} } // 0x000000018475E270-0x000000018475E310 0x0000000184760720-0x00000001847607C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TenCostItemNum { get => default; set {} } // 0x000000018475E6C0-0x000000018475E760 0x000000018475DD30-0x000000018475DDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LeftGachaTimes { get => default; set {} } // 0x0000000184760AD0-0x0000000184760B70 0x000000018475F420-0x000000018475F4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GachaTimesLimit { get => default; set {} } // 0x0000000184760180-0x0000000184760220 0x000000018475E760-0x000000018475E800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GachaSortId { get => default; set {} } // 0x000000018475FCC0-0x000000018475FD60 0x000000018475FD60-0x000000018475FE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GachaProbUrlOversea { get => default; set {} } // 0x000000018475E580-0x000000018475E620 0x0000000184760990-0x0000000184760A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string GachaRecordUrlOversea { get => default; set {} } // 0x000000018475FEB0-0x000000018475FF50 0x000000018475FE00-0x000000018475FEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<GachaUpInfo> GachaUpInfoList { get => default; } // 0x0000000184760120-0x0000000184760180 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GachaInfo() {} // 0x0000000184762250-0x0000000184762320
	static GachaInfo() {} // 0x0000000184762140-0x0000000184762250

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GachaInfo Clone() => default; // 0x0000000184760460-0x0000000184760550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GachaInfo ShallowCopy() => default; // 0x000000018475F540-0x000000018475F5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018475E220-0x000000018475E270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184760900-0x0000000184760990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184760A40-0x0000000184760AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018475E310-0x000000018475E4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018475ECE0-0x000000018475EDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GachaInfo other) => default; // 0x000000018475E8A0-0x000000018475ECE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018475F820-0x000000018475FCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184761750-0x0000000184762140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184760EF0-0x00000001847614C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018475EDB0-0x000000018475F420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GachaInfo other) {} // 0x000000018475DDD0-0x000000018475E220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018475D8B0-0x000000018475DC30
}

