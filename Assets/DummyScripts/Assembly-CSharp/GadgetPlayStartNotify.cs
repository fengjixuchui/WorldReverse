/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GadgetPlayStartNotify : MessageBase, IMessage<GadgetPlayStartNotify> // TypeDefIndex: 23200
{
	// Fields
	private static readonly MessageParser<GadgetPlayStartNotify> _parser; // 0x00
	public const int PlayTypeFieldNumber = 1; // Metadata: 0x00B03767
	private uint playType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B0376B
	private uint entityId_; // 0x1C
	public const int StartTimeFieldNumber = 3; // Metadata: 0x00B0376F
	private uint startTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GadgetPlayStartNotify> Parser { get => default; } // 0x0000000182F96F10-0x0000000182F96FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182F96C00-0x0000000182F96C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182F968C0-0x0000000182F96940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182F96200-0x0000000182F96260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182F97420-0x0000000182F97510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182F97170-0x0000000182F971D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182F96D30-0x0000000182F96E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182F973D0-0x0000000182F97420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182F969E0-0x0000000182F96AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayType { get => default; set {} } // 0x0000000182F971D0-0x0000000182F97270 0x0000000182F96490-0x0000000182F96530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182F970D0-0x0000000182F97170 0x0000000182F97510-0x0000000182F975B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartTime { get => default; set {} } // 0x0000000182F975B0-0x0000000182F97650 0x0000000182F96C90-0x0000000182F96D30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23201
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23202
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 809
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayStartNotify() {} // 0x0000000182F979A0-0x0000000182F97A00
	static GadgetPlayStartNotify() {} // 0x0000000182F978E0-0x0000000182F979A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayStartNotify Clone() => default; // 0x0000000182F96E20-0x0000000182F96F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GadgetPlayStartNotify ShallowCopy() => default; // 0x0000000182F96940-0x0000000182F969E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182F963C0-0x0000000182F96410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F97030-0x0000000182F97080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182F97080-0x0000000182F970D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182F96410-0x0000000182F96490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182F96530-0x0000000182F96600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GadgetPlayStartNotify other) => default; // 0x0000000182F96600-0x0000000182F96740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182F96AD0-0x0000000182F96C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182F97650-0x0000000182F978E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182F97270-0x0000000182F973D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182F96740-0x0000000182F968C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GadgetPlayStartNotify other) {} // 0x0000000182F96260-0x0000000182F963C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182F960F0-0x0000000182F96200
}

