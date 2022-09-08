/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlossomBriefInfo : MessageBase, IMessage<BlossomBriefInfo> // TypeDefIndex: 22592
{
	// Fields
	private static readonly MessageParser<BlossomBriefInfo> _parser; // 0x00
	public const int RefreshIdFieldNumber = 1; // Metadata: 0x00B01F0B
	private uint refreshId_; // 0x18
	public const int CircleCampIdFieldNumber = 2; // Metadata: 0x00B01F0F
	private uint circleCampId_; // 0x1C
	public const int CityIdFieldNumber = 3; // Metadata: 0x00B01F13
	private uint cityId_; // 0x20
	public const int ResinFieldNumber = 4; // Metadata: 0x00B01F17
	private uint resin_; // 0x24
	public const int PosFieldNumber = 5; // Metadata: 0x00B01F1B
	private Vector pos_; // 0x28
	public const int RewardIdFieldNumber = 6; // Metadata: 0x00B01F1F
	private uint rewardId_; // 0x30
	public const int MonsterLevelFieldNumber = 7; // Metadata: 0x00B01F23
	private uint monsterLevel_; // 0x34
	public const int IsGuideOpenedFieldNumber = 8; // Metadata: 0x00B01F27
	private bool isGuideOpened_; // 0x38
	public const int StateFieldNumber = 9; // Metadata: 0x00B01F2B
	private uint state_; // 0x3C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlossomBriefInfo> Parser { get => default; } // 0x0000000181D9F880-0x0000000181D9F910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D9F2F0-0x0000000181D9F380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D9ECF0-0x0000000181D9ED70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D9DE00-0x0000000181D9DE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181DA00A0-0x0000000181DA0190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D9FC80-0x0000000181D9FCE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D9F420-0x0000000181D9F510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181DA0050-0x0000000181DA00A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D9EEB0-0x0000000181D9EFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RefreshId { get => default; set {} } // 0x0000000181D9DE60-0x0000000181D9DF00 0x0000000181D9F7E0-0x0000000181D9F880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CircleCampId { get => default; set {} } // 0x0000000181D9F250-0x0000000181D9F2F0 0x0000000181DA0190-0x0000000181DA0230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CityId { get => default; set {} } // 0x0000000181D9E230-0x0000000181D9E2D0 0x0000000181D9F9A0-0x0000000181D9FA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Resin { get => default; set {} } // 0x0000000181D9E4E0-0x0000000181D9E580 0x0000000181D9DF00-0x0000000181D9DFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000181D9FB40-0x0000000181D9FBE0 0x0000000181D9FFB0-0x0000000181DA0050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x0000000181D9FBE0-0x0000000181D9FC80 0x0000000181D9F600-0x0000000181D9F6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MonsterLevel { get => default; set {} } // 0x0000000181D9F740-0x0000000181D9F7E0 0x0000000181D9EE10-0x0000000181D9EEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsGuideOpened { get => default; set {} } // 0x0000000181D9F6A0-0x0000000181D9F740 0x0000000181D9F380-0x0000000181D9F420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint State { get => default; set {} } // 0x0000000181D9EBB0-0x0000000181D9EC50 0x0000000181D9EC50-0x0000000181D9ECF0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomBriefInfo() {} // 0x0000000181DA08B0-0x0000000181DA0910
	static BlossomBriefInfo() {} // 0x0000000181DA07F0-0x0000000181DA08B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomBriefInfo Clone() => default; // 0x0000000181D9F510-0x0000000181D9F600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomBriefInfo ShallowCopy() => default; // 0x0000000181D9ED70-0x0000000181D9EE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D9E2D0-0x0000000181D9E350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D9FA40-0x0000000181D9FAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D9FAC0-0x0000000181D9FB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D9E350-0x0000000181D9E4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D9E580-0x0000000181D9E650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlossomBriefInfo other) => default; // 0x0000000181D9E650-0x0000000181D9E850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D9EFA0-0x0000000181D9F250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181DA0230-0x0000000181DA07F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D9FCE0-0x0000000181D9FFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D9E850-0x0000000181D9EBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlossomBriefInfo other) {} // 0x0000000181D9DFA0-0x0000000181D9E230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D9DBF0-0x0000000181D9DE00
}

