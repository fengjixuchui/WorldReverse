/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExpeditionChallengeEnterRegionNotify : MessageBase, IMessage<ExpeditionChallengeEnterRegionNotify> // TypeDefIndex: 22198
{
	// Fields
	private static readonly MessageParser<ExpeditionChallengeEnterRegionNotify> _parser; // 0x00
	public const int IsPuzzleFinishedFieldNumber = 1; // Metadata: 0x00B0105B
	private bool isPuzzleFinished_; // 0x18
	public const int IdFieldNumber = 2; // Metadata: 0x00B0105F
	private uint id_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExpeditionChallengeEnterRegionNotify> Parser { get => default; } // 0x00000001836D0D40-0x00000001836D0DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836D0AD0-0x00000001836D0B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001836D07B0-0x00000001836D0830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001836D0130-0x00000001836D0190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001836D1170-0x00000001836D1260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836D0FA0-0x00000001836D1000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001836D0B60-0x00000001836D0C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001836D1120-0x00000001836D1170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001836D08D0-0x00000001836D09C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsPuzzleFinished { get => default; set {} } // 0x00000001836D0380-0x00000001836D0420 0x00000001836D1260-0x00000001836D1300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x00000001836D0710-0x00000001836D07B0 0x00000001836D0DD0-0x00000001836D0E70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22199
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22200
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2171
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionChallengeEnterRegionNotify() {} // 0x00000001836D15C0-0x00000001836D1620
	static ExpeditionChallengeEnterRegionNotify() {} // 0x00000001836D1500-0x00000001836D15C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionChallengeEnterRegionNotify Clone() => default; // 0x00000001836D0C50-0x00000001836D0D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionChallengeEnterRegionNotify ShallowCopy() => default; // 0x00000001836D0830-0x00000001836D08D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001836D02C0-0x00000001836D0310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836D0F00-0x00000001836D0F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836D0F50-0x00000001836D0FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001836D0310-0x00000001836D0380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001836D0540-0x00000001836D0610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ExpeditionChallengeEnterRegionNotify other) => default; // 0x00000001836D0420-0x00000001836D0540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001836D09C0-0x00000001836D0AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001836D1300-0x00000001836D1500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001836D1000-0x00000001836D1120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001836D0610-0x00000001836D0710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ExpeditionChallengeEnterRegionNotify other) {} // 0x00000001836D0190-0x00000001836D02C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836D0030-0x00000001836D0130
}

