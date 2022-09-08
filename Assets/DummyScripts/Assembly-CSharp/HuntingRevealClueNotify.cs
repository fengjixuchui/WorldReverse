/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HuntingRevealClueNotify : MessageBase, IMessage<HuntingRevealClueNotify> // TypeDefIndex: 23550
{
	// Fields
	private static readonly MessageParser<HuntingRevealClueNotify> _parser; // 0x00
	public const int HuntingPairFieldNumber = 1; // Metadata: 0x00B0443B
	private HuntingPair huntingPair_; // 0x18
	public const int FinishedGroupIdFieldNumber = 2; // Metadata: 0x00B0443F
	private uint finishedGroupId_; // 0x20
	public const int CluePositionFieldNumber = 3; // Metadata: 0x00B04443
	private Vector cluePosition_; // 0x28
	public const int FinishClueCountFieldNumber = 4; // Metadata: 0x00B04447
	private uint finishClueCount_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HuntingRevealClueNotify> Parser { get => default; } // 0x000000018520F3B0-0x000000018520F440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018520F0A0-0x000000018520F130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018520EBA0-0x000000018520EC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018520E070-0x000000018520E0D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018520FA10-0x000000018520FB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018520F730-0x000000018520F790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018520F130-0x000000018520F220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018520F9C0-0x000000018520FA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018520ECC0-0x000000018520EDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingPair HuntingPair { get => default; set {} } // 0x000000018520E2F0-0x000000018520E390 0x000000018520DE20-0x000000018520DEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishedGroupId { get => default; set {} } // 0x000000018520F920-0x000000018520F9C0 0x000000018520F000-0x000000018520F0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector CluePosition { get => default; set {} } // 0x000000018520F4D0-0x000000018520F570 0x000000018520E620-0x000000018520E6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishClueCount { get => default; set {} } // 0x000000018520F310-0x000000018520F3B0 0x000000018520F600-0x000000018520F6A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23551
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23552
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4308
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingRevealClueNotify() {} // 0x000000018520FEA0-0x000000018520FF00
	static HuntingRevealClueNotify() {} // 0x000000018520FDE0-0x000000018520FEA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingRevealClueNotify Clone() => default; // 0x000000018520F220-0x000000018520F310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingRevealClueNotify ShallowCopy() => default; // 0x000000018520EC20-0x000000018520ECC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018520E390-0x000000018520E420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018520F570-0x000000018520F600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018520F6A0-0x000000018520F730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018520E420-0x000000018520E620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018520E6C0-0x000000018520E790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HuntingRevealClueNotify other) => default; // 0x000000018520E790-0x000000018520E910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018520EDB0-0x000000018520F000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018520FB00-0x000000018520FDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018520F790-0x000000018520F920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018520E910-0x000000018520EBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HuntingRevealClueNotify other) {} // 0x000000018520E0D0-0x000000018520E2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018520DEC0-0x000000018520E070
}

