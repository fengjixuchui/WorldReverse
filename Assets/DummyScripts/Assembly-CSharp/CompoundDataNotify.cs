/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CompoundDataNotify : MessageBase, IMessage<CompoundDataNotify> // TypeDefIndex: 24410
{
	// Fields
	private static readonly MessageParser<CompoundDataNotify> _parser; // 0x00
	public const int UnlockCompoundListFieldNumber = 1; // Metadata: 0x00B065FF
	private static readonly FieldCodec<uint> _repeated_unlockCompoundList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> unlockCompoundList_; // 0x18
	public const int CompoundQueDataListFieldNumber = 2; // Metadata: 0x00B06603
	private static readonly FieldCodec<CompoundQueueData> _repeated_compoundQueDataList_codec; // 0x10
	private readonly RepeatedMessageField<CompoundQueueData> compoundQueDataList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CompoundDataNotify> Parser { get => default; } // 0x0000000182F27330-0x0000000182F273C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182F27060-0x0000000182F270F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182F26D60-0x0000000182F26DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182F26710-0x0000000182F26770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182F277B0-0x0000000182F278A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182F275D0-0x0000000182F27630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182F27150-0x0000000182F27240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182F27760-0x0000000182F277B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182F26E80-0x0000000182F26F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> UnlockCompoundList { get => default; } // 0x0000000182F27570-0x0000000182F275D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CompoundQueueData> CompoundQueDataList { get => default; } // 0x0000000182F270F0-0x0000000182F27150 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24411
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24412
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 137
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CompoundDataNotify() {} // 0x0000000182F27B90-0x0000000182F27C40
	static CompoundDataNotify() {} // 0x0000000182F27A60-0x0000000182F27B90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CompoundDataNotify Clone() => default; // 0x0000000182F27240-0x0000000182F27330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CompoundDataNotify ShallowCopy() => default; // 0x0000000182F26DE0-0x0000000182F26E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182F268C0-0x0000000182F26910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F27450-0x0000000182F274E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F274E0-0x0000000182F27570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182F26910-0x0000000182F26A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182F26A40-0x0000000182F26B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CompoundDataNotify other) => default; // 0x0000000182F26B10-0x0000000182F26C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182F26F70-0x0000000182F27060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182F278A0-0x0000000182F27A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182F27630-0x0000000182F27760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182F26C40-0x0000000182F26D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CompoundDataNotify other) {} // 0x0000000182F26770-0x0000000182F268C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182F26560-0x0000000182F26710
}

