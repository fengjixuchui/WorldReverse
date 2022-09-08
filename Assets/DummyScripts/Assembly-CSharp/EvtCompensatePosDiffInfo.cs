/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtCompensatePosDiffInfo : MessageBase, IMessage<EvtCompensatePosDiffInfo> // TypeDefIndex: 23027
{
	// Fields
	private static readonly MessageParser<EvtCompensatePosDiffInfo> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B02FB7
	private uint entityId_; // 0x18
	public const int CurHashFieldNumber = 2; // Metadata: 0x00B02FBB
	private uint curHash_; // 0x1C
	public const int FaceAngleCompactFieldNumber = 3; // Metadata: 0x00B02FBF
	private int faceAngleCompact_; // 0x20
	public const int CurPosFieldNumber = 4; // Metadata: 0x00B02FC3
	private Vector curPos_; // 0x28
	public const int NormalizedTimeCompactFieldNumber = 5; // Metadata: 0x00B02FC7
	private uint normalizedTimeCompact_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtCompensatePosDiffInfo> Parser { get => default; } // 0x0000000182202F50-0x0000000182202FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182202C40-0x0000000182202CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182202780-0x0000000182202800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182201C90-0x0000000182201CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182203670-0x0000000182203760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001822033F0-0x0000000182203450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182202CD0-0x0000000182202DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182203620-0x0000000182203670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001822028A0-0x0000000182202990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182203350-0x00000001822033F0 0x0000000182203760-0x0000000182203800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurHash { get => default; set {} } // 0x0000000182202170-0x0000000182202210 0x0000000182202210-0x00000001822022B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int FaceAngleCompact { get => default; set {} } // 0x0000000182202BA0-0x0000000182202C40 0x00000001822032B0-0x0000000182203350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector CurPos { get => default; set {} } // 0x00000001822020D0-0x0000000182202170 0x0000000182202FE0-0x0000000182203080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NormalizedTimeCompact { get => default; set {} } // 0x0000000182203190-0x0000000182203230 0x0000000182202EB0-0x0000000182202F50

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCompensatePosDiffInfo() {} // 0x0000000182203C50-0x0000000182203CB0
	static EvtCompensatePosDiffInfo() {} // 0x0000000182203B90-0x0000000182203C50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCompensatePosDiffInfo Clone() => default; // 0x0000000182202DC0-0x0000000182202EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtCompensatePosDiffInfo ShallowCopy() => default; // 0x0000000182202800-0x00000001822028A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182201EF0-0x0000000182201F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182203110-0x0000000182203190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182203230-0x00000001822032B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182201F70-0x00000001822020D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001822022B0-0x0000000182202380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtCompensatePosDiffInfo other) => default; // 0x0000000182202380-0x0000000182202510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182202990-0x0000000182202BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182203800-0x0000000182203B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182203450-0x0000000182203620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182202510-0x0000000182202780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtCompensatePosDiffInfo other) {} // 0x0000000182201CF0-0x0000000182201EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182201AF0-0x0000000182201C90
}

