/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneCreateEntityRsp : MessageBase, IMessage<SceneCreateEntityRsp> // TypeDefIndex: 24978
{
	// Fields
	private static readonly MessageParser<SceneCreateEntityRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B07B23
	private int retcode_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B07B27
	private uint entityId_; // 0x1C
	public const int EntityFieldNumber = 3; // Metadata: 0x00B07B2B
	private CreateEntityInfo entity_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneCreateEntityRsp> Parser { get => default; } // 0x0000000184B49710-0x0000000184B497A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184B494A0-0x0000000184B49530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184B490E0-0x0000000184B49160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184B48690-0x0000000184B486F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184B49BE0-0x0000000184B49CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184B499D0-0x0000000184B49A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184B49530-0x0000000184B49620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184B49B90-0x0000000184B49BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184B49200-0x0000000184B492F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184B48FA0-0x0000000184B49040 0x0000000184B48B00-0x0000000184B48BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000184B49930-0x0000000184B499D0 0x0000000184B49CD0-0x0000000184B49D70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CreateEntityInfo Entity { get => default; set {} } // 0x0000000184B48A60-0x0000000184B48B00 0x0000000184B49040-0x0000000184B490E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24979
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24980
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 228
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneCreateEntityRsp() {} // 0x0000000184B4A0A0-0x0000000184B4A100
	static SceneCreateEntityRsp() {} // 0x0000000184B49FE0-0x0000000184B4A0A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneCreateEntityRsp Clone() => default; // 0x0000000184B49620-0x0000000184B49710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneCreateEntityRsp ShallowCopy() => default; // 0x0000000184B49160-0x0000000184B49200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B488A0-0x0000000184B48920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B49830-0x0000000184B498B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B498B0-0x0000000184B49930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184B48920-0x0000000184B48A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184B48BA0-0x0000000184B48C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneCreateEntityRsp other) => default; // 0x0000000184B48C70-0x0000000184B48DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184B492F0-0x0000000184B494A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184B49D70-0x0000000184B49FE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B49A30-0x0000000184B49B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184B48DC0-0x0000000184B48FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneCreateEntityRsp other) {} // 0x0000000184B486F0-0x0000000184B488A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B48530-0x0000000184B48690
}

