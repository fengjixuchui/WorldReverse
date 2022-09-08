/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TreasureMapRegionInfo : MessageBase, IMessage<TreasureMapRegionInfo> // TypeDefIndex: 22095
{
	// Fields
	private static readonly MessageParser<TreasureMapRegionInfo> _parser; // 0x00
	public const int RegionIdFieldNumber = 1; // Metadata: 0x00B00C7F
	private uint regionId_; // 0x18
	public const int StartTimeFieldNumber = 3; // Metadata: 0x00B00C83
	private uint startTime_; // 0x1C
	public const int RegionCenterPosFieldNumber = 4; // Metadata: 0x00B00C87
	private Vector regionCenterPos_; // 0x20
	public const int RegionRadiusFieldNumber = 5; // Metadata: 0x00B00C8B
	private uint regionRadius_; // 0x28
	public const int CurrentProgressFieldNumber = 6; // Metadata: 0x00B00C8F
	private uint currentProgress_; // 0x2C
	public const int GoalPointsFieldNumber = 7; // Metadata: 0x00B00C93
	private uint goalPoints_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TreasureMapRegionInfo> Parser { get => default; } // 0x0000000183D07670-0x0000000183D07700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D07220-0x0000000183D072B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D06D30-0x0000000183D06DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D062F0-0x0000000183D06350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D07DD0-0x0000000183D07EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D079D0-0x0000000183D07A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D07490-0x0000000183D07580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D07D80-0x0000000183D07DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D06E50-0x0000000183D06F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RegionId { get => default; set {} } // 0x0000000183D07CE0-0x0000000183D07D80 0x0000000183D07180-0x0000000183D07220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartTime { get => default; set {} } // 0x0000000183D07EC0-0x0000000183D07F60 0x0000000183D07350-0x0000000183D073F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector RegionCenterPos { get => default; set {} } // 0x0000000183D07F60-0x0000000183D08000 0x0000000183D07930-0x0000000183D079D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RegionRadius { get => default; set {} } // 0x0000000183D06750-0x0000000183D067F0 0x0000000183D06250-0x0000000183D062F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurrentProgress { get => default; set {} } // 0x0000000183D072B0-0x0000000183D07350 0x0000000183D073F0-0x0000000183D07490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GoalPoints { get => default; set {} } // 0x0000000183D07890-0x0000000183D07930 0x0000000183D07A30-0x0000000183D07AD0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapRegionInfo() {} // 0x0000000183D084D0-0x0000000183D08530
	static TreasureMapRegionInfo() {} // 0x0000000183D08410-0x0000000183D084D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapRegionInfo Clone() => default; // 0x0000000183D07580-0x0000000183D07670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapRegionInfo ShallowCopy() => default; // 0x0000000183D06DB0-0x0000000183D06E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D06570-0x0000000183D065F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D07790-0x0000000183D07810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D07810-0x0000000183D07890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D065F0-0x0000000183D06750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D069A0-0x0000000183D06A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TreasureMapRegionInfo other) => default; // 0x0000000183D067F0-0x0000000183D069A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D06F40-0x0000000183D07180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D08000-0x0000000183D08410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D07AD0-0x0000000183D07CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D06A70-0x0000000183D06D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TreasureMapRegionInfo other) {} // 0x0000000183D06350-0x0000000183D06570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D060A0-0x0000000183D06250
}

