/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DoGachaRsp : MessageBase, IMessage<DoGachaRsp> // TypeDefIndex: 23169
{
	// Fields
	private static readonly MessageParser<DoGachaRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B035D7
	private int retcode_; // 0x18
	public const int GachaTypeFieldNumber = 2; // Metadata: 0x00B035DB
	private uint gachaType_; // 0x1C
	public const int GachaTimesFieldNumber = 3; // Metadata: 0x00B035DF
	private uint gachaTimes_; // 0x20
	public const int GachaScheduleIdFieldNumber = 4; // Metadata: 0x00B035E3
	private uint gachaScheduleId_; // 0x24
	public const int GachaItemListFieldNumber = 5; // Metadata: 0x00B035E7
	private static readonly FieldCodec<GachaItem> _repeated_gachaItemList_codec; // 0x08
	private readonly RepeatedMessageField<GachaItem> gachaItemList_; // 0x28
	public const int NewGachaRandomFieldNumber = 6; // Metadata: 0x00B035EB
	private uint newGachaRandom_; // 0x30
	public const int CostItemIdFieldNumber = 7; // Metadata: 0x00B035EF
	private uint costItemId_; // 0x34
	public const int CostItemNumFieldNumber = 8; // Metadata: 0x00B035F3
	private uint costItemNum_; // 0x38
	public const int TenCostItemIdFieldNumber = 9; // Metadata: 0x00B035F7
	private uint tenCostItemId_; // 0x3C
	public const int TenCostItemNumFieldNumber = 10; // Metadata: 0x00B035FB
	private uint tenCostItemNum_; // 0x40
	public const int LeftGachaTimesFieldNumber = 11; // Metadata: 0x00B035FF
	private uint leftGachaTimes_; // 0x44
	public const int GachaTimesLimitFieldNumber = 12; // Metadata: 0x00B03603
	private uint gachaTimesLimit_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DoGachaRsp> Parser { get => default; } // 0x0000000182051300-0x0000000182051390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182050DB0-0x0000000182050E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182050860-0x00000001820508E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018204F400-0x000000018204F460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182051C30-0x0000000182051D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182051720-0x0000000182051780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001820510C0-0x00000001820511B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182051BE0-0x0000000182051C30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182050980-0x0000000182050A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182050720-0x00000001820507C0 0x000000018204FDF0-0x000000018204FE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GachaType { get => default; set {} } // 0x0000000182051780-0x0000000182051820 0x0000000182050D10-0x0000000182050DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GachaTimes { get => default; set {} } // 0x000000018204F5A0-0x000000018204F640 0x000000018204FCB0-0x000000018204FD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GachaScheduleId { get => default; set {} } // 0x0000000182050F80-0x0000000182051020 0x0000000182050EE0-0x0000000182050F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<GachaItem> GachaItemList { get => default; } // 0x00000001820512A0-0x0000000182051300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NewGachaRandom { get => default; set {} } // 0x0000000182050E40-0x0000000182050EE0 0x000000018204F460-0x000000018204F500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CostItemId { get => default; set {} } // 0x000000018204F500-0x000000018204F5A0 0x000000018204FC10-0x000000018204FCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CostItemNum { get => default; set {} } // 0x0000000182051680-0x0000000182051720 0x000000018204FF30-0x000000018204FFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TenCostItemId { get => default; set {} } // 0x000000018204FA10-0x000000018204FAB0 0x0000000182051390-0x0000000182051430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TenCostItemNum { get => default; set {} } // 0x000000018204FD50-0x000000018204FDF0 0x000000018204F640-0x000000018204F6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LeftGachaTimes { get => default; set {} } // 0x00000001820515E0-0x0000000182051680 0x00000001820507C0-0x0000000182050860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GachaTimesLimit { get => default; set {} } // 0x0000000182051020-0x00000001820510C0 0x000000018204FE90-0x000000018204FF30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23170
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23171
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1504
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DoGachaRsp() {} // 0x0000000182052570-0x0000000182052600
	static DoGachaRsp() {} // 0x0000000182052460-0x0000000182052570

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DoGachaRsp Clone() => default; // 0x00000001820511B0-0x00000001820512A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DoGachaRsp ShallowCopy() => default; // 0x00000001820508E0-0x0000000182050980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018204F9C0-0x000000018204FA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820514C0-0x0000000182051550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182051550-0x00000001820515E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018204FAB0-0x000000018204FC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018204FFD0-0x00000001820500A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DoGachaRsp other) => default; // 0x00000001820500A0-0x0000000182050300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182050A70-0x0000000182050D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182051D20-0x0000000182052460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182051820-0x0000000182051BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182050300-0x0000000182050720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DoGachaRsp other) {} // 0x000000018204F6E0-0x000000018204F9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018204F170-0x000000018204F400
}

