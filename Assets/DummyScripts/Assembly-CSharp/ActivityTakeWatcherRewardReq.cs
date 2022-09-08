/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityTakeWatcherRewardReq : MessageBase, IMessage<ActivityTakeWatcherRewardReq> // TypeDefIndex: 21874
{
	// Fields
	private static readonly MessageParser<ActivityTakeWatcherRewardReq> _parser; // 0x00
	public const int ActivityIdFieldNumber = 1; // Metadata: 0x00B003D3
	private uint activityId_; // 0x18
	public const int WatcherIdFieldNumber = 2; // Metadata: 0x00B003D7
	private uint watcherId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivityTakeWatcherRewardReq> Parser { get => default; } // 0x00000001841BE080-0x00000001841BE110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001841BDCD0-0x00000001841BDD60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001841BD9C0-0x00000001841BDA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001841BD3B0-0x00000001841BD410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001841BE4B0-0x00000001841BE5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001841BE2E0-0x00000001841BE340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001841BDEA0-0x00000001841BDF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001841BE460-0x00000001841BE4B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001841BDAE0-0x00000001841BDBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x00000001841BE240-0x00000001841BE2E0 0x00000001841BD410-0x00000001841BD4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WatcherId { get => default; set {} } // 0x00000001841BDE00-0x00000001841BDEA0 0x00000001841BDD60-0x00000001841BDE00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21875
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21876
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2008
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeWatcherRewardReq() {} // 0x00000001841BE860-0x00000001841BE8C0
	static ActivityTakeWatcherRewardReq() {} // 0x00000001841BE7A0-0x00000001841BE860

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeWatcherRewardReq Clone() => default; // 0x00000001841BDF90-0x00000001841BE080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityTakeWatcherRewardReq ShallowCopy() => default; // 0x00000001841BDA40-0x00000001841BDAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001841BD5E0-0x00000001841BD630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841BE1A0-0x00000001841BE1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841BE1F0-0x00000001841BE240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001841BD630-0x00000001841BD6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001841BD6A0-0x00000001841BD770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivityTakeWatcherRewardReq other) => default; // 0x00000001841BD770-0x00000001841BD890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001841BDBD0-0x00000001841BDCD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001841BE5A0-0x00000001841BE7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001841BE340-0x00000001841BE460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001841BD890-0x00000001841BD9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivityTakeWatcherRewardReq other) {} // 0x00000001841BD4B0-0x00000001841BD5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001841BD2B0-0x00000001841BD3B0
}

