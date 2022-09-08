/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayOutofRegionNotify : MessageBase, IMessage<ScenePlayOutofRegionNotify> // TypeDefIndex: 25413
{
	// Fields
	private static readonly MessageParser<ScenePlayOutofRegionNotify> _parser; // 0x00
	public const int PlayIdFieldNumber = 1; // Metadata: 0x00B08B07
	private uint playId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayOutofRegionNotify> Parser { get => default; } // 0x0000000182BD4C10-0x0000000182BD4CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182BD49A0-0x0000000182BD4A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182BD4610-0x0000000182BD4690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182BD4080-0x0000000182BD40E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182BD4F60-0x0000000182BD5050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182BD4DD0-0x0000000182BD4E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182BD4A30-0x0000000182BD4B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182BD4F10-0x0000000182BD4F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182BD4730-0x0000000182BD4820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayId { get => default; set {} } // 0x0000000182BD4570-0x0000000182BD4610 0x0000000182BD4900-0x0000000182BD49A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25414
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25415
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4366
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayOutofRegionNotify() {} // 0x0000000182BD5280-0x0000000182BD52E0
	static ScenePlayOutofRegionNotify() {} // 0x0000000182BD51C0-0x0000000182BD5280

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayOutofRegionNotify Clone() => default; // 0x0000000182BD4B20-0x0000000182BD4C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayOutofRegionNotify ShallowCopy() => default; // 0x0000000182BD4690-0x0000000182BD4730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182BD41F0-0x0000000182BD4240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BD4D30-0x0000000182BD4D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182BD4D80-0x0000000182BD4DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182BD4240-0x0000000182BD42B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182BD42B0-0x0000000182BD4380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayOutofRegionNotify other) => default; // 0x0000000182BD4380-0x0000000182BD4480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182BD4820-0x0000000182BD4900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182BD5050-0x0000000182BD51C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182BD4E30-0x0000000182BD4F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182BD4480-0x0000000182BD4570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayOutofRegionNotify other) {} // 0x0000000182BD40E0-0x0000000182BD41F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182BD3FA0-0x0000000182BD4080
}

