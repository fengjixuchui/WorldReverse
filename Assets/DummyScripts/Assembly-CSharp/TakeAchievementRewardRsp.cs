/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TakeAchievementRewardRsp : MessageBase, IMessage<TakeAchievementRewardRsp> // TypeDefIndex: 21840
{
	// Fields
	private static readonly MessageParser<TakeAchievementRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B001CB
	private int retcode_; // 0x18
	public const int IdListFieldNumber = 2; // Metadata: 0x00B001CF
	private static readonly FieldCodec<uint> _repeated_idList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> idList_; // 0x20
	public const int ItemListFieldNumber = 3; // Metadata: 0x00B001D3
	private static readonly FieldCodec<ItemParam> _repeated_itemList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> itemList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TakeAchievementRewardRsp> Parser { get => default; } // 0x0000000181C48720-0x0000000181C487B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181C48450-0x0000000181C484E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181C48120-0x0000000181C481A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181C47870-0x0000000181C478D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181C48B80-0x0000000181C48C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181C48960-0x0000000181C489C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181C48540-0x0000000181C48630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181C48B30-0x0000000181C48B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181C48240-0x0000000181C48330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181C48080-0x0000000181C48120 0x0000000181C47BE0-0x0000000181C47C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> IdList { get => default; } // 0x0000000181C47C80-0x0000000181C47CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemList { get => default; } // 0x0000000181C484E0-0x0000000181C48540 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21841
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21842
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2654
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAchievementRewardRsp() {} // 0x0000000181C49000-0x0000000181C490B0
	static TakeAchievementRewardRsp() {} // 0x0000000181C48ED0-0x0000000181C49000

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAchievementRewardRsp Clone() => default; // 0x0000000181C48630-0x0000000181C48720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TakeAchievementRewardRsp ShallowCopy() => default; // 0x0000000181C481A0-0x0000000181C48240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181C47A50-0x0000000181C47AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C48840-0x0000000181C488D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181C488D0-0x0000000181C48960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181C47AA0-0x0000000181C47BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181C47E30-0x0000000181C47F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TakeAchievementRewardRsp other) => default; // 0x0000000181C47CE0-0x0000000181C47E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181C48330-0x0000000181C48450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181C48C70-0x0000000181C48ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181C489C0-0x0000000181C48B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181C47F00-0x0000000181C48080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TakeAchievementRewardRsp other) {} // 0x0000000181C478D0-0x0000000181C47A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181C47690-0x0000000181C47870
}

