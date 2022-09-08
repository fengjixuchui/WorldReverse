/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CancelFinishParentQuestNotify : MessageBase, IMessage<CancelFinishParentQuestNotify> // TypeDefIndex: 24690
{
	// Fields
	private static readonly MessageParser<CancelFinishParentQuestNotify> _parser; // 0x00
	public const int ParentQuestIdFieldNumber = 1; // Metadata: 0x00B0701B
	private uint parentQuestId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CancelFinishParentQuestNotify> Parser { get => default; } // 0x0000000183FCC710-0x0000000183FCC7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183FCC400-0x0000000183FCC490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183FCC110-0x0000000183FCC190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183FCBB80-0x0000000183FCBBE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183FCCA60-0x0000000183FCCB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183FCC8D0-0x0000000183FCC930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183FCC530-0x0000000183FCC620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183FCCA10-0x0000000183FCCA60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183FCC230-0x0000000183FCC320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ParentQuestId { get => default; set {} } // 0x0000000183FCBDB0-0x0000000183FCBE50 0x0000000183FCC490-0x0000000183FCC530

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24691
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24692
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 441
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CancelFinishParentQuestNotify() {} // 0x0000000183FCCD80-0x0000000183FCCDE0
	static CancelFinishParentQuestNotify() {} // 0x0000000183FCCCC0-0x0000000183FCCD80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CancelFinishParentQuestNotify Clone() => default; // 0x0000000183FCC620-0x0000000183FCC710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CancelFinishParentQuestNotify ShallowCopy() => default; // 0x0000000183FCC190-0x0000000183FCC230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183FCBCF0-0x0000000183FCBD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FCC830-0x0000000183FCC880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FCC880-0x0000000183FCC8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183FCBD40-0x0000000183FCBDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183FCBE50-0x0000000183FCBF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CancelFinishParentQuestNotify other) => default; // 0x0000000183FCBF20-0x0000000183FCC020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183FCC320-0x0000000183FCC400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183FCCB50-0x0000000183FCCCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183FCC930-0x0000000183FCCA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183FCC020-0x0000000183FCC110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CancelFinishParentQuestNotify other) {} // 0x0000000183FCBBE0-0x0000000183FCBCF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183FCBAA0-0x0000000183FCBB80
}

