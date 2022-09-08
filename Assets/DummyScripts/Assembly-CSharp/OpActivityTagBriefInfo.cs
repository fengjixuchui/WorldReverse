/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OpActivityTagBriefInfo : MessageBase, IMessage<OpActivityTagBriefInfo> // TypeDefIndex: 25444
{
	// Fields
	private static readonly MessageParser<OpActivityTagBriefInfo> _parser; // 0x00
	public const int OpActivityTypeFieldNumber = 1; // Metadata: 0x00B08C67
	private uint opActivityType_; // 0x18
	public const int ConfigIdFieldNumber = 2; // Metadata: 0x00B08C6B
	private uint configId_; // 0x1C
	public const int HasRewardFieldNumber = 3; // Metadata: 0x00B08C6F
	private bool hasReward_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OpActivityTagBriefInfo> Parser { get => default; } // 0x00000001830764F0-0x0000000183076580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001830760A0-0x0000000183076130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183075D60-0x0000000183075DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001830756D0-0x0000000183075730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183076960-0x0000000183076A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183076750-0x00000001830767B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001830761D0-0x00000001830762C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183076910-0x0000000183076960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183075E80-0x0000000183075F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OpActivityType { get => default; set {} } // 0x0000000183076450-0x00000001830764F0 0x00000001830766B0-0x0000000183076750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x0000000183076130-0x00000001830761D0 0x0000000183075730-0x00000001830757D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool HasReward { get => default; set {} } // 0x00000001830763B0-0x0000000183076450 0x0000000183075630-0x00000001830756D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityTagBriefInfo() {} // 0x0000000183076DA0-0x0000000183076E00
	static OpActivityTagBriefInfo() {} // 0x0000000183076CE0-0x0000000183076DA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityTagBriefInfo Clone() => default; // 0x00000001830762C0-0x00000001830763B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityTagBriefInfo ShallowCopy() => default; // 0x0000000183075DE0-0x0000000183075E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183075930-0x0000000183075980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183076610-0x0000000183076660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183076660-0x00000001830766B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183075980-0x0000000183075A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183075B40-0x0000000183075C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OpActivityTagBriefInfo other) => default; // 0x0000000183075A00-0x0000000183075B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183075F70-0x00000001830760A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183076A50-0x0000000183076CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001830767B0-0x0000000183076910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183075C10-0x0000000183075D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OpActivityTagBriefInfo other) {} // 0x00000001830757D0-0x0000000183075930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183075520-0x0000000183075630
}

