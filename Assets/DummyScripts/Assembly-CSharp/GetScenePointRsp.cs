/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetScenePointRsp : MessageBase, IMessage<GetScenePointRsp> // TypeDefIndex: 24938
{
	// Fields
	private static readonly MessageParser<GetScenePointRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B0798F
	private int retcode_; // 0x18
	public const int SceneIdFieldNumber = 2; // Metadata: 0x00B07993
	private uint sceneId_; // 0x1C
	public const int UnlockedPointListFieldNumber = 3; // Metadata: 0x00B07997
	private static readonly FieldCodec<uint> _repeated_unlockedPointList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> unlockedPointList_; // 0x20
	public const int BelongUidFieldNumber = 4; // Metadata: 0x00B0799B
	private uint belongUid_; // 0x28
	public const int UnlockAreaListFieldNumber = 5; // Metadata: 0x00B0799F
	private static readonly FieldCodec<uint> _repeated_unlockAreaList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> unlockAreaList_; // 0x30
	public const int LockedPointListFieldNumber = 6; // Metadata: 0x00B079A3
	private static readonly FieldCodec<uint> _repeated_lockedPointList_codec; // 0x18
	private readonly RepeatedPrimitiveField<uint> lockedPointList_; // 0x38
	public const int ToBeExploreDungeonEntryListFieldNumber = 7; // Metadata: 0x00B079A7
	private static readonly FieldCodec<uint> _repeated_toBeExploreDungeonEntryList_codec; // 0x20
	private readonly RepeatedPrimitiveField<uint> toBeExploreDungeonEntryList_; // 0x40
	public const int NotExploredDungeonEntryListFieldNumber = 8; // Metadata: 0x00B079AB
	private static readonly FieldCodec<uint> _repeated_notExploredDungeonEntryList_codec; // 0x28
	private readonly RepeatedPrimitiveField<uint> notExploredDungeonEntryList_; // 0x48
	public const int GroupUnlimitPointListFieldNumber = 9; // Metadata: 0x00B079AF
	private static readonly FieldCodec<uint> _repeated_groupUnlimitPointList_codec; // 0x30
	private readonly RepeatedPrimitiveField<uint> groupUnlimitPointList_; // 0x50
	public const int NotInteractDungeonEntryListFieldNumber = 10; // Metadata: 0x00B079B3
	private static readonly FieldCodec<uint> _repeated_notInteractDungeonEntryList_codec; // 0x38
	private readonly RepeatedPrimitiveField<uint> notInteractDungeonEntryList_; // 0x58

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetScenePointRsp> Parser { get => default; } // 0x0000000182A9FF60-0x0000000182A9FFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A9FC90-0x0000000182A9FD20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A9F7E0-0x0000000182A9F860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A9E800-0x0000000182A9E860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182AA05E0-0x0000000182AA06D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182AA01C0-0x0000000182AA0220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A9FD20-0x0000000182A9FE10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182AA0590-0x0000000182AA05E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A9F900-0x0000000182A9F9F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182A9F6A0-0x0000000182A9F740 0x0000000182A9EF00-0x0000000182A9EFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000182A9EE60-0x0000000182A9EF00 0x0000000182A9F740-0x0000000182A9F7E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> UnlockedPointList { get => default; } // 0x0000000182AA0730-0x0000000182AA0790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BelongUid { get => default; set {} } // 0x0000000182A9FFF0-0x0000000182AA0090 0x0000000182A9EFA0-0x0000000182A9F040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> UnlockAreaList { get => default; } // 0x0000000182A9E860-0x0000000182A9E8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> LockedPointList { get => default; } // 0x0000000182A9FC30-0x0000000182A9FC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ToBeExploreDungeonEntryList { get => default; } // 0x0000000182AA06D0-0x0000000182AA0730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> NotExploredDungeonEntryList { get => default; } // 0x0000000182A9FF00-0x0000000182A9FF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> GroupUnlimitPointList { get => default; } // 0x0000000182AA0790-0x0000000182AA07F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> NotInteractDungeonEntryList { get => default; } // 0x0000000182AA0220-0x0000000182AA0280 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24939
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24940
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 215
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetScenePointRsp() {} // 0x0000000182AA0F40-0x0000000182AA10A0
	static GetScenePointRsp() {} // 0x0000000182AA0DA0-0x0000000182AA0F40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetScenePointRsp Clone() => default; // 0x0000000182A9FE10-0x0000000182A9FF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetScenePointRsp ShallowCopy() => default; // 0x0000000182A9F860-0x0000000182A9F900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A9EB00-0x0000000182A9EB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AA0120-0x0000000182AA0170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182AA0170-0x0000000182AA01C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A9EB50-0x0000000182A9EE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A9F040-0x0000000182A9F110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetScenePointRsp other) => default; // 0x0000000182A9F110-0x0000000182A9F370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A9F9F0-0x0000000182A9FC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182AA07F0-0x0000000182AA0DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182AA0280-0x0000000182AA0590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A9F370-0x0000000182A9F6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetScenePointRsp other) {} // 0x0000000182A9E8C0-0x0000000182A9EB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A9E380-0x0000000182A9E800
}

