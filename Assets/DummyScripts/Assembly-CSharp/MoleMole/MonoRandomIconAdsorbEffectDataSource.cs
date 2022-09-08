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
	public class MonoRandomIconAdsorbEffectDataSource : MonoBehaviour, AdsorbEffectDataSourceInterface // TypeDefIndex: 30620
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int _dataCount; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private uint[] _randomIconList; // 0x20
		private List<uint> _currentIconList; // 0x28
		private List<AdsorbEffectIconData> _currentIconObjectList; // 0x30
	
		// Properties
		public int DataCount { /* [XID] */ /* 0x0000000189B488E0-0x0000000189B48900 */ get => default; } // 0x000000018442D4D0-0x000000018442D570 
	
		// Constructors
		public MonoRandomIconAdsorbEffectDataSource() {} // 0x000000018442D410-0x000000018442D4D0
	
		// Methods
		// [XID] // 0x0000000189B50010-0x0000000189B50030
		public object GetEffectData(int index) => default; // 0x000000018442CFB0-0x000000018442D0A0
		// [XID] // 0x0000000189B57820-0x0000000189B57840
		public void Init() {} // 0x000000018442D0A0-0x000000018442D410
	}
}
