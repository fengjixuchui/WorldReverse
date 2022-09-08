/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientScriptEventNotify : MessageBase, IMessage<ClientScriptEventNotify> // TypeDefIndex: 25194
{
	// Fields
	private static readonly MessageParser<ClientScriptEventNotify> _parser; // 0x00
	public const int EventTypeFieldNumber = 1; // Metadata: 0x00B082E7
	private uint eventType_; // 0x18
	public const int SourceEntityIdFieldNumber = 2; // Metadata: 0x00B082EB
	private uint sourceEntityId_; // 0x1C
	public const int TargetEntityIdFieldNumber = 3; // Metadata: 0x00B082EF
	private uint targetEntityId_; // 0x20
	public const int ParamListFieldNumber = 4; // Metadata: 0x00B082F3
	private static readonly FieldCodec<int> _repeated_paramList_codec; // 0x08
	private readonly RepeatedPrimitiveField<int> paramList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientScriptEventNotify> Parser { get => default; } // 0x00000001822E4B40-0x00000001822E4BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001822E4830-0x00000001822E48C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001822E44C0-0x00000001822E4540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001822E3BC0-0x00000001822E3C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001822E5100-0x00000001822E51F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001822E4DA0-0x00000001822E4E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001822E48C0-0x00000001822E49B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001822E5010-0x00000001822E5060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001822E45E0-0x00000001822E46D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EventType { get => default; set {} } // 0x00000001822E4380-0x00000001822E4420 0x00000001822E4AA0-0x00000001822E4B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SourceEntityId { get => default; set {} } // 0x00000001822E3C20-0x00000001822E3CC0 0x00000001822E4420-0x00000001822E44C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetEntityId { get => default; set {} } // 0x00000001822E5060-0x00000001822E5100 0x00000001822E4D00-0x00000001822E4DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<int> ParamList { get => default; } // 0x00000001822E4E00-0x00000001822E4E60 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25195
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25196
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 298
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientScriptEventNotify() {} // 0x00000001822E55D0-0x00000001822E5660
	static ClientScriptEventNotify() {} // 0x00000001822E54F0-0x00000001822E55D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientScriptEventNotify Clone() => default; // 0x00000001822E49B0-0x00000001822E4AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientScriptEventNotify ShallowCopy() => default; // 0x00000001822E4540-0x00000001822E45E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001822E3E40-0x00000001822E3E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822E4C60-0x00000001822E4CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001822E4CB0-0x00000001822E4D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001822E3E90-0x00000001822E3F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001822E3F70-0x00000001822E4040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientScriptEventNotify other) => default; // 0x00000001822E4040-0x00000001822E41A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001822E46D0-0x00000001822E4830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001822E51F0-0x00000001822E54F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001822E4E60-0x00000001822E5010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001822E41A0-0x00000001822E4380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientScriptEventNotify other) {} // 0x00000001822E3CC0-0x00000001822E3E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001822E3A20-0x00000001822E3BC0
}

