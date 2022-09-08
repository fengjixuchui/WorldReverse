/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusCardResultNotify : MessageBase, IMessage<InBattleMechanicusCardResultNotify> // TypeDefIndex: 24147
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusCardResultNotify> _parser; // 0x00
	public const int PlayIndexFieldNumber = 1; // Metadata: 0x00B05B2F
	private uint playIndex_; // 0x18
	public const int GroupIdFieldNumber = 2; // Metadata: 0x00B05B33
	private uint groupId_; // 0x1C
	public const int WaitBeginTimeUsFieldNumber = 3; // Metadata: 0x00B05B37
	private ulong waitBeginTimeUs_; // 0x20
	public const int WaitSecondsFieldNumber = 4; // Metadata: 0x00B05B3B
	private uint waitSeconds_; // 0x28
	public const int CardListFieldNumber = 5; // Metadata: 0x00B05B3F
	private static readonly FieldCodec<InBattleMechanicusCardInfo> _repeated_cardList_codec; // 0x08
	private readonly RepeatedMessageField<InBattleMechanicusCardInfo> cardList_; // 0x30
	public const int PlayerConfirmedCardMapFieldNumber = 6; // Metadata: 0x00B05B43
	private static readonly MapField<uint, uint> _map_playerConfirmedCardMap_codec; // 0x10
	private readonly MapField<uint, uint> playerConfirmedCardMap_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusCardResultNotify> Parser { get => default; } // 0x00000001832CB8A0-0x00000001832CB930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001832CB450-0x00000001832CB4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001832CB050-0x00000001832CB0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001832CA410-0x00000001832CA470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001832CBE60-0x00000001832CBF50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001832CBAE0-0x00000001832CBB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001832CB580-0x00000001832CB670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001832CBE10-0x00000001832CBE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001832CB170-0x00000001832CB260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayIndex { get => default; set {} } // 0x00000001832CAF10-0x00000001832CAFB0 0x00000001832CB4E0-0x00000001832CB580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x00000001832CB670-0x00000001832CB710 0x00000001832CAFB0-0x00000001832CB050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong WaitBeginTimeUs { get => default; set {} } // 0x00000001832CA470-0x00000001832CA510 0x00000001832CA920-0x00000001832CA9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WaitSeconds { get => default; set {} } // 0x00000001832CBB40-0x00000001832CBBE0 0x00000001832CB800-0x00000001832CB8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<InBattleMechanicusCardInfo> CardList { get => default; } // 0x00000001832CAEB0-0x00000001832CAF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> PlayerConfirmedCardMap { get => default; } // 0x00000001832CA760-0x00000001832CA7C0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24148
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24149
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5314
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusCardResultNotify() {} // 0x00000001832CC4D0-0x00000001832CC580
	static InBattleMechanicusCardResultNotify() {} // 0x00000001832CC350-0x00000001832CC4D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusCardResultNotify Clone() => default; // 0x00000001832CB710-0x00000001832CB800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusCardResultNotify ShallowCopy() => default; // 0x00000001832CB0D0-0x00000001832CB170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001832CA710-0x00000001832CA760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832CB9C0-0x00000001832CBA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832CBA50-0x00000001832CBAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001832CA7C0-0x00000001832CA920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001832CAB90-0x00000001832CAC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusCardResultNotify other) => default; // 0x00000001832CA9C0-0x00000001832CAB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001832CB260-0x00000001832CB450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001832CBF50-0x00000001832CC350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001832CBBE0-0x00000001832CBE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001832CAC60-0x00000001832CAEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusCardResultNotify other) {} // 0x00000001832CA510-0x00000001832CA710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001832CA1F0-0x00000001832CA410
}

