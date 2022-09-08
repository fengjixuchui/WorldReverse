/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MultistagePlayInfo : MessageBase, IMessage<MultistagePlayInfo> // TypeDefIndex: 24112
{
	// Fields
	private static readonly MessageParser<MultistagePlayInfo> _parser; // 0x00
	public const int PlayIndexFieldNumber = 1; // Metadata: 0x00B059CB
	private uint playIndex_; // 0x18
	public const int GroupIdFieldNumber = 2; // Metadata: 0x00B059CF
	private uint groupId_; // 0x1C
	public const int StageIndexFieldNumber = 3; // Metadata: 0x00B059D3
	private uint stageIndex_; // 0x20
	public const int StageTypeFieldNumber = 4; // Metadata: 0x00B059D7
	private uint stageType_; // 0x24
	public const int BeginTimeFieldNumber = 5; // Metadata: 0x00B059DB
	private uint beginTime_; // 0x28
	public const int DurationFieldNumber = 6; // Metadata: 0x00B059DF
	private uint duration_; // 0x2C
	public const int PlayTypeFieldNumber = 7; // Metadata: 0x00B059E3
	private uint playType_; // 0x30
	public const int MechanicusInfoFieldNumber = 101; // Metadata: 0x00B059E7
	public const int FleurFairInfoFieldNumber = 102; // Metadata: 0x00B059EB
	public const int HideAndSeekInfoFieldNumber = 103; // Metadata: 0x00B059EF
	private object detail_; // 0x38
	private DetailOneofCase detailCase_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MultistagePlayInfo> Parser { get => default; } // 0x0000000183640F10-0x0000000183640FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836408B0-0x0000000183640940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001836402C0-0x0000000183640340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018363EF70-0x000000018363EFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183641950-0x0000000183641A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183641450-0x00000001836414B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183640B50-0x0000000183640C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183641900-0x0000000183641950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001836403E0-0x00000001836404D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayIndex { get => default; set {} } // 0x0000000183640180-0x0000000183640220 0x0000000183640940-0x00000001836409E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x0000000183640C40-0x0000000183640CE0 0x0000000183640220-0x00000001836402C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StageIndex { get => default; set {} } // 0x000000018363EB80-0x000000018363EC20 0x00000001836413B0-0x0000000183641450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StageType { get => default; set {} } // 0x000000018363F0D0-0x000000018363F170 0x0000000183640740-0x00000001836407E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x0000000183641860-0x0000000183641900 0x0000000183641310-0x00000001836413B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Duration { get => default; set {} } // 0x0000000183641A40-0x0000000183641AE0 0x000000018363EFD0-0x000000018363F070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayType { get => default; set {} } // 0x00000001836414B0-0x0000000183641550 0x000000018363F6F0-0x000000018363F790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusInfo MechanicusInfo { get => default; set {} } // 0x0000000183640A80-0x0000000183640B50 0x00000001836409E0-0x0000000183640A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleFleurFairInfo FleurFairInfo { get => default; set {} } // 0x00000001836407E0-0x00000001836408B0 0x0000000183640E70-0x0000000183640F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HideAndSeekStageInfo HideAndSeekInfo { get => default; set {} } // 0x00000001836400B0-0x0000000183640180 0x0000000183640DD0-0x0000000183640E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DetailOneofCase DetailCase { get => default; } // 0x000000018363F5D0-0x000000018363F630 

	// Nested types
	public enum DetailOneofCase // TypeDefIndex: 24113
	{
		None = 0,
		MechanicusInfo = 101,
		FleurFairInfo = 102,
		HideAndSeekInfo = 103
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayInfo() {} // 0x00000001836422E0-0x0000000183642350
	static MultistagePlayInfo() {} // 0x0000000183642220-0x00000001836422E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayInfo Clone() => default; // 0x0000000183640CE0-0x0000000183640DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MultistagePlayInfo ShallowCopy() => default; // 0x0000000183640340-0x00000001836403E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018363F450-0x000000018363F5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183641030-0x00000001836411A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836411A0-0x0000000183641310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018363F630-0x000000018363F6F0
	public void resetDetail() {} // 0x000000018363FE30-0x00000001836400B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDetail() {} // 0x000000018363F070-0x000000018363F0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018363F9F0-0x000000018363FAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MultistagePlayInfo other) => default; // 0x000000018363F790-0x000000018363F9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001836404D0-0x0000000183640740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183641AE0-0x0000000183642220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183641550-0x0000000183641860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018363FAC0-0x000000018363FE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MultistagePlayInfo other) {} // 0x000000018363F170-0x000000018363F450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018363EC20-0x000000018363EF70
}

