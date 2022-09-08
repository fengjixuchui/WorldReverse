/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class EnviroCloudsLayer // TypeDefIndex: 31456
	{
		// Fields
		[NotSerialized] // 0x0000000189845E90-0x0000000189845EA0
		public Color debugColor; // 0x10
		public string layerName; // 0x20
		// [Range] // 0x00000001895F61C0-0x00000001895F61E0
		public int maxParticles; // 0x28
		// [Range] // 0x00000001895FD4C0-0x00000001895FD4E0
		public float particleLifeTime; // 0x2C
		// [MinMax] // 0x0000000189604E40-0x0000000189604E60
		public Vector2 particleFadeInAndOut; // 0x30
		// [MinMax] // 0x000000018960C850-0x000000018960C870
		public Vector2 particlePositionRange; // 0x38
		// [MinMax] // 0x0000000189613DB0-0x0000000189613DD0
		public Vector2 particleSizeRange; // 0x40
		public MaterialSpriteSlot[] materialSpriteSlots; // 0x48
	
		// Nested types
		[Serializable]
		public struct MaterialSpriteSlot // TypeDefIndex: 31457
		{
			// Fields
			public int id; // 0x00
			// [Range] // 0x0000000189927470-0x0000000189927490
			public float edgeSmoothness; // 0x04
			// [Range] // 0x0000000189927470-0x0000000189927490
			public float rimLightWidth; // 0x08
		}
	
		// Constructors
		public EnviroCloudsLayer() {} // 0x00000001814A8400-0x00000001814A8500
	
		// Methods
		// [XID] // 0x000000018961B780-0x000000018961B7A0
		public int GetRandomMaterialSpriteSlotID(int exclusiveSlotID) => default; // 0x00000001814A7E00-0x00000001814A7F30
		// [XID] // 0x0000000189622D00-0x0000000189622D20
		public MaterialSpriteSlot GetMaterialSpriteSlot(int id) => default; // 0x00000001814A7F30-0x00000001814A8070
		// [XID] // 0x000000018962A4F0-0x000000018962A510
		public float GetRamdomLifetime() => default; // 0x00000001814A8070-0x00000001814A8150
		// [XID] // 0x0000000189631C90-0x0000000189631CB0
		public Vector3 GetRandomPosition(int index, int count, bool useRandom) => default; // 0x00000001814A8150-0x00000001814A8340
		// [XID] // 0x00000001896397C0-0x00000001896397E0
		public float GetRandomSize() => default; // 0x00000001814A8340-0x00000001814A8400
	}
}
