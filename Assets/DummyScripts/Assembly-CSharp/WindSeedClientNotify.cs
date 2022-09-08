/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WindSeedClientNotify : MessageBase, IMessage<WindSeedClientNotify> // TypeDefIndex: 21805
{
	// Fields
	private static readonly MessageParser<WindSeedClientNotify> _parser; // 0x00
	public const int RefreshNotifyFieldNumber = 1; // Metadata: 0x00B00087
	public const int AddWindBulletNotifyFieldNumber = 2; // Metadata: 0x00B0008B
	public const int AreaNotifyFieldNumber = 3; // Metadata: 0x00B0008F
	private object notify_; // 0x18
	private NotifyOneofCase notifyCase_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WindSeedClientNotify> Parser { get => default; } // 0x0000000185612AA0-0x0000000185612B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001856125F0-0x0000000185612680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001856121D0-0x0000000185612250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001856116C0-0x0000000185611720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001856131A0-0x0000000185613290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185612F00-0x0000000185612F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185612750-0x0000000185612840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185613150-0x00000001856131A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001856122F0-0x00000001856123E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.RefreshNotify RefreshNotify { get => default; set {} } // 0x0000000185612680-0x0000000185612750 0x0000000185611AE0-0x0000000185611B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.AddWindBulletNotify AddWindBulletNotify { get => default; set {} } // 0x0000000185612520-0x00000001856125F0 0x0000000185612A00-0x0000000185612AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.AreaNotify AreaNotify { get => default; set {} } // 0x0000000185612930-0x0000000185612A00 0x00000001856130B0-0x0000000185613150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public NotifyOneofCase NotifyCase { get => default; } // 0x0000000185612BC0-0x0000000185612C20 

	// Nested types
	public enum NotifyOneofCase // TypeDefIndex: 21806
	{
		None = 0,
		RefreshNotify = 1,
		AddWindBulletNotify = 2,
		AreaNotify = 3
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 21807
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 21808
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1110
		}

		public sealed class RefreshNotify : MessageBase, IMessage<RefreshNotify> // TypeDefIndex: 21809
		{
			// Fields
			private static readonly MessageParser<RefreshNotify> _parser; // 0x00
			public const int RefreshNumFieldNumber = 1; // Metadata: 0x00B000B3
			private uint refreshNum_; // 0x18

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<RefreshNotify> Parser { get => default; } // 0x00000001855FEA40-0x00000001855FEAD0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001855FE730-0x00000001855FE7C0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x00000001855FE440-0x00000001855FE4C0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x00000001855FDF50-0x00000001855FDFB0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x00000001855FEE30-0x00000001855FEF20 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x00000001855FEC00-0x00000001855FEC60 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x00000001855FE7C0-0x00000001855FE8B0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x00000001855FEDE0-0x00000001855FEE30 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x00000001855FE560-0x00000001855FE650 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint RefreshNum { get => default; set {} } // 0x00000001855FE9A0-0x00000001855FEA40 0x00000001855FED40-0x00000001855FEDE0

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RefreshNotify() {} // 0x00000001855FF150-0x00000001855FF1B0
			static RefreshNotify() {} // 0x00000001855FF090-0x00000001855FF150

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RefreshNotify Clone() => default; // 0x00000001855FE8B0-0x00000001855FE9A0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RefreshNotify ShallowCopy() => default; // 0x00000001855FE4C0-0x00000001855FE560
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x00000001855FE0C0-0x00000001855FE110
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001855FEB60-0x00000001855FEBB0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001855FEBB0-0x00000001855FEC00
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x00000001855FE110-0x00000001855FE180
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x00000001855FE280-0x00000001855FE350
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(RefreshNotify other) => default; // 0x00000001855FE180-0x00000001855FE280
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x00000001855FE650-0x00000001855FE730
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x00000001855FEF20-0x00000001855FF090
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x00000001855FEC60-0x00000001855FED40
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x00000001855FE350-0x00000001855FE440
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(RefreshNotify other) {} // 0x00000001855FDFB0-0x00000001855FE0C0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x00000001855FDE70-0x00000001855FDF50
		}

		public sealed class AddWindBulletNotify : MessageBase, IMessage<AddWindBulletNotify> // TypeDefIndex: 21810
		{
			// Fields
			private static readonly MessageParser<AddWindBulletNotify> _parser; // 0x00
			public const int SeedEntityIdFieldNumber = 1; // Metadata: 0x00B000B7
			private uint seedEntityId_; // 0x18
			public const int SeedPosFieldNumber = 2; // Metadata: 0x00B000BB
			private Vector seedPos_; // 0x20
			public const int CatchPlayerUidFieldNumber = 3; // Metadata: 0x00B000BF
			private uint catchPlayerUid_; // 0x28

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<AddWindBulletNotify> Parser { get => default; } // 0x00000001855FD440-0x00000001855FD4D0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001855FD090-0x00000001855FD120 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x00000001855FCC30-0x00000001855FCCB0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x00000001855FC320-0x00000001855FC380 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x00000001855FD910-0x00000001855FDA00 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x00000001855FD700-0x00000001855FD760 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x00000001855FD1C0-0x00000001855FD2B0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x00000001855FD8C0-0x00000001855FD910 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x00000001855FCDF0-0x00000001855FCEE0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint SeedEntityId { get => default; set {} } // 0x00000001855FD3A0-0x00000001855FD440 0x00000001855FCB90-0x00000001855FCC30
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public Vector SeedPos { get => default; set {} } // 0x00000001855FD120-0x00000001855FD1C0 0x00000001855FCCB0-0x00000001855FCD50
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint CatchPlayerUid { get => default; set {} } // 0x00000001855FC6F0-0x00000001855FC790 0x00000001855FD660-0x00000001855FD700

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public AddWindBulletNotify() {} // 0x00000001855FDD30-0x00000001855FDD90
			static AddWindBulletNotify() {} // 0x00000001855FDC70-0x00000001855FDD30

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public AddWindBulletNotify Clone() => default; // 0x00000001855FD2B0-0x00000001855FD3A0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public AddWindBulletNotify ShallowCopy() => default; // 0x00000001855FCD50-0x00000001855FCDF0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x00000001855FC530-0x00000001855FC5B0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001855FD560-0x00000001855FD5E0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001855FD5E0-0x00000001855FD660
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x00000001855FC5B0-0x00000001855FC6F0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x00000001855FC8E0-0x00000001855FC9B0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(AddWindBulletNotify other) => default; // 0x00000001855FC790-0x00000001855FC8E0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x00000001855FCEE0-0x00000001855FD090
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x00000001855FDA00-0x00000001855FDC70
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x00000001855FD760-0x00000001855FD8C0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x00000001855FC9B0-0x00000001855FCB90
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(AddWindBulletNotify other) {} // 0x00000001855FC380-0x00000001855FC530
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x00000001855FC1C0-0x00000001855FC320
		}

		public sealed class AreaNotify : MessageBase, IMessage<AreaNotify> // TypeDefIndex: 21811
		{
			// Fields
			private static readonly MessageParser<AreaNotify> _parser; // 0x00
			public const int AreaIdFieldNumber = 1; // Metadata: 0x00B000C3
			private uint areaId_; // 0x18
			public const int AreaCodeFieldNumber = 2; // Metadata: 0x00B000C7
			private ByteString areaCode_; // 0x20
			public const int AreaTypeFieldNumber = 3; // Metadata: 0x00B000CB
			private uint areaType_; // 0x28

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<AreaNotify> Parser { get => default; } // 0x00000001856003A0-0x0000000185600430 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185600090-0x0000000185600120 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { get => default; } // 0x00000001855FFD20-0x00000001855FFDA0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { get => default; } // 0x00000001855FF510-0x00000001855FF570 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { get => default; } // 0x00000001856008D0-0x00000001856009C0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { get => default; } // 0x0000000185600600-0x0000000185600660 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { get => default; } // 0x00000001856001C0-0x00000001856002B0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { get => default; } // 0x0000000185600880-0x00000001856008D0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { get => default; } // 0x00000001855FFE40-0x00000001855FFF30 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint AreaId { get => default; set {} } // 0x00000001855FF7F0-0x00000001855FF890 0x0000000185600120-0x00000001856001C0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public ByteString AreaCode { get => default; set {} } // 0x0000000185600660-0x0000000185600700 0x00000001855FF890-0x00000001855FF940
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public uint AreaType { get => default; set {} } // 0x00000001856009C0-0x0000000185600A60 0x0000000185600510-0x00000001856005B0

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public AreaNotify() {} // 0x0000000185600D90-0x0000000185600E20
			static AreaNotify() {} // 0x0000000185600CD0-0x0000000185600D90

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public AreaNotify Clone() => default; // 0x00000001856002B0-0x00000001856003A0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public AreaNotify ShallowCopy() => default; // 0x00000001855FFDA0-0x00000001855FFE40
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalSetInPool(bool value) {} // 0x00000001855FF6F0-0x00000001855FF740
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001856004C0-0x0000000185600510
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001856005B0-0x0000000185600600
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void Reset() {} // 0x00000001855FF740-0x00000001855FF7F0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override bool Equals(object other) => default; // 0x00000001855FFAB0-0x00000001855FFB80
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool Equals(AreaNotify other) => default; // 0x00000001855FF940-0x00000001855FFAB0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int GetHashCode() => default; // 0x00000001855FFF30-0x0000000185600090
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ToString() => default; // 0x0000000185600A60-0x0000000185600CD0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void WriteTo(CodedOutputStream output) {} // 0x0000000185600700-0x0000000185600880
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override int CalculateSize() => default; // 0x00000001855FFB80-0x00000001855FFD20
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public void CopyFrom(AreaNotify other) {} // 0x00000001855FF570-0x00000001855FF6F0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override void MergeFrom(CodedInputStream input) {} // 0x00000001855FF400-0x00000001855FF510
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WindSeedClientNotify() {} // 0x0000000185613600-0x0000000185613670
	static WindSeedClientNotify() {} // 0x0000000185613540-0x0000000185613600

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WindSeedClientNotify Clone() => default; // 0x0000000185612840-0x0000000185612930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WindSeedClientNotify ShallowCopy() => default; // 0x0000000185612250-0x00000001856122F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185611900-0x0000000185611A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185612C20-0x0000000185612D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185612D90-0x0000000185612F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185611A80-0x0000000185611AE0
	public void resetNotify() {} // 0x0000000185611F50-0x00000001856121D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearNotify() {} // 0x0000000185611660-0x00000001856116C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185611D10-0x0000000185611DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WindSeedClientNotify other) => default; // 0x0000000185611B80-0x0000000185611D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001856123E0-0x0000000185612520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185613290-0x0000000185613540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185612F60-0x00000001856130B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185611DE0-0x0000000185611F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WindSeedClientNotify other) {} // 0x0000000185611720-0x0000000185611900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001856113F0-0x0000000185611660
}

