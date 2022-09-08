/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EnterScenePeerNotify : MessageBase, IMessage<EnterScenePeerNotify> // TypeDefIndex: 25151
{
	// Fields
	private static readonly MessageParser<EnterScenePeerNotify> _parser; // 0x00
	public const int DestSceneIdFieldNumber = 1; // Metadata: 0x00B0817F
	private uint destSceneId_; // 0x18
	public const int PeerIdFieldNumber = 2; // Metadata: 0x00B08183
	private uint peerId_; // 0x1C
	public const int HostPeerIdFieldNumber = 3; // Metadata: 0x00B08187
	private uint hostPeerId_; // 0x20
	public const int EnterSceneTokenFieldNumber = 4; // Metadata: 0x00B0818B
	private uint enterSceneToken_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EnterScenePeerNotify> Parser { get => default; } // 0x000000018279E760-0x000000018279E7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018279E3B0-0x000000018279E440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018279DF00-0x000000018279DF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018279D670-0x000000018279D6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018279EC10-0x000000018279ED00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018279E9C0-0x000000018279EA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018279E4E0-0x000000018279E5D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018279EBC0-0x000000018279EC10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018279E0C0-0x000000018279E1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DestSceneId { get => default; set {} } // 0x000000018279E310-0x000000018279E3B0 0x000000018279D6D0-0x000000018279D770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PeerId { get => default; set {} } // 0x000000018279E020-0x000000018279E0C0 0x000000018279D770-0x000000018279D810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HostPeerId { get => default; set {} } // 0x000000018279E6C0-0x000000018279E760 0x000000018279DC90-0x000000018279DD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EnterSceneToken { get => default; set {} } // 0x000000018279E440-0x000000018279E4E0 0x000000018279E920-0x000000018279E9C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25152
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25153
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 284
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterScenePeerNotify() {} // 0x000000018279F0E0-0x000000018279F140
	static EnterScenePeerNotify() {} // 0x000000018279F020-0x000000018279F0E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterScenePeerNotify Clone() => default; // 0x000000018279E5D0-0x000000018279E6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EnterScenePeerNotify ShallowCopy() => default; // 0x000000018279DF80-0x000000018279E020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018279D990-0x000000018279D9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018279E880-0x000000018279E8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018279E8D0-0x000000018279E920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018279D9E0-0x000000018279DA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018279DA70-0x000000018279DB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EnterScenePeerNotify other) => default; // 0x000000018279DB40-0x000000018279DC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018279E1B0-0x000000018279E310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018279ED00-0x000000018279F020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018279EA20-0x000000018279EBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018279DD30-0x000000018279DF00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EnterScenePeerNotify other) {} // 0x000000018279D810-0x000000018279D990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018279D540-0x000000018279D670
}

