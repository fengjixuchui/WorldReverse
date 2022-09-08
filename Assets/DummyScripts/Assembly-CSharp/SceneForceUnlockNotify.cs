/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneForceUnlockNotify : MessageBase, IMessage<SceneForceUnlockNotify> // TypeDefIndex: 24987
{
	// Fields
	private static readonly MessageParser<SceneForceUnlockNotify> _parser; // 0x00
	public const int ForceIdListFieldNumber = 1; // Metadata: 0x00B07B6F
	private static readonly FieldCodec<uint> _repeated_forceIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> forceIdList_; // 0x18
	public const int IsAddFieldNumber = 2; // Metadata: 0x00B07B73
	private bool isAdd_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneForceUnlockNotify> Parser { get => default; } // 0x0000000183D91AF0-0x0000000183D91B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183D91820-0x0000000183D918B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183D91520-0x0000000183D915A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183D90F80-0x0000000183D90FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183D91F40-0x0000000183D92030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183D91D50-0x0000000183D91DB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183D91910-0x0000000183D91A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183D91EF0-0x0000000183D91F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183D91640-0x0000000183D91730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ForceIdList { get => default; } // 0x0000000183D918B0-0x0000000183D91910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAdd { get => default; set {} } // 0x0000000183D90EE0-0x0000000183D90F80 0x0000000183D91C10-0x0000000183D91CB0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24988
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24989
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 231
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneForceUnlockNotify() {} // 0x0000000183D922F0-0x0000000183D92380
	static SceneForceUnlockNotify() {} // 0x0000000183D92210-0x0000000183D922F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneForceUnlockNotify Clone() => default; // 0x0000000183D91A00-0x0000000183D91AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneForceUnlockNotify ShallowCopy() => default; // 0x0000000183D915A0-0x0000000183D91640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183D91110-0x0000000183D91160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D91CB0-0x0000000183D91D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183D91D00-0x0000000183D91D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183D91160-0x0000000183D91230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183D91350-0x0000000183D91420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneForceUnlockNotify other) => default; // 0x0000000183D91230-0x0000000183D91350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183D91730-0x0000000183D91820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183D92030-0x0000000183D92210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183D91DB0-0x0000000183D91EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183D91420-0x0000000183D91520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneForceUnlockNotify other) {} // 0x0000000183D90FE0-0x0000000183D91110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183D90D70-0x0000000183D90EE0
}

