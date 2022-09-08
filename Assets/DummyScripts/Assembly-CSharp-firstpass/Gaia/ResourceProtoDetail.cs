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
	public class ResourceProtoDetail // TypeDefIndex: 9286
	{
		// Fields
		// [Tooltip] // 0x0000000189916A80-0x0000000189916AB0
		public string m_name; // 0x10
		// [Tooltip] // 0x0000000189604CE0-0x0000000189604D10
		public DetailRenderMode m_renderMode; // 0x18
		// [Tooltip] // 0x000000018960DE40-0x000000018960DE70
		public GameObject m_detailProtoype; // 0x20
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string m_detailPrototypeFileName; // 0x28
		// [Tooltip] // 0x000000018961E450-0x000000018961E480
		public Texture2D m_detailTexture; // 0x30
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public string m_detailTextureFileName; // 0x38
		// [Tooltip] // 0x000000018962E920-0x000000018962E950
		public float m_minWidth; // 0x40
		// [Tooltip] // 0x0000000189637FB0-0x0000000189637FE0
		public float m_maxWidth; // 0x44
		// [Tooltip] // 0x0000000189640A00-0x0000000189640A30
		public float m_minHeight; // 0x48
		// [Tooltip] // 0x0000000189649B50-0x0000000189649B80
		public float m_maxHeight; // 0x4C
		// [Range] // 0x0000000189652960-0x00000001896529B0
		// [Tooltip] // 0x0000000189652960-0x00000001896529B0
		public float m_noiseSpread; // 0x50
		// [Range] // 0x000000018965E920-0x000000018965E970
		// [Tooltip] // 0x000000018965E920-0x000000018965E970
		public float m_bendFactor; // 0x54
		// [Tooltip] // 0x000000018966AA30-0x000000018966AA60
		public Color m_healthyColour; // 0x58
		// [Tooltip] // 0x0000000189673D10-0x0000000189673D40
		public Color m_dryColour; // 0x68
		// [Tooltip] // 0x000000018967CDF0-0x000000018967CE20
		public ResourceProtoDNA m_dna; // 0x78
		// [Tooltip] // 0x00000001899883B0-0x00000001899883E0
		public SpawnCritera[] m_spawnCriteria; // 0x80
		// [Tooltip] // 0x0000000189A1B030-0x0000000189A1B060
		public SpawnRuleExtension[] m_spawnExtensions; // 0x88
	
		// Constructors
		public ResourceProtoDetail() {} // 0x0000000185A02A10-0x0000000185A02AF0
	
		// Methods
		// [XID] // 0x0000000189698570-0x0000000189698590
		public void Initialise(Spawner spawner) {} // 0x0000000185A02860-0x0000000185A02970
		// [XID] // 0x000000018970D690-0x000000018970D6B0
		public bool HasActiveCriteria() => default; // 0x0000000185A02750-0x0000000185A02860
		// [XID] // 0x000000018986F310-0x000000018986F330
		public bool SetAssetAssociations() => default; // 0x0000000185A02970-0x0000000185A02A10
		// [XID] // 0x00000001896AE1B0-0x00000001896AE1D0
		public bool AssociateAssets() => default; // 0x0000000185A02430-0x0000000185A024D0
		// [XID] // 0x00000001896B58C0-0x00000001896B58E0
		public bool ChecksTextures() => default; // 0x0000000185A02610-0x0000000185A02750
		// [XID] // 0x00000001896BD7E0-0x00000001896BD800
		public bool ChecksProximity() => default; // 0x0000000185A024D0-0x0000000185A02610
		// [XID] // 0x0000000189794EE0-0x0000000189794F00
		public void AddTags(ref List<string> tagList) {} // 0x0000000185A02200-0x0000000185A02430
	}
}
