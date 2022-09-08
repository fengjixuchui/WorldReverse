/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	public sealed class NetSerializer // TypeDefIndex: 6924
	{
		// Fields
		private readonly Dictionary<ulong, StructInfo> _cache; // 0x10
		private readonly Dictionary<System.Type, CustomType> _registeredCustomTypes; // 0x18
		private static readonly HashSet<System.Type> BasicTypes; // 0x00
		private readonly NetDataWriter _writer; // 0x20
		private readonly NetSerializerHasher _hasher; // 0x28
		private const int MaxStringLenght = 1024; // Metadata: 0x00ADE079
	
		// Nested types
		private sealed class CustomType // TypeDefIndex: 6925
		{
			// Fields
			public readonly CustomTypeWrite WriteDelegate; // 0x10
			public readonly CustomTypeRead ReadDelegate; // 0x18
	
			// Constructors
			public CustomType() {} // Dummy constructor
			public CustomType(CustomTypeWrite writeDelegate, CustomTypeRead readDelegate) {} // 0x0000000186B3C240-0x0000000186B3C2E0
		}
	
		private delegate void CustomTypeWrite(NetDataWriter writer, object customObj); // TypeDefIndex: 6926; 0x0000000186B3BF10-0x0000000186B3C1C0
	
		private delegate object CustomTypeRead(NetDataReader reader); // TypeDefIndex: 6927; 0x0000000186B3BB30-0x0000000186B3BD90
	
		private sealed class StructInfo // TypeDefIndex: 6928
		{
			// Fields
			public readonly Action<NetDataWriter>[] WriteDelegate; // 0x10
			public readonly Action<NetDataReader>[] ReadDelegate; // 0x18
			public readonly System.Type[] FieldTypes; // 0x20
			public object Reference; // 0x28
			public Func<object> CreatorFunc; // 0x30
			public Action<object, object> OnReceive; // 0x38
			public readonly ulong Hash; // 0x40
			public readonly int MembersCount; // 0x48
	
			// Constructors
			public StructInfo() {} // Dummy constructor
			public StructInfo(ulong hash, int membersCount) {} // 0x0000000186B464F0-0x0000000186B465D0
	
			// Methods
			// [XID] // 0x00000001898EB060-0x00000001898EB080
			public void Write(NetDataWriter writer, object obj) {} // 0x0000000186B463D0-0x0000000186B464F0
			// [XID] // 0x00000001898F2780-0x00000001898F27A0
			public void Read(NetDataReader reader) {} // 0x0000000186B462C0-0x0000000186B463D0
		}
	
		// Constructors
		public NetSerializer() {} // 0x0000000186B45230-0x0000000186B452C0
		public NetSerializer(NetSerializerHasher hasher) {} // 0x0000000186B452C0-0x0000000186B453A0
		static NetSerializer() {} // 0x0000000186B44FC0-0x0000000186B45230
	
		// Methods
		private bool RegisterCustomTypeInternal<T>(Func<T> constructor)
			where T : INetSerializable => default;
		public bool RegisterCustomType<T>()
			where T : struct, INetSerializable => default;
		public bool RegisterCustomType<T>(Func<T> constructor)
			where T : class, INetSerializable => default;
		public bool RegisterCustomType<T>(Action<NetDataWriter, T> writeDelegate, Func<NetDataReader, T> readDelegate) => default;
		// [XID] // 0x0000000189970040-0x0000000189970060
		private static Delegate CreateDelegate(System.Type type, MethodInfo info) => default; // 0x0000000186B44B00-0x0000000186B44BC0
		private static Func<TClass, TProperty> ExtractGetDelegate<TClass, TProperty>(MethodInfo info) => default;
		private static Action<TClass, TProperty> ExtractSetDelegate<TClass, TProperty>(MethodInfo info) => default;
		private StructInfo RegisterInternal<T>()
			where T : class => default;
		// [XID] // 0x00000001898B0360-0x00000001898B0380
		public void ReadAllPackets(NetDataReader reader) {} // 0x0000000186B44BC0-0x0000000186B44CA0
		public void ReadAllPackets<T>(NetDataReader reader, T userData) {}
		// [IDTag] // 0x00000001898B7820-0x00000001898B7860
		// [XID] // 0x00000001898B7820-0x00000001898B7860
		public void ReadPacket(NetDataReader reader) {} // 0x0000000186B44DE0-0x0000000186B44EA0
		// [XID] // 0x00000001898C2000-0x00000001898C2020
		private StructInfo ReadInfo(NetDataReader reader) => default; // 0x0000000186B44CA0-0x0000000186B44DE0
		public T ReadKnownPacket<T>(NetDataReader reader)
			where T : class, new() => default;
		public bool ReadKnownPacket<T>(NetDataReader reader, T target)
			where T : class, new() => default;
		// [IDTag] // 0x00000001898C9960-0x00000001898C99A0
		// [XID] // 0x00000001898C9960-0x00000001898C99A0
		public void ReadPacket(NetDataReader reader, object userData) {} // 0x0000000186B44EA0-0x0000000186B44FC0
		public void Subscribe<T>(Action<T> onReceive, Func<T> packetConstructor)
			where T : class, new() {}
		public void Register<T>(Func<T> packetConstructor = null)
			where T : class, new() {}
		public void Subscribe<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor)
			where T : class, new() {}
		public void SubscribeReusable<T>(Action<T> onReceive)
			where T : class, new() {}
		public void SubscribeReusable<T, TUserData>(Action<T, TUserData> onReceive)
			where T : class, new() {}
		public void Serialize<T>(NetDataWriter writer, T obj)
			where T : class, new() {}
		public byte[] Serialize<T>(T obj)
			where T : class, new() => default;
	}
}
