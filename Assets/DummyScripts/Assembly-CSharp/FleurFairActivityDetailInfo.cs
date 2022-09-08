/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairActivityDetailInfo : MessageBase, IMessage<FleurFairActivityDetailInfo> // TypeDefIndex: 22213
{
	// Fields
	private static readonly MessageParser<FleurFairActivityDetailInfo> _parser; // 0x00
	public const int ChapterInfoListFieldNumber = 1; // Metadata: 0x00B010E7
	private static readonly FieldCodec<FleurFairChapterInfo> _repeated_chapterInfoList_codec; // 0x08
	private readonly RepeatedMessageField<FleurFairChapterInfo> chapterInfoList_; // 0x18
	public const int IsContentClosedFieldNumber = 2; // Metadata: 0x00B010EB
	private bool isContentClosed_; // 0x20
	public const int ContentCloseTimeFieldNumber = 3; // Metadata: 0x00B010EF
	private uint contentCloseTime_; // 0x24
	public const int MinigameInfoMapFieldNumber = 4; // Metadata: 0x00B010F3
	private static readonly MapField<uint, FleurFairMinigameInfo> _map_minigameInfoMap_codec; // 0x10
	private readonly MapField<uint, FleurFairMinigameInfo> minigameInfoMap_; // 0x28
	public const int DungeonSectionInfoMapFieldNumber = 5; // Metadata: 0x00B010F7
	private static readonly MapField<uint, FleurFairDungeonSectionInfo> _map_dungeonSectionInfoMap_codec; // 0x18
	private readonly MapField<uint, FleurFairDungeonSectionInfo> dungeonSectionInfoMap_; // 0x30
	public const int IsDungeonUnlockedFieldNumber = 6; // Metadata: 0x00B010FB
	private bool isDungeonUnlocked_; // 0x38
	public const int DungeonPunishOverTimeFieldNumber = 7; // Metadata: 0x00B010FF
	private uint dungeonPunishOverTime_; // 0x3C
	public const int ObtainedTokenFieldNumber = 8; // Metadata: 0x00B01103
	private uint obtainedToken_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairActivityDetailInfo> Parser { get => default; } // 0x0000000183DED2A0-0x0000000183DED330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183DECF90-0x0000000183DED020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183DECA60-0x0000000183DECAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183DEBC90-0x0000000183DEBCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183DEDA60-0x0000000183DEDB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183DED5A0-0x0000000183DED600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183DED020-0x0000000183DED110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183DED970-0x0000000183DED9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183DECB80-0x0000000183DECC70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FleurFairChapterInfo> ChapterInfoList { get => default; } // 0x0000000183DED540-0x0000000183DED5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsContentClosed { get => default; set {} } // 0x0000000183DEBCF0-0x0000000183DEBD90 0x0000000183DEC330-0x0000000183DEC3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ContentCloseTime { get => default; set {} } // 0x0000000183DED9C0-0x0000000183DEDA60 0x0000000183DEC9C0-0x0000000183DECA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, FleurFairMinigameInfo> MinigameInfoMap { get => default; } // 0x0000000183DED4E0-0x0000000183DED540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, FleurFairDungeonSectionInfo> DungeonSectionInfoMap { get => default; } // 0x0000000183DEC3D0-0x0000000183DEC430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsDungeonUnlocked { get => default; set {} } // 0x0000000183DED8D0-0x0000000183DED970 0x0000000183DECEF0-0x0000000183DECF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DungeonPunishOverTime { get => default; set {} } // 0x0000000183DEC290-0x0000000183DEC330 0x0000000183DEDB50-0x0000000183DEDBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ObtainedToken { get => default; set {} } // 0x0000000183DED200-0x0000000183DED2A0 0x0000000183DEC030-0x0000000183DEC0D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairActivityDetailInfo() {} // 0x0000000183DEE330-0x0000000183DEE400
	static FleurFairActivityDetailInfo() {} // 0x0000000183DEE0F0-0x0000000183DEE330

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairActivityDetailInfo Clone() => default; // 0x0000000183DED110-0x0000000183DED200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairActivityDetailInfo ShallowCopy() => default; // 0x0000000183DECAE0-0x0000000183DECB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183DEBFE0-0x0000000183DEC030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DED3C0-0x0000000183DED450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183DED450-0x0000000183DED4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183DEC0D0-0x0000000183DEC290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183DEC660-0x0000000183DEC730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairActivityDetailInfo other) => default; // 0x0000000183DEC430-0x0000000183DEC660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183DECC70-0x0000000183DECEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183DEDBF0-0x0000000183DEE0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183DED600-0x0000000183DED8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183DEC730-0x0000000183DEC9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairActivityDetailInfo other) {} // 0x0000000183DEBD90-0x0000000183DEBFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183DEB9F0-0x0000000183DEBC90
}

