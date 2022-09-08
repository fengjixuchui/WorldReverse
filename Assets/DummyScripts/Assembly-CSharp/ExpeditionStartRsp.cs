/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExpeditionStartRsp : MessageBase, IMessage<ExpeditionStartRsp> // TypeDefIndex: 22170
{
	// Fields
	private static readonly MessageParser<ExpeditionStartRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00F67
	private int retcode_; // 0x18
	public const int PathIdFieldNumber = 2; // Metadata: 0x00B00F6B
	private uint pathId_; // 0x1C
	public const int AvatarIdListFieldNumber = 3; // Metadata: 0x00B00F6F
	private static readonly FieldCodec<uint> _repeated_avatarIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> avatarIdList_; // 0x20
	public const int AssistUidFieldNumber = 4; // Metadata: 0x00B00F73
	private uint assistUid_; // 0x28
	public const int AssistAvatarIdFieldNumber = 5; // Metadata: 0x00B00F77
	private uint assistAvatarId_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExpeditionStartRsp> Parser { get => default; } // 0x0000000184918CE0-0x0000000184918D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849189D0-0x0000000184918A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184918640-0x00000001849186C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184917BB0-0x0000000184917C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184919290-0x0000000184919380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184918F40-0x0000000184918FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184918A60-0x0000000184918B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184919240-0x0000000184919290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184918760-0x0000000184918850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184918540-0x00000001849185E0 0x0000000184917F90-0x0000000184918030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PathId { get => default; set {} } // 0x0000000184917EF0-0x0000000184917F90 0x0000000184917B10-0x0000000184917BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AvatarIdList { get => default; } // 0x00000001849185E0-0x0000000184918640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AssistUid { get => default; set {} } // 0x00000001849191A0-0x0000000184919240 0x0000000184918C40-0x0000000184918CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AssistAvatarId { get => default; set {} } // 0x0000000184918E00-0x0000000184918EA0 0x00000001849184A0-0x0000000184918540

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22171
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22172
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2162
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionStartRsp() {} // 0x00000001849197F0-0x0000000184919880
	static ExpeditionStartRsp() {} // 0x0000000184919710-0x00000001849197F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionStartRsp Clone() => default; // 0x0000000184918B50-0x0000000184918C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionStartRsp ShallowCopy() => default; // 0x00000001849186C0-0x0000000184918760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184917DB0-0x0000000184917E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184918EA0-0x0000000184918EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184918EF0-0x0000000184918F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184917E00-0x0000000184917EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849181B0-0x0000000184918280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ExpeditionStartRsp other) => default; // 0x0000000184918030-0x00000001849181B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184918850-0x00000001849189D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184919380-0x0000000184919710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184918FA0-0x00000001849191A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184918280-0x00000001849184A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ExpeditionStartRsp other) {} // 0x0000000184917C10-0x0000000184917DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184917950-0x0000000184917B10
}

