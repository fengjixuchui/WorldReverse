/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class NavMeshStatsNotify : MessageBase, IMessage<NavMeshStatsNotify> // TypeDefIndex: 24294
{
	// Fields
	private static readonly MessageParser<NavMeshStatsNotify> _parser; // 0x00
	public const int InfosFieldNumber = 1; // Metadata: 0x00B060AF
	private static readonly FieldCodec<PbNavMeshStatsInfo> _repeated_infos_codec; // 0x08
	private readonly RepeatedMessageField<PbNavMeshStatsInfo> infos_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<NavMeshStatsNotify> Parser { get => default; } // 0x00000001834767A0-0x0000000183476830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183476530-0x00000001834765C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183476260-0x00000001834762E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183475C80-0x0000000183475CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183476B90-0x0000000183476C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001834769E0-0x0000000183476A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001834765C0-0x00000001834766B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183476B40-0x0000000183476B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183476380-0x0000000183476470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<PbNavMeshStatsInfo> Infos { get => default; } // 0x0000000183476200-0x0000000183476260 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24295
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24296
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2355
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NavMeshStatsNotify() {} // 0x0000000183476EE0-0x0000000183476F70
	static NavMeshStatsNotify() {} // 0x0000000183476DD0-0x0000000183476EE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NavMeshStatsNotify Clone() => default; // 0x00000001834766B0-0x00000001834767A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NavMeshStatsNotify ShallowCopy() => default; // 0x00000001834762E0-0x0000000183476380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183475E10-0x0000000183475E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001834768C0-0x0000000183476950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183476950-0x00000001834769E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183475E60-0x0000000183475F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183476040-0x0000000183476110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(NavMeshStatsNotify other) => default; // 0x0000000183475F30-0x0000000183476040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183476470-0x0000000183476530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183476C80-0x0000000183476DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183476A40-0x0000000183476B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183476110-0x0000000183476200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(NavMeshStatsNotify other) {} // 0x0000000183475CE0-0x0000000183475E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183475B50-0x0000000183475C80
}

