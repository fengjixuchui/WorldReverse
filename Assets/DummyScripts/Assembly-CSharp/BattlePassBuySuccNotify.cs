/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BattlePassBuySuccNotify : MessageBase, IMessage<BattlePassBuySuccNotify> // TypeDefIndex: 22582
{
	// Fields
	private static readonly MessageParser<BattlePassBuySuccNotify> _parser; // 0x00
	public const int ScheduleIdFieldNumber = 1; // Metadata: 0x00B01EAB
	private uint scheduleId_; // 0x18
	public const int ProductPlayTypeFieldNumber = 2; // Metadata: 0x00B01EAF
	private uint productPlayType_; // 0x1C
	public const int ItemListFieldNumber = 3; // Metadata: 0x00B01EB3
	private static readonly FieldCodec<ItemParam> _repeated_itemList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> itemList_; // 0x20
	public const int AddPointFieldNumber = 4; // Metadata: 0x00B01EB7
	private uint addPoint_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BattlePassBuySuccNotify> Parser { get => default; } // 0x0000000184063250-0x00000001840632E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184062F80-0x0000000184063010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184062C10-0x0000000184062C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001840622B0-0x0000000184062310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184063840-0x0000000184063930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184063490-0x00000001840634F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184063070-0x0000000184063160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001840637F0-0x0000000184063840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184062D30-0x0000000184062E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ScheduleId { get => default; set {} } // 0x00000001840626B0-0x0000000184062750 0x00000001840634F0-0x0000000184063590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ProductPlayType { get => default; set {} } // 0x0000000184062750-0x00000001840627F0 0x0000000184062510-0x00000001840625B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemList { get => default; } // 0x0000000184063010-0x0000000184063070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AddPoint { get => default; set {} } // 0x0000000184063590-0x0000000184063630 0x0000000184062210-0x00000001840622B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22583
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22584
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2615
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassBuySuccNotify() {} // 0x0000000184063D40-0x0000000184063DD0
	static BattlePassBuySuccNotify() {} // 0x0000000184063C30-0x0000000184063D40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassBuySuccNotify Clone() => default; // 0x0000000184063160-0x0000000184063250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassBuySuccNotify ShallowCopy() => default; // 0x0000000184062C90-0x0000000184062D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001840624C0-0x0000000184062510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184063370-0x0000000184063400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184063400-0x0000000184063490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001840625B0-0x00000001840626B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001840627F0-0x00000001840628C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BattlePassBuySuccNotify other) => default; // 0x00000001840628C0-0x0000000184062A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184062E20-0x0000000184062F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184063930-0x0000000184063C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184063630-0x00000001840637F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184062A30-0x0000000184062C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BattlePassBuySuccNotify other) {} // 0x0000000184062310-0x00000001840624C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184062070-0x0000000184062210
}

