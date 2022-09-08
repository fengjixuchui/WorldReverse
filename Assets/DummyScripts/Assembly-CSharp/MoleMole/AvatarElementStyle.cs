/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[CreateAssetMenu] // 0x00000001896E9C00-0x00000001896E9C40
	public class AvatarElementStyle : ScriptableObject // TypeDefIndex: 19600
	{
		// Fields
		public AvatarStyle[] colors; // 0x18
		public AvatarMaterial[] materials; // 0x20
	
		// Nested types
		[Serializable]
		public class Style // TypeDefIndex: 19601
		{
			// Fields
			public Color emissionColor; // 0x10
			public float emissionScaler; // 0x20
			public AnimationCurve changeBreath; // 0x28
			public float changeBreathTime; // 0x30
	
			// Constructors
			public Style() {} // 0x0000000182DDB250-0x0000000182DDB2B0
		}
	
		[Serializable]
		public class AvatarMaterial // TypeDefIndex: 19602
		{
			// Fields
			public uint[] configIDs; // 0x10
			public BodyMaterialType materialIndex; // 0x18
	
			// Constructors
			public AvatarMaterial() {} // 0x0000000182DBFF30-0x0000000182DBFFA0
		}
	
		[Serializable]
		public class AvatarStyle // TypeDefIndex: 19603
		{
			// Fields
			public uint[] configIDs; // 0x10
			public Style none; // 0x18
			public Style fire; // 0x20
			public Style water; // 0x28
			public Style grass; // 0x30
			public Style electric; // 0x38
			public Style wind; // 0x40
			public Style ice; // 0x48
			public Style rock; // 0x50
	
			// Constructors
			public AvatarStyle() {} // 0x0000000182DC0210-0x0000000182DC0270
		}
	
		// Constructors
		public AvatarElementStyle() {} // 0x0000000182DBFED0-0x0000000182DBFF30
	
		// Methods
		// [IDTag] // 0x00000001896F2490-0x00000001896F24D0
		// [XID] // 0x00000001896F2490-0x00000001896F24D0
		public AvatarStyle GetStyle(uint configId) => default; // 0x0000000182DBFD30-0x0000000182DBFED0
		// [XID] // 0x00000001896FD090-0x00000001896FD0B0
		public AvatarMaterial GetAvatarMaterial(uint configId) => default; // 0x0000000182DBFAB0-0x0000000182DBFC50
		// [IDTag] // 0x0000000189704590-0x00000001897045D0
		// [XID] // 0x0000000189704590-0x00000001897045D0
		public Style GetStyle(uint configId, ElementType type) => default; // 0x0000000182DBFC50-0x0000000182DBFD30
		// [XID] // 0x000000018970F040-0x000000018970F060
		private Style GetAvatarStyle(AvatarStyle avatar, ElementType type) => default; // 0x0000000182DBF910-0x0000000182DBFAB0
	}
}
