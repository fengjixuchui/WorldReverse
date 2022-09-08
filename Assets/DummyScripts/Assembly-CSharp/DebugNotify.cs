/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DebugNotify : MessageBase, IMessage<DebugNotify> // TypeDefIndex: 21706
{
	// Fields
	private static readonly MessageParser<DebugNotify> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00AFFCEE
	private uint id_; // 0x18
	public const int NameFieldNumber = 2; // Metadata: 0x00AFFCF2
	private string name_; // 0x20
	public const int RetcodeFieldNumber = 3; // Metadata: 0x00AFFCF6
	private Types.Retcode retcode_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DebugNotify> Parser { get => default; } // 0x0000000186580F80-0x0000000186581010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000186580D90-0x0000000186580E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000186580A80-0x0000000186580B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001865800B0-0x0000000186580110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000186581550-0x0000000186581640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000186581210-0x0000000186581270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000186580E20-0x0000000186580F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000186581500-0x0000000186581550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000186580B00-0x0000000186580BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x0000000186580940-0x00000001865809E0 0x0000000186581010-0x00000001865810B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { get => default; set {} } // 0x00000001865809E0-0x0000000186580A80 0x0000000186580410-0x00000001865804C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Retcode Retcode { get => default; set {} } // 0x00000001865808A0-0x0000000186580940 0x0000000186580370-0x0000000186580410

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21707
	{
		// Nested types
		public enum Enum // TypeDefIndex: 21708
		{
			Zero = 0,
			EnetIsReliable = 1,
			EnetChannelId = 2,
			CmdId = 101,
			TargetService = 101
		}

		public enum Retcode // TypeDefIndex: 21709
		{
			Succ = 0,
			Fail = 1
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DebugNotify() {} // 0x0000000186581970-0x00000001865819F0
	static DebugNotify() {} // 0x00000001865818B0-0x0000000186581970

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DebugNotify Clone() => default; // 0x0000000186580F10-0x0000000186580F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DebugNotify DeepClone(DebugNotify clone = null) => default; // 0x0000000186581270-0x0000000186581380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001865811C0-0x0000000186581210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000186581170-0x00000001865811C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000186580290-0x00000001865802E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001865802E0-0x0000000186580370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000186580630-0x0000000186580700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DebugNotify other) => default; // 0x00000001865804C0-0x0000000186580630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000186580BF0-0x0000000186580D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000186581640-0x00000001865818B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000186581380-0x0000000186581500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000186580700-0x00000001865808A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DebugNotify other) {} // 0x0000000186580110-0x0000000186580290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018657FFA0-0x00000001865800B0
}

