/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class OpActivityStateNotify : MessageBase, IMessage<OpActivityStateNotify> // TypeDefIndex: 25445
{
	// Fields
	private static readonly MessageParser<OpActivityStateNotify> _parser; // 0x00
	public const int OpenedOpActivityInfoListFieldNumber = 1; // Metadata: 0x00B08C73
	private static readonly FieldCodec<OpActivityTagBriefInfo> _repeated_openedOpActivityInfoList_codec; // 0x08
	private readonly RepeatedMessageField<OpActivityTagBriefInfo> openedOpActivityInfoList_; // 0x18
	public const int FinishedBonusActivityIdListFieldNumber = 2; // Metadata: 0x00B08C77
	private static readonly FieldCodec<uint> _repeated_finishedBonusActivityIdList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> finishedBonusActivityIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<OpActivityStateNotify> Parser { get => default; } // 0x0000000183616F60-0x0000000183616FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183616C90-0x0000000183616D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183616990-0x0000000183616A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001836162D0-0x0000000183616330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183617380-0x0000000183617470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836171A0-0x0000000183617200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183616D20-0x0000000183616E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183617330-0x0000000183617380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183616AB0-0x0000000183616BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<OpActivityTagBriefInfo> OpenedOpActivityInfoList { get => default; } // 0x0000000183616490-0x00000001836164F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FinishedBonusActivityIdList { get => default; } // 0x0000000183616F00-0x0000000183616F60 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25446
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25447
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2501
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityStateNotify() {} // 0x0000000183617760-0x0000000183617810
	static OpActivityStateNotify() {} // 0x0000000183617630-0x0000000183617760

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityStateNotify Clone() => default; // 0x0000000183616E10-0x0000000183616F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OpActivityStateNotify ShallowCopy() => default; // 0x0000000183616A10-0x0000000183616AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001836164F0-0x0000000183616540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183617080-0x0000000183617110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183617110-0x00000001836171A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183616540-0x0000000183616670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001836167A0-0x0000000183616870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(OpActivityStateNotify other) => default; // 0x0000000183616670-0x00000001836167A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183616BA0-0x0000000183616C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183617470-0x0000000183617630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183617200-0x0000000183617330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183616870-0x0000000183616990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(OpActivityStateNotify other) {} // 0x0000000183616330-0x0000000183616490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183616120-0x00000001836162D0
}

