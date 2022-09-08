/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarFollowRouteNotify : MessageBase, IMessage<AvatarFollowRouteNotify> // TypeDefIndex: 25361
{
	// Fields
	private static readonly MessageParser<AvatarFollowRouteNotify> _parser; // 0x00
	public const int RouteFieldNumber = 1; // Metadata: 0x00B088C7
	private Route route_; // 0x18
	public const int StartSceneTimeMsFieldNumber = 2; // Metadata: 0x00B088CB
	private uint startSceneTimeMs_; // 0x20
	public const int EntityIdFieldNumber = 3; // Metadata: 0x00B088CF
	private uint entityId_; // 0x24
	public const int ClientParamsFieldNumber = 4; // Metadata: 0x00B088D3
	private string clientParams_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarFollowRouteNotify> Parser { get => default; } // 0x0000000184A9CBF0-0x0000000184A9CC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184A9C980-0x0000000184A9CA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184A9C4C0-0x0000000184A9C540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184A9BB50-0x0000000184A9BBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184A9D250-0x0000000184A9D340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184A9CFF0-0x0000000184A9D050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184A9CA10-0x0000000184A9CB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184A9D200-0x0000000184A9D250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184A9C690-0x0000000184A9C780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Route Route { get => default; set {} } // 0x0000000184A9CDB0-0x0000000184A9CE50 0x0000000184A9BAB0-0x0000000184A9BB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StartSceneTimeMs { get => default; set {} } // 0x0000000184A9CC80-0x0000000184A9CD20 0x0000000184A9C420-0x0000000184A9C4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000184A9CF50-0x0000000184A9CFF0 0x0000000184A9D340-0x0000000184A9D3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string ClientParams { get => default; set {} } // 0x0000000184A9D3E0-0x0000000184A9D480 0x0000000184A9C5E0-0x0000000184A9C690

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25362
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25363
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3068
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFollowRouteNotify() {} // 0x0000000184A9D820-0x0000000184A9D890
	static AvatarFollowRouteNotify() {} // 0x0000000184A9D760-0x0000000184A9D820

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFollowRouteNotify Clone() => default; // 0x0000000184A9CB00-0x0000000184A9CBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFollowRouteNotify ShallowCopy() => default; // 0x0000000184A9C540-0x0000000184A9C5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A9BDA0-0x0000000184A9BE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A9CE50-0x0000000184A9CED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A9CED0-0x0000000184A9CF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184A9BE20-0x0000000184A9BF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184A9BF70-0x0000000184A9C040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarFollowRouteNotify other) => default; // 0x0000000184A9C040-0x0000000184A9C1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184A9C780-0x0000000184A9C980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184A9D480-0x0000000184A9D760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A9D050-0x0000000184A9D200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184A9C1E0-0x0000000184A9C420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarFollowRouteNotify other) {} // 0x0000000184A9BBB0-0x0000000184A9BDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A9B940-0x0000000184A9BAB0
}

