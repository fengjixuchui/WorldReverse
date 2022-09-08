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
	public class ResourceProtoStamp // TypeDefIndex: 9293
	{
		// Fields
		// [Tooltip] // 0x00000001898BD750-0x00000001898BD780
		public string m_name; // 0x10
		// [Tooltip] // 0x00000001898C6780-0x00000001898C67B0
		public Texture2D m_texture; // 0x18
		// [Tooltip] // 0x0000000189961550-0x0000000189961580
		public bool m_stickToGround; // 0x20
		// [Tooltip] // 0x00000001898D8700-0x00000001898D8730
		public ResourceProtoDNA m_dna; // 0x28
		// [Tooltip] // 0x00000001899883B0-0x00000001899883E0
		public SpawnCritera[] m_spawnCriteria; // 0x30
	
		// Constructors
		public ResourceProtoStamp() {} // 0x0000000185A03D80-0x0000000185A03E10
	
		// Methods
		// [XID] // 0x00000001898A3340-0x00000001898A3360
		public void Initialise(Spawner spawner) {} // 0x0000000185A03C80-0x0000000185A03D80
		// [XID] // 0x00000001898F0F40-0x00000001898F0F60
		public bool HasActiveCriteria() => default; // 0x0000000185A03B70-0x0000000185A03C80
		// [XID] // 0x0000000189A8D790-0x0000000189A8D7B0
		public bool ChecksTextures() => default; // 0x0000000185A03A30-0x0000000185A03B70
		// [XID] // 0x00000001899001D0-0x00000001899001F0
		public bool ChecksProximity() => default; // 0x0000000185A038F0-0x0000000185A03A30
		// [XID] // 0x0000000189907880-0x00000001899078A0
		public void AddTags(ref List<string> tagList) {} // 0x0000000185A036D0-0x0000000185A038F0
		// [XID] // 0x000000018990F200-0x000000018990F220
		public void AddStamps(ref List<string> stampList) {} // 0x0000000185A035F0-0x0000000185A036D0
	}
}
