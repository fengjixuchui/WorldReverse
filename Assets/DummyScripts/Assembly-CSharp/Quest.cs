/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Quest : MessageBase, IMessage<Quest> // TypeDefIndex: 26074
{
	// Fields
	private static readonly MessageParser<Quest> _parser; // 0x00
	public const int QuestIdFieldNumber = 1; // Metadata: 0x00B0B01F
	private uint questId_; // 0x18
	public const int StateFieldNumber = 2; // Metadata: 0x00B0B023
	private uint state_; // 0x1C
	public const int StartTimeFieldNumber = 4; // Metadata: 0x00B0B027
	private uint startTime_; // 0x20
	public const int IsRandomFieldNumber = 5; // Metadata: 0x00B0B02B
	private bool isRandom_; // 0x24
	public const int ParentQuestIdFieldNumber = 6; // Metadata: 0x00B0B02F
	private uint parentQuestId_; // 0x28
	public const int QuestConfigIdFieldNumber = 7; // Metadata: 0x00B0B033
	private uint questConfigId_; // 0x2C
	public const int StartGameTimeFieldNumber = 8; // Metadata: 0x00B0B037
	private uint startGameTime_; // 0x30
	public const int AcceptTimeFieldNumber = 9; // Metadata: 0x00B0B03B
	private uint acceptTime_; // 0x34
	public const int LackedNpcListFieldNumber = 10; // Metadata: 0x00B0B03F
	private static readonly FieldCodec<uint> _repeated_lackedNpcList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> lackedNpcList_; // 0x38
	public const int FinishProgressListFieldNumber = 11; // Metadata: 0x00B0B043
	private static readonly FieldCodec<uint> _repeated_finishProgressList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> finishProgressList_; // 0x40
	public const int FailProgressListFieldNumber = 12; // Metadata: 0x00B0B047
	private static readonly FieldCodec<uint> _repeated_failProgressList_codec; // 0x18
	private readonly RepeatedPrimitiveField<uint> failProgressList_; // 0x48
	public const int LackedNpcMapFieldNumber = 13; // Metadata: 0x00B0B04B
	private static readonly MapField<uint, uint> _map_lackedNpcMap_codec; // 0x20
	private readonly MapField<uint, uint> lackedNpcMap_; // 0x50
	public const int LackedPlaceListFieldNumber = 14; // Metadata: 0x00B0B04F
	private static readonly FieldCodec<uint> _repeated_lackedPlaceList_codec; // 0x28
	private readonly RepeatedPrimitiveField<uint> lackedPlaceList_; // 0x58
	public const int LackedPlaceMapFieldNumber = 15; // Metadata: 0x00B0B053
	private static readonly MapField<uint, uint> _map_lackedPlaceMap_codec; // 0x30
	private readonly MapField<uint, uint> lackedPlaceMap_; // 0x60

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Quest> Parser { get => default; } // 0x000000018378B300-0x000000018378B390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018378AEB0-0x000000018378AF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018378A800-0x000000018378A880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183789430-0x0000000183789490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018378BB70-0x000000018378BC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018378B660-0x000000018378B6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018378B080-0x000000018378B170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018378BAC0-0x000000018378BB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018378A920-0x000000018378AA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestId { get => default; set {} } // 0x0000000183789390-0x0000000183789430 0x000000018378A760-0x000000018378A800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint State { get => default; set {} } // 0x000000018378A620-0x000000018378A6C0 0x000000018378A6C0-0x000000018378A760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartTime { get => default; set {} } // 0x000000018378BC60-0x000000018378BD00 0x000000018378AFE0-0x000000018378B080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsRandom { get => default; set {} } // 0x0000000183789DB0-0x0000000183789E50 0x000000018378B5C0-0x000000018378B660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestId { get => default; set {} } // 0x0000000183789D10-0x0000000183789DB0 0x000000018378AF40-0x000000018378AFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QuestConfigId { get => default; set {} } // 0x000000018378B4D0-0x000000018378B570 0x000000018378B260-0x000000018378B300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartGameTime { get => default; set {} } // 0x000000018378AD70-0x000000018378AE10 0x00000001837897D0-0x0000000183789870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AcceptTime { get => default; set {} } // 0x0000000183789870-0x0000000183789910 0x000000018378AE10-0x000000018378AEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> LackedNpcList { get => default; } // 0x0000000183789CB0-0x0000000183789D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FinishProgressList { get => default; } // 0x000000018378BB10-0x000000018378BB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FailProgressList { get => default; } // 0x0000000183789330-0x0000000183789390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> LackedNpcMap { get => default; } // 0x000000018378B390-0x000000018378B3F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> LackedPlaceList { get => default; } // 0x0000000183789490-0x00000001837894F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> LackedPlaceMap { get => default; } // 0x0000000183789C50-0x0000000183789CB0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Quest() {} // 0x000000018378C700-0x000000018378C840
	static Quest() {} // 0x000000018378C4F0-0x000000018378C700

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Quest Clone() => default; // 0x000000018378B170-0x000000018378B260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Quest ShallowCopy() => default; // 0x000000018378A880-0x000000018378A920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183789910-0x0000000183789960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018378B480-0x000000018378B4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018378B570-0x000000018378B5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183789960-0x0000000183789C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183789E50-0x0000000183789F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Quest other) => default; // 0x0000000183789F20-0x000000018378A220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018378AA10-0x000000018378AD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018378BD00-0x000000018378C4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018378B6C0-0x000000018378BAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018378A220-0x000000018378A620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Quest other) {} // 0x00000001837894F0-0x00000001837897D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183788EA0-0x0000000183789330
}

