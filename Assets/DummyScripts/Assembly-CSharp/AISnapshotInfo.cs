/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AISnapshotInfo : MessageBase, IMessage<AISnapshotInfo> // TypeDefIndex: 25692
{
	// Fields
	private static readonly MessageParser<AISnapshotInfo> _parser; // 0x00
	public const int AiSnapshotsFieldNumber = 1; // Metadata: 0x00B095A7
	private static readonly FieldCodec<AISnapshotEntityData> _repeated_aiSnapshots_codec; // 0x08
	private readonly RepeatedMessageField<AISnapshotEntityData> aiSnapshots_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AISnapshotInfo> Parser { get => default; } // 0x00000001824929D0-0x0000000182492A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182492760-0x00000001824927F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182492430-0x00000001824924B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182491EB0-0x0000000182491F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182492DC0-0x0000000182492EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182492C10-0x0000000182492C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001824927F0-0x00000001824928E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182492D70-0x0000000182492DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182492550-0x0000000182492640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AISnapshotEntityData> AiSnapshots { get => default; } // 0x0000000182492700-0x0000000182492760 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AISnapshotInfo() {} // 0x0000000182493110-0x00000001824931A0
	static AISnapshotInfo() {} // 0x0000000182493000-0x0000000182493110

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AISnapshotInfo Clone() => default; // 0x00000001824928E0-0x00000001824929D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AISnapshotInfo ShallowCopy() => default; // 0x00000001824924B0-0x0000000182492550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182492040-0x0000000182492090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182492AF0-0x0000000182492B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182492B80-0x0000000182492C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182492090-0x0000000182492160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182492160-0x0000000182492230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AISnapshotInfo other) => default; // 0x0000000182492230-0x0000000182492340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182492640-0x0000000182492700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182492EB0-0x0000000182493000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182492C70-0x0000000182492D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182492340-0x0000000182492430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AISnapshotInfo other) {} // 0x0000000182491F10-0x0000000182492040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182491D80-0x0000000182491EB0
}

