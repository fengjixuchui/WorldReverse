/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerDailyRewardProgressChangeNotify : MessageBase, IMessage<TowerDailyRewardProgressChangeNotify> // TypeDefIndex: 25706
{
	// Fields
	private static readonly MessageParser<TowerDailyRewardProgressChangeNotify> _parser; // 0x00
	public const int DailyFloorIdFieldNumber = 1; // Metadata: 0x00B09637
	private uint dailyFloorId_; // 0x18
	public const int DailyLevelIndexFieldNumber = 2; // Metadata: 0x00B0963B
	private uint dailyLevelIndex_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerDailyRewardProgressChangeNotify> Parser { get => default; } // 0x0000000181D5F760-0x0000000181D5F7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D5F450-0x0000000181D5F4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D5F0A0-0x0000000181D5F120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D5EA90-0x0000000181D5EAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D5FAF0-0x0000000181D5FBE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D5F920-0x0000000181D5F980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D5F4E0-0x0000000181D5F5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D5FAA0-0x0000000181D5FAF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D5F1C0-0x0000000181D5F2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DailyFloorId { get => default; set {} } // 0x0000000181D5F000-0x0000000181D5F0A0 0x0000000181D5F6C0-0x0000000181D5F760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DailyLevelIndex { get => default; set {} } // 0x0000000181D5F3B0-0x0000000181D5F450 0x0000000181D5E9F0-0x0000000181D5EA90

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25707
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25708
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2404
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerDailyRewardProgressChangeNotify() {} // 0x0000000181D5FEA0-0x0000000181D5FF00
	static TowerDailyRewardProgressChangeNotify() {} // 0x0000000181D5FDE0-0x0000000181D5FEA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerDailyRewardProgressChangeNotify Clone() => default; // 0x0000000181D5F5D0-0x0000000181D5F6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerDailyRewardProgressChangeNotify ShallowCopy() => default; // 0x0000000181D5F120-0x0000000181D5F1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D5EC20-0x0000000181D5EC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D5F880-0x0000000181D5F8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D5F8D0-0x0000000181D5F920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D5EC70-0x0000000181D5ECE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D5EE00-0x0000000181D5EED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerDailyRewardProgressChangeNotify other) => default; // 0x0000000181D5ECE0-0x0000000181D5EE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D5F2B0-0x0000000181D5F3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D5FBE0-0x0000000181D5FDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D5F980-0x0000000181D5FAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D5EED0-0x0000000181D5F000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerDailyRewardProgressChangeNotify other) {} // 0x0000000181D5EAF0-0x0000000181D5EC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D5E8F0-0x0000000181D5E9F0
}

