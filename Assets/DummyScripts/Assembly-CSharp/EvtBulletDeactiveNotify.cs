/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtBulletDeactiveNotify : MessageBase, IMessage<EvtBulletDeactiveNotify> // TypeDefIndex: 23045
{
	// Fields
	private static readonly MessageParser<EvtBulletDeactiveNotify> _parser; // 0x00
	public const int ForwardTypeFieldNumber = 1; // Metadata: 0x00B030CF
	private ForwardType forwardType_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B030D3
	private uint entityId_; // 0x1C
	public const int DisappearPosFieldNumber = 3; // Metadata: 0x00B030D7
	private Vector disappearPos_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtBulletDeactiveNotify> Parser { get => default; } // 0x0000000184AD1930-0x0000000184AD19C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184AD16C0-0x0000000184AD1750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184AD12C0-0x0000000184AD1340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184AD0910-0x0000000184AD0970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184AD1EA0-0x0000000184AD1F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184AD1BF0-0x0000000184AD1C50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184AD1750-0x0000000184AD1840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184AD1E50-0x0000000184AD1EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184AD13E0-0x0000000184AD14D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForwardType ForwardType { get => default; set {} } // 0x0000000184AD1220-0x0000000184AD12C0 0x0000000184AD0C40-0x0000000184AD0CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000184AD1B50-0x0000000184AD1BF0 0x0000000184AD1F90-0x0000000184AD2030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector DisappearPos { get => default; set {} } // 0x0000000184AD1DB0-0x0000000184AD1E50 0x0000000184AD0B20-0x0000000184AD0BC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23046
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23047
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 314
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBulletDeactiveNotify() {} // 0x0000000184AD2360-0x0000000184AD23D0
	static EvtBulletDeactiveNotify() {} // 0x0000000184AD22A0-0x0000000184AD2360

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBulletDeactiveNotify Clone() => default; // 0x0000000184AD1840-0x0000000184AD1930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtBulletDeactiveNotify ShallowCopy() => default; // 0x0000000184AD1340-0x0000000184AD13E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184AD0BC0-0x0000000184AD0C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184AD1A50-0x0000000184AD1AD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184AD1AD0-0x0000000184AD1B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184AD0CE0-0x0000000184AD0E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184AD0F70-0x0000000184AD1040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtBulletDeactiveNotify other) => default; // 0x0000000184AD0E20-0x0000000184AD0F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184AD14D0-0x0000000184AD16C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184AD2030-0x0000000184AD22A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184AD1C50-0x0000000184AD1DB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184AD1040-0x0000000184AD1220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtBulletDeactiveNotify other) {} // 0x0000000184AD0970-0x0000000184AD0B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184AD07C0-0x0000000184AD0910
}

