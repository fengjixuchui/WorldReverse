/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CityReputationExploreInfo : MessageBase, IMessage<CityReputationExploreInfo> // TypeDefIndex: 24750
{
	// Fields
	private static readonly MessageParser<CityReputationExploreInfo> _parser; // 0x00
	public const int IsOpenFieldNumber = 1; // Metadata: 0x00B0724B
	private bool isOpen_; // 0x18
	public const int TakenExploreRewardListFieldNumber = 2; // Metadata: 0x00B0724F
	private static readonly FieldCodec<uint> _repeated_takenExploreRewardList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> takenExploreRewardList_; // 0x20
	public const int ExplorePercentFieldNumber = 3; // Metadata: 0x00B07253
	private uint explorePercent_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CityReputationExploreInfo> Parser { get => default; } // 0x0000000182EECC70-0x0000000182EECD00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182EEC9A0-0x0000000182EECA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182EEC660-0x0000000182EEC6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182EEBE20-0x0000000182EEBE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182EED100-0x0000000182EED1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182EECE30-0x0000000182EECE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182EECA90-0x0000000182EECB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182EED0B0-0x0000000182EED100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182EEC780-0x0000000182EEC870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x0000000182EECE90-0x0000000182EECF30 0x0000000182EEBF20-0x0000000182EEBFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> TakenExploreRewardList { get => default; } // 0x0000000182EECA30-0x0000000182EECA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExplorePercent { get => default; set {} } // 0x0000000182EEC120-0x0000000182EEC1C0 0x0000000182EEBE80-0x0000000182EEBF20

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationExploreInfo() {} // 0x0000000182EED540-0x0000000182EED5D0
	static CityReputationExploreInfo() {} // 0x0000000182EED460-0x0000000182EED540

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationExploreInfo Clone() => default; // 0x0000000182EECB80-0x0000000182EECC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CityReputationExploreInfo ShallowCopy() => default; // 0x0000000182EEC6E0-0x0000000182EEC780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182EEC1C0-0x0000000182EEC210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182EECD90-0x0000000182EECDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182EECDE0-0x0000000182EECE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182EEC210-0x0000000182EEC2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182EEC2F0-0x0000000182EEC3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CityReputationExploreInfo other) => default; // 0x0000000182EEC3C0-0x0000000182EEC500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182EEC870-0x0000000182EEC9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182EED1F0-0x0000000182EED460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182EECF30-0x0000000182EED0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182EEC500-0x0000000182EEC660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CityReputationExploreInfo other) {} // 0x0000000182EEBFC0-0x0000000182EEC120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182EEBCA0-0x0000000182EEBE20
}

