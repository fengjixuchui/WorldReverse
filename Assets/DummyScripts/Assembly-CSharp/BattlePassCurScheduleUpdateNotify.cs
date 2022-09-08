/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BattlePassCurScheduleUpdateNotify : MessageBase, IMessage<BattlePassCurScheduleUpdateNotify> // TypeDefIndex: 22554
{
	// Fields
	private static readonly MessageParser<BattlePassCurScheduleUpdateNotify> _parser; // 0x00
	public const int HaveCurScheduleFieldNumber = 1; // Metadata: 0x00B01DBB
	private bool haveCurSchedule_; // 0x18
	public const int CurScheduleFieldNumber = 2; // Metadata: 0x00B01DBF
	private BattlePassSchedule curSchedule_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BattlePassCurScheduleUpdateNotify> Parser { get => default; } // 0x0000000184869FA0-0x000000018486A030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184869C90-0x0000000184869D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184869900-0x0000000184869980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001848690C0-0x0000000184869120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018486A390-0x000000018486A480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018486A1C0-0x000000018486A220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184869DC0-0x0000000184869EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018486A340-0x000000018486A390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184869A20-0x0000000184869B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool HaveCurSchedule { get => default; set {} } // 0x0000000184869D20-0x0000000184869DC0 0x0000000184868EE0-0x0000000184868F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassSchedule CurSchedule { get => default; set {} } // 0x0000000184869450-0x00000001848694F0 0x00000001848694F0-0x0000000184869590

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22555
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22556
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2604
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassCurScheduleUpdateNotify() {} // 0x000000018486A720-0x000000018486A780
	static BattlePassCurScheduleUpdateNotify() {} // 0x000000018486A660-0x000000018486A720

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassCurScheduleUpdateNotify Clone() => default; // 0x0000000184869EB0-0x0000000184869FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassCurScheduleUpdateNotify ShallowCopy() => default; // 0x0000000184869980-0x0000000184869A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001848692A0-0x0000000184869320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018486A0C0-0x000000018486A140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018486A140-0x000000018486A1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184869320-0x0000000184869450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001848696C0-0x0000000184869790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BattlePassCurScheduleUpdateNotify other) => default; // 0x0000000184869590-0x00000001848696C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184869B10-0x0000000184869C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018486A480-0x000000018486A660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018486A220-0x000000018486A340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184869790-0x0000000184869900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BattlePassCurScheduleUpdateNotify other) {} // 0x0000000184869120-0x00000001848692A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184868F80-0x00000001848690C0
}

