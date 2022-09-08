/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace JesseStiller.TerrainFormerExtension
{
	public class HeightMapData // TypeDefIndex: 10069
	{
		// Fields
		private int _widthX; // 0x10
		private int _depthZ; // 0x14
		private float[,] _heights; // 0x18
		private Bounds _boundsWU; // 0x20
	
		// Properties
		public float this[int x, int z] { /* [IDTag] */ /* 0x0000000189AAD900-0x0000000189AAD940 */ /* [XID] */ /* 0x0000000189AAD900-0x0000000189AAD940 */ get => default; /* [XID] */ /* 0x0000000189AB8160-0x0000000189AB81A0 */ /* [IDTag] */ /* 0x0000000189AB8160-0x0000000189AB81A0 */ set {} } // 0x0000000186D088E0-0x0000000186D08E00 0x0000000186D08EE0-0x0000000186D09000
		public float this[float x, float z] { /* [IDTag] */ /* 0x0000000189AC2ED0-0x0000000189AC2F10 */ /* [XID] */ /* 0x0000000189AC2ED0-0x0000000189AC2F10 */ get => default; /* [XID] */ /* 0x0000000189ACD820-0x0000000189ACD860 */ /* [IDTag] */ /* 0x0000000189ACD820-0x0000000189ACD860 */ set {} } // 0x0000000186D08E00-0x0000000186D08EE0 0x0000000186D09000-0x0000000186D09160
	
		// Constructors
		public HeightMapData() {} // Dummy constructor
		public HeightMapData(Texture2D texture) {} // 0x0000000186D08840-0x0000000186D088E0
	
		// Methods
		// [XID] // 0x0000000189AA6300-0x0000000189AA6320
		public void LoadFromTexture2D(Texture2D texture) {} // 0x0000000186D08310-0x0000000186D084D0
		// [XID] // 0x0000000189825240-0x0000000189825260
		public bool HasData() => default; // 0x0000000186D08040-0x0000000186D08130
		// [XID] // 0x000000018983B730-0x000000018983B750
		public HeightMapData Invert() => default; // 0x0000000186D081D0-0x0000000186D08310
		// [XID] // 0x0000000189AE75A0-0x0000000189AE75C0
		public HeightMapData Normalise() => default; // 0x0000000186D085C0-0x0000000186D08770
		// [XID] // 0x00000001898430F0-0x0000000189843110
		public void SetBoundsWU(Bounds bounds) {} // 0x0000000186D08770-0x0000000186D08840
		// [XID] // 0x0000000189885120-0x0000000189885140
		public Bounds GetBoundsWU() => default; // 0x0000000186D07B40-0x0000000186D07C30
		// [XID] // 0x000000018988C6E0-0x000000018988C700
		public float[,] Heights() => default; // 0x0000000186D08130-0x0000000186D081D0
		// [XID] // 0x0000000189690A40-0x0000000189690A60
		public int GetWidth() => default; // 0x0000000186D07FA0-0x0000000186D08040
		// [XID] // 0x00000001896982A0-0x00000001896982C0
		public int GetDepth() => default; // 0x0000000186D07C30-0x0000000186D07CD0
		// [XID] // 0x00000001898164B0-0x00000001898164D0
		private float GetInterpolatedHeight(float x, float z) => default; // 0x0000000186D07CD0-0x0000000186D07FA0
		// [XID] // 0x0000000189B1B950-0x0000000189B1B970
		private void MakeTextureReadable(Texture2D texture, bool isReadable) {} // 0x0000000186D084D0-0x0000000186D085C0
	}
}
