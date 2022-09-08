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
	public class MonoIconSpriteAdsorbEffectDataSource : MonoBehaviour, AdsorbEffectDataSourceInterface // TypeDefIndex: 30617
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Sprite[] _spriteList; // 0x18
		private List<AdsorbEffectIconData> _currentIconObjectList; // 0x20
		private Stack<AdsorbEffectIconData> _availableIconObjectList; // 0x28
	
		// Properties
		public int DataCount { /* [XID] */ /* 0x0000000189AEF6F0-0x0000000189AEF710 */ get => default; } // 0x00000001846FD1C0-0x00000001846FD280 
	
		// Constructors
		public MonoIconSpriteAdsorbEffectDataSource() {} // 0x00000001846FD110-0x00000001846FD1C0
	
		// Methods
		// [XID] // 0x0000000189AF6C10-0x0000000189AF6C30
		public object GetEffectData(int index) => default; // 0x00000001846FCD80-0x00000001846FCE70
		// [XID] // 0x0000000189AFE140-0x0000000189AFE160
		public void Init() {} // 0x00000001846FCE70-0x00000001846FD110
	}
}
