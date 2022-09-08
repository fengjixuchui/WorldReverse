/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WatcherChangeNotify : MessageBase, IMessage<WatcherChangeNotify> // TypeDefIndex: 25770
{
	// Fields
	private static readonly MessageParser<WatcherChangeNotify> _parser; // 0x00
	public const int NewWatcherListFieldNumber = 1; // Metadata: 0x00B0989B
	private static readonly FieldCodec<uint> _repeated_newWatcherList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> newWatcherList_; // 0x18
	public const int RemovedWatcherListFieldNumber = 2; // Metadata: 0x00B0989F
	private static readonly FieldCodec<uint> _repeated_removedWatcherList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> removedWatcherList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WatcherChangeNotify> Parser { get => default; } // 0x0000000185A6E930-0x0000000185A6E9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185A6E6C0-0x0000000185A6E750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185A6E3C0-0x0000000185A6E440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185A6DD50-0x0000000185A6DDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185A6ECD0-0x0000000185A6EDC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185A6EAF0-0x0000000185A6EB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185A6E750-0x0000000185A6E840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185A6EC80-0x0000000185A6ECD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185A6E4E0-0x0000000185A6E5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> NewWatcherList { get => default; } // 0x0000000185A6E050-0x0000000185A6E0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> RemovedWatcherList { get => default; } // 0x0000000185A6EDC0-0x0000000185A6EE20 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25771
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25772
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2202
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WatcherChangeNotify() {} // 0x0000000185A6F0E0-0x0000000185A6F190
	static WatcherChangeNotify() {} // 0x0000000185A6EFE0-0x0000000185A6F0E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WatcherChangeNotify Clone() => default; // 0x0000000185A6E840-0x0000000185A6E930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WatcherChangeNotify ShallowCopy() => default; // 0x0000000185A6E440-0x0000000185A6E4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185A6DEE0-0x0000000185A6DF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185A6EA50-0x0000000185A6EAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185A6EAA0-0x0000000185A6EAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185A6DF30-0x0000000185A6E050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185A6E1D0-0x0000000185A6E2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WatcherChangeNotify other) => default; // 0x0000000185A6E0B0-0x0000000185A6E1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185A6E5D0-0x0000000185A6E6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185A6EE20-0x0000000185A6EFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185A6EB50-0x0000000185A6EC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185A6E2A0-0x0000000185A6E3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WatcherChangeNotify other) {} // 0x0000000185A6DDB0-0x0000000185A6DEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185A6DB90-0x0000000185A6DD50
}

