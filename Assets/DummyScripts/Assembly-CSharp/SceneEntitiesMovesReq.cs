/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneEntitiesMovesReq : MessageBase, IMessage<SceneEntitiesMovesReq> // TypeDefIndex: 25197
{
	// Fields
	private static readonly MessageParser<SceneEntitiesMovesReq> _parser; // 0x00
	public const int EntityMoveInfoListFieldNumber = 1; // Metadata: 0x00B0830B
	private static readonly FieldCodec<EntityMoveInfo> _repeated_entityMoveInfoList_codec; // 0x08
	private readonly RepeatedMessageField<EntityMoveInfo> entityMoveInfoList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneEntitiesMovesReq> Parser { get => default; } // 0x00000001816AAB20-0x00000001816AABB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001816AA8B0-0x00000001816AA940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001816AA5E0-0x00000001816AA660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001816AA000-0x00000001816AA060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001816AAF10-0x00000001816AB000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001816AAD60-0x00000001816AADC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001816AA940-0x00000001816AAA30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001816AAEC0-0x00000001816AAF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001816AA700-0x00000001816AA7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EntityMoveInfo> EntityMoveInfoList { get => default; } // 0x00000001816AA580-0x00000001816AA5E0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25198
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25199
		{
			None = 0,
			EnetIsReliable = 0,
			EnetChannelId = 1,
			IsAllowClient = 1,
			CmdId = 299
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntitiesMovesReq() {} // 0x00000001816AB260-0x00000001816AB2F0
	static SceneEntitiesMovesReq() {} // 0x00000001816AB150-0x00000001816AB260

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntitiesMovesReq Clone() => default; // 0x00000001816AAA30-0x00000001816AAB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntitiesMovesReq ShallowCopy() => default; // 0x00000001816AA660-0x00000001816AA700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001816AA190-0x00000001816AA1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816AAC40-0x00000001816AACD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001816AACD0-0x00000001816AAD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001816AA1E0-0x00000001816AA2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001816AA3C0-0x00000001816AA490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneEntitiesMovesReq other) => default; // 0x00000001816AA2B0-0x00000001816AA3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001816AA7F0-0x00000001816AA8B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001816AB000-0x00000001816AB150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001816AADC0-0x00000001816AAEC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001816AA490-0x00000001816AA580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneEntitiesMovesReq other) {} // 0x00000001816AA060-0x00000001816AA190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001816A9ED0-0x00000001816AA000
}

