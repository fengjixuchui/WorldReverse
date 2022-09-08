/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlessingFriendPicData : MessageBase, IMessage<BlessingFriendPicData> // TypeDefIndex: 22129
{
	// Fields
	private static readonly MessageParser<BlessingFriendPicData> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B00DB3
	private uint uid_; // 0x18
	public const int AvatarIdFieldNumber = 2; // Metadata: 0x00B00DB7
	private uint avatarId_; // 0x1C
	public const int SignatureFieldNumber = 3; // Metadata: 0x00B00DBB
	private string signature_; // 0x20
	public const int NicknameFieldNumber = 4; // Metadata: 0x00B00DBF
	private string nickname_; // 0x28
	public const int PicNumMapFieldNumber = 5; // Metadata: 0x00B00DC3
	private static readonly MapField<uint, uint> _map_picNumMap_codec; // 0x08
	private readonly MapField<uint, uint> picNumMap_; // 0x30
	public const int RemarkNameFieldNumber = 6; // Metadata: 0x00B00DC7
	private string remarkName_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlessingFriendPicData> Parser { get => default; } // 0x00000001843D66B0-0x00000001843D6740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001843D61C0-0x00000001843D6250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001843D5CA0-0x00000001843D5D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001843D5010-0x00000001843D5070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001843D6C50-0x00000001843D6D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001843D6870-0x00000001843D68D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001843D64D0-0x00000001843D65C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001843D6C00-0x00000001843D6C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001843D5DC0-0x00000001843D5EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001843D5AC0-0x00000001843D5B60 0x00000001843D6250-0x00000001843D62F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x00000001843D5B60-0x00000001843D5C00 0x00000001843D5C00-0x00000001843D5CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Signature { get => default; set {} } // 0x00000001843D6430-0x00000001843D64D0 0x00000001843D6110-0x00000001843D61C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Nickname { get => default; set {} } // 0x00000001843D62F0-0x00000001843D6390 0x00000001843D53E0-0x00000001843D5490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> PicNumMap { get => default; } // 0x00000001843D5490-0x00000001843D54F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string RemarkName { get => default; set {} } // 0x00000001843D6390-0x00000001843D6430 0x00000001843D68D0-0x00000001843D6980

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingFriendPicData() {} // 0x00000001843D7240-0x00000001843D72F0
	static BlessingFriendPicData() {} // 0x00000001843D7110-0x00000001843D7240

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingFriendPicData Clone() => default; // 0x00000001843D65C0-0x00000001843D66B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingFriendPicData ShallowCopy() => default; // 0x00000001843D5D20-0x00000001843D5DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001843D5280-0x00000001843D52D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843D67D0-0x00000001843D6820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843D6820-0x00000001843D6870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001843D52D0-0x00000001843D53E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001843D5740-0x00000001843D5810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlessingFriendPicData other) => default; // 0x00000001843D54F0-0x00000001843D5740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001843D5EB0-0x00000001843D6110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001843D6D40-0x00000001843D7110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001843D6980-0x00000001843D6C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001843D5810-0x00000001843D5AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlessingFriendPicData other) {} // 0x00000001843D5070-0x00000001843D5280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001843D4E30-0x00000001843D5010
}

