/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FallSettleInfo : MessageBase, IMessage<FallSettleInfo> // TypeDefIndex: 23251
{
	// Fields
	private static readonly MessageParser<FallSettleInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B0396F
	private uint uid_; // 0x18
	public const int CatchCountFieldNumber = 2; // Metadata: 0x00B03973
	private uint catchCount_; // 0x1C
	public const int FlowerRingCatchCountMapFieldNumber = 3; // Metadata: 0x00B03977
	private static readonly MapField<uint, uint> _map_flowerRingCatchCountMap_codec; // 0x08
	private readonly MapField<uint, uint> flowerRingCatchCountMap_; // 0x20
	public const int FinalScoreFieldNumber = 4; // Metadata: 0x00B0397B
	private uint finalScore_; // 0x28
	public const int PlayerInfoFieldNumber = 5; // Metadata: 0x00B0397F
	private OnlinePlayerInfo playerInfo_; // 0x30
	public const int RemainTimeFieldNumber = 6; // Metadata: 0x00B03983
	private uint remainTime_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FallSettleInfo> Parser { get => default; } // 0x0000000184952E10-0x0000000184952EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184952B00-0x0000000184952B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184952680-0x0000000184952700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849519E0-0x0000000184951A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184953500-0x00000001849535F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184953170-0x00000001849531D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184952C30-0x0000000184952D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849534B0-0x0000000184953500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849527A0-0x0000000184952890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x0000000184952540-0x00000001849525E0 0x0000000184952B90-0x0000000184952C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CatchCount { get => default; set {} } // 0x00000001849525E0-0x0000000184952680 0x0000000184951A40-0x0000000184951AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> FlowerRingCatchCountMap { get => default; } // 0x00000001849535F0-0x0000000184953650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinalScore { get => default; set {} } // 0x0000000184953650-0x00000001849536F0 0x0000000184952FB0-0x0000000184953050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OnlinePlayerInfo PlayerInfo { get => default; set {} } // 0x0000000184951F30-0x0000000184951FD0 0x00000001849530D0-0x0000000184953170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RemainTime { get => default; set {} } // 0x0000000184951940-0x00000001849519E0 0x00000001849531D0-0x0000000184953270

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FallSettleInfo() {} // 0x0000000184953C20-0x0000000184953CB0
	static FallSettleInfo() {} // 0x0000000184953AF0-0x0000000184953C20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FallSettleInfo Clone() => default; // 0x0000000184952D20-0x0000000184952E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FallSettleInfo ShallowCopy() => default; // 0x0000000184952700-0x00000001849527A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184951D00-0x0000000184951D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184952F30-0x0000000184952FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184953050-0x00000001849530D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184951D80-0x0000000184951F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849521A0-0x0000000184952270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FallSettleInfo other) => default; // 0x0000000184951FD0-0x00000001849521A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184952890-0x0000000184952B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849536F0-0x0000000184953AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184953270-0x00000001849534B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184952270-0x0000000184952540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FallSettleInfo other) {} // 0x0000000184951AE0-0x0000000184951D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184951730-0x0000000184951940
}

