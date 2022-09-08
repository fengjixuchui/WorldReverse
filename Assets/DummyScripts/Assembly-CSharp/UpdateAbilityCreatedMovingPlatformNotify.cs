/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UpdateAbilityCreatedMovingPlatformNotify : MessageBase, IMessage<UpdateAbilityCreatedMovingPlatformNotify> // TypeDefIndex: 23219
{
	// Fields
	private static readonly MessageParser<UpdateAbilityCreatedMovingPlatformNotify> _parser; // 0x00
	public const int OpTypeFieldNumber = 1; // Metadata: 0x00B03833
	private Types.OpType opType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B03837
	private uint entityId_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UpdateAbilityCreatedMovingPlatformNotify> Parser { get => default; } // 0x0000000182D99DD0-0x0000000182D99E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D99B60-0x0000000182D99BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D99800-0x0000000182D99880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D991F0-0x0000000182D99250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D9A200-0x0000000182D9A2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D9A030-0x0000000182D9A090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D99BF0-0x0000000182D99CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D9A1B0-0x0000000182D9A200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D99920-0x0000000182D99A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.OpType OpType { get => default; set {} } // 0x0000000182D99380-0x0000000182D99420 0x0000000182D99150-0x0000000182D991F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182D99F90-0x0000000182D9A030 0x0000000182D9A2F0-0x0000000182D9A390

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23220
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23221
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 815
		}

		public enum OpType // TypeDefIndex: 23222
		{
			OpNone = 0,
			OpActivate = 1,
			OpDeactivate = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdateAbilityCreatedMovingPlatformNotify() {} // 0x0000000182D9A650-0x0000000182D9A6C0
	static UpdateAbilityCreatedMovingPlatformNotify() {} // 0x0000000182D9A590-0x0000000182D9A650

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdateAbilityCreatedMovingPlatformNotify Clone() => default; // 0x0000000182D99CE0-0x0000000182D99DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdateAbilityCreatedMovingPlatformNotify ShallowCopy() => default; // 0x0000000182D99880-0x0000000182D99920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D99420-0x0000000182D99470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D99EF0-0x0000000182D99F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D99F40-0x0000000182D99F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D99470-0x0000000182D994E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D994E0-0x0000000182D995B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UpdateAbilityCreatedMovingPlatformNotify other) => default; // 0x0000000182D995B0-0x0000000182D996D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D99A10-0x0000000182D99B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D9A390-0x0000000182D9A590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D9A090-0x0000000182D9A1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D996D0-0x0000000182D99800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UpdateAbilityCreatedMovingPlatformNotify other) {} // 0x0000000182D99250-0x0000000182D99380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D99060-0x0000000182D99150
}

