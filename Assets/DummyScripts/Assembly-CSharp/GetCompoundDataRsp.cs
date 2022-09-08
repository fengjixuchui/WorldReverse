/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetCompoundDataRsp : MessageBase, IMessage<GetCompoundDataRsp> // TypeDefIndex: 24416
{
	// Fields
	private static readonly MessageParser<GetCompoundDataRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0662B
	private int retcode_; // 0x18
	public const int UnlockCompoundListFieldNumber = 2; // Metadata: 0x00B0662F
	private static readonly FieldCodec<uint> _repeated_unlockCompoundList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> unlockCompoundList_; // 0x20
	public const int CompoundQueDataListFieldNumber = 3; // Metadata: 0x00B06633
	private static readonly FieldCodec<CompoundQueueData> _repeated_compoundQueDataList_codec; // 0x10
	private readonly RepeatedMessageField<CompoundQueueData> compoundQueDataList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetCompoundDataRsp> Parser { get => default; } // 0x00000001816FCB80-0x00000001816FCC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001816FC8B0-0x00000001816FC940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001816FC580-0x00000001816FC600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001816FBD30-0x00000001816FBD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001816FD040-0x00000001816FD130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001816FCE20-0x00000001816FCE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001816FC9A0-0x00000001816FCA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001816FCFF0-0x00000001816FD040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001816FC6A0-0x00000001816FC790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001816FC4E0-0x00000001816FC580 0x00000001816FC0A0-0x00000001816FC140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> UnlockCompoundList { get => default; } // 0x00000001816FCDC0-0x00000001816FCE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CompoundQueueData> CompoundQueDataList { get => default; } // 0x00000001816FC940-0x00000001816FC9A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24417
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24418
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 139
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetCompoundDataRsp() {} // 0x00000001816FD4C0-0x00000001816FD570
	static GetCompoundDataRsp() {} // 0x00000001816FD390-0x00000001816FD4C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetCompoundDataRsp Clone() => default; // 0x00000001816FCA90-0x00000001816FCB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetCompoundDataRsp ShallowCopy() => default; // 0x00000001816FC600-0x00000001816FC6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001816FBF10-0x00000001816FBF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816FCCA0-0x00000001816FCD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816FCD30-0x00000001816FCDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001816FBF60-0x00000001816FC0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001816FC140-0x00000001816FC210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetCompoundDataRsp other) => default; // 0x00000001816FC210-0x00000001816FC360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001816FC790-0x00000001816FC8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001816FD130-0x00000001816FD390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001816FCE80-0x00000001816FCFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001816FC360-0x00000001816FC4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetCompoundDataRsp other) {} // 0x00000001816FBD90-0x00000001816FBF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001816FBB50-0x00000001816FBD30
}

