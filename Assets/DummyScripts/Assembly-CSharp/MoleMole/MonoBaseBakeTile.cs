/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public abstract class MonoBaseBakeTile : MonoBehaviour, IBakeSurfaceTile // TypeDefIndex: 31789
	{
		// Fields
		public EBakeLocationType locationType; // 0x18
		public Bounds bounds; // 0x1C
		private Vector3 _curPos; // 0x34
	
		// Nested types
		[Serializable]
		public class BakeTile // TypeDefIndex: 31790
		{
			// Fields
			[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
			public Dict dict; // 0x10
			[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
			public ushort[] heightMaskArray; // 0x18
			public List<float> yHeightList; // 0x20
			public ushort yState; // 0x28
			public float top; // 0x2C
			public float bottom; // 0x30
	
			// Constructors
			public BakeTile() {} // 0x00000001848E44D0-0x00000001848E4580
	
			// Methods
			// [XID] // 0x000000018995B640-0x000000018995B660
			public ushort GetMask(int x, int z) => default; // 0x00000001848E4190-0x00000001848E42E0
			// [XID] // 0x0000000189963220-0x0000000189963240
			public float GetHeight(int x, int z, float top, float bottom) => default; // 0x00000001848E42E0-0x00000001848E44D0
		}
	
		[Serializable]
		public class Dict // TypeDefIndex: 31791
		{
			// Fields
			public int[] buckets; // 0x10
			public uint[] hashArr; // 0x18
			public ushort[] values; // 0x20
			public int[] next; // 0x28
	
			// Constructors
			public Dict() {} // Dummy constructor
			public Dict(int capcity) {} // 0x00000001848E4730-0x00000001848E48F0
	
			// Methods
			// [XID] // 0x000000018996A5E0-0x000000018996A600
			public ushort GetValue(uint hash) => default; // 0x00000001848E4580-0x00000001848E4730
		}
	
		// Constructors
		protected MonoBaseBakeTile() {} // 0x00000001848F60E0-0x00000001848F6140
	
		// Methods
		protected abstract BakeTile GetBakeTile(EBakeTileType type);
		// [XID] // 0x0000000189901B20-0x0000000189901B40
		public EBakeLocationType GetLocationType() => default; // 0x00000001848F5880-0x00000001848F5920
		// [XID] // 0x0000000189909310-0x0000000189909330
		public virtual Bounds GetBounds() => default; // 0x00000001848F5790-0x00000001848F5880
		// [XID] // 0x00000001899107E0-0x0000000189910800
		public int GetTileObjID() => default; // 0x00000001848F5A00-0x00000001848F5AC0
		// [XID] // 0x0000000189918380-0x00000001899183A0
		protected virtual void OnEnable() {} // 0x00000001848F5F40-0x00000001848F60E0
		// [XID] // 0x000000018991FBE0-0x000000018991FC00
		protected virtual void OnDisable() {} // 0x00000001848F5E30-0x00000001848F5F40
		// [XID] // 0x0000000189927410-0x0000000189927430
		public virtual Vector3 GetPos() => default; // 0x00000001848F5920-0x00000001848F5A00
		// [XID] // 0x000000018992EC10-0x000000018992EC30
		public float GetBakeTileHeight(Vector3 pos, float hitRayLength, EBakeTileType type) => default; // 0x00000001848F5650-0x00000001848F5790
		// [XID] // 0x0000000189936070-0x0000000189936090
		protected virtual float LocalToWorld(float y) => default; // 0x00000001848F5AC0-0x00000001848F5B70
		// [XID] // 0x000000018993DAD0-0x000000018993DAF0
		protected virtual float WorldToLocal(float y) => default; // 0x00000001848F55A0-0x00000001848F5650
		// [XID] // 0x0000000189945280-0x00000001899452A0
		protected virtual float GetRegionHeight(Vector3 worldPos, float hitRayLength, BakeTile bakeTile) => default; // 0x00000001848F5B70-0x00000001848F5E30
	}
}
