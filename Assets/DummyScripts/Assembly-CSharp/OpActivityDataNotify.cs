/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OpActivityDataNotify : MessageBase, IMessage<OpActivityDataNotify> // TypeDefIndex: 24247
{
	// Fields
	private static readonly MessageParser<OpActivityDataNotify> _parser; // 0x00
	public const int OpActivityInfoListFieldNumber = 1; // Metadata: 0x00B05EF7
	private static readonly FieldCodec<OpActivityInfo> _repeated_opActivityInfoList_codec; // 0x08
	private readonly RepeatedMessageField<OpActivityInfo> opActivityInfoList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OpActivityDataNotify> Parser { get => default; } // 0x0000000182C5E9B0-0x0000000182C5EA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C5E6E0-0x0000000182C5E770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C5E410-0x0000000182C5E490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C5DE90-0x0000000182C5DEF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C5EDA0-0x0000000182C5EE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C5EBF0-0x0000000182C5EC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C5E770-0x0000000182C5E860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C5ED50-0x0000000182C5EDA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C5E530-0x0000000182C5E620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<OpActivityInfo> OpActivityInfoList { get => default; } // 0x0000000182C5E950-0x0000000182C5E9B0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24248
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24249
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5103
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityDataNotify() {} // 0x0000000182C5F0F0-0x0000000182C5F180
	static OpActivityDataNotify() {} // 0x0000000182C5EFE0-0x0000000182C5F0F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityDataNotify Clone() => default; // 0x0000000182C5E860-0x0000000182C5E950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityDataNotify ShallowCopy() => default; // 0x0000000182C5E490-0x0000000182C5E530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C5E020-0x0000000182C5E070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C5EAD0-0x0000000182C5EB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C5EB60-0x0000000182C5EBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C5E070-0x0000000182C5E140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C5E140-0x0000000182C5E210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OpActivityDataNotify other) => default; // 0x0000000182C5E210-0x0000000182C5E320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C5E620-0x0000000182C5E6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C5EE90-0x0000000182C5EFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C5EC50-0x0000000182C5ED50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C5E320-0x0000000182C5E410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OpActivityDataNotify other) {} // 0x0000000182C5DEF0-0x0000000182C5E020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C5DD60-0x0000000182C5DE90
}

