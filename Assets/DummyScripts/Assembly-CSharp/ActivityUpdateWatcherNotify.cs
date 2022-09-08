/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ActivityUpdateWatcherNotify : MessageBase, IMessage<ActivityUpdateWatcherNotify> // TypeDefIndex: 21880
{
	// Fields
	private static readonly MessageParser<ActivityUpdateWatcherNotify> _parser; // 0x00
	public const int ActivityIdFieldNumber = 1; // Metadata: 0x00B0040B
	private uint activityId_; // 0x18
	public const int WatcherInfoFieldNumber = 2; // Metadata: 0x00B0040F
	private ActivityWatcherInfo watcherInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ActivityUpdateWatcherNotify> Parser { get => default; } // 0x000000018519E4B0-0x000000018519E540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018519E240-0x000000018519E2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018519DE10-0x000000018519DE90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018519D5A0-0x000000018519D600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018519E940-0x000000018519EA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018519E770-0x000000018519E7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018519E2D0-0x000000018519E3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018519E8F0-0x000000018519E940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018519DFD0-0x000000018519E0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ActivityId { get => default; set {} } // 0x000000018519E6D0-0x000000018519E770 0x000000018519D6A0-0x000000018519D740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityWatcherInfo WatcherInfo { get => default; set {} } // 0x000000018519DE90-0x000000018519DF30 0x000000018519D600-0x000000018519D6A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21881
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21882
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2010
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityUpdateWatcherNotify() {} // 0x000000018519ECD0-0x000000018519ED30
	static ActivityUpdateWatcherNotify() {} // 0x000000018519EC10-0x000000018519ECD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityUpdateWatcherNotify Clone() => default; // 0x000000018519E3C0-0x000000018519E4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ActivityUpdateWatcherNotify ShallowCopy() => default; // 0x000000018519DF30-0x000000018519DFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018519D8C0-0x000000018519D940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018519E5D0-0x000000018519E650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018519E650-0x000000018519E6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018519D940-0x000000018519DA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018519DA70-0x000000018519DB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ActivityUpdateWatcherNotify other) => default; // 0x000000018519DB40-0x000000018519DC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018519E0C0-0x000000018519E240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018519EA30-0x000000018519EC10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018519E7D0-0x000000018519E8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018519DC70-0x000000018519DE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ActivityUpdateWatcherNotify other) {} // 0x000000018519D740-0x000000018519D8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018519D460-0x000000018519D5A0
}

