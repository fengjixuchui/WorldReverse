/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExpeditionActivityDetailInfo : MessageBase, IMessage<ExpeditionActivityDetailInfo> // TypeDefIndex: 22166
{
	// Fields
	private static readonly MessageParser<ExpeditionActivityDetailInfo> _parser; // 0x00
	public const int PathInfoListFieldNumber = 1; // Metadata: 0x00B00F2B
	private static readonly FieldCodec<ExpeditionPathInfo> _repeated_pathInfoList_codec; // 0x08
	private readonly RepeatedMessageField<ExpeditionPathInfo> pathInfoList_; // 0x18
	public const int ExpeditionCountFieldNumber = 2; // Metadata: 0x00B00F2F
	private uint expeditionCount_; // 0x20
	public const int ChallengeInfoListFieldNumber = 3; // Metadata: 0x00B00F33
	private static readonly FieldCodec<ExpeditionChallengeInfo> _repeated_challengeInfoList_codec; // 0x10
	private readonly RepeatedMessageField<ExpeditionChallengeInfo> challengeInfoList_; // 0x28
	public const int IsContentClosedFieldNumber = 4; // Metadata: 0x00B00F37
	private bool isContentClosed_; // 0x30
	public const int ContentCloseTimeFieldNumber = 5; // Metadata: 0x00B00F3B
	private uint contentCloseTime_; // 0x34
	public const int CurChallengeIdFieldNumber = 6; // Metadata: 0x00B00F3F
	private uint curChallengeId_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExpeditionActivityDetailInfo> Parser { get => default; } // 0x0000000185702E70-0x0000000185702F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185702B00-0x0000000185702B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185702740-0x00000001857027C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185701AD0-0x0000000185701B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185703520-0x0000000185703610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001857030D0-0x0000000185703130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185702C30-0x0000000185702D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185703390-0x00000001857033E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185702860-0x0000000185702950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ExpeditionPathInfo> PathInfoList { get => default; } // 0x0000000185702E10-0x0000000185702E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExpeditionCount { get => default; set {} } // 0x0000000185702B90-0x0000000185702C30 0x0000000185702090-0x0000000185702130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ExpeditionChallengeInfo> ChallengeInfoList { get => default; } // 0x0000000185701EE0-0x0000000185701F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsContentClosed { get => default; set {} } // 0x0000000185701B30-0x0000000185701BD0 0x0000000185702130-0x00000001857021D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ContentCloseTime { get => default; set {} } // 0x0000000185703480-0x0000000185703520 0x00000001857026A0-0x0000000185702740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurChallengeId { get => default; set {} } // 0x0000000185701DF0-0x0000000185701E90 0x00000001857033E0-0x0000000185703480

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionActivityDetailInfo() {} // 0x0000000185703B70-0x0000000185703C20
	static ExpeditionActivityDetailInfo() {} // 0x0000000185703A10-0x0000000185703B70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionActivityDetailInfo Clone() => default; // 0x0000000185702D20-0x0000000185702E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionActivityDetailInfo ShallowCopy() => default; // 0x00000001857027C0-0x0000000185702860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185701E90-0x0000000185701EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185702F90-0x0000000185703030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185703030-0x00000001857030D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185701F40-0x0000000185702090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185702390-0x0000000185702460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ExpeditionActivityDetailInfo other) => default; // 0x00000001857021D0-0x0000000185702390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185702950-0x0000000185702B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185703610-0x0000000185703A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185703130-0x0000000185703390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185702460-0x00000001857026A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ExpeditionActivityDetailInfo other) {} // 0x0000000185701BD0-0x0000000185701DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001857018B0-0x0000000185701AD0
}

