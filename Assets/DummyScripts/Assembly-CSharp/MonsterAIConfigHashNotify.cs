/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MonsterAIConfigHashNotify : MessageBase, IMessage<MonsterAIConfigHashNotify> // TypeDefIndex: 25290
{
	// Fields
	private static readonly MessageParser<MonsterAIConfigHashNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0862F
	private uint entityId_; // 0x18
	public const int HashValueFieldNumber = 2; // Metadata: 0x00B08633
	private int hashValue_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MonsterAIConfigHashNotify> Parser { get => default; } // 0x0000000183C280F0-0x0000000183C28180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C27E80-0x0000000183C27F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C27B70-0x0000000183C27BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C27560-0x0000000183C275C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C28520-0x0000000183C28610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C28350-0x0000000183C283B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C27F10-0x0000000183C28000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C284D0-0x0000000183C28520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C27C90-0x0000000183C27D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000183C282B0-0x0000000183C28350 0x0000000183C28610-0x0000000183C286B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int HashValue { get => default; set {} } // 0x0000000183C275C0-0x0000000183C27660 0x0000000183C286B0-0x0000000183C28750

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25291
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25292
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 3044
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterAIConfigHashNotify() {} // 0x0000000183C28A10-0x0000000183C28A70
	static MonsterAIConfigHashNotify() {} // 0x0000000183C28950-0x0000000183C28A10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterAIConfigHashNotify Clone() => default; // 0x0000000183C28000-0x0000000183C280F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MonsterAIConfigHashNotify ShallowCopy() => default; // 0x0000000183C27BF0-0x0000000183C27C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C27790-0x0000000183C277E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C28210-0x0000000183C28260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C28260-0x0000000183C282B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C277E0-0x0000000183C27850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C27850-0x0000000183C27920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MonsterAIConfigHashNotify other) => default; // 0x0000000183C27920-0x0000000183C27A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C27D80-0x0000000183C27E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C28750-0x0000000183C28950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C283B0-0x0000000183C284D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C27A40-0x0000000183C27B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MonsterAIConfigHashNotify other) {} // 0x0000000183C27660-0x0000000183C27790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C27460-0x0000000183C27560
}

