/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MpPlayPrepareInterruptNotify : MessageBase, IMessage<MpPlayPrepareInterruptNotify> // TypeDefIndex: 24096
{
	// Fields
	private static readonly MessageParser<MpPlayPrepareInterruptNotify> _parser; // 0x00
	public const int MpPlayIdFieldNumber = 1; // Metadata: 0x00B058BB
	private uint mpPlayId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MpPlayPrepareInterruptNotify> Parser { get => default; } // 0x0000000184143400-0x0000000184143490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184143190-0x0000000184143220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184142E00-0x0000000184142E80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184142870-0x00000001841428D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184143750-0x0000000184143840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001841435C0-0x0000000184143620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184143220-0x0000000184143310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184143700-0x0000000184143750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184142F20-0x0000000184143010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MpPlayId { get => default; set {} } // 0x00000001841430F0-0x0000000184143190 0x0000000184142AA0-0x0000000184142B40

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24097
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24098
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1825
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayPrepareInterruptNotify() {} // 0x0000000184143A70-0x0000000184143AD0
	static MpPlayPrepareInterruptNotify() {} // 0x00000001841439B0-0x0000000184143A70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayPrepareInterruptNotify Clone() => default; // 0x0000000184143310-0x0000000184143400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MpPlayPrepareInterruptNotify ShallowCopy() => default; // 0x0000000184142E80-0x0000000184142F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001841429E0-0x0000000184142A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184143520-0x0000000184143570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184143570-0x00000001841435C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184142A30-0x0000000184142AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184142B40-0x0000000184142C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MpPlayPrepareInterruptNotify other) => default; // 0x0000000184142C10-0x0000000184142D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184143010-0x00000001841430F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184143840-0x00000001841439B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184143620-0x0000000184143700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184142D10-0x0000000184142E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MpPlayPrepareInterruptNotify other) {} // 0x00000001841428D0-0x00000001841429E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184142790-0x0000000184142870
}

