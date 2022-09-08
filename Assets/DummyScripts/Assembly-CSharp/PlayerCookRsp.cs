/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerCookRsp : MessageBase, IMessage<PlayerCookRsp> // TypeDefIndex: 24378
{
	// Fields
	private static readonly MessageParser<PlayerCookRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B064EF
	private int retcode_; // 0x18
	public const int RecipeDataFieldNumber = 2; // Metadata: 0x00B064F3
	private CookRecipeData recipeData_; // 0x20
	public const int ItemListFieldNumber = 3; // Metadata: 0x00B064F7
	private static readonly FieldCodec<ItemParam> _repeated_itemList_codec; // 0x08
	private readonly RepeatedMessageField<ItemParam> itemList_; // 0x28
	public const int QteQualityFieldNumber = 4; // Metadata: 0x00B064FB
	private uint qteQuality_; // 0x30
	public const int CookCountFieldNumber = 5; // Metadata: 0x00B064FF
	private uint cookCount_; // 0x34
	public const int ExtralItemListFieldNumber = 6; // Metadata: 0x00B06503
	private static readonly FieldCodec<ItemParam> _repeated_extralItemList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> extralItemList_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerCookRsp> Parser { get => default; } // 0x0000000184382970-0x0000000184382A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184382600-0x0000000184382690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001843821C0-0x0000000184382240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184381250-0x00000001843812B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184382F10-0x0000000184383000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184382C10-0x0000000184382C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001843826F0-0x00000001843827E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184382EC0-0x0000000184382F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001843822E0-0x00000001843823D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001843820C0-0x0000000184382160 0x0000000184381A20-0x0000000184381AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CookRecipeData RecipeData { get => default; set {} } // 0x0000000184381980-0x0000000184381A20 0x0000000184381660-0x0000000184381700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ItemList { get => default; } // 0x0000000184382690-0x00000001843826F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QteQuality { get => default; set {} } // 0x0000000184381AC0-0x0000000184381B60 0x00000001843828D0-0x0000000184382970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CookCount { get => default; set {} } // 0x0000000184381350-0x00000001843813F0 0x00000001843812B0-0x0000000184381350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> ExtralItemList { get => default; } // 0x0000000184382160-0x00000001843821C0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24379
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24380
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 127
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCookRsp() {} // 0x0000000184383520-0x00000001843835D0
	static PlayerCookRsp() {} // 0x00000001843833E0-0x0000000184383520

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCookRsp Clone() => default; // 0x00000001843827E0-0x00000001843828D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCookRsp ShallowCopy() => default; // 0x0000000184382240-0x00000001843822E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184381700-0x0000000184381780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184382A90-0x0000000184382B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184382B50-0x0000000184382C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184381780-0x0000000184381980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184381D20-0x0000000184381DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerCookRsp other) => default; // 0x0000000184381B60-0x0000000184381D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001843823D0-0x0000000184382600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184383000-0x00000001843833E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184382C70-0x0000000184382EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184381DF0-0x00000001843820C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerCookRsp other) {} // 0x00000001843813F0-0x0000000184381660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184381000-0x0000000184381250
}

