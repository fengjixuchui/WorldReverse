/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer.Internal;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Gaia.FullSerializer
{
	public class fsMetaType // TypeDefIndex: 9276
	{
		// Fields
		private static Dictionary<System.Type, fsMetaType> _metaTypes; // 0x00
		public System.Type ReflectedType; // 0x10
		private bool _hasEmittedAotData; // 0x18
		private bool? _hasDefaultConstructorCache; // 0x28
		private bool _isDefaultConstructorPublic; // 0x2A
	
		// Properties
		public fsMetaProperty[] Properties { /* [XID] */ /* 0x00000001895FEA90-0x00000001895FEAD0 */ get; private set; } // 0x0000000186B57990-0x0000000186B579F0 0x0000000186B579F0-0x0000000186B57A50
		public bool HasDefaultConstructor { /* [XID] */ /* 0x00000001899D03B0-0x00000001899D03D0 */ get => default; } // 0x0000000186B57760-0x0000000186B57990 
	
		// Constructors
		public fsMetaType() {} // Dummy constructor
		private fsMetaType(System.Type reflectedType) {} // 0x0000000186B57650-0x0000000186B57760
		static fsMetaType() {} // 0x0000000186B575C0-0x0000000186B57650
	
		// Methods
		// [XID] // 0x0000000189BC5200-0x0000000189BC5220
		public static fsMetaType Get(System.Type type) => default; // 0x0000000186B57240-0x0000000186B573D0
		// [XID] // 0x0000000189BCCC40-0x0000000189BCCC60
		public static void ClearCache() {} // 0x0000000186B56540-0x0000000186B56620
		// [XID] // 0x0000000189A58900-0x0000000189A58920
		private static void CollectProperties(List<fsMetaProperty> properties, System.Type reflectedType) {} // 0x0000000186B56620-0x0000000186B56BB0
		// [XID] // 0x0000000189BDBC20-0x0000000189BDBC40
		private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members) => default; // 0x0000000186B573D0-0x0000000186B575C0
		// [XID] // 0x00000001895E85B0-0x00000001895E85D0
		private static bool CanSerializeProperty(PropertyInfo property, MemberInfo[] members, bool annotationFreeValue) => default; // 0x0000000186B56160-0x0000000186B56540
		// [XID] // 0x00000001895EFD80-0x00000001895EFDA0
		private static bool CanSerializeField(FieldInfo field, bool annotationFreeValue) => default; // 0x0000000186B55E70-0x0000000186B56160
		// [XID] // 0x00000001895F76F0-0x00000001895F7710
		public bool EmitAotData() => default; // 0x0000000186B57080-0x0000000186B57240
		// [XID] // 0x0000000189618250-0x0000000189618270
		public object CreateInstance() => default; // 0x0000000186B56BB0-0x0000000186B57080
	}
}
