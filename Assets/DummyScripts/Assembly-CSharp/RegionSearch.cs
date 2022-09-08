/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RegionSearch : MessageBase, IMessage<RegionSearch> // TypeDefIndex: 24725
{
	// Fields
	private static readonly MessageParser<RegionSearch> _parser; // 0x00
	public const int RegionSearchIdFieldNumber = 1; // Metadata: 0x00B07163
	private uint regionSearchId_; // 0x18
	public const int StateFieldNumber = 2; // Metadata: 0x00B07167
	private RegionSearchState state_; // 0x1C
	public const int ProgressFieldNumber = 3; // Metadata: 0x00B0716B
	private uint progress_; // 0x20
	public const int IsEnteredFieldNumber = 4; // Metadata: 0x00B0716F
	private bool isEntered_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RegionSearch> Parser { get => default; } // 0x000000018280A830-0x000000018280A8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018280A480-0x000000018280A510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182809F90-0x000000018280A010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182809690-0x00000001828096F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018280AC40-0x000000018280AD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018280A9F0-0x000000018280AA50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018280A650-0x000000018280A740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018280ABF0-0x000000018280AC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018280A1F0-0x000000018280A2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RegionSearchId { get => default; set {} } // 0x00000001828096F0-0x0000000182809790 0x0000000182809910-0x00000001828099B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearchState State { get => default; set {} } // 0x0000000182809E50-0x0000000182809EF0 0x0000000182809EF0-0x0000000182809F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Progress { get => default; set {} } // 0x000000018280A510-0x000000018280A5B0 0x000000018280A150-0x000000018280A1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsEntered { get => default; set {} } // 0x000000018280A5B0-0x000000018280A650 0x000000018280A0B0-0x000000018280A150

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearch() {} // 0x000000018280B110-0x000000018280B180
	static RegionSearch() {} // 0x000000018280B050-0x000000018280B110

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearch Clone() => default; // 0x000000018280A740-0x000000018280A830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RegionSearch ShallowCopy() => default; // 0x000000018280A010-0x000000018280A0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001828099B0-0x0000000182809A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018280A950-0x000000018280A9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018280A9A0-0x000000018280A9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182809A00-0x0000000182809A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182809A90-0x0000000182809B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RegionSearch other) => default; // 0x0000000182809B60-0x0000000182809CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018280A2E0-0x000000018280A480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018280AD30-0x000000018280B050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018280AA50-0x000000018280ABF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182809CC0-0x0000000182809E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RegionSearch other) {} // 0x0000000182809790-0x0000000182809910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182809570-0x0000000182809690
}

