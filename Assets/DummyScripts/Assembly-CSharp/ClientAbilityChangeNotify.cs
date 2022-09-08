/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ClientAbilityChangeNotify : MessageBase, IMessage<ClientAbilityChangeNotify> // TypeDefIndex: 21815
{
	// Fields
	private static readonly MessageParser<ClientAbilityChangeNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B000E7
	private uint entityId_; // 0x18
	public const int InvokesFieldNumber = 2; // Metadata: 0x00B000EB
	private static readonly FieldCodec<AbilityInvokeEntry> _repeated_invokes_codec; // 0x08
	private readonly RepeatedMessageField<AbilityInvokeEntry> invokes_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ClientAbilityChangeNotify> Parser { get => default; } // 0x00000001823F3B20-0x00000001823F3BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823F3850-0x00000001823F38E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823F3540-0x00000001823F35C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823F2F10-0x00000001823F2F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823F3FF0-0x00000001823F40E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823F3E00-0x00000001823F3E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823F38E0-0x00000001823F39D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823F3FA0-0x00000001823F3FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823F3660-0x00000001823F3750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x00000001823F3D60-0x00000001823F3E00 0x00000001823F40E0-0x00000001823F4180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AbilityInvokeEntry> Invokes { get => default; } // 0x00000001823F3AC0-0x00000001823F3B20 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21816
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21817
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1112
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAbilityChangeNotify() {} // 0x00000001823F4470-0x00000001823F4500
	static ClientAbilityChangeNotify() {} // 0x00000001823F4360-0x00000001823F4470

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAbilityChangeNotify Clone() => default; // 0x00000001823F39D0-0x00000001823F3AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ClientAbilityChangeNotify ShallowCopy() => default; // 0x00000001823F35C0-0x00000001823F3660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823F30D0-0x00000001823F3120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823F3C40-0x00000001823F3CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823F3CD0-0x00000001823F3D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823F3120-0x00000001823F3200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823F3200-0x00000001823F32D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ClientAbilityChangeNotify other) => default; // 0x00000001823F32D0-0x00000001823F3400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823F3750-0x00000001823F3850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823F4180-0x00000001823F4360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001823F3E60-0x00000001823F3FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823F3400-0x00000001823F3540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ClientAbilityChangeNotify other) {} // 0x00000001823F2F70-0x00000001823F30D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823F2DB0-0x00000001823F2F10
}

