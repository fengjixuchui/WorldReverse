/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerHomeCompInfo : MessageBase, IMessage<PlayerHomeCompInfo> // TypeDefIndex: 23356
{
	// Fields
	private static readonly MessageParser<PlayerHomeCompInfo> _parser; // 0x00
	public const int FriendEnterHomeOptionFieldNumber = 1; // Metadata: 0x00B03D8F
	private FriendEnterHomeOption friendEnterHomeOption_; // 0x18
	public const int UnlockedModuleIdListFieldNumber = 2; // Metadata: 0x00B03D93
	private static readonly FieldCodec<uint> _repeated_unlockedModuleIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> unlockedModuleIdList_; // 0x20
	public const int LevelupRewardGotLevelListFieldNumber = 3; // Metadata: 0x00B03D97
	private static readonly FieldCodec<uint> _repeated_levelupRewardGotLevelList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> levelupRewardGotLevelList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerHomeCompInfo> Parser { get => default; } // 0x00000001850AB640-0x00000001850AB6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001850AB230-0x00000001850AB2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001850AAEC0-0x00000001850AAF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001850AA7F0-0x00000001850AA850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001850ABA80-0x00000001850ABB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001850AB800-0x00000001850AB860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001850AB400-0x00000001850AB4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001850ABA30-0x00000001850ABA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001850AAFE0-0x00000001850AB0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FriendEnterHomeOption FriendEnterHomeOption { get => default; set {} } // 0x00000001850AB2C0-0x00000001850AB360 0x00000001850AB360-0x00000001850AB400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> UnlockedModuleIdList { get => default; } // 0x00000001850AB860-0x00000001850AB8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> LevelupRewardGotLevelList { get => default; } // 0x00000001850AB5E0-0x00000001850AB640 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerHomeCompInfo() {} // 0x00000001850ABED0-0x00000001850ABF90
	static PlayerHomeCompInfo() {} // 0x00000001850ABDD0-0x00000001850ABED0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerHomeCompInfo Clone() => default; // 0x00000001850AB4F0-0x00000001850AB5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerHomeCompInfo ShallowCopy() => default; // 0x00000001850AAF40-0x00000001850AAFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001850AA9A0-0x00000001850AA9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850AB760-0x00000001850AB7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850AB7B0-0x00000001850AB800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001850AA9F0-0x00000001850AAB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001850AAB20-0x00000001850AABF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerHomeCompInfo other) => default; // 0x00000001850AABF0-0x00000001850AAD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001850AB0D0-0x00000001850AB230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001850ABB70-0x00000001850ABDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001850AB8C0-0x00000001850ABA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001850AAD40-0x00000001850AAEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerHomeCompInfo other) {} // 0x00000001850AA850-0x00000001850AA9A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001850AA620-0x00000001850AA7F0
}

