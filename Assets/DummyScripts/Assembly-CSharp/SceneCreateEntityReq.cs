/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneCreateEntityReq : MessageBase, IMessage<SceneCreateEntityReq> // TypeDefIndex: 24975
{
	// Fields
	private static readonly MessageParser<SceneCreateEntityReq> _parser; // 0x00
	public const int EntityFieldNumber = 1; // Metadata: 0x00B07B03
	private CreateEntityInfo entity_; // 0x18
	public const int ReasonFieldNumber = 2; // Metadata: 0x00B07B07
	private CreateReason reason_; // 0x20
	public const int IsDestroyWhenDisconnectFieldNumber = 3; // Metadata: 0x00B07B0B
	private bool isDestroyWhenDisconnect_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneCreateEntityReq> Parser { get => default; } // 0x0000000181E10940-0x0000000181E109D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E10590-0x0000000181E10620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E10190-0x0000000181E10210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E0F810-0x0000000181E0F870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E10D70-0x0000000181E10E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E10B60-0x0000000181E10BC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E106C0-0x0000000181E107B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E10D20-0x0000000181E10D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E102B0-0x0000000181E103A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateEntityInfo Entity { get => default; set {} } // 0x0000000181E0FC80-0x0000000181E0FD20 0x0000000181E100F0-0x0000000181E10190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateReason Reason { get => default; set {} } // 0x0000000181E108A0-0x0000000181E10940 0x0000000181E0FAA0-0x0000000181E0FB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsDestroyWhenDisconnect { get => default; set {} } // 0x0000000181E10620-0x0000000181E106C0 0x0000000181E0F770-0x0000000181E0F810

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24976
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24977
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 227
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneCreateEntityReq() {} // 0x0000000181E11190-0x0000000181E11200
	static SceneCreateEntityReq() {} // 0x0000000181E110D0-0x0000000181E11190

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneCreateEntityReq Clone() => default; // 0x0000000181E107B0-0x0000000181E108A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneCreateEntityReq ShallowCopy() => default; // 0x0000000181E10210-0x0000000181E102B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E0FA20-0x0000000181E0FAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E10A60-0x0000000181E10AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E10AE0-0x0000000181E10B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E0FB40-0x0000000181E0FC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E0FE70-0x0000000181E0FF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneCreateEntityReq other) => default; // 0x0000000181E0FD20-0x0000000181E0FE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E103A0-0x0000000181E10590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E10E60-0x0000000181E110D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E10BC0-0x0000000181E10D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E0FF40-0x0000000181E100F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneCreateEntityReq other) {} // 0x0000000181E0F870-0x0000000181E0FA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E0F620-0x0000000181E0F770
}

