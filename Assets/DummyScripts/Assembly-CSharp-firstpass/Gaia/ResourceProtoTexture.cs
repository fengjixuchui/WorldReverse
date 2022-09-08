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

namespace Gaia
{
	[Serializable]
	public class ResourceProtoTexture // TypeDefIndex: 9294
	{
		// Fields
		// [Tooltip] // 0x0000000189916A80-0x0000000189916AB0
		public string m_name; // 0x10
		// [Tooltip] // 0x000000018991E290-0x000000018991E2C0
		public Texture2D m_texture; // 0x18
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string m_textureFileName; // 0x20
		// [Tooltip] // 0x000000018992E9E0-0x000000018992EA10
		public Texture2D m_normal; // 0x28
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string m_normalFileName; // 0x30
		// [Tooltip] // 0x000000018993EF50-0x000000018993EF80
		public Texture2D m_detailHeight; // 0x38
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string m_detailHeightFileName; // 0x40
		// [Tooltip] // 0x000000018994F390-0x000000018994F3C0
		public float m_sizeX; // 0x48
		// [Tooltip] // 0x0000000189958610-0x0000000189958640
		public float m_sizeY; // 0x4C
		// [Tooltip] // 0x0000000189961550-0x0000000189961580
		public float m_offsetX; // 0x50
		// [Tooltip] // 0x0000000189961550-0x0000000189961580
		public float m_offsetY; // 0x54
		// [Range] // 0x0000000189970200-0x0000000189970260
		// [Tooltip] // 0x0000000189970200-0x0000000189970260
		public float m_metalic; // 0x58
		// [Range] // 0x000000018997C120-0x000000018997C170
		// [Tooltip] // 0x000000018997C120-0x000000018997C170
		public float m_smoothness; // 0x5C
		// [Tooltip] // 0x00000001899883B0-0x00000001899883E0
		public SpawnCritera[] m_spawnCriteria; // 0x60
		// [Tooltip] // 0x0000000189A1B030-0x0000000189A1B060
		public SpawnRuleExtension[] m_spawnExtensions; // 0x68
	
		// Constructors
		public ResourceProtoTexture() {} // 0x0000000185A04660-0x0000000185A04720
	
		// Methods
		// [XID] // 0x000000018999DA20-0x000000018999DA40
		public void Initialise(Spawner spawner) {} // 0x0000000185A044C0-0x0000000185A045C0
		// [XID] // 0x0000000189786240-0x0000000189786260
		public bool HasActiveCriteria() => default; // 0x0000000185A043B0-0x0000000185A044C0
		// [XID] // 0x00000001899A6CF0-0x00000001899A6D10
		public bool SetAssetAssociations() => default; // 0x0000000185A045C0-0x0000000185A04660
		// [XID] // 0x00000001898789D0-0x00000001898789F0
		public bool AssociateAssets() => default; // 0x0000000185A04090-0x0000000185A04130
		// [XID] // 0x00000001899B5C00-0x00000001899B5C20
		public bool ChecksTextures() => default; // 0x0000000185A04270-0x0000000185A043B0
		// [XID] // 0x0000000189738830-0x0000000189738850
		public bool ChecksProximity() => default; // 0x0000000185A04130-0x0000000185A04270
		// [XID] // 0x0000000189657B10-0x0000000189657B30
		public void AddTags(ref List<string> tagList) {} // 0x0000000185A03E70-0x0000000185A04090
	}
}
