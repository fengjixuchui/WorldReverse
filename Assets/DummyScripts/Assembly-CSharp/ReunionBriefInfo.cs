/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReunionBriefInfo : MessageBase, IMessage<ReunionBriefInfo> // TypeDefIndex: 24806
{
	// Fields
	private static readonly MessageParser<ReunionBriefInfo> _parser; // 0x00
	public const int FinishTimeFieldNumber = 1; // Metadata: 0x00B0748F
	private uint finishTime_; // 0x18
	public const int IsTakenFirstGiftFieldNumber = 2; // Metadata: 0x00B07493
	private bool isTakenFirstGift_; // 0x1C
	public const int FirstGiftRewardIdFieldNumber = 3; // Metadata: 0x00B07497
	private uint firstGiftRewardId_; // 0x20
	public const int SignInConfigIdFieldNumber = 4; // Metadata: 0x00B0749B
	private uint signInConfigId_; // 0x24
	public const int SignInHasRewardFieldNumber = 5; // Metadata: 0x00B0749F
	private bool signInHasReward_; // 0x28
	public const int MissionIdFieldNumber = 6; // Metadata: 0x00B074A3
	private uint missionId_; // 0x2C
	public const int MissionHasRewardFieldNumber = 7; // Metadata: 0x00B074A7
	private bool missionHasReward_; // 0x30
	public const int PrivilegeIdFieldNumber = 8; // Metadata: 0x00B074AB
	private uint privilegeId_; // 0x34
	public const int VersionFieldNumber = 9; // Metadata: 0x00B074AF
	private string version_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReunionBriefInfo> Parser { get => default; } // 0x0000000183E39050-0x0000000183E390E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183E38970-0x0000000183E38A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183E38320-0x0000000183E383A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183E37670-0x0000000183E376D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183E39790-0x0000000183E39880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183E39350-0x0000000183E393B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183E38BE0-0x0000000183E38CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183E39740-0x0000000183E39790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183E38580-0x0000000183E38670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishTime { get => default; set {} } // 0x0000000183E38E70-0x0000000183E38F10 0x0000000183E39170-0x0000000183E39210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsTakenFirstGift { get => default; set {} } // 0x0000000183E388D0-0x0000000183E38970 0x0000000183E38A00-0x0000000183E38AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FirstGiftRewardId { get => default; set {} } // 0x0000000183E383A0-0x0000000183E38440 0x0000000183E38F10-0x0000000183E38FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SignInConfigId { get => default; set {} } // 0x0000000183E376D0-0x0000000183E37770 0x0000000183E37CD0-0x0000000183E37D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool SignInHasReward { get => default; set {} } // 0x0000000183E39260-0x0000000183E39300 0x0000000183E37B10-0x0000000183E37BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MissionId { get => default; set {} } // 0x0000000183E37770-0x0000000183E37810 0x0000000183E38B40-0x0000000183E38BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool MissionHasReward { get => default; set {} } // 0x0000000183E396A0-0x0000000183E39740 0x0000000183E38FB0-0x0000000183E39050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PrivilegeId { get => default; set {} } // 0x0000000183E37810-0x0000000183E378B0 0x0000000183E38440-0x0000000183E384E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Version { get => default; set {} } // 0x0000000183E38AA0-0x0000000183E38B40 0x0000000183E38CD0-0x0000000183E38D80

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionBriefInfo() {} // 0x0000000183E39F00-0x0000000183E39F70
	static ReunionBriefInfo() {} // 0x0000000183E39E40-0x0000000183E39F00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionBriefInfo Clone() => default; // 0x0000000183E38D80-0x0000000183E38E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionBriefInfo ShallowCopy() => default; // 0x0000000183E384E0-0x0000000183E38580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183E37BB0-0x0000000183E37C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E39210-0x0000000183E39260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183E39300-0x0000000183E39350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183E37C00-0x0000000183E37CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183E37FA0-0x0000000183E38070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReunionBriefInfo other) => default; // 0x0000000183E37D70-0x0000000183E37FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183E38670-0x0000000183E388D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183E39880-0x0000000183E39E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183E393B0-0x0000000183E396A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183E38070-0x0000000183E38320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReunionBriefInfo other) {} // 0x0000000183E378B0-0x0000000183E37B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183E374A0-0x0000000183E37670
}

