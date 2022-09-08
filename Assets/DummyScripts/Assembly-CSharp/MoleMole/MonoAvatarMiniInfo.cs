/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoAvatarMiniInfo : MonoSpriteProxy // TypeDefIndex: 30439
	{
		// Fields
		private const string AVATAR_PROPERTY_ITEM_PATH = "ART/UI/Menus/Widget/AvatarPropertyItem"; // Metadata: 0x00B10F93
		private List<MonoAvatarPropertyItem> _miniInfoList; // 0x20
	
		// Properties
		public List<MonoAvatarPropertyItem> miniInfoList { /* [XID] */ /* 0x0000000189930430-0x0000000189930450 */ get => default; } // 0x0000000184223540-0x00000001842235F0 
	
		// Constructors
		public MonoAvatarMiniInfo() {} // 0x00000001842234D0-0x0000000184223540
	
		// Methods
		// [XID] // 0x0000000189937900-0x0000000189937920
		public void Init() {} // 0x00000001842227B0-0x0000000184222B60
		// [XID] // 0x000000018993F3F0-0x000000018993F410
		public void UpdateRelicProp(Dictionary<FightPropType, float> propDict) {} // 0x0000000184223130-0x00000001842234D0
		// [XID] // 0x00000001899469E0-0x0000000189946A00
		public void UpdateAvatarProp(AvatarDataItem dataItem, bool isLocalPlayer) {} // 0x0000000184222B60-0x0000000184223130
	}
}
