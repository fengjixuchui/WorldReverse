/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlessingGiveFriendPicReq : MessageBase, IMessage<BlessingGiveFriendPicReq> // TypeDefIndex: 22137
{
	// Fields
	private static readonly MessageParser<BlessingGiveFriendPicReq> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B00E17
	private uint uid_; // 0x18
	public const int PicIdFieldNumber = 2; // Metadata: 0x00B00E1B
	private uint picId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlessingGiveFriendPicReq> Parser { get => default; } // 0x000000018235F1F0-0x000000018235F280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018235EE40-0x000000018235EED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018235EA90-0x000000018235EB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018235E480-0x000000018235E4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018235F580-0x000000018235F670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018235F3B0-0x000000018235F410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018235F010-0x000000018235F100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018235F530-0x000000018235F580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018235EC50-0x000000018235ED40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x000000018235E9F0-0x000000018235EA90 0x000000018235EED0-0x000000018235EF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PicId { get => default; set {} } // 0x000000018235EBB0-0x000000018235EC50 0x000000018235EF70-0x000000018235F010

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22138
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22139
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2147
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingGiveFriendPicReq() {} // 0x000000018235F930-0x000000018235F990
	static BlessingGiveFriendPicReq() {} // 0x000000018235F870-0x000000018235F930

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingGiveFriendPicReq Clone() => default; // 0x000000018235F100-0x000000018235F1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlessingGiveFriendPicReq ShallowCopy() => default; // 0x000000018235EB10-0x000000018235EBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018235E610-0x000000018235E660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018235F310-0x000000018235F360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018235F360-0x000000018235F3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018235E660-0x000000018235E6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018235E7F0-0x000000018235E8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlessingGiveFriendPicReq other) => default; // 0x000000018235E6D0-0x000000018235E7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018235ED40-0x000000018235EE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018235F670-0x000000018235F870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018235F410-0x000000018235F530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018235E8C0-0x000000018235E9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlessingGiveFriendPicReq other) {} // 0x000000018235E4E0-0x000000018235E610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018235E380-0x000000018235E480
}

