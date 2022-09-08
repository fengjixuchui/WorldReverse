/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AbilityMixinScenePropSync : MessageBase, IMessage<AbilityMixinScenePropSync> // TypeDefIndex: 21791
{
	// Fields
	private static readonly MessageParser<AbilityMixinScenePropSync> _parser; // 0x00
	public const int MassivePropListFieldNumber = 1; // Metadata: 0x00B0000F
	private static readonly FieldCodec<MassivePropSyncInfo> _repeated_massivePropList_codec; // 0x08
	private readonly RepeatedMessageField<MassivePropSyncInfo> massivePropList_; // 0x18
	public const int DeleteIdListFieldNumber = 2; // Metadata: 0x00B00013
	private static readonly FieldCodec<long> _repeated_deleteIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<long> deleteIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AbilityMixinScenePropSync> Parser { get => default; } // 0x000000018426CC00-0x000000018426CC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018426C990-0x000000018426CA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018426C690-0x000000018426C710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018426BFD0-0x000000018426C030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018426D080-0x000000018426D170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018426CEA0-0x000000018426CF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018426CA20-0x000000018426CB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018426D030-0x000000018426D080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018426C7B0-0x000000018426C8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MassivePropSyncInfo> MassivePropList { get => default; } // 0x000000018426CE40-0x000000018426CEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<long> DeleteIdList { get => default; } // 0x000000018426C310-0x000000018426C370 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinScenePropSync() {} // 0x000000018426D460-0x000000018426D510
	static AbilityMixinScenePropSync() {} // 0x000000018426D330-0x000000018426D460

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinScenePropSync Clone() => default; // 0x000000018426CB10-0x000000018426CC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AbilityMixinScenePropSync ShallowCopy() => default; // 0x000000018426C710-0x000000018426C7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018426C190-0x000000018426C1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018426CD20-0x000000018426CDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018426CDB0-0x000000018426CE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018426C1E0-0x000000018426C310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018426C4A0-0x000000018426C570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AbilityMixinScenePropSync other) => default; // 0x000000018426C370-0x000000018426C4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018426C8A0-0x000000018426C990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018426D170-0x000000018426D330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018426CF00-0x000000018426D030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018426C570-0x000000018426C690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AbilityMixinScenePropSync other) {} // 0x000000018426C030-0x000000018426C190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018426BE20-0x000000018426BFD0
}

