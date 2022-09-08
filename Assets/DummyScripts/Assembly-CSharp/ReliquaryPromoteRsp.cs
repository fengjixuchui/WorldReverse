/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReliquaryPromoteRsp : MessageBase, IMessage<ReliquaryPromoteRsp> // TypeDefIndex: 23672
{
	// Fields
	private static readonly MessageParser<ReliquaryPromoteRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0490B
	private int retcode_; // 0x18
	public const int TargetReliquaryGuidFieldNumber = 2; // Metadata: 0x00B0490F
	private ulong targetReliquaryGuid_; // 0x20
	public const int OldPromoteLevelFieldNumber = 3; // Metadata: 0x00B04913
	private uint oldPromoteLevel_; // 0x28
	public const int CurPromoteLevelFieldNumber = 4; // Metadata: 0x00B04917
	private uint curPromoteLevel_; // 0x2C
	public const int OldAppendPropListFieldNumber = 5; // Metadata: 0x00B0491B
	private static readonly FieldCodec<uint> _repeated_oldAppendPropList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> oldAppendPropList_; // 0x30
	public const int CurAppendPropListFieldNumber = 6; // Metadata: 0x00B0491F
	private static readonly FieldCodec<uint> _repeated_curAppendPropList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> curAppendPropList_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReliquaryPromoteRsp> Parser { get => default; } // 0x000000018305ECF0-0x000000018305ED80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018305E8A0-0x000000018305E930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018305E4E0-0x000000018305E560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018305DAB0-0x000000018305DB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018305F2D0-0x000000018305F3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018305EF50-0x000000018305EFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018305E9D0-0x000000018305EAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018305F280-0x000000018305F2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018305E600-0x000000018305E6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018305E440-0x000000018305E4E0 0x000000018305DED0-0x000000018305DF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong TargetReliquaryGuid { get => default; set {} } // 0x000000018305F3C0-0x000000018305F460 0x000000018305EFB0-0x000000018305F050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OldPromoteLevel { get => default; set {} } // 0x000000018305E930-0x000000018305E9D0 0x000000018305EC50-0x000000018305ECF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurPromoteLevel { get => default; set {} } // 0x000000018305EBB0-0x000000018305EC50 0x000000018305EE60-0x000000018305EF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> OldAppendPropList { get => default; } // 0x000000018305DCD0-0x000000018305DD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> CurAppendPropList { get => default; } // 0x000000018305DA50-0x000000018305DAB0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23673
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23674
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 626
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReliquaryPromoteRsp() {} // 0x000000018305F960-0x000000018305FA10
	static ReliquaryPromoteRsp() {} // 0x000000018305F860-0x000000018305F960

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReliquaryPromoteRsp Clone() => default; // 0x000000018305EAC0-0x000000018305EBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReliquaryPromoteRsp ShallowCopy() => default; // 0x000000018305E560-0x000000018305E600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018305DD30-0x000000018305DD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018305EE10-0x000000018305EE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018305EF00-0x000000018305EF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018305DD80-0x000000018305DED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018305DF70-0x000000018305E040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReliquaryPromoteRsp other) => default; // 0x000000018305E040-0x000000018305E1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018305E6F0-0x000000018305E8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018305F460-0x000000018305F860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018305F050-0x000000018305F280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018305E1F0-0x000000018305E440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReliquaryPromoteRsp other) {} // 0x000000018305DB10-0x000000018305DCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018305D810-0x000000018305DA50
}

