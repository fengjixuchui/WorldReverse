/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtEntityRenderersChangedNotify : MessageBase, IMessage<EvtEntityRenderersChangedNotify> // TypeDefIndex: 23085
{
	// Fields
	private static readonly MessageParser<EvtEntityRenderersChangedNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B03287
	private ForwardType forwardType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B0328B
	private uint entityId_; // 0x1C
	public const int IsServerCacheFieldNumber = 3; // Metadata: 0x00B0328F
	private bool isServerCache_; // 0x20
	public const int RendererChangedInfoFieldNumber = 4; // Metadata: 0x00B03293
	private EntityRendererChangedInfo rendererChangedInfo_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtEntityRenderersChangedNotify> Parser { get => default; } // 0x00000001812969A0-0x0000000181296A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181296690-0x0000000181296720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181296260-0x00000001812962E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181295850-0x00000001812958B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181296F50-0x0000000181297040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181296D00-0x0000000181296D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181296720-0x0000000181296810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181296F00-0x0000000181296F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181296380-0x0000000181296470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x00000001812961C0-0x0000000181296260 0x0000000181295B00-0x0000000181295BA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000181296BC0-0x0000000181296C60 0x0000000181297040-0x00000001812970E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsServerCache { get => default; set {} } // 0x0000000181295CF0-0x0000000181295D90 0x0000000181296C60-0x0000000181296D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityRendererChangedInfo RendererChangedInfo { get => default; set {} } // 0x0000000181296900-0x00000001812969A0 0x00000001812970E0-0x0000000181297180

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23086
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23087
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 334
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtEntityRenderersChangedNotify() {} // 0x0000000181297540-0x00000001812975B0
	static EvtEntityRenderersChangedNotify() {} // 0x0000000181297480-0x0000000181297540

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtEntityRenderersChangedNotify Clone() => default; // 0x0000000181296810-0x0000000181296900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtEntityRenderersChangedNotify ShallowCopy() => default; // 0x00000001812962E0-0x0000000181296380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181295A80-0x0000000181295B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181296AC0-0x0000000181296B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181296B40-0x0000000181296BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181295BA0-0x0000000181295CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181295F00-0x0000000181295FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtEntityRenderersChangedNotify other) => default; // 0x0000000181295D90-0x0000000181295F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181296470-0x0000000181296690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181297180-0x0000000181297480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181296D60-0x0000000181296F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181295FD0-0x00000001812961C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtEntityRenderersChangedNotify other) {} // 0x00000001812958B0-0x0000000181295A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001812956E0-0x0000000181295850
}

