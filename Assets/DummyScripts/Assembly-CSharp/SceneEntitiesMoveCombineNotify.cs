/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneEntitiesMoveCombineNotify : MessageBase, IMessage<SceneEntitiesMoveCombineNotify> // TypeDefIndex: 25204
{
	// Fields
	private static readonly MessageParser<SceneEntitiesMoveCombineNotify> _parser; // 0x00
	public const int EntityMoveInfoListFieldNumber = 1; // Metadata: 0x00B0834B
	private static readonly FieldCodec<EntityMoveInfo> _repeated_entityMoveInfoList_codec; // 0x08
	private readonly RepeatedMessageField<EntityMoveInfo> entityMoveInfoList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneEntitiesMoveCombineNotify> Parser { get => default; } // 0x0000000184CA6430-0x0000000184CA64C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184CA61C0-0x0000000184CA6250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184CA5EF0-0x0000000184CA5F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184CA5910-0x0000000184CA5970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184CA6820-0x0000000184CA6910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184CA6670-0x0000000184CA66D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184CA6250-0x0000000184CA6340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184CA67D0-0x0000000184CA6820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184CA6010-0x0000000184CA6100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EntityMoveInfo> EntityMoveInfoList { get => default; } // 0x0000000184CA5E90-0x0000000184CA5EF0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25205
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25206
		{
			None = 0,
			EnetIsReliable = 0,
			EnetChannelId = 1,
			CmdId = 3001
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntitiesMoveCombineNotify() {} // 0x0000000184CA6B70-0x0000000184CA6C00
	static SceneEntitiesMoveCombineNotify() {} // 0x0000000184CA6A60-0x0000000184CA6B70

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntitiesMoveCombineNotify Clone() => default; // 0x0000000184CA6340-0x0000000184CA6430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntitiesMoveCombineNotify ShallowCopy() => default; // 0x0000000184CA5F70-0x0000000184CA6010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184CA5AA0-0x0000000184CA5AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CA6550-0x0000000184CA65E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CA65E0-0x0000000184CA6670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184CA5AF0-0x0000000184CA5BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184CA5BC0-0x0000000184CA5C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneEntitiesMoveCombineNotify other) => default; // 0x0000000184CA5C90-0x0000000184CA5DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184CA6100-0x0000000184CA61C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184CA6910-0x0000000184CA6A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184CA66D0-0x0000000184CA67D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184CA5DA0-0x0000000184CA5E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneEntitiesMoveCombineNotify other) {} // 0x0000000184CA5970-0x0000000184CA5AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184CA57E0-0x0000000184CA5910
}

