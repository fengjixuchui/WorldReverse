/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeBattlePassRewardRsp : MessageBase, IMessage<TakeBattlePassRewardRsp> // TypeDefIndex: 22561
{
	// Fields
	private static readonly MessageParser<TakeBattlePassRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01DF3
	private int retcode_; // 0x18
	public const int TakeOptionListFieldNumber = 2; // Metadata: 0x00B01DF7
	private static readonly FieldCodec<BattlePassRewardTakeOption> _repeated_takeOptionList_codec; // 0x08
	private readonly RepeatedMessageField<BattlePassRewardTakeOption> takeOptionList_; // 0x20
	public const int ItemListFieldNumber = 3; // Metadata: 0x00B01DFB
	private static readonly FieldCodec<ItemParam> _repeated_itemList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> itemList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeBattlePassRewardRsp> Parser { get => default; } // 0x00000001829D66D0-0x00000001829D6760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001829D6400-0x00000001829D6490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001829D60D0-0x00000001829D6150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001829D5820-0x00000001829D5880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001829D6B50-0x00000001829D6C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001829D6930-0x00000001829D6990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001829D64F0-0x00000001829D65E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001829D6B00-0x00000001829D6B50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001829D61F0-0x00000001829D62E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001829D6030-0x00000001829D60D0 0x00000001829D5B90-0x00000001829D5C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<BattlePassRewardTakeOption> TakeOptionList { get => default; } // 0x00000001829D5FD0-0x00000001829D6030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemList { get => default; } // 0x00000001829D6490-0x00000001829D64F0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22562
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22563
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2606
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeBattlePassRewardRsp() {} // 0x00000001829D7000-0x00000001829D70B0
	static TakeBattlePassRewardRsp() {} // 0x00000001829D6EA0-0x00000001829D7000

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeBattlePassRewardRsp Clone() => default; // 0x00000001829D65E0-0x00000001829D66D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeBattlePassRewardRsp ShallowCopy() => default; // 0x00000001829D6150-0x00000001829D61F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001829D5A10-0x00000001829D5A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001829D67F0-0x00000001829D6890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001829D6890-0x00000001829D6930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001829D5A60-0x00000001829D5B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001829D5D80-0x00000001829D5E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeBattlePassRewardRsp other) => default; // 0x00000001829D5C30-0x00000001829D5D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001829D62E0-0x00000001829D6400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001829D6C40-0x00000001829D6EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001829D6990-0x00000001829D6B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001829D5E50-0x00000001829D5FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeBattlePassRewardRsp other) {} // 0x00000001829D5880-0x00000001829D5A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001829D5650-0x00000001829D5820
}

