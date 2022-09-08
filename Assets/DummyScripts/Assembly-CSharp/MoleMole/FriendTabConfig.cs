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
	[CreateAssetMenu] // 0x0000000189973FD0-0x0000000189974010
	public class FriendTabConfig : ScriptableObject // TypeDefIndex: 19639
	{
		// Fields
		public FriendMenuConfig[] menuConfig; // 0x18
	
		// Nested types
		[Serializable]
		public struct FriendMenuConfig // TypeDefIndex: 19640
		{
			// Fields
			public FriendPageType type; // 0x00
			public string nameTextID; // 0x08
			public string iconName; // 0x10
		}
	
		// Constructors
		public FriendTabConfig() {} // 0x0000000181F7F2C0-0x0000000181F7F320
	
		// Methods
		// [XID] // 0x000000018997C910-0x000000018997C930
		public FriendMenuConfig GetMenuTabConfig(FriendPageType type) => default; // 0x0000000181F7F110-0x0000000181F7F2C0
	}
}
