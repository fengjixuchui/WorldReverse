/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace DigitalRuby.ThunderAndLightning
{
	public abstract class LightningBoltPathScriptBase : LightningBoltPrefabScriptBase // TypeDefIndex: 9653
	{
		// Fields
		// [Header] // 0x00000001896F36C0-0x00000001896F3720
		// [ReorderableList] // 0x00000001896F36C0-0x00000001896F3720
		public ReorderableList_GameObject LightningPath; // 0x1F0
		private readonly List<GameObject> currentPathObjects; // 0x1F8
	
		// Constructors
		protected LightningBoltPathScriptBase() {} // 0x000000018603A4F0-0x000000018603A580
	
		// Methods
		// [XID] // 0x0000000189B4F0B0-0x0000000189B4F0D0
		protected List<GameObject> GetCurrentPathObjects() => default; // 0x000000018603A140-0x000000018603A390
		// [XID] // 0x0000000189708330-0x0000000189708350
		protected override LightningBoltParameters OnCreateParameters() => default; // 0x000000018603A390-0x000000018603A480
	}
}
