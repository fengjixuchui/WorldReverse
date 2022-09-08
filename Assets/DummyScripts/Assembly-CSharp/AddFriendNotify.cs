/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AddFriendNotify : MessageBase, IMessage<AddFriendNotify> // TypeDefIndex: 25588
{
	// Fields
	private static readonly MessageParser<AddFriendNotify> _parser; // 0x00
	public const int TargetUidFieldNumber = 1; // Metadata: 0x00B09217
	private uint targetUid_; // 0x18
	public const int TargetFriendBriefFieldNumber = 2; // Metadata: 0x00B0921B
	private FriendBrief targetFriendBrief_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AddFriendNotify> Parser { get => default; } // 0x000000018373F070-0x000000018373F100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018373ED60-0x000000018373EDF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018373E930-0x000000018373E9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018373E0C0-0x000000018373E120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018373F460-0x000000018373F550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018373F290-0x000000018373F2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018373EDF0-0x000000018373EEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018373F410-0x000000018373F460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018373EA50-0x000000018373EB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x000000018373ECC0-0x000000018373ED60 0x000000018373E890-0x000000018373E930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FriendBrief TargetFriendBrief { get => default; set {} } // 0x000000018373E120-0x000000018373E1C0 0x000000018373EFD0-0x000000018373F070

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25589
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25590
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4021
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddFriendNotify() {} // 0x000000018373F7F0-0x000000018373F850
	static AddFriendNotify() {} // 0x000000018373F730-0x000000018373F7F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddFriendNotify Clone() => default; // 0x000000018373EEE0-0x000000018373EFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AddFriendNotify ShallowCopy() => default; // 0x000000018373E9B0-0x000000018373EA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018373E340-0x000000018373E3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018373F190-0x000000018373F210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018373F210-0x000000018373F290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018373E3C0-0x000000018373E4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018373E620-0x000000018373E6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AddFriendNotify other) => default; // 0x000000018373E4F0-0x000000018373E620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018373EB40-0x000000018373ECC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018373F550-0x000000018373F730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018373F2F0-0x000000018373F410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018373E6F0-0x000000018373E890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AddFriendNotify other) {} // 0x000000018373E1C0-0x000000018373E340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018373DF80-0x000000018373E0C0
}

