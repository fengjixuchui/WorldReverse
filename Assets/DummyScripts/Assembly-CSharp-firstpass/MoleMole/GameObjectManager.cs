/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class GameObjectManager : InLevelManager // TypeDefIndex: 7430
	{
		// Fields
		private HashList<GameObjectCache> _gameObjectList; // 0x10
		private Dictionary<ulong, HashList<GameObjectCache>> _gameObjectMap; // 0x18
		public static Transform Cache_ROOT; // 0x00
	
		// Properties
		public int MapCount { /* [XID] */ /* 0x00000001897471F0-0x0000000189747210 */ get => default; } // 0x0000000189BE5B20-0x0000000189BE5D00 
	
		// Nested types
		public class GameObjectCache // TypeDefIndex: 7431
		{
			// Properties
			public ulong hash { /* [XID] */ /* 0x0000000189795F10-0x0000000189795F50 */ get; /* [XID] */ /* 0x00000001897A0D30-0x00000001897A0D70 */ set; } // 0x0000000189BE4940-0x0000000189BE49A0 0x0000000189BE4A00-0x0000000189BE4A60
			public GameObject gameObject { /* [XID] */ /* 0x00000001897AB080-0x00000001897AB0C0 */ get; /* [XID] */ /* 0x00000001897B6630-0x00000001897B6670 */ set; } // 0x0000000189BE48E0-0x0000000189BE4940 0x0000000189BE49A0-0x0000000189BE4A00
	
			// Constructors
			public GameObjectCache() {} // 0x0000000189BE4880-0x0000000189BE48E0
	
			// Methods
			// [XID] // 0x00000001897C1110-0x00000001897C1130
			public void Clear() {} // 0x0000000189BE4550-0x0000000189BE4680
			// [XID] // 0x00000001897C8AA0-0x00000001897C8AC0
			public void Destroy() {} // 0x0000000189BE4680-0x0000000189BE4880
		}
	
		// Constructors
		public GameObjectManager() {} // 0x0000000189BE5A80-0x0000000189BE5B20
		static GameObjectManager() {} // 0x0000000189BE5A20-0x0000000189BE5A80
	
		// Methods
		// [IDTag] // 0x000000018974E9A0-0x000000018974E9E0
		// [XID] // 0x000000018974E9A0-0x000000018974E9E0
		private void Delete(DoublyList<GameObjectCache> node) {} // 0x0000000189BE53B0-0x0000000189BE55E0
		// [IDTag] // 0x0000000189758A70-0x0000000189758AB0
		// [XID] // 0x0000000189758A70-0x0000000189758AB0
		public void Delete(ulong hash) {} // 0x0000000189BE51B0-0x0000000189BE53B0
		// [XID] // 0x0000000189763690-0x00000001897636B0
		public override void Destroy() {} // 0x0000000189BE55E0-0x0000000189BE58C0
		// [XID] // 0x000000018976AE50-0x000000018976AE70
		public override void Init() {} // 0x0000000189BE58C0-0x0000000189BE5A20
		// [XID] // 0x0000000189772400-0x0000000189772420
		public bool Allocate(ulong hash, out GameObject g) {
			g = default;
			return default;
		} // 0x0000000189BE4A60-0x0000000189BE4DB0
		// [XID] // 0x0000000189779A60-0x0000000189779A80
		public void DeAllocate(ulong hash, GameObject g, bool usePool, bool deActive = true /* Metadata: 0x00ADE9F4 */) {} // 0x0000000189BE4DB0-0x0000000189BE51B0
	}
}
