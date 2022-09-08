/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoAvatarBaseInfo : MonoBehaviour // TypeDefIndex: 30434
	{
		// Fields
		private const string QUALITY_ICON_FOUR_PREFAB_ROOT = "ART/UI/Menus/Widget/AvatarIcon_Quality4"; // Metadata: 0x00B10EE9
		private const string QUALITY_ICON_FIVE_PREFAB_ROOT = "ART/UI/Menus/Widget/AvatarIcon_Quality5"; // Metadata: 0x00B10F14
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _name; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _costLabel; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _level; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private UnityEngine.UI.Text _exp; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private SmoothMask _expFill; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoStarRate _starRate; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _qualityIconRoot; // 0x48
		private StringBuilder _expBuilder; // 0x50
		private GameObject _qualityIcon4; // 0x58
		private GameObject _qualityIcon5; // 0x60
	
		// Properties
		public GameObject qualityIcon4 { /* [XID] */ /* 0x0000000189830020-0x0000000189830040 */ get => default; } // 0x000000018421A740-0x000000018421A8E0 
		public GameObject qualityIcon5 { /* [XID] */ /* 0x00000001898377A0-0x00000001898377C0 */ get => default; } // 0x000000018421A8E0-0x000000018421AA80 
		public string avatarName { /* [XID] */ /* 0x00000001898464B0-0x00000001898464D0 */ set {} } // 0x000000018421AA80-0x000000018421AB50
		public int breakLevel { /* [XID] */ /* 0x000000018984DA80-0x000000018984DAA0 */ set {} } // 0x000000018421AB50-0x000000018421ACB0
		public uint cost { /* [XID] */ /* 0x0000000189854B00-0x0000000189854B20 */ set {} } // 0x000000018421ACB0-0x000000018421AE10
		public QualityType quality { /* [XID] */ /* 0x0000000189872380-0x00000001898723A0 */ set {} } // 0x000000018421AE10-0x000000018421B050
	
		// Constructors
		public MonoAvatarBaseInfo() {} // 0x000000018421A680-0x000000018421A740
	
		// Methods
		// [XID] // 0x000000018983EE70-0x000000018983EE90
		private void OnDestroy() {} // 0x000000018421A0F0-0x000000018421A260
		// [XID] // 0x000000018985C360-0x000000018985C380
		public void SetLevel(uint current, uint max) {} // 0x000000018421A420-0x000000018421A580
		// [XID] // 0x0000000189863CA0-0x0000000189863CC0
		public void SetExp(uint current, uint max) {} // 0x000000018421A260-0x000000018421A420
		// [XID] // 0x000000018986AFB0-0x000000018986AFD0
		public void ShowExp(bool show) {} // 0x000000018421A580-0x000000018421A680
	}
}
