/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneForceLockNotify : MessageBase, IMessage<SceneForceLockNotify> // TypeDefIndex: 24990
{
	// Fields
	private static readonly MessageParser<SceneForceLockNotify> _parser; // 0x00
	public const int ForceIdListFieldNumber = 1; // Metadata: 0x00B07B87
	private static readonly FieldCodec<uint> _repeated_forceIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> forceIdList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneForceLockNotify> Parser { get => default; } // 0x0000000181B8C430-0x0000000181B8C4C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181B8C160-0x0000000181B8C1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181B8BE90-0x0000000181B8BF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181B8B950-0x0000000181B8B9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181B8C7A0-0x0000000181B8C890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181B8C5F0-0x0000000181B8C650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181B8C250-0x0000000181B8C340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181B8C750-0x0000000181B8C7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181B8BFB0-0x0000000181B8C0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ForceIdList { get => default; } // 0x0000000181B8C1F0-0x0000000181B8C250 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24991
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24992
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 232
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneForceLockNotify() {} // 0x0000000181B8CAC0-0x0000000181B8CB50
	static SceneForceLockNotify() {} // 0x0000000181B8C9E0-0x0000000181B8CAC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneForceLockNotify Clone() => default; // 0x0000000181B8C340-0x0000000181B8C430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneForceLockNotify ShallowCopy() => default; // 0x0000000181B8BF10-0x0000000181B8BFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181B8BAC0-0x0000000181B8BB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B8C550-0x0000000181B8C5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B8C5A0-0x0000000181B8C5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181B8BB10-0x0000000181B8BBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181B8BBD0-0x0000000181B8BCA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneForceLockNotify other) => default; // 0x0000000181B8BCA0-0x0000000181B8BDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181B8C0A0-0x0000000181B8C160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181B8C890-0x0000000181B8C9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181B8C650-0x0000000181B8C750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181B8BDA0-0x0000000181B8BE90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneForceLockNotify other) {} // 0x0000000181B8B9B0-0x0000000181B8BAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181B8B810-0x0000000181B8B950
}

