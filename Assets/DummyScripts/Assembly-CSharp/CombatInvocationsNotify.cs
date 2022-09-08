/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CombatInvocationsNotify : MessageBase, IMessage<CombatInvocationsNotify> // TypeDefIndex: 23127
{
	// Fields
	private static readonly MessageParser<CombatInvocationsNotify> _parser; // 0x00
	public const int InvokeListFieldNumber = 1; // Metadata: 0x00B03403
	private static readonly FieldCodec<CombatInvokeEntry> _repeated_invokeList_codec; // 0x08
	private readonly RepeatedMessageField<CombatInvokeEntry> invokeList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CombatInvocationsNotify> Parser { get => default; } // 0x00000001849EA460-0x00000001849EA4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001849EA1F0-0x00000001849EA280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001849E9F20-0x00000001849E9FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001849E9940-0x00000001849E99A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001849EA850-0x00000001849EA940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001849EA6A0-0x00000001849EA700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001849EA280-0x00000001849EA370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001849EA800-0x00000001849EA850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001849EA040-0x00000001849EA130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CombatInvokeEntry> InvokeList { get => default; } // 0x00000001849E9EC0-0x00000001849E9F20 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23128
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23129
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 350
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombatInvocationsNotify() {} // 0x00000001849EABA0-0x00000001849EAC30
	static CombatInvocationsNotify() {} // 0x00000001849EAA90-0x00000001849EABA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombatInvocationsNotify Clone() => default; // 0x00000001849EA370-0x00000001849EA460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CombatInvocationsNotify ShallowCopy() => default; // 0x00000001849E9FA0-0x00000001849EA040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001849E9AD0-0x00000001849E9B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849EA580-0x00000001849EA610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001849EA610-0x00000001849EA6A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001849E9B20-0x00000001849E9BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001849E9D00-0x00000001849E9DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CombatInvocationsNotify other) => default; // 0x00000001849E9BF0-0x00000001849E9D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001849EA130-0x00000001849EA1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001849EA940-0x00000001849EAA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001849EA700-0x00000001849EA800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001849E9DD0-0x00000001849E9EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CombatInvocationsNotify other) {} // 0x00000001849E99A0-0x00000001849E9AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001849E9810-0x00000001849E9940
}

