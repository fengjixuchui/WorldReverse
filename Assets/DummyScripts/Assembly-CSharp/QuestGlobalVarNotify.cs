/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class QuestGlobalVarNotify : MessageBase, IMessage<QuestGlobalVarNotify> // TypeDefIndex: 24658
{
	// Fields
	private static readonly MessageParser<QuestGlobalVarNotify> _parser; // 0x00
	public const int VarListFieldNumber = 1; // Metadata: 0x00B06EFF
	private static readonly FieldCodec<QuestGlobalVar> _repeated_varList_codec; // 0x08
	private readonly RepeatedMessageField<QuestGlobalVar> varList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<QuestGlobalVarNotify> Parser { get => default; } // 0x00000001826CB8F0-0x00000001826CB980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001826CB680-0x00000001826CB710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001826CB3B0-0x00000001826CB430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001826CADD0-0x00000001826CAE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001826CBCE0-0x00000001826CBDD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001826CBB30-0x00000001826CBB90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001826CB710-0x00000001826CB800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001826CBC90-0x00000001826CBCE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001826CB4D0-0x00000001826CB5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<QuestGlobalVar> VarList { get => default; } // 0x00000001826CB080-0x00000001826CB0E0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24659
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24660
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 432
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestGlobalVarNotify() {} // 0x00000001826CC030-0x00000001826CC0C0
	static QuestGlobalVarNotify() {} // 0x00000001826CBF20-0x00000001826CC030

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestGlobalVarNotify Clone() => default; // 0x00000001826CB800-0x00000001826CB8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public QuestGlobalVarNotify ShallowCopy() => default; // 0x00000001826CB430-0x00000001826CB4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001826CAF60-0x00000001826CAFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001826CBA10-0x00000001826CBAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001826CBAA0-0x00000001826CBB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001826CAFB0-0x00000001826CB080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001826CB0E0-0x00000001826CB1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(QuestGlobalVarNotify other) => default; // 0x00000001826CB1B0-0x00000001826CB2C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001826CB5C0-0x00000001826CB680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001826CBDD0-0x00000001826CBF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001826CBB90-0x00000001826CBC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001826CB2C0-0x00000001826CB3B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(QuestGlobalVarNotify other) {} // 0x00000001826CAE30-0x00000001826CAF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001826CACA0-0x00000001826CADD0
}

