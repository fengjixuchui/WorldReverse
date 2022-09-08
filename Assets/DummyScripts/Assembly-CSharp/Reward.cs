/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Reward : MessageBase, IMessage<Reward> // TypeDefIndex: 25989
{
	// Fields
	private static readonly MessageParser<Reward> _parser; // 0x00
	public const int RewardIdFieldNumber = 1; // Metadata: 0x00B0A93B
	private uint rewardId_; // 0x18
	public const int ItemListFieldNumber = 2; // Metadata: 0x00B0A93F
	private static readonly FieldCodec<ItemParam> _repeated_itemList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> itemList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Reward> Parser { get => default; } // 0x000000018286D950-0x000000018286D9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018286D5E0-0x000000018286D670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018286D2D0-0x000000018286D350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018286CCA0-0x000000018286CD00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018286DE20-0x000000018286DF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018286DC30-0x000000018286DC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018286D6D0-0x000000018286D7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018286DDD0-0x000000018286DE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018286D3F0-0x000000018286D4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RewardId { get => default; set {} } // 0x000000018286DB90-0x000000018286DC30 0x000000018286D8B0-0x000000018286D950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemList { get => default; } // 0x000000018286D670-0x000000018286D6D0 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Reward() {} // 0x000000018286E200-0x000000018286E290
	static Reward() {} // 0x000000018286E0F0-0x000000018286E200

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Reward Clone() => default; // 0x000000018286D7C0-0x000000018286D8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Reward ShallowCopy() => default; // 0x000000018286D350-0x000000018286D3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018286CE60-0x000000018286CEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018286DA70-0x000000018286DB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018286DB00-0x000000018286DB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018286CEB0-0x000000018286CF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018286D0C0-0x000000018286D190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Reward other) => default; // 0x000000018286CF90-0x000000018286D0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018286D4E0-0x000000018286D5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018286DF10-0x000000018286E0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018286DC90-0x000000018286DDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018286D190-0x000000018286D2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Reward other) {} // 0x000000018286CD00-0x000000018286CE60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018286CB40-0x000000018286CCA0
}

