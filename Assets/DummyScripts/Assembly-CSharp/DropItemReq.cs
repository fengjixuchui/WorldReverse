/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DropItemReq : MessageBase, IMessage<DropItemReq> // TypeDefIndex: 23630
{
	// Fields
	private static readonly MessageParser<DropItemReq> _parser; // 0x00
	public const int StoreTypeFieldNumber = 1; // Metadata: 0x00B0474B
	private StoreType storeType_; // 0x18
	public const int GuidFieldNumber = 2; // Metadata: 0x00B0474F
	private ulong guid_; // 0x20
	public const int CountFieldNumber = 3; // Metadata: 0x00B04753
	private uint count_; // 0x28
	public const int PosFieldNumber = 4; // Metadata: 0x00B04757
	private Vector pos_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DropItemReq> Parser { get => default; } // 0x0000000184ACE910-0x0000000184ACE9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184ACE6A0-0x0000000184ACE730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184ACE270-0x0000000184ACE2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184ACD780-0x0000000184ACD7E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184ACEF60-0x0000000184ACF050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184ACEC70-0x0000000184ACECD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184ACE730-0x0000000184ACE820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184ACEF10-0x0000000184ACEF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184ACE390-0x0000000184ACE480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StoreType StoreType { get => default; set {} } // 0x0000000184ACDA50-0x0000000184ACDAF0 0x0000000184ACDD60-0x0000000184ACDE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x0000000184ACD9B0-0x0000000184ACDA50 0x0000000184ACDCC0-0x0000000184ACDD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Count { get => default; set {} } // 0x0000000184ACEA30-0x0000000184ACEAD0 0x0000000184ACD6E0-0x0000000184ACD780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000184ACEBD0-0x0000000184ACEC70 0x0000000184ACEE70-0x0000000184ACEF10

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23631
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23632
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 610
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropItemReq() {} // 0x0000000184ACF410-0x0000000184ACF480
	static DropItemReq() {} // 0x0000000184ACF350-0x0000000184ACF410

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropItemReq Clone() => default; // 0x0000000184ACE820-0x0000000184ACE910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DropItemReq ShallowCopy() => default; // 0x0000000184ACE2F0-0x0000000184ACE390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184ACDAF0-0x0000000184ACDB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184ACEAD0-0x0000000184ACEB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184ACEB50-0x0000000184ACEBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184ACDB70-0x0000000184ACDCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184ACDF70-0x0000000184ACE040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DropItemReq other) => default; // 0x0000000184ACDE00-0x0000000184ACDF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184ACE480-0x0000000184ACE6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184ACF050-0x0000000184ACF350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184ACECD0-0x0000000184ACEE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184ACE040-0x0000000184ACE270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DropItemReq other) {} // 0x0000000184ACD7E0-0x0000000184ACD9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184ACD570-0x0000000184ACD6E0
}

