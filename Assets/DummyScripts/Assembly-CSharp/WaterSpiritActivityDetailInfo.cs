/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WaterSpiritActivityDetailInfo : MessageBase, IMessage<WaterSpiritActivityDetailInfo> // TypeDefIndex: 22204
{
	// Fields
	private static readonly MessageParser<WaterSpiritActivityDetailInfo> _parser; // 0x00
	public const int RegionSearchIdFieldNumber = 1; // Metadata: 0x00B01087
	private uint regionSearchId_; // 0x18
	public const int MpPlayIdFieldNumber = 2; // Metadata: 0x00B0108B
	private uint mpPlayId_; // 0x1C
	public const int SearchTimeMapFieldNumber = 3; // Metadata: 0x00B0108F
	private static readonly MapField<uint, uint> _map_searchTimeMap_codec; // 0x08
	private readonly MapField<uint, uint> searchTimeMap_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WaterSpiritActivityDetailInfo> Parser { get => default; } // 0x0000000182771610-0x00000001827716A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001827713A0-0x0000000182771430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182770F30-0x0000000182770FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001827706B0-0x0000000182770710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001827719F0-0x0000000182771AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001827717D0-0x0000000182771830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182771430-0x0000000182771520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001827719A0-0x00000001827719F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182771050-0x0000000182771140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RegionSearchId { get => default; set {} } // 0x0000000182770710-0x00000001827707B0 0x0000000182770910-0x00000001827709B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x00000001827712A0-0x0000000182771340 0x0000000182770AD0-0x0000000182770B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> SearchTimeMap { get => default; } // 0x0000000182771340-0x00000001827713A0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WaterSpiritActivityDetailInfo() {} // 0x0000000182771E80-0x0000000182771F10
	static WaterSpiritActivityDetailInfo() {} // 0x0000000182771D50-0x0000000182771E80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WaterSpiritActivityDetailInfo Clone() => default; // 0x0000000182771520-0x0000000182771610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WaterSpiritActivityDetailInfo ShallowCopy() => default; // 0x0000000182770FB0-0x0000000182771050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001827709B0-0x0000000182770A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182771730-0x0000000182771780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182771780-0x00000001827717D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182770A00-0x0000000182770AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182770CD0-0x0000000182770DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WaterSpiritActivityDetailInfo other) => default; // 0x0000000182770B70-0x0000000182770CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182771140-0x00000001827712A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182771AE0-0x0000000182771D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182771830-0x00000001827719A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182770DA0-0x0000000182770F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WaterSpiritActivityDetailInfo other) {} // 0x00000001827707B0-0x0000000182770910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182770530-0x00000001827706B0
}

