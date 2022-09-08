/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UnlockNameCardNotify : MessageBase, IMessage<UnlockNameCardNotify> // TypeDefIndex: 25618
{
	// Fields
	private static readonly MessageParser<UnlockNameCardNotify> _parser; // 0x00
	public const int NameCardIdFieldNumber = 1; // Metadata: 0x00B0930B
	private uint nameCardId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UnlockNameCardNotify> Parser { get => default; } // 0x00000001823D8E60-0x00000001823D8EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823D8B50-0x00000001823D8BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823D87C0-0x00000001823D8840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823D82D0-0x00000001823D8330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823D91B0-0x00000001823D92A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823D9020-0x00000001823D9080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823D8C80-0x00000001823D8D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823D9160-0x00000001823D91B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823D8980-0x00000001823D8A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NameCardId { get => default; set {} } // 0x00000001823D8BE0-0x00000001823D8C80 0x00000001823D88E0-0x00000001823D8980

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25619
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25620
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4031
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockNameCardNotify() {} // 0x00000001823D94D0-0x00000001823D9530
	static UnlockNameCardNotify() {} // 0x00000001823D9410-0x00000001823D94D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockNameCardNotify Clone() => default; // 0x00000001823D8D70-0x00000001823D8E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UnlockNameCardNotify ShallowCopy() => default; // 0x00000001823D8840-0x00000001823D88E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823D8440-0x00000001823D8490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823D8F80-0x00000001823D8FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823D8FD0-0x00000001823D9020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823D8490-0x00000001823D8500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823D8600-0x00000001823D86D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UnlockNameCardNotify other) => default; // 0x00000001823D8500-0x00000001823D8600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823D8A70-0x00000001823D8B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823D92A0-0x00000001823D9410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001823D9080-0x00000001823D9160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823D86D0-0x00000001823D87C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UnlockNameCardNotify other) {} // 0x00000001823D8330-0x00000001823D8440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823D81F0-0x00000001823D82D0
}

