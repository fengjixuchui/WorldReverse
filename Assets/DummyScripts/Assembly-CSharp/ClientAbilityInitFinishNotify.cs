/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientAbilityInitFinishNotify : MessageBase, IMessage<ClientAbilityInitFinishNotify> // TypeDefIndex: 21795
{
	// Fields
	private static readonly MessageParser<ClientAbilityInitFinishNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0002F
	private uint entityId_; // 0x18
	public const int InvokesFieldNumber = 2; // Metadata: 0x00B00033
	private static readonly FieldCodec<AbilityInvokeEntry> _repeated_invokes_codec; // 0x08
	private readonly RepeatedMessageField<AbilityInvokeEntry> invokes_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientAbilityInitFinishNotify> Parser { get => default; } // 0x000000018289F9F0-0x000000018289FA80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018289F720-0x000000018289F7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018289F410-0x000000018289F490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018289EDE0-0x000000018289EE40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018289FEC0-0x000000018289FFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018289FCD0-0x000000018289FD30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018289F7B0-0x000000018289F8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018289FE70-0x000000018289FEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018289F530-0x000000018289F620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x000000018289FC30-0x000000018289FCD0 0x000000018289FFB0-0x00000001828A0050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AbilityInvokeEntry> Invokes { get => default; } // 0x000000018289F990-0x000000018289F9F0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21796
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21797
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1104
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAbilityInitFinishNotify() {} // 0x00000001828A0340-0x00000001828A03D0
	static ClientAbilityInitFinishNotify() {} // 0x00000001828A0230-0x00000001828A0340

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAbilityInitFinishNotify Clone() => default; // 0x000000018289F8A0-0x000000018289F990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAbilityInitFinishNotify ShallowCopy() => default; // 0x000000018289F490-0x000000018289F530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018289EFA0-0x000000018289EFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018289FB10-0x000000018289FBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018289FBA0-0x000000018289FC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018289EFF0-0x000000018289F0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018289F0D0-0x000000018289F1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientAbilityInitFinishNotify other) => default; // 0x000000018289F1A0-0x000000018289F2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018289F620-0x000000018289F720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001828A0050-0x00000001828A0230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018289FD30-0x000000018289FE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018289F2D0-0x000000018289F410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientAbilityInitFinishNotify other) {} // 0x000000018289EE40-0x000000018289EFA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018289EC80-0x000000018289EDE0
}

