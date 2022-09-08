/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WatcherAllDataNotify : MessageBase, IMessage<WatcherAllDataNotify> // TypeDefIndex: 25767
{
	// Fields
	private static readonly MessageParser<WatcherAllDataNotify> _parser; // 0x00
	public const int WatcherListFieldNumber = 1; // Metadata: 0x00B09887
	private static readonly FieldCodec<uint> _repeated_watcherList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> watcherList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WatcherAllDataNotify> Parser { get => default; } // 0x00000001848BA840-0x00000001848BA8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001848BA5D0-0x00000001848BA660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001848BA300-0x00000001848BA380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001848B9D60-0x00000001848B9DC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001848BABB0-0x00000001848BACA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001848BAA00-0x00000001848BAA60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001848BA660-0x00000001848BA750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001848BAB60-0x00000001848BABB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001848BA420-0x00000001848BA510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> WatcherList { get => default; } // 0x00000001848B9DC0-0x00000001848B9E20 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25768
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25769
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2201
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WatcherAllDataNotify() {} // 0x00000001848BAED0-0x00000001848BAF60
	static WatcherAllDataNotify() {} // 0x00000001848BADF0-0x00000001848BAED0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WatcherAllDataNotify Clone() => default; // 0x00000001848BA750-0x00000001848BA840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WatcherAllDataNotify ShallowCopy() => default; // 0x00000001848BA380-0x00000001848BA420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001848B9F30-0x00000001848B9F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848BA960-0x00000001848BA9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001848BA9B0-0x00000001848BAA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001848B9F80-0x00000001848BA040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001848BA140-0x00000001848BA210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WatcherAllDataNotify other) => default; // 0x00000001848BA040-0x00000001848BA140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001848BA510-0x00000001848BA5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001848BACA0-0x00000001848BADF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001848BAA60-0x00000001848BAB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001848BA210-0x00000001848BA300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WatcherAllDataNotify other) {} // 0x00000001848B9E20-0x00000001848B9F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001848B9C20-0x00000001848B9D60
}

