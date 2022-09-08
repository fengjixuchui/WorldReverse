/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CityReputationHuntInfo : MessageBase, IMessage<CityReputationHuntInfo> // TypeDefIndex: 24751
{
	// Fields
	private static readonly MessageParser<CityReputationHuntInfo> _parser; // 0x00
	public const int IsOpenFieldNumber = 1; // Metadata: 0x00B07257
	private bool isOpen_; // 0x18
	public const int HasRewardFieldNumber = 2; // Metadata: 0x00B0725B
	private bool hasReward_; // 0x19
	public const int CurWeekFinishNumFieldNumber = 3; // Metadata: 0x00B0725F
	private uint curWeekFinishNum_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CityReputationHuntInfo> Parser { get => default; } // 0x000000018550DDF0-0x000000018550DE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018550DA40-0x000000018550DAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018550D6F0-0x000000018550D770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018550D0A0-0x000000018550D100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018550E300-0x000000018550E3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018550E050-0x000000018550E0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018550DB70-0x000000018550DC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018550E2B0-0x000000018550E300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018550D810-0x000000018550D900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x000000018550E0B0-0x000000018550E150 0x000000018550D100-0x000000018550D1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool HasReward { get => default; set {} } // 0x000000018550DD50-0x000000018550DDF0 0x000000018550D000-0x000000018550D0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurWeekFinishNum { get => default; set {} } // 0x000000018550DFB0-0x000000018550E050 0x000000018550DAD0-0x000000018550DB70

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationHuntInfo() {} // 0x000000018550E740-0x000000018550E7A0
	static CityReputationHuntInfo() {} // 0x000000018550E680-0x000000018550E740

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationHuntInfo Clone() => default; // 0x000000018550DC60-0x000000018550DD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationHuntInfo ShallowCopy() => default; // 0x000000018550D770-0x000000018550D810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018550D300-0x000000018550D350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018550DF10-0x000000018550DF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018550DF60-0x000000018550DFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018550D350-0x000000018550D3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018550D510-0x000000018550D5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CityReputationHuntInfo other) => default; // 0x000000018550D3D0-0x000000018550D510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018550D900-0x000000018550DA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018550E3F0-0x000000018550E680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018550E150-0x000000018550E2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018550D5E0-0x000000018550D6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CityReputationHuntInfo other) {} // 0x000000018550D1A0-0x000000018550D300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018550CEF0-0x000000018550D000
}

