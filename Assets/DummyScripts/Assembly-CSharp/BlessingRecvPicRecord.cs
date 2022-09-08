/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlessingRecvPicRecord : MessageBase, IMessage<BlessingRecvPicRecord> // TypeDefIndex: 22130
{
	// Fields
	private static readonly MessageParser<BlessingRecvPicRecord> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B00DCB
	private uint uid_; // 0x18
	public const int AvatarIdFieldNumber = 2; // Metadata: 0x00B00DCF
	private uint avatarId_; // 0x1C
	public const int NicknameFieldNumber = 3; // Metadata: 0x00B00DD3
	private string nickname_; // 0x20
	public const int SignatureFieldNumber = 4; // Metadata: 0x00B00DD7
	private string signature_; // 0x28
	public const int PicIdFieldNumber = 5; // Metadata: 0x00B00DDB
	private uint picId_; // 0x30
	public const int IsRecvFieldNumber = 6; // Metadata: 0x00B00DDF
	private bool isRecv_; // 0x34
	public const int IndexFieldNumber = 7; // Metadata: 0x00B00DE3
	private uint index_; // 0x38
	public const int RemarkNameFieldNumber = 8; // Metadata: 0x00B00DE7
	private string remarkName_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlessingRecvPicRecord> Parser { get => default; } // 0x00000001832A7320-0x00000001832A73B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001832A6D90-0x00000001832A6E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001832A6660-0x00000001832A66E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001832A5910-0x00000001832A5970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001832A79C0-0x00000001832A7AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001832A7580-0x00000001832A75E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001832A7140-0x00000001832A7230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001832A7970-0x00000001832A79C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001832A68C0-0x00000001832A69B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001832A6480-0x00000001832A6520 0x00000001832A6E20-0x00000001832A6EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x00000001832A6520-0x00000001832A65C0 0x00000001832A65C0-0x00000001832A6660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Nickname { get => default; set {} } // 0x00000001832A6EC0-0x00000001832A6F60 0x00000001832A5CF0-0x00000001832A5DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Signature { get => default; set {} } // 0x00000001832A7000-0x00000001832A70A0 0x00000001832A6C40-0x00000001832A6CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PicId { get => default; set {} } // 0x00000001832A6820-0x00000001832A68C0 0x00000001832A70A0-0x00000001832A7140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsRecv { get => default; set {} } // 0x00000001832A73B0-0x00000001832A7450 0x00000001832A6780-0x00000001832A6820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Index { get => default; set {} } // 0x00000001832A63E0-0x00000001832A6480 0x00000001832A6CF0-0x00000001832A6D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string RemarkName { get => default; set {} } // 0x00000001832A6F60-0x00000001832A7000 0x00000001832A75E0-0x00000001832A7690

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingRecvPicRecord() {} // 0x00000001832A8070-0x00000001832A8100
	static BlessingRecvPicRecord() {} // 0x00000001832A7FB0-0x00000001832A8070

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingRecvPicRecord Clone() => default; // 0x00000001832A7230-0x00000001832A7320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingRecvPicRecord ShallowCopy() => default; // 0x00000001832A66E0-0x00000001832A6780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001832A5BD0-0x00000001832A5C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832A74E0-0x00000001832A7530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832A7530-0x00000001832A7580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001832A5C20-0x00000001832A5CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001832A5DA0-0x00000001832A5E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlessingRecvPicRecord other) => default; // 0x00000001832A5E70-0x00000001832A60E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001832A69B0-0x00000001832A6C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001832A7AB0-0x00000001832A7FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001832A7690-0x00000001832A7970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001832A60E0-0x00000001832A63E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlessingRecvPicRecord other) {} // 0x00000001832A5970-0x00000001832A5BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001832A5760-0x00000001832A5910
}

