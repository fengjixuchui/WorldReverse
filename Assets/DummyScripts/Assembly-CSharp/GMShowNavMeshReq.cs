/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GMShowNavMeshReq : MessageBase, IMessage<GMShowNavMeshReq> // TypeDefIndex: 24283
{
	// Fields
	private static readonly MessageParser<GMShowNavMeshReq> _parser; // 0x00
	public const int CenterFieldNumber = 1; // Metadata: 0x00B0604B
	private Vector center_; // 0x18
	public const int ExtentFieldNumber = 2; // Metadata: 0x00B0604F
	private Vector extent_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GMShowNavMeshReq> Parser { get => default; } // 0x0000000184C26C80-0x0000000184C26D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184C26A10-0x0000000184C26AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184C26570-0x0000000184C265F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184C25CA0-0x0000000184C25D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184C27120-0x0000000184C27210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184C26EC0-0x0000000184C26F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184C26AA0-0x0000000184C26B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184C270D0-0x0000000184C27120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184C26690-0x0000000184C26780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Center { get => default; set {} } // 0x0000000184C25A90-0x0000000184C25B30 0x0000000184C26970-0x0000000184C26A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Extent { get => default; set {} } // 0x0000000184C26F20-0x0000000184C26FC0 0x0000000184C27210-0x0000000184C272B0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24284
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24285
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2353
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GMShowNavMeshReq() {} // 0x0000000184C27530-0x0000000184C27590
	static GMShowNavMeshReq() {} // 0x0000000184C27470-0x0000000184C27530

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GMShowNavMeshReq Clone() => default; // 0x0000000184C26B90-0x0000000184C26C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GMShowNavMeshReq ShallowCopy() => default; // 0x0000000184C265F0-0x0000000184C26690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184C25EE0-0x0000000184C25F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C26DA0-0x0000000184C26E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C26E30-0x0000000184C26EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184C25F70-0x0000000184C26150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184C26290-0x0000000184C26360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GMShowNavMeshReq other) => default; // 0x0000000184C26150-0x0000000184C26290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184C26780-0x0000000184C26970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184C272B0-0x0000000184C27470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184C26FC0-0x0000000184C270D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184C26360-0x0000000184C26570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GMShowNavMeshReq other) {} // 0x0000000184C25D00-0x0000000184C25EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184C25B30-0x0000000184C25CA0
}

