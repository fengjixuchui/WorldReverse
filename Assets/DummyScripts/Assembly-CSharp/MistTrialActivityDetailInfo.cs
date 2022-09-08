/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MistTrialActivityDetailInfo : MessageBase, IMessage<MistTrialActivityDetailInfo> // TypeDefIndex: 22333
{
	// Fields
	private static readonly MessageParser<MistTrialActivityDetailInfo> _parser; // 0x00
	public const int TrialLevelDataListFieldNumber = 1; // Metadata: 0x00B015AB
	private static readonly FieldCodec<MistTrialLevelData> _repeated_trialLevelDataList_codec; // 0x08
	private readonly RepeatedMessageField<MistTrialLevelData> trialLevelDataList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MistTrialActivityDetailInfo> Parser { get => default; } // 0x00000001837A7920-0x00000001837A79B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001837A76B0-0x00000001837A7740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001837A73E0-0x00000001837A7460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001837A6E00-0x00000001837A6E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001837A7D10-0x00000001837A7E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001837A7B60-0x00000001837A7BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001837A7740-0x00000001837A7830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001837A7CC0-0x00000001837A7D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001837A7500-0x00000001837A75F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MistTrialLevelData> TrialLevelDataList { get => default; } // 0x00000001837A7380-0x00000001837A73E0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialActivityDetailInfo() {} // 0x00000001837A8060-0x00000001837A80F0
	static MistTrialActivityDetailInfo() {} // 0x00000001837A7F50-0x00000001837A8060

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialActivityDetailInfo Clone() => default; // 0x00000001837A7830-0x00000001837A7920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialActivityDetailInfo ShallowCopy() => default; // 0x00000001837A7460-0x00000001837A7500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001837A6F90-0x00000001837A6FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837A7A40-0x00000001837A7AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837A7AD0-0x00000001837A7B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001837A6FE0-0x00000001837A70B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001837A70B0-0x00000001837A7180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MistTrialActivityDetailInfo other) => default; // 0x00000001837A7180-0x00000001837A7290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001837A75F0-0x00000001837A76B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001837A7E00-0x00000001837A7F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001837A7BC0-0x00000001837A7CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001837A7290-0x00000001837A7380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MistTrialActivityDetailInfo other) {} // 0x00000001837A6E60-0x00000001837A6F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001837A6CD0-0x00000001837A6E00
}

