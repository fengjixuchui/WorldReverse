/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TreasureMapBonusChallengeNotify : MessageBase, IMessage<TreasureMapBonusChallengeNotify> // TypeDefIndex: 22110
{
	// Fields
	private static readonly MessageParser<TreasureMapBonusChallengeNotify> _parser; // 0x00
	public const int InfoFieldNumber = 1; // Metadata: 0x00B00D0F
	private TreasureMapBonusChallengeInfo info_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TreasureMapBonusChallengeNotify> Parser { get => default; } // 0x000000018368B050-0x000000018368B0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018368ADE0-0x000000018368AE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018368AA80-0x000000018368AB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018368A350-0x000000018368A3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018368B4A0-0x000000018368B590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018368B310-0x000000018368B370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018368AE70-0x000000018368AF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018368B450-0x000000018368B4A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018368ABA0-0x000000018368AC90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapBonusChallengeInfo Info { get => default; set {} } // 0x000000018368A6B0-0x000000018368A750 0x000000018368B270-0x000000018368B310

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22111
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22112
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2127
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapBonusChallengeNotify() {} // 0x000000018368B7A0-0x000000018368B800
	static TreasureMapBonusChallengeNotify() {} // 0x000000018368B6E0-0x000000018368B7A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapBonusChallengeNotify Clone() => default; // 0x000000018368AF60-0x000000018368B050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TreasureMapBonusChallengeNotify ShallowCopy() => default; // 0x000000018368AB00-0x000000018368ABA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018368A510-0x000000018368A590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018368B170-0x000000018368B1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018368B1F0-0x000000018368B270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018368A590-0x000000018368A6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018368A750-0x000000018368A820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TreasureMapBonusChallengeNotify other) => default; // 0x000000018368A820-0x000000018368A930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018368AC90-0x000000018368ADE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018368B590-0x000000018368B6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018368B370-0x000000018368B450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018368A930-0x000000018368AA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TreasureMapBonusChallengeNotify other) {} // 0x000000018368A3B0-0x000000018368A510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018368A240-0x000000018368A350
}

