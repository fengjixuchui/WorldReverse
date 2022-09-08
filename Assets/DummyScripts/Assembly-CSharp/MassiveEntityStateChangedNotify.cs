/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MassiveEntityStateChangedNotify : MessageBase, IMessage<MassiveEntityStateChangedNotify> // TypeDefIndex: 23116
{
	// Fields
	private static readonly MessageParser<MassiveEntityStateChangedNotify> _parser; // 0x00
	public const int MassiveEntityStateListFieldNumber = 1; // Metadata: 0x00B033A3
	private static readonly FieldCodec<MassiveEntityState> _repeated_massiveEntityStateList_codec; // 0x08
	private readonly RepeatedMessageField<MassiveEntityState> massiveEntityStateList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MassiveEntityStateChangedNotify> Parser { get => default; } // 0x0000000181CB62E0-0x0000000181CB6370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181CB6010-0x0000000181CB60A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181CB5D40-0x0000000181CB5DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181CB57C0-0x0000000181CB5820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181CB66D0-0x0000000181CB67C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181CB6520-0x0000000181CB6580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181CB60A0-0x0000000181CB6190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181CB6680-0x0000000181CB66D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181CB5E60-0x0000000181CB5F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MassiveEntityState> MassiveEntityStateList { get => default; } // 0x0000000181CB6280-0x0000000181CB62E0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23117
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23118
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 347
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveEntityStateChangedNotify() {} // 0x0000000181CB6A20-0x0000000181CB6AB0
	static MassiveEntityStateChangedNotify() {} // 0x0000000181CB6910-0x0000000181CB6A20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveEntityStateChangedNotify Clone() => default; // 0x0000000181CB6190-0x0000000181CB6280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveEntityStateChangedNotify ShallowCopy() => default; // 0x0000000181CB5DC0-0x0000000181CB5E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181CB5950-0x0000000181CB59A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CB6400-0x0000000181CB6490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181CB6490-0x0000000181CB6520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181CB59A0-0x0000000181CB5A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181CB5A70-0x0000000181CB5B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MassiveEntityStateChangedNotify other) => default; // 0x0000000181CB5B40-0x0000000181CB5C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181CB5F50-0x0000000181CB6010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181CB67C0-0x0000000181CB6910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181CB6580-0x0000000181CB6680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181CB5C50-0x0000000181CB5D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MassiveEntityStateChangedNotify other) {} // 0x0000000181CB5820-0x0000000181CB5950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181CB5690-0x0000000181CB57C0
}

