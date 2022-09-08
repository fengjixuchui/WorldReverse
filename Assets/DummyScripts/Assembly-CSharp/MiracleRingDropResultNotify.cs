/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MiracleRingDropResultNotify : MessageBase, IMessage<MiracleRingDropResultNotify> // TypeDefIndex: 23935
{
	// Fields
	private static readonly MessageParser<MiracleRingDropResultNotify> _parser; // 0x00
	public const int DropResultFieldNumber = 1; // Metadata: 0x00B052AF
	private int dropResult_; // 0x18
	public const int LastTakeRewardTimeFieldNumber = 2; // Metadata: 0x00B052B3
	private int lastTakeRewardTime_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MiracleRingDropResultNotify> Parser { get => default; } // 0x0000000181365370-0x0000000181365400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181365060-0x00000001813650F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181364D50-0x0000000181364DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001813646A0-0x0000000181364700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181365700-0x00000001813657F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181365530-0x0000000181365590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181365190-0x0000000181365280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001813656B0-0x0000000181365700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181364E70-0x0000000181364F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int DropResult { get => default; set {} } // 0x0000000181364CB0-0x0000000181364D50 0x00000001813657F0-0x0000000181365890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int LastTakeRewardTime { get => default; set {} } // 0x0000000181364700-0x00000001813647A0 0x00000001813650F0-0x0000000181365190

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23936
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23937
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5206
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingDropResultNotify() {} // 0x0000000181365B50-0x0000000181365BB0
	static MiracleRingDropResultNotify() {} // 0x0000000181365A90-0x0000000181365B50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingDropResultNotify Clone() => default; // 0x0000000181365280-0x0000000181365370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MiracleRingDropResultNotify ShallowCopy() => default; // 0x0000000181364DD0-0x0000000181364E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001813648D0-0x0000000181364920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181365490-0x00000001813654E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001813654E0-0x0000000181365530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181364920-0x0000000181364990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181364AB0-0x0000000181364B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MiracleRingDropResultNotify other) => default; // 0x0000000181364990-0x0000000181364AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181364F60-0x0000000181365060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181365890-0x0000000181365A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181365590-0x00000001813656B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181364B80-0x0000000181364CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MiracleRingDropResultNotify other) {} // 0x00000001813647A0-0x00000001813648D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001813645A0-0x00000001813646A0
}

