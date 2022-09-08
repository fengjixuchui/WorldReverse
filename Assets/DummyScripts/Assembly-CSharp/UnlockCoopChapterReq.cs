/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UnlockCoopChapterReq : MessageBase, IMessage<UnlockCoopChapterReq> // TypeDefIndex: 22717
{
	// Fields
	private static readonly MessageParser<UnlockCoopChapterReq> _parser; // 0x00
	public const int ChapterIdFieldNumber = 1; // Metadata: 0x00B0237F
	private uint chapterId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UnlockCoopChapterReq> Parser { get => default; } // 0x0000000180FD8260-0x0000000180FD82F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180FD7FF0-0x0000000180FD8080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180FD7D00-0x0000000180FD7D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180FD7770-0x0000000180FD77D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180FD8650-0x0000000180FD8740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180FD84C0-0x0000000180FD8520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180FD8080-0x0000000180FD8170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180FD8600-0x0000000180FD8650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180FD7E20-0x0000000180FD7F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChapterId { get => default; set {} } // 0x0000000180FD7C60-0x0000000180FD7D00 0x0000000180FD8380-0x0000000180FD8420

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22718
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22719
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1961
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockCoopChapterReq() {} // 0x0000000180FD8970-0x0000000180FD89D0
	static UnlockCoopChapterReq() {} // 0x0000000180FD88B0-0x0000000180FD8970

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockCoopChapterReq Clone() => default; // 0x0000000180FD8170-0x0000000180FD8260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockCoopChapterReq ShallowCopy() => default; // 0x0000000180FD7D80-0x0000000180FD7E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180FD78E0-0x0000000180FD7930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180FD8420-0x0000000180FD8470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180FD8470-0x0000000180FD84C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180FD7930-0x0000000180FD79A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180FD79A0-0x0000000180FD7A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UnlockCoopChapterReq other) => default; // 0x0000000180FD7A70-0x0000000180FD7B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180FD7F10-0x0000000180FD7FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180FD8740-0x0000000180FD88B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180FD8520-0x0000000180FD8600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180FD7B70-0x0000000180FD7C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UnlockCoopChapterReq other) {} // 0x0000000180FD77D0-0x0000000180FD78E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180FD7690-0x0000000180FD7770
}

